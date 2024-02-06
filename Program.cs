namespace GeometricForms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Color rgbColor = new Color(234, 221, 143);
            Color hexColor = new Color("eadc8f");
            Color hexObjectColor = new Color(new HexColorValue("eadc8f"));

            Console.WriteLine(rgbColor);
            Console.WriteLine(hexColor);
            Console.WriteLine(hexObjectColor);
            Console.WriteLine(hexColor.GetHexValue());
            Console.WriteLine(hexColor.GetHexValue().GetRGBColor());
        }
    }
}
