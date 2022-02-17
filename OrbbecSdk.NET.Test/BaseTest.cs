using Xunit.Abstractions;

namespace OrbbecSdk.NET.Test
{
    public class BaseTest
    {
        protected ITestOutputHelper OutputHelper;

        public BaseTest(ITestOutputHelper outputHelper)
        {
            this.OutputHelper = outputHelper;
        }
    }
}