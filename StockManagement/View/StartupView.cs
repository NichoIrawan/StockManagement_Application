using StockManagement.Controllers.UserController;
using StockManagement.Models;
using StockManagementLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockManagement.View
{
    public class StartupView
    {
        UserStateController cont = new UserStateController();
        List<User> userList = new List<User>();

        public StartupView() {
        }

        public void selectLanguage() {

            BahasaConfig bahasaConfig = new BahasaConfig();
            var conf = bahasaConfig.GetCurrentLanguage();
            if (conf == Bahasa.Indonesia)
            {
                Localization.SetLanguage("id");
            }
            else {
                Localization.SetLanguage("en");
            }
            Console.WriteLine(Localization.Get("ChooseLang"));
            Console.WriteLine("1. English");
            Console.WriteLine("2. Bahasa Indonesia");
            string langChoice = Console.ReadLine();
            if (langChoice == "1")
            {
                conf = Bahasa.English;
            }
            else {
                conf = Bahasa.Indonesia;
            }
            bahasaConfig.ChangeLanguage(conf);
            if (conf == Bahasa.Indonesia)
            {
                Localization.SetLanguage("id");
            }
            else
            {
                Localization.SetLanguage("en");
            }
        }

        public void callMenu()
        {
            
            Console.WriteLine(Localization.Get("WelcomeMessage"));
            Console.WriteLine(Localization.Get("LoginRegisterPrompt"));
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("0. Keluar\n");

            var menuActions = new Dictionary<string, Action>
    {
        { "1", Login },
        { "2", Register },
        { "0", () => {
            Console.WriteLine(Localization.Get("ExitMessage"));
            Environment.Exit(0); // keluar dari aplikasi
        }}
    };

            string input = Console.ReadLine();

            if (menuActions.ContainsKey(input))
                menuActions[input].Invoke();
            else
            {
                Console.WriteLine(Localization.Get("LoginRegisterPrompt\n"));
                callMenu();
            }
        }


        private void Login()
        {
            Console.WriteLine(Localization.Get("EnterUsername"));
            string username = Console.ReadLine();
            Console.WriteLine(Localization.Get("EnterPassword"));
            string password = Console.ReadLine();

            User foundUser = userList.FirstOrDefault(u => u.username.Equals(username) && u.password.Equals(password));

            if (foundUser != null)
            {
                Console.WriteLine(Localization.Get("LoginSuccesful") + " " +  foundUser.role);
                cont.ChangeState(
                    foundUser.role == Roles.Staff ? 1 :
                    foundUser.role == Roles.Manager ? 2 : 3);
            }
            else
            {
                Console.WriteLine(Localization.Get("InvalidLogin"));
                callMenu();
            }
        }

        private void Register()
        {
            Console.WriteLine(Localization.Get("EnterUsername"));
            string username = Console.ReadLine();
            Console.WriteLine(Localization.Get("EnterName"));
            string name = Console.ReadLine();
            Console.WriteLine(Localization.Get("EnterPassword"));
            string password = Console.ReadLine();
            Console.WriteLine(Localization.Get("EnterRole"));
            string roleInput = Console.ReadLine();

            Roles role = roleInput == "1" ? Roles.Staff :
                         roleInput == "2" ? Roles.Manager :
                         Roles.Admin;

            User newUser = new User(username, name, role, password);
            userList.Add(newUser);

            Console.WriteLine("Registrasi berhasil! Silakan login kembali.\n");
            callMenu();
        }
    }
}
