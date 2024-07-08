using IIDToolbox;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TDD_IIDRelayWhenReachMono : MonoBehaviour
{

    public STRUCT_IID_UNITY_DATA m_valueUnityDataPushed;
    public UnityEvent<I_IndexIntegerDateWithType> m_onPushIID;

    public float m_delayInSeconds = 5f;
    public long m_currentNtpTime;

    public void Update()
    {
         UtilityIID.GetMicrosecondsFromDateTime1970UtcNtp(out m_currentNtpTime);
    }

    [ContextMenu("PushRandomNow")]
    public void PushRandomNow()
    {
        I_IndexIntegerDateWithType id = CreateRandomToPush();
        PushInterface(id);

    }

    private void PushInterface(I_IndexIntegerDateWithType id)
    {
        UtilityIID.CreateStructFrom(id, out m_valueUnityDataPushed);
        m_onPushIID.Invoke(id);
    }


    public int m_min= int.MinValue;
    public int m_max= int.MaxValue;
    private I_IndexIntegerDateWithType CreateRandomToPush()
    {
        UtilityIID.CreateEmpty(out I_IndexIntegerDateWithType id);
        id.SetIndex(UnityEngine.Random.Range(m_min, m_max));
        id.SetValue(UnityEngine.Random.Range(m_min, m_max));
        UtilityIID.GetTicksFromDateTime1970UtcNtp(out long tick);
        id.SetTimeType(E_IID_DATE_TYPE.NTP_WHEN_TO_EXECUTE, tick);
        return id;
    }

    [ContextMenu("Push Sequence Random Now")]
    public void PushSequenceRandomNow()
    {

        UtilityIID.GetMicrosecondsFromDateTime1970UtcNtp(out long ntp);
        for (int i = 0; i < 10; i++)
        {
            I_IndexIntegerDateWithType id = CreateRandomToPush();
            id.SetTimeType(E_IID_DATE_TYPE.NTP_WHEN_TO_EXECUTE, ntp+ i *(long)( m_delayInSeconds *TimeSpan.TicksPerSecond/10));
            PushInterface(id);
        }
    }
}
