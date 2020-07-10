using DDD.sample.Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.sample.Domain.Models.Circles
{
  public class Circle
  {
    public Circle(CircleId id, CircleName name, User owner, List<User> members)
    {
      Id = id ?? throw new ArgumentException(nameof(id));
      Name = name ?? throw new ArgumentException(nameof(name));
      Owner = owner ?? throw new ArgumentException(nameof(owner));
      Members = members ?? throw new ArgumentException(nameof(members));
    }
    public CircleId Id { get; }
    public CircleName Name { get; private set; }
    public User Owner { get; private set; }
    public List<User> Members { get; private set; }
  }
}
