namespace IIDToolbox
{
    public interface I_GetIndexIntegerDateWithType : I_GetTimeWithTypeIID
    {
        public void GetIndex(out int index);
        public void GetValue(out int value);
    }
}