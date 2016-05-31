using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**********************************************************************************     
     * Created by  Yao  on  5/31/2016 3:49:36 PM     
     * README:界面交互工具类
     * ============================================================================
     * CHANGELOG：
    ********************************************************************************/
namespace icarto.common
{
    public class InteractiveHelper
    {
        public void toggleControlVisiable(Control c) {
            if (c.Visible)
            {
                c.Visible = false;
            }
            else
            {
                c.Visible = true;

            }
        }
    }
}