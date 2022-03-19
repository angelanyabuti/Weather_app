
namespace Weather_app
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblspeed = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtMaxtemp = new System.Windows.Forms.TextBox();
            this.txtMintemp = new System.Windows.Forms.TextBox();
            this.txtSpeedmph = new System.Windows.Forms.TextBox();
            this.txtSpeedkph = new System.Windows.Forms.TextBox();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblsunrise = new System.Windows.Forms.Label();
            this.lblsunset = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblwspeed = new System.Windows.Forms.Label();
            this.lblpressure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Condition";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(10, 107);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(39, 13);
            this.lblDetails.TabIndex = 2;
            this.lblDetails.Text = "Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sunrise";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblspeed
            // 
            this.lblspeed.AutoSize = true;
            this.lblspeed.Location = new System.Drawing.Point(10, 229);
            this.lblspeed.Name = "lblspeed";
            this.lblspeed.Size = new System.Drawing.Size(85, 13);
            this.lblspeed.TabIndex = 4;
            this.lblspeed.Text = "Wind speed kph";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 260);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 13);
            this.label.TabIndex = 5;
            this.label.Text = "Pressure";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cloud";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(120, 29);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(100, 20);
            this.txtcity.TabIndex = 7;
            // 
            // txtMaxtemp
            // 
            this.txtMaxtemp.Location = new System.Drawing.Point(120, 60);
            this.txtMaxtemp.Name = "txtMaxtemp";
            this.txtMaxtemp.Size = new System.Drawing.Size(100, 20);
            this.txtMaxtemp.TabIndex = 8;
            // 
            // txtMintemp
            // 
            this.txtMintemp.Location = new System.Drawing.Point(120, 100);
            this.txtMintemp.Name = "txtMintemp";
            this.txtMintemp.Size = new System.Drawing.Size(100, 20);
            this.txtMintemp.TabIndex = 9;
            // 
            // txtSpeedmph
            // 
            this.txtSpeedmph.Location = new System.Drawing.Point(243, 100);
            this.txtSpeedmph.Name = "txtSpeedmph";
            this.txtSpeedmph.Size = new System.Drawing.Size(100, 20);
            this.txtSpeedmph.TabIndex = 10;
            // 
            // txtSpeedkph
            // 
            this.txtSpeedkph.Location = new System.Drawing.Point(243, 140);
            this.txtSpeedkph.Name = "txtSpeedkph";
            this.txtSpeedkph.Size = new System.Drawing.Size(100, 20);
            this.txtSpeedkph.TabIndex = 11;
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(243, 186);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(100, 20);
            this.txtHumidity.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(515, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // lblsunrise
            // 
            this.lblsunrise.AutoSize = true;
            this.lblsunrise.Location = new System.Drawing.Point(131, 147);
            this.lblsunrise.Name = "lblsunrise";
            this.lblsunrise.Size = new System.Drawing.Size(27, 13);
            this.lblsunrise.TabIndex = 17;
            this.lblsunrise.Text = "N/A";
            // 
            // lblsunset
            // 
            this.lblsunset.AutoSize = true;
            this.lblsunset.Location = new System.Drawing.Point(131, 193);
            this.lblsunset.Name = "lblsunset";
            this.lblsunset.Size = new System.Drawing.Size(27, 13);
            this.lblsunset.TabIndex = 19;
            this.lblsunset.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Sunset";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblwspeed
            // 
            this.lblwspeed.AutoSize = true;
            this.lblwspeed.Location = new System.Drawing.Point(132, 229);
            this.lblwspeed.Name = "lblwspeed";
            this.lblwspeed.Size = new System.Drawing.Size(27, 13);
            this.lblwspeed.TabIndex = 20;
            this.lblwspeed.Text = "N/A";
            // 
            // lblpressure
            // 
            this.lblpressure.AutoSize = true;
            this.lblpressure.Location = new System.Drawing.Point(132, 260);
            this.lblpressure.Name = "lblpressure";
            this.lblpressure.Size = new System.Drawing.Size(27, 13);
            this.lblpressure.TabIndex = 21;
            this.lblpressure.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 505);
            this.Controls.Add(this.lblpressure);
            this.Controls.Add(this.lblwspeed);
            this.Controls.Add(this.lblsunset);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblsunrise);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtHumidity);
            this.Controls.Add(this.txtSpeedkph);
            this.Controls.Add(this.txtSpeedmph);
            this.Controls.Add(this.txtMintemp);
            this.Controls.Add(this.txtMaxtemp);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblspeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblspeed;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtMaxtemp;
        private System.Windows.Forms.TextBox txtMintemp;
        private System.Windows.Forms.TextBox txtSpeedmph;
        private System.Windows.Forms.TextBox txtSpeedkph;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblsunrise;
        private System.Windows.Forms.Label lblsunset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblwspeed;
        private System.Windows.Forms.Label lblpressure;
    }
}

