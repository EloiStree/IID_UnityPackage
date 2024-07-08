using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RelayIntegerToColorMono : MonoBehaviour
{
   
    public int m_value;
    public Color m_color;
    public UnityEvent<Color> m_onPushColor;

    public void PushIn(int value)
    {
        m_value = value;
        byte[] bytes = System.BitConverter.GetBytes(value);
        m_color = new Color32(bytes[0], bytes[1], bytes[2], 255);
        m_onPushColor.Invoke(m_color);
    }
}
