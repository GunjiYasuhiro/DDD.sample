using DDD.sample.WebApp.Application.Users;
using DDD.sample.WebApp.Controllers.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DDD.sample.WebApp.Controllers
{
  [ApiController]
  [Route("[controller")]
  public class UserController : ControllerBase
  {
    private readonly UserApplicationService userApplicationService;
    public UserController(UserApplicationService userApplicationService)
    {
      this.userApplicationService = userApplicationService;
    }

    [HttpGet("{id}")]
    public UserGetResponseModel Get(int id)
    {
      var command = new UserGetCommand(id);
      var result = userApplicationService.Get(command);
      return new UserGetResponseModel(result);
    }
  }
}
