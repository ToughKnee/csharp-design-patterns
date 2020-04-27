using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;

namespace Laptop.Test
{
    public class AbstractFactoryShould
    {
        public static IEnumerable<object[]> FactoriesAndProcessorExpectations
        {
            get
            {
                yield return new object[] { (new LenovoPartsFactory()), "AMD", 2.1 };
                yield return new object[] { (new DellPartsFactory()), "Intel", 1.8 };
            }
        }

        [Theory]
        [MemberData(nameof(FactoriesAndProcessorExpectations))]
        public void HaveCorrectProcessor_WhenUsingFactory(ILaptopPartsFactory factory, string name, double speed)
        {
            // Act
            var processor = factory.CreateProcessor();

            // Assert
            processor.BrandName().Should().Be(name);
            processor.SpeedInGigaHertz().Should().Be(speed);
        }

        public static IEnumerable<object[]> FactoriesAndStorageExpectations
        {
            get
            {
                yield return new object[] { (new LenovoPartsFactory()), "hdd", 50 };
                yield return new object[] { (new DellPartsFactory()), "ssd", 250 };
            }
        }

        [Theory]
        [MemberData(nameof(FactoriesAndStorageExpectations))]
        public void HaveCorrectStorage_WhenUsingFactory(ILaptopPartsFactory factory, string hwtype, int speed)
        {
            // Act
            var storage = factory.CreateStorage();

            // Assert
            storage.HardwareType().Should().Be(hwtype);
            storage.ReadSpeedInMBytesPerSec().Should().Be(speed);
        }

    }
}
