using AGDevX.Enums;
using Xunit;

namespace AGDevX.Tests.Enums;

public class EnumStringValueAttributeTests
{
    private enum TestEnum
    {
        [EnumStringValue("From Cowboy Bebop")]
        Spike,
        [EnumStringValue("From Ruroni Kenshin")]
        Kenshin,
        Vash
    }

    public class When_calling_EnumStringValue
    {
        [Fact]
        public void And_matches_expected_description_then_return_expected_value()
        {
            //-- Arrange
            var stringValue = "From Cowboy Bebop";

            //-- Act
            var stringValueFromEnum = TestEnum.Spike.StringValue();

            //-- Assert
            Assert.Equal(stringValue, stringValueFromEnum);
        }

        [Fact]
        public void And_enum_does_not_have_attribute_but_itself_matches_the_expected_string_value_then_return_expected_value()
        {
            //-- Arrange
            var stringValue = "Vash";

            //-- Act
            var stringValueFromEnum = TestEnum.Vash.StringValue();

            //-- Assert
            Assert.Equal(stringValue, stringValueFromEnum);
        }
    }
}