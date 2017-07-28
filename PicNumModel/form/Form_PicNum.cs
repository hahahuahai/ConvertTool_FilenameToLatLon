using ConvertTool_FilenameToLatLon.PicNumModel.execute;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConvertTool_FilenameToLatLon.PicNumModel.form
{
    public partial class Form_PicNum : Form
    {
        public Form_PicNum()
        {
            InitializeComponent();
        }

        #region 事件
        /// <summary>
        /// 选择输入文件夹路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SelectInputFolder_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
                dialog.Description = "请选择输入文件夹";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(dialog.SelectedPath))
                    {
                        MessageBox.Show("文件夹路径不能为空", "提示");
                        return;
                    }
                    textBox_InputFolderPath.Text = dialog.SelectedPath;
                }
            }
            catch (System.Exception ex)
            {

            }

        }

        /// <summary>
        /// 选择输出文件夹路径。（用于存储Excel）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SelectOutputFolder_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
                dialog.Description = "请选择输出文件夹";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(dialog.SelectedPath))
                    {
                        MessageBox.Show("文件夹路径不能为空", "提示");
                        return;
                    }
                    textBox_OutputFolderPath.Text = dialog.SelectedPath;
                }
            }
            catch (System.Exception ex)
            {

            }

        }
        /// <summary>
        /// 执行。将图幅号转换成经纬度信息，并将其输出至Excel。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Execute_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox_InputFolderPath.Text) || string.IsNullOrEmpty(textBox_OutputFolderPath.Text))
                {
                    MessageBox.Show("请先选择输入文件夹和输出文件夹路径！", "提示");
                    return;
                }
                executeHelper.executeMethod(textBox_InputFolderPath.Text, textBox_OutputFolderPath.Text);
            }
            catch (System.Exception ex)
            {

            }

        }
        #endregion






    }
}
