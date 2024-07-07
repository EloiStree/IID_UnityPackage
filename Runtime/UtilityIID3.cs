using System;



namespace IIDToolbox
{
    public static partial class UtilityIID
    {


       
        public static void GetTime(out STRUCT_IID_NTP_TIME_TICK time)
        {
            time = new STRUCT_IID_NTP_TIME_TICK();
            UtilityIID.GetNtpOffset(out STRUCT_IID_MICROSECOND_OFFSET_UTC2NTP offsetUtc2Ntp);
            long tick = offsetUtc2Ntp.m_microSecondsOffsetLocal2NTP.GetTick();
            time.SetWithTick(tick);
        }

        public static void GetTime(out STRUCT_IID_LOCAL_TIME_REGION_TICK time)
        {
            time = new STRUCT_IID_LOCAL_TIME_REGION_TICK();
            time.SetWithTick(DateTime.Now.Ticks);
        }
        public static void GetTime(out STRUCT_IID_LOCAL_TIME_UTC_TICK time)
        {
            time = new STRUCT_IID_LOCAL_TIME_UTC_TICK();
            time.SetWithTick(DateTime.UtcNow.Ticks);
        }
      
    }
}