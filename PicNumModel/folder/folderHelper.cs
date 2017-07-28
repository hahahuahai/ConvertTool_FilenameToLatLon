using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConvertTool_FilenameToLatLon.PicNumModel.folder
{
    public class folderHelper
    {
        /// <summary>
        /// 根据文件夹路径得到下面所有文件名
        /// </summary>
        /// <param name="FolderPath"></param>
        /// <returns></returns>
        public static List<string> getFilename(string FolderPath)
        {
            List<string> list_FileName = new List<string>();
            try
            {
                string FileName = "";
                DirectoryInfo dir = new System.IO.DirectoryInfo(FolderPath);
                if (dir.Exists)
                {
                    FileInfo[] fileList = dir.GetFiles();
                    foreach (var item in fileList)
                    {
                        FileName = Path.GetFileNameWithoutExtension(item.Name);
                        list_FileName.Add(FileName);
                    }
                }
            }
            catch (System.Exception ex)
            {

            }
            return list_FileName;
        }


    }
}
