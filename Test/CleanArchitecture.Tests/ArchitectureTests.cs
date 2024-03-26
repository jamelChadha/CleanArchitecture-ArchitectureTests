using NetArchTest.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CleanArchitecture.Tests
{
    public class ArchitectureTests
    {
        [Fact]
        public void Domain_Should_Not_HaveDependencyOnOtherProjects()
        {
            //Arrange
            var assembly = typeof(Domains.AssemblyReference).Assembly;
            //Act
            var result = Types.InAssembly(assembly)
                .Should()
                .NotHaveDependencyOn("Application")
                .And()
                .NotHaveDependencyOn("Presentation")
                .And()
                .NotHaveDependencyOn("Infrastructure")
                .And()
                .NotHaveDependencyOn("WebAPI")
                .GetResult();
            //Assert
            Assert.True(result.IsSuccessful);
        }


    }
}
