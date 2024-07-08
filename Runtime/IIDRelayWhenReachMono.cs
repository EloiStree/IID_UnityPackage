using IIDToolbox;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;







[System.Serializable]
public class ExecuteOrDelayIndexIntegerDateMono : MonoBehaviour
{

    public UnityEvent<I_IndexIntegerDateWithType> m_onRequestToExecute;

    [System.Serializable]
    public class WaitingToBeExecuted
    {
        public STRUCT_IID_UNITY_DATA m_value;
        public I_IndexIntegerDateWithType m_interfaceToPush;
    }

    public List<WaitingToBeExecuted> m_waitingToBeExecuted = new List<WaitingToBeExecuted>();


    public void PushIn(I_IndexIntegerDateWithType valueRef)
    {

        WaitingToBeExecuted w = new WaitingToBeExecuted();
        UtilityIID.CreateStructFrom(valueRef, out w.m_value);
        if(w.m_value.m_dateType== E_IID_DATE_TYPE.LOCAL_TIME_UTC_WHEN_TO_EXECUTE)
        {
            UtilityIID.GetNtpOffset(out STRUCT_IID_MICROSECOND_OFFSET_UTC2NTP offset);
            long t = w.m_value.m_microSeconds1970.GetTick() + offset.GetTick();
            w.m_value.m_microSeconds1970.SetWithTick(t);
        }
        w.m_interfaceToPush = valueRef;
        m_waitingToBeExecuted.Add(w);

    }

    public void Update()
    {
        CheckAndPushWaiting();
    
    }
    public long m_currentNtpTime;
    public void CheckAndPushWaiting()
    {

        UtilityIID.GetMicrosecondsFromDateTime1970UtcNtp(out  m_currentNtpTime);
        for (int i = m_waitingToBeExecuted.Count - 1; i >= 0; i--)
        {
            if (m_waitingToBeExecuted[i].m_value.m_microSeconds1970.m_microSeconds <= m_currentNtpTime)
            {
                m_onRequestToExecute.Invoke(m_waitingToBeExecuted[i].m_interfaceToPush);
                m_waitingToBeExecuted.RemoveAt(i);
            }
        }
    }

}


