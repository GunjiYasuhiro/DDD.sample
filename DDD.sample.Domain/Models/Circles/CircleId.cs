using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.sample.Domain.Models.Circles
{
  public class CircleId
  {
    public CircleId(string value)
    {
      Value = value ?? throw new ArgumentException(nameof(value));
    }
    public string Value { get; }
  }
}
