﻿namespace Gmage
{
    partial class BatchForm
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
            this.mFB_Index = new MaterialSkin.Controls.MaterialFlatButton();
            this.mFB_RemoveImg = new MaterialSkin.Controls.MaterialFlatButton();
            this.mFB_Image = new MaterialSkin.Controls.MaterialFlatButton();
            this.mFB_SelectTask = new MaterialSkin.Controls.MaterialFlatButton();
            this.mFB_ClearImg = new MaterialSkin.Controls.MaterialFlatButton();
            this.mFB_StartTask = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pB_View = new System.Windows.Forms.PictureBox();
            this.gB_Task = new System.Windows.Forms.GroupBox();
            this.mL_Remain = new MaterialSkin.Controls.MaterialLabel();
            this.mL_Count = new MaterialSkin.Controls.MaterialLabel();
            this.mL_Task = new MaterialSkin.Controls.MaterialLabel();
            this.mFB_Output = new MaterialSkin.Controls.MaterialFlatButton();
            this.mL_Output = new MaterialSkin.Controls.MaterialLabel();
            this.dGV_Paths = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPB_Progress = new MaterialSkin.Controls.MaterialProgressBar();
            this.mFB_OpenFolder = new MaterialSkin.Controls.MaterialFlatButton();
            this.gB_View2 = new System.Windows.Forms.GroupBox();
            this.pB_View2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_View)).BeginInit();
            this.gB_Task.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Paths)).BeginInit();
            this.gB_View2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_View2)).BeginInit();
            this.SuspendLayout();
            // 
            // mFB_Index
            // 
            this.mFB_Index.AutoSize = true;
            this.mFB_Index.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mFB_Index.BackColor = System.Drawing.Color.Transparent;
            this.mFB_Index.Depth = 0;
            this.mFB_Index.Font = new System.Drawing.Font("宋体", 15F);
            this.mFB_Index.ForeColor = System.Drawing.Color.White;
            this.mFB_Index.Icon = null;
            this.mFB_Index.Location = new System.Drawing.Point(13, 72);
            this.mFB_Index.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mFB_Index.MouseState = MaterialSkin.MouseState.HOVER;
            this.mFB_Index.Name = "mFB_Index";
            this.mFB_Index.Primary = false;
            this.mFB_Index.Size = new System.Drawing.Size(81, 36);
            this.mFB_Index.TabIndex = 2;
            this.mFB_Index.Text = "选择目录";
            this.mFB_Index.UseVisualStyleBackColor = false;
            this.mFB_Index.Click += new System.EventHandler(this.mFB_Index_Click);
            // 
            // mFB_RemoveImg
            // 
            this.mFB_RemoveImg.AutoSize = true;
            this.mFB_RemoveImg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mFB_RemoveImg.BackColor = System.Drawing.Color.Transparent;
            this.mFB_RemoveImg.Depth = 0;
            this.mFB_RemoveImg.Font = new System.Drawing.Font("宋体", 15F);
            this.mFB_RemoveImg.ForeColor = System.Drawing.Color.White;
            this.mFB_RemoveImg.Icon = null;
            this.mFB_RemoveImg.Location = new System.Drawing.Point(13, 168);
            this.mFB_RemoveImg.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mFB_RemoveImg.MouseState = MaterialSkin.MouseState.HOVER;
            this.mFB_RemoveImg.Name = "mFB_RemoveImg";
            this.mFB_RemoveImg.Primary = false;
            this.mFB_RemoveImg.Size = new System.Drawing.Size(81, 36);
            this.mFB_RemoveImg.TabIndex = 4;
            this.mFB_RemoveImg.Text = "移除图片";
            this.mFB_RemoveImg.UseVisualStyleBackColor = false;
            // 
            // mFB_Image
            // 
            this.mFB_Image.AutoSize = true;
            this.mFB_Image.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mFB_Image.BackColor = System.Drawing.Color.Transparent;
            this.mFB_Image.Depth = 0;
            this.mFB_Image.Font = new System.Drawing.Font("宋体", 15F);
            this.mFB_Image.ForeColor = System.Drawing.Color.White;
            this.mFB_Image.Icon = null;
            this.mFB_Image.Location = new System.Drawing.Point(13, 120);
            this.mFB_Image.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mFB_Image.MouseState = MaterialSkin.MouseState.HOVER;
            this.mFB_Image.Name = "mFB_Image";
            this.mFB_Image.Primary = false;
            this.mFB_Image.Size = new System.Drawing.Size(81, 36);
            this.mFB_Image.TabIndex = 5;
            this.mFB_Image.Text = "选择图片";
            this.mFB_Image.UseVisualStyleBackColor = false;
            // 
            // mFB_SelectTask
            // 
            this.mFB_SelectTask.AutoSize = true;
            this.mFB_SelectTask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mFB_SelectTask.BackColor = System.Drawing.Color.Transparent;
            this.mFB_SelectTask.Depth = 0;
            this.mFB_SelectTask.Font = new System.Drawing.Font("宋体", 15F);
            this.mFB_SelectTask.ForeColor = System.Drawing.Color.White;
            this.mFB_SelectTask.Icon = null;
            this.mFB_SelectTask.Location = new System.Drawing.Point(13, 264);
            this.mFB_SelectTask.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mFB_SelectTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.mFB_SelectTask.Name = "mFB_SelectTask";
            this.mFB_SelectTask.Primary = false;
            this.mFB_SelectTask.Size = new System.Drawing.Size(81, 36);
            this.mFB_SelectTask.TabIndex = 6;
            this.mFB_SelectTask.Text = "选择任务";
            this.mFB_SelectTask.UseVisualStyleBackColor = false;
            this.mFB_SelectTask.Click += new System.EventHandler(this.mFB_AddTask_Click);
            // 
            // mFB_ClearImg
            // 
            this.mFB_ClearImg.AutoSize = true;
            this.mFB_ClearImg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mFB_ClearImg.BackColor = System.Drawing.Color.Transparent;
            this.mFB_ClearImg.Depth = 0;
            this.mFB_ClearImg.Font = new System.Drawing.Font("宋体", 15F);
            this.mFB_ClearImg.ForeColor = System.Drawing.Color.White;
            this.mFB_ClearImg.Icon = null;
            this.mFB_ClearImg.Location = new System.Drawing.Point(13, 216);
            this.mFB_ClearImg.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mFB_ClearImg.MouseState = MaterialSkin.MouseState.HOVER;
            this.mFB_ClearImg.Name = "mFB_ClearImg";
            this.mFB_ClearImg.Primary = false;
            this.mFB_ClearImg.Size = new System.Drawing.Size(81, 36);
            this.mFB_ClearImg.TabIndex = 8;
            this.mFB_ClearImg.Text = "清空图片";
            this.mFB_ClearImg.UseVisualStyleBackColor = false;
            // 
            // mFB_StartTask
            // 
            this.mFB_StartTask.AutoSize = true;
            this.mFB_StartTask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mFB_StartTask.BackColor = System.Drawing.Color.Transparent;
            this.mFB_StartTask.Depth = 0;
            this.mFB_StartTask.Font = new System.Drawing.Font("宋体", 15F);
            this.mFB_StartTask.ForeColor = System.Drawing.Color.White;
            this.mFB_StartTask.Icon = null;
            this.mFB_StartTask.Location = new System.Drawing.Point(13, 312);
            this.mFB_StartTask.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mFB_StartTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.mFB_StartTask.Name = "mFB_StartTask";
            this.mFB_StartTask.Primary = false;
            this.mFB_StartTask.Size = new System.Drawing.Size(81, 36);
            this.mFB_StartTask.TabIndex = 10;
            this.mFB_StartTask.Text = "开始任务";
            this.mFB_StartTask.UseVisualStyleBackColor = false;
            this.mFB_StartTask.Click += new System.EventHandler(this.mFB_StartTask_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pB_View);
            this.groupBox1.Location = new System.Drawing.Point(949, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 235);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "预览";
            // 
            // pB_View
            // 
            this.pB_View.BackColor = System.Drawing.Color.Transparent;
            this.pB_View.Location = new System.Drawing.Point(6, 20);
            this.pB_View.Name = "pB_View";
            this.pB_View.Size = new System.Drawing.Size(161, 202);
            this.pB_View.TabIndex = 12;
            this.pB_View.TabStop = false;
            // 
            // gB_Task
            // 
            this.gB_Task.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gB_Task.BackColor = System.Drawing.Color.Transparent;
            this.gB_Task.Controls.Add(this.mL_Remain);
            this.gB_Task.Controls.Add(this.mL_Count);
            this.gB_Task.Controls.Add(this.mL_Task);
            this.gB_Task.Location = new System.Drawing.Point(949, 72);
            this.gB_Task.Name = "gB_Task";
            this.gB_Task.Size = new System.Drawing.Size(173, 221);
            this.gB_Task.TabIndex = 14;
            this.gB_Task.TabStop = false;
            this.gB_Task.Text = "信息列表";
            // 
            // mL_Remain
            // 
            this.mL_Remain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mL_Remain.BackColor = System.Drawing.Color.Transparent;
            this.mL_Remain.Depth = 0;
            this.mL_Remain.Font = new System.Drawing.Font("Roboto", 11F);
            this.mL_Remain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mL_Remain.Location = new System.Drawing.Point(8, 50);
            this.mL_Remain.MouseState = MaterialSkin.MouseState.HOVER;
            this.mL_Remain.Name = "mL_Remain";
            this.mL_Remain.Size = new System.Drawing.Size(159, 20);
            this.mL_Remain.TabIndex = 23;
            this.mL_Remain.Text = "转换剩余：未开始";
            // 
            // mL_Count
            // 
            this.mL_Count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mL_Count.BackColor = System.Drawing.Color.Transparent;
            this.mL_Count.Depth = 0;
            this.mL_Count.Font = new System.Drawing.Font("Roboto", 11F);
            this.mL_Count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mL_Count.Location = new System.Drawing.Point(8, 75);
            this.mL_Count.MouseState = MaterialSkin.MouseState.HOVER;
            this.mL_Count.Name = "mL_Count";
            this.mL_Count.Size = new System.Drawing.Size(159, 20);
            this.mL_Count.TabIndex = 22;
            this.mL_Count.Text = "图片总计：";
            // 
            // mL_Task
            // 
            this.mL_Task.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mL_Task.BackColor = System.Drawing.Color.Transparent;
            this.mL_Task.Depth = 0;
            this.mL_Task.Font = new System.Drawing.Font("Roboto", 11F);
            this.mL_Task.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mL_Task.Location = new System.Drawing.Point(8, 25);
            this.mL_Task.MouseState = MaterialSkin.MouseState.HOVER;
            this.mL_Task.Name = "mL_Task";
            this.mL_Task.Size = new System.Drawing.Size(159, 20);
            this.mL_Task.TabIndex = 21;
            this.mL_Task.Text = "任务名称：";
            // 
            // mFB_Output
            // 
            this.mFB_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mFB_Output.AutoSize = true;
            this.mFB_Output.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mFB_Output.BackColor = System.Drawing.Color.Transparent;
            this.mFB_Output.Depth = 0;
            this.mFB_Output.Font = new System.Drawing.Font("宋体", 15F);
            this.mFB_Output.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mFB_Output.Icon = null;
            this.mFB_Output.Location = new System.Drawing.Point(13, 783);
            this.mFB_Output.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mFB_Output.MouseState = MaterialSkin.MouseState.HOVER;
            this.mFB_Output.Name = "mFB_Output";
            this.mFB_Output.Primary = false;
            this.mFB_Output.Size = new System.Drawing.Size(78, 36);
            this.mFB_Output.TabIndex = 15;
            this.mFB_Output.Text = "输出至...";
            this.mFB_Output.UseVisualStyleBackColor = false;
            this.mFB_Output.Click += new System.EventHandler(this.mFB_Output_Click);
            // 
            // mL_Output
            // 
            this.mL_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mL_Output.Depth = 0;
            this.mL_Output.Font = new System.Drawing.Font("Roboto", 11F);
            this.mL_Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mL_Output.Location = new System.Drawing.Point(100, 793);
            this.mL_Output.MouseState = MaterialSkin.MouseState.HOVER;
            this.mL_Output.Name = "mL_Output";
            this.mL_Output.Size = new System.Drawing.Size(614, 19);
            this.mL_Output.TabIndex = 17;
            // 
            // dGV_Paths
            // 
            this.dGV_Paths.AllowUserToAddRows = false;
            this.dGV_Paths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Paths.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Paths.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGV_Paths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Paths.ColumnHeadersVisible = false;
            this.dGV_Paths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dGV_Paths.Location = new System.Drawing.Point(104, 72);
            this.dGV_Paths.Name = "dGV_Paths";
            this.dGV_Paths.ReadOnly = true;
            this.dGV_Paths.RowHeadersVisible = false;
            this.dGV_Paths.RowTemplate.Height = 23;
            this.dGV_Paths.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dGV_Paths.Size = new System.Drawing.Size(827, 712);
            this.dGV_Paths.TabIndex = 18;
            this.dGV_Paths.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Paths_CellClick);
            this.dGV_Paths.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Paths_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "路径";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // mPB_Progress
            // 
            this.mPB_Progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mPB_Progress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mPB_Progress.Depth = 0;
            this.mPB_Progress.Location = new System.Drawing.Point(0, 822);
            this.mPB_Progress.MouseState = MaterialSkin.MouseState.HOVER;
            this.mPB_Progress.Name = "mPB_Progress";
            this.mPB_Progress.Size = new System.Drawing.Size(1134, 5);
            this.mPB_Progress.TabIndex = 19;
            this.mPB_Progress.Visible = false;
            // 
            // mFB_OpenFolder
            // 
            this.mFB_OpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mFB_OpenFolder.AutoSize = true;
            this.mFB_OpenFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mFB_OpenFolder.BackColor = System.Drawing.Color.Transparent;
            this.mFB_OpenFolder.Depth = 0;
            this.mFB_OpenFolder.Font = new System.Drawing.Font("宋体", 15F);
            this.mFB_OpenFolder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mFB_OpenFolder.Icon = null;
            this.mFB_OpenFolder.Location = new System.Drawing.Point(13, 735);
            this.mFB_OpenFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mFB_OpenFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.mFB_OpenFolder.Name = "mFB_OpenFolder";
            this.mFB_OpenFolder.Primary = false;
            this.mFB_OpenFolder.Size = new System.Drawing.Size(81, 36);
            this.mFB_OpenFolder.TabIndex = 20;
            this.mFB_OpenFolder.Text = "打开目录";
            this.mFB_OpenFolder.UseVisualStyleBackColor = false;
            this.mFB_OpenFolder.Click += new System.EventHandler(this.mFB_OpenFolder_Click);
            // 
            // gB_View2
            // 
            this.gB_View2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gB_View2.BackColor = System.Drawing.Color.Transparent;
            this.gB_View2.Controls.Add(this.pB_View2);
            this.gB_View2.Location = new System.Drawing.Point(949, 549);
            this.gB_View2.Name = "gB_View2";
            this.gB_View2.Size = new System.Drawing.Size(173, 235);
            this.gB_View2.TabIndex = 21;
            this.gB_View2.TabStop = false;
            this.gB_View2.Text = "效果预览";
            // 
            // pB_View2
            // 
            this.pB_View2.BackColor = System.Drawing.Color.Transparent;
            this.pB_View2.Location = new System.Drawing.Point(6, 20);
            this.pB_View2.Name = "pB_View2";
            this.pB_View2.Size = new System.Drawing.Size(161, 202);
            this.pB_View2.TabIndex = 12;
            this.pB_View2.TabStop = false;
            // 
            // BatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 827);
            this.Controls.Add(this.gB_View2);
            this.Controls.Add(this.mFB_OpenFolder);
            this.Controls.Add(this.mPB_Progress);
            this.Controls.Add(this.dGV_Paths);
            this.Controls.Add(this.mL_Output);
            this.Controls.Add(this.mFB_Output);
            this.Controls.Add(this.gB_Task);
            this.Controls.Add(this.mFB_StartTask);
            this.Controls.Add(this.mFB_ClearImg);
            this.Controls.Add(this.mFB_SelectTask);
            this.Controls.Add(this.mFB_Image);
            this.Controls.Add(this.mFB_RemoveImg);
            this.Controls.Add(this.mFB_Index);
            this.Controls.Add(this.groupBox1);
            this.Name = "BatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批处理";
            this.Load += new System.EventHandler(this.BatchForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB_View)).EndInit();
            this.gB_Task.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Paths)).EndInit();
            this.gB_View2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB_View2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton mFB_Index;
        private MaterialSkin.Controls.MaterialFlatButton mFB_RemoveImg;
        private MaterialSkin.Controls.MaterialFlatButton mFB_Image;
        private MaterialSkin.Controls.MaterialFlatButton mFB_SelectTask;
        private MaterialSkin.Controls.MaterialFlatButton mFB_ClearImg;
        private MaterialSkin.Controls.MaterialFlatButton mFB_StartTask;
        private System.Windows.Forms.PictureBox pB_View;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gB_Task;
        private MaterialSkin.Controls.MaterialFlatButton mFB_Output;
        private MaterialSkin.Controls.MaterialLabel mL_Output;
        private System.Windows.Forms.DataGridView dGV_Paths;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private MaterialSkin.Controls.MaterialProgressBar mPB_Progress;
        private MaterialSkin.Controls.MaterialFlatButton mFB_OpenFolder;
        private MaterialSkin.Controls.MaterialLabel mL_Remain;
        private MaterialSkin.Controls.MaterialLabel mL_Count;
        private MaterialSkin.Controls.MaterialLabel mL_Task;
        private System.Windows.Forms.GroupBox gB_View2;
        private System.Windows.Forms.PictureBox pB_View2;
    }
}