using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BatStore.Extention
{
    public static class Extention
    {
        public static string ToVND(this double donGia)
        {
            return donGia.ToString("#,##0") + " VND";
        }
        public static string ToTitleCase(string str)
        {
            string result = str;
            if(!string.IsNullOrEmpty(str))
            {
                var words = str.Split(' ');
                for(int i = 0; i <words.Length; i++)
                {
                    var s = words[i];
                    if(s.Length>0)
                    {
                        words[i] = s[0].ToString().ToUpper() + s.Substring(1);
                    }
                }
                result = string.Join(" ", words);
            }
            return result;
        }
        public static string ToEasyUrl(this string url)
        {
            var result = url.ToLower().Trim();
            result = Regex.Replace(result, "aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬ", "a");
            result = Regex.Replace(result, "dDđĐ", "d");
            result = Regex.Replace(result, "eEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆ", "e");
            result = Regex.Replace(result, "iIìÌỉỈĩĨíÍịỊ", "i");
            result = Regex.Replace(result, "oOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢ", "o");
            result = Regex.Replace(result, " UùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰ", "u");
            result = Regex.Replace(result, "YỳỲỷỶỹỸýÝỵỴ", "y");
            result = Regex.Replace(result, "[^a-z0-9]", " ");
            result = Regex.Replace(result, "(-)+", "-");
            return result;
        }
    }
}
