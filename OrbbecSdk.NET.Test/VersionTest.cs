using Xunit;
using Xunit.Abstractions;

namespace OrbbecSdk.NET.Test
{
    public class VersionTest : BaseTest
    {
        public VersionTest(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        [Fact]
        public void TestVersion()
        {
            int version = Version.ob_get_version();
            int majorVersion = Version.ob_get_major_version();
            int minorVersion = Version.ob_get_minor_version();
            int patchVersion = Version.ob_get_patch_version();
            Assert.True(version > 0);
            Assert.True(majorVersion > 0);
            Assert.True(minorVersion > 0);
            Assert.True(patchVersion > 0);
            this.OutputHelper.WriteLine($"version:{version}\nmajorVersion:{majorVersion}\nminorVersion:{minorVersion}\npatchVersion:{patchVersion}");
        }
    }
}