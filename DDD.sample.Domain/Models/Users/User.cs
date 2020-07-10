using System;
using System.Collections.Generic;

namespace DDD.sample.Domain.Models.Users
{
  public class User
  {
    public User(UserId id, UserName name, UserTypeEnum type)
    {
      Id = id ?? throw new ArgumentException(nameof(id));
      Name = name ?? throw new ArgumentException(nameof(name));
      Type = type;
    }

    public UserId Id { get; }
    public UserName Name { get; private set; }
    public UserTypeEnum Type { get; private set; }
  }
}