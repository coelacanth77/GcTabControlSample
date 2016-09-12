namespace GcTabControlSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gcTabControl1 = new GrapeCity.Win.Containers.GcTabControl();
            this.gcTabPage1 = new GrapeCity.Win.Containers.GcTabPage();
            this.gcTabPage2 = new GrapeCity.Win.Containers.GcTabPage();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTabControl1)).BeginInit();
            this.gcTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gcTabControl1
            // 
            this.gcTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.gcTabControl1.Appearance = GrapeCity.Win.Containers.TabAppearance.Office2007Blue;
            this.gcTabControl1.CloseButtonVisibility = GrapeCity.Win.Containers.CloseButtonVisibility.Always;
            this.gcTabControl1.HotTrack = true;
            this.gcTabControl1.HotTrackEffect = GrapeCity.Win.Containers.HotTrackEffect.Normal;
            this.gcTabControl1.Location = new System.Drawing.Point(12, 131);
            this.gcTabControl1.Name = "gcTabControl1";
            this.gcTabControl1.Size = new System.Drawing.Size(200, 100);
            this.gcTabControl1.TabIndex = 1;
            this.gcTabControl1.TabPages.Add(this.gcTabPage1);
            this.gcTabControl1.TabPages.Add(this.gcTabPage2);
            this.gcTabControl1.TextOrientation = GrapeCity.Win.Common.TextOrientation.Horizontal;
            // 
            // gcTabPage1
            // 
            this.gcTabPage1.Location = new System.Drawing.Point(93, 4);
            this.gcTabPage1.Name = "gcTabPage1";
            this.gcTabPage1.Size = new System.Drawing.Size(103, 92);
            this.gcTabPage1.TabIndex = 0;
            this.gcTabPage1.Text = "gcTabPage1";
            this.gcTabPage1.UseVisualStyleBackColor = true;
            // 
            // gcTabPage2
            // 
            this.gcTabPage2.Location = new System.Drawing.Point(93, 4);
            this.gcTabPage2.Name = "gcTabPage2";
            this.gcTabPage2.Size = new System.Drawing.Size(103, 92);
            this.gcTabPage2.TabIndex = 1;
            this.gcTabPage2.Text = "gcTabPage2";
            this.gcTabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gcTabControl1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTabControl1)).EndInit();
            this.gcTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private GrapeCity.Win.Containers.GcTabControl gcTabControl1;
        private GrapeCity.Win.Containers.GcTabPage gcTabPage1;
        private GrapeCity.Win.Containers.GcTabPage gcTabPage2;
    }
}

