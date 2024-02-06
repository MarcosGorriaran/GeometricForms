

namespace GeometricForms
{
    public class HexColorValue
    {
        private const string WrongHex = "El string proporcionado no se identifica como un hex de color RGB";
        private const int UTFAword = 41;
        private const int UTFFword = 46;
        private const int UTFZeroWord = 30;
        private const int UTFNineWord = 39;
        public const int HexStringLimitSize = 6;
        public const int IndividualColorSize = 2;
        public const int RedPosition = 2;
        public const int GreenPosition = 4;
        public const int BluePosition = 6;
        public const int HexadecimalValues = 16;
        private string hexString;

        public HexColorValue(string hexString)
        {
            HexString = hexString;
        }

        public string HexString
        {
            get { return this.hexString;}
            set
            {
                if (!ValidateHex(value)){
                    throw new Exception(WrongHex);
                }
                hexString = value;
            }
        }
        public int GetRedRGBCode()
        {
            string redHex = this.HexString.Substring(RedPosition-IndividualColorSize,RedPosition);
            return Convert.ToInt32(redHex, HexadecimalValues);
        }
        public int GetGreenRGBCode()
        {
            string blueHex = this.HexString.Substring(GreenPosition - IndividualColorSize, GreenPosition);
            return Convert.ToInt32(blueHex, HexadecimalValues);
        }
        public int GetBlueRGBCode()
        {
            string greenHex = this.HexString.Substring(BluePosition - IndividualColorSize, BluePosition);
            return Convert.ToInt32(greenHex, HexadecimalValues);
        }
        public static bool ValidateHex(string hex)
        {
            hex = hex.ToUpper();
            if (hex.Length != HexStringLimitSize) return false;

            for(int i = 0; i< hex.Length; i++)
            {
                if (IsCharAHexValue(hex[i])) return true;
            }
            return false;
            
        }
        public static bool IsCharAHexValue(char hexChar)
        {
            int utfCharCode = Convert.ToInt32(hexChar);
            return utfCharCode >= UTFZeroWord || utfCharCode <= UTFNineWord || utfCharCode >= UTFAword || utfCharCode <= UTFFword;
        }
    }
}
