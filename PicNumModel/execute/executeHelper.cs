using ConvertTool_FilenameToLatLon.PicNumModel.folder;
using ConvertTool_FilenameToLatLon.PicNumModel.model;
using ConvertTool_FilenameToLatLon.PicNumModel.txt;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ConvertTool_FilenameToLatLon.PicNumModel.execute
{
    public class executeHelper
    {
        /// <summary>
        /// 执行程序
        /// </summary>
        /// <param name="InputFolderPath"></param>
        public static void executeMethod(string InputFolderPath, string OutputFolderPath)
        {
            try
            {
                List<string> list_FileName = new List<string>();
                List<PictureNumberModel> list_PictureNumberModel = new List<PictureNumberModel>();
                List<LatitudeLongitude_Final_maxminModel> list_LatitudeLongitude_Final_maxminModel = new List<LatitudeLongitude_Final_maxminModel>();

                list_FileName = getAllFileName(InputFolderPath);//得到所有文件名
                list_PictureNumberModel = getAllPictureNumber(list_FileName);//得到所有文件名的图幅号5个参数
                list_LatitudeLongitude_Final_maxminModel = getAllLatitudeLongitude_Final(list_PictureNumberModel);//得到最终结果
                //npoiHelper.CreateExcel(OutputFolderPath, list_LatitudeLongitude_Final_maxminModel);//输出到Excel
                txtHelper.txtExecute(OutputFolderPath, list_LatitudeLongitude_Final_maxminModel);//输出到TXT文件
            }
            catch (System.Exception ex)
            {

            }

        }

        /// <summary>
        /// 得到文件夹下的所有文件名
        /// </summary>
        /// <param name="FolderPath"></param>
        public static List<string> getAllFileName(string FolderPath)
        {
            List<string> list_FileName = new List<string>();
            try
            {

                list_FileName = folderHelper.getFilename(FolderPath);

            }
            catch (System.Exception ex)
            {

            }
            return list_FileName;

        }

        /// <summary>
        /// 分解所有文件名，得到图幅号的5个参数
        /// </summary>
        /// <param name="list_FileName"></param>
        /// <returns></returns>
        public static List<PictureNumberModel> getAllPictureNumber(List<string> list_FileName)
        {
            List<PictureNumberModel> list_picturenumbermodel = new List<PictureNumberModel>();
            try
            {

                PictureNumberModel picturenumbermodel = new PictureNumberModel();
                foreach (string FileName in list_FileName)
                {
                    picturenumbermodel = PictureNumberModel.getPicNumberModel(FileName);
                    list_picturenumbermodel.Add(picturenumbermodel);
                }

            }
            catch (System.Exception ex)
            {

            }
            return list_picturenumbermodel;

        }

        /// <summary>
        /// 得到所有文件名的最终的经纬度，根据图幅号的5个参数。
        /// </summary>
        /// <param name="list_PictureNumberModel"></param>
        /// <returns></returns>
        public static List<LatitudeLongitude_Final_maxminModel> getAllLatitudeLongitude_Final(List<PictureNumberModel> list_PictureNumberModel)
        {
            List<LatitudeLongitude_Final_maxminModel> list_LatitudeLongitude_Final_maxminModel = new List<LatitudeLongitude_Final_maxminModel>();

            try
            {
                LatitudeLongitude_Final_maxminModel latitudeLongitude_Final_maxminModel;
                foreach (PictureNumberModel pictureNumberModel in list_PictureNumberModel)
                {
                    latitudeLongitude_Final_maxminModel = new LatitudeLongitude_Final_maxminModel();
                    latitudeLongitude_Final_maxminModel = getSingleLatitudeLongitude_Final(pictureNumberModel);
                    list_LatitudeLongitude_Final_maxminModel.Add(latitudeLongitude_Final_maxminModel);
                }

            }
            catch (System.Exception ex)
            {

            }
            return list_LatitudeLongitude_Final_maxminModel;

        }

        /// <summary>
        /// 得到单个文件名的最终的经纬度，根据图幅号的5个参数。
        /// </summary>
        /// <param name="PictureNumberModel"></param>
        /// <returns></returns>
        public static LatitudeLongitude_Final_maxminModel getSingleLatitudeLongitude_Final(PictureNumberModel PictureNumberModel)
        {
            LatitudeLongitude_Final_maxminModel latitudeLongitude_Final_maxminModel = new LatitudeLongitude_Final_maxminModel();

            try
            {
                LatitudeLongitude_100_maxminModel latitudeLongitude_100_maxminModel = new LatitudeLongitude_100_maxminModel();
                SmallRectangleInfoModel smallRectangleInfoModel = new SmallRectangleInfoModel();
                //步骤一：得到1:100万下的经纬度坐标
                latitudeLongitude_100_maxminModel = getLatitudeLongitude_100(PictureNumberModel.LineNumber_100, PictureNumberModel.ColumnNumber_100);
                //步骤二：得到小矩形基本信息
                smallRectangleInfoModel = getSmallRectangleInfo(PictureNumberModel.ScaleCode);
                //步骤三：得到最终比例尺下的经纬度坐标
                latitudeLongitude_Final_maxminModel = getLatitudeLongitude_Final(latitudeLongitude_100_maxminModel, smallRectangleInfoModel, PictureNumberModel.PicLineNumber, PictureNumberModel.PicColumnNumber, PictureNumberModel.FileName);


            }
            catch (System.Exception ex)
            {

            }
            return latitudeLongitude_Final_maxminModel;


        }


        #region 图幅号转经纬度的核心算法

        /// <summary>
        /// 得到单个文件名的1:100万下的经纬度，根据1:100万行号和1:100万列号这两个参数。【核心算法，步骤一】
        /// </summary>
        /// <param name="LineNumber_100"></param>
        /// <param name="ColumnNumber_100"></param>
        /// <returns></returns>
        public static LatitudeLongitude_100_maxminModel getLatitudeLongitude_100(string LineNumber_100, string ColumnNumber_100)
        {
            LatitudeLongitude_100_maxminModel latitudeLongitude_100_maxminModel = new LatitudeLongitude_100_maxminModel();
            try
            {

                //判断LineNumber_100的值是H还是I。因为江苏省的纬度范围是30°45′N-35°20′N，H表示28°N-32°N，I表示32°N-36°N。
                if (string.Compare(LineNumber_100, "H") == 0)//等于H
                {
                    latitudeLongitude_100_maxminModel.FileLatitudeMax_100 = 32;
                    latitudeLongitude_100_maxminModel.FileLatitudeMin_100 = 28;
                }
                else if (string.Compare(LineNumber_100, "I") == 0)//等于I
                {
                    latitudeLongitude_100_maxminModel.FileLatitudeMax_100 = 36;
                    latitudeLongitude_100_maxminModel.FileLatitudeMin_100 = 32;
                }
                else
                {
                    MessageBox.Show("1:100万行号有问题！非江苏省！", "提示");
                    return null;
                }
                //判断ColumnNumber_100的值是50还是51.因为江苏省的经度范围是116°18′E-121°57′，50表示114°E-120°E，51表示120°E-126°E。
                if (string.Compare(ColumnNumber_100, "50") == 0)//等于50
                {
                    latitudeLongitude_100_maxminModel.FileLongitudeMax_100 = 120;
                    latitudeLongitude_100_maxminModel.FileLongitudeMin_100 = 114;
                }
                else if (string.Compare(ColumnNumber_100, "51") == 0)//等于51
                {
                    latitudeLongitude_100_maxminModel.FileLongitudeMax_100 = 126;
                    latitudeLongitude_100_maxminModel.FileLongitudeMin_100 = 120;
                }
                else
                {
                    MessageBox.Show("1:100万列号有问题！非江苏省！", "提示");
                    return null;
                }

            }
            catch (System.Exception ex)
            {

            }
            return latitudeLongitude_100_maxminModel;
        }

        /// <summary>
        /// 得到1幅实际比例尺下的图幅信息，根据比例尺代码。【核心算法，步骤二】
        /// </summary>
        /// <param name="scaleCode"></param>
        /// <returns></returns>
        public static SmallRectangleInfoModel getSmallRectangleInfo(string scaleCode)
        {
            SmallRectangleInfoModel smallRectangleInfoModel = new SmallRectangleInfoModel();
            try
            {

                switch (scaleCode)
                {
                    case "B":
                        smallRectangleInfoModel.Number = 2; break;
                    case "C":
                        smallRectangleInfoModel.Number = 4; break;
                    case "D":
                        smallRectangleInfoModel.Number = 12; break;
                    case "E":
                        smallRectangleInfoModel.Number = 24; break;
                    case "F":
                        smallRectangleInfoModel.Number = 48; break;
                    case "G":
                        smallRectangleInfoModel.Number = 96; break;
                    case "H":
                        smallRectangleInfoModel.Number = 192; break;
                    default:
                        MessageBox.Show("比例尺代码有问题！", "提示");
                        return null;
                }
                smallRectangleInfoModel.LatitudeDistance = 4.0 / smallRectangleInfoModel.Number;
                smallRectangleInfoModel.LongitudeDistance = 6.0 / smallRectangleInfoModel.Number;


            }
            catch (System.Exception ex)
            {

            }
            return smallRectangleInfoModel;

        }

        /// <summary>
        /// 得到最终比例尺下的经纬度信息，根据步骤一和二求得的结果。【核心算法，步骤三】
        /// </summary>
        /// <param name="latitudeLongitude_100_maxminModel"></param>
        /// <param name="smallRectangleInfoModel"></param>
        /// <param name="picLineNumber">图幅行号数字码</param>
        /// <param name="picColumnNumber">图幅列号数字码</param>
        public static LatitudeLongitude_Final_maxminModel getLatitudeLongitude_Final(LatitudeLongitude_100_maxminModel latitudeLongitude_100_maxminModel, SmallRectangleInfoModel smallRectangleInfoModel, string picLineNumber, string picColumnNumber, string fileName)
        {
            LatitudeLongitude_Final_maxminModel latitudeLongitude_Final_maxminModel = new LatitudeLongitude_Final_maxminModel();
            try
            {


                double picLineNumber_double = double.Parse(picLineNumber);
                double picColumnNumber_double = double.Parse(picColumnNumber);
                //得到实际比例尺下的经纬度四至范围
                latitudeLongitude_Final_maxminModel.FileLatitudeMax_Final = latitudeLongitude_100_maxminModel.FileLatitudeMax_100 - smallRectangleInfoModel.LatitudeDistance * (picLineNumber_double - 1);
                latitudeLongitude_Final_maxminModel.FileLatitudeMin_Final = latitudeLongitude_Final_maxminModel.FileLatitudeMax_Final - smallRectangleInfoModel.LatitudeDistance;
                latitudeLongitude_Final_maxminModel.FileLongitudeMin_Final = latitudeLongitude_100_maxminModel.FileLongitudeMin_100 + smallRectangleInfoModel.LongitudeDistance * (picLineNumber_double - 1);
                latitudeLongitude_Final_maxminModel.FileLongitudeMax_Final = latitudeLongitude_Final_maxminModel.FileLongitudeMin_Final + smallRectangleInfoModel.LongitudeDistance;
                latitudeLongitude_Final_maxminModel.FileName = fileName;

            }
            catch (System.Exception ex)
            {

            }
            return latitudeLongitude_Final_maxminModel;

        }
        #endregion

    }
}
