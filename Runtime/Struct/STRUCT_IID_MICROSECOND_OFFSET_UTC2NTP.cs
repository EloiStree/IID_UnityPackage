

namespace IIDToolbox
{
    [System.Serializable]
    public struct STRUCT_IID_MICROSECOND_OFFSET_UTC2NTP : I_STRUCT_IID_TICK
    {
        public STRUCT_IID_MICROSECONDS m_microSecondsOffsetLocal2NTP;
        public long GetTick()
        {
            return m_microSecondsOffsetLocal2NTP.GetTick();
        }

        public void SetWithTick(long tick)
        {
            m_microSecondsOffsetLocal2NTP.SetWithTick(tick);
        }
    }
}
