namespace IIDToolbox
{
    public interface I_SetIntegerDateWithType : I_SetTimeWithTypeIID
    {
        public void SetValue(int value);
        public void SetType(E_IID_DATE_TYPE dateType);
    }
}