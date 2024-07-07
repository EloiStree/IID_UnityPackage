

namespace IIDToolbox
{
    [System.Serializable]
    public struct STRUCT_IID_TICKS : I_STRUCT_IID_TICK
    {
        public long m_ticks;

        public long GetTick()
        {
            return m_ticks;
        }

        public void SetWithTick(long tick)
        {
            m_ticks = tick;
        }
    }

}
