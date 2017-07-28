namespace ConvertTool_FilenameToLatLon.PicNumModel.form
{
    partial class Form_PicNum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_PicNum = new System.Windows.Forms.Panel();
            this.button_SelectOutputFolder = new System.Windows.Forms.Button();
            this.button_SelectInputFolder = new System.Windows.Forms.Button();
            this.button_Execute = new System.Windows.Forms.Button();
            this.label_OutputFolderPath = new System.Windows.Forms.Label();
            this.label_InputfolderPath = new System.Windows.Forms.Label();
            this.textBox_OutputFolderPath = new System.Windows.Forms.TextBox();
            this.textBox_InputFolderPath = new System.Windows.Forms.TextBox();
            this.panel_PicNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_PicNum
            // 
            this.panel_PicNum.Controls.Add(this.button_SelectOutputFolder);
            this.panel_PicNum.Controls.Add(this.button_SelectInputFolder);
            this.panel_PicNum.Controls.Add(this.button_Execute);
            this.panel_PicNum.Controls.Add(this.label_OutputFolderPath);
            this.panel_PicNum.Controls.Add(this.label_InputfolderPath);
            this.panel_PicNum.Controls.Add(this.textBox_OutputFolderPath);
            this.panel_PicNum.Controls.Add(this.textBox_InputFolderPath);
            this.panel_PicNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_PicNum.Location = new System.Drawing.Point(0, 0);
            this.panel_PicNum.Name = "panel_PicNum";
            this.panel_PicNum.Size = new System.Drawing.Size(509, 111);
            this.panel_PicNum.TabIndex = 0;
            // 
            // button_SelectOutputFolder
            // 
            this.button_SelectOutputFolder.Location = new System.Drawing.Point(472, 46);
            this.button_SelectOutputFolder.Name = "button_SelectOutputFolder";
            this.button_SelectOutputFolder.Size = new System.Drawing.Size(25, 21);
            this.button_SelectOutputFolder.TabIndex = 4;
            this.button_SelectOutputFolder.UseVisualStyleBackColor = true;
            this.button_SelectOutputFolder.Click += new System.EventHandler(this.button_SelectOutputFolder_Click);
            // 
            // button_SelectInputFolder
            // 
            this.button_SelectInputFolder.Location = new System.Drawing.Point(472, 12);
            this.button_SelectInputFolder.Name = "button_SelectInputFolder";
            this.button_SelectInputFolder.Size = new System.Drawing.Size(25, 21);
            this.button_SelectInputFolder.TabIndex = 3;
            this.button_SelectInputFolder.UseVisualStyleBackColor = true;
            this.button_SelectInputFolder.Click += new System.EventHandler(this.button_SelectInputFolder_Click);
            // 
            // button_Execute
            // 
            this.button_Execute.Location = new System.Drawing.Point(224, 76);
            this.button_Execute.Name = "button_Execute";
            this.button_Execute.Size = new System.Drawing.Size(75, 23);
            this.button_Execute.TabIndex = 2;
            this.button_Execute.Text = "执行";
            this.button_Execute.UseVisualStyleBackColor = true;
            this.button_Execute.Click += new System.EventHandler(this.button_Execute_Click);
            // 
            // label_OutputFolderPath
            // 
            this.label_OutputFolderPath.AutoSize = true;
            this.label_OutputFolderPath.Location = new System.Drawing.Point(12, 49);
            this.label_OutputFolderPath.Name = "label_OutputFolderPath";
            this.label_OutputFolderPath.Size = new System.Drawing.Size(77, 12);
            this.label_OutputFolderPath.TabIndex = 1;
            this.label_OutputFolderPath.Text = "输出文件夹：";
            // 
            // label_InputfolderPath
            // 
            this.label_InputfolderPath.AutoSize = true;
            this.label_InputfolderPath.Location = new System.Drawing.Point(12, 15);
            this.label_InputfolderPath.Name = "label_InputfolderPath";
            this.label_InputfolderPath.Size = new System.Drawing.Size(77, 12);
            this.label_InputfolderPath.TabIndex = 1;
            this.label_InputfolderPath.Text = "输入文件夹：";
            // 
            // textBox_OutputFolderPath
            // 
            this.textBox_OutputFolderPath.Enabled = false;
            this.textBox_OutputFolderPath.Location = new System.Drawing.Point(91, 46);
            this.textBox_OutputFolderPath.Name = "textBox_OutputFolderPath";
            this.textBox_OutputFolderPath.Size = new System.Drawing.Size(375, 21);
            this.textBox_OutputFolderPath.TabIndex = 0;
            // 
            // textBox_InputFolderPath
            // 
            this.textBox_InputFolderPath.Enabled = false;
            this.textBox_InputFolderPath.Location = new System.Drawing.Point(91, 12);
            this.textBox_InputFolderPath.Name = "textBox_InputFolderPath";
            this.textBox_InputFolderPath.Size = new System.Drawing.Size(375, 21);
            this.textBox_InputFolderPath.TabIndex = 0;
            // 
            // Form_PicNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 111);
            this.Controls.Add(this.panel_PicNum);
            this.Name = "Form_PicNum";
            this.Text = "图幅号转经纬度";
            this.panel_PicNum.ResumeLayout(false);
            this.panel_PicNum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_PicNum;
        private System.Windows.Forms.Label label_OutputFolderPath;
        private System.Windows.Forms.Label label_InputfolderPath;
        private System.Windows.Forms.TextBox textBox_OutputFolderPath;
        private System.Windows.Forms.TextBox textBox_InputFolderPath;
        private System.Windows.Forms.Button button_Execute;
        private System.Windows.Forms.Button button_SelectOutputFolder;
        private System.Windows.Forms.Button button_SelectInputFolder;
    }
}