namespace WatchPatterns
{
    partial class EventsForm1
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
            this.addBtn = new System.Windows.Forms.Button();
            this.numericUpDownH = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownS = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(65, 129);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // numericUpDownH
            // 
            this.numericUpDownH.Location = new System.Drawing.Point(29, 34);
            this.numericUpDownH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownH.Name = "numericUpDownH";
            this.numericUpDownH.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownH.TabIndex = 1;
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.Location = new System.Drawing.Point(81, 34);
            this.numericUpDownM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownM.Name = "numericUpDownM";
            this.numericUpDownM.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownM.TabIndex = 2;
            // 
            // numericUpDownS
            // 
            this.numericUpDownS.Location = new System.Drawing.Point(133, 34);
            this.numericUpDownS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownS.Name = "numericUpDownS";
            this.numericUpDownS.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownS.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "s";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Alarm",
            "Timer",
            "Stopwatch"});
            this.comboBox.Location = new System.Drawing.Point(31, 76);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(144, 21);
            this.comboBox.TabIndex = 7;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 174);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownS);
            this.Controls.Add(this.numericUpDownM);
            this.Controls.Add(this.numericUpDownH);
            this.Controls.Add(this.addBtn);
            this.Name = "EventsForm";
            this.Text = "Add event";
            this.Load += new System.EventHandler(this.EventsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.NumericUpDown numericUpDownH;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.NumericUpDown numericUpDownS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox;
    }
}