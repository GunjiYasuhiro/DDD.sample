using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.sample.Domain.Models.Users
{
  public interface IUserFactory
  {
    User Create(UserName name);
  }
}
