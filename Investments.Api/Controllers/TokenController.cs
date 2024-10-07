using AutoMapper;
using Investments.Api.Models;
using Investments.Application.Interfaces;
using Investments.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Investments.Api.Controllers
{
    [Route("api/tokens")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public TokenController(ITokenService tokenService, IMapper mapper)
        {
            _tokenService = tokenService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(TokenModel tokenModel)
        {
            var token = _mapper.Map<Token>(tokenModel);

            return Ok(await _tokenService.CreateAsync(token));
        }

        [HttpGet]
        public async Task<IActionResult> RetrieveAsync()
        {
            var tokens = _mapper.Map<IEnumerable<TokenModel>>(await _tokenService.RetrieveAsync());

            return Ok(tokens);
        }
    }
}
