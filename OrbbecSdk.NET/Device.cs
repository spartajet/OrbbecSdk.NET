using System;
using System.Runtime.InteropServices;

namespace OrbbecSdk.NET
{
    public class Device
    {
        /// <summary>
        /// 获取设备数量
        /// </summary>
        /// <param name="list">设备列表对象</param>
        /// <param name="error">记录错误信息</param>
        /// <returns>返回设备数量</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern uint ob_device_list_device_count(IntPtr list, ref ob_error error);

        // /// <summary>
        // /// 获取设备信息
        // /// </summary>
        // /// <param name="list">设备列表对象</param>
        // /// <param name="index">设备索引</param>
        // /// <param name="error">记录错误信息</param>
        // /// <returns>返回设备信息</returns>
        // [DllImport("OrbbecSDK.dll")]
        // public static extern IntPtr ob_device_list_get_device_info(IntPtr list, uint index, ref ob_error error);

        /// <summary>
        /// 获取指定设备名称
        /// </summary>
        /// <param name="list">设备列表对象</param>
        /// <param name="index">设备索引</param>
        /// <param name="error">记录错误信息</param>
        /// <returns>返回设备名称</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern string ob_device_list_get_device_name(IntPtr list, uint index, ref ob_error error);

        /// <summary>
        /// 获取指定设备pid
        /// </summary>
        /// <param name="list">设备列表对象</param>
        /// <param name="index">设备索引</param>
        /// <param name="error">记录错误信息</param>
        /// <returns>返回设备pid</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern int ob_device_list_get_device_pid(IntPtr list, uint index, ref ob_error error);

        /// <summary>
        /// 获取指定设备vid
        /// </summary>
        /// <param name="list">设备列表对象</param>
        /// <param name="index">设备索引</param>
        /// <param name="error">记录错误信息</param>
        /// <returns>返回设备pid</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern int ob_device_list_get_device_vid(IntPtr list, uint index, ref ob_error error);

        /// <summary>
        /// 获取指定设备uid
        /// </summary>
        /// <param name="list">设备列表对象</param>
        /// <param name="index">设备索引</param>
        /// <param name="error">记录错误信息</param>
        /// <returns>返回设备pid</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern string ob_device_list_get_device_uid(IntPtr list, uint index, ref ob_error error);


        /// <summary>
        /// 获取指定设备序列号
        /// </summary>
        /// <param name="list">设备列表对象</param>
        /// <param name="index">设备索引</param>
        /// <param name="error">记录错误信息</param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern string ob_device_list_get_device_serial_number(IntPtr list, uint index, ref ob_error error);

        /// <summary>
        /// 创建设备
        /// 如果设备有在其他地方被获取创建，重复获取将会返回错误
        /// </summary>
        /// <param name="list">设备列表对象</param>
        /// <param name="index">要创建设备的索引</param>
        /// <param name="error">记录错误信息</param>
        /// <returns>返回设备pid</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_device_list_get_device(IntPtr list, uint index, ref ob_error error);

        /// <summary>
        /// 创建设备,如果设备有在其他地方被获取创建，重复获取将会返回错误
        /// </summary>
        /// <param name="list">设备列表对象</param>
        /// <param name="serial_number">要创建设备的序列号</param>
        /// <param name="error">记录错误信息</param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_device_list_get_device_by_serial_number(IntPtr list, string serial_number, ref ob_error error);


        /// <summary>
        /// 创建设备,如果设备有在其他地方被获取创建，重复获取将会返回错误
        /// </summary>
        /// <param name="list">设备列表对象</param>
        /// <param name="uid">要创建设备的uid</param>
        /// <param name="error">记录错误信息</param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_device_list_get_device_by_uid(IntPtr list, string uid, ref ob_error error);

        /// <summary>
        /// 删除设备
        /// </summary>
        /// <param name="device">要删除的设备</param>
        /// <param name="error">记录错误信息</param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_delete_device(IntPtr device, ref ob_error error);

        /// <summary>
        /// 删除设备信息
        /// </summary>
        /// <param name="info">要删除的设备信息</param>
        /// <param name="error">记录错误信息</param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_delete_device_info(IntPtr info, ref ob_error error);

        /// <summary>
        /// 删除设备列表
        /// </summary>
        /// <param name="list">要删除的设备列表对象</param>
        /// <param name="error">记录错误信息</param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_delete_device_list(IntPtr list, ref ob_error error);

        /// <summary>
        /// 获取设备信息
        /// </summary>
        /// <param name="device">要获取信息的设备</param>
        /// <param name="error">记录错误信息</param>
        /// <returns>返回设备信息</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_device_get_device_info(IntPtr device, ref ob_error error);

        /// <summary>
        /// 获取设备的所有传感器
        /// </summary>
        /// <param name="device">设备对象</param>
        /// <param name="error">记录错误信息</param>
        /// <returns>返回所有传感器列表</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_device_get_sensor_list(IntPtr device, ref ob_error error);

        /// <summary>
        /// 获取设备的传感器
        /// </summary>
        /// <param name="device">设备对象</param>
        /// <param name="type">要获取的传感器类型</param>
        /// <param name="error">记录错误信息</param>
        /// <returns>返回获取的传感器</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_device_get_sensor(IntPtr device, ob_sensor_type type, ref ob_error error);

        /// <summary>
        /// 设置int类型的设备属性
        /// </summary>
        /// <param name="device">设备对象</param>
        /// <param name="property_id">要设置的属性id</param>
        /// <param name="property">要设置的属性值</param>
        /// <param name="error">记录错误信息</param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_device_set_int_property(IntPtr device, ob_global_unified_property property_id, int property, ref ob_error error);

        /// <summary>
        /// 获取int类型的设备属性
        /// </summary>
        /// <param name="device">设备对象</param>
        /// <param name="property_id">属性id</param>
        /// <param name="error">记录错误信息</param>
        /// <returns>返回属性值</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern int ob_device_get_int_property(IntPtr device, ob_global_unified_property property_id, ref ob_error error);

        /// <summary>
        /// 设置float类型的设备属性
        /// </summary>
        /// <param name="device">设备对象</param>
        /// <param name="property_id">要设置的属性id</param>
        /// <param name="property">要设置的属性值</param>
        /// <param name="error">记录错误信息</param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_device_set_float_property(IntPtr device, ob_global_unified_property property_id, float property, ref ob_error error);

        /// <summary>
        /// 获取float类型的设备属性
        /// </summary>
        /// <param name="device">设备对象</param>
        /// <param name="property_id">属性id</param>
        /// <param name="error">记录错误信息</param>
        /// <returns>返回属性值</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern float ob_device_get_float_property(IntPtr device, ob_global_unified_property property_id, ref ob_error error);

        /// <summary>
        /// 设置bool类型的设备属性
        /// </summary>
        /// <param name="device">设备对象</param>
        /// <param name="property_id">要设置的属性id</param>
        /// <param name="property">要设置的属性值</param>
        /// <param name="error">记录错误信息</param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_device_set_bool_property(IntPtr device, ob_global_unified_property property_id, bool property, ref ob_error error);

        /// <summary>
        /// 获取bool类型的设备属性
        /// </summary>
        /// <param name="device">设备对象</param>
        /// <param name="property_id">属性id</param>
        /// <param name="error">记录错误信息</param>
        /// <returns>返回属性值</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern bool ob_device_get_bool_property(IntPtr device, ob_global_unified_property property_id, ref ob_error error);

        /// <summary>
        /// 设置结构体类型的设备属性
        /// </summary>
        /// <param name="device">设备对象</param>
        /// <param name="property_id">要设置的属性id</param>
        /// <param name="data">要设置的属性数据</param>
        /// <param name="data_size">要设置的属性大小</param>
        /// <param name="error">记录错误信息</param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_device_set_structured_data(IntPtr device, ob_global_unified_property property_id, IntPtr data, uint data_size, ref ob_error error);

        /// <summary>
        /// 获取结构体类型的设备属性
        /// </summary>
        /// <param name="device">设备对象</param>
        /// <param name="property_id">要获取的属性id</param>
        /// <param name="data">获取的属性数据</param>
        /// <param name="data_size">获取的属性大小</param>
        /// <param name="error">记录错误信息</param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_device_get_structured_data(IntPtr device, ob_global_unified_property property_id, IntPtr data, ref uint data_size, ref ob_error error);

        /// <summary>
        /// 设置进度回调函数
        /// </summary>
        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate int ob_set_data_callback(ob_data_tran_state state, sbyte percent, IntPtr user_data);

        /// <summary>
        /// 设置raw data类型d 设备属性
        /// </summary>
        /// <param name="device">设备对象</param>
        /// <param name="property_id">要设置的属性id</param>
        /// <param name="data">要设置的属性数据</param>
        /// <param name="data_size">要设置的属性大小</param>
        /// <param name="cb">设置进度回调</param>
        /// <param name="async">是否异步执行</param>
        /// <param name="user_data">用户自定义数据，会在回调中返回</param>
        /// <param name="error">记录错误信息</param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern bool ob_device_set_raw_data(IntPtr device, ob_global_unified_property property_id, IntPtr data, uint data_size, [MarshalAs(UnmanagedType.FunctionPtr)] ob_set_data_callback cb, bool async, IntPtr user_data, ref ob_error error);

        /// <summary>
        /// 获取数据给返回和进度回调
        /// </summary>
        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate int ob_get_data_callback(ob_data_tran_state state, ob_data_chunk dataChunk, IntPtr user_data);

        /// <summary>
        /// 获取raw data类型的设备属性
        /// </summary>
        /// <param name="device">设备对象</param>
        /// <param name="property_id">要获取的属性id</param>
        /// <param name="cb">获取数据给返回和进度回调</param>
        /// <param name="async">是否异步执行</param>
        /// <param name="user_data">用户自定义数据，会在回调中返回</param>
        /// <param name="error">记录错误信息</param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern bool ob_device_get_raw_data(IntPtr device, ob_global_unified_property property_id, [MarshalAs(UnmanagedType.FunctionPtr)] ob_get_data_callback cb, bool async, IntPtr user_data, ref ob_error error);

        /// <summary>
        /// 获取设备支持的属性的数量
        /// </summary>
        /// <param name="device">设备对象</param>
        /// <param name="error">记录错误信息</param>
        /// <returns>返回设备支持的属性的数量</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern uint ob_device_get_supported_property_count(IntPtr device, ref ob_error error);

        /// <summary>
        /// 获取设备支持的属性
        /// </summary>
        /// <param name="device">设备对象</param>
        /// <param name="index">属性的index</param>
        /// <param name="error">记录错误信息</param>
        /// <returns>返回设备支持的属性的类型</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_global_unified_property_item ob_device_get_supported_property(IntPtr device, uint index, ref ob_error error);

        /// <summary>
        /// 判断设备属性是否支持
        /// </summary>
        /// <param name="device"></param>
        /// <param name="property_id">属性id</param>
        /// <param name="permission">需要判读的权限类型</param>
        /// <param name="error">记录错误信息</param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern bool ob_device_is_property_supported(IntPtr device, ob_property_id property_id, ob_permission_type permission, ref ob_error error);

        /// <summary>
        /// 获取int类型的设备属性范围
        /// </summary>
        /// <param name="device"></param>
        /// <param name="property_id"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_int_property_range ob_device_get_int_property_range(IntPtr device, ob_property_id property_id, ref ob_error error);


        /// <summary>
        /// 获取float类型的设备属性范围
        /// </summary>
        /// <param name="device"></param>
        /// <param name="property_id"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_float_property_range ob_device_get_float_property_range(IntPtr device, ob_property_id property_id, ref ob_error error);

        /// <summary>
        /// 获取bool类型的设备属性范围
        /// </summary>
        /// <param name="device"></param>
        /// <param name="property_id"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_bool_property_range ob_device_get_bool_property_range(IntPtr device, ob_property_id property_id, ref ob_error error);

        /// <summary>
        /// ahb写寄存器
        /// </summary>
        /// <param name="device"></param>
        /// <param name="reg"></param>
        /// <param name="mask"></param>
        /// <param name="value"></param>
        /// <param name="error"></param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_device_write_ahb(IntPtr device, uint reg, uint mask, uint value, ref ob_error error);

        /// <summary>
        /// ahb读寄存器
        /// </summary>
        /// <param name="device"></param>
        /// <param name="reg"></param>
        /// <param name="mask"></param>
        /// <param name="value"></param>
        /// <param name="error"></param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_device_read_ahb(IntPtr device, uint reg, uint mask, ref int value, ref ob_error error);

        /// <summary>
        /// i2c写寄存器
        /// </summary>
        /// <param name="device"></param>
        /// <param name="module_id"></param>
        /// <param name="reg"></param>
        /// <param name="mask"></param>
        /// <param name="value"></param>
        /// <param name="error"></param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_device_write_i2c(IntPtr device, uint module_id, uint reg, uint mask, uint value, ref ob_error error);

        /// <summary>
        /// i2c读寄存器
        /// </summary>
        /// <param name="device"></param>
        /// <param name="module_id"></param>
        /// <param name="reg"></param>
        /// <param name="mask"></param>
        /// <param name="value"></param>
        /// <param name="error"></param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_device_read_i2c(IntPtr device, uint module_id, uint reg, uint mask, ref int value, ref ob_error error);

        /// <summary>
        /// 设置写入Flash的属性[异步回调]
        /// </summary>
        /// <param name="device"></param>
        /// <param name="offset"></param>
        /// <param name="???"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern bool ob_device_write_flash(IntPtr device, uint offset, IntPtr data, uint data_size, ob_set_data_callback cb, bool async, IntPtr user_data, ref ob_error error);

        /// <summary>
        /// 读取Flash的属性[异步回调]
        /// </summary>
        /// <param name="device"></param>
        /// <param name="offset"></param>
        /// <param name="data_size"></param>
        /// <param name="cb"></param>
        /// <param name="async"></param>
        /// <param name="user_data"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern bool ob_device_read_flash(IntPtr device, uint offset, uint data_size, ob_get_data_callback cb, bool async, IntPtr user_data, ref ob_error error);


        /// <summary>
        /// 同步设备时间（向设备授时，同步本地系统时间到设备）
        /// </summary>
        /// <param name="device"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern ulong ob_device_sync_device_time(IntPtr device, ref ob_error error);

        /// <summary>
        /// 设置设备状态监听进度回调
        /// </summary>
        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate int ob_device_upgrade_callback(ob_upgrade_state state, string message, sbyte percent, IntPtr user_data);

        /// <summary>
        /// 设备固件升级
        /// </summary>
        /// <param name="device"></param>
        /// <param name="???"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern bool ob_device_upgrade(IntPtr device, string path, [MarshalAs(UnmanagedType.FunctionPtr)] ob_device_upgrade_callback callback, bool async, IntPtr user_data, ref ob_error error);


        /// <summary>
        /// 获取当前设备状态
        /// </summary>
        /// <param name="device"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_device_state ob_device_get_device_state(IntPtr device, ref ob_error error);


        /// <summary>
        /// 设置设备状态监听进度回调
        /// </summary>
        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate int ob_device_state_callback(ob_device_state state, IntPtr user_data);

        /// <summary>
        /// 设置设备状态监听
        /// </summary>
        /// <param name="device"></param>
        /// <param name="callback"></param>
        /// <param name="user_data"></param>
        /// <param name="error"></param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_device_state_changed(IntPtr device, [MarshalAs(UnmanagedType.FunctionPtr)] ob_device_state_callback callback, IntPtr user_data, ref ob_error error);

        /// <summary>
        /// 文件发送进度回调
        /// </summary>
        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate int ob_file_send_callback(ob_file_tran_state state, string message, sbyte percent, IntPtr user_data);

        // /// <summary>
        // /// 发送文件到设备指定路径
        // /// </summary>
        // /// <param name="device"></param>
        // /// <param name="???"></param>
        // /// <returns></returns>

        /// <summary>
        /// 发送文件到设备指定路径
        /// </summary>
        /// <param name="device"></param>
        /// <param name="file_path"></param>
        /// <param name="dst_path"></param>
        /// <param name="callback"></param>
        /// <param name="async"></param>
        /// <param name="user_data"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern bool ob_device_send_file_to_destination(IntPtr device, string file_path, string dst_path, [MarshalAs(UnmanagedType.FunctionPtr)] ob_file_send_callback callback, bool async, IntPtr user_data, ref ob_error error);


        /// <summary>
        /// 验证设备授权码
        /// </summary>
        /// <param name="device"></param>
        /// <param name="???"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern bool ob_device_activate_authorization(IntPtr device, string auth_code, ref ob_error error);


        /// <summary>
        /// 写入设备授权码
        /// </summary>
        /// <param name="device"></param>
        /// <param name="???"></param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_device_write_authorization_code(IntPtr device, string auth_code, ref ob_error error);


        /// <summary>
        /// 获取设备内保存的相机标定的原始参数列表，列表内参数不与当前开流配置相对应，需要自行根据实际情况选用参数并可能需要做缩放、镜像等处理。非专业用户建议使用ob_pipeline_get_camera_param()接口。
        /// </summary>
        /// <param name="device">设备对象</param>
        /// <param name="error">记录错误信息</param>
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_device_get_calibration_camera_param_list(IntPtr device, ref ob_error error);

        /// <summary>
        /// 设备重启
        /// 设备会掉线重连，设备掉线后对device句柄的接口访问可能会发生异常，请直接使用ob_delete_device接口删除句柄，待设备重连后可重新获取。
        /// </summary>
        /// <param name="device"></param>
        /// <param name="error"></param>
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_device_reboot(IntPtr device, ref ob_error error);


        // /// <summary>
        // /// 获取相机内参（会根据当前镜像状态返回）
        // /// </summary>
        // /// <param name="device"></param>
        // /// <param name="sensor_type"></param>
        // /// <param name="error"></param>
        // /// <returns></returns>
        // [DllImport("OrbbecSDK.dll")]
        // public static extern ob_camera_intrinsic ob_device_get_camera_intrinsic(IntPtr device, ob_sensor_type sensor_type, ref ob_error error);
        //
        // /// <summary>
        // /// 获取相机畸变参数（会根据当前镜像状态返回）
        // /// </summary>
        // /// <param name="device"></param>
        // /// <param name="sensor_type"></param>
        // /// <param name="error"></param>
        // /// <returns></returns>
        // [DllImport("OrbbecSDK.dll")]
        // public static extern ob_camera_distortion ob_device_get_camera_distortion(IntPtr device, ob_sensor_type sensor_type, ref ob_error error);
        //
        //
        // /// <summary>
        // /// 获取d2c旋转矩阵（会根据当前镜像状态返回）
        // /// </summary>
        // /// <param name="device"></param>
        // /// <param name="error"></param>
        // /// <returns></returns>
        // [DllImport("OrbbecSDK.dll")]
        // public static extern ob_d2c_transform ob_device_get_d2c_transform(IntPtr device, ref ob_error error);

        /// <summary>
        /// 获取设备名
        /// </summary>
        /// <param name="info"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ob_device_info_name(IntPtr info, ref ob_error error);


        /// <summary>
        /// 获取设备pid
        /// </summary>
        /// <param name="info"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern int ob_device_info_pid(IntPtr info, ref ob_error error);

        /// <summary>
        /// 获取设备vid
        /// </summary>
        /// <param name="info"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern int ob_device_info_vid(IntPtr info, ref ob_error error);

        /// <summary>
        /// 获取设备uid
        /// </summary>
        /// <param name="info"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_device_info_uid(IntPtr info, ref ob_error error);

        /// <summary>
        /// 获取设备序列号
        /// </summary>
        /// <param name="info"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_device_info_serial_number(IntPtr info, ref ob_error error);

        /// <summary>
        /// 获取固件版本号
        /// </summary>
        /// <param name="info"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_device_info_firmware_version(IntPtr info, ref ob_error error);

        /// <summary>
        /// 获取usb连接类型
        /// </summary>
        /// <param name="info"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern string ob_device_info_usb_type(IntPtr info, ref ob_error error);
        /// <summary>
        /// 获取设备连接类型
        /// </summary>
        /// <param name="info"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern string ob_device_info_connection_type(IntPtr info, ref ob_error error);
        /// <summary>
        /// 获取硬件的版本号
        /// </summary>
        /// <param name="info"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        
        [DllImport("OrbbecSDK.dll")]
        public static extern string ob_device_info_hardware_version(IntPtr info, ref ob_error error);
        /// <summary>
        /// 获取设备支持的SDK最小版本号
        /// </summary>
        /// <param name="info"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        
        [DllImport("OrbbecSDK.dll")]
        public static extern string ob_device_info_supported_min_sdk_version(IntPtr info, ref ob_error error);
        /// <summary>
        /// 获取芯片类型名称
        /// </summary>
        /// <param name="info"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        
        [DllImport("OrbbecSDK.dll")]
        public static extern string ob_device_info_asicName(IntPtr info, ref ob_error error);
        /// <summary>
        /// 获取设备类型
        /// </summary>
        /// <param name="info"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_device_type ob_device_info_device_type(IntPtr info, ref ob_error error);
        /// <summary>
        /// 获取相机参数列表内参数组数
        /// </summary>
        /// <param name="info"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        
        [DllImport("OrbbecSDK.dll")]
        public static extern uint ob_camera_param_list_count(IntPtr param_list, ref ob_error error);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_camera_param ob_camera_param_list_get_param(IntPtr param_list,uint index, ref ob_error error);
        
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_delete_camera_param_list(IntPtr param_list, ref ob_error error);

    }
}