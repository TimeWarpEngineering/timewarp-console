﻿namespace TimeWarp.Blazor.Server.Integration.Tests.Features.WeatherForecast.GetAll
{
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System;
  using System.Threading.Tasks;
  using TimeWarp.Blazor.Api.Features.WeatherForecast;
  using TimeWarp.Blazor.Server.Integration.Tests.Infrastructure;

  internal class GetAllWeatherForecastsTests
  {
    private readonly IMediator Mediator;
    private readonly IServiceProvider ServiceProvider;

    public GetAllWeatherForecastsTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
    }

    public async Task ShouldGetAllWeatherForecasts()
    {
      // Arrange
      var getWeatherForecastsRequest = new GetWeatherForecastsRequest { Days = 10 };

      //Act
      GetWeatherForecastsResponse getWeatherForecastsResponse =
        await Mediator.Send(getWeatherForecastsRequest);

      //Assert
      getWeatherForecastsResponse.WeatherForecasts.Count.ShouldBe(10);
    }
  }
}
