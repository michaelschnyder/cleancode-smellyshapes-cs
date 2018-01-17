namespace SmellyShapes.Source
{
    public class ShapeGroup : ComplexShape
    {
        public IShape[] shapes = new IShape[10];
        
        public int size = 0;

        public ShapeGroup() { }

        public ShapeGroup(IShape[] shapes, bool readOnly)
        {
            this.shapes = shapes;
            this.size = shapes.Length;
            this.ReadOnly = readOnly;
        }

        public void Add(IShape shape)
        {
            if (!this.ReadOnly)
            {
                int newSize = this.size + 1;
                if (newSize > this.shapes.Length)
                {
                    IShape[] newShapes = new IShape[this.shapes.Length + 10];
                    for (int i = 0; i < this.size; i++)
                    {
                        newShapes[i] = this.shapes[i];
                    }
                    this.shapes = newShapes;
                }

                if (this.Contains(shape))
                {
                    return;
                }
                this.shapes[this.size++] = shape;
            }
        }

        public bool Contains(IShape shape)
        {
            for (int i = 0; i < this.size; i++)
            {
                if (this.shapes[i].Equals(shape))
                {
                    return true;
                }
            }
            return false;
        }

        public override bool Contains(int x, int y)
        {
            foreach (IShape shape in this.shapes)
            {
                if (shape != null)
                {
                    if (shape.Contains(x, y))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
