namespace OrbbecSdk.NET.Enums
{
    /// <summary>
    /// SDK内部的异常类型，通过异常类型，可以简单判断具体哪个类型的错误详细的错误API接口函数、错误日志请参考ob_error的信息
    /// </summary>
    public enum ob_exception_type
    {
        OB_EXCEPTION_TYPE_UNKNOWN,                  //未知错误，SDK未明确定义的错误
        OB_EXCEPTION_TYPE_CAMERA_DISCONNECTED,      // SDK的设备断开的异常
        OB_EXCEPTION_TYPE_PLATFORM,                 //在SDK适配平台层错误，代表是具体一个系统平台实现上错误
        OB_EXCEPTION_TYPE_INVALID_VALUE,            //无效的参数类型异常，需要检查输入参数
        OB_EXCEPTION_TYPE_WRONG_API_CALL_SEQUENCE,  // API版本不匹配带来的异常
        OB_EXCEPTION_TYPE_NOT_IMPLEMENTED,          // SDK及固件还未实现功能
        OB_EXCEPTION_TYPE_IO,                       // SDK访问IO异常错误
        OB_EXCEPTION_TYPE_MEMORY,                   // SDK的访问和使用内存错误，代表桢分配内存失败
        OB_EXCEPTION_TYPE_UNSUPPORTED_OPERATION,    // SDK或RGBD设备不支持的操作类型错误
        OB_EXCEPTION_TYPE_COUNT
    }
}