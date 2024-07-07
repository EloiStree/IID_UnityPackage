namespace IIDToolbox
{
    public partial class UtilityIID {

        public static bool IsByteParsable_Integer(byte[] bytes)
        {
            if (bytes == null)
                return false;
            if (bytes.Length != 4)
                return false;
            return true;
        }

        public static bool IsByteParsable_IndexInteger(byte[] bytes)
        {
            if (bytes == null)
                return false;
            if (bytes.Length != 8)
                return false;
            return true;
        }

        public static bool IsByteParsable_IntegerDate(byte[] bytes)
        {
            if (bytes == null)
                return false;
            if (bytes.Length != 12)
                return false;
            return true;
        }
        public static bool IsByteParsable_IndexIntegerDate(byte[] bytes)
        {
            if (bytes == null)
                return false;
            if (bytes.Length != 16)
                return false;
            return true;
        }



        #region OFFSET NTP
        static STRUCT_IID_MICROSECOND_OFFSET_UTC2NTP m_globalNtpMicroSecondOffset;
        public static STRUCT_IID_MICROSECOND_OFFSET_UTC2NTP GetNtpOffset()
        {
            return m_globalNtpMicroSecondOffset;
        }
        public static void GetNtpOffset(out STRUCT_IID_MICROSECOND_OFFSET_UTC2NTP offset)
        {
            offset = m_globalNtpMicroSecondOffset;
        }
        public static void GetNtpOffset(out long offset)
        {
            offset = m_globalNtpMicroSecondOffset.m_microSecondsOffsetLocal2NTP.m_microSeconds;
        }


        public static void SetNtpOffset(STRUCT_IID_MICROSECOND_OFFSET_UTC2NTP offset)
        {
            m_globalNtpMicroSecondOffset = offset;
        }
        public static void SetNtpOffsetFromTick(long offsetTick)
        {
            STRUCT_IID_MICROSECOND_OFFSET_UTC2NTP offset = new STRUCT_IID_MICROSECOND_OFFSET_UTC2NTP();
            offset.SetWithTick(offsetTick);
            m_globalNtpMicroSecondOffset = offset;
        }

        #endregion
    }
}