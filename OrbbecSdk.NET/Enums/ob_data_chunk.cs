using System;

namespace OrbbecSdk.NET.Enums
{
    public struct ob_data_chunk
    {
        public IntPtr data; // 当前数据块数据
        public uint size; // 当前数据块大小
        public uint offset; // 当前数据块相对完整数据的偏移
        public uint fullDataSize; // 完整数据大小
    }
}