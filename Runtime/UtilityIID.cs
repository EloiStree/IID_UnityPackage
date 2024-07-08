using IIDToolbox;
using System;

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

        public static void CreateEmpty(out I_IntegerDateWithType id)
        {
            id = new REF_ID();
        }

        public static void CreateEmpty(out I_IndexIntegerDateWithType iid)
        {
            iid = new REF_IDD();
        }

        public static void CreateStructFrom(I_IntegerDateWithType source, out STRUCT_IID_INTEGER_DATE created)
        {
            created = new STRUCT_IID_INTEGER_DATE();
            source.GetTimeType(out created.m_dateType);
            source.GetValue(out created.m_integerValue.m_integerValue);
            created.m_microSeconds1970.SetWithTick(source.GetTick());
            

        }
        public static void CreateStructFrom(I_IndexIntegerDateWithType source, out STRUCT_IID_UNITY_DATA created)
        {
            created = new STRUCT_IID_UNITY_DATA();
            source.GetTimeType(out created.m_dateType);
            source.GetValue(out created.m_integerValue.m_integerValue);
            source.GetIndex(out created.m_claimIndex.m_claimIndex);
            created.m_microSeconds1970.SetWithTick(source.GetTick());
        }
    }
}


[System.Serializable]
public class REF_ID: I_IntegerDateWithType
{
    public STRUCT_IID_INTEGER_DATE m_value;

   

    public long GetTick()
    {
        return m_value.m_microSeconds1970.GetTick();
    }

    public void GetTimeType(out E_IID_DATE_TYPE type)
    {
        type = m_value.m_dateType;
    }


    public void GetType(out E_IID_DATE_TYPE dateType)
    {
        dateType = m_value.m_dateType;
    }
    public void SetType(E_IID_DATE_TYPE dateType)
    {
         m_value.m_dateType= dateType;
    }
    public void GetValue(out int value)
    {
        value = m_value.m_integerValue.m_integerValue;
    }

    public void SetIndex(int index)
    {
        m_value.m_integerValue.m_integerValue = index;
    }

    public void SetTimeType(E_IID_DATE_TYPE type, long microseconds)
    {

        m_value.m_dateType = type;
        m_value.m_microSeconds1970.SetWithTick(microseconds * 10);
    }

  

    public void SetValue(int value)
    {
        m_value.m_integerValue.m_integerValue = value;
    }

    public E_IID_DATE_TYPE GetTimeType()
    {
        return m_value.m_dateType;
    }
}
[System.Serializable]
public class REF_IDD: I_IndexIntegerDateWithType
{
    public STRUCT_IID_UNITY_DATA m_value;

    public void GetIndex(out int index)
    {
        index= m_value.m_claimIndex.m_claimIndex;
    }

    public long GetTick()
    {
        return m_value.m_microSeconds1970.GetTick();
    }

    public void GetTimeType(out E_IID_DATE_TYPE type)
    {
        type = m_value.m_dateType;
    }

    public E_IID_DATE_TYPE GetTimeType()
    {
        return m_value.m_dateType;
    }

    public void GetValue(out int value)
    {
        value = m_value.m_integerValue.m_integerValue;
    }

    public void SetIndex(int index)
    {
        m_value.m_integerValue.m_integerValue = index;
    }

    public void SetTimeType(E_IID_DATE_TYPE type, long microseconds)
    {

        m_value.m_dateType = type;
        m_value.m_microSeconds1970.SetWithTick(microseconds*10);
    }

    public void SetValue(int value)
    {
        m_value.m_integerValue.m_integerValue = value;
    }
}


