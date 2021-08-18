using System;

namespace lib
{
    public class Util
    {
        public static string GetTimeString() {
            return DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }
    }
}
