using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertTool_FilenameToLatLon.PicNumModel.model
{
    /// <summary>
    /// 表示根据比例尺代码，确定的小矩形。1:100万的大矩形被这些小矩形划分。
    /// </summary>
    public class SmallRectangleInfoModel
    {
        private int number;//1:100万大矩形里小矩形的个数
        private double longitudeDistance;//小矩形的经度差
        private double latitudeDistance;//小矩形的纬度差

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public double LongitudeDistance
        {
            get { return longitudeDistance; }
            set { longitudeDistance = value; }
        }

        public double LatitudeDistance
        {
            get { return latitudeDistance; }
            set { latitudeDistance = value; }
        }

    }
}
