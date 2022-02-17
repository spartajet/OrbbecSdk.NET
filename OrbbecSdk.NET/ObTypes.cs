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
        STAT_DONE = 3,
        STAT_IN_PROGRESS = 2,
        STAT_START = 1,
        STAT_VERIFY_IMAGE = 0,
        ERR_VERIFY = -1,
        ERR_PROGRAM = -2,
        ERR_ERASE = -3,
        ERR_FLASH_TYPE = -4,
        ERR_IMG_SIZE = -5,
        ERR_OTHER = -6,
        ERR_DDR = -7,
        ERR_TIMEOUT = -8
    }

    /// <summary>
    /// 描述像素格式的枚举值
    /// </summary>
    public enum ob_format
    {
        OB_FORMAT_YUYV = 0,
        OB_FORMAT_YUY2 = 1,
        OB_FORMAT_UYVY = 2,
        OB_FORMAT_NV12 = 3,
        OB_FORMAT_NV21 = 4,
        OB_FORMAT_MJPG = 5,
        OB_FORMAT_H264 = 6,
        OB_FORMAT_H265 = 7,
        OB_FORMAT_Y16 = 8,
        OB_FORMAT_Y8 = 9,
        OB_FORMAT_Y10 = 10,
        OB_FORMAT_Y11 = 11,
        OB_FORMAT_Y12 = 12,
        OB_FORMAT_GRAY = 13,
        OB_FORMAT_HEVC = 14,
        OB_FORMAT_I420 = 15,
        OB_FORMAT_ACCEL = 16,
        OB_FORMAT_GYRO = 17,

        // OB_FORMAT_IMU       = 18,  // delete
        OB_FORMAT_POINT = 19,
        OB_FORMAT_RGB_POINT = 20,
        OB_FORMAT_RLE = 21,
        OB_FORMAT_RGB888 = 22,
        OB_FORMAT_BGR = 23,
        OB_FORMAT_UNKNOWN = 0xff,
    }

    /// <summary>
    /// 描述Frame类型枚举值
    /// </summary>
    public enum ob_frame_type
    {
        OB_FRAME_VIDEO = 0,
        OB_FRAME_IR = 1,
        OB_FRAME_COLOR = 2,
        OB_FRAME_DEPTH = 3,
        OB_FRAME_ACCEL = 4,
        OB_FRAME_SET = 5,
        OB_FRAME_POINTS = 6,
        OB_FRAME_GYRO = 7,
    }

    /// <summary>
    /// 描述数据流类型的枚举值
    /// </summary>
    public enum ob_stream_type
    {
        OB_STREAM_VIDEO = 0,
        OB_STREAM_IR = 1,
        OB_STREAM_COLOR = 2,
        OB_STREAM_DEPTH = 3,
        OB_STREAM_ACCEL = 4,
        OB_STREAM_GYRO = 5,
    }

    /// <summary>
    /// 
    /// </summary>
    public struct ob_accel_value
    {
        float x;
        float y;
        float z;
    }

    /// <summary>
    /// 
    /// </summary>
    public struct ob_gyro_value
    {
        float x;
        float y;
        float z;
    }

    public struct ob_camera_para
    {
        float[] d_intr_p; // 深度相机内参：[fx,fy,cx,cy]
        float[] c_intr_p; // 彩色相机内参：[fx,fy,cx,cy]
        float[] d2c_r; // 深度相机到彩色相机的旋转矩阵 [r00,r01,r02;r10,r11,r12;r20,r21,r22]
        float[] d2c_t; // 深度相机到彩色相机的平移矩阵 [t1,t2,t3]
        float[] d_k; // 深度相机畸变参数 [k1,k2,p1,p2,k3]  // 注意k3的位置，这个是算法定的，有些代码k3排在k2后边
        float[] c_k; // 彩色相机畸变参数 [k1,k2,p1,p2,k3]
        uint[] c_img_size; // 彩色标定分辨率 [color_width, color_height]
        uint[] d_img_size; // 深度标定分辨率 [ir_width, ir_height]
    }

    public enum ob_convert_format
    {
        FORMAT_YUYV_TO_RGB888 = 0,
        FORMAT_I420_TO_RGB888,
        FORMAT_NV21_TO_RGB888,
        FORMAT_NV12_TO_RGB888,
        FORMAT_MJPEG_TO_I420,
        FORMAT_RGB888_TO_BGR,
        FORMAT_MJPEG_TO_NV21,
        FORMAT_MJPEG_TO_RGB888,
    }
}