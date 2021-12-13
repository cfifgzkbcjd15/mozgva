using mozgva.Controllers;
using mozgva.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mozgva.Services
{
    public class UserService:IUserService
    {
        public bool IsValidUserInformation(LoginModel model)
        {
            if (model.UserName.Equals("Pyaliska") && model.Password.Equals("")) return true;
            else return false;
        }
    }
}
