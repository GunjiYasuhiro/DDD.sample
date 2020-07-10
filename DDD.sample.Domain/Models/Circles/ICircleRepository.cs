using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.sample.Domain.Models.Circles
{
  public interface ICircleRepository
  {
    void Save(Circle circle);
    Circle Find(CircleId id);
    Circle Find(CircleName name);
  }
}
