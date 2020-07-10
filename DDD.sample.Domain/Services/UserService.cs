using DDD.sample.Domain.Models.Users;
using System.Reflection.Metadata;

namespace DDD.sample.Domain.Services
{
  public class UserService
  {
    private readonly IUserRepository userRepository;

    public UserService(IUserRepository userRepository)
    {
      this.userRepository = userRepository;
    }
    public bool Exist(User user)
    {
      var duplicatedUser = userRepository.Find(user.Name);
      return duplicatedUser != null;
    }
  }
}