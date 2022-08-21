using System;

namespace OrbbecSdk.NET
{

    public enum ob_permission_type
    {
        OB_PERMISSION_DENY       = 0,//**< \if English no permission \else 无访问权限 \endif */
        OB_PERMISSION_READ       = 1, //**< \if English can read \else 可读 \endif */
        OB_PERMISSION_WRITE      = 2, //**< \if English can write \else 可写 \endif */
        OB_PERMISSION_READ_WRITE = 3, //**< \if English can read and write \else 可读写 \endif */
    }
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

    public struct ob_camera_param
    {
        OBCameraIntrinsic  depthIntrinsic;   //< \if English Depth camera internal parameters \else 深度相机内参 \endif    
        OBCameraIntrinsic  rgbIntrinsic;     //< \if English Color camera internal parameters \else 彩色相机内参 \endif    
        OBCameraDistortion depthDistortion;  //< \if English Depth camera distortion parameters \else 深度相机畸变参数 \endif   
        OBCameraDistortion rgbDistortion;    //< \if English Color camera distortion parameters 1 \else 彩色相机畸变参数 \endif   
        OBD2CTransform     transform;        //< \if English rotation/transformation matrix \else 旋转/变换矩阵 \endif   
        bool               isMirrored;       //< \if English Whether the image frame corresponding to this group of parameters is mirrored \else 本组参数对应的图像帧是否被镜像 \endif   
    }

    public enum ob_align_mode
    {
        ALIGN_DISABLE,     //**< \if English turn off alignment \else 关闭对齐 \endif */
        ALIGN_D2C_HW_MODE, //**< \if English Hardware D2C alignment mode \else 硬件D2C对齐模式 \endif */
        ALIGN_D2C_SW_MODE, //**< \if English Software D2C alignment mode \else 软件D2C对齐模式 \endif */
    }

    public struct ob_rect
    {
        uint x;       //< \if English origin coordinate x \else 原点坐标x \endif     
        uint y;       //< \if English origin coordinate y \else 原点坐标y \endif     
        uint width;   //< \if English rectangle width \else 矩形宽度 \endif     
        uint height;  //< \if English rectangle height \else 矩形高度 \endif     
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

    // public struct ob_device_state
    // {
    //     DeviceStateType type; //设备状态类型
    //     string msg; //设备状态具体信息
    // }

    public enum ob_device_state
    {
        OB_DEVICE_STATE_NULL        = 0x0000, //**< \if English No status or LOG information update \else 无状态或LOG信息更新 \endif */
        OPEN_STREAM_OPERATION_ERROR = 0x0001, //**< \if English Open current exception \else 开流异常 \endif */
        OB_DEVICE_STATE_INFO        = 0x7fff  //**< \if English LOG information update \else LOG信息更新 \endif */
    }

    public struct ob_device_temperature
    {
        float cpuTemp;        //< \if English CPU temperature \else cpu温度 \endif     
        float irTemp;         //< \if English IR temperature \else IR温度 \endif     
        float ldmTemp;        //< \if English laser temperature \else 激光温度 \endif     
        float mainBoardTemp;  //< \if English motherboard temperature \else 主板温度 \endif     
        float tecTemp;        //< \if English TEC temperature \else TEC温度 \endif     
        float imuTemp;        //< \if English IMU temperature \else IMU温度 \endif     
        float rgbTemp;        //< \if English RGB temperature \else RGB温度 \endif  
    }

    public enum ob_depth_cropping_mode
    {
        DEPTH_CROPPING_MODE_AUTO  = 0, //**< \if English automatic mode \else 自动模式 \endif */
        DEPTH_CROPPING_MODE_CLOSE = 1, //**< \if English close crop \else 关闭裁切 \endif */
        DEPTH_CROPPING_MODE_OPEN  = 2, //**< \if English open crop \else 打开裁切 \endif */
    }

    public enum ob_media_type
    {
        OB_MEDIA_COLOR_STREAM = 1,   //**< \if English color stream \else 彩色流\endif */ 
        OB_MEDIA_DEPTH_STREAM = 2,   //**< \if English depth stream \else 深度流 \endif */
        OB_MEDIA_IR_STREAM    = 4,   //**< \if English IR stream \else 红外流 \endif */
        OB_MEDIA_GYRO_STREAM  = 8,   //**< \if English gyro stream \else 陀螺仪数据流 \endif */
        OB_MEDIA_ACCEL_STREAM = 16,  //**< \if English accel stream \else 加速度计数据流 \endif */ 
        OB_MEDIA_CAMERA_PARAM = 32,  //**< \if English camera parameter \else 相机参数 \endif */ 
        OB_MEDIA_DEVICE_INFO  = 64,  //**< \if English device information \else 设备信息  \endif */
        OB_MEDIA_STREAM_INFO  = 128, //**< \if English stream information \else 流信息 \endif */ 

        OB_MEDIA_ALL = OB_MEDIA_COLOR_STREAM | OB_MEDIA_DEPTH_STREAM | OB_MEDIA_IR_STREAM | OB_MEDIA_GYRO_STREAM | OB_MEDIA_ACCEL_STREAM | OB_MEDIA_CAMERA_PARAM
          | OB_MEDIA_DEVICE_INFO | OB_MEDIA_STREAM_INFO, //**< \if English All media data types \else 所有媒体数据类型 \endif */ 
    }

    public enum ob_media_state
    {
        OB_MEDIA_BEGIN = 0, //**< \if English begin \else 开始 \endif */ 
        OB_MEDIA_PAUSE,     //**< \if English pause \else 暂停 \endif */ 
        OB_MEDIA_RESUME,    //**< \if English resume \else 继续 \endif */ 
        OB_MEDIA_END,       //**< \if English end \else 终止  \endif */
    }

    public enum ob_device_type
    {
        OB_STRUCTURED_LIGHT_MONOCULAR_CAMERA = 0,//**< \if English Monocular structured light camera \else 单目结构光相机  \endif */
        OB_STRUCTURED_LIGHT_BINOCULAR_CAMERA,    //**< \if English Binocular structured light camera \else 双目结构光相机  \endif */
        OB_TOF_CAMERA,                           //**< \if English TOF camera \else TOF相机  \endif */
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

    /// <summary>
    /// 加速度计量程枚举
    /// </summary>
    public enum ob_accel_full_scale_range
    {
        OB_ACCEL_FS_2g = 1,
        OB_ACCEL_FS_4g,
        OB_ACCEL_FS_8g,
        OB_ACCEL_FS_16g,
    }

    /// <summary>
    /// IMU采样率值的枚举(陀螺仪或加速度计)
    /// </summary>
    public enum ob_accel_sample_rate
    {
        OB_SAMPLE_RATE_1_5625_HZ = 1,
        OB_SAMPLE_RATE_3_125_HZ,
        OB_SAMPLE_RATE_6_25_HZ,
        OB_SAMPLE_RATE_12_5_HZ,
        OB_SAMPLE_RATE_25_HZ,
        OB_SAMPLE_RATE_50_HZ,
        OB_SAMPLE_RATE_100_HZ,
        OB_SAMPLE_RATE_200_HZ,
        OB_SAMPLE_RATE_500_HZ,
        OB_SAMPLE_RATE_1_KHZ,
        OB_SAMPLE_RATE_2_KHZ,
        OB_SAMPLE_RATE_4_KHZ,
        OB_SAMPLE_RATE_8_KHZ,
        OB_SAMPLE_RATE_16_KHZ,
        OB_SAMPLE_RATE_32_KHZ,
    }

    public enum ob_depth_precision_level
    {
        OB_PRECISION_1MM,  //**< 1mm */
        OB_PRECISION_0MM8, //**< 0.8mm */
        OB_PRECISION_0MM4, //**< 0.4mm */
        OB_PRECISION_0MM1, //**< 0.1mm */
        OB_PRECISION_COUNT,
    }

    public enum ob_tof_filter_range
    {
        OB_TOF_FILTER_RANGE_CLOSE  = 0,   //**< \if English close range \else 近距离范围 \endif */ 
        OB_TOF_FILTER_RANGE_MIDDLE = 1,   //**< \if English middle range \else 中距离范围  \endif */
        OB_TOF_FILTER_RANGE_LONG   = 2,   //**< \if English long range \else 远距离范围 \endif */
        OB_TOF_FILTER_RANGE_DEBUG  = 100, //**< \if English debug range \else Debug模式  \endif */
    }

    public struct ob_point
    {
        float x;  //< \if English x coordinate \else X坐标 \endif     
        float y;  //< \if English y coordinate \else Y坐标 \endif     
        float z;  //< \if English z coordinate \else Z坐标 \endif     
    }

    public struct ob_color_point
    {
        float x;  //< \if English x coordinate \else X坐标 \endif    
        float y;  //< \if English y coordinate \else Y坐标 \endif   
        float z;  //< \if English z coordinate \else Z坐标 \endif    
        float r;  //< \if English red channel component \else 红色通道分量 \endif    
        float g;  //< \if English green channel component \else 绿色通道分量 \endif    
        float b;  //< \if English blue channel component\else 蓝色通道分量 \endif    
    }

    public enum ob_sync_mode
    {
        OB_SYNC_STOP              = 0x00, //**< \if English turn off sync \else 关闭同步 \endif */ 
        OB_SYNC_SINGLE_MODE       = 0x01, //**< \if English single device mode \else single device模式 \endif */
        OB_SYNC_ONLINE_HOST_MODE  = 0x02, //**< \if English The single device mode is also the host mode, which is dominated by ir \else single device模式，也是host模式，是ir作主的  \endif */
        OB_SYNC_ONLINE_SLAVE_MODE = 0x03, //**< \if English slave mode (ext_in --> rgb、tof、ext_out) \else slave模式 (ext_in --> rgb、tof、ext_out)  \endif */
        OB_SYNC_ONLY_MCU_MODE     = 0x04, //**< \if English MCU as host mode \else mcu作host的模式 \endif */ 
        OB_SYNC_ONLY_IR_MODE      = 0x05, //**< \if English IR as host mode\else ir作host的模式  \endif */
    }

    public struct ob_tof_exposure_threshold_control
    {
        int upper;  //< \if English Upper threshold, unit: ms \else 阈值上限， 单位：ms \endif
        int lower;  //< \if English Lower threshold, unit: ms \else 阈值下限， 单位：ms \endif
    }

    public struct ob_multi_device_sync_config
    {
        OBSyncMode syncMode;       //< \if English Sync mode \else 同步模式 \endif  
        short   tofPhaseDelay;  //< \if English Tof trigger signal delay us. \else Tof触发信号延时 us \endif  
        short   rgbPhaseDelay;  //< \if English rgb trigger signal delay us \else rgb触发信号延时 us \endif  
        short   outPhaseDelay;  //< \if English Output signal delay us \else 输出信号延时 us \endif  
        short   outOCPolarity;  //< \if English 0: Positive pulse, 1: Negative pulse \else 0:正向脉冲, 1: 负向脉冲 \endif  
        short   mcuHostFps;     //< \if English Trigger frame rate in mcu master mode \else mcu主模式时的触发帧率 \endif  
        short   curDevId;       //< \if English Current device number \else 当前设备编号 \endif  
    }

    /// <summary>
    /// 陀螺仪量程的枚举
    /// </summary>
    public enum ob_gyro_full_scale_range
    {
        OB_GYRO_FS_16dps = 1,
        OB_GYRO_FS_31dps,
        OB_GYRO_FS_62dps,
        OB_GYRO_FS_125dps,
        OB_GYRO_FS_245dps,
        OB_GYRO_FS_250dps,
        OB_GYRO_FS_500dps,
        OB_GYRO_FS_1000dps,
        OB_GYRO_FS_2000dps,
    }
/// <summary>
/// IMU采样率值的枚举(陀螺仪或加速度计)
/// </summary>
    public enum ob_gyro_sample_rate
    {
        OB_SAMPLE_RATE_1_5625_HZ = 1,
        OB_SAMPLE_RATE_3_125_HZ,
        OB_SAMPLE_RATE_6_25_HZ,
        OB_SAMPLE_RATE_12_5_HZ,
        OB_SAMPLE_RATE_25_HZ,
        OB_SAMPLE_RATE_50_HZ,
        OB_SAMPLE_RATE_100_HZ,
        OB_SAMPLE_RATE_200_HZ,
        OB_SAMPLE_RATE_500_HZ,
        OB_SAMPLE_RATE_1_KHZ,
        OB_SAMPLE_RATE_2_KHZ,
        OB_SAMPLE_RATE_4_KHZ,
        OB_SAMPLE_RATE_8_KHZ,
        OB_SAMPLE_RATE_16_KHZ,
        OB_SAMPLE_RATE_32_KHZ,
    }

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
public struct ob_data_chunk
{
    public IntPtr data; // 当前数据块数据
    public uint size; // 当前数据块大小
    public uint offset; // 当前数据块相对完整数据的偏移
    public uint fullDataSize; // 完整数据大小
}
public enum ob_data_tran_state
{
    DATA_TRAN_STAT_STOPED       = 3,
    DATA_TRAN_STAT_DONE         = 2,
    DATA_TRAN_STAT_VERIFYING    = 1,
    DATA_TRAN_STAT_TRANSFERING  = 0,
    DATA_TRAN_ERR_BUSY          = -1,
    DATA_TRAN_ERR_UNSUPPORTED   = -2,
    DATA_TRAN_ERR_TRAN_FAILED   = -3,
    DATA_TRAN_ERR_VERIFY_FAILED = -4,
    DATA_TRAN_ERR_OTHER         = -5
}
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
    // OB_EXCEPTION_TYPE_COUNT
}
/// <summary>
    /// 描述设备所有的属性的枚举值
    /// </summary>
    public enum ob_global_unified_property
    {
        // 0~999为设备端int, bool及float类型控制命令
        // Device:: get/setxxxProperty、 getxxxPropertyRange (xxx表示数据类型)
        OB_DEVICE_PROPERTY_FLASH_WRITE_PROTECTION_BOOL = 0, // FLASH写保护开关；0，关闭；1，开启
        OB_DEVICE_PROPERTY_TEC_ENABLE_BOOL = 1, // TEC开关
        OB_DEVICE_PROPERTY_LDP_BOOL = 2, // LDP开关
        OB_DEVICE_PROPERTY_EMITTER_BOOL = 3, // 激光开光
        OB_DEVICE_PROPERTY_LASER_PULSE_WIDTH_INT = 4, // 读写激光Time值（脉宽）,
        OB_DEVICE_PROPERTY_LASER_CURRENT_FLOAT = 5, // 激光电流
        OB_DEVICE_PROPERTY_FLOOD_BOOL = 6, // 泛光灯开关
        OB_DEVICE_PROPERTY_FLOOD_LEVEL_INT = 7, // 泛光灯等级
        OB_DEVICE_PROPERTY_TEMPERATURE_COMPENSATION_ENABLE_BOOL = 8, // 温度补偿开关
        OB_DEVICE_PROPERTY_TEMPERATURE_CALIBRATED_IR_FLOAT = 9, // IR标定温度
        OB_DEVICE_PROPERTY_TEMPERATURE_CALIBRATED_LDMP_FLOAT = 10, // 激光标定温度
        OB_DEVICE_PROPERTY_TEMPERATURE_COMPENSATION_COEFFICIENT_IR_FLOAT = 11, // IR温补系数
        OB_DEVICE_PROPERTY_TEMPERATURE_COMPENSATION_COEFFICIENT_LDMP_FLOAT = 12, // 激光温补系数
        OB_DEVICE_PROPERTY_DEPTH_ALIGN_SOFTWARE_BOOL = 13, // 软件D2C
        OB_DEVICE_PROPERTY_DEPTH_MIRROR_BOOL = 14, // 深度镜像
        OB_DEVICE_PROPERTY_DEPTH_FLIP_BOOL = 15, // 深度翻转
        OB_DEVICE_PROPERTY_DEPTH_POSTFILTER_BOOL = 16, // 深度Postfilter
        OB_DEVICE_PROPERTY_DEPTH_HOLEFILTER_BOOL = 17, // 深度Holefilter
        OB_DEVICE_PROPERTY_IR_MIRROR_BOOL = 18, // IR 镜像
        OB_DEVICE_PROPERTY_IR_FLIP_BOOL = 19, // IR 翻转
        OB_DEVICE_PROPERTY_IR_SWITCH_BOOL = 20, // IR 左右切换
        OB_DEVICE_PROPERTY_HARDWARE_SYNC_BOOL = 21, // 开启硬件同步
        OB_DEVICE_PROPERTY_MIN_DEPTH_INT = 22, // 最小深度阈值
        OB_DEVICE_PROPERTY_MAX_DEPTH_INT = 23, // 最大深度阈值
        OB_DEVICE_PROPERTY_DEPTH_SOFT_FILTER_BOOL = 24, // 软件滤波开关
        OB_DEVICE_PROPERTY_ZERO_PLANE_DISTANCE_FLOAT = 25, // ZPD
        OB_DEVICE_PROPERTY_ZERO_PLANE_PIXEL_SIZE_FLOAT = 26, // ZPPS
        OB_DEVICE_PROPERTY_CHIP_TYPE_INT = 27, // 芯片类型
        OB_DEVICE_PROPERTY_USB_SPEED_INT = 28, // usb speed
        OB_DEVICE_PROPERTY_SOFT_RESET_BOOL = 29, // 软件复位
        OB_DEVICE_PROPERTY_LDP_THRES_UP_INT = 30, // LDP阈值的上限
        OB_DEVICE_PROPERTY_LDP_THRES_LOW_INT = 31, // LDP阈值的下限
        OB_DEVICE_PROPERTY_LDP_STATUS_BOOL = 32, // LDP状态
        OB_DEVICE_PROPERTY_LASER_TEMPERATURE_FLOAT = 33, // 获取激光温度
        OB_DEVICE_PROPERTY_BOOTLOADER_WRITE_PROTECTION_STATUS_BOOL = 34, // Bootloader区flash写保护状态
        OB_DEVICE_PROPERTY_RT_IR_TEMP_FLOAT = 35, // 获取实时IR温度
        OB_DEVICE_PROPERTY_RT_LDMP_TEMP_FLOAT = 36, // 获取实时LDMP温度
        OB_DEVICE_PROPERTY_RT_RGB_TEMP_FLOAT = 37, // 获取实时RGB温度
        OB_DEVICE_PROPERTY_STOP_DEPTH_STREAM_BOOL = 38, // 关闭深度流，用于无法通过标准UVC协议关流的设备
        OB_DEVICE_PROPERTY_STOP_IR_STREAM_BOOL = 39, // 关闭IR流用于无法通过标准UVC协议关流的设备
        OB_DEVICE_PROPERTY_DEPTH_MAX_DIFF_INT = 40, // soft filter maxdiff param
        OB_DEVICE_PROPERTY_DEPTH_MAX_SPECKLE_SIZE_INT = 41, // soft filter maxSpeckleSize
        OB_DEVICE_PROPERTY_DEPTH_ALIGN_HARDWARE_BOOL = 42, // 硬件d2c开
        OB_DEVICE_PROPERTY_TIMESTAMP_OFFSET_INT = 43, // 时间戳调校
        OB_DEVICE_PROPERTY_ORIENTATION_SWITCH_BOOL = 44, // 横竖屏切换, 0:竖屏，1横屏
        OB_DEVICE_PROPERTY_ENABLE_CALIBRATION_BOOL = 45, // 是否需要裁剪

        // OB_DEVICE_PROPERTY_TOF_FPS_INT                                          = 46,  // TOF帧率
        OB_DEVICE_PROPERTY_TOF_EXPOSURE_TIME_INT = 47, // TOF曝光时间
        OB_DEVICE_PROPERTY_TOF_GAIN_INT = 48, // TOF增益
        OB_DEVICE_PROPERTY_TOF_MIRROR_INT = 49, // TOF镜像开光, 0: close 1:H-Mirror  2: V-Mirror 3:H-V-Mirror
        OB_DEVICE_PROPERTY_TOF_GAUSSIAN_FILTER_BOOL = 50, // 噪声滤波开关
        OB_DEVICE_PROPERTY_TOF_SCATTER_FILTER_BOOL = 51, // 散射滤波开关
        OB_DEVICE_PROPERTY_TOF_BILATERAL_FILTER_BOOL = 52, // 双边滤波开关
        OB_DEVICE_PROPERTY_TOF_FLY_POINT_FILTER_BOOL = 53, // 点云滤波开关
        OB_DEVICE_PROPERTY_TOF_MEDIAN_FILTER_BOOL = 54, // 中值滤波开关
        OB_DEVICE_PROPERTY_TOF_CONFIDENCE_FILTER_BOOL = 55, // 置信滤波开关
        OB_DEVICE_PROPERTY_TOF_SHUFFLE_MODE_BOOL = 56, // TOF Phase Shuffle模式
        OB_DEVICE_PROPERTY_REBOOT_DEVICE_BOOL = 57, // 设备重启
        OB_DEVICE_PROPERTY_FACTORY_RESET_BOOL = 58, // 恢复出厂设置
        OB_DEVICE_PROPERTY_IR_MODE_SWITCH_BOOL = 59, // IR模式 散斑(false)/纯净图(true) 切换
        OB_DEVICE_PROPERTY_FRAME_RATE_MODE_SWITCH_BOOL = 60, // 帧率 固定模式(false)/动态调整模式(true) 切换
        OB_DEVICE_PROPERTY_HARDWARE_DISTORTION_SWITCH_BOOL = 61, // 硬件去畸变开关 Rectify
        OB_DEVICE_PROPERTY_FAN_WORK_MODE_INT = 62, // 风扇开关模式
        OB_DEVICE_PROPERTY_DEPTH_ALIGN_HARDWARE_MODE_INT = 63, // 多分辨率D2C模式
        OB_DEVICE_PROPERTY_ANTI_COLLUSION_ACTIVATION_STATUS_BOOL = 64, // 防串货状态
        OB_DEVICE_PROPERTY_SOFTWARE_DISTORTION_SWITCH_BOOL = 65, // 软件去畸变开关 OBBoolPropertyRangeTran
        OB_DEVICE_PROPERTY_SYNC_MODE_INT = 66, // (倚天剑已弃用)同步模式 OBIntPropertyRangeTran
        OB_DEVICE_PROPERTY_SYNC_EXT_OUT_DELAY_TIME_INT = 67, // (倚天剑已弃用)配置同步信号延时us数后再triggler out输出 OBIntPropertyRangeTran
        OB_DEVICE_PROPERTY_IR_FRAME_RATE_INT = 68, // IR帧率设置，用于无法通过标准UVC协议设置帧率的设备
        OB_DEVICE_PROPERTY_DEPTH_FRAME_RATE_INT = 69, // Depth帧率设置，用于无法通过标准UVC协议设置帧率的设备
        OB_DEVICE_PROPERTY_TEC_MAX_CURRENT_INT = 70, // TEC 最大电流 -> 百分比 0~100%
        OB_DEVICE_PROPERTY_TEC_MAX_CURRENT_CONFIG_INT = 71, // TEC最大电流配置（掉电保存）
        OB_DEVICE_PROPERTY_FAN_WORK_MODE_CONFIG_INT = 72, // 风扇开关模式配置（掉电保存）
        OB_DEVICE_PROPERTY_DEPTH_BIT_PER_PIXEL_INT = 73, // Depth像素位数配置， 8/12/14/16 等，单位为bpp。实际图像帧中每像素占用的位数可以大于实际像素位数（如16bit深度图，有效像素位数为10bit）
        OB_DEVICE_PROPERTY_IR_BIT_PER_PIXEL_INT = 74, // IR像素位数配置， 8/12/14/16 等，单位为bpp
        OB_DEVICE_PROPERTY_DEPTH_UNIT_INT = 75, // 深度单位，mx6600: 0: 0.1mm, 1: 0.2mm, 2: 0.4mm, 3: 0.8mm, 4: 1.6mm -> 2^n/10mm
        OB_DEVICE_PROPERTY_TOF_FILTER_RANGE_INT = 76, // tof滤波场景范围配置
        OB_DEVICE_PROPERTY_STOP_COLOR_STREAM_BOOL = 77, // 关闭Color流，用于无法通过标准UVC协议关流的设备
        OB_DEVICE_PROPERTY_FACTORY_MODE_BOOL = 78, // 工程模式开关
        OB_DEVICE_PROPERTY_LASER_MODE_INT = 79, // mx6600 激光点亮模式，固件端目前只返回 1: IR Drive, 2: Torch
        OB_DEVICE_PROPERTY_SBG_RECTIFY_MODE_BOOL = 80, // mx6600 sbg rectify模式开关，0: Disable, 1: Rectify Enable
        OB_DEVICE_PROPERTY_COLOR_MIRROR_BOOL = 81, // 彩色镜像
        OB_DEVICE_PROPERTY_COLOR_FLIP_BOOL = 82, // 彩色翻转
        OB_DEVICE_PROPERTY_INDICATOR_LIGHT_BOOL = 83, // 指示灯开关，0: Disable， 1: Enable
        OB_DEVICE_PROPERTY_CALIBRATION_MODE_BOOL = 84, // 标定模式开关，0: Disable, 1: Enable

        // 1000~1999为设备端结构体控制命令
        // Device:: get/setStructedData
        OB_DATA_TYPE_VERSIONS = 1000, // 版本信息
        OB_DATA_TYPE_CAMERA_PARA = 1001, // 相机内外参数
        OB_DATA_TYPE_BASELINE_CALIBRATION_PARA = 1002, // 基线标定参数
        OB_DATA_TYPE_DEVICE_TEMPERATURE = 1003, // 设备温度信息
        OB_DATA_TYPE_DEVICE_AE_PARAMS = 1004, // AE调试参数
        OB_DATA_TYPE_EXTENSION_PARAMS = 1005, // 扩展参数
        OB_DATA_TYPE_DEVICE_UPGRADE_STATUS = 1006, // 固件升级状态 read only
        OB_DATA_TYPE_DEVICE_CALIBRATION_UPGRADE_STATUS = 1007, // 标定文件升级状态 read only
        OB_DATA_TYPE_DEVICE_FILE_TRAN_STATUS = 1008, // 文件传输状态 read only
        OB_DATA_TYPE_PTZ_CONTROL = 1009, // 云台控制
        OB_DATA_TYPE_DIGITAL_ZOOM = 1010, // 数字变焦
        OB_DATA_TYPE_TOF_TX_RX_TEMP = 1011, // TOF tx rx温度
        OB_DATA_TYPE_TOF_MODULATION_FREQ = 1012, // TOF调制频率信息
        OB_DATA_TYPE_TOF_DUTY_CYCLE = 1013, // TOF调制信号占空比信息
        OB_DATA_TYPE_TOF_CALIBRATION_PARA = 1014, // TOF标定参数
        OB_DATA_TYPE_TOF_DEPTH_COEF_PARA = 1015, // TOF距离转深度系数
        OB_DATA_TYPE_TOF_VCSEL_TEMP_COMPENSATION = 1016, // TOF温补系数
        OB_DATA_TYPE_TOF_GAUSSIAN_FILTER_PARA = 1017, // TOF高斯噪声滤波参数
        OB_DATA_TYPE_TOF_SCATTER_FILTER_PARA = 1018, // TOF散射滤波参数
        OB_DATA_TYPE_TOF_BILATERAL_FILTER_PARA = 1019, // TOF双边滤波参数
        OB_DATA_TYPE_TOF_FLY_POINT_FILTER_PARA = 1020, // TOF点云滤波参数
        OB_DATA_TYPE_TOF_MEDIAN_FILTER_PARA = 1021, // TOF中值滤波参数
        OB_DATA_TYPE_TOF_CONFIDENCE_FILTER_PARA = 1022, // TOF置信滤波参数
        OB_DATA_TYPE_TOF_NEAREST_FARTHEST_LENGTH = 1023, // TOF最近与最远距离
        OB_DATA_TYPE_TOF_EXPOSURE_THRESHOLD_CONTROL = 1024, // TOF曝光阈值范围
        OB_DATA_TYPE_DEVICE_STATE = 1025, // 获取当前设备状态
        OB_DATA_TYPE_TEC_DATA = 1026, // 获取TEC数据
        OB_DATA_TYPE_GPM_CONFIG_DATA = 1027, // GPM配置数据，包括16个坐标和相关的阈值
        OB_DATA_TYPE_GPM_STATUS_DATA = 1028, // 获取GPM状态数据,包括16个点机及其统计信息
        OB_DATA_TYPE_ANTI_COLLUSION_ACTIVATION_CONTENT = 1029, // 防串货激活码读写
        OB_DATA_TYPE_ANTI_COLLUSION_ACTIVATION_VERIFY = 1030, // 防串货激活码验证
        OB_DATA_TYPE_GET_GYRO_PRESETS_ODR_LIST = 1031, // 获取陀螺仪支持的采样率列表
        OB_DATA_TYPE_GET_ACCEL_PRESETS_ODR_LIST = 1032, // 获取加速度计支持的采样率列表
        OB_DATA_TYPE_GET_GYRO_PRESETS_FULL_SCALE_LIST = 1033, // 获取陀螺仪支持的量程列表
        OB_DATA_TYPE_GET_ACCEL_PRESETS_FULL_SCALE_LIST = 1034, // 获取加速度计支持的量程列表
        OB_DATA_TYPE_DEVICE_SERIAL_NUMBER = 1035, // get/set序列号
        OB_DATA_TYPE_DEVICE_PRODUCT_NUMBER = 1036, // get/set PN
        OB_DATA_TYPE_DEVICE_TIME = 1037, // get/set device time
        OB_DATA_TYPE_TOF_MULTI_DEVICE_SYNC_CONFIG = 1038, // 多设备同步模式和参数配置
        OB_DATA_TYPE_TEMP_COMPENSATE_PARA = 1039, // get/set 温度补偿系数

        // 2000~2999为Sensor控制命令
        // Sensor::get/setxxxProperty、 getxxxPropertyRange (xxx表示数据类型)
        OB_SENSOR_PROPERTY_ENABLE_AUTO_EXPOSURE_BOOL = 2000, // 自动曝光
        OB_SENSOR_PROPERTY_EXPOSURE_INT = 2001, // 曝光调节
        OB_SENSOR_PROPERTY_GAIN_INT = 2002, // 增益调节
        OB_SENSOR_PROPERTY_ENABLE_AUTO_WHITE_BALANCE_BOOL = 2003, // 自动白平衡
        OB_SENSOR_PROPERTY_WHITE_BALANCE_INT = 2004, // 白平衡调节
        OB_SENSOR_PROPERTY_BRIGHTNESS_INT = 2005, // 亮度调节
        OB_SENSOR_PROPERTY_SHARPNESS_INT = 2006, // 锐度调节

        // 用白平衡调节代替色温调节
        // OB_SENSOR_PROPERTY_COLOR_TEMPERATURE_INT                                = 2007,  // 色温调节
        OB_SENSOR_PROPERTY_SATURATION_INT = 2008, // 饱和度调节
        OB_SENSOR_PROPERTY_CONTRAST_INT = 2009, // 对比度调节
        OB_SENSOR_PROPERTY_GAMMA_INT = 2010, // 伽马值调节
        OB_SENSOR_PROPERTY_ROLL_INT = 2011, // 图像旋转
        OB_SENSOR_PROPERTY_AUTO_EXPOSURE_PRIORITY_INT = 2012, // 自动曝光优先
        OB_SENSOR_PROPERTY_BACKLIGHT_COMPENSATION_INT = 2013, // 亮度补偿
        OB_SENSOR_PROPERTY_HUE_INT = 2014, // 彩色色调
        OB_SENSOR_PROPERTY_POWER_LINE_FREQUENCY_INT = 2015, // 电力线路频率

        // MIRROR 和 FLIP 通过私有协议控制命令实现
        // OB_SENSOR_PROPERTY_MIRROR_BOOL                                          = 2016,  // 图像镜像
        // OB_SENSOR_PROPERTY_FLIP_BOOL                                            = 2017,  // 图像翻转
        // 以上Sensor控制命令会被转换成标准UVC控制协议命令
        // OB_SENSOR_PROPERTY_ID_INT                                               = 2018,  // SensorID
        OB_SENSOR_PROPERTY_GYRO_SWITCH_BOOL = 2019, // 陀螺仪开关
        OB_SENSOR_PROPERTY_ACCEL_SWITCH_BOOL = 2020, // 加速度计开关
        OB_SENSOR_PROPERTY_GYRO_ODR_INT = 2021, // get/set当前陀螺仪的采样率
        OB_SENSOR_PROPERTY_ACCEL_ODR_INT = 2022, // get/set当前加速度计的采样率
        OB_SENSOR_PROPERTY_GYRO_FULL_SCALE_INT = 2023, // get/set当前陀螺仪的量程
        OB_SENSOR_PROPERTY_ACCEL_FULL_SCALE_INT = 2024, // get/set当前加速度计的量程

        // 3000~3499为SDK int, bool及float类型控制命令
        // Device:: get/setxxxProperty、 getxxxPropertyRange (xxx表示数据类型)
        OB_SDK_PROPERTY_DEPTH_SOFT_FILTER_BOOL = 3000, // 软件滤波开关
        OB_SDK_PROPERTY_DEPTH_MAX_DIFF_INT = 3001, // soft filter maxdiff param
        OB_SDK_PROPERTY_DEPTH_MAX_SPECKLE_SIZE_INT = 3002, // soft filter maxSpeckleSize
        OB_SDK_PROPERTY_SOFT_FILTER_TYPE_BOOL = 3003, // soft filter filterType ,0-disparity 1-depth
        OB_SDK_PROPERTY_DISPARITY_TO_DEPTH_BOOL = 3004, // convert disparity to depth
        OB_SDK_PROPERTY_IR_MIRROR_BOOL = 3005, // SDK ir mirror
        OB_SDK_PROPERTY_DEPTH_RLE_DECODE_BOOL = 3006, // DEPTH RLE decode使能(开深度RLE流时有效)

        // 3500~3999为SDK结构体控制命令
        OB_SDK_DATA_DEPTH_VALUE_LIMIT_RANGE = 3500, // DEPTH VALUE LIMIT(深度最大值、最小值, unit: mm)

        // 4000~4999为RawData控制命令
        // Device:: get/setRawData
        OB_RAW_DATA_MULTIPLE_DISTANCE_CALIBRATION_PARA = 4000, // 多距离标定参数
        OB_RAW_DATA_REFERENCE_IMAGE = 4001, // 参考图
        OB_RAW_DATA_CAMERA_CFG_PARAMETER_960_1280 = 4002, // 对应960_1280分辨率的相机配置参数 write only
        OB_RAW_DATA_CAMERA_CFG_PARAMETER_720_1280 = 4003, // 对应720_1280分辨率的相机配置参数  write only
        OB_RAW_DATA_CAMERA_CFG_PARAMETER_1280_720 = 4004, // 对应720_1280分辨率的相机配置参数  write only
        OB_RAW_DATA_HARDWARE_ALIGN_PARA = 4005, // 硬件对齐参数
        OB_RAW_DATA_SOFTWARE_ALIGN_PARA = 4006, // 软件对齐参数
        OB_RAW_DATA_HARDWARE_DISTORTION_PARA = 4007, // 硬件去畸变参数
        OB_RAW_DATA_DEPTH_CONFIG_PARA = 4008, // Config区
        OB_RAW_DATA_HARDWARE_ALIGN_PARA_0 = 4009, // 硬件对齐参数0, 适用与多分辨率对齐场景，由设备决定HARDWARE_ALIGN_PARA_xxx 与分辨率的映射关系
        OB_RAW_DATA_HARDWARE_ALIGN_PARA_1 = 4010, // 硬件对齐参数1
        OB_RAW_DATA_HARDWARE_ALIGN_PARA_2 = 4011, // 硬件对齐参数2
        OB_RAW_DATA_HARDWARE_ALIGN_PARA_3 = 4012, // 硬件对齐参数3
        OB_RAW_DATA_HARDWARE_ALIGN_PARA_4 = 4013, // 硬件对齐参数4
        OB_RAW_DATA_HARDWARE_ALIGN_PARA_5 = 4014, // 硬件对齐参数5
        OB_RAW_DATA_TEMP_COMPENSATE_PARA = 4015, // 温补参数
        OB_RAW_DATA_SOFTWARE_ALIGN_PARA_0 = 4016, // 软件对齐参数0, 适用与多分辨率对齐场景，由设备决定HARDWARE_ALIGN_PARA_xxx 与分辨率的映射关系
        OB_RAW_DATA_SOFTWARE_ALIGN_PARA_1 = 4017, // 软件对齐参数1
        OB_RAW_DATA_SOFTWARE_ALIGN_PARA_2 = 4018, // 软件对齐参数2
        OB_RAW_DATA_SOFTWARE_ALIGN_PARA_3 = 4019, // 软件对齐参数3
        OB_RAW_DATA_SOFTWARE_ALIGN_PARA_4 = 4020, // 软件对齐参数4
        OB_RAW_DATA_SOFTWARE_ALIGN_PARA_5 = 4021, // 软件对齐参数5
        OB_RAW_DATA_DEPTH_CALIB_FLASH_FILE = 4022, // 深度标定参数文件(MX6600)
        OB_RAW_DATA_ALIGN_CALIB_FLASH_FILE = 4023, // 对齐标定参数文件(MX6600)

        // 5000~5499为调试用int, bool及float类型控制命令
        // Device:: get/setxxxProperty、 getxxxPropertyRange (xxx表示数据类型)
        OB_DEVICE_DEBUG_ADB_FUNCTION_CONTROL_BOOL = 5000, // ADB调试功能开关
        OB_DEVICE_DEBUG_SET_FORCE_UPGRADE_BOOL = 5001, // 强制升级
        OB_DEVICE_DEBUG_MX6300_START_TIME_INT = 5002, // 获取MX6300固件启动时间

        // 5500~5999为调试用结构体控制命令
        // Device:: get/setStructedData
        OB_DEVICE_DEBUG_RECORD_RGB_DATA = 5500, // 设备端 RGB 传图控制（调试功能）
        OB_DEVICE_DEBUG_RECORD_PHASE_DATA = 5501, // 设备端 raw Phase 传图控制（调试功能）
        OB_DEVICE_DEBUG_RECORD_IR_DATA = 5502, // 设备端 IR 传图控制（调试功能）
        OB_DEVICE_DEBUG_RECORD_DEPTH_DATA = 5503, // 设备端 depth 传图控制（调试功能）
    }
public struct ob_global_unified_property_item
{
    OBGlobalUnifiedProperty     id;    // 属性id
    string                 name;  // 属性名字
    ob_global_unified_property_type type;  // 属性类型
}
/// <summary>
/// 用于描述所有属性设置的数据类型
/// </summary>
public enum ob_global_unified_property_type
{
    OB_BOOL_PROPERTY   = 0,  // bool类型数据的属性
    OB_INT_PROPERTY    = 1,  // int类型数据的属性
    OB_FLOAT_PROPERTY  = 2,  // float类型数据的属性
    OB_STRUCT_PROPERTY = 3,  // struct类型数据的属性
}
/// <summary>
/// log等级
/// </summary>
public enum ob_log_severity
{
    OB_LOG_SEVERITY_DEBUG,
    OB_LOG_SEVERITY_INFO,
    OB_LOG_SEVERITY_WARN,
    OB_LOG_SEVERITY_ERROR,
    OB_LOG_SEVERITY_FATAL,
    OB_LOG_SEVERITY_NONE
    // OB_LOG_SEVERITY_COUNT
}

/// <summary>
/// 描述传感器类型的枚举值
/// </summary>
public enum ob_sensor_type
{
    OB_SENSOR_UNKNOWN = 0,
    OB_SENSOR_IR = 1,
    OB_SENSOR_COLOR = 2,
    OB_SENSOR_DEPTH = 3,
    OB_SENSOR_ACCEL = 4,
    OB_SENSOR_GYRO = 5,
}

/// <summary>
/// 错误码
/// </summary>
public enum ob_status
{
    OB_STATUS_OK = 0,
    OB_STATUS_ERROR = 1
}

public enum OBGlobalUnifiedProperty
    {
            // 0~999为设备端int, bool及float类型控制命令
    // Device:: get/setxxxProperty、 getxxxPropertyRange (xxx表示数据类型)
    OB_DEVICE_PROPERTY_FLASH_WRITE_PROTECTION_BOOL                     = 0,   // FLASH写保护开关；0，关闭；1，开启
    OB_DEVICE_PROPERTY_TEC_ENABLE_BOOL                                 = 1,   // TEC开关
    OB_DEVICE_PROPERTY_LDP_BOOL                                        = 2,   // LDP开关
    OB_DEVICE_PROPERTY_EMITTER_BOOL                                    = 3,   // 激光开光
    OB_DEVICE_PROPERTY_LASER_PULSE_WIDTH_INT                           = 4,   // 读写激光Time值（脉宽）,
    OB_DEVICE_PROPERTY_LASER_CURRENT_FLOAT                             = 5,   // 激光电流
    OB_DEVICE_PROPERTY_FLOOD_BOOL                                      = 6,   // 泛光灯开关
    OB_DEVICE_PROPERTY_FLOOD_LEVEL_INT                                 = 7,   // 泛光灯等级
    OB_DEVICE_PROPERTY_TEMPERATURE_COMPENSATION_ENABLE_BOOL            = 8,   // 温度补偿开关
    OB_DEVICE_PROPERTY_TEMPERATURE_CALIBRATED_IR_FLOAT                 = 9,   // IR标定温度
    OB_DEVICE_PROPERTY_TEMPERATURE_CALIBRATED_LDMP_FLOAT               = 10,  // 激光标定温度
    OB_DEVICE_PROPERTY_TEMPERATURE_COMPENSATION_COEFFICIENT_IR_FLOAT   = 11,  // IR温补系数
    OB_DEVICE_PROPERTY_TEMPERATURE_COMPENSATION_COEFFICIENT_LDMP_FLOAT = 12,  // 激光温补系数
    OB_DEVICE_PROPERTY_DEPTH_ALIGN_SOFTWARE_BOOL                       = 13,  // 软件D2C
    OB_DEVICE_PROPERTY_DEPTH_MIRROR_BOOL                               = 14,  // 深度镜像
    OB_DEVICE_PROPERTY_DEPTH_FLIP_BOOL                                 = 15,  // 深度翻转
    OB_DEVICE_PROPERTY_DEPTH_POSTFILTER_BOOL                           = 16,  // 深度Postfilter
    OB_DEVICE_PROPERTY_DEPTH_HOLEFILTER_BOOL                           = 17,  // 深度Holefilter
    OB_DEVICE_PROPERTY_IR_MIRROR_BOOL                                  = 18,  // IR 镜像
    OB_DEVICE_PROPERTY_IR_FLIP_BOOL                                    = 19,  // IR 翻转
    OB_DEVICE_PROPERTY_IR_SWITCH_BOOL                                  = 20,  // IR 左右切换
    OB_DEVICE_PROPERTY_HARDWARE_SYNC_BOOL                              = 21,  // 开启硬件同步
    OB_DEVICE_PROPERTY_MIN_DEPTH_INT                                   = 22,  // 最小深度阈值
    OB_DEVICE_PROPERTY_MAX_DEPTH_INT                                   = 23,  // 最大深度阈值
    OB_DEVICE_PROPERTY_DEPTH_SOFT_FILTER_BOOL                          = 24,  // 软件滤波开关
    OB_DEVICE_PROPERTY_ZERO_PLANE_DISTANCE_FLOAT                       = 25,  // ZPD
    OB_DEVICE_PROPERTY_ZERO_PLANE_PIXEL_SIZE_FLOAT                     = 26,  // ZPPS
    OB_DEVICE_PROPERTY_CHIP_TYPE_INT                                   = 27,  // 芯片类型
    OB_DEVICE_PROPERTY_USB_SPEED_INT                                   = 28,  // usb speed
    OB_DEVICE_PROPERTY_SOFT_RESET_BOOL                                 = 29,  // 软件复位
    OB_DEVICE_PROPERTY_LDP_THRES_UP_INT                                = 30,  // LDP阈值的上限
    OB_DEVICE_PROPERTY_LDP_THRES_LOW_INT                               = 31,  // LDP阈值的下限
    OB_DEVICE_PROPERTY_LDP_STATUS_BOOL                                 = 32,  // LDP状态
    OB_DEVICE_PROPERTY_LASER_TEMPERATURE_FLOAT                         = 33,  // 获取激光温度
    OB_DEVICE_PROPERTY_BOOTLOADER_WRITE_PROTECTION_STATUS_BOOL         = 34,  // Bootloader区flash写保护状态
    OB_DEVICE_PROPERTY_RT_IR_TEMP_FLOAT                                = 35,  // 获取实时IR温度
    OB_DEVICE_PROPERTY_RT_LDMP_TEMP_FLOAT                              = 36,  // 获取实时LDMP温度
    OB_DEVICE_PROPERTY_RT_RGB_TEMP_FLOAT                               = 37,  // 获取实时RGB温度
    OB_DEVICE_PROPERTY_STOP_DEPTH_STREAM_BOOL                          = 38,  // 关闭深度流，用于无法通过标准UVC协议关流的设备
    OB_DEVICE_PROPERTY_STOP_IR_STREAM_BOOL                             = 39,  // 关闭IR流用于无法通过标准UVC协议关流的设备
    OB_DEVICE_PROPERTY_DEPTH_MAX_DIFF_INT                              = 40,  // soft filter maxdiff param
    OB_DEVICE_PROPERTY_DEPTH_MAX_SPECKLE_SIZE_INT                      = 41,  // soft filter maxSpeckleSize
    OB_DEVICE_PROPERTY_DEPTH_ALIGN_HARDWARE_BOOL                       = 42,  // 硬件d2c开
    OB_DEVICE_PROPERTY_TIMESTAMP_OFFSET_INT                            = 43,  // 时间戳调校
    OB_DEVICE_PROPERTY_ORIENTATION_SWITCH_BOOL                         = 44,  // 横竖屏切换, 0:竖屏，1横屏
    OB_DEVICE_PROPERTY_ENABLE_CALIBRATION_BOOL                         = 45,  // 是否需要裁剪
    // OB_DEVICE_PROPERTY_TOF_FPS_INT                                          = 46,  // TOF帧率
    OB_DEVICE_PROPERTY_TOF_EXPOSURE_TIME_INT                 = 47,  // TOF曝光时间
    OB_DEVICE_PROPERTY_TOF_GAIN_INT                          = 48,  // TOF增益
    OB_DEVICE_PROPERTY_TOF_MIRROR_INT                        = 49,  // TOF镜像开光, 0: close 1:H-Mirror  2: V-Mirror 3:H-V-Mirror
    OB_DEVICE_PROPERTY_TOF_GAUSSIAN_FILTER_BOOL              = 50,  // 噪声滤波开关
    OB_DEVICE_PROPERTY_TOF_SCATTER_FILTER_BOOL               = 51,  // 散射滤波开关
    OB_DEVICE_PROPERTY_TOF_BILATERAL_FILTER_BOOL             = 52,  // 双边滤波开关
    OB_DEVICE_PROPERTY_TOF_FLY_POINT_FILTER_BOOL             = 53,  // 点云滤波开关
    OB_DEVICE_PROPERTY_TOF_MEDIAN_FILTER_BOOL                = 54,  // 中值滤波开关
    OB_DEVICE_PROPERTY_TOF_CONFIDENCE_FILTER_BOOL            = 55,  // 置信滤波开关
    OB_DEVICE_PROPERTY_TOF_SHUFFLE_MODE_BOOL                 = 56,  // TOF Phase Shuffle模式
    OB_DEVICE_PROPERTY_REBOOT_DEVICE_BOOL                    = 57,  // 设备重启
    OB_DEVICE_PROPERTY_FACTORY_RESET_BOOL                    = 58,  // 恢复出厂设置
    OB_DEVICE_PROPERTY_IR_MODE_SWITCH_BOOL                   = 59,  // IR模式 散斑(false)/纯净图(true) 切换
    OB_DEVICE_PROPERTY_FRAME_RATE_MODE_SWITCH_BOOL           = 60,  // 帧率 固定模式(false)/动态调整模式(true) 切换
    OB_DEVICE_PROPERTY_HARDWARE_DISTORTION_SWITCH_BOOL       = 61,  // 硬件去畸变开关 Rectify
    OB_DEVICE_PROPERTY_FAN_WORK_MODE_INT                     = 62,  // 风扇开关模式
    OB_DEVICE_PROPERTY_DEPTH_ALIGN_HARDWARE_MODE_INT         = 63,  // 多分辨率D2C模式
    OB_DEVICE_PROPERTY_ANTI_COLLUSION_ACTIVATION_STATUS_BOOL = 64,  // 防串货状态
    OB_DEVICE_PROPERTY_SOFTWARE_DISTORTION_SWITCH_BOOL       = 65,  // 软件去畸变开关 OBBoolPropertyRangeTran
    OB_DEVICE_PROPERTY_SYNC_MODE_INT                         = 66,  // (倚天剑已弃用)同步模式 OBIntPropertyRangeTran
    OB_DEVICE_PROPERTY_SYNC_EXT_OUT_DELAY_TIME_INT           = 67,  // (倚天剑已弃用)配置同步信号延时us数后再triggler out输出 OBIntPropertyRangeTran
    OB_DEVICE_PROPERTY_IR_FRAME_RATE_INT                     = 68,  // IR帧率设置，用于无法通过标准UVC协议设置帧率的设备
    OB_DEVICE_PROPERTY_DEPTH_FRAME_RATE_INT                  = 69,  // Depth帧率设置，用于无法通过标准UVC协议设置帧率的设备
    OB_DEVICE_PROPERTY_TEC_MAX_CURRENT_INT                   = 70,  // TEC 最大电流 -> 百分比 0~100%
    OB_DEVICE_PROPERTY_TEC_MAX_CURRENT_CONFIG_INT            = 71,  // TEC最大电流配置（掉电保存）
    OB_DEVICE_PROPERTY_FAN_WORK_MODE_CONFIG_INT              = 72,  // 风扇开关模式配置（掉电保存）
    OB_DEVICE_PROPERTY_DEPTH_BIT_PER_PIXEL_INT = 73,  // Depth像素位数配置， 8/12/14/16 等，单位为bpp。实际图像帧中每像素占用的位数可以大于实际像素位数（如16bit深度图，有效像素位数为10bit）
    OB_DEVICE_PROPERTY_IR_BIT_PER_PIXEL_INT   = 74,  // IR像素位数配置， 8/12/14/16 等，单位为bpp
    OB_DEVICE_PROPERTY_DEPTH_UNIT_INT         = 75,  // 深度单位，mx6600: 0: 0.1mm, 1: 0.2mm, 2: 0.4mm, 3: 0.8mm, 4: 1.6mm -> 2^n/10mm
    OB_DEVICE_PROPERTY_TOF_FILTER_RANGE_INT   = 76,  // tof滤波场景范围配置
    OB_DEVICE_PROPERTY_STOP_COLOR_STREAM_BOOL = 77,  // 关闭Color流，用于无法通过标准UVC协议关流的设备
    OB_DEVICE_PROPERTY_FACTORY_MODE_BOOL      = 78,  // 工程模式开关
    OB_DEVICE_PROPERTY_LASER_MODE_INT         = 79,  // mx6600 激光点亮模式，固件端目前只返回 1: IR Drive, 2: Torch
    OB_DEVICE_PROPERTY_SBG_RECTIFY_MODE_BOOL  = 80,  // mx6600 sbg rectify模式开关，0: Disable, 1: Rectify Enable
    OB_DEVICE_PROPERTY_COLOR_MIRROR_BOOL      = 81,  // 彩色镜像
    OB_DEVICE_PROPERTY_COLOR_FLIP_BOOL        = 82,  // 彩色翻转
    OB_DEVICE_PROPERTY_INDICATOR_LIGHT_BOOL   = 83,  // 指示灯开关，0: Disable， 1: Enable
    OB_DEVICE_PROPERTY_CALIBRATION_MODE_BOOL  = 84,  // 标定模式开关，0: Disable, 1: Enable

    // 1000~1999为设备端结构体控制命令
    // Device:: get/setStructedData
    OB_DATA_TYPE_VERSIONS                          = 1000,  // 版本信息
    OB_DATA_TYPE_CAMERA_PARA                       = 1001,  // 相机内外参数
    OB_DATA_TYPE_BASELINE_CALIBRATION_PARA         = 1002,  // 基线标定参数
    OB_DATA_TYPE_DEVICE_TEMPERATURE                = 1003,  // 设备温度信息
    OB_DATA_TYPE_DEVICE_AE_PARAMS                  = 1004,  // AE调试参数
    OB_DATA_TYPE_EXTENSION_PARAMS                  = 1005,  // 扩展参数
    OB_DATA_TYPE_DEVICE_UPGRADE_STATUS             = 1006,  // 固件升级状态 read only
    OB_DATA_TYPE_DEVICE_CALIBRATION_UPGRADE_STATUS = 1007,  // 标定文件升级状态 read only
    OB_DATA_TYPE_DEVICE_FILE_TRAN_STATUS           = 1008,  // 文件传输状态 read only
    OB_DATA_TYPE_PTZ_CONTROL                       = 1009,  // 云台控制
    OB_DATA_TYPE_DIGITAL_ZOOM                      = 1010,  // 数字变焦
    OB_DATA_TYPE_TOF_TX_RX_TEMP                    = 1011,  // TOF tx rx温度
    OB_DATA_TYPE_TOF_MODULATION_FREQ               = 1012,  // TOF调制频率信息
    OB_DATA_TYPE_TOF_DUTY_CYCLE                    = 1013,  // TOF调制信号占空比信息
    OB_DATA_TYPE_TOF_CALIBRATION_PARA              = 1014,  // TOF标定参数
    OB_DATA_TYPE_TOF_DEPTH_COEF_PARA               = 1015,  // TOF距离转深度系数
    OB_DATA_TYPE_TOF_VCSEL_TEMP_COMPENSATION       = 1016,  // TOF温补系数
    OB_DATA_TYPE_TOF_GAUSSIAN_FILTER_PARA          = 1017,  // TOF高斯噪声滤波参数
    OB_DATA_TYPE_TOF_SCATTER_FILTER_PARA           = 1018,  // TOF散射滤波参数
    OB_DATA_TYPE_TOF_BILATERAL_FILTER_PARA         = 1019,  // TOF双边滤波参数
    OB_DATA_TYPE_TOF_FLY_POINT_FILTER_PARA         = 1020,  // TOF点云滤波参数
    OB_DATA_TYPE_TOF_MEDIAN_FILTER_PARA            = 1021,  // TOF中值滤波参数
    OB_DATA_TYPE_TOF_CONFIDENCE_FILTER_PARA        = 1022,  // TOF置信滤波参数
    OB_DATA_TYPE_TOF_NEAREST_FARTHEST_LENGTH       = 1023,  // TOF最近与最远距离
    OB_DATA_TYPE_TOF_EXPOSURE_THRESHOLD_CONTROL    = 1024,  // TOF曝光阈值范围
    OB_DATA_TYPE_DEVICE_STATE                      = 1025,  // 获取当前设备状态
    OB_DATA_TYPE_TEC_DATA                          = 1026,  // 获取TEC数据
    OB_DATA_TYPE_GPM_CONFIG_DATA                   = 1027,  // GPM配置数据，包括16个坐标和相关的阈值
    OB_DATA_TYPE_GPM_STATUS_DATA                   = 1028,  // 获取GPM状态数据,包括16个点机及其统计信息
    OB_DATA_TYPE_ANTI_COLLUSION_ACTIVATION_CONTENT = 1029,  // 防串货激活码读写
    OB_DATA_TYPE_ANTI_COLLUSION_ACTIVATION_VERIFY  = 1030,  // 防串货激活码验证
    OB_DATA_TYPE_GET_GYRO_PRESETS_ODR_LIST         = 1031,  // 获取陀螺仪支持的采样率列表
    OB_DATA_TYPE_GET_ACCEL_PRESETS_ODR_LIST        = 1032,  // 获取加速度计支持的采样率列表
    OB_DATA_TYPE_GET_GYRO_PRESETS_FULL_SCALE_LIST  = 1033,  // 获取陀螺仪支持的量程列表
    OB_DATA_TYPE_GET_ACCEL_PRESETS_FULL_SCALE_LIST = 1034,  // 获取加速度计支持的量程列表
    OB_DATA_TYPE_DEVICE_SERIAL_NUMBER              = 1035,  // get/set序列号
    OB_DATA_TYPE_DEVICE_PRODUCT_NUMBER             = 1036,  // get/set PN
    OB_DATA_TYPE_DEVICE_TIME                       = 1037,  // get/set device time
    OB_DATA_TYPE_TOF_MULTI_DEVICE_SYNC_CONFIG      = 1038,  // 多设备同步模式和参数配置
    OB_DATA_TYPE_TEMP_COMPENSATE_PARA              = 1039,  // get/set 温度补偿系数

    // 2000~2999为Sensor控制命令
    // Sensor::get/setxxxProperty、 getxxxPropertyRange (xxx表示数据类型)
    OB_SENSOR_PROPERTY_ENABLE_AUTO_EXPOSURE_BOOL      = 2000,  // 自动曝光
    OB_SENSOR_PROPERTY_EXPOSURE_INT                   = 2001,  // 曝光调节
    OB_SENSOR_PROPERTY_GAIN_INT                       = 2002,  // 增益调节
    OB_SENSOR_PROPERTY_ENABLE_AUTO_WHITE_BALANCE_BOOL = 2003,  // 自动白平衡
    OB_SENSOR_PROPERTY_WHITE_BALANCE_INT              = 2004,  // 白平衡调节
    OB_SENSOR_PROPERTY_BRIGHTNESS_INT                 = 2005,  // 亮度调节
    OB_SENSOR_PROPERTY_SHARPNESS_INT                  = 2006,  // 锐度调节
    // 用白平衡调节代替色温调节
    // OB_SENSOR_PROPERTY_COLOR_TEMPERATURE_INT                                = 2007,  // 色温调节
    OB_SENSOR_PROPERTY_SATURATION_INT             = 2008,  // 饱和度调节
    OB_SENSOR_PROPERTY_CONTRAST_INT               = 2009,  // 对比度调节
    OB_SENSOR_PROPERTY_GAMMA_INT                  = 2010,  // 伽马值调节
    OB_SENSOR_PROPERTY_ROLL_INT                   = 2011,  // 图像旋转
    OB_SENSOR_PROPERTY_AUTO_EXPOSURE_PRIORITY_INT = 2012,  // 自动曝光优先
    OB_SENSOR_PROPERTY_BACKLIGHT_COMPENSATION_INT = 2013,  // 亮度补偿
    OB_SENSOR_PROPERTY_HUE_INT                    = 2014,  // 彩色色调
    OB_SENSOR_PROPERTY_POWER_LINE_FREQUENCY_INT   = 2015,  // 电力线路频率
    // MIRROR 和 FLIP 通过私有协议控制命令实现
    // OB_SENSOR_PROPERTY_MIRROR_BOOL                                          = 2016,  // 图像镜像
    // OB_SENSOR_PROPERTY_FLIP_BOOL                                            = 2017,  // 图像翻转
    // 以上Sensor控制命令会被转换成标准UVC控制协议命令
    // OB_SENSOR_PROPERTY_ID_INT                                               = 2018,  // SensorID
    OB_SENSOR_PROPERTY_GYRO_SWITCH_BOOL     = 2019,  // 陀螺仪开关
    OB_SENSOR_PROPERTY_ACCEL_SWITCH_BOOL    = 2020,  // 加速度计开关
    OB_SENSOR_PROPERTY_GYRO_ODR_INT         = 2021,  // get/set当前陀螺仪的采样率
    OB_SENSOR_PROPERTY_ACCEL_ODR_INT        = 2022,  // get/set当前加速度计的采样率
    OB_SENSOR_PROPERTY_GYRO_FULL_SCALE_INT  = 2023,  // get/set当前陀螺仪的量程
    OB_SENSOR_PROPERTY_ACCEL_FULL_SCALE_INT = 2024,  // get/set当前加速度计的量程

    // 3000~3499为SDK int, bool及float类型控制命令
    // Device:: get/setxxxProperty、 getxxxPropertyRange (xxx表示数据类型)
    OB_SDK_PROPERTY_DEPTH_SOFT_FILTER_BOOL     = 3000,  // 软件滤波开关
    OB_SDK_PROPERTY_DEPTH_MAX_DIFF_INT         = 3001,  // soft filter maxdiff param
    OB_SDK_PROPERTY_DEPTH_MAX_SPECKLE_SIZE_INT = 3002,  // soft filter maxSpeckleSize
    OB_SDK_PROPERTY_SOFT_FILTER_TYPE_BOOL      = 3003,  // soft filter filterType ,0-disparity 1-depth
    OB_SDK_PROPERTY_DISPARITY_TO_DEPTH_BOOL    = 3004,  // convert disparity to depth
    OB_SDK_PROPERTY_IR_MIRROR_BOOL             = 3005,  // SDK ir mirror
    OB_SDK_PROPERTY_DEPTH_RLE_DECODE_BOOL      = 3006,  // DEPTH RLE decode使能(开深度RLE流时有效)

    // 3500~3999为SDK结构体控制命令
    OB_SDK_DATA_DEPTH_VALUE_LIMIT_RANGE = 3500,  // DEPTH VALUE LIMIT(深度最大值、最小值, unit: mm)

    // 4000~4999为RawData控制命令
    // Device:: get/setRawData
    OB_RAW_DATA_MULTIPLE_DISTANCE_CALIBRATION_PARA = 4000,  // 多距离标定参数
    OB_RAW_DATA_REFERENCE_IMAGE                    = 4001,  // 参考图
    OB_RAW_DATA_CAMERA_CFG_PARAMETER_960_1280      = 4002,  // 对应960_1280分辨率的相机配置参数 write only
    OB_RAW_DATA_CAMERA_CFG_PARAMETER_720_1280      = 4003,  // 对应720_1280分辨率的相机配置参数  write only
    OB_RAW_DATA_CAMERA_CFG_PARAMETER_1280_720      = 4004,  // 对应720_1280分辨率的相机配置参数  write only
    OB_RAW_DATA_HARDWARE_ALIGN_PARA                = 4005,  // 硬件对齐参数
    OB_RAW_DATA_SOFTWARE_ALIGN_PARA                = 4006,  // 软件对齐参数
    OB_RAW_DATA_HARDWARE_DISTORTION_PARA           = 4007,  // 硬件去畸变参数
    OB_RAW_DATA_DEPTH_CONFIG_PARA                  = 4008,  // Config区
    OB_RAW_DATA_HARDWARE_ALIGN_PARA_0              = 4009,  // 硬件对齐参数0, 适用与多分辨率对齐场景，由设备决定HARDWARE_ALIGN_PARA_xxx 与分辨率的映射关系
    OB_RAW_DATA_HARDWARE_ALIGN_PARA_1              = 4010,  // 硬件对齐参数1
    OB_RAW_DATA_HARDWARE_ALIGN_PARA_2              = 4011,  // 硬件对齐参数2
    OB_RAW_DATA_HARDWARE_ALIGN_PARA_3              = 4012,  // 硬件对齐参数3
    OB_RAW_DATA_HARDWARE_ALIGN_PARA_4              = 4013,  // 硬件对齐参数4
    OB_RAW_DATA_HARDWARE_ALIGN_PARA_5              = 4014,  // 硬件对齐参数5
    OB_RAW_DATA_TEMP_COMPENSATE_PARA               = 4015,  // 温补参数
    OB_RAW_DATA_SOFTWARE_ALIGN_PARA_0              = 4016,  // 软件对齐参数0, 适用与多分辨率对齐场景，由设备决定HARDWARE_ALIGN_PARA_xxx 与分辨率的映射关系
    OB_RAW_DATA_SOFTWARE_ALIGN_PARA_1              = 4017,  // 软件对齐参数1
    OB_RAW_DATA_SOFTWARE_ALIGN_PARA_2              = 4018,  // 软件对齐参数2
    OB_RAW_DATA_SOFTWARE_ALIGN_PARA_3              = 4019,  // 软件对齐参数3
    OB_RAW_DATA_SOFTWARE_ALIGN_PARA_4              = 4020,  // 软件对齐参数4
    OB_RAW_DATA_SOFTWARE_ALIGN_PARA_5              = 4021,  // 软件对齐参数5
    OB_RAW_DATA_DEPTH_CALIB_FLASH_FILE             = 4022,  // 深度标定参数文件(MX6600)
    OB_RAW_DATA_ALIGN_CALIB_FLASH_FILE             = 4023,  // 对齐标定参数文件(MX6600)

    // 5000~5499为调试用int, bool及float类型控制命令
    // Device:: get/setxxxProperty、 getxxxPropertyRange (xxx表示数据类型)
    OB_DEVICE_DEBUG_ADB_FUNCTION_CONTROL_BOOL = 5000,  // ADB调试功能开关
    OB_DEVICE_DEBUG_SET_FORCE_UPGRADE_BOOL    = 5001,  // 强制升级
    OB_DEVICE_DEBUG_MX6300_START_TIME_INT     = 5002,  // 获取MX6300固件启动时间

    // 5500~5999为调试用结构体控制命令
    // Device:: get/setStructedData
    OB_DEVICE_DEBUG_RECORD_RGB_DATA   = 5500,  // 设备端 RGB 传图控制（调试功能）
    OB_DEVICE_DEBUG_RECORD_PHASE_DATA = 5501,  // 设备端 raw Phase 传图控制（调试功能）
    OB_DEVICE_DEBUG_RECORD_IR_DATA    = 5502,  // 设备端 IR 传图控制（调试功能）
    OB_DEVICE_DEBUG_RECORD_DEPTH_DATA = 5503,  // 设备端 depth 传图控制（调试功能）
    }
}