using IIDToolbox;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TDD_IIDRelayWhenReachMono : MonoBehaviour
{

    //public OffsetDateTimeToNTP m_currentOffset;

    //public UnityEvent<I_IndexIntegerDate> m_onPushIID;

    //public TimeTypeIID m_dateType = TimeTypeIID.WhenToExecute;
    //public float m_delayInSeconds = 5f;


    //public long m_currentNtpTime;
    //public StructRefIndexIntegerDate m_lastPushed;

    //public void Update()
    //{
    //    m_currentNtpTime = IIDUtility.GetNtpMillisecondsLong1970();
    //}

    //[ContextMenu("PushRandomNow")]
    //public void PushRandomNow()
    //{
    //    I_IndexIntegerDate id = CreateRandomToPush();

    //    m_onPushIID.Invoke(id);

    //}

    //private I_IndexIntegerDate CreateRandomToPush()
    //{
    //     IIDUtility.CreateEmpty(out I_IndexIntegerDate id);
    //    id.SetIndex(UnityEngine.Random.Range(-100, 100));
    //    id.SetValue(UnityEngine.Random.Range(-100, 100));
    //    id.SetNtpMillisecondsSince1970(m_dateType,
    //        IIDUtility.GetNtpMillisecondsLong1970());
    //    return id;
    //}

    //[ContextMenu("Push Sequence Random Now")]
    //public void PushSequenceRandomNow() { 
    
    //    for (int i = 0; i < 10; i++)
    //    {
    //        I_IndexIntegerDate id = CreateRandomToPush();
    //        id.SetNtpMillisecondsSince1970(m_dateType, i*1000);
    //        m_onPushIID.Invoke(id);
    //    }
    //}
}
