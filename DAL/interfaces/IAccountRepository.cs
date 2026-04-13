using CourseRegistration.DTO.Entities;

namespace CourseRegistration.DAL.Interfaces
{
    /// <summary>
    /// Interface cho Account Repository
    /// </summary>
    public interface IAccountRepository
    {
        Account GetByUsername(string username);
        Account GetById(int accountId);
        bool UpdateLastLogin(int accountId);
        bool Create(Account account);
        bool Update(Account account);
        bool Delete(int accountId);
    }
}
