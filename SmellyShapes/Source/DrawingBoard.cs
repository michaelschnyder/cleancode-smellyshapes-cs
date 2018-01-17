namespace SmellyShapes.Source
{
    using System;

    public class DrawingBoard : ShapeGroup
    {
        /// <summary>
        /// Use NO_DATE to indicate that no date is set (the equivalent of 'null Date' in Java)
        /// </summary>
        public static readonly DateTime NO_DATE = DateTime.MaxValue;

        private Color backgroundColor;

        public Color GetBackgroundColor()
        {
            return this.backgroundColor;
        }

        public void SetBackgroundColor(Color backgroundColor)
        {
            this.backgroundColor = backgroundColor;
        }

        public void DrawOnScreen()
        {
            var previousStart = NO_DATE;
            var thisStart = DateTime.Now;
            Console.WriteLine("Started last time: " + previousStart);

            // ... removed for exercise
        }

        public void Load(string file)
        {
            // ... removed for exercise
        }

        public static void Main(string[] args)
        {
            DrawingBoard drawingBoard = new DrawingBoard();
            drawingBoard.SetBackgroundColor(new Color("Green"));
            drawingBoard.Add(new Square(-10, -10, 20));
            drawingBoard.Load(args[0]);
            drawingBoard.DrawOnScreen();
        }
    }
}
