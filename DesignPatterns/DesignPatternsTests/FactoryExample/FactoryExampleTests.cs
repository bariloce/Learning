using Xunit;
using DesignPatterns.FactoryExample;
using NSubstitute;

namespace DesignPatternsTests.FactoryExample
{
    public class FactoryExampleTests
    {
        [Fact]
        public void ShouldCreateNotNullObjectAudiSportsCarFromGenericFactory()
        {
            var car = new AudiSportsCar();
            Assert.NotNull(car);
        }

        [Fact]
        public void ShouldCreateNotNullObjectMercedesSportsCarFromGenericFactory()
        {
            var car = new MercedesSportsCar();
            Assert.NotNull(car);
        }

        [Fact]
        public void ShouldCreateNotNullObjectAudiFamilyCarFromGenericFactory()
        {
            var car =  new AudiFamilyCar();
            Assert.NotNull(car);
        }

        [Fact]
        public void ShouldCreateNotNullObjectMercedesFamilyCarFromGenericFactory()
        {
            var car = new MercedesFamilyCar();
            Assert.NotNull(car);
        }

        [Fact]
        public void ShouldCreateNotNullObjectDriver()
        {
            var factory = Substitute.For<CarFactory>();
            var driver = new Driver(factory);
            Assert.NotNull(driver);
        }

        [Fact]
        public void ShouldCompareSpeedOfMercedesSportsAndFamilyCars()
        {
            var factory = new MercedesFactory();
            var driver = new Driver(factory);
            Assert.Equal("MercedesFamilyCar is slower than MercedesSportsCar", driver.CompareSpeeds());
        }

        [Fact]
        public void ShouldCompareSpeedOfAudiSportsAndFamilyCars()
        {
            var factory = new AudiFactory();
            var driver = new Driver(factory);
            Assert.Equal("AudiFamilyCar is slower than AudiSportsCar", driver.CompareSpeeds());
        }
    }
}
