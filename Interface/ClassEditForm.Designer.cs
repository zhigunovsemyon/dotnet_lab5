namespace Interface
{
	partial class ClassEditForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			ClassNameBox = new TextBox();
			LectionsInput = new NumericUpDown();
			PracticeInput = new NumericUpDown();
			LabsInput = new NumericUpDown();
			OkButton = new Button();
			CloseButton = new Button();
			((System.ComponentModel.ISupportInitialize)LectionsInput).BeginInit();
			((System.ComponentModel.ISupportInitialize)PracticeInput).BeginInit();
			((System.ComponentModel.ISupportInitialize)LabsInput).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(17, 9);
			label1.Name = "label1";
			label1.Size = new Size(114, 15);
			label1.TabIndex = 0;
			label1.Text = "Название предмета";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(17, 53);
			label2.Name = "label2";
			label2.Size = new Size(190, 15);
			label2.TabIndex = 1;
			label2.Text = "Количество лекционных занятий";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(223, 9);
			label3.Name = "label3";
			label3.Size = new Size(186, 15);
			label3.TabIndex = 2;
			label3.Text = "Количество практических работ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(222, 51);
			label4.Name = "label4";
			label4.Size = new Size(191, 15);
			label4.TabIndex = 3;
			label4.Text = "Количество лабораторных работ";
			// 
			// ClassNameBox
			// 
			ClassNameBox.Location = new Point(17, 27);
			ClassNameBox.MaxLength = 60;
			ClassNameBox.Name = "ClassNameBox";
			ClassNameBox.Size = new Size(189, 23);
			ClassNameBox.TabIndex = 4;
			ClassNameBox.LostFocus += ClassNameBox_LostFocus;
			// 
			// LectionsInput
			// 
			LectionsInput.Location = new Point(17, 71);
			LectionsInput.Name = "LectionsInput";
			LectionsInput.Size = new Size(190, 23);
			LectionsInput.TabIndex = 5;
			// 
			// PracticeInput
			// 
			PracticeInput.Location = new Point(223, 27);
			PracticeInput.Name = "PracticeInput";
			PracticeInput.Size = new Size(190, 23);
			PracticeInput.TabIndex = 6;
			// 
			// LabsInput
			// 
			LabsInput.Location = new Point(222, 71);
			LabsInput.Name = "LabsInput";
			LabsInput.Size = new Size(190, 23);
			LabsInput.TabIndex = 7;
			// 
			// OkButton
			// 
			OkButton.Location = new Point(222, 115);
			OkButton.Name = "OkButton";
			OkButton.Size = new Size(95, 23);
			OkButton.TabIndex = 8;
			OkButton.Text = "ОК";
			OkButton.UseVisualStyleBackColor = true;
			OkButton.Click += OkButton_Click;
			// 
			// CloseButton
			// 
			CloseButton.Location = new Point(323, 115);
			CloseButton.Name = "CloseButton";
			CloseButton.Size = new Size(89, 23);
			CloseButton.TabIndex = 9;
			CloseButton.Text = "Закрыть";
			CloseButton.UseVisualStyleBackColor = true;
			// 
			// ClassEditForm
			// 
			AcceptButton = OkButton;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = CloseButton;
			ClientSize = new Size(433, 162);
			Controls.Add(CloseButton);
			Controls.Add(OkButton);
			Controls.Add(LabsInput);
			Controls.Add(PracticeInput);
			Controls.Add(LectionsInput);
			Controls.Add(ClassNameBox);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "ClassEditForm";
			ShowIcon = false;
			Text = "Информация о предмете";
			Load += set_boxes;
			((System.ComponentModel.ISupportInitialize)LectionsInput).EndInit();
			((System.ComponentModel.ISupportInitialize)PracticeInput).EndInit();
			((System.ComponentModel.ISupportInitialize)LabsInput).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox ClassNameBox;
		private NumericUpDown LectionsInput;
		private NumericUpDown PracticeInput;
		private NumericUpDown LabsInput;
		private Button OkButton;
		private Button CloseButton;
	}
}