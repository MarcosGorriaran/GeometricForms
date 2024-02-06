using System.Security.Cryptography.X509Certificates;

namespace GeometricForms
{
    public class Color
    {

        private const string WrongRedValue = "El valor proporcionado en rojo es erroneo, el valor proporcionado es: ";
        private const string WrongGreenValue = "El valor proporcionado en verde es erroneo, el valor proporcionado es: ";
        private const string WrongBlueValue = "El valor proporcionado en azul es erroneo, el valor proporcionado es: ";
        private const int MinDecimalValue = 0;
        private const int MaxDecimalValue = 255;
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
            set
            {
                if (!IsValueRGBCode(value))
                {
                    throw new Exception(WrongRedValue+value);
                }
                redValue = value;
            }
        }
        public int GreenValue
        {
            get => greenValue;
            set
            {
                if (!IsValueRGBCode(value))
                {
                    throw new Exception(WrongGreenValue+value);
                }
                greenValue = value;
            }
        }
        public int BlueValue
        {
            get => blueValue;
            set 
            {
                if (!IsValueRGBCode(value))
                {
                    throw new Exception(WrongBlueValue+value);
                }
                blueValue = value;
            }
        }
        public void SetRGBWithHex(HexColorValue hexValue)
        {
            RedValue = hexValue.GetRedRGBCode();
            GreenValue = hexValue.GetGreenRGBCode();
            BlueValue = hexValue.GetBlueRGBCode();
        }
        public HexColorValue GetHexValue()
        {
            string redHex = RedValue.ToString("X");
            if(redHex.Length < 2)
            {
                redHex = "0" + redHex;
            }
            string greenHex = GreenValue.ToString("X");
            if(greenHex.Length < 2)
            {
                greenHex = "0" + greenHex;
            }
            string blueHex = BlueValue.ToString("X");
            if(blueHex.Length < 2)
            {
                blueHex = "0" + blueHex;
            }
            return new HexColorValue(redHex+greenHex+blueHex);
        }
        public static bool IsValueRGBCode (int code)
        {
            return code >=MinDecimalValue && code <=MaxDecimalValue;
        }
        public override string ToString()
        {
            return $"{RedValue}, {GreenValue}, {BlueValue}";
        }
    }
}
