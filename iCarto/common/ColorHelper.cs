using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************************     
     * Created by  Yao  on  5/30/2016 8:21:27 PM     
     * README:颜色操作工具类
     * ============================================================================
     * CHANGELOG：
    ********************************************************************************/
namespace icarto.common
{
    public class ColorHelper
    {


        public Color getColorByEnum(ColorPalatte colorp)
        {
            Color someColor;
            someColor = this.hexToColor((int)colorp);
            return someColor;

        }



        /// <summary>
        /// 16进制色值转Color.
        /// </summary>
        /// <returns></returns>
        public Color hexToColor(int argb)
        {
            //通过按位&清零干扰位，取出需要位，右移一位相当于/2
            return Color.FromArgb(
                (argb & 0xff0000) >> 16,
                (argb & 0xff00) >> 8,
                 argb & 0xff);
        }


    }
}