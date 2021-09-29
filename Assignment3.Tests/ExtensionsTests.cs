using System;
using Xunit;

namespace Assignment3.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void Flatten_given_lists_return_content() {
            // Arrange
            var list = new[]{
                new[] {1,2,3,4},
                new[] {5,6,7,8},
                new[] {9,10}
            };

            // Act

            var actual = Extensions.Flatten(list);
            var expected = new[] {1,2,3,4,5,6,7,8,9,10};

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Filter_given_42_45_49_70_return_49_and_70() {
            // Arrange
            var list = new[]{ 42, 45, 49, 70};

            // Act

            var actual = Extensions.Filter(list);
            var expected = new[]{49, 70};


            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsLeapYear_given_1700_1800_2000_2100_returns_2000()
        {
        //Arrange
        var list = new[]{1700, 1800, 2000, 2100};

        //Act
        var actual = Extensions.IsLeapYear(list);
        var expected = new[]{2000};

        //Assert
        Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsSecure_given_SecureUri_andInsecureUri()
        {
        //Arrange
        Uri AcceptedUri = new Uri("https://www.youtube.com/watch?v=O91DT1pR1ew&ab_channel=CB2C");
        Uri DeniedUri = new Uri("ldap://[2001:db8::7]/c=gb?objectClass?one");
        
        //Act
        var actual = Extensions.IsSecure(AcceptedUri);
        var actual2 = Extensions.IsSecure(DeniedUri);
        
        //Assert
        Assert.True(actual);
        Assert.False(actual2);
        }

        [Fact]
        public void WordCount_Given_3Words_returns_correctly()
        {
        //Arrange
        var word = "I have commited several war crimes";
        var word2 = "C0mb1n1ng l3tt3r5 4nd numb3rs";
        var word3 = "Systributed Distems";

        //Act
        var actual = Extensions.WordCount(word);
        var actual2 = Extensions.WordCount(word2);
        var actual3 = Extensions.WordCount(word3);

        //Assert
        Assert.Equal(6, actual);
        Assert.Equal(10, actual2);
        Assert.Equal(2, actual3);
        }
    }
}
