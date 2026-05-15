using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using jkanime.Features.Animes.CreateAnime;
using jkanime.Infrastructure.Persistence;

namespace jkanime.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class AnimesController : ControllerBase
{
    private readonly CreateAnimeHandler _createHandler;

    public AnimesController(CreateAnimeHandler createHandler)
    {
        _createHandler = createHandler;
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create([FromBody] CreateAnimeRequest request)
    {
        try
        {
            var result = await _createHandler.HandleAsync(request);

            return CreatedAtAction(
                nameof(Create),
                new { id = result.Id },
                result);
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(new
            {
                message = ex.Message
            });
        }
    }
}