namespace dotnet_six_csharp
{
    public class FormatTest
    {
        int _size;
        int _decimals;
        char _dataType;

        public FormatTest(int size, int decimals, char dataType)
        {
            _size = size;
            _decimals = decimals;
            _dataType = dataType;
        }

        public string Format(object valueData)
        {
            string ret = "";

            if (_dataType == 'N')
            {
                if (_decimals > 0)
                {
                    var n = decimal.Parse(valueData.ToString());
                    string fmt = "".PadLeft(_size - _decimals, '0') + "." +
                        "".PadLeft(_decimals, '#');
                    ret = n.ToString(fmt).Replace(",", "").Replace(".", "");
                }
                else
                {
                    var n = int.Parse(valueData.ToString());
                    string fmt = "".PadLeft(_size, '0');
                    ret = n.ToString(fmt);
                }
            }

            return ret;
        }
    }
}