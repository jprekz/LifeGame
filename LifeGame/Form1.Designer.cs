namespace LifeGame
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
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CellSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileFToolStripMenuItem,
            this.GameToolStripMenuItem,
            this.PauseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileFToolStripMenuItem
            // 
            this.FileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenOToolStripMenuItem,
            this.ExitXToolStripMenuItem});
            this.FileFToolStripMenuItem.Name = "FileFToolStripMenuItem";
            this.FileFToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.FileFToolStripMenuItem.Text = "ファイル(F)";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.NewToolStripMenuItem.Text = "新規(N)";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OpenOToolStripMenuItem
            // 
            this.OpenOToolStripMenuItem.Name = "OpenOToolStripMenuItem";
            this.OpenOToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.OpenOToolStripMenuItem.Text = "ファイルを開く(O)";
            this.OpenOToolStripMenuItem.Click += new System.EventHandler(this.OpenOToolStripMenuItem_Click);
            // 
            // ExitXToolStripMenuItem
            // 
            this.ExitXToolStripMenuItem.Name = "ExitXToolStripMenuItem";
            this.ExitXToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.ExitXToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ExitXToolStripMenuItem.Text = "終了(X)";
            this.ExitXToolStripMenuItem.Click += new System.EventHandler(this.ExitXToolStripMenuItem_Click);
            // 
            // GameToolStripMenuItem
            // 
            this.GameToolStripMenuItem.CheckOnClick = true;
            this.GameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoopToolStripMenuItem,
            this.CellSizeToolStripMenuItem,
            this.SpeedToolStripMenuItem});
            this.GameToolStripMenuItem.Name = "GameToolStripMenuItem";
            this.GameToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.GameToolStripMenuItem.Text = "ゲーム(G)";
            // 
            // LoopToolStripMenuItem
            // 
            this.LoopToolStripMenuItem.CheckOnClick = true;
            this.LoopToolStripMenuItem.Name = "LoopToolStripMenuItem";
            this.LoopToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.LoopToolStripMenuItem.Text = "セルのループ";
            this.LoopToolStripMenuItem.Click += new System.EventHandler(this.LoopToolStripMenuItem_Click);
            // 
            // CellSizeToolStripMenuItem
            // 
            this.CellSizeToolStripMenuItem.Name = "CellSizeToolStripMenuItem";
            this.CellSizeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.CellSizeToolStripMenuItem.Text = "セルの大きさ";
            this.CellSizeToolStripMenuItem.Click += new System.EventHandler(this.CellSizeToolStripMenuItem_Click);
            // 
            // PauseToolStripMenuItem
            // 
            this.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem";
            this.PauseToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.PauseToolStripMenuItem.Text = "開始";
            this.PauseToolStripMenuItem.Click += new System.EventHandler(this.PauseToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 416);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SpeedToolStripMenuItem
            // 
            this.SpeedToolStripMenuItem.Name = "SpeedToolStripMenuItem";
            this.SpeedToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.SpeedToolStripMenuItem.Text = "実行速度の変更";
            this.SpeedToolStripMenuItem.Click += new System.EventHandler(this.SpeedToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CellSizeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenOToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem SpeedToolStripMenuItem;
    }
}

