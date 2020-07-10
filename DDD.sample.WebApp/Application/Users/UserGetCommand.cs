using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDD.sample.WebApp.Application.Users
{
  public class UserGetCommand
  {
    public UserGetCommand(int id)
    {
      Id = id;
    }
    public int Id { get; set; }
  }
}
