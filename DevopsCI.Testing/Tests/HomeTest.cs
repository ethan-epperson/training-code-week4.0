using DevopsCI.Client.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DevopsCI.Testing.Tests
{
    public class Test
    {
        [Fact]
        public HomeController_Test()
        {
        //Given
            var sut = new HomeController();
            var view = sut.Index();
        //When
        
        //Then
            Assert.NotNull(view);
        }
    }
}