

namespace IIDToolbox
{
    public interface I_STRUCT_IID_TICK_GET
    {
        long GetTick();
    }
    public interface I_STRUCT_IID_TICK_SET
    {
        void SetWithTick(long tick);
    }

    public interface I_STRUCT_IID_TICK : I_STRUCT_IID_TICK_GET, I_STRUCT_IID_TICK_SET
    {
    }
}
