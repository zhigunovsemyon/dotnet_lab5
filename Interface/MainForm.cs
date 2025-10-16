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
			var form = new FormStudent(student);
			if (DialogResult.OK != form.ShowDialog()) {
				return;
			}

			if (form.Student == null) {
				MessageBox.Show(
					"StudentEditForm вернула null",
					"Внутренняя ошибка"
				);
				return;
			}
			if (!form.Student.IsValid) {
				MessageBox.Show("Неправильно указаны данные!");
				return;
			}

			this.student_ = form.Student;
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
			AddOrEditStudent(student_.Clone());
		}

		/// <summary>
		/// Метод для вызова и обработки результата работы формы изменения занятия
		/// </summary>
		/// <param name="class">Обрабатываемое занятие</param>
		private void AddOrEditClass(Electives.Class @class)
		{			
			var form = new FormClass(@class);
			if (DialogResult.OK != form.ShowDialog()) {
				return;
			}

			if (form.Class == null) {
				MessageBox.Show(
					"ClassEditForm вернула null",
					"Внутренняя ошибка"
				);
				return;
			}
			if (!form.Class.IsValid) {
				MessageBox.Show("Неправильно указаны данные!");
				return;
			}

			this.@class_ = form.Class;
		}

		/// <summary> Обработчик создания нового занятия </summary>
		private void ClassAddStripMenuItem_Click (object sender, EventArgs e)
		{
			AddOrEditClass(new Class());
		}

		/// <summary> Обработчик редактирования существующего занятия </summary>
		private void ClassEditStripMenuItem_Click (object sender, EventArgs e)
		{
			AddOrEditClass(class_.Clone());
		}
	}
}
