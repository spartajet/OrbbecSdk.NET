namespace OrbbecSdk.NET.Enums
{
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
}