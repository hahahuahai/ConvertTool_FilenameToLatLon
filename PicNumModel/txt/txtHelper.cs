using ConvertTool_FilenameToLatLon.PicNumModel.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TXTClass;

namespace ConvertTool_FilenameToLatLon.PicNumModel.txt
{
    /// <summary>
    /// TXT文件相关的操作类
    /// </summary>
    public class txtHelper
    {
        public static void txtExecute(string FolderPath, List<LatitudeLongitude_Final_maxminModel> list_LatitudeLongitude_Final_maxminModel)
        {
            try
            {
                string txtPath = "";
                txtPath = createTXT(FolderPath);
                writeTXT(txtPath, list_LatitudeLongitude_Final_maxminModel);
            }
            catch (System.Exception ex)
            {

            }


        }

        /// <summary>
        /// 创建一个空的TXT文件
        /// </summary>
        /// <param name="FolderPath"></param>
        public static string createTXT(string FolderPath)
        {
            try
            {
                FileStream fs1 = new FileStream(FolderPath + "\\coordinateINFO.txt", FileMode.Create, FileAccess.Write);//创建写入文件 
                fs1.Close();
            }
            catch (System.Exception ex)
            {

            }
            return FolderPath + "\\coordinateINFO.txt";
        }

        /// <summary>
        /// 将坐标信息写入TXT文件
        /// </summary>
        /// <param name="txtPath"></param>
        /// <param name="list_LatitudeLongitude_Final_maxminModel"></param>
        public static void writeTXT(string txtPath, List<LatitudeLongitude_Final_maxminModel> list_LatitudeLongitude_Final_maxminModel)
        {
            try
            {
                txtclass txt = new txtclass();
                txt.txtWrite(txtPath, "文件名     最大经度     最小经度     最大纬度     最小纬度");
                foreach (LatitudeLongitude_Final_maxminModel latitudeLongitude_Final_maxminModel in list_LatitudeLongitude_Final_maxminModel)
                {
                    txt.txtWrite(txtPath, latitudeLongitude_Final_maxminModel.FileName + "     " + latitudeLongitude_Final_maxminModel.FileLongitudeMax_Final + "     " + latitudeLongitude_Final_maxminModel.FileLongitudeMin_Final + "     " + latitudeLongitude_Final_maxminModel.FileLatitudeMax_Final + "     " + latitudeLongitude_Final_maxminModel.FileLatitudeMin_Final);
                }
                MessageBox.Show("坐标信息文件生成成功！", "提示");
            }
            catch (System.Exception ex)
            {

            }

        }
    }
}
