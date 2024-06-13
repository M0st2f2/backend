using GreenDefined.DTOs.Classfication;
using GreenDefined.Models;
using GreenDefined.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GreenDefined.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassficationController : ControllerBase
    {
        #region Fields
        private readonly IClassficationService _classfication;
        private readonly UserManager<ApplicationUser> _userManager; 
        #endregion

        #region Ctor
        public ClassficationController(IClassficationService classfication, UserManager<ApplicationUser> userManager)
        {
            _classfication = classfication;
            _userManager = userManager;
        }
        #endregion

        #region Hanlde Functions
        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> AddImage(SavingImageDTO DTO)
        {
            var response = await _classfication.SavingImage(DTO.Image);
            if (response == 0) return BadRequest();
            SavingImageResponseDTO responseDTO = new SavingImageResponseDTO() { id = response };
            return Ok(responseDTO);
        }

        [HttpGet("[action]")]
        [Authorize]
        public async Task<IActionResult> GetImageDetaild([FromQuery] ClassficationImageDTO DTO)
        {
            var response = await _classfication.HandleClassfication(DTO);

            return Ok(response);//ClassficationImageResponseDTO
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> AhmedTripleMohamedMosad()
        {
            var response = await _userManager.Users.ToListAsync();
            return Ok(response);
        }
        #endregion
    }
}
