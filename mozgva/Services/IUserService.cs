using mozgva.Controllers;
using mozgva.ViewModels;

namespace mozgva.Services
{
        public interface IUserService
    {
        bool IsValidUserInformation(LoginModel model);
    }

}