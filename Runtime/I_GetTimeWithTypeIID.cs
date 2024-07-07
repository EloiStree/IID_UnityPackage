namespace IIDToolbox
{
    public interface I_GetTimeWithTypeIID : I_STRUCT_IID_TICK_GET
    {
        public void GetTimeType(out E_IID_DATE_TYPE type);
        public E_IID_DATE_TYPE GetTimeType();
    }
}