using DDD.sample.Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DDD.sample.WebApp.Application.Circles
{
  public class CircleCreateCommand
  {
    public CircleCreateCommand(int userId, string name)
    {
      UserId = userId;
      Name = name;
    }
    public int UserId { get; }
    public string Name { get; }
  }
}
