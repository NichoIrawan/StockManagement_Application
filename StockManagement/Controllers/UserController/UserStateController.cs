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
                    
                }
            }
        }

        public class StaffState : IUserState
        {
            public void transitionState(UserStateController context, int userType)
            {
                switch (userType)
                {
                   
                }
            }
        }

        public class ManagerState : IUserState
        {
            public void transitionState(UserStateController context, int userType)
            {
                switch (userType)
                {
                  
                }
            }
        }

        public class AdminState : IUserState
        {
            public void transitionState(UserStateController context, int userType)
            {
                switch (userType)
                {
                }
            }
        }
        public interface IUserState
        {
            void transitionState(UserStateController controller, int userType);
        }

    }
}
