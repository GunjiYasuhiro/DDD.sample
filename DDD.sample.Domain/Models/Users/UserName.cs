using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.sample.Domain.Models.Users
{
  public class UserName : IEquatable<UserName>
  {
    public UserName(string value)
    {
      if (value == null) throw new ArgumentException(nameof(value));
      if (value.Length < 3) throw new ArgumentException("ユーザー名は3文字以上です。", nameof(value));
      Value = value;
    }
    public string Value { get; }
    public bool Equals(UserName other)
    {
      if (other is null) return false;
      if (ReferenceEquals(this, other)) return true;
      return string.Equals(Value, other.Value);
    }
    public override bool Equals(object obj)
    {
      if (obj is null) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((UserName)obj);
    }
    public override int GetHashCode()
    {
      return HashCode.Combine(Value);
    }
  }
}
