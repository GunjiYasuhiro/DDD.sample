using DDD.sample.Domain.Models.Circles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DDD.sample.WebApp.Application.Circles
{
  public class CircleApplicationService
  {
    private readonly ICircleRepository circleRepository;
    public CircleApplicationService(ICircleRepository circleRepository)
    {
      this.circleRepository = circleRepository;
    }

  }
}
