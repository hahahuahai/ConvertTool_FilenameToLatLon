using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertTool_FilenameToLatLon.PicNumModel.model
{
    /// <summary>
    /// 1:100万条件下的经纬度四至范围模型。（作为临时存储）
    /// </summary>
    public class LatitudeLongitude_100_maxminModel
    {
        private string filename;//文件名
        private double fileLatitudeMax_100;//1:100万条件下的最大纬度
        private double fileLatitudeMin_100;//1:100万条件下的最小纬度
        private double fileLongitudeMax_100;//1:100万条件下的最大经度
        private double fileLongitudeMin_100;//1:100万条件下的最小经度

        public string Filename
        {
            get { return filename; }
            set { filename = value; }
        }
        public double FileLatitudeMax_100
        {
            get { return fileLatitudeMax_100; }
            set { fileLatitudeMax_100 = value; }
        }

        public double FileLatitudeMin_100
        {
            get { return fileLatitudeMin_100; }
            set { fileLatitudeMin_100 = value; }
        }

        public double FileLongitudeMax_100
        {
            get { return fileLongitudeMax_100; }
            set { fileLongitudeMax_100 = value; }
        }
 
        public double FileLongitudeMin_100
        {
            get { return fileLongitudeMin_100; }
            set { fileLongitudeMin_100 = value; }
        }


    }
}
