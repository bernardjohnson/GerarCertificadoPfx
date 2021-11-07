using System;

namespace GerarCertificadoPfx.Utils
{
    public static class ExtensionMethods
    {
        public static byte[] ConvertPK(this string pemContents)
        {
            string returno = pemContents.Replace("\n", "")
                                        .Replace("\r", "")
                                        .TrimStart("-----BEGIN PRIVATE KEY-----".ToCharArray())
                                        .TrimEnd(@"-----END PRIVATE KEY-----".ToCharArray());
            return Convert.FromBase64String(returno);
        }

        public static byte[] ConvertCRT(this string pemContents)
        {
            string returno = pemContents.Replace("\n", "")
                                        .Replace("\r", "")
                                        .TrimStart("-----BEGIN CERTIFICATE-----".ToCharArray())
                                        .TrimEnd(@"-----END CERTIFICATE-----".ToCharArray());
            return Convert.FromBase64String(returno);
        }
    }
}
