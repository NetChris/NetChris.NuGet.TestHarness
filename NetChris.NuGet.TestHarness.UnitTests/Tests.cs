using FluentAssertions;
using Xunit;

namespace NetChris.NuGet.TestHarness.UnitTests;

public class Tests
{
    [Fact]
    public void Test1()
    {
        true.Should().BeTrue();
    }

    [Fact]
    public void Test2()
    {
        true.Should().BeTrue();
    }
}