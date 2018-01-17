using System;

namespace SmellyShapes.Source
{
    public class Square : Rectangle
    {

        public Square(int x, int y, int edgeLength)
            : base(x, y, edgeLength, edgeLength)
        {
        }

        public Square(int x, int y, int edgeLength, Color color)
            : base(x, y, edgeLength, edgeLength)
        {
            this.c = color;
        }

        public bool ContainsPoint(int x, int y)
        {
            return this.GetX() <= x && x <= this.GetX() + this.GetWidth() && this.GetY() <= y && y <= this.GetY() + this.GetWidth();
        }

        public override int GetHeight() 
        {
            throw new InvalidOperationException("Square does not have a height, only edgeLength");
        }

        public override string ToString()
        {
            return String.Format("Square: ({0}:{1}) edgeLength={2} color={3}",
                this.GetX(), this.GetY(), this.GetWidth(), this.c.GetColorAsHex());
        }

        public bool Contains(int x1, int y1, int x2, int y2)
        {
            return this.Contains(x1, y1) && this.Contains(x2, y2);
        }
    }
}
