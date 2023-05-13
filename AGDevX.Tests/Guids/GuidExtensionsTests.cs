using System;
using AGDevX.Guids;
using Xunit;

namespace AGDevX.Tests.Guids;

public class GuidExtensionsTests
{
    public class When_calling_IsEmpty
    {
        [Fact]
        public void And_the_guid_is_empty_then_return_true()
        {
            //-- Arrange
            var guid = Guid.Empty;

            //-- Act
            var isEmpty = guid.IsEmpty();

            //-- Assert
            Assert.True(isEmpty);
        }

        [Fact]
        public void And_the_guid_is_not_empty_then_return_false()
        {
            //-- Arrange
            var guid = Guid.NewGuid();

            //-- Act
            var isEmpty = guid.IsEmpty();

            //-- Assert
            Assert.False(isEmpty);
        }
    }

    public class When_calling_IsNotEmpty
    {
        [Fact]
        public void And_the_guid_is_not_empty_then_return_true()
        {
            //-- Arrange
            var guid = Guid.NewGuid();

            //-- Act
            var isEmpty = guid.IsNotEmpty();

            //-- Assert
            Assert.True(isEmpty);
        }

        [Fact]
        public void And_the_guid_is_empty_then_return_false()
        {
            //-- Arrange
            var guid = Guid.Empty;

            //-- Act
            var isEmpty = guid.IsNotEmpty();

            //-- Assert
            Assert.False(isEmpty);
        }
    }

    public class When_calling_IsNull
    {
        [Fact]
        public void And_the_guid_is_null_then_return_true()
        {
            //-- Arrange
            Guid? guid = null;

            //-- Act
            var isNull = guid.IsNull();

            //-- Assert
            Assert.True(isNull);
        }

        [Fact]
        public void And_the_guid_is_not_null_then_return_false()
        {
            //-- Arrange
            Guid? guid = Guid.NewGuid();

            //-- Act
            var isNull = guid.IsNull();

            //-- Assert
            Assert.False(isNull);
        }
    }

    public class When_calling_IsNotNull
    {
        [Fact]
        public void And_the_guid_is_not_null_then_return_true()
        {
            //-- Arrange
            Guid? guid = Guid.NewGuid();

            //-- Act
            var isNotNull = guid.IsNotNull();

            //-- Assert
            Assert.True(isNotNull);
        }

        [Fact]
        public void And_the_guid_is_null_then_return_false()
        {
            //-- Arrange
            Guid? guid = null;

            //-- Act
            var isNotNull = guid.IsNotNull();

            //-- Assert
            Assert.False(isNotNull);
        }
    }

    public class When_calling_IsNullOrEmpty
    {
        [Fact]
        public void And_the_guid_is_empty_then_return_true()
        {
            //-- Arrange
            Guid? guid = Guid.Empty;

            //-- Act
            var isNullOrEmpty = guid.IsNullOrEmpty();

            //-- Assert
            Assert.True(isNullOrEmpty);
        }

        [Fact]
        public void And_the_guid_is_null_then_return_false()
        {
            //-- Arrange
            Guid? guid = null;

            //-- Act
            var isNullOrEmpty = guid.IsNullOrEmpty();

            //-- Assert
            Assert.True(isNullOrEmpty);
        }

        [Fact]
        public void And_the_guid_is_not_empty_and_not_null_then_return_false()
        {
            //-- Arrange
            Guid? guid = Guid.NewGuid();

            //-- Act
            var isEmpty = guid.IsNullOrEmpty();

            //-- Assert
            Assert.False(isEmpty);
        }
    }

    public class When_calling_IsNotNullNorEmpty
    {
        [Fact]
        public void And_the_guid_is_not_empty_and_not_null_then_return_true()
        {
            //-- Arrange
            Guid? guid = Guid.NewGuid();

            //-- Act
            var isNullOrEmpty = guid.IsNotNullNorEmpty();

            //-- Assert
            Assert.True(isNullOrEmpty);
        }

        [Fact]
        public void And_the_guid_is_not_null_then_return_false()
        {
            //-- Arrange
            Guid? guid = null;

            //-- Act
            var isNullOrEmpty = guid.IsNotNullNorEmpty();

            //-- Assert
            Assert.False(isNullOrEmpty);
        }

        [Fact]
        public void And_the_guid_is_empty_and_not_null_then_return_false()
        {
            //-- Arrange
            Guid? guid = Guid.Empty;

            //-- Act
            var isEmpty = guid.IsNotNullNorEmpty();

            //-- Assert
            Assert.False(isEmpty);
        }
    }
}