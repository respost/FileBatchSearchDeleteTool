namespace 文件批量搜索删除工具
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelFileBox = new System.Windows.Forms.Panel();
            this.labTips = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.AddPath = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirPath = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panelCopyright = new System.Windows.Forms.Panel();
            this.panelFileBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPath)).BeginInit();
            this.panelCopyright.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFileBox
            // 
            this.panelFileBox.AllowDrop = true;
            this.panelFileBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFileBox.BackColor = System.Drawing.SystemColors.Control;
            this.panelFileBox.Controls.Add(this.labTips);
            this.panelFileBox.Controls.Add(this.listView1);
            this.panelFileBox.Location = new System.Drawing.Point(7, 43);
            this.panelFileBox.Name = "panelFileBox";
            this.panelFileBox.Size = new System.Drawing.Size(480, 217);
            this.panelFileBox.TabIndex = 2;
            this.panelFileBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelFileBox_DragDrop);
            this.panelFileBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelFileBox_DragEnter);
            // 
            // labTips
            // 
            this.labTips.AutoSize = true;
            this.labTips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.labTips.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labTips.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTips.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labTips.Location = new System.Drawing.Point(148, 100);
            this.labTips.Name = "labTips";
            this.labTips.Size = new System.Drawing.Size(184, 16);
            this.labTips.TabIndex = 1;
            this.labTips.Text = "拖拽要删除的文件到这里";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(480, 217);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // AddPath
            // 
            this.AddPath.Image = ((System.Drawing.Image)(resources.GetObject("AddPath.Image")));
            this.AddPath.Location = new System.Drawing.Point(392, 13);
            this.AddPath.Name = "AddPath";
            this.AddPath.Size = new System.Drawing.Size(20, 18);
            this.AddPath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddPath.TabIndex = 7;
            this.AddPath.TabStop = false;
            this.AddPath.Click += new System.EventHandler(this.AddPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "文件所在目录：";
            // 
            // txtDirPath
            // 
            this.txtDirPath.Location = new System.Drawing.Point(100, 12);
            this.txtDirPath.Name = "txtDirPath";
            this.txtDirPath.Size = new System.Drawing.Size(313, 21);
            this.txtDirPath.TabIndex = 6;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Green;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(419, 10);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(68, 23);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "点击删除";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Gray;
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(7, 266);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(480, 99);
            this.txtLog.TabIndex = 10;
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.BackColor = System.Drawing.Color.Transparent;
            this.labelUrl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelUrl.ForeColor = System.Drawing.Color.White;
            this.labelUrl.Location = new System.Drawing.Point(79, 33);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(281, 12);
            this.labelUrl.TabIndex = 14;
            this.labelUrl.Text = "开发赞助商：资源驿站（www.zy13.net），点击访问";
            this.labelUrl.Click += new System.EventHandler(this.labelUrl_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(37, 12);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(365, 12);
            this.label22.TabIndex = 13;
            this.label22.Text = "软件仅供学习和研究，不得用于非法盈利，违者自行承担法律责任。";
            // 
            // panelCopyright
            // 
            this.panelCopyright.BackColor = System.Drawing.Color.Gray;
            this.panelCopyright.Controls.Add(this.labelUrl);
            this.panelCopyright.Controls.Add(this.label22);
            this.panelCopyright.Location = new System.Drawing.Point(28, 289);
            this.panelCopyright.Name = "panelCopyright";
            this.panelCopyright.Size = new System.Drawing.Size(439, 57);
            this.panelCopyright.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 373);
            this.Controls.Add(this.panelCopyright);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.AddPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDirPath);
            this.Controls.Add(this.panelFileBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件批量搜索删除工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelFileBox.ResumeLayout(false);
            this.panelFileBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPath)).EndInit();
            this.panelCopyright.ResumeLayout(false);
            this.panelCopyright.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFileBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox AddPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirPath;
        private System.Windows.Forms.Label labTips;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panelCopyright;
    }
}

