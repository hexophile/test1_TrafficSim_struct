using test1_TrafficSim_struct;

namespace test1_TrafficSim_struct.data
{
    /// <summary>
    /// Contains X and Y of geographical coordinates
    /// </summary>
    public struct Coordinates
    {
        float X;
        float Y;
    }

    /// <summary>
    /// Way of the lane structur, 0 for right and 1 for left
    /// </summary>
    public enum Way
    {
        Right,
        Left
    }

    public struct AreaData
    {
        /// or xml?
    }
}