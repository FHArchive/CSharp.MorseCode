namespace MorseCodeWinForm
{
    partial class MorseCode
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.RunBtn = new System.Windows.Forms.Button();
            this.Encode = new System.Windows.Forms.RadioButton();
            this.Decode = new System.Windows.Forms.RadioButton();
            this.Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.BinWav = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BinWav)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Converts text to and from morse code and displays the binary wave";
            // 
            // RunBtn
            // 
            this.RunBtn.Location = new System.Drawing.Point(260, 56);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(75, 23);
            this.RunBtn.TabIndex = 1;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.run_Click);
            // 
            // Encode
            // 
            this.Encode.AutoSize = true;
            this.Encode.Location = new System.Drawing.Point(16, 39);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(86, 17);
            this.Encode.TabIndex = 2;
            this.Encode.TabStop = true;
            this.Encode.Text = "Encode Text";
            this.Encode.UseVisualStyleBackColor = true;
            // 
            // Decode
            // 
            this.Decode.AutoSize = true;
            this.Decode.Location = new System.Drawing.Point(16, 62);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(95, 17);
            this.Decode.TabIndex = 3;
            this.Decode.TabStop = true;
            this.Decode.Text = "Decode Morse";
            this.Decode.UseVisualStyleBackColor = true;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(16, 105);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(319, 73);
            this.Input.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Output";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(16, 199);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(319, 73);
            this.Output.TabIndex = 6;
            // 
            // BinWav
            // 
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.Interval = 1D;
            chartArea2.AxisY.Maximum = 1D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.BinWav.ChartAreas.Add(chartArea2);
            this.BinWav.Location = new System.Drawing.Point(16, 291);
            this.BinWav.Name = "BinWav";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.BinWav.Series.Add(series2);
            this.BinWav.Size = new System.Drawing.Size(319, 128);
            this.BinWav.TabIndex = 8;
            this.BinWav.Text = "Binary Wave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Binary Wave";
            // 
            // MorseCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 430);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BinWav);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Decode);
            this.Controls.Add(this.Encode);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MorseCode";
            this.Text = "Morse Code";
            ((System.ComponentModel.ISupportInitialize)(this.BinWav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.RadioButton Encode;
        private System.Windows.Forms.RadioButton Decode;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.DataVisualization.Charting.Chart BinWav;
        private System.Windows.Forms.Label label4;
    }
}

