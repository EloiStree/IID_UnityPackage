using System;

namespace IIDToolbox
{
    public class TDD_UtilityIID_Parse
    {
        public STRUCT_IID_INDEX_INTEGER_VALUE m_indexValue;
        public STRUCT_IID_UNITY_DATA m_b;
        public STRUCT_IID_RAW_DATA m_a;
        public STRUCT_IID_INTEGER_DATE m_c;

        public long m_microSecondsOffset;
        public long m_nowUTC_ticks;
        public long m_nowUTC_microSeconds;
        public long m_nowUTC_milliSeconds;
        public long m_nowUTC_seconds;

        public void Update() {

            Refresh();
        }

        public void OnValidate()
        {
            Refresh();

        }

        private void Refresh()
        {
            DateTime now = DateTime.UtcNow;
            m_nowUTC_ticks = now.Ticks;
            m_nowUTC_microSeconds = now.Ticks * 10;
            m_nowUTC_milliSeconds = now.Ticks / 10000;
            m_nowUTC_seconds = now.Ticks / 10000000;
        }
    }

}
