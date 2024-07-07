using System;

namespace IIDToolbox
{
    [System.Serializable]
    public struct STRUCT_IID_LOCAL_TIME_REGION_TICK: I_STRUCT_IID_TICK
    {
        public long m_dateTimeTick;

        public long GetTick()
        {
            return m_dateTimeTick;
        }

        public void SetWithTick(long tick)
        {
            m_dateTimeTick = tick;
        }
    }


}
