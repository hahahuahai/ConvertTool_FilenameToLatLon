using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertTool_FilenameToLatLon.PicNumModel.model
{
    /// <summary>
    /// 此模型用于存储文件的全名和用于获取图幅信息的图幅号。针对的是类似于H50E001021-Z320131119.tif这类文件名称不是纯粹的图幅号。需要把后面多余的截去之后才能使用。
    /// </summary>
    public class FileNameModel
    {
        private string fullFileName;//文件名全称
        private string pictureNumFileName;//文件名中提取出来的图幅号

        public string FullFileName
        {
            get { return fullFileName; }
            set { fullFileName = value; }
        }
        public string PictureNumFileName
        {
            get { return pictureNumFileName; }
            set { pictureNumFileName = value; }
        }

    }
}
