using DDD.sample.Domain.Models.Users;
using DDD.sample.Domain.Services;
using System;
using System.Transactions;

namespace DDD.sample.WebApp.Application.Users
{
  public class UserApplicationService
  {
    private readonly UserService userService;
    private readonly IUserFactory userFactory;
    private readonly IUserRepository userRepository;

    public UserApplicationService(UserService userService, IUserFactory userFactory, IUserRepository userRepository)
    {
      this.userService = userService;
      this.userFactory = userFactory;
      this.userRepository = userRepository;
    }

    public UserGetResult Get(UserGetCommand command)
    {
      var id = new UserId(command.Id);
      var user = userRepository.Find(id);
      if(user == null)
      {
        throw new Exception();
      }
      var data = new UserData(user);
      return new UserGetResult(data);
    }

    public UserRegisterResult Register(UserRegisterCommand command)
    {
      using (var transaction = new TransactionScope())
      {
        var name = new UserName(command.UserName);
        var user = userFactory.Create(name);
        if (userService.Exist(user))
        {
          throw new Exception("ユーザーは既に存在しています。");
        }
        userRepository.Save(user);
        transaction.Complete();
        return new UserRegisterResult(user.Id.Value);
      }
    }
  }
}