using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************************     
     * Created by  Yao  on  5/31/2016 12:29:19 PM     
     * README:
     * ============================================================================
     * CHANGELOG：
    ********************************************************************************/
namespace EngineConsoleApplication.tests
{
    public class StringSplit
    {

        public void getRestStrings(string strUselessPart) {
            string testName = "usrLabl";
            testName = testName.Replace(strUselessPart, "");
            Console.WriteLine(testName);
        
        }

    }
}