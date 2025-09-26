using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Tabs.Tests;

[Collection("Collection")]
public sealed class TabTests : FixturedUnitTest
{
    public TabTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
