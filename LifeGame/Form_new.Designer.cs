namespace LifeGame
{
    partial class Form_new
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_y = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_x = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_new = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.checkBox_rnd = new System.Windows.Forms.CheckBox();
            this.numericUpDown_rnd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rnd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_y);
            this.groupBox1.Controls.Add(this.numericUpDown_x);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(177, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "大きさ";
            // 
            // numericUpDown_y
            // 
            this.numericUpDown_y.Location = new System.Drawing.Point(44, 64);
            this.numericUpDown_y.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_y.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_y.Name = "numericUpDown_y";
            this.numericUpDown_y.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown_y.TabIndex = 4;
            this.numericUpDown_y.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_x
            // 
            this.numericUpDown_x.Location = new System.Drawing.Point(44, 30);
            this.numericUpDown_x.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_x.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_x.Name = "numericUpDown_x";
            this.numericUpDown_x.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown_x.TabIndex = 3;
            this.numericUpDown_x.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "y : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "x : ";
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(231, 125);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(75, 23);
            this.button_new.TabIndex = 1;
            this.button_new.Text = "新規作成";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(231, 154);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "キャンセル";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // checkBox_rnd
            // 
            this.checkBox_rnd.AutoSize = true;
            this.checkBox_rnd.Location = new System.Drawing.Point(19, 128);
            this.checkBox_rnd.Margin = new System.Windows.Forms.Padding(10);
            this.checkBox_rnd.Name = "checkBox_rnd";
            this.checkBox_rnd.Size = new System.Drawing.Size(124, 16);
            this.checkBox_rnd.TabIndex = 3;
            this.checkBox_rnd.Text = "ランダムに初期化する";
            this.checkBox_rnd.UseVisualStyleBackColor = true;
            this.checkBox_rnd.CheckedChanged += new System.EventHandler(this.checkBox_rnd_CheckedChanged);
            // 
            // numericUpDown_rnd
            // 
            this.numericUpDown_rnd.DecimalPlaces = 2;
            this.numericUpDown_rnd.Enabled = false;
            this.numericUpDown_rnd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_rnd.Location = new System.Drawing.Point(57, 157);
            this.numericUpDown_rnd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_rnd.Name = "numericUpDown_rnd";
            this.numericUpDown_rnd.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown_rnd.TabIndex = 4;
            this.numericUpDown_rnd.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "しきい値";
            // 
            // Form_new
            // 
            this.AcceptButton = this.button_new;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(329, 194);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_rnd);
            this.Controls.Add(this.checkBox_rnd);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_new";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "新規";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_cancel;
        public System.Windows.Forms.NumericUpDown numericUpDown_y;
        public System.Windows.Forms.NumericUpDown numericUpDown_x;
        public System.Windows.Forms.CheckBox checkBox_rnd;
        public System.Windows.Forms.NumericUpDown numericUpDown_rnd;
        private System.Windows.Forms.Label label3;

    }
}