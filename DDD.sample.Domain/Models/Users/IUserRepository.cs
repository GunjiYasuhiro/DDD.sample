using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.sample.Domain.Models.Users
{
  public interface IUserRepository
  {
    void Save(User user);
    User Find(UserId id);
    User Find(UserName name);
  }
}
