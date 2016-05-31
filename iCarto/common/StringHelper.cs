using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************************     
     * Created by  Yao  on  5/31/2016 12:39:33 PM     
     * README:字符串操作工具类
     * ============================================================================
     * CHANGELOG：
    ********************************************************************************/
namespace icarto.common
{
    public class StringHelper
    {


        /// <summary>
        /// 利用空格替换获取剩余字符串
        /// </summary>
        /// <param name="strWholeString"></param>
        /// <param name="strUselessPart"></param>
        /// <returns></returns>
        public string getRestStrings(string strWholeString, string strUselessPart)
        {
            string wholeString = strWholeString;
            string uselessPart = strUselessPart;
            string restString = "";
            restString = wholeString.Replace(strUselessPart, "");
            return restString;
        }


    }
}