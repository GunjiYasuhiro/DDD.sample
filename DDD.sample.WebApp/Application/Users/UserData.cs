using DDD.sample.Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDD.sample.WebApp.Application.Users
{
  public class UserData
  {
    public UserData(User user)
    {
      User = user;
    }
    public User User { get; set; }
  }
}
