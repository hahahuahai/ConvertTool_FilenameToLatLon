namespace ConvertTool_FilenameToLatLon
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_PicNum = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_PicNum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 48);
            this.panel1.TabIndex = 0;
            // 
            // button_PicNum
            // 
            this.button_PicNum.Location = new System.Drawing.Point(23, 12);
            this.button_PicNum.Name = "button_PicNum";
            this.button_PicNum.Size = new System.Drawing.Size(119, 23);
            this.button_PicNum.TabIndex = 0;
            this.button_PicNum.Text = "图幅号转经纬度";
            this.button_PicNum.UseVisualStyleBackColor = true;
            this.button_PicNum.Click += new System.EventHandler(this.button_PicNum_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 48);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "主窗体";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_PicNum;
    }
}

