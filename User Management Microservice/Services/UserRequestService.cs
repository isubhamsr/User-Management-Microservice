using Microsoft.EntityFrameworkCore;
using User_Management_Microservice.Model;

namespace User_Management_Microservice.Services
{
    public class UserRequestService : IUserRequestService
    {
        private ApplicationDbContex _context;

        public UserRequestService(ApplicationDbContex context)
        {
            _context = context;
        }
        public bool DeleteUser(int id)
        {
            try
            {
                var service = _context.AppUsers.Where(p => p.Id == id).FirstOrDefault();
                if (service != null)
                {
                    _context.Entry(service).State = EntityState.Deleted;
                    _context.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
       
        public List<AppUser> GetServiceRequestDetailsByUserId(int userId)
        {
            List<AppUser> services = new List<AppUser>();
            try
            {
                services = _context.AppUsers.Where(p => p.Id == userId).ToList();
                return services;
            }
            catch (Exception ex)
            {

                throw new Exception();
            }
        }

        public List<AppUser> GetUserList()
        {
            List<AppUser> services = new List<AppUser>();
            try
            {
                services = _context.AppUsers.ToList();

                return services;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public bool SaveUser(AppUser serviceReqModel)
        {
            try
            {
                if (serviceReqModel != null)
                {
                    _context.AppUsers.Add(serviceReqModel);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateUser(int id, AppUser serviceReqModel)
        {
            try
            {
                var service = _context.AppUsers.Where(p => p.Id == id).FirstOrDefault();
                if (service != null)
                {
                    service.Email = serviceReqModel.Email;
                    service.Name = serviceReqModel.Name;
                    service.Mobile = serviceReqModel.Mobile;
                    service.Registrationdate = serviceReqModel.Registrationdate;

                    _context.Entry(service).State = EntityState.Modified;
                    _context.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}

