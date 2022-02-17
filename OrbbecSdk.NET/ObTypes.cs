using System;

namespace OrbbecSdk.NET
{
    /// <summary>
    /// 以下三个OBxxxxPropertyRangeTran 结构体，用于SDK与设备固件property数据传输其成员变量数据类型的长度（4byte）遵循Property命令协议
    /// 整形范围的结构体
    /// </summary>
    public struct ob_int_property_range
    {
        int cur;
        int max;
        int min;
        int step;
        int def;
    }

    /// <summary>
    /// 浮点型范围的结构体
    /// </summary>
    public struct ob_float_property_range
    {
        float cur;
        float max;
        float min;
        float step;
        float def;
    }

    /// <summary>
    /// bool型范围的结构体
    /// </summary>
    public struct ob_bool_property_range
    {
        bool cur;
        bool max;
        bool min;
        bool step;
        bool def;
    }

    /// <summary>
    /// 旋转矩阵
    /// </summary>
    public struct ob_d2c_transform
    {
        float[] rot; // 旋转矩阵，行优先 9
        float[] trans; //3
    }

    /// <summary>
    /// 去畸变参数
    /// </summary>
    public struct ob_camera_distortion
    {
        float k1;
        float k2;
        float k3;
        float k4;
        float k5;
        float k6;
        float p1;
        float p2;
    }

    /// <summary>
    /// 相机内参
    /// </summary>
    public struct ob_camera_intrinsic
    {
        float fx; //  x方向焦距，单位：像素
        float fy; //  y方向焦距，单位：像素
        float cx; // 光心横坐标
        float cy; //  光心纵坐标
        short width; // 图像宽度
        short height; //  图像高度
    }

    public enum ob_file_tran_state
    {
        FILE_TRAN_STAT_TRANSFER = 2,
        FILE_TRAN_STAT_DONE = 1,
        FILE_TRAN_STAT_PREPAR = 0,
        FILE_TRAN_ERR_DDR = -1,
        FILE_TRAN_ERR_NOT_ENOUGH_SPACE = -2,
        FILE_TRAN_ERR_PATH_NOT_WRITABLE = -3,
        FILE_TRAN_ERR_MD5_ERROR = -4,
        FILE_TRAN_ERR_WRITA_FLASH_ERROR = -5,
        FILE_TRAN_ERR_TIMEOUT = -6
    }

    public struct ob_device_state
    {
        DeviceStateType type; //设备状态类型
        string msg; //设备状态具体信息
    }

    public enum DeviceStateType
    {
        NORMAL = 0,
        OPEN_STREAM_OPERATION_ERROR = 1, //开流异常
    }

    public enum ob_upgrade_state
    {
        STAT_FILE_TRANSFER = 4,
        STAT_DONE          = 3,
        STAT_IN_PROGRESS   = 2,
        STAT_START         = 1,
        STAT_VERIFY_IMAGE  = 0,
        ERR_VERIFY         = -1,
        ERR_PROGRAM        = -2,
        ERR_ERASE          = -3,
        ERR_FLASH_TYPE     = -4,
        ERR_IMG_SIZE       = -5,
        ERR_OTHER          = -6,
        ERR_DDR            = -7,
        ERR_TIMEOUT        = -8
    }
}