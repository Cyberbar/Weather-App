namespace Weather_App
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
            lab_description = new Label();
            lab_humidity = new Label();
            lab_detail = new Label();
            btn_close = new Button();
            pic_icon = new PictureBox();
            lab_condition = new Label();
            lab_sunrise = new Label();
            sunrise = new Label();
            sunset = new Label();
            lab_sunset = new Label();
            lab_pressure = new Label();
            windspeed = new Label();
            lab_windspeed = new Label();
            label6 = new Label();
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
            // lab_description
            // 
            lab_description.AutoSize = true;
            lab_description.BackColor = Color.Transparent;
            lab_description.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            lab_description.ForeColor = Color.White;
            lab_description.Location = new Point(304, 663);
            lab_description.Name = "lab_description";
            lab_description.Size = new Size(163, 28);
            lab_description.TabIndex = 3;
            lab_description.Text = "Description:";
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
            // 
            // pic_icon
            // 
            pic_icon.BackColor = Color.Transparent;
            pic_icon.Location = new Point(304, 478);
            pic_icon.Name = "pic_icon";
            pic_icon.Size = new Size(150, 75);
            pic_icon.TabIndex = 7;
            pic_icon.TabStop = false;
            // 
            // lab_condition
            // 
            lab_condition.AutoSize = true;
            lab_condition.BackColor = Color.Transparent;
            lab_condition.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            lab_condition.ForeColor = Color.White;
            lab_condition.Location = new Point(304, 743);
            lab_condition.Name = "lab_condition";
            lab_condition.Size = new Size(139, 28);
            lab_condition.TabIndex = 8;
            lab_condition.Text = "Condition:";
            lab_condition.Click += lab_Condition_Click;
            // 
            // lab_sunrise
            // 
            lab_sunrise.AutoSize = true;
            lab_sunrise.BackColor = Color.Transparent;
            lab_sunrise.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            lab_sunrise.ForeColor = Color.White;
            lab_sunrise.Location = new Point(916, 663);
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
            sunrise.Location = new Point(786, 663);
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
            sunset.Location = new Point(786, 759);
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
            lab_sunset.Location = new Point(916, 759);
            lab_sunset.Name = "lab_sunset";
            lab_sunset.Size = new Size(65, 28);
            lab_sunset.TabIndex = 12;
            lab_sunset.Text = "N/A";
            // 
            // lab_pressure
            // 
            lab_pressure.AutoSize = true;
            lab_pressure.BackColor = Color.Transparent;
            lab_pressure.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            lab_pressure.ForeColor = Color.White;
            lab_pressure.Location = new Point(779, 918);
            lab_pressure.Name = "lab_pressure";
            lab_pressure.Size = new Size(132, 28);
            lab_pressure.TabIndex = 13;
            lab_pressure.Text = "Pressure:";
            // 
            // windspeed
            // 
            windspeed.AutoSize = true;
            windspeed.BackColor = Color.Transparent;
            windspeed.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            windspeed.ForeColor = Color.White;
            windspeed.Location = new Point(786, 837);
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
            lab_windspeed.Location = new Point(1002, 837);
            lab_windspeed.Name = "lab_windspeed";
            lab_windspeed.Size = new Size(65, 28);
            lab_windspeed.TabIndex = 15;
            lab_windspeed.Text = "N/A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1002, 918);
            label6.Name = "label6";
            label6.Size = new Size(65, 28);
            label6.TabIndex = 16;
            label6.Text = "N/A";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1664, 1119);
            Controls.Add(label6);
            Controls.Add(lab_windspeed);
            Controls.Add(windspeed);
            Controls.Add(lab_pressure);
            Controls.Add(lab_sunset);
            Controls.Add(sunset);
            Controls.Add(sunrise);
            Controls.Add(lab_sunrise);
            Controls.Add(lab_condition);
            Controls.Add(pic_icon);
            Controls.Add(btn_close);
            Controls.Add(lab_detail);
            Controls.Add(lab_humidity);
            Controls.Add(lab_description);
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
        private Label lab_description;
        private Label lab_humidity;
        private Label lab_detail;
        private Button btn_close;
        private PictureBox pic_icon;
        private Label lab_condition;
        private Label lab_sunrise;
        private Label sunrise;
        private Label sunset;
        private Label lab_sunset;
        private Label lab_pressure;
        private Label windspeed;
        private Label lab_windspeed;
        private Label label6;
    }
}
