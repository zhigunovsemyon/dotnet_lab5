namespace Interface
{
	partial class StudentEditForm
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
			if (disposing && (components != null)) {
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
			SurnameBox = new TextBox();
			NameBox = new TextBox();
			PatronimBox = new TextBox();
			PhoneBox = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label5 = new Label();
			ok_button = new Button();
			close_button = new Button();
			AddressBox = new GroupBox();
			label9 = new Label();
			BuildingBox = new TextBox();
			label8 = new Label();
			HouseBox = new TextBox();
			label7 = new Label();
			StreetBox = new TextBox();
			label6 = new Label();
			CityBox = new TextBox();
			label4 = new Label();
			RegionBox = new TextBox();
			AddressBox.SuspendLayout();
			SuspendLayout();
			// 
			// SurnameBox
			// 
			SurnameBox.Location = new Point(12, 35);
			SurnameBox.MaxLength = 40;
			SurnameBox.Name = "SurnameBox";
			SurnameBox.Size = new Size(178, 23);
			SurnameBox.TabIndex = 0;
			SurnameBox.LostFocus += trim_all_textbox;
			// 
			// NameBox
			// 
			NameBox.Location = new Point(12, 82);
			NameBox.MaxLength = 28;
			NameBox.Name = "NameBox";
			NameBox.Size = new Size(178, 23);
			NameBox.TabIndex = 1;
			NameBox.LostFocus += trim_all_textbox;
			// 
			// PatronimBox
			// 
			PatronimBox.Location = new Point(12, 132);
			PatronimBox.MaxLength = 28;
			PatronimBox.Name = "PatronimBox";
			PatronimBox.Size = new Size(178, 23);
			PatronimBox.TabIndex = 2;
			PatronimBox.LostFocus += trim_all_textbox;
			// 
			// PhoneBox
			// 
			PhoneBox.Location = new Point(12, 185);
			PhoneBox.MaxLength = 20;
			PhoneBox.Name = "PhoneBox";
			PhoneBox.Size = new Size(178, 23);
			PhoneBox.TabIndex = 3;
			PhoneBox.LostFocus += trim_all_textbox;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 17);
			label1.Name = "label1";
			label1.Size = new Size(58, 15);
			label1.TabIndex = 5;
			label1.Text = "&Фамилия";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 64);
			label2.Name = "label2";
			label2.Size = new Size(31, 15);
			label2.TabIndex = 6;
			label2.Text = "&Имя";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 114);
			label3.Name = "label3";
			label3.Size = new Size(151, 15);
			label3.TabIndex = 7;
			label3.Text = "&Отчество (необязательно)";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 167);
			label5.Name = "label5";
			label5.Size = new Size(55, 15);
			label5.TabIndex = 9;
			label5.Text = "&Телефон";
			// 
			// ok_button
			// 
			ok_button.DialogResult = DialogResult.OK;
			ok_button.Location = new Point(280, 243);
			ok_button.Name = "ok_button";
			ok_button.Size = new Size(75, 23);
			ok_button.TabIndex = 11;
			ok_button.Text = "OK";
			ok_button.UseVisualStyleBackColor = true;
			ok_button.Click += ok_button_Click;
			// 
			// close_button
			// 
			close_button.DialogResult = DialogResult.Cancel;
			close_button.Location = new Point(361, 243);
			close_button.Name = "close_button";
			close_button.Size = new Size(75, 23);
			close_button.TabIndex = 12;
			close_button.Text = "Закрыть";
			close_button.UseVisualStyleBackColor = true;
			// 
			// AddressBox
			// 
			AddressBox.Controls.Add(label9);
			AddressBox.Controls.Add(BuildingBox);
			AddressBox.Controls.Add(label8);
			AddressBox.Controls.Add(HouseBox);
			AddressBox.Controls.Add(label7);
			AddressBox.Controls.Add(StreetBox);
			AddressBox.Controls.Add(label6);
			AddressBox.Controls.Add(CityBox);
			AddressBox.Controls.Add(label4);
			AddressBox.Controls.Add(RegionBox);
			AddressBox.Location = new Point(205, 0);
			AddressBox.Name = "AddressBox";
			AddressBox.Size = new Size(250, 226);
			AddressBox.TabIndex = 10;
			AddressBox.TabStop = false;
			AddressBox.Text = "Адрес студента";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(88, 168);
			label9.Name = "label9";
			label9.Size = new Size(153, 15);
			label9.TabIndex = 21;
			label9.Text = "&Строение (необязательно)";
			// 
			// BuildingBox
			// 
			BuildingBox.Location = new Point(88, 186);
			BuildingBox.MaxLength = 5;
			BuildingBox.Name = "BuildingBox";
			BuildingBox.Size = new Size(146, 23);
			BuildingBox.TabIndex = 20;
			BuildingBox.LostFocus += trim_all_textbox;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(6, 168);
			label8.Name = "label8";
			label8.Size = new Size(76, 15);
			label8.TabIndex = 19;
			label8.Text = "&Номер дома";
			// 
			// HouseBox
			// 
			HouseBox.Location = new Point(6, 186);
			HouseBox.MaxLength = 5;
			HouseBox.Name = "HouseBox";
			HouseBox.Size = new Size(76, 23);
			HouseBox.TabIndex = 18;
			HouseBox.LostFocus += trim_all_textbox;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(6, 115);
			label7.Name = "label7";
			label7.Size = new Size(41, 15);
			label7.TabIndex = 17;
			label7.Text = "&Улица";
			// 
			// StreetBox
			// 
			StreetBox.Location = new Point(6, 133);
			StreetBox.MaxLength = 40;
			StreetBox.Name = "StreetBox";
			StreetBox.Size = new Size(228, 23);
			StreetBox.TabIndex = 16;
			StreetBox.LostFocus += trim_all_textbox;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(6, 65);
			label6.Name = "label6";
			label6.Size = new Size(40, 15);
			label6.TabIndex = 15;
			label6.Text = "&Город";
			// 
			// CityBox
			// 
			CityBox.Location = new Point(6, 83);
			CityBox.MaxLength = 40;
			CityBox.Name = "CityBox";
			CityBox.Size = new Size(228, 23);
			CityBox.TabIndex = 14;
			CityBox.LostFocus += trim_all_textbox;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 18);
			label4.Name = "label4";
			label4.Size = new Size(46, 15);
			label4.TabIndex = 13;
			label4.Text = "&Регион";
			// 
			// RegionBox
			// 
			RegionBox.Location = new Point(6, 36);
			RegionBox.MaxLength = 40;
			RegionBox.Name = "RegionBox";
			RegionBox.Size = new Size(228, 23);
			RegionBox.TabIndex = 0;
			RegionBox.LostFocus += trim_all_textbox;
			// 
			// StudentEditForm
			// 
			AcceptButton = ok_button;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = close_button;
			ClientSize = new Size(458, 278);
			Controls.Add(AddressBox);
			Controls.Add(close_button);
			Controls.Add(ok_button);
			Controls.Add(label5);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(PhoneBox);
			Controls.Add(PatronimBox);
			Controls.Add(NameBox);
			Controls.Add(SurnameBox);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			Name = "StudentEditForm";
			ShowIcon = false;
			Text = "Информация о студенте";
			Load += set_boxes;
			AddressBox.ResumeLayout(false);
			AddressBox.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox SurnameBox;
		private TextBox NameBox;
		private TextBox PatronimBox;
		private TextBox PhoneBox;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label5;
		private Button ok_button;
		private Button close_button;
		private GroupBox AddressBox;
		private Label label6;
		private TextBox CityBox;
		private Label label4;
		private TextBox RegionBox;
		private Label label9;
		private TextBox BuildingBox;
		private Label label8;
		private TextBox HouseBox;
		private Label label7;
		private TextBox StreetBox;
	}
}