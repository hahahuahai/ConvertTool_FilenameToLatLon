using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertTool_FilenameToLatLon.PicNumModel.model
{
    /// <summary>
    /// 实际比例尺条件下的经纬度四至范围，也是最后输出到Excel里面的结果模型
    /// </summary>
    public class LatitudeLongitude_Final_maxminModel
    {
        #region 字段
        private string fileName;//文件名
        private double fileLatitudeMax_Final;//文件最大的经度
        private double fileLatitudeMin_Final;//文件最小的经度
        private double fileLongitudeMax_Final;//文件最大的纬度
        private double fileLongitudeMin_Final;//文件最小的纬度

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public double FileLatitudeMax_Final
        {
            get { return fileLatitudeMax_Final; }
            set { fileLatitudeMax_Final = value; }
        }

        public double FileLatitudeMin_Final
        {
            get { return fileLatitudeMin_Final; }
            set { fileLatitudeMin_Final = value; }
        }

        public double FileLongitudeMax_Final
        {
            get { return fileLongitudeMax_Final; }
            set { fileLongitudeMax_Final = value; }
        }

        public double FileLongitudeMin_Final
        {
            get { return fileLongitudeMin_Final; }
            set { fileLongitudeMin_Final = value; }
        }
        #endregion


    }
}
