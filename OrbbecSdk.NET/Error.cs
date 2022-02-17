using System.Runtime.InteropServices;

namespace OrbbecSdk.NET
{
    public class Error
    {
        /// <summary>
        /// 获取错误状态
        /// </summary>
        /// <param name="error">错误对象</param>
        /// <returns>返回错误状态</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_status ob_error_status(ob_error error);

        /// <summary>
        /// 获取错误信息
        /// </summary>
        /// <param name="error">错误对象</param>
        /// <returns>返回错误信息</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern string ob_error_message(ob_error error);

        /// <summary>
        /// 获取出现错误的API函数名称
        /// </summary>
        /// <param name="error">错误对象</param>
        /// <returns>返回错误函数</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern string ob_error_function(ob_error error);

        /// <summary>
        /// 获取错误参数
        /// </summary>
        /// <param name="error">错误对象</param>
        /// <returns>返回错误参数</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern string ob_error_args(ob_error error);

        /// <summary>
        /// 获取错误异常类型
        /// </summary>
        /// <param name="error">错误对象</param>
        /// <returns>返回错误异常类型</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_exception_type ob_error_exception_type(ob_error error);

        /// <summary>
        /// 删除错误对象
        /// <param name="error">错误对象</param>
        /// </summary>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_delete_error(ob_error error);
    }
}