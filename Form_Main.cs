using ConvertTool_FilenameToLatLon.PicNumModel.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConvertTool_FilenameToLatLon
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }


        #region 事件
        /// <summary>
        /// 打开图幅号转经纬度的界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_PicNum_Click(object sender, EventArgs e)
        {
            try
            {
                Form_PicNum form_picnum = new Form_PicNum();
                form_picnum.ShowDialog();
            }
            catch (System.Exception ex)
            {

            }

        }
        #endregion
    }
}
