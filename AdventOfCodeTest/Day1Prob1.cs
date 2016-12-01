using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2016.Day1;

namespace AdventOfCodeTest
{
    using Xunit;
    using Xunit.Abstractions;

    public class Day1Prob1
    {
        private ITestOutputHelper _output;

        public Day1Prob1(ITestOutputHelper output)
        {
            this._output = output;
        }
        [Fact]
        public  void RunSolution()
        {
            var result = Problem1.SolveProblem1();
            _output.WriteLine((result ?? "null").ToString());
            
        }
    }
}
