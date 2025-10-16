namespace Interface
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStrip1 = new MenuStrip();
			toolStripMenuItemFile = new ToolStripMenuItem();
			toolStripMenuItemClose = new ToolStripMenuItem();
			toolStripMenuItemStudents = new ToolStripMenuItem();
			toolStripMenuItemAddStudent = new ToolStripMenuItem();
			toolStripMenuItemEditStudent = new ToolStripMenuItem();
			ClassesToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItemAddClass = new ToolStripMenuItem();
			toolStripMenuItemEditClass = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemFile, toolStripMenuItemStudents, ClassesToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItemFile
			// 
			toolStripMenuItemFile.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemClose });
			toolStripMenuItemFile.Name = "toolStripMenuItemFile";
			toolStripMenuItemFile.Size = new Size(48, 20);
			toolStripMenuItemFile.Text = "&Файл";
			// 
			// toolStripMenuItemClose
			// 
			toolStripMenuItemClose.Name = "toolStripMenuItemClose";
			toolStripMenuItemClose.Size = new Size(180, 22);
			toolStripMenuItemClose.Text = "&Выйти";
			toolStripMenuItemClose.Click += CloseButton_Click;
			// 
			// toolStripMenuItemStudents
			// 
			toolStripMenuItemStudents.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAddStudent, toolStripMenuItemEditStudent });
			toolStripMenuItemStudents.Name = "toolStripMenuItemStudents";
			toolStripMenuItemStudents.Size = new Size(71, 20);
			toolStripMenuItemStudents.Text = "&Студенты";
			// 
			// toolStripMenuItemAddStudent
			// 
			toolStripMenuItemAddStudent.Name = "toolStripMenuItemAddStudent";
			toolStripMenuItemAddStudent.Size = new Size(180, 22);
			toolStripMenuItemAddStudent.Text = "&Добавить";
			toolStripMenuItemAddStudent.Click += StudentAddtoolStripMenuItem_Click;
			// 
			// toolStripMenuItemEditStudent
			// 
			toolStripMenuItemEditStudent.Name = "toolStripMenuItemEditStudent";
			toolStripMenuItemEditStudent.Size = new Size(180, 22);
			toolStripMenuItemEditStudent.Text = "&Редактировать";
			toolStripMenuItemEditStudent.Click += StudentEditToolStripMenuItem_Click;
			// 
			// ClassesToolStripMenuItem
			// 
			ClassesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAddClass, toolStripMenuItemEditClass });
			ClassesToolStripMenuItem.Name = "ClassesToolStripMenuItem";
			ClassesToolStripMenuItem.Size = new Size(63, 20);
			ClassesToolStripMenuItem.Text = "&Занятия";
			// 
			// toolStripMenuItemAddClass
			// 
			toolStripMenuItemAddClass.Name = "toolStripMenuItemAddClass";
			toolStripMenuItemAddClass.Size = new Size(180, 22);
			toolStripMenuItemAddClass.Text = "&Добавить";
			toolStripMenuItemAddClass.Click += ClassAddStripMenuItem_Click;
			// 
			// toolStripMenuItemEditClass
			// 
			toolStripMenuItemEditClass.Name = "toolStripMenuItemEditClass";
			toolStripMenuItemEditClass.Size = new Size(180, 22);
			toolStripMenuItemEditClass.Text = "&Редактировать";
			toolStripMenuItemEditClass.Click += ClassEditStripMenuItem_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "MainForm";
			Text = "Факультативы";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem toolStripMenuItemFile;
		private ToolStripMenuItem toolStripMenuItemClose;
		private ToolStripMenuItem toolStripMenuItemStudents;
		private ToolStripMenuItem ClassesToolStripMenuItem;
		private ToolStripMenuItem toolStripMenuItemAddStudent;
		private ToolStripMenuItem toolStripMenuItemEditStudent;
		private ToolStripMenuItem toolStripMenuItemAddClass;
		private ToolStripMenuItem toolStripMenuItemEditClass;
	}
}
