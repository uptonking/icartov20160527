using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************************     
     * Created by  Yao  on  5/30/2016 4:51:12 PM     
     * README:存取文件路径工具类
     * ============================================================================
     * CHANGELOG：
    ********************************************************************************/
namespace icarto.common
{
    public  class FilePathHelper
    {

        /// <summary>
        /// 输入文件在项目中的相对路径，返回文件在系统中的绝对路径
        /// </summary>
        /// <param name="strFilePath">文件在项目中的相对路径</param>
        /// <returns>文件在系统中的绝对路径</returns>
        public   string getFileAbsolutePath(string strFilePath)
        {
            string filePath = strFilePath;
            string projectRootPath = System.Windows.Forms.Application.StartupPath + @"../../../";
            System.IO.Directory.SetCurrentDirectory(projectRootPath);
            string fileAbsolutePath = System.IO.Directory.GetCurrentDirectory() + filePath;
            //string fontAbsolutePath = System.IO.Directory.GetCurrentDirectory() + @"\res\fonts\SourceHanSansSC-Regular.ttf";
            return fileAbsolutePath;
        }


    }
}