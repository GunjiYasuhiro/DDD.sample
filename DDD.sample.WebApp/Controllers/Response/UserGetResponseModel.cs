using DDD.sample.Domain.Models.Users;
using DDD.sample.WebApp.Application.Users;

namespace DDD.sample.WebApp.Controllers.Response
{
  public class UserGetResponseModel
  {
    public UserGetResponseModel(UserGetResult user)
    {
      User = user;
    }

    public UserGetResult User { get; set; }
  }
}