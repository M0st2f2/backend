namespace GreenDefined.DTOs.Posts
{
    public class GetPostsDTO
    {
        public int postId { get; set; }
        public string postValue { get; set; }
        public string postImageURL { get; set; }
        public string userName { get; set; }
        public string? userImageURL { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CommentsCount { get; set; }

        public string LikeStatus { get; set; }

    }
}
