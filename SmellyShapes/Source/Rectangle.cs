namespace SmellyShapes.Source
{
    public class Rectangle : SimpleShape {

        protected Color c = new Color("Blue");
        private int x;
        private int y;
        int width;
        int height;

        public Rectangle(int x, int y, int width, int height) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public int GetWidth() {
            return this.width;
        }

        public virtual int GetHeight() {
            return this.height;
        }

        public override bool Contains(int x, int y) {
            return this.x <= x && x <= this.x + this.width && this.y <= y && y <= this.y + this.height;
        }

        public int Calculate() {
            return this.width*this.height;
        }

        public int GetX() {
            return this.x;
        }

        public int GetY() {
            return this.y;
        }

        public override string ToString() {
            return string.Format("Rectangle: ({0}) width={1} height={2} color={3}", this.x, this.y, this.width, this.height,
                this.c.GetColorAsHex());
        }
    }
}
