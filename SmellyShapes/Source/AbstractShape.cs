using System.Text;

namespace SmellyShapes.Source
{
    using System;

    public abstract class AbstractShape : IShape
    {
        public abstract bool Contains(int x, int y);

        public string ToXml()
        {
            StringBuilder builder = new StringBuilder();
            if (this is Circle)
            {
                Circle circle = (Circle)this;
                builder.Append("<circle");
                builder.Append(" x=\"" + circle.GetX() + "\"");
                builder.Append(" y=\"" + circle.GetY() + "\"");
                builder.Append(" radius=\"" + circle.GetRadius() + "\"");
                builder.Append(" />\n");
            }
            else if (this is Square)
            {
                Square square = (Square)this;
                builder.Append("<square");
                builder.Append(" x=\"" + square.GetX() + "\"");
                builder.Append(" y=\"" + square.GetY() + "\"");
                builder.Append(" edgeLength=\"" + square.GetWidth() + "\"");
                builder.Append(" />\n");
            }
            else if (this is Rectangle)
            {
                Rectangle rectangle = (Rectangle)this;
                builder.Append("<rectangle");
                builder.Append(" x=\"" + rectangle.GetX() + "\"");
                builder.Append(" y=\"" + rectangle.GetY() + "\"");
                builder.Append(" width=\"" + rectangle.GetWidth() + "\"");
                builder.Append(" height=\"" + rectangle.GetHeight() + "\"");
                builder.Append(" />\n");
            }
            else if (this is ShapeGroup)
            {
                ShapeGroup group = (ShapeGroup)this;
                builder.Append("<shapegroup>\n");
                for (int i = 0; i < group.size; i++)
                {
                    builder.Append(group.shapes[i].ToXml());
                }
                builder.Append("</shapegroup>\n");
            }
            else
            {
                throw new ArgumentException("Unknown shape type: " + this.GetType());
            }
            return builder.ToString();
        }
    }
}
