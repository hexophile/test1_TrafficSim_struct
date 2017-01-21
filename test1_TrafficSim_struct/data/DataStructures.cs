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
    /// Direction of the lane structur, 0 for right and 1 for left
    /// </summary>
    public enum Direction
    {
        Forward,
        Backward
    }

    public struct AreaData
    {
        /// or xml?
    }
}