using System;
using System.Runtime.InteropServices;

namespace OrbbecSdk.NET
{
    public class PipeLine
    {
        /**
 * @brief 创建pipeline对象
 *
 * @param[out] error 记录错误信息
 * @return IntPtr 返回pipeline对象
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_create_pipeline(ob_error error);

        /**
 * @brief 使用设备对象来创建pipeline对象
 *
 * @param[in] dev 用于创建pipeline的设备对象
 * @param[out] error 记录错误信息
 * @return IntPtr 返回pipeline对象
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_create_pipeline_with_device(IntPtr dev, ob_error error);

        /**
 * @brief 删除pipeline对象
 *
 * @param[in] pipeline 要删除的pipeline对象
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_delete_pipeline(IntPtr pipeline, ob_error error);

        /**
 * @brief 以默认参数启动pipeline
 *
 * @param[in] pipeline pipeline对象
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_pipeline_start(IntPtr pipeline, ob_error error);

        /**
 * @brief 启动pipeline并配置参数
 *
 * @param[in] pipeline pipeline对象
 * @param[in] config 要配置的参数
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_pipeline_start_with_config(IntPtr pipeline, IntPtr config, ob_error error);

        /// <summary>
        /// 文件发送进度回调
        /// </summary>
        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate int ob_frame_set_callback(IntPtr frame_set, IntPtr user_data);

        /**
 * @brief 启动pipeline并设置帧集合数据回调
 *
 * @param[in] pipeline pipeline对象
 * @param[in] config 要配置的参数
 * @param[in] callback 帧集合中的所有帧数据都到达时触发回调
 * @param[in] user_data 可以传入任意用户数据，并从回调中获取
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_pipeline_start_with_callback(IntPtr pipeline, IntPtr config, [MarshalAs(UnmanagedType.FunctionPtr)] ob_frame_set_callback callback, IntPtr user_data, ob_error error);

        /**
 * @brief 停止pipeline
 *
 * @param[in] pipeline pipeline对象
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_pipeline_stop(IntPtr pipeline, ob_error error);

        /**
 * @brief 获取pipeline当前参数
 *
 * @param[in] pipeline pipeline对象
 * @param[out] error 记录错误信息
 * @return IntPtr 返回pipeline参数
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_pipeline_get_config(IntPtr pipeline, ob_error error);

        /**
 * @brief 以同步阻塞的形式等待返回一组帧集合
 *
 * @param[in] pipeline pipeline对象
 * @param[in] timeout_ms 等待超时时间(毫秒)
 * @param[out] error 记录错误信息
 * @return IntPtr 返回等待的帧集合
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_pipeline_wait_for_frames(IntPtr pipeline, uint timeout_ms, ob_error error);

        /**
 * @brief 从pipeline中获取设备
 *
 * @param[in] pipeline pipeline对象
 * @param[out] error 记录错误信息
 * @return IntPtr 返回设备对象
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_pipeline_get_device(IntPtr pipeline, ob_error error);

        /**
 * @brief 获取传感器相应的流配置
 *
 * @param[in] pipeline pipeline对象
 * @param[in] sensor_type 传感器类型
 * @param[out] profile_count 获取的流配置数量
 * @param[out] error 记录错误信息
 * @return IntPt* 返回流配置列表
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_pipeline_get_stream_profiles(IntPtr pipeline, ob_sensor_type sensor_type, ref uint profile_count, ob_error error);

        /**
 * @brief 获取所有流配置
 *
 * @param[in] pipeline pipeline对象
 * @param[out] profile_count 获取的流配置数量
 * @param[out] error 记录错误信息
 * @return IntPt* 返回流配置列表
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_pipeline_get_all_stream_profiles(IntPtr pipeline, ref uint profile_count, ob_error error);

        /**
 * @brief 打开帧同步功能
 *
 * @param[in] pipeline pipeline对象
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_pipeline_enable_frame_sync(IntPtr pipeline, ob_error error);

        /**
 * @brief 关闭帧同步功能
 *
 * @param[in] pipeline pipeline对象
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_pipeline_disable_frame_sync(IntPtr pipeline, ob_error error);

        /**
 * @brief 创建pipeline的配置
 *
 * @param[out] error 记录错误信息
 * @return IntPtr 返回配置对象
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_create_config(ob_error error);

        /**
 * @brief 删除pipeline的配置
 *
 * @param[in] config 要删除的配置
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_delete_config(IntPtr config, ob_error error);

        /**
 * @brief 配置要打开的流
 *
 * @param[in] config pipeline的配置
 * @param[in] profile 要打开的流的配置
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_config_enable_stream(IntPtr config, IntPtr profile, ob_error error);

        /**
 * @brief 配置打开所有的流
 *
 * @param[in] config pipeline的配置
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_config_enable_all_stream(IntPtr config, ob_error error);

        /**
 * @brief 配置要关闭的流
 *
 * @param[in] config pipeline的配置
 * @param[in] profile 要关闭的流的配置
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_config_disable_stream(IntPtr config, ob_stream_type type, ob_error error);

        /**
 * @brief 配置关闭所有的流
 *
 * @param[in] config pipeline的配置
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_config_disable_all_stream(IntPtr config, ob_error error);

        /**
 * @brief 创建PointCloud Filter
 *
 * @param[in] pipeline pipeline对象
 * @param[out] error 记录错误信息
 *
 * @return filter pointcloud_filter对象
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_pipeline_create_pointcloud_filter(IntPtr pipeline, ob_error error);

        /**
 * @brief 删除PointCloud Filter
 *
 * @param[in] pipeline pipeline对象
 * @param[in] filter pointcloud_filter 对象
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_pipeline_delete_pointcloud_filter(IntPtr pipeline, IntPtr filter, ob_error error);

        /**
 * @brief PointCloud Filter设备相机参数
 *
 * @param[in] filter pointcloud_filter对象
 * @param[in] param 相机参数
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_pointcloud_filter_set_camera_parameter(IntPtr filter, ob_camera_para param, ob_error error);

        /**
 * @brief 设置点云类型参数
 *
 * @param[in] filter pointcloud_filter对象
 * @param[in] type 点云类型 深度点云或RGBD点云
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_pointcloud_filter_set_point_format(IntPtr filter, ob_format type, ob_error error);

        /**
 * @brief  使能对齐模式（D2C模式下需要开启，作为算法选用那组相机内参的依据）
 * @param[in] filter pointcloud_filter对象
 * @param[in] status 对齐状态，True：开启对齐； False：关闭对齐
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_pointcloud_filter_enable_aligned_mode(IntPtr filter, bool status, ob_error error);

        /**
 * @brief 创建FormatConvet Filter
 *
 * @param[in] pipeline pipeline对象
 * @param[out] error 记录错误信息
 *
 * @return filter format_convert 对象
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_pipeline_create_format_convert_filter(IntPtr pipeline, ob_error error);

        /**
 * @brief 设置格式转化的类型
 *
 * @param[in] filter formatconvet_filter对象
 * @param[in] type 格式转化类型
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_format_convert_filter_set_format(IntPtr filter, ob_convert_format type, ob_error error);

        /**
 * @brief 删除FormatConvet Filter
 *
 * @param[in] pipeline pipeline对象
 * @param[in] filter format_convet_filter 对象
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_pipeline_delete_format_convert_filter(IntPtr pipeline, IntPtr filter, ob_error error);

        /**
 * @brief  Filter重置
 *
 * @param[in] filter filter对象
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_filter_reset(IntPtr filter, ob_error error);

        /**
 * @brief Filter 处理(同步接口)
 *
 * @param[in] filter filter对象
 * @param[in] frame 需要被处理的frame对象指针
 * @param[out] error 记录错误信息
 *
 * @return ob_frame  filter处理后的frame对象
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_filter_process(IntPtr filter, IntPtr frame, ob_error error);

        /**
 * @brief Filter 启动处理线程(异步回调接口)
 *
 * @param[in] filter filter对象
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern bool ob_filter_start(IntPtr filter, ob_error error);

        /**
 * @brief Filter 停止处理线程(异步回调接口)
 *
 * @param[in] filter filter对象
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_filter_stop(IntPtr filter, ob_error error);

        /// <summary>
        /// 设置处理结果回调函数
        /// </summary>
        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate int ob_filter_callback(IntPtr frame_set, IntPtr user_data);

        /**
 * @brief Filter 设置处理结果回调函数(异步回调接口)
 *
 * @param[in] filter filter对象
 * @param[in] callback 回调函数
 * @param[in] user_data 可以传入任意用户数据指针，并从回调返回该数据指针
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_filter_set_callback(IntPtr filter, [MarshalAs(UnmanagedType.FunctionPtr)] ob_filter_callback callback, IntPtr user_data, ob_error error);

        /**
 * @brief filter 压入frame_set到待处理缓存(异步回调接口)
 *
 * @param[in] filter filter对象
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_filter_push_frame(IntPtr filter, IntPtr frame, ob_error error);
    }
}