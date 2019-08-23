

namespace WebAPI.Models.Data
{
    public interface IUserRepository
    {

        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();

        UserDetail[] GetAllUsers();
        
    }
}
