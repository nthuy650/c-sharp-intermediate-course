namespace Inheritance
{
    public class RepresentationObject
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object was copied to clipboard");
        }
    }
}
