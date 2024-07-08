using IIDToolbox;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RelayInterfaceIIDMono : MonoBehaviour
{

    public STRUCT_IID_UNITY_DATA m_valueUnityData;

    public UnityEvent<I_IndexIntegerDateWithType> m_onIndexIntegerDateWithType;
    
    public void PushIn(I_IndexIntegerDateWithType value)
    {
        UtilityIID.CreateStructFrom(value, out m_valueUnityData);
        m_onIndexIntegerDateWithType.Invoke(value);
    }
}
