namespace GeometricForms
{
    public abstract class GeometricForm
    {
        private Color color;
        private int edges;
        private int[] edgesLength;

        public GeometricForm(Color color, int edges, params int[]edgesLength)
        {
            
        }
        public Color Color
        {
            get => color;
            set => color = value;
        }
        public int Edges
        {
            get => edges;
            set => edges = value;
        }
        public int[] EdgesLength
        {
            get => edgesLength;
        }
    }
}
