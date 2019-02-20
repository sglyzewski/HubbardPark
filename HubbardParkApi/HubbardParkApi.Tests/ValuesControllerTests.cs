using System;
using AutoFixture;
using AutoFixture.AutoMoq;
using Xunit;
using HubbardParkApi.Controllers;

namespace HubbardParkApi.Tests
{
  public class ValuesControllerTests
  {
    private readonly Fixture _fixture;
    private readonly ValuesController _sut;

    public ValuesControllerTests()
    {
      _fixture = new Fixture();
      _fixture.Customize(new AutoMoqCustomization());
      _sut = _fixture.Create<ValuesController>();
    }

    [Fact]
    public void GivenNoParameter_ShouldReturnHelloSpaceWorld()
    {
      var expected = "Hello space World";
      var result = _sut.Get();
      Assert.Equal(expected, result.Value);
    }
  }
}
