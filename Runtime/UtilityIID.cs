namespace IIDToolbox
{
    [System.Serializable]
    public static partial class UtilityIID {

        public const ulong DIVIDER_TO_TYPE = 1000000000000000000;
        //10017203882137545501
        //10000000000000000000
        //100000000000000000


        public static void GetDateTypeFromUlong(ulong rawDateTimeReceived, out E_IID_DATE_TYPE dateType, out long timeInMicroSeconds) {
            byte typeByte = (byte)(rawDateTimeReceived / DIVIDER_TO_TYPE);

            timeInMicroSeconds = (long)(rawDateTimeReceived % DIVIDER_TO_TYPE);

            switch (typeByte)
            {
                case 0: dateType = E_IID_DATE_TYPE.UNKOWN; break;
                case 10: dateType = E_IID_DATE_TYPE.NTP_WHEN_TO_EXECUTE; break;
                case 01: dateType = E_IID_DATE_TYPE.NTP_SENT; break;
                case 02: dateType = E_IID_DATE_TYPE.LOCAL_TIME_UTC_WHEN_TO_EXECUTE; break;
                case 03: dateType = E_IID_DATE_TYPE.LOCAL_TIME_UTC_SENT; break;
                case 04: dateType = E_IID_DATE_TYPE.LOCAL_TIME_REGION; break;
                case 09: dateType = E_IID_DATE_TYPE.EXTENDED_SPACE; break;
                default:
                    dateType = E_IID_DATE_TYPE.CUSTOM;
                    break;
            }
        }
        public static void GetUlongFromDateType(E_IID_DATE_TYPE dateType, long timeinMicroSeconds, out ulong rawDateTimeSent) {
            byte typebyte = 0;
            switch (dateType)
            {
                case E_IID_DATE_TYPE.UNKOWN: typebyte = 0; break;
                case E_IID_DATE_TYPE.NTP_WHEN_TO_EXECUTE: typebyte = 10; break;
                case E_IID_DATE_TYPE.NTP_SENT: typebyte = 01; break;
                case E_IID_DATE_TYPE.LOCAL_TIME_UTC_WHEN_TO_EXECUTE: typebyte = 02; break;
                case E_IID_DATE_TYPE.LOCAL_TIME_UTC_SENT: typebyte = 03; break;
                case E_IID_DATE_TYPE.LOCAL_TIME_REGION: typebyte = 04; break;
                case E_IID_DATE_TYPE.EXTENDED_SPACE: typebyte = 09; break;
                default:
                    typebyte = 5;
                    break;
            }
            rawDateTimeSent = ((ulong)typebyte * (ulong)DIVIDER_TO_TYPE) + (ulong)timeinMicroSeconds;

        }
    }


}
