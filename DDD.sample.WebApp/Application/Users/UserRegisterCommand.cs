using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDD.sample.WebApp.Application.Users
{
  public class UserRegisterCommand
  {
    public UserRegisterCommand(string userName)
    {
      UserName = userName;
    }
    public string UserName { get; set; }
  }
}
