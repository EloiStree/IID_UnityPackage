

namespace IIDToolbox
{
    [System.Serializable]
    public struct STRUCT_IID_MICROSECONDS : I_STRUCT_IID_TICK
    {

        public long m_microSeconds;

        public long GetTick()
        {
            return m_microSeconds * 10;
        }

        public void SetWithTick(long tick)
        {
            m_microSeconds = tick / 10;
        }
    }
}
