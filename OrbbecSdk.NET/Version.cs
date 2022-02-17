using System.Runtime.InteropServices;

namespace OrbbecSdk.NET
{
    public class Version
    {
        /// <summary>
        /// 获取SDK版本号
        /// </summary>
        /// <returns>返回SDK版本号</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern int ob_get_version();

        /// <summary>
        /// 获取SDK主版本号
        /// </summary>
        /// <returns>返回SDK主版本号</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern int ob_get_major_version();

        /// <summary>
        /// 获取SDK副版本号
        /// </summary>
        /// <returns>返回SDK副版本号</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern int ob_get_minor_version();

        /// <summary>
        /// 获取SDK修订版本号
        /// </summary>
        /// <returns>返回SDK修订版本号</returns>
        [DllImport("OrbbecSDK.dll")]
        public static extern int ob_get_patch_version();
    }
}