using OrbbecSdk.NET.Enums;

namespace OrbbecSdk.NET.Structs
{
    /// <summary>
    /// SDK的对外暴露的错误类，用户可以根据该错误类，获取详细的错误信息
    /// </summary>
    public struct ob_error
    {
        /// <summary>
        /// 描述错误的状态码，作为兼容之前客户状态码需求
        /// </summary>
        public ob_status status;

        /// <summary>
        /// 描述详细的错误日志
        /// </summary>
        public string message;

        /// <summary>
        /// 描述出现错误的函数名称
        /// </summary>
        public string function;

        /// <summary>
        /// 函数传入的参数。用来检查是不是参数错
        /// </summary>
        public string args;

        /// <summary>
        /// 描述是SDK的具体错误类型
        /// </summary>
        public ob_exception_type exception_type;
    }
}