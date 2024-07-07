using System;
using UnityEngine;

namespace IIDToolbox
{
    public class TDD_UlongToIIDMono : MonoBehaviour
    {
        public ulong m_rawType;
        public E_IID_DATE_TYPE m_dateType;
        public long m_time;
        public ulong m_rawTypeRecovered;

        public string m_dateTime;


        private void OnValidate()
        {
            Refresh();
        }

        private void Refresh()
        {
            UtilityIID.GetDateTypeFromUlong(m_rawType, out m_dateType, out m_time);
            UtilityIID.GetUlongFromDateType(m_dateType, m_time, out m_rawTypeRecovered);
            long tick = m_time * 10;
            if (tick > DateTime.MaxValue.Ticks)
            { 
                tick= DateTime.MaxValue.Ticks;
            }
            DateTime dateTime = new DateTime(tick, DateTimeKind.Utc);
            m_dateTime = dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        [ContextMenu("SetRawWithCurrentUtcTime")]
        public void SetRawWithCurrentUtcTime() { 

            UtilityIID.GetMicrosecondsFromDateTime1970Utc(out  long time);
            m_rawType=(ulong)time;
            Refresh();
          
        
        
        }

       
    }

}
