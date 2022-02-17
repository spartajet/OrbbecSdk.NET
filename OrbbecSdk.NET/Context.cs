using System;
using System.Runtime.InteropServices;

namespace OrbbecSdk.NET
{
    public class Context
    {
        /// <summary>
        /// 创建context的接口函数
        /// </summary>
        /// <param name="error">记录错误信息</param>
        /// <returns>返回上下文环境</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_create_context(ref ob_error error);

        /// <summary>
        /// 创建context的接口函数
        /// </summary>
        /// <param name="config_path">配置文件的路径，如果使用默认路径则传NULL</param>
        /// <param name="error">记录错误信息</param>
        /// <returns>返回上下文环境</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_create_context_with_config(string config_path, ref ob_error error);

        /// <summary>
        /// 删除上下文环境
        /// </summary>
        /// <param name="context">要删除的上下文环境</param>
        /// <param name="error">记录错误信息</param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_delete_context(IntPtr context, ref ob_error error);

        /// <summary>
        /// 获取OS枚举设备列表
        /// </summary>
        /// <param name="context">上下文环境</param>
        /// <param name="error">记录错误信息</param>
        /// <returns>返回设备列表对象</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_query_device_list(IntPtr context, ref ob_error error);


        /// <summary>
        /// 设备插拔回调函数
        /// </summary>
        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate int ob_device_changed_callback(IntPtr removed, IntPtr added, IntPtr user_data);

        /// <summary>
        /// 设置设备插拔回调函数
        /// 通过回调接口返回的added和removed设备列表，在回调函数返回后会自动销毁
        /// </summary>
        /// <param name="context">上下文环境</param>
        /// <param name="callback">设备插拔时触发的回调</param>
        /// <param name="user_data">可以传入任意用户数据，并从回调中获取</param>
        /// <param name="error">记录错误信息</param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_set_device_changed_callback(IntPtr context, [MarshalAs(UnmanagedType.FunctionPtr)] ob_device_changed_callback callback, IntPtr user_data, ref ob_error error);

        /// <summary>
        /// 设置日志的等级
        /// </summary>
        /// <param name="context">上下文环境</param>
        /// <param name="log">日志的等级</param>
        /// <param name="error">记录错误信息</param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_set_logger_serverity(IntPtr context, ob_log_severity log, ref ob_error error);

        /// <summary>
        /// 设置输出日志到文件
        /// </summary>
        /// <param name="context">上下文环境</param>
        /// <param name="log">日志的等级</param>
        /// <param name="file_name">日志文件名</param>
        /// <param name="error">记录错误信息</param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_set_logger_to_file(IntPtr context, ob_log_severity log, string file_name, ref ob_error error);

        /// <summary>
        /// 设置输出日志到控制台
        /// </summary>
        /// <param name="context">上下文环境</param>
        /// <param name="log">日志的等级</param>
        /// <param name="error">记录错误信息</param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_set_logger_to_console(IntPtr context, ob_log_severity log, ref ob_error error);

        /// <summary>
        /// 启动多设备同步功能，同步已创建设备的时钟(需要使用的设备支持该功能)
        /// </summary>
        /// <param name="context">上下文环境</param>
        /// <param name="repeatInterval">定时同步时间间隔（单位ms；如果repeatInterval=0，表示只同步一次，不再定时执行）</param>
        /// <param name="error">记录错误信息</param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_enable_multi_device_sync(IntPtr context, ulong repeatInterval, ref ob_error error);
    }
}