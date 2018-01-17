namespace SmellyShapes.Source
{
    public class Circle : SimpleShape
    {
        private readonly int x;
        private readonly int y;
        private readonly int radius;
        private int numberOfContainingPoints;
        private Color color = new Color("Green");

        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override bool Contains(int x, int y)
        {
            bool result = (x - this.x) * (x - this.x) + (y - this.y) * (y - this.y) <= this.radius * this.radius;
            // Increase number of Points?
            if (result == true)
            {
                this.numberOfContainingPoints++;
            }
            return result;
        }

        public int CountContainingPoints(int[] xCords, int[] yCords)
        {
            this.numberOfContainingPoints = 0;
            for (int i = 0; i < xCords.Length; ++i)
            {
                this.Contains(xCords[i], yCords[i]);
            }
            return this.numberOfContainingPoints;
        }

        /// <summary>
        ///  This method returns the shape color.
        /// </summary>
        /// <returns>the shape color</returns>
        public Color GetColor()
        {
            return this.color;
        }

        /// <summary>
        /// Sets the shape color
        /// </summary>
        /// <param name="color">color the new color of the shape</param>
        public void SetColor(Color color)
        {
            this.color = color;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public int GetRadius()
        {
            return this.radius;
        }

        public override string ToString()
        {
            return "Circle: (" + this.x + "," + this.y + ") radius= " + this.radius
                   + " RGB=" + this.color.GetColorAsRGBRed() + ","
                   + this.color.GetColorAsRGBGreen() + ","
                   + this.color.GetColorAsRGBBlue();
        }
    }
}
