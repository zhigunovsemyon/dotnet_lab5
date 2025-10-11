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
		private void InitializeComponent ()
		{
			menuStrip1 = new MenuStrip();
			FileToolStripMenuItem = new ToolStripMenuItem();
			CloseButton = new ToolStripMenuItem();
			StudentsToolStripMenuItem = new ToolStripMenuItem();
			StudentAddtoolStripMenuItem = new ToolStripMenuItem();
			StudentEditToolStripMenuItem = new ToolStripMenuItem();
			ClassesToolStripMenuItem = new ToolStripMenuItem();
			ClassAddStripMenuItem = new ToolStripMenuItem();
			ClassEditStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, StudentsToolStripMenuItem, ClassesToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// FileToolStripMenuItem
			// 
			FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CloseButton });
			FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			FileToolStripMenuItem.Size = new Size(48, 20);
			FileToolStripMenuItem.Text = "&Файл";
			// 
			// CloseButton
			// 
			CloseButton.Name = "CloseButton";
			CloseButton.Size = new Size(109, 22);
			CloseButton.Text = "&Выйти";
			CloseButton.Click += CloseButton_Click;
			// 
			// StudentsToolStripMenuItem
			// 
			StudentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { StudentAddtoolStripMenuItem, StudentEditToolStripMenuItem });
			StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem";
			StudentsToolStripMenuItem.Size = new Size(71, 20);
			StudentsToolStripMenuItem.Text = "&Студенты";
			// 
			// StudentAddtoolStripMenuItem
			// 
			StudentAddtoolStripMenuItem.Name = "StudentAddtoolStripMenuItem";
			StudentAddtoolStripMenuItem.Size = new Size(154, 22);
			StudentAddtoolStripMenuItem.Text = "&Добавить";
			StudentAddtoolStripMenuItem.Click += StudentAddtoolStripMenuItem_Click;
			// 
			// StudentEditToolStripMenuItem
			// 
			StudentEditToolStripMenuItem.Name = "StudentEditToolStripMenuItem";
			StudentEditToolStripMenuItem.Size = new Size(154, 22);
			StudentEditToolStripMenuItem.Text = "&Редактировать";
			StudentEditToolStripMenuItem.Click += StudentEditToolStripMenuItem_Click;
			// 
			// ClassesToolStripMenuItem
			// 
			ClassesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ClassAddStripMenuItem, ClassEditStripMenuItem });
			ClassesToolStripMenuItem.Name = "ClassesToolStripMenuItem";
			ClassesToolStripMenuItem.Size = new Size(63, 20);
			ClassesToolStripMenuItem.Text = "&Занятия";
			// 
			// ClassAddStripMenuItem
			// 
			ClassAddStripMenuItem.Name = "ClassAddStripMenuItem";
			ClassAddStripMenuItem.Size = new Size(180, 22);
			ClassAddStripMenuItem.Text = "&Добавить";
			ClassAddStripMenuItem.Click += ClassAddStripMenuItem_Click;
			// 
			// ClassEditStripMenuItem
			// 
			ClassEditStripMenuItem.Name = "ClassEditStripMenuItem";
			ClassEditStripMenuItem.Size = new Size(180, 22);
			ClassEditStripMenuItem.Text = "&Редактировать";
			ClassEditStripMenuItem.Click += ClassEditStripMenuItem_Click;
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
		private ToolStripMenuItem FileToolStripMenuItem;
		private ToolStripMenuItem CloseButton;
		private ToolStripMenuItem StudentsToolStripMenuItem;
		private ToolStripMenuItem ClassesToolStripMenuItem;
		private ToolStripMenuItem StudentAddtoolStripMenuItem;
		private ToolStripMenuItem StudentEditToolStripMenuItem;
		private ToolStripMenuItem ClassAddStripMenuItem;
		private ToolStripMenuItem ClassEditStripMenuItem;
	}
}
