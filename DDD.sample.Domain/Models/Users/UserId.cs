using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.sample.Domain.Models.Users
{
  public class UserId
  {
    public UserId(int value)
    {
      Value = value;
    }
    public int Value { get; }
  }
}
