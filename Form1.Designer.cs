﻿namespace Weather_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TbCity = new TextBox();
            lab_City = new Label();
            Btn_Search = new Button();
            Detail = new Label();
            btn_close = new Button();
            pic_icon = new PictureBox();
            Condition = new Label();
            lab_sunrise = new Label();
            sunrise = new Label();
            sunset = new Label();
            lab_sunset = new Label();
            Pressure = new Label();
            windspeed = new Label();
            lab_windspeed = new Label();
            lab_pressure = new Label();
            lab_condition = new Label();
            lab_detail = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_icon).BeginInit();
            SuspendLayout();
            // 
            // TbCity
            // 
            TbCity.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            TbCity.Location = new Point(531, 363);
            TbCity.Name = "TbCity";
            TbCity.Size = new Size(536, 35);
            TbCity.TabIndex = 0;
            TbCity.Text = "boston";
            // 
            // lab_City
            // 
            lab_City.AutoSize = true;
            lab_City.BackColor = Color.Transparent;
            lab_City.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_City.ForeColor = Color.White;
            lab_City.Location = new Point(304, 370);
            lab_City.Name = "lab_City";
            lab_City.Size = new Size(71, 28);
            lab_City.TabIndex = 1;
            lab_City.Text = "City:";
            // 
            // Btn_Search
            // 
            Btn_Search.BackColor = Color.Transparent;
            Btn_Search.FlatStyle = FlatStyle.Flat;
            Btn_Search.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            Btn_Search.ForeColor = Color.White;
            Btn_Search.Location = new Point(1192, 362);
            Btn_Search.Name = "Btn_Search";
            Btn_Search.Size = new Size(112, 34);
            Btn_Search.TabIndex = 2;
            Btn_Search.Text = "Search";
            Btn_Search.UseVisualStyleBackColor = false;
            Btn_Search.Click += btn_Search_Click;
            // 
            // Detail
            // 
            Detail.AutoSize = true;
            Detail.BackColor = Color.Transparent;
            Detail.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            Detail.ForeColor = Color.White;
            Detail.Location = new Point(294, 729);
            Detail.Name = "Detail";
            Detail.Size = new Size(92, 28);
            Detail.TabIndex = 5;
            Detail.Text = "Detail:";
            // 
            // lab_humidity
            // 
            lab_humidity.AutoSize = true;
            lab_humidity.BackColor = Color.Transparent;
            lab_humidity.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            lab_humidity.ForeColor = Color.White;
            lab_humidity.Location = new Point(304, 819);
            lab_humidity.Name = "lab_humidity";
            lab_humidity.Size = new Size(129, 28);
            lab_humidity.TabIndex = 4;
            lab_humidity.Text = "Humidity:";
            // 
            // lab_detail
            // 
            lab_detail.AutoSize = true;
            lab_detail.BackColor = Color.Transparent;
            lab_detail.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            lab_detail.ForeColor = Color.White;
            lab_detail.Location = new Point(304, 893);
            lab_detail.Name = "lab_detail";
            lab_detail.Size = new Size(92, 28);
            lab_detail.TabIndex = 5;
            lab_detail.Text = "Detail:";
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Transparent;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.ForeColor = Color.White;
            btn_close.Location = new Point(1621, -2);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(46, 44);
            btn_close.TabIndex = 6;
            btn_close.Text = "X";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // pic_icon
            // 
            pic_icon.BackColor = Color.Transparent;
            pic_icon.Location = new Point(1210, 502);
            pic_icon.Name = "pic_icon";
            pic_icon.Size = new Size(363, 369);
            pic_icon.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_icon.TabIndex = 7;
            pic_icon.TabStop = false;
            // 
            // Condition
            // 
            Condition.AutoSize = true;
            Condition.BackColor = Color.Transparent;
            Condition.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            Condition.ForeColor = Color.White;
            Condition.Location = new Point(294, 663);
            Condition.Name = "Condition";
            Condition.Size = new Size(153, 28);
            Condition.TabIndex = 8;
            Condition.Text = "Conditions:";
            Condition.Click += lab_Condition_Click;
            // 
            // lab_sunrise
            // 
            lab_sunrise.AutoSize = true;
            lab_sunrise.BackColor = Color.Transparent;
            lab_sunrise.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            lab_sunrise.ForeColor = Color.White;
            lab_sunrise.Location = new Point(491, 787);
            lab_sunrise.Name = "lab_sunrise";
            lab_sunrise.Size = new Size(65, 28);
            lab_sunrise.TabIndex = 9;
            lab_sunrise.Text = "N/A";
            // 
            // sunrise
            // 
            sunrise.AutoSize = true;
            sunrise.BackColor = Color.Transparent;
            sunrise.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            sunrise.ForeColor = Color.White;
            sunrise.Location = new Point(294, 787);
            sunrise.Name = "sunrise";
            sunrise.Size = new Size(114, 28);
            sunrise.TabIndex = 10;
            sunrise.Text = "Sunrise:";
            // 
            // sunset
            // 
            sunset.AutoSize = true;
            sunset.BackColor = Color.Transparent;
            sunset.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            sunset.ForeColor = Color.White;
            sunset.Location = new Point(294, 858);
            sunset.Name = "sunset";
            sunset.Size = new Size(107, 28);
            sunset.TabIndex = 11;
            sunset.Text = "Sunset:";
            // 
            // lab_sunset
            // 
            lab_sunset.AutoSize = true;
            lab_sunset.BackColor = Color.Transparent;
            lab_sunset.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            lab_sunset.ForeColor = Color.White;
            lab_sunset.Location = new Point(491, 858);
            lab_sunset.Name = "lab_sunset";
            lab_sunset.Size = new Size(65, 28);
            lab_sunset.TabIndex = 12;
            lab_sunset.Text = "N/A";
            // 
            // Pressure
            // 
            Pressure.AutoSize = true;
            Pressure.BackColor = Color.Transparent;
            Pressure.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            Pressure.ForeColor = Color.White;
            Pressure.Location = new Point(763, 717);
            Pressure.Name = "Pressure";
            Pressure.Size = new Size(132, 28);
            Pressure.TabIndex = 13;
            Pressure.Text = "Pressure:";
            // 
            // windspeed
            // 
            windspeed.AutoSize = true;
            windspeed.BackColor = Color.Transparent;
            windspeed.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            windspeed.ForeColor = Color.White;
            windspeed.Location = new Point(763, 663);
            windspeed.Name = "windspeed";
            windspeed.Size = new Size(166, 28);
            windspeed.TabIndex = 14;
            windspeed.Text = "Wind Speed:";
            // 
            // lab_windspeed
            // 
            lab_windspeed.AutoSize = true;
            lab_windspeed.BackColor = Color.Transparent;
            lab_windspeed.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            lab_windspeed.ForeColor = Color.White;
            lab_windspeed.Location = new Point(992, 663);
            lab_windspeed.Name = "lab_windspeed";
            lab_windspeed.Size = new Size(65, 28);
            lab_windspeed.TabIndex = 15;
            lab_windspeed.Text = "N/A";
            // 
            // lab_pressure
            // 
            lab_pressure.AutoSize = true;
            lab_pressure.BackColor = Color.Transparent;
            lab_pressure.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            lab_pressure.ForeColor = Color.White;
            lab_pressure.Location = new Point(992, 717);
            lab_pressure.Name = "lab_pressure";
            lab_pressure.Size = new Size(65, 28);
            lab_pressure.TabIndex = 16;
            lab_pressure.Text = "N/A";
            // 
            // lab_condition
            // 
            lab_condition.AutoSize = true;
            lab_condition.BackColor = Color.Transparent;
            lab_condition.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            lab_condition.ForeColor = Color.White;
            lab_condition.Location = new Point(491, 663);
            lab_condition.Name = "lab_condition";
            lab_condition.Size = new Size(65, 28);
            lab_condition.TabIndex = 17;
            lab_condition.Text = "N/A";
            // 
            // lab_detail
            // 
            lab_detail.AutoSize = true;
            lab_detail.BackColor = Color.Transparent;
            lab_detail.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            lab_detail.ForeColor = Color.White;
            lab_detail.Location = new Point(491, 729);
            lab_detail.Name = "lab_detail";
            lab_detail.Size = new Size(65, 28);
            lab_detail.TabIndex = 18;
            lab_detail.Text = "N/A";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1664, 1119);
            Controls.Add(lab_detail);
            Controls.Add(lab_condition);
            Controls.Add(lab_pressure);
            Controls.Add(lab_windspeed);
            Controls.Add(windspeed);
            Controls.Add(Pressure);
            Controls.Add(lab_sunset);
            Controls.Add(sunset);
            Controls.Add(sunrise);
            Controls.Add(lab_sunrise);
            Controls.Add(Condition);
            Controls.Add(pic_icon);
            Controls.Add(btn_close);
            Controls.Add(Detail);
            Controls.Add(Btn_Search);
            Controls.Add(lab_City);
            Controls.Add(TbCity);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pic_icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbCity;
        private Label lab_City;
        private Button Btn_Search;
        private Label Detail;
        private Button btn_close;
        private PictureBox pic_icon;
        private Label Condition;
        private Label lab_sunrise;
        private Label sunrise;
        private Label sunset;
        private Label lab_sunset;
        private Label Pressure;
        private Label windspeed;
        private Label lab_windspeed;
        private Label lab_pressure;
        private Label lab_condition;
        private Label lab_detail;
    }
}
