using IIDToolbox;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityIIDMono : MonoBehaviour
{

    public STRUCT_IID_CURRENT_FULL_TIME m_currentTime;
   
    public void SetOffsetFromTicks(long tickOffset) {
        UtilityIID.SetNtpOffsetFromTick(tickOffset);
        m_currentTime.m_ntpOffset = UtilityIID.GetNtpOffset();
    }

    public void Update()
    {
        UtilityIID.GetTicksFromDateTime1970Utc(out long timeNow);
        m_currentTime.m_ntpOffset = UtilityIID.GetNtpOffset();
        m_currentTime.SetWithTick(timeNow);
    }
}


[System.Serializable]
public struct STRUCT_IID_CURRENT_FULL_TIME : I_STRUCT_IID_TICK_SET
{
    public STRUCT_IID_MICROSECOND_OFFSET_UTC2NTP m_ntpOffset;
    public STRUCT_IID_FULL_DATETIME m_currentTimeUtc;
    public STRUCT_IID_FULL_DATETIME m_currentTimeUtcNtp;

    public void SetWithTick(long tick)
    {
        m_currentTimeUtc.SetWithTick(tick);
        m_currentTimeUtcNtp.SetWithTick(tick + m_ntpOffset.GetTick());
    }
}
[System.Serializable]
public struct STRUCT_IID_FULL_DATETIME :I_STRUCT_IID_TICK
{
    public STRUCT_IID_TICKS m_tick;
    public STRUCT_IID_MICROSECONDS m_microseconds;
    public STRUCT_IID_MILLISECONDS m_milliseconds;
    public STRUCT_IID_SECONDS m_seconds;
    public long GetTick()
    {
        return m_tick.GetTick();
    }

    public void SetWithTick(long tick)
    {
        m_tick.SetWithTick(tick);
        m_microseconds.SetWithTick(tick);
        m_milliseconds.SetWithTick(tick);
        m_seconds.SetWithTick(tick);

    }
}