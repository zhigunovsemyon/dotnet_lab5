namespace Interface
{
	partial class FormPlan
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
		private void InitializeComponent ()
		{
			this.labelStudent = new Label();
			this.labelClass = new Label();
			this.comboBoxStudents = new ComboBox();
			this.comboBoxClasses = new ComboBox();
			this.buttonOK = new Button();
			this.buttonClose = new Button();
			this.SuspendLayout();
			// 
			// labelStudent
			// 
			this.labelStudent.AutoSize = true;
			this.labelStudent.Location = new Point(12, 9);
			this.labelStudent.Name = "labelStudent";
			this.labelStudent.Size = new Size(50, 15);
			this.labelStudent.TabIndex = 0;
			this.labelStudent.Text = "Студент";
			// 
			// labelClass
			// 
			this.labelClass.AutoSize = true;
			this.labelClass.Location = new Point(12, 65);
			this.labelClass.Name = "labelClass";
			this.labelClass.Size = new Size(55, 15);
			this.labelClass.TabIndex = 1;
			this.labelClass.Text = "Предмет";
			// 
			// comboBoxStudents
			// 
			this.comboBoxStudents.FormattingEnabled = true;
			this.comboBoxStudents.Location = new Point(12, 27);
			this.comboBoxStudents.Name = "comboBoxStudents";
			this.comboBoxStudents.Size = new Size(272, 23);
			this.comboBoxStudents.TabIndex = 2;
			// 
			// comboBoxClasses
			// 
			this.comboBoxClasses.FormattingEnabled = true;
			this.comboBoxClasses.Location = new Point(12, 83);
			this.comboBoxClasses.Name = "comboBoxClasses";
			this.comboBoxClasses.Size = new Size(272, 23);
			this.comboBoxClasses.TabIndex = 3;
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new Point(128, 229);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new Size(75, 23);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += this.buttonOK_Click;
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new Point(209, 229);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new Size(75, 23);
			this.buttonClose.TabIndex = 5;
			this.buttonClose.Text = "Закрыть";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += this.buttonClose_Click;
			// 
			// FormPlan
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.CancelButton = this.buttonClose;
			this.ClientSize = new Size(306, 264);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.comboBoxClasses);
			this.Controls.Add(this.comboBoxStudents);
			this.Controls.Add(this.labelClass);
			this.Controls.Add(this.labelStudent);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FormPlan";
			this.ShowIcon = false;
			this.Text = "Информация об учебном плане";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private Label labelStudent;
		private Label labelClass;
		private ComboBox comboBoxStudents;
		private ComboBox comboBoxClasses;
		private Button buttonOK;
		private Button buttonClose;
	}
}