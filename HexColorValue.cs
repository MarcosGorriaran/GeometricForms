

namespace GeometricForms
{
    public class HexColorValue
    {
        private const string WrongHexSize = "El string con el hex debe tener una longitud de 6";
        private const int UTFAword = 41;
        private const int UTFFword = 46;
        private const int UTFZeroWord = 30;
        private const int UTFNineWord = 39;
        public const int HexStringLimitSize = 6;
        private string hexString;

        public HexColorValue()
        {

        }

        public string HexString
        {
            get { return this.hexString;}
            set
            {
                if (value.Length != HexStringLimitSize)
                {
                    throw new Exception(WrongHexSize);
                }
                for(int i = 0; i < UTFAWord; i++) { }
                this.hexString = value;
            }
        }
    }
}
