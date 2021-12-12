using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Class_Helper
{
    class Utils
    {
        /// <summary>
        /// 随机数生成
        /// </summary>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值</param>
        /// <returns>随机数</returns>
        public static int RandomNum(int min, int max)
        {
            return new Random().Next(min, max + 1);
        }

        /// <summary>
        /// 将时间转换为 Unix 时间戳
        /// </summary>
        public static long GetUnix(DateTime dt)
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
            return (long)(dt - startTime).TotalSeconds;
        }

        /// <summary>
        /// 将 Unix 时间戳转换为时间
        /// </summary>
        public static DateTime GetDateTime(long timeStamp)
        {
            DateTime startDt = TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), TimeZoneInfo.Local);
            long lTime = timeStamp * 10000000;
            TimeSpan toNow = new TimeSpan(lTime);
            return startDt.Add(toNow);
        }

        /// <summary>
        /// 计算两个时间的时间差
        /// </summary>
        public static string[] DateDiff(DateTime dt1, DateTime dt2)
        {
            TimeSpan ts1 = new TimeSpan(dt1.Ticks);
            TimeSpan ts2 = new TimeSpan(dt2.Ticks);
            TimeSpan ts = ts1.Subtract(ts2).Duration();

            return new string[]{ ts.Days.ToString(), ts.Hours.ToString(), ts.Minutes.ToString(), ts.Seconds.ToString() };
        }
    }
}
