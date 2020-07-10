namespace DDD.sample.WebApp.Application.Users
{
  public class UserGetResult
  {
    public UserGetResult(UserData user)
    {
      User = user;
    }

    public UserData User { get; set; }
  }
}