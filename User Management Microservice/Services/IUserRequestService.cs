using User_Management_Microservice.Model;

namespace User_Management_Microservice.Services
{
    public interface IUserRequestService
    {
        List<AppUser> GetUserList();
        List<AppUser> GetServiceRequestDetailsByUserId(int userId);
        bool SaveUser(AppUser serviceReqModel);
        bool DeleteUser(int id);
        bool UpdateUser(AppUser serviceReqModel);
    }
}

