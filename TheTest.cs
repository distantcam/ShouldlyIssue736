using Bogus;
using Shouldly;
using System;
using System.Linq;
using Xunit;

namespace ShouldMatchApprovedTestPerf
{
    public class TheTest
    {
        [Fact]
        public void LargeApproval()
        {
            var faker = new Faker();

            var lines = Enumerable.Range(0, 10000)
                .Select(_ => faker.Random.String2(10, 100))
                .ToArray();

            var expected = string.Join(Environment.NewLine, lines);
            expected.ShouldMatchApproved();
        }
    }
}
