using System;
using OrbbecSdk.NET.Enums;
using OrbbecSdk.NET.Structs;
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
            IntPtr context = Context.ob_create_context(error);
            this.OutputHelper.WriteLine(context.ToString());
            IntPtr dev_list = Context.ob_query_device_list(context, error);
            
            Assert.Equal(ob_status.OB_STATUS_OK,error.status);
            
            this.OutputHelper.WriteLine(dev_list.ToString());
        }
    }
}