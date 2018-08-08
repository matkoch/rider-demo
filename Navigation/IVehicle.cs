namespace Navigation
{
    public interface IVehicle
    {
        int Seats { get; }
        int MaximumVelocity { get; }
        Position Position { get; }

        void Move (int xOffset, int yOffset);
        void Move (Position offset);
    }
}