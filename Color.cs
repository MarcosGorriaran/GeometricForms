using System.Security.Cryptography.X509Certificates;

namespace GeometricForms
{
    public class Color
    {
        
       
        private const string WrongHexSize = "El string con el hex debe tener una longitud de 6";
        private int RedValue;
        private int GreenValue;
        private int BlueValue;

        public Color(string hexValue)
        {

        }
        public int SetRGBWithHex(string hexValue)
        {
            
            hexValue = hexValue.ToUpper();

            
        }
    }
}
