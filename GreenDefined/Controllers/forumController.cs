using GreenDefined.DTOs.Comments;
using GreenDefined.DTOs.Posts;
using GreenDefined.DTOs.Reacts;
using GreenDefined.Migrations;
using GreenDefined.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreenDefined.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class forumController : ControllerBase
    {
        #region Fields
        private readonly IPostService _postService;
        private readonly ICommentService _commentService;
        private readonly IReactService _reactService;
        #endregion

        #region Ctor
        public forumController(IPostService postService, ICommentService commentService, IReactService reactService)
        {
            _postService = postService;
            _commentService = commentService;
            _reactService = reactService;

        }
        #endregion

        #region Handle Functions
        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> AddPost([FromForm] AddPostDTO postDTO)
        {
            var response = await _postService.AddPost(postDTO);
            if (response == "Success") return Ok();
            return BadRequest(response);
        }

        [HttpGet("[action]")]
        [Authorize]
        public async Task<IActionResult> GetPosts()
        {
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "userId");


            // Remove {userId: } and extract userId
            string userId = userIdClaim.ToString().Substring(userIdClaim.ToString().IndexOf(":") + 1).Trim();
            var response = await _postService.GetPosts(userId.ToString());
            return Ok(response);
        }

        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> AddComment(AddCommentDTO DTO)
        {
            await _commentService.AddComment(DTO);
            return Ok();
        }
        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> AddReact(AddReactDTO DTO)
        {
            var response = await _reactService.AddReact(DTO);
            if (response == "Success"||response== "Deleted Saccessfuly") return Ok(response);
            return BadRequest(response);
        }

        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> GetPostDetail(int PostId)
        {
            var response = await _postService.GetPostDetail(PostId);
            return Ok(response);
        }
        #endregion
    }
}
