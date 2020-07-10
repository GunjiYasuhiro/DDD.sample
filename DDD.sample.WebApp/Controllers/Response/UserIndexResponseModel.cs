using System.Collections.Generic;

namespace DDD.sample.WebApp.Controllers.Response
{
  public class UserIndexResponseModel
  {
    public UserIndexResponseModel(List<UserResponseModel> users)
    {
      Users = users;
    }

    public List<UserResponseModel> Users { get; set; }
  }
}