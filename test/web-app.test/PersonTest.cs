using System;
using Xunit;
using FitnessStudio.Model;

namespace FitnessStudio.Test
{
    public class PersonTest
    {
        [Theory]
        [InlineData("Name")]
        [InlineData("John")]
        public void Constructor(string value)
        {
            var p = new Person(value);
            Assert.Equal(value, p.Name);
        }
    }
}
