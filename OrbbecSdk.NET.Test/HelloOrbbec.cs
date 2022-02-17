using System;
using System.Runtime.InteropServices;
using Xunit;
using Xunit.Abstractions;

namespace OrbbecSdk.NET.Test
{
    public class HelloOrbbec:BaseTest
    {
        [Fact]
        public void HelloOrbbecTest()
        {
            // 打印SDK版本号
            this.OutputHelper.WriteLine($"SDK version: {Version.ob_get_major_version()}.{Version.ob_get_minor_version()}.{Version.ob_get_patch_version()}");

            //创建一个Context，与Pipeline不同，Context是底层API的入口，在开关流等常用操作上
            //使用低级会稍微复杂一些，但是底层API可以提供更多灵活的操作，如获取多个设备，读写
            //设备及相机的属性等
            ob_error error = new();
            IntPtr ctx = Context.ob_create_context(ref error);
            check_error(error);
            Context.ob_set_logger_to_console(ctx, ob_log_severity.OB_LOG_SEVERITY_INFO,ref error);

            //查询已经接入设备的列表
            IntPtr dev_list = Context.ob_query_device_list(ctx, ref error);
            check_error(error);

            //获取接入设备的数量
            uint dev_count = Device.ob_device_list_device_count(dev_list, ref error);
            check_error(error);
            if (dev_count == 0)
            {
                this.OutputHelper.WriteLine("Device not found!");
                return;
            }

            //创建设备，0表示第一个设备的索引
            IntPtr dev = Device.ob_get_device(dev_list, 0, ref error);
            check_error(error);

            //获取设备信息
            IntPtr dev_info = Device.ob_device_get_device_info(dev, ref error);
            check_error(error);

            //获取设备的名称
            IntPtr namePtr = Device.ob_device_info_name(dev_info, ref error);
            check_error(error);
            string name = Marshal.PtrToStringAnsi(namePtr);
            this.OutputHelper.WriteLine($"Device name: {name}" );

            //获取设备的pid, vid, uid
            int pid = Device.ob_device_info_pid(dev_info, ref error);
            check_error(error);
            int vid =Device. ob_device_info_vid(dev_info, ref error);
            check_error(error);
            string uid = Marshal.PtrToStringAnsi(Device.ob_device_info_uid(dev_info, ref error));
            check_error(error);
            this.OutputHelper.WriteLine($"Device pid: {pid} vid: {vid} uid: {uid}" );

            //通过获取设备的固件版本号
            string fw_ver = Marshal.PtrToStringAnsi(Device.ob_device_info_firmware_version(dev_info, ref error));
            check_error(error);
            this.OutputHelper.WriteLine($"Firmware version: {fw_ver}" );

            //通过获取设备的序列号
            string sn = Marshal.PtrToStringAnsi(Device.ob_device_info_serial_number(dev_info, ref error));
            check_error(error);
            this.OutputHelper.WriteLine($"Serial number: {sn}" );

            this.OutputHelper.WriteLine("Sensor types: ");
            //获取支持的传感器列表
            IntPtr sensor_list = Device.ob_device_get_sensor_list(dev, ref error);
            check_error(error);

            uint sensor_count = Sensor.ob_sensor_list_get_sensor_count(sensor_list, ref error);
            check_error(error);
            for (uint i = 0; i < sensor_count; i++)
            {
                ob_sensor_type sensor_type = Sensor.ob_sensor_list_get_sensor_type(sensor_list, i, ref error);
                check_error(error);
                switch (sensor_type)
                {
                    case ob_sensor_type.OB_SENSOR_COLOR:
                        this.OutputHelper.WriteLine("\tColor sensor");
                        break;
                    case ob_sensor_type.OB_SENSOR_DEPTH:
                        this.OutputHelper.WriteLine("\tDepth sensor");
                        break;
                    case ob_sensor_type.OB_SENSOR_IR:
                        this.OutputHelper.WriteLine("\tIR sensor");
                        break;
                    case ob_sensor_type.OB_SENSOR_ACCEL:
                        this.OutputHelper.WriteLine("\tAccel sensor");
                        break;
                    case ob_sensor_type.OB_SENSOR_GYRO:
                        this.OutputHelper.WriteLine("\tGyro sensor");
                        break;
                    default:
                        break;
                }
            }

            this.OutputHelper.WriteLine("Press ESC to exit! ");
            
        }

        public HelloOrbbec(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }
    }
}