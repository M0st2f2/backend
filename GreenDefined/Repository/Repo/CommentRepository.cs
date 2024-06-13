using GreenDefined.Models.Data;
using GreenDefined.Models;
using GreenDefined.Repository.GenericRepo;
using GreenDefined.Repository.IRepo;
using Microsoft.EntityFrameworkCore;

namespace GreenDefined.Repository.Repo
{
    public class CommentRepository : GenericRepositoryAsync<Comment>, ICommentRepository
    {
        private readonly DbSet<Comment> comments;
        public CommentRepository(AppDbContext db) : base(db)
        {
            comments = db.Set<Comment>();
        }


    }
}
