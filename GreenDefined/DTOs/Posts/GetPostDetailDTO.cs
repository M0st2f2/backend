namespace GreenDefined.DTOs.Posts
{
    public class GetPostDetailDTO
    {
        public int PostId { get; set; }
        public string PostBody { get; set; }

        public string PostImageURL { get; set; }

        public DateTime PostDate { get; set; }

        public string UserCountry { get; set; }
        public string UserName { get; set; }

        public string UserImageURL { get; set; }

        public int LikesCount { get; set; }
        public int DisLikesCount { get; set; }

        public ICollection<PostCommentsDTO> Comments { get; set; }
    }
    public class PostCommentsDTO
    {
        public int CommentID { get; set; }
        public string CommentText { get; set; }

        public string UserImageUrl { get; set; }
        public string UserName { get; set; }
        public string UserCounrty { get; set; }

        public DateTime CommentDate { get; set; }
    }
}
