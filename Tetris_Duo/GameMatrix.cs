public class GameMatrix
{
    static char[][] matrix;

    public GameMatrix(Position topLeftPivot, int width, int height)
    {
        this.Width = width;
        this.Height = height;

        this.TopLeftCorner = topLeftPivot;
        this.TopRightCorner = new Position(topLeftPivot.X + width, topLeftPivot.Y);
        this.BottomLeftCorner = new Position(topLeftPivot.X, topLeftPivot.Y + height);
        this.BottomRightCorner = new Position(topLeftPivot.X + width, topLeftPivot.Y + height);
    }

    public int Width { get; set; }

    public int Height { get; set; }

    public Position TopLeftCorner { get; set; }
    public Position TopRightCorner { get; set; }
    public Position BottomLeftCorner { get; set; }
    public Position BottomRightCorner { get; set; }
}
