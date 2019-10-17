namespace Ekml
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Export = new System.Windows.Forms.Button();
            this.labelIndex = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRng5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textVal10 = new System.Windows.Forms.TextBox();
            this.textVal9 = new System.Windows.Forms.TextBox();
            this.btnRng4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textVal8 = new System.Windows.Forms.TextBox();
            this.textVal7 = new System.Windows.Forms.TextBox();
            this.btnRng3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textVal6 = new System.Windows.Forms.TextBox();
            this.textVal5 = new System.Windows.Forms.TextBox();
            this.btnRng2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textVal4 = new System.Windows.Forms.TextBox();
            this.textVal3 = new System.Windows.Forms.TextBox();
            this.btnRng1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textVal2 = new System.Windows.Forms.TextBox();
            this.textVal1 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleDescription = "";
            this.comboBox1.AccessibleName = "";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Tag = "";
            this.comboBox1.Text = "select a data";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCsvToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exportAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openCsvToolStripMenuItem
            // 
            this.openCsvToolStripMenuItem.Name = "openCsvToolStripMenuItem";
            this.openCsvToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.openCsvToolStripMenuItem.Text = "Open Csv";
            this.openCsvToolStripMenuItem.Click += new System.EventHandler(this.openCsvToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exportAsToolStripMenuItem
            // 
            this.exportAsToolStripMenuItem.Name = "exportAsToolStripMenuItem";
            this.exportAsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.exportAsToolStripMenuItem.Text = "Export As";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openValuesToolStripMenuItem,
            this.saveValuesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // openValuesToolStripMenuItem
            // 
            this.openValuesToolStripMenuItem.Name = "openValuesToolStripMenuItem";
            this.openValuesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openValuesToolStripMenuItem.Text = "Open Values";
            // 
            // saveValuesToolStripMenuItem
            // 
            this.saveValuesToolStripMenuItem.Name = "saveValuesToolStripMenuItem";
            this.saveValuesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveValuesToolStripMenuItem.Text = "Save Values";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(9, 155);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(139, 21);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.Text = "select longitude";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(9, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(139, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "select latitude";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Longitude:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Latitude:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source Data";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(12, 337);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(165, 23);
            this.Export.TabIndex = 3;
            this.Export.Text = "Plotter";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.export_Click);
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.BackColor = System.Drawing.Color.Transparent;
            this.labelIndex.Location = new System.Drawing.Point(193, 267);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(32, 13);
            this.labelIndex.TabIndex = 9;
            this.labelIndex.Text = "index";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRng5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textVal10);
            this.groupBox2.Controls.Add(this.textVal9);
            this.groupBox2.Controls.Add(this.btnRng4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textVal8);
            this.groupBox2.Controls.Add(this.textVal7);
            this.groupBox2.Controls.Add(this.btnRng3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textVal6);
            this.groupBox2.Controls.Add(this.textVal5);
            this.groupBox2.Controls.Add(this.btnRng2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textVal4);
            this.groupBox2.Controls.Add(this.textVal3);
            this.groupBox2.Controls.Add(this.btnRng1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textVal2);
            this.groupBox2.Controls.Add(this.textVal1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(196, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 206);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Range Values";
            // 
            // btnRng5
            // 
            this.btnRng5.BackColor = System.Drawing.Color.White;
            this.btnRng5.Location = new System.Drawing.Point(10, 165);
            this.btnRng5.Name = "btnRng5";
            this.btnRng5.Size = new System.Drawing.Size(22, 21);
            this.btnRng5.TabIndex = 27;
            this.btnRng5.UseVisualStyleBackColor = false;
            this.btnRng5.Click += new System.EventHandler(this.btnRng5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "to";
            // 
            // textVal10
            // 
            this.textVal10.Location = new System.Drawing.Point(107, 166);
            this.textVal10.Name = "textVal10";
            this.textVal10.Size = new System.Drawing.Size(46, 20);
            this.textVal10.TabIndex = 26;
            this.textVal10.TextChanged += new System.EventHandler(this.textVal10_TextChanged);
            // 
            // textVal9
            // 
            this.textVal9.Location = new System.Drawing.Point(36, 166);
            this.textVal9.Name = "textVal9";
            this.textVal9.Size = new System.Drawing.Size(46, 20);
            this.textVal9.TabIndex = 25;
            this.textVal9.TextChanged += new System.EventHandler(this.textVal9_TextChanged);
            // 
            // btnRng4
            // 
            this.btnRng4.BackColor = System.Drawing.Color.White;
            this.btnRng4.Location = new System.Drawing.Point(10, 129);
            this.btnRng4.Name = "btnRng4";
            this.btnRng4.Size = new System.Drawing.Size(22, 21);
            this.btnRng4.TabIndex = 23;
            this.btnRng4.UseVisualStyleBackColor = false;
            this.btnRng4.Click += new System.EventHandler(this.btnRng4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "to";
            // 
            // textVal8
            // 
            this.textVal8.Location = new System.Drawing.Point(107, 130);
            this.textVal8.Name = "textVal8";
            this.textVal8.Size = new System.Drawing.Size(46, 20);
            this.textVal8.TabIndex = 22;
            this.textVal8.TextChanged += new System.EventHandler(this.textVal8_TextChanged);
            // 
            // textVal7
            // 
            this.textVal7.Location = new System.Drawing.Point(36, 130);
            this.textVal7.Name = "textVal7";
            this.textVal7.Size = new System.Drawing.Size(46, 20);
            this.textVal7.TabIndex = 21;
            this.textVal7.TextChanged += new System.EventHandler(this.textVal7_TextChanged);
            // 
            // btnRng3
            // 
            this.btnRng3.BackColor = System.Drawing.Color.White;
            this.btnRng3.Location = new System.Drawing.Point(10, 94);
            this.btnRng3.Name = "btnRng3";
            this.btnRng3.Size = new System.Drawing.Size(22, 21);
            this.btnRng3.TabIndex = 19;
            this.btnRng3.UseVisualStyleBackColor = false;
            this.btnRng3.Click += new System.EventHandler(this.btnRng3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "to";
            // 
            // textVal6
            // 
            this.textVal6.Location = new System.Drawing.Point(107, 95);
            this.textVal6.Name = "textVal6";
            this.textVal6.Size = new System.Drawing.Size(46, 20);
            this.textVal6.TabIndex = 18;
            this.textVal6.TextChanged += new System.EventHandler(this.textVal6_TextChanged);
            // 
            // textVal5
            // 
            this.textVal5.Location = new System.Drawing.Point(36, 95);
            this.textVal5.Name = "textVal5";
            this.textVal5.Size = new System.Drawing.Size(46, 20);
            this.textVal5.TabIndex = 17;
            this.textVal5.TextChanged += new System.EventHandler(this.textVal5_TextChanged);
            // 
            // btnRng2
            // 
            this.btnRng2.BackColor = System.Drawing.Color.White;
            this.btnRng2.Location = new System.Drawing.Point(10, 61);
            this.btnRng2.Name = "btnRng2";
            this.btnRng2.Size = new System.Drawing.Size(22, 21);
            this.btnRng2.TabIndex = 15;
            this.btnRng2.UseVisualStyleBackColor = false;
            this.btnRng2.Click += new System.EventHandler(this.btnRng2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "to";
            // 
            // textVal4
            // 
            this.textVal4.Location = new System.Drawing.Point(107, 62);
            this.textVal4.Name = "textVal4";
            this.textVal4.Size = new System.Drawing.Size(46, 20);
            this.textVal4.TabIndex = 14;
            this.textVal4.TextChanged += new System.EventHandler(this.textVal4_TextChanged);
            // 
            // textVal3
            // 
            this.textVal3.Location = new System.Drawing.Point(36, 62);
            this.textVal3.Name = "textVal3";
            this.textVal3.Size = new System.Drawing.Size(46, 20);
            this.textVal3.TabIndex = 13;
            this.textVal3.TextChanged += new System.EventHandler(this.textVal3_TextChanged);
            // 
            // btnRng1
            // 
            this.btnRng1.BackColor = System.Drawing.Color.White;
            this.btnRng1.Location = new System.Drawing.Point(10, 30);
            this.btnRng1.Name = "btnRng1";
            this.btnRng1.Size = new System.Drawing.Size(22, 21);
            this.btnRng1.TabIndex = 12;
            this.btnRng1.UseVisualStyleBackColor = false;
            this.btnRng1.Click += new System.EventHandler(this.btnRng1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "to";
            // 
            // textVal2
            // 
            this.textVal2.Location = new System.Drawing.Point(107, 31);
            this.textVal2.Name = "textVal2";
            this.textVal2.Size = new System.Drawing.Size(46, 20);
            this.textVal2.TabIndex = 2;
            this.textVal2.TextChanged += new System.EventHandler(this.textVal2_TextChanged);
            // 
            // textVal1
            // 
            this.textVal1.Location = new System.Drawing.Point(36, 31);
            this.textVal1.Name = "textVal1";
            this.textVal1.Size = new System.Drawing.Size(46, 20);
            this.textVal1.TabIndex = 1;
            this.textVal1.TextChanged += new System.EventHandler(this.textVal1_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.AccessibleName = "";
            this.progressBar.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar.Location = new System.Drawing.Point(212, 337);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(383, 23);
            this.progressBar.TabIndex = 11;
            this.progressBar.Tag = "hola";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 92);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Export";
            // 
            // Form
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(644, 372);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Export Kml";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveValuesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textVal2;
        private System.Windows.Forms.TextBox textVal1;
        private System.Windows.Forms.Button btnRng1;
        private System.Windows.Forms.Button btnRng4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textVal8;
        private System.Windows.Forms.TextBox textVal7;
        private System.Windows.Forms.Button btnRng3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textVal6;
        private System.Windows.Forms.TextBox textVal5;
        private System.Windows.Forms.Button btnRng2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textVal4;
        private System.Windows.Forms.TextBox textVal3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRng5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textVal10;
        private System.Windows.Forms.TextBox textVal9;
    }
}

