namespace IIDToolbox
{
    public interface I_GetIntegerDateWithType : I_GetTimeWithTypeIID
    {
        public void GetValue(out int value);
        public void GetType(out E_IID_DATE_TYPE dateType);
    }
}