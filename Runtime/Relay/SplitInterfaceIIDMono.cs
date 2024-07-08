using IIDToolbox;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SplitInterfaceIIDMono : MonoBehaviour
{

    public STRUCT_IID_UNITY_DATA m_last;
    public UnityEvent<int> m_onPushIndex;
    public UnityEvent<int> m_onPushValue;
    public UnityEvent<long> m_onPushTimeMicro;
    public UnityEvent<long> m_onPushTimeTick;
    public UnityEvent<E_IID_DATE_TYPE> m_onPushType;

    public void PushIn(I_IndexIntegerDateWithType id)
    {
        UtilityIID.CreateStructFrom(id, out m_last);
        m_onPushIndex.Invoke(m_last.m_claimIndex.m_claimIndex);
        m_onPushValue.Invoke(m_last.m_integerValue.m_integerValue);
        m_onPushTimeMicro.Invoke(m_last.m_microSeconds1970.m_microSeconds);
        m_onPushTimeTick.Invoke(m_last.m_microSeconds1970.GetTick());
        m_onPushType.Invoke(id.GetTimeType());


    }
}
