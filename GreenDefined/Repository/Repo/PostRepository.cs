using GreenDefined.Models.Data;
using GreenDefined.Models;
using GreenDefined.Repository.GenericRepo;
using GreenDefined.Repository.IRepo;
using Microsoft.EntityFrameworkCore;

namespace GreenDefined.Repository.Repo
{
    public class PostRepository : GenericRepositoryAsync<Post>, IPostRepository
    {
        private readonly DbSet<Post> posts;
        public PostRepository(AppDbContext db) : base(db)
        {
            posts = db.Set<Post>();
        }


    }
}
