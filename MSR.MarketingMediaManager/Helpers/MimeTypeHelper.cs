using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace MSR.MarketingMediaManager.Helpers
{
    public static class MimeTypeHelper
    {
        private const string Png = "image/png";
        private const string Jpg = "image/jpeg";
        private const string Gif = "image/gif";


        private static readonly Dictionary<string, string> MimeTypeMappings = new Dictionary<string, string>
        {
            { "image/png", Png },
            { "image/x-png", Png },
            { "application/png", Png },
            { "application/x-png", Png },
            { "image/gif", Gif },
            { "image/jpg", Jpg },
            { "image/jpeg", Jpg },
            { "image/pjpg", Jpg },
            { "image/pjpeg", Jpg },
            { "application/pipeg", Jpg },
            { "application/x-jpg", Jpg },
            { "application/jpeg", Jpg },
            { "application/x-jpeg", Jpg },
        };

        internal static string GetMimeType(FileSystemInfo file)
        {
            FindMimeFromData(0, null, File.ReadAllBytes(file.FullName), 256, null, 0, out var mimeTypeNum, 0);
            var mimeTypeP = new IntPtr(mimeTypeNum);
            var inferredMimeType = Marshal.PtrToStringUni(mimeTypeP)?.ToLowerInvariant();
            if (inferredMimeType == null) return null;
            return MimeTypeMappings.ContainsKey(inferredMimeType) ? MimeTypeMappings[inferredMimeType] : null;
        }

        [DllImport(@"urlmon.dll", CharSet = CharSet.Auto)]
        private static extern uint FindMimeFromData(uint pBC,
            [MarshalAs(UnmanagedType.LPStr)] string pwzUrl,
            [MarshalAs(UnmanagedType.LPArray)] byte[] pBuffer,
            uint cbSize, [MarshalAs(UnmanagedType.LPStr)] string pwzMimeProposed,
            uint dwMimeFlags,
            out uint ppwzMimeOut,
            uint dwReserverd);
    }
}