using GreenDefined.DTOs.UserDTos.Edit;
using GreenDefined.DTOs.UserDTos.Login;
using GreenDefined.DTOs.UserDTos.Password;
using GreenDefined.DTOs.UserDTos.Register;
using GreenDefined.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreenDefined.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        #region Fields
        private readonly IAuthService _authService;
        #endregion

        #region Ctor
        public AccountController(IAuthService authService)
        {
            _authService = authService;
        }
        #endregion

        #region Hanlde Functions
        [HttpPost("[action]")]
        public async Task<IActionResult> Register(RegisterDTO DTO)
        {
            var result = await _authService.RegisterAsync(DTO);
            if (result.message == "Existing") return BadRequest(new { code = result.message, message = result.error });
            if (result.message == "Password") return BadRequest(new { code = result.message, message = result.error });
            if (result.message == "Falid Save Verify Code") return BadRequest(new { code = result.message, message = result.error });
            if (result.message == "Password") return BadRequest(new { code = result.message, message = result.error });
            return Ok("Success");
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> ConfirmAccount(CodeConfirm DTO)
        {
            var result = await _authService.ConfirmingAccount(DTO);
            if (result == "Success") return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginDTO DTO)
        {
            var result = await _authService.Login(DTO);
            if (!result.IsAuthenticated) return BadRequest(result.Message);
            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetUserData(string userId)
        {
            var response = await _authService.GetUserData(userId);
            return Ok(response);
        }

        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> LogOut(string userID)
        {
            var response = await _authService.LogOut(userID);
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> SendForgetPasswordOTP(string Email)
        {
            var response = await _authService.SendOTPForgetPassword(Email);
            if (response == "NoUser") return BadRequest("No User with this Email!");
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CheckForgetPasswordOTP(string Email, int Code)
        {
            var response = await _authService.CheckForgetPasswordOTP(Email, Code);
            if (response == "Success") return Ok();
            return BadRequest(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddingNewPassword(AddNewPasswordDTO dTO)
        {
            var response = await _authService.AddNewPassword(dTO);
            if (response == "Success") return Ok();
            return BadRequest(response);
        }

        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> ChangePassword(ChangePasswordDTO dTO)
        {
            var response = await _authService.ChangePassword(dTO);
            if (response == "Success") return Ok();
            return BadRequest(response);
        }

        [HttpPut("[action]")]
        [Authorize]
        public async Task<IActionResult> EditProfile([FromForm] EditProfileDTO DTO)
        {
            var response = await _authService.EditProfile(DTO);
            if (response == "Success") return Ok();
            return BadRequest();

        }
        #endregion
    }
}
