

using System;

namespace IIDToolbox
{
    public static partial class UtilityIID {

        //public static void GetLocalDateTime(out DateTime time)
        //    => time = DateTime.Now;
        //public static void GetLocalDateTimeUtc(out DateTime time)
        //    => time = DateTime.UtcNow;

        public static void GetTicksFromDateTime1970Utc(out long ticks)
            => ticks = (DateTime.UtcNow - new DateTime(1970, 1, 1, 1, 0, 0, DateTimeKind.Utc)).Ticks;
        public static void GetTicksFromDateTime1970UtcNtp(out long ticks)
        {
            GetTicksFromDateTime1970Utc(out ticks);
            ticks += m_globalNtpMicroSecondOffset.GetTick();
        }
        public static void GetMicrosecondsFromDateTime1970Utc(out long ticks)
            => ticks = (DateTime.UtcNow - new DateTime(1970, 1, 1, 1, 0, 0, DateTimeKind.Utc)).Ticks/10;
        public static void GetMicrosecondsFromDateTime1970UtcNtp(out long ticks)
        {
            GetMicrosecondsFromDateTime1970Utc(out ticks);
            ticks += m_globalNtpMicroSecondOffset.GetTick()/10;
        }


        public static void ParseTickToMicrosecond(long tick, out long microseconds)
            => microseconds = tick * 10;

        public static void ParseMicrosecondToTick(long microseconds, out long tick)
            => tick = microseconds / 10;

        public static void ParseTickToMillisecond(long tick, out long microseconds)
            => microseconds = tick * TimeSpan.TicksPerMillisecond;

        public static void ParseMillisecondToTick(long microseconds, out long tick)
            => tick = microseconds / TimeSpan.TicksPerMillisecond;

        public static void ParseTickToSecond(long tick, out long microseconds)
            => microseconds = tick * TimeSpan.TicksPerSecond;

        public static void ParseSecondToTick(long microseconds, out long tick)
            => tick = microseconds / TimeSpan.TicksPerSecond;

    }


}
