using System;
using Xunit;
using FitnessStudio.Model;

namespace FitnessStudio.Test
{
    public class GroupTest
    {
        [Theory]
        [InlineData("Person Name")]
        public void Construction(string value)
        {
            var p = new Person(value);
            var grp = new Group();
            Assert.NotNull(grp.Members);
            grp.Members.Add(p);
            Assert.NotEmpty(grp.Members);
        }
    }
}