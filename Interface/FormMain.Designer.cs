namespace Interface
{
	partial class FormMain
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
			toolStripMenuItemFile = new ToolStripMenuItem();
			toolStripMenuItemClose = new ToolStripMenuItem();
			toolStripMenuItemStudents = new ToolStripMenuItem();
			toolStripMenuItemAddStudent = new ToolStripMenuItem();
			toolStripMenuItemEditStudent = new ToolStripMenuItem();
			ClassesToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItemAddClass = new ToolStripMenuItem();
			toolStripMenuItemEditClass = new ToolStripMenuItem();
			планToolStripMenuItem = new ToolStripMenuItem();
			добавитьToolStripMenuItem = new ToolStripMenuItem();
			редактироватьToolStripMenuItem = new ToolStripMenuItem();
			tabControlMain = new TabControl();
			tabPageStudents = new TabPage();
			listViewStudents = new ListView();
			tabPageClasses = new TabPage();
			listViewClasses = new ListView();
			tabPagePlans = new TabPage();
			listViewPlans = new ListView();
			menuStrip1.SuspendLayout();
			tabControlMain.SuspendLayout();
			tabPageStudents.SuspendLayout();
			tabPageClasses.SuspendLayout();
			tabPagePlans.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemFile, toolStripMenuItemStudents, ClassesToolStripMenuItem, планToolStripMenuItem });
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
			toolStripMenuItemClose.Size = new Size(109, 22);
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
			toolStripMenuItemAddStudent.Size = new Size(154, 22);
			toolStripMenuItemAddStudent.Text = "&Добавить";
			toolStripMenuItemAddStudent.Click += StudentAddtoolStripMenuItem_Click;
			// 
			// toolStripMenuItemEditStudent
			// 
			toolStripMenuItemEditStudent.Name = "toolStripMenuItemEditStudent";
			toolStripMenuItemEditStudent.Size = new Size(154, 22);
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
			toolStripMenuItemAddClass.Size = new Size(154, 22);
			toolStripMenuItemAddClass.Text = "&Добавить";
			toolStripMenuItemAddClass.Click += ClassAddStripMenuItem_Click;
			// 
			// toolStripMenuItemEditClass
			// 
			toolStripMenuItemEditClass.Name = "toolStripMenuItemEditClass";
			toolStripMenuItemEditClass.Size = new Size(154, 22);
			toolStripMenuItemEditClass.Text = "&Редактировать";
			toolStripMenuItemEditClass.Click += ClassEditStripMenuItem_Click;
			// 
			// планToolStripMenuItem
			// 
			планToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, редактироватьToolStripMenuItem });
			планToolStripMenuItem.Name = "планToolStripMenuItem";
			планToolStripMenuItem.Size = new Size(48, 20);
			планToolStripMenuItem.Text = "&План";
			// 
			// добавитьToolStripMenuItem
			// 
			добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
			добавитьToolStripMenuItem.Size = new Size(154, 22);
			добавитьToolStripMenuItem.Text = "&Добавить";
			// 
			// редактироватьToolStripMenuItem
			// 
			редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
			редактироватьToolStripMenuItem.Size = new Size(154, 22);
			редактироватьToolStripMenuItem.Text = "&Редактировать";
			// 
			// tabControlMain
			// 
			tabControlMain.Controls.Add(tabPageStudents);
			tabControlMain.Controls.Add(tabPageClasses);
			tabControlMain.Controls.Add(tabPagePlans);
			tabControlMain.Dock = DockStyle.Fill;
			tabControlMain.Location = new Point(0, 24);
			tabControlMain.Name = "tabControlMain";
			tabControlMain.SelectedIndex = 0;
			tabControlMain.Size = new Size(800, 426);
			tabControlMain.TabIndex = 1;
			// 
			// tabPageStudents
			// 
			tabPageStudents.Controls.Add(listViewStudents);
			tabPageStudents.Location = new Point(4, 24);
			tabPageStudents.Name = "tabPageStudents";
			tabPageStudents.Padding = new Padding(3);
			tabPageStudents.Size = new Size(792, 398);
			tabPageStudents.TabIndex = 0;
			tabPageStudents.Text = "Студенты";
			tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// listViewStudents
			// 
			listViewStudents.Dock = DockStyle.Fill;
			listViewStudents.Location = new Point(3, 3);
			listViewStudents.Name = "listViewStudents";
			listViewStudents.Size = new Size(786, 392);
			listViewStudents.TabIndex = 0;
			listViewStudents.UseCompatibleStateImageBehavior = false;
			// 
			// tabPageClasses
			// 
			tabPageClasses.Controls.Add(listViewClasses);
			tabPageClasses.Location = new Point(4, 24);
			tabPageClasses.Name = "tabPageClasses";
			tabPageClasses.Padding = new Padding(3);
			tabPageClasses.Size = new Size(792, 398);
			tabPageClasses.TabIndex = 1;
			tabPageClasses.Text = "Занятия";
			tabPageClasses.UseVisualStyleBackColor = true;
			// 
			// listViewClasses
			// 
			listViewClasses.Dock = DockStyle.Fill;
			listViewClasses.Location = new Point(3, 3);
			listViewClasses.Name = "listViewClasses";
			listViewClasses.Size = new Size(786, 392);
			listViewClasses.TabIndex = 0;
			listViewClasses.UseCompatibleStateImageBehavior = false;
			// 
			// tabPagePlans
			// 
			tabPagePlans.Controls.Add(listViewPlans);
			tabPagePlans.Location = new Point(4, 24);
			tabPagePlans.Name = "tabPagePlans";
			tabPagePlans.Padding = new Padding(3);
			tabPagePlans.Size = new Size(792, 398);
			tabPagePlans.TabIndex = 2;
			tabPagePlans.Text = "Планы";
			tabPagePlans.UseVisualStyleBackColor = true;
			// 
			// listViewPlans
			// 
			listViewPlans.Dock = DockStyle.Fill;
			listViewPlans.Location = new Point(3, 3);
			listViewPlans.Name = "listViewPlans";
			listViewPlans.Size = new Size(786, 392);
			listViewPlans.TabIndex = 0;
			listViewPlans.UseCompatibleStateImageBehavior = false;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tabControlMain);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "FormMain";
			Text = "Факультативы";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			tabControlMain.ResumeLayout(false);
			tabPageStudents.ResumeLayout(false);
			tabPageClasses.ResumeLayout(false);
			tabPagePlans.ResumeLayout(false);
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
		private TabControl tabControlMain;
		private TabPage tabPageStudents;
		private TabPage tabPageClasses;
		private TabPage tabPagePlans;
		private ToolStripMenuItem планToolStripMenuItem;
		private ToolStripMenuItem добавитьToolStripMenuItem;
		private ToolStripMenuItem редактироватьToolStripMenuItem;
		private ListView listViewStudents;
		private ListView listViewClasses;
		private ListView listViewPlans;
	}
}
