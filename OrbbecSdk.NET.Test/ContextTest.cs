using System;
using Xunit;
using Xunit.Abstractions;

namespace OrbbecSdk.NET.Test
{
    public class ContextTest : BaseTest
    {
        public ContextTest(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        [Fact]
        public void TestContext()
        {
            ob_error error = new ob_error();
            IntPtr context = Context.ob_create_context(ref error);
            this.OutputHelper.WriteLine($"context intptr:{context.ToString()}");
            IntPtr dev_list = Context.ob_query_device_list(context,ref error);

            Assert.Equal(ob_status.OB_STATUS_OK, error.status);

            this.OutputHelper.WriteLine($"device list intptr:{dev_list.ToString()}");

            Context.ob_set_logger_to_console(context, ob_log_severity.OB_LOG_SEVERITY_INFO,ref error);

            uint dev_count = Device.ob_device_list_device_count(dev_list,ref error);
            Assert.Equal(ob_status.OB_STATUS_OK, error.status);
            this.OutputHelper.WriteLine($"device count:{dev_count}");
            
        }
    }
}