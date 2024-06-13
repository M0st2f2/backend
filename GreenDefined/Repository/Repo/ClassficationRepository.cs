using GreenDefined.Models.Data;
using GreenDefined.Models;
using GreenDefined.Repository.GenericRepo;
using GreenDefined.Repository.IRepo;
using Microsoft.EntityFrameworkCore;

namespace GreenDefined.Repository.Repo
{
    public class ClassficationRepository : GenericRepositoryAsync<ClassificationImage>, IClassficationRepository
    {
        private readonly DbSet<ClassificationImage> classifications;
        public ClassficationRepository(AppDbContext db) : base(db)
        {
            classifications = db.Set<ClassificationImage>();
        }


    }
}
