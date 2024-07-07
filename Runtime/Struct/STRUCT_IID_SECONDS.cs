

using System;

namespace IIDToolbox
{
    [System.Serializable]
    public struct STRUCT_IID_SECONDS : I_STRUCT_IID_TICK
    {
        public long m_seconds;

        public long GetTick()
        {
            return m_seconds * TimeSpan.TicksPerSecond;
        }

        public void SetWithTick(long tick)
        {
            m_seconds = tick / TimeSpan.TicksPerSecond;
        }
    }


}
