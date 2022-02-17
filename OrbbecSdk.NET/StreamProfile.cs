using System;
using System.Runtime.InteropServices;

namespace OrbbecSdk.NET
{
    public class StreamProfile
    {
        /**
 * @brief 获取流配置的格式
 *
 * @param[in] profile 流配置对象
 * @param[out] error 记录错误信息
 * @return ob_format 返回流的格式
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_format ob_stream_profile_format(IntPtr profile, ref ob_error error);

        /**
 * @brief 获取流的类型
 *
 * @param[in] profile 流配置对象
 * @param[out] error 记录错误信息
 * @return ob_stream_type 流的类型
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_stream_type ob_stream_profile_type(IntPtr profile, ref ob_error error);

// /**
//  * @brief 获取视频流配置的帧率 -> 接口已弃用，将会在接下来的版本更新中删除，请使用ob_video_stream_profile_fps
//  *
//  * @param[in] profile 流配置对象, 如果该配置不是视频流配置，将会返错误
//  * @param[out] error 记录错误信息
//  * @return uint 返回流的帧率
//  */
// DEPRECATED uint ob_stream_profile_fps( IntPtr profile, ob_error error );
//
// /**
//  * @brief 获取视频流配置的宽 -> 接口已弃用，将会在接下来的版本更新中删除，请使用ob_video_stream_profile_width
//  *
//  * @param[in] profile 流配置对象, 如果该配置不是视频流配置，将会返错误
//  * @param[out] error 记录错误信息
//  * @return uint 返回流的宽
//  */
// DEPRECATED uint ob_stream_profile_width( IntPtr profile, ob_error error );
//
// /**
//  * @brief 获取视频流配置的高 -> 接口已弃用，将会在接下来的版本更新中删除，请使用ob_video_stream_profile_height
//  *
//  * @param[in] profile 流配置对象, 如果该配置不是视频流配置，将会返错误
//  * @param[out] error 记录错误信息
//  * @return uint 返回流的高
//  */
// DEPRECATED uint ob_stream_profile_height( IntPtr profile, ob_error error );

        /**
 * @brief 获取视频流配置的帧率
 *
 * @param[in] profile 流配置对象, 如果该配置不是视频流配置，将会返错误
 * @param[out] error 记录错误信息
 * @return uint 返回流的帧率
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern uint ob_video_stream_profile_fps(IntPtr profile, ref ob_error error);

        /**
 * @brief 获取视频流配置的宽
 *
 * @param[in] profile 流配置对象, 如果该配置不是视频流配置，将会返错误
 * @param[out] error 记录错误信息
 * @return uint 返回流的宽
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern uint ob_video_stream_profile_width(IntPtr profile, ref ob_error error);

        /**
 * @brief 获取视频流配置的高
 *
 * @param[in] profile 流配置对象, 如果该配置不是视频流配置，将会返错误
 * @param[out] error 记录错误信息
 * @return uint 返回流的高
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern uint ob_video_stream_profile_height(IntPtr profile, ref ob_error error);

        /**
 * @brief 获取加速度计流配置的量程范围
 *
 * @param[in] profile 流配置对象, 如果该配置不是加速度计流配置，将会返错误
 * @param[out] error 记录错误信息
 * @return ob_accel_full_scale_range 量程范围
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_accel_full_scale_range ob_accel_stream_profile_full_scale_range(IntPtr profile, ref ob_error error);

        /**
 * @brief 获取加速度计流配置的采样频率
 *
 * @param[in] profile 流配置对象, 如果该配置不是加速度计流配置，将会返错误
 * @param[out] error 记录错误信息
 * @return ob_accel_sample_rate 采样频率
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_accel_sample_rate ob_accel_stream_profile_sample_rate(IntPtr profile, ref ob_error error);

        /**
 * @brief 获取陀螺仪流配置的量程范围
 *
 * @param[in] profile 流配置对象, 如果该配置不是陀螺仪流配置，将会返错误
 * @param[out] error 记录错误信息
 * @return ob_gyro_full_scale_range 量程范围
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_gyro_full_scale_range ob_gyro_stream_profile_full_scale_range(IntPtr profile, ref ob_error error);

        /**
 * @brief 获取陀螺仪流配置的采样频率
 *
 * @param[in] profile 流配置对象, 如果该配置不是陀螺仪流配置，将会返错误
 * @param[out] error 记录错误信息
 * @return ob_gyro_sample_rate 采样频率
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_gyro_sample_rate ob_gyro_stream_profile_sample_rate(IntPtr profile, ref ob_error error);

        /**
 * @brief 删除流配置列表
 *
 * @param[in] profiles 流配置列表
 * @param[in] count 流配置数量
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_delete_stream_profiles(ref IntPtr profiles, uint count, ref ob_error error);

        /**
 * @brief 删除流配置
 *
 * @param[in] profile 流配置对象
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_delete_stream_profile(IntPtr profile, ref ob_error error);
    }
}