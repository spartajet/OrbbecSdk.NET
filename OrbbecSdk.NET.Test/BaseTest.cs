using Xunit;
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

        protected void check_error(ob_error error)
        {
            if (error.status == ob_status.OB_STATUS_OK) return;
            this.OutputHelper.WriteLine($"ob_error was raised when calling   {Error.ob_error_function(error)}({Error.ob_error_args(error)}s)");
            this.OutputHelper.WriteLine($"error message:    {Error.ob_error_message(error)}");
            this.OutputHelper.WriteLine($"error Type:    {Error.ob_error_exception_type(error)}");
            Assert.Equal(ob_status.OB_STATUS_OK, error.status);
        }
    }
}