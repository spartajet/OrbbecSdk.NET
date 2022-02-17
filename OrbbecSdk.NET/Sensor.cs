using System;
using System.Runtime.InteropServices;

namespace OrbbecSdk.NET
{
    public class Sensor
    {
        /**
 * @brief 获取传感器类型
 *
 * @param[in] sensor 传感器对象
 * @param[out] error 记录错误信息
 * @return ob_sensor_type 返回传感器类型
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_sensor_type ob_sensor_get_type(IntPtr sensor, ob_error error);

/*
 * @brief 设置bool类型的设备属性
 *
 * @param[in] sensor 设备对象
 * @param[in] property_id 要设置的属性id
 * @param[in] property 要设置的属性值
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_sensor_set_bool_property(IntPtr sensor, ob_global_unified_property property_id, bool property, ob_error error);

        /**
 * @brief 获取bool类型的设备属性
 *
 * @param[in] sensor 设备对象
 * @param[in] property_id 属性id
 * @param[out] error 记录错误信息
 * @return bool 返回属性值
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern bool ob_sensor_get_bool_property(IntPtr sensor, ob_global_unified_property property_id, ob_error error);

        /**
 * @brief 设置int类型的设备属性
 *
 * @param[in] sensor 设备对象
 * @param[in] property_id 要设置的属性id
 * @param[in] property 要设置的属性值
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_sensor_set_int_property(IntPtr sensor, ob_global_unified_property property_id, int property, ob_error error);

        /**
 * @brief 获取int类型的设备属性
 *
 * @param[in] sensor 设备对象
 * @param[in] property_id 属性id
 * @param[out] error 记录错误信息
 * @return int 返回属性值
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern int ob_sensor_get_int_property(IntPtr sensor, ob_global_unified_property property_id, ob_error error);

        /**
 * @brief 设置float类型的设备属性
 *
 * @param[in] sensor 设备对象
 * @param[in] property_id 要设置的属性id
 * @param[in] property 要设置的属性值
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_sensor_set_float_property(IntPtr sensor, ob_global_unified_property property_id, float property, ob_error error);

        /**
 * @brief 获取float类型的设备属性
 *
 * @param[in] sensor 设备对象
 * @param[in] property_id 属性id
 * @param[out] error 记录错误信息
 * @return int 返回属性值
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern float ob_sensor_get_float_property(IntPtr sensor, ob_global_unified_property property_id, ob_error error);

        /**
 * @brief 设置结构体类型的设备属性
 *
 * @param[in] sensor 设备对象
 * @param[in] property_id 要设置的属性id
 * @param[in] data 要设置的属性数据
 * @param[in] data_size 要设置的属性大小
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_sensor_set_structured_data(IntPtr sensor, ob_global_unified_property property_id, IntPtr data, uint data_size, ob_error error);

        /**
 * @brief 获取结构体类型的设备属性
 *
 * @param[in] sensor 设备对象
 * @param[in] property_id 要获取的属性id
 * @param[out] data 获取的属性数据
 * @param[out] data_size 获取的属性大小
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_sensor_get_structured_data(IntPtr sensor, ob_global_unified_property property_id, IntPtr data, ref uint data_size, ob_error error);

        /**
 * @brief 获取raw_data类型的传感器属性
 *
 * @param[in] sensor 传感器对象
 * @param[in] property_id 属性的id
 * @param[in] cb 获取数据及进度回调
 * @param[in] async 是否异步执行
 * @param[in] user_data 用户自定义数据，会在回调中返回
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern bool ob_sensor_get_raw_data(IntPtr sensor, ob_global_unified_property property_id, Device.ob_get_data_callback cb, bool async, IntPtr user_data, ob_error error);

        /**
 * @brief 设置raw data类型的传感器属性
 *
 * @param[in] sensor 传感器对象
 * @param[in] property_id 属性的id
 * @param[in] data 要设置的属性数据
 * @param[in] data_size 设置的属性大小
 * @param[in] cb 进度回调
 * @param[in] async 是否异步执行
 * @param[in] user_data 用户自定义数据，会在回调中返回
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern bool ob_sensor_set_raw_data(IntPtr sensor, ob_global_unified_property property_id, IntPtr data, uint data_size, Device.ob_set_data_callback cb, bool async, IntPtr user_data, ob_error error);

        /**
 * @brief 获取int类型传感器属性的范围
 *
 * @param[in] sensor 传感器对象
 * @param[in] property_id 属性的id
 * @param[out] error 记录错误信息
 * @return ob_int_property_range 返回传感器属性范围
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_int_property_range ob_sensor_get_int_property_range(IntPtr sensor, ob_global_unified_property property_id, ob_error error);

        /**
 * @brief 获取float类型传感器属性的范围
 *
 * @param[in] sensor 传感器对象
 * @param[in] property_id 属性的id
 * @param[out] error 记录错误信息
 * @return ob_int_property_range 返回传感器属性范围
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_float_property_range ob_sensor_get_float_property_range(IntPtr sensor, ob_global_unified_property property_id, ob_error error);

        /**
 * @brief 获取bool类型传感器属性的范围
 *
 * @param[in] sensor 传感器对象
 * @param[in] property_id 属性的id
 * @param[out] error 记录错误信息
 * @return ob_bool_property_range 返回传感器属性范围
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_bool_property_range ob_sensor_get_bool_property_range(IntPtr sensor, ob_global_unified_property property_id, ob_error error);

        /**
 * @brief 获取传感器支持的属性的数量
 *
 * @param[in] sensor 传感器对象
 * @param[out] error 记录错误信息
 * @return uint 返回传感器支持的属性的数量
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern uint ob_sensor_get_supported_property_count(IntPtr sensor, ob_error error);

        /**
 * @brief 获取传感器支持的属性
 *
 * @param[in] sensor 传感器对象
 * @param[in] index 属性的index
 * @param[out] error 记录错误信息
 * @return ob_global_unified_property_item 返回传感器支持的属性的类型
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_global_unified_property_item ob_sensor_get_supported_property(IntPtr sensor, uint index, ob_error error);

        /**
 * @brief 查询传感器属性是否支持
 *
 * @param[in] sensor 传感器对象
 * @param[in] property_id 要查询的属性id
 * @param[out] error 记录错误信息
 * @return bool 返回属性是否支持
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern bool ob_sensor_is_property_supported(IntPtr sensor, ob_global_unified_property property_id, ob_error error);

        /**
 * @brief 获取传感器支持的所有流的配置
 *
 * @param[in] sensor 传感器对象
 * @param[out] count 获取的流配置的数量
 * @param[out] error 记录错误信息
 * @return IntPtr 返回流配置的列表
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_sensor_get_stream_profiles(IntPtr sensor, ref uint count, ob_error error);

        /// <summary>
        /// 帧数据到达时触发的回调函数
        /// </summary>
        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate int ob_frame_callback(IntPtr frame, IntPtr user_data);

        /**
 * @brief 打开传感器的流，并设置帧数据回调
 *
 * @param[in] sensor 传感器对象
 * @param[in] profile 流的配置信息
 * @param[in] callback 帧数据到达时触发的回调函数
 * @param[in] user_data 可以传入任意用户数据，并从回调中获取
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_sensor_start(IntPtr sensor, IntPtr profile, [MarshalAs(UnmanagedType.FunctionPtr)] ob_frame_callback callback, IntPtr user_data, ob_error error);

        /**
 * @brief 停止传感器的流
 *
 * @param[in] sensor 传感器对象
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_sensor_stop(IntPtr sensor, ob_error error);

        /**
 * @brief 删除传感器对象列表
 *
 * @param[in] sensors 要删除的传感器对象列表
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_delete_sensor_list(IntPtr sensors, ob_error error);

        /**
 * @brief 获取传感器列表内传感器个数
 *
 * @param[in] sensors 要删除的传感器对象列表
 * @param[in] count 传感器数量
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern uint ob_sensor_list_get_sensor_count(IntPtr sensors, ob_error error);

        /**
 * @brief 获取指定Sensor的类型
 *
 * @param index Sensor索引
 * @return OBSensorType 返回Sensor类型
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern ob_sensor_type ob_sensor_list_get_sensor_type(IntPtr sensors, uint index, ob_error error);

        /**
 * @brief 通过Sensor类型获取Sensor
 *
 * @param sensors 通过device获取返回的sensor列表
 * @param sensorType 要获取的Sensor类型
 * @return  返回Sensor指针，如果指定类型Sensor不存在，将返回空
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_get_sensor_by_type(IntPtr sensors, ob_sensor_type sensorType, ob_error error);

        /**
 * @brief 通过索引号获取Sensor
 *
 * @param sensors 通过device获取返回的sensor列表
 * @param index 要创建设备的索，范围 [0, count-1]，如果index超出范围将抛异常
 * @return std::shared_ptr<Sensor> 返回Sensor对象
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern IntPtr ob_get_sensor(IntPtr sensors, uint index, ob_error error);

        /**
 * @brief 删除传感器对象
 *
 * @param[in] sensor 要删除的传感器对象
 * @param[out] error 记录错误信息
 */
        [DllImport("OrbbecSDK.dll")]
        public static extern void ob_delete_sensor(IntPtr sensor, ob_error error);
    }
}