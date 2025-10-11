using Electives;

namespace Interface
{
	/// <summary> Основная форма </summary>
	public partial class MainForm : Form
	{
		/// <summary> Внутреннее поле со студентом </summary>
		private Electives.Student student_ = new();

		/// <summary> Внутреннее поле с занятием </summary>
		private Electives.Class class_ = new();

		public MainForm ()
		{
			InitializeComponent();
		}

		/// <summary> Метод для закрытия приложения через пункт меню </summary>
		private void CloseButton_Click (object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Метод для вызова и обработки результата работы формы изменения студента
		/// </summary>
		/// <param name="student">Обрабатываемый студент</param>
		private void AddOrEditStudent (Electives.Student student)
		{
			var form = new StudentEditForm(student);
			if (DialogResult.OK != form.ShowDialog()) {
				return;
			}

			if (form.student == null) {
				MessageBox.Show(
					"StudentEditForm вернула null",
					"Внутренняя ошибка"
				);
				return;
			}
			if (!form.student.IsValid) {
				MessageBox.Show("Неправильно указаны данные!");
				return;
			}

			this.student_ = form.student;
		}

		/// <summary> Обработчик поля создания нового студента </summary>
		private void StudentAddtoolStripMenuItem_Click (object sender, EventArgs e)
		{
			//Вызов формы на чистом студенте
			AddOrEditStudent(new Student());
		}

		/// <summary> Обработчик редактирования существующего студента </summary>
		private void StudentEditToolStripMenuItem_Click (object sender, EventArgs e)
		{
			//Вызов формы на копии исходного студента
			AddOrEditStudent(student_.clone());
		}

		/// <summary>
		/// Метод для вызова и обработки результата работы формы изменения занятия
		/// </summary>
		/// <param name="class">Обрабатываемое занятие</param>
		private void AddOrEditClass(Electives.Class @class)
		{			
			var form = new ClassEditForm(@class);
			if (DialogResult.OK != form.ShowDialog()) {
				return;
			}

			if (form.@class == null) {
				MessageBox.Show(
					"ClassEditForm вернула null",
					"Внутренняя ошибка"
				);
				return;
			}
			if (!form.@class.IsValid) {
				MessageBox.Show("Неправильно указаны данные!");
				return;
			}

			this.@class_ = form.@class;
		}

		/// <summary> Обработчик создания нового занятия </summary>
		private void ClassAddStripMenuItem_Click (object sender, EventArgs e)
		{
			AddOrEditClass(new Class());
		}

		/// <summary> Обработчик редактирования существующего занятия </summary>
		private void ClassEditStripMenuItem_Click (object sender, EventArgs e)
		{
			AddOrEditClass(class_.clone());
		}
	}
}
