

namespace IIDToolbox
{
    [System.Serializable]
    public struct STRUCT_IID_MILLISECONDS: I_STRUCT_IID_TICK
    {

        public long m_milliSeconds;

        public long GetTick()
        {
            return m_milliSeconds*10000;
        }

        public void SetWithTick(long tick)
        {
            m_milliSeconds = tick/10000;
        }
    }


}
