using Microsoft.AspNetCore.Mvc;
using Messenger.Application.UseCases.RegisterUser;

namespace Messenger.WebAPI.Controllers;

// Контроллер только принимает HTTP и вызывает handler из Application. Бизнес-логики здесь нет.

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly RegisterUserHandler _registerUserHandler;

    public UsersController(RegisterUserHandler registerUserHandler)
    {
        _registerUserHandler = registerUserHandler;
    }

    [HttpPost("register")]
    public async Task<ActionResult<Guid>> Register([FromBody] RegisterUserRequest request, CancellationToken ct)
    {
        var command = new RegisterUserCommand(request.UserName, request.Email, request.Password);
        var id = await _registerUserHandler.HandleAsync(command, ct);
        return Ok(id);
    }
}

public record RegisterUserRequest(string UserName, string Email, string Password);
