using GreenDefined.Models.Data;
using GreenDefined.Models;
using GreenDefined.Repository.GenericRepo;
using GreenDefined.Repository.IRepo;
using Microsoft.EntityFrameworkCore;

namespace GreenDefined.Repository.Repo
{
    public class ReactRepository : GenericRepositoryAsync<React>, IReactRepository
    {
        private readonly DbSet<React> reacts;
        public ReactRepository(AppDbContext db) : base(db)
        {
            reacts = db.Set<React>();
        }


    }
}
