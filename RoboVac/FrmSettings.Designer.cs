namespace RoboVac
{
    partial class FrmSettings
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
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudObstacles = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudScale = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudObstacles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudScale);
            this.groupBox1.Controls.Add(this.nudObstacles);
            this.groupBox1.Controls.Add(this.nudHeight);
            this.groupBox1.Controls.Add(this.nudWidth);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(305, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(23, 77);
            this.nudWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(88, 26);
            this.nudWidth.TabIndex = 0;
            this.nudWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(188, 77);
            this.nudHeight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(88, 26);
            this.nudHeight.TabIndex = 0;
            this.nudHeight.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "The size of the map";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of obstacles:";
            // 
            // nudObstacles
            // 
            this.nudObstacles.Location = new System.Drawing.Point(188, 121);
            this.nudObstacles.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudObstacles.Name = "nudObstacles";
            this.nudObstacles.Size = new System.Drawing.Size(88, 26);
            this.nudObstacles.TabIndex = 0;
            this.nudObstacles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(27, 230);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(249, 55);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Scale:";
            // 
            // nudScale
            // 
            this.nudScale.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudScale.Location = new System.Drawing.Point(188, 165);
            this.nudScale.Name = "nudScale";
            this.nudScale.Size = new System.Drawing.Size(88, 26);
            this.nudScale.TabIndex = 0;
            this.nudScale.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 376);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSettings";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudObstacles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudObstacles;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudScale;
    }
}

