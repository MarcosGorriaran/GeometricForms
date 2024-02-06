using System.Security.Cryptography.X509Certificates;

namespace GeometricForms
{
    public class Color
    {
        
       
        private const string WrongHexSize = "El string con el hex debe tener una longitud de 6";
        private int redValue;
        private int greenValue;
        private int blueValue;

        public Color(int redValue, int greenValue, int blueValue)
        {
            RedValue = redValue;
            GreenValue = greenValue;
            BlueValue = blueValue;
        }
        public Color(HexColorValue hexValue)
        {
            SetRGBWithHex(hexValue);
        }
        public Color (string hexValue)
        {
            SetRGBWithHex(new HexColorValue(hexValue));
        }
        public int RedValue
        {
            get => redValue;
            set => redValue = value;
        }
        public int GreenValue
        {
            get => greenValue;
            set => greenValue = value;
        }
        public int BlueValue
        {
            get => greenValue;
            set => greenValue = value;
        }
        public void SetRGBWithHex(HexColorValue hexValue)
        {
            RedValue = hexValue.GetRedRGBCode();
            GreenValue = hexValue.GetGreenRGBCode();
            BlueValue = hexValue.GetGreenRGBCode();
        }
        public override string ToString()
        {
            return $"{RedValue}, {GreenValue}, {BlueValue}";
        }
    }
}
