using GreenDefined.Models.Data;
using GreenDefined.Models;
using GreenDefined.Repository.GenericRepo;
using GreenDefined.Repository.IRepo;
using Microsoft.EntityFrameworkCore;

namespace GreenDefined.Repository.Repo
{
    public class NotificationTransactionRepository : GenericRepositoryAsync<NotificationTransaction>, INotificationTransactionRepository
    {
        private readonly DbSet<NotificationTransaction> noty;
        public NotificationTransactionRepository(AppDbContext db) : base(db)
        {
            noty = db.Set<NotificationTransaction>();
        }
    }
}
