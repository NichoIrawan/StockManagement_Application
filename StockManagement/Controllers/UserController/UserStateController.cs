using StockManagement.Controller.UserController;
using StockManagement.View;

namespace StockManagement.Controllers.UserController
{
    public class UserStateController
    {
        public IUserState currentState;
        public AdminController adminController;
        public ManagerController managerController;
        public StaffController staffController;


        public UserStateController()
        {
            currentState = new NoneState();
        }

        public void SetState(IUserState state)
        {
            currentState = state;
        }

        public void ChangeState(int userType)
        {
            currentState.transitionState(this, userType);
        }

        public class NoneState : IUserState
        {
            public void transitionState(UserStateController context, int userType)
            {
                switch (userType)
                {
                    case 1:
                        var staffView = new StaffView(context.staffController);
                        staffView.callMenu();
                        break;
                    case 2:
                        context.SetState(new ManagerState());
                        var managerView = new ManagerView(context.managerController);
                        managerView.callMenu();
                        break;
                    case 3:
                        context.SetState(new AdminState());
                        var adminView = new AdminView(context.adminController);
                        adminView.callMenu();
                        break;
                }
            }
        }

        public class StaffState : IUserState
        {
            public void transitionState(UserStateController context, int userType)
            {
                switch (userType)
                {
                    case 2:
                        context.SetState(new ManagerState());
                        var managerView = new ManagerView(context.managerController);
                        managerView.callMenu();
                        break;
                    case 3:
                        context.SetState(new AdminState());
                        var adminView = new AdminView(context.adminController);
                        adminView.callMenu();
                        break;
                }
            }
        }

        public class ManagerState : IUserState
        {
            public void transitionState(UserStateController context, int userType)
            {
                switch (userType)
                {
                    case 1:
                        context.SetState(new StaffState());
                        var staffView = new StaffView(context.staffController);
                        staffView.callMenu();
                        break;
                    case 3:
                        context.SetState(new AdminState());
                        var adminView = new AdminView(context.adminController);
                        adminView.callMenu();
                        break;
                }
            }
        }

        public class AdminState : IUserState
        {
            public void transitionState(UserStateController context, int userType)
            {
                switch (userType)
                {
                    case 1:
                        context.SetState(new StaffState());
                        var staffView = new StaffView(context.staffController);
                        staffView.callMenu();
                        break;
                    case 2:
                        context.SetState(new ManagerState());
                        var managerView = new ManagerView(context.managerController);
                        managerView.callMenu();
                        break;
                }
            }
        }
        public interface IUserState
        {
            void transitionState(UserStateController controller, int userType);
        }

    }
}
