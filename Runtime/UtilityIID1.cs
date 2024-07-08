namespace IIDToolbox
{
    public static partial class UtilityIID
    {


        public static void Parse(
            STRUCT_IID_INTEGER_VALUE value, 
            STRUCT_IID_MICROSECONDS1970 microSeconds, 
            STRUCT_IID_MICROSECOND_OFFSET_UTC2NTP offest,
            out STRUCT_IID_INTEGER_DATE to)
        {
            to.m_integerValue.m_integerValue = value.m_integerValue;
            to.m_microSeconds1970.m_microSeconds = microSeconds.m_microSeconds1970.m_microSeconds + offest.m_microSecondsOffsetLocal2NTP.m_microSeconds;
            GetDateTypeFromUlong((ulong)microSeconds.m_microSeconds1970.m_microSeconds, out to.m_dateType, out to.m_microSeconds1970.m_microSeconds);

        }

        public static void Parse(STRUCT_IID_INDEX_INTEGER_VALUE from, out STRUCT_IID_UNITY_DATA to)
        {
            to.m_claimIndex = from.m_claimIndex;
            to.m_integerValue = from.m_integerValue;
            GetDateTypeFromUlong((ulong)from.m_integerValue.m_integerValue, out to.m_dateType, out to.m_microSeconds1970.m_microSeconds);
        }
        public static void Parse(STRUCT_IID_UNITY_DATA from, out STRUCT_IID_RAW_DATA to)
        {
            to.m_claimIndex = from.m_claimIndex.m_claimIndex;
            to.m_integerValue = from.m_integerValue.m_integerValue;
            GetUlongFromDateType(from.m_dateType, from.m_microSeconds1970.m_microSeconds, out to.m_rawUlongDateAndType);

        }
        public static void Parse(STRUCT_IID_RAW_DATA from, out STRUCT_IID_INTEGER_DATE to)
        {
            to.m_integerValue.m_integerValue = from.m_integerValue;
            GetDateTypeFromUlong(from.m_rawUlongDateAndType, out to.m_dateType, out to.m_microSeconds1970.m_microSeconds);

        }
        public static void Parse(STRUCT_IID_INTEGER_DATE from,  out STRUCT_IID_INTEGER_VALUE value, out E_IID_DATE_TYPE date, out STRUCT_IID_MICROSECONDS1970 timestamp)
        {
            value.m_integerValue = from.m_integerValue.m_integerValue;
            date = from.m_dateType;
            timestamp.m_microSeconds1970.m_microSeconds = from.m_microSeconds1970.m_microSeconds;
        }
    }


}
