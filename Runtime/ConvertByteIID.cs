using System;

using System.Data;


namespace IIDToolbox
{

    

    public class ConvertByteIID {

        public static void ParseToBytes(I_GetIntegerDateWithType iid, out byte[] bytes)
        {
            STRUCT_IID_MICROSECONDS iidTicks = new STRUCT_IID_MICROSECONDS();
            bytes = new byte[12];
            long tick = iid.GetTick();
            iidTicks.SetWithTick(tick);
            iid.GetValue(out int value);

            long tagDate = iidTicks.m_microSeconds;
            UtilityIID.GetUlongFromDateType(iid.GetTimeType(), iidTicks.m_microSeconds, out ulong tagTime);            
           
            BitConverter.GetBytes(value).CopyTo(bytes, 0);
            BitConverter.GetBytes(tagTime).CopyTo(bytes, 4);
        }
        public static void ParseToBytes(I_GetIndexIntegerDateWithType iid, out byte[] bytes)
        {
            STRUCT_IID_MICROSECONDS iidTicks = new STRUCT_IID_MICROSECONDS();
            bytes = new byte[16] ;
            iid.GetIndex(out int index);
            iid.GetValue(out int value);
            long tick = iid.GetTick();
            iidTicks.SetWithTick(tick);
            long tagDate = iidTicks.m_microSeconds;
            UtilityIID.GetUlongFromDateType(iid.GetTimeType(), iidTicks.m_microSeconds, out ulong tagTime);
            BitConverter.GetBytes(index).CopyTo(bytes, 0);
            BitConverter.GetBytes(value).CopyTo(bytes, 4);
            BitConverter.GetBytes(tagTime).CopyTo(bytes, 8);

        }


        public static void ParseFromBytes(byte[] bytes, I_SetIntegerDateWithType iid)
        {
            if(bytes==null)
               throw new NullReferenceException();

            if (bytes.Length != 12)
                throw new DataException("Bytes must be 12 bytes long");

            int value = BitConverter.ToInt32(bytes, 0);
            ulong dateTime = BitConverter.ToUInt64(bytes, 4);

            UtilityIID.GetDateTypeFromUlong(dateTime, out E_IID_DATE_TYPE type, out long timeInMicroSeconds);          
            iid.SetValue(value);
            iid.SetTimeType(type, timeInMicroSeconds);
        }

        public static void ParseFromBytes(byte[] bytes, I_SetIndexIntegerDateWithType iid)
        {

            if (bytes == null)
                throw new NullReferenceException();

            if (bytes.Length != 16)
                throw new DataException("Bytes must be 16 bytes long");

            int index = BitConverter.ToInt32(bytes, 0);
            int value = BitConverter.ToInt32(bytes, 4);
            ulong dateTime = BitConverter.ToUInt64(bytes, 8);

            UtilityIID.GetDateTypeFromUlong(dateTime, out E_IID_DATE_TYPE type, out long timeInMicroSeconds);
            iid.SetIndex(index);
            iid.SetValue(value);
            iid.SetTimeType(type, timeInMicroSeconds);
        }
    }

}
