using System;
using System.Runtime.InteropServices;

namespace OrbbecSdk.NET
{
    public class Frame
    {
        /**
 * @brief 获取帧索引
 *
 * @param[in] frame 帧对象
 * @param[out] error 记录错误信息
 * @return ulong 返回帧索引
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ulong ob_frame_index(IntPtr frame, ref ob_error error);

        /**
 * @brief 获取帧格式
 *
 * @param[in] frame 帧对象
 * @param[out] error 记录错误信息
 * @return ob_format 返回帧格式
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_format ob_frame_format(IntPtr frame, ref ob_error error);

        /**
 * @brief 获取帧类型
 *
 * @param[in] frame 帧对象
 * @param[out] error 记录错误信息
 * @return ob_frame_type 返回帧类型
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_frame_type ob_frame_get_type(IntPtr frame, ref ob_error error);

        /**
 * @brief 获取帧硬件时间戳
 *
 * @param[in] frame 帧对象
 * @param[out] error 记录错误信息
 * @return ulong 返回帧硬件时间戳
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ulong ob_frame_time_stamp(IntPtr frame, ref ob_error error);

        /**
 * @brief 获取帧系统时间戳
 *
 * @param[in] frame 帧对象
 * @param[out] error 记录错误信息
 * @return ulong 返回帧系统时间戳
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ulong ob_frame_system_time_stamp(IntPtr frame, ref ob_error error);

        /**
 * @brief 获取视频帧宽
 *
 * @param[in] frame 帧对象
 * @param[out] error 记录错误信息
 * @return uint 返回帧宽
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern uint ob_video_frame_width(IntPtr frame, ref ob_error error);

        /**
 * @brief 获取视频帧高
 *
 * @param[in] frame 帧对象
 * @param[out] error 记录错误信息
 * @return uint 返回帧高
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern uint ob_video_frame_height(IntPtr frame, ref ob_error error);

// /**
//  * @brief 获取视频帧宽 -> 接口已弃用，将会在接下来的版本更新中删除，请使用ob_video_frame_width代替
//  *
//  * @param[in] frame 帧对象
//  * @param[out] error 记录错误信息
//  * @return uint 返回帧宽
//  */
// [DllImport("OrbbecSDK.dll")]
// public static extern DEPRECATED uint ob_frame_width( IntPtr frame, ob_error error );

// /**
//  * @brief 获取视频帧高 -> 接口已弃用，将会在接下来的版本更新中删除，请使用ob_video_frame_height代替
//  *
//  * @param[in] frame 帧对象
//  * @param[out] error 记录错误信息
//  * @return uint 返回帧高
//  */
// [DllImport("OrbbecSDK.dll")]
// public static extern DEPRECATED uint ob_frame_height( IntPtr frame, ob_error error );

        /**
 * @brief 获取深度帧的值刻度，单位为 mm/step，
 *      如valueScale=0.1, 某坐标像素值为pixelValue=10000，
 *     则表示深度值value = pixelValue*valueScale = 10000*0.1=1000mm。
 *
 * @param[in] frame 帧对象
 * @param[out] error 记录错误信息
 * @return float 值刻度
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern float ob_depth_frame_get_value_scale(IntPtr frame, ref ob_error error);

        /**
 * @brief 获取帧数据
 *
 * @param[in] frame 帧对象
 * @param[out] error 记录错误信息
 * @return IntPtr 返回帧数据指针
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_frame_data(IntPtr frame, ref ob_error error);

        /**
 * @brief 获取帧数据大小
 *
 * @param[in] frame 帧对象
 * @param[out] error 记录错误信息
 * @return uint 返回帧数据大小
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern uint ob_frame_data_size(IntPtr frame, ref ob_error error);

        /**
 * @brief 获取帧的元数据
 *
 * @param[in] frame 帧对象
 * @param[out] error 记录错误信息
 * @return IntPtr 返回帧的元数据指针
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_frame_metadata(IntPtr frame, ref ob_error error);

        /**
 * @brief 获取帧的元数据大小
 *
 * @param[in] frame 帧对象
 * @param[out] error 记录错误信息
 * @return uint 返回帧的元数据大小
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern uint ob_frame_metadata_size(IntPtr frame, ref ob_error error);

        /**
 * @brief 获取帧的流类型
 *
 * @param[in] frame 帧对象
 * @param[out] error 记录错误信息
 * @return ob_stream_type 返回流类型
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_stream_type ob_frame_get_stream_type(IntPtr frame, ref ob_error error);

        /**
 * @brief 删除帧
 *
 * @param[in] frame 要删除的帧对象
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_delete_frame(IntPtr frame, ref ob_error error);

// /**
//  * @brief 删除帧集合 -> 接口已弃用，将会在接下来的版本更新中删除，请使用ob_delete_frame
//  *
//  * @param[in] frame 要删除的帧对象
//  * @param[out] error 记录错误信息
//  */
// [DllImport("OrbbecSDK.dll")]
// public static extern DEPRECATED void ob_delete_frame_set( IntPtr frame_set, ob_error error );

        /**
 * @brief 获取帧集合包含的帧数量
 *
 * @param[in] frame_set 帧集合对象
 * @param[out] error 记录错误信息
 * @return uint 返回帧数量
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern uint ob_frame_set_frame_count(IntPtr frame_set, ref ob_error error);

        /**
 * @brief 从帧集合中获取深度帧
 *
 * @param[in] frame_set 帧集合对象
 * @param[out] error 记录错误信息
 * @return IntPtr 返回深度帧
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_frame_set_depth_frame(IntPtr frame_set, ref ob_error error);

        /**
 * @brief 从帧集合中获取彩色帧
 *
 * @param[in] frame_set 帧集合对象
 * @param[out] error 记录错误信息
 * @return IntPtr 返回彩色帧
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_frame_set_color_frame(IntPtr frame_set, ref ob_error error);

        /**
 * @brief 从帧集合中获取红外帧
 *
 * @param[in] frame_set 帧集合对象
 * @param[out] error 记录错误信息
 * @return IntPtr 返回红外帧
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_frame_set_ir_frame(IntPtr frame_set, ref ob_error error);

        /**
 * @brief 从帧集合中获取点云数据
 *
 * @param[in] frame_set 帧集合对象
 * @param[out] error 记录错误信息
 * @return IntPtr 返回点云帧
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_frame_set_points_frame(IntPtr frame_set, ref ob_error error);

        /**
 * @brief 获取加速度帧数据
 *
 * @param[in] frame 加速度帧
 * @param[out] error 记录错误信息
 * @return ob_accel_value 加速度数据
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_accel_value ob_accel_frame_value(IntPtr frame, ref ob_error error);

        /**
 * @brief 获取加速度帧采样时温度
 *
 * @param[in] frame 加速度帧
 * @param[out] error 记录错误信息
 * @return float 返回数值
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern float ob_accel_frame_temperature(IntPtr frame, ref ob_error error);

        /**
 * @brief 获取陀螺仪帧数据
 *
 * @param[in] frame 陀螺仪帧
 * @param[out] error 记录错误信息
 * @return ob_gyro_value 陀螺仪数据
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_gyro_value ob_gyro_frame_value(IntPtr frame, ref ob_error error);

        /**
 * @brief 获取加速度帧采样时温度
 *
 * @param[in] frame 加速度帧
 * @param[out] error 记录错误信息
 * @return float 返回数值
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern float ob_gyro_frame_temperature(IntPtr frame, ref ob_error error);
    }
}