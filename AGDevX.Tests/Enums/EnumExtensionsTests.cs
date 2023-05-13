using AGDevX.Enums;
using Xunit;

namespace AGDevX.Tests.Enums;

public class EnumExtensionsTests
{
    private enum TestEnum
    {
        [EnumStringValue("From Cowboy Bebop")]
        Spike,
        [EnumStringValue("From Ruroni Kenshin")]
        Kenshin,
        Vash
    }

    public class When_calling_IsOneOf
    {
        [Fact]
        public void With_a_value_that_is_one_of_then_return_true()
        {
            //-- Arrange
            TestEnum kenshin = TestEnum.Kenshin;

            //-- Act
            var isOneOf = kenshin.IsOneOf(TestEnum.Spike, TestEnum.Kenshin);

            //-- Assert
            Assert.True(isOneOf);
        }

        [Fact]
        public void With_a_value_that_is_not_one_of_then_return_false()
        {
            //-- Arrange
            TestEnum vash = TestEnum.Vash;

            //-- Act
            var isOneOf = vash.IsOneOf(TestEnum.Spike, TestEnum.Kenshin);

            //-- Assert
            Assert.False(isOneOf);
        }
    }
}