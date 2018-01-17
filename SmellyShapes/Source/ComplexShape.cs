namespace SmellyShapes.Source
{
    public abstract class ComplexShape : AbstractShape
    {
        protected bool ReadOnly = false;

        public void SetReadOnly(bool readOnly)
        {
            this.ReadOnly = readOnly;
        }
    }
}
