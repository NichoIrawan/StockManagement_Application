using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using StockManagement.View;
using StockManagement.Models;
using StockManagementLibrary;
using System.Collections.Generic;

namespace StockManagement.Tests
{
    [TestClass]
    public class StartupViewTests
    {
        [TestInitialize]
        public void Setup()
        {
            // Set bahasa agar Localization.Get tidak error
            Localization.SetLanguage("en");
        }

        [TestMethod]
        public void Login_ValidCredentials_ShouldLoginSuccessfully()
        {
            // Arrange
            var view = new StartupView();

            // Tambahkan user ke userList secara refleksi
            var userListField = typeof(StartupView).GetField("userList", BindingFlags.NonPublic | BindingFlags.Instance);
            var userList = (List<User>)userListField.GetValue(view);
            userList.Add(new User("admin", "Admin", Roles.Admin, "admin123"));

            // Simulasi input
            var input = new StringReader("admin\nadmin123\n");
            Console.SetIn(input);

            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            var loginMethod = typeof(StartupView).GetMethod("Login", BindingFlags.NonPublic | BindingFlags.Instance);
            loginMethod.Invoke(view, null);

            // Assert
            string consoleOutput = output.ToString();
            Assert.IsTrue(consoleOutput.Contains("Login successful") || consoleOutput.Contains("LoginSuccesful"));
            Assert.IsTrue(consoleOutput.Contains("Admin"));
        }

        [TestMethod]
        public void Login_InvalidCredentials_ShouldShowInvalidLoginMessage()
        {
            // Arrange
            var view = new StartupView();

            var input = new StringReader("wronguser\nwrongpass\n0\n"); // input terakhir untuk keluar dari callMenu
            Console.SetIn(input);

            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            var loginMethod = typeof(StartupView).GetMethod("Login", BindingFlags.NonPublic | BindingFlags.Instance);
            try
            {
                loginMethod.Invoke(view, null);
            }
            catch (TargetInvocationException) { /* ignore Environment.Exit */ }

            // Assert
            string consoleOutput = output.ToString();
            Assert.IsTrue(consoleOutput.Contains("InvalidLogin"));
        }

        [TestMethod]
        public void Register_ShouldAddNewUserToList()
        {
            // Arrange
            var view = new StartupView();

            // Siapkan input: username, name, password, role, lalu input untuk callMenu ? Exit
            var input = new StringReader("testuser\nTest Name\npassword123\n1\n0\n");
            Console.SetIn(input);

            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            var registerMethod = typeof(StartupView).GetMethod("Register", BindingFlags.NonPublic | BindingFlags.Instance);
            try
            {
                registerMethod.Invoke(view, null);
            }
            catch (TargetInvocationException) { /* ignore Environment.Exit */ }

            // Assert
            var userListField = typeof(StartupView).GetField("userList", BindingFlags.NonPublic | BindingFlags.Instance);
            var userList = (List<User>)userListField.GetValue(view);

            var createdUser = userList.FirstOrDefault(u => u.username == "testuser");
            Assert.IsNotNull(createdUser);
            Assert.AreEqual("Test Name", createdUser.name);
            Assert.AreEqual("password123", createdUser.password);
            Assert.AreEqual(Roles.Staff, createdUser.role);
        }
    }
}
