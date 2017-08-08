using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertTool_FilenameToLatLon.PicNumModel.model
{
    /// <summary>
    /// 地形图编号模型，如J50C003003。此编号由1:100万行号、1:100万列号、比例尺代码、图幅行号数字码、图幅列号数字码，5个部分组成。
    /// 将此编号拆分存入上述5个变量内，方便计算对应的经纬度。
    /// </summary>
    public class PictureNumberModel
    {
        #region 变量
        private string fileName;//文件名
        private string lineNumber_100;//1:100万行号
        private string columnNumber_100;//1:100万列号
        private string scaleCode;//比例尺代码
        private string picLineNumber;//图幅行号数字码
        private string picColumnNumber;//图幅列号数字码

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        public string LineNumber_100
        {
            get { return lineNumber_100; }
            set { lineNumber_100 = value; }
        }

        public string ColumnNumber_100
        {
            get { return columnNumber_100; }
            set { columnNumber_100 = value; }
        }

        public string ScaleCode
        {
            get { return scaleCode; }
            set { scaleCode = value; }
        }

        public string PicLineNumber
        {
            get { return picLineNumber; }
            set { picLineNumber = value; }
        }

        public string PicColumnNumber
        {
            get { return picColumnNumber; }
            set { picColumnNumber = value; }
        }

        #endregion

        #region 方法
        /// <summary>
        /// 根据文件名得到地形图编号的5个变量值
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static PictureNumberModel getPicNumberModel(FileNameModel filename)
        {
            PictureNumberModel picturenumbermodel = new PictureNumberModel();
            try
            {
                picturenumbermodel.FileName = filename.FullFileName;//文件名
                picturenumbermodel.LineNumber_100 = filename.PictureNumFileName.Substring(0, 1);//1：100万行号
                picturenumbermodel.ColumnNumber_100 = filename.PictureNumFileName.Substring(1, 2);//1:100万列号
                picturenumbermodel.ScaleCode = filename.PictureNumFileName.Substring(3, 1);//比例尺代码
                picturenumbermodel.PicLineNumber = filename.PictureNumFileName.Substring(4, 3);//图幅行号数字码
                picturenumbermodel.PicColumnNumber = filename.PictureNumFileName.Substring(7, 3);//图幅号数字码

            }
            catch (System.Exception ex)
            {

            }
            return picturenumbermodel;
        }


        #endregion

    }
}
