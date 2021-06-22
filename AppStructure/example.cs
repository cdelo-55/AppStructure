using System;
using FluentAssertions;

namespace AppStructure
{
    class exampleClass
    {
        public void additionMethod()
        {
           var first = 3;
           var second = 7;
           var result = first + second;

           result.Should().Be(10);
        }
    }
}
