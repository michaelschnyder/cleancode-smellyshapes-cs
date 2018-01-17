namespace SmellyShapes.Source
{
    public interface IShape 
    {
        bool Contains(int x, int y);

        string ToXml();
    }
}
