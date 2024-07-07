using IIDToolbox;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;







[System.Serializable]
public class ExecuteOrDelayIndexIntegerDateMono : MonoBehaviour
{

    //public UnityEvent<I_GetIndexIntegerDateWithType> m_onRequestToExecute;

    //[System.Serializable]
    //public class WaitingToBeExecuted
    //{
    //    public MillisecondsSince1970 m_milliSeconds1970;
    //    public I_GetIndexIntegerDateWithType m_interfaceToPush;
    //}

    //public List<WaitingToBeExecuted> m_waitingToBeExecuted = new List<WaitingToBeExecuted>();

   
    //public void PushIn(I_GetIndexIntegerDateWithType valueRef) {

    //    WaitingToBeExecuted w = new WaitingToBeExecuted();
    //    w.m_interfaceToPush = valueRef;
    //    long tick = valueRef.GetTick();
    //    UtilityIID.ParseTickToMicrosecond(tick, out long microSeconds);
    //    w.m_milliSeconds1970.m_milliseconds = microSeconds;
    //    m_waitingToBeExecuted.Add(w);

    //}

    //public void CheckAndPushWaiting() { 
    
    //    for(int i = m_waitingToBeExecuted.Count-1; i >= 0; i--)
    //    {
    //        if (m_waitingToBeExecuted[i].m_milliSeconds1970.m_milliseconds <= IIDUtility.GetNtpUtcMillisecondsLong1970())
    //        {
    //            m_onRequestToExecute.Invoke(m_waitingToBeExecuted[i].m_interfaceToPush);
    //            m_waitingToBeExecuted.RemoveAt(i);
    //        }
    //    }
    //}

}


