using System;
using System.Runtime.InteropServices;

namespace OrbbecSdk.NET
{
    public class Filter
    {
        /// <summary>
        /// 创建PointCloud Filter
        /// </summary>
        /// <param name="error">记录错误信息</param>
        /// <returns>filter pointcloud_filter对象</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_create_pointcloud_filter( ref ob_error error);

        /// <summary>
        ///  PointCloud Filter设备相机参数
        /// </summary>
        /// <param name="param">pointcloud_filter对象</param>
        /// <param name="error">相机参数</param>
        /// <param name="filter">记录错误信息</param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_pointcloud_filter_set_camera_param(IntPtr filter, ob_camera_param param,ref ob_error error);
        /// <summary>
        /// 设置点云类型参数
        /// </summary>
        /// <param name="filter">pointcloud_filter对象</param>
        /// <param name="type">点云类型 深度点云或RGBD点云</param>
        /// <param name="error">点云类型 深度点云或RGBD点云</param>
        
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_pointcloud_filter_set_point_format( IntPtr filter,ob_format type,ref ob_error error);
        /// <summary>
        /// 设置将要输入用于生产点云的帧的对齐状态
        /// </summary>
        /// <param name="filter">pointcloud_filter对象</param>
        /// <param name="state">对齐状态，True：已对齐； False：未对齐</param>
        /// <param name="error">记录错误信息</param>
        
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_pointcloud_filter_set_frame_align_state( IntPtr filter,bool state,ref ob_error error);
        /// <summary>
        ///  创建FormatConvet Filter
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_create_format_convert_filter( ref ob_error error);
        /// <summary>
        /// 设置格式转化的类型
        /// </summary>
        /// <param name="filter">formatconvet_filter对象</param>
        /// <param name="type">格式转化类型</param>
        /// <param name="error">记录错误信息</param>
        
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_format_convert_filter_set_format( IntPtr filter, ob_convert_format type,ref ob_error error);
        /// <summary>
        ///  Filter重置, 缓存清空，状态复位。如果是使用异步方式接口，还会停止处理线程，清空待处理的缓存帧
        /// </summary>
        /// <param name="filter">filter对象</param>
        /// <param name="error"></param>
        
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_filter_reset( IntPtr filter,ref ob_error error);
        
        /// <summary>
        /// Filter 处理(同步接口)
        /// </summary>
        /// <param name="filter">filter对象</param>
        /// <param name="frame">需要被处理的frame对象指针</param>
        /// <param name="error">记录错误信息</param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_filter_process( IntPtr filter,IntPtr frame,ref ob_error error);
        /// <summary>
        /// 设置处理结果回调函数(异步回调接口)
        /// </summary>
        /// <param name="filter">filter对象</param>
        /// <param name="callback">回调函数</param>
        /// <param name="user_data">可以传入任意用户数据指针，并从回调返回该数据指针</param>
        /// <param name="error"></param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_filter_set_callback( IntPtr filter,PipeLine.ob_filter_callback callback,IntPtr user_data,ref ob_error error);
        /// <summary>
        /// filter 压入frame到待处理缓存(异步回调接口)
        /// </summary>
        /// <param name="filter">filter对象</param>
        /// <param name="frame"></param>
        /// <param name="error"></param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_filter_push_frame( IntPtr filter,IntPtr frame,ref ob_error error);
        /// <summary>
        /// 删除Filter
        /// </summary>
        /// <param name="filter">filter 对象</param>
        /// <param name="error">记录错误信息</param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_delete_filter( IntPtr filter,ref ob_error error);
    }
}