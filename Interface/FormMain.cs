using Electives;

namespace Interface;

/// <summary> Основная форма </summary>
public partial class FormMain : Form
{
	public FormMain () => this.InitializeComponent();

	/// <summary> Метод для закрытия приложения через пункт меню </summary>
	private void CloseButton_Click (object sender, EventArgs e) => this.Close();

	/// <summary>
	/// Метод для вызова и обработки результата работы формы изменения студента
	/// </summary>
	/// <param name="student">Обрабатываемый студент</param>
	private void AddOrEditStudent (Electives.Student? student)
	{
		if (student == null) {
			MessageBox.Show(
				"AddOrEditStudent: student is null",
				"Внутренняя ошибка"
			);
			return;
		}

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

		Journal.ListStudents[form.Student.Id] = form.Student;
		UpdateStudentListView();
	}

	/// <summary> Обработчик поля создания нового студента </summary>
	private void StudentAddtoolStripMenuItem_Click (object sender, EventArgs e)
		=> this.AddOrEditStudent(new Student()); //Вызов формы на чистом студенте

	/// <summary> Обработчик редактирования существующего студента </summary>
	private void StudentEditToolStripMenuItem_Click (object sender, EventArgs e)
	{
		var selectedItemsList = listViewStudents.SelectedItems;
		if (selectedItemsList.Count <= 0) {
			MessageBox.Show("Не выбран редактируемый элемент");
			return;
		}
		//Вызов формы на копии исходного студента
		this.AddOrEditStudent(selectedItemsList[0].Tag as Electives.Student);
	}

	/// <summary>
	/// Метод для вызова и обработки результата работы формы изменения занятия
	/// </summary>
	/// <param name="class">Обрабатываемое занятие</param>
	private void AddOrEditClass (Electives.Class? @class)
	{
		if (@class == null) {
			MessageBox.Show(
				"AddOrEditClass: class is null",
				"Внутренняя ошибка"
			);
			return;
		}

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

		Journal.ListClasses[form.Class.Id] = form.Class;
		UpdateClassListView();
	}

	/// <summary> Обновление списка студентов в форме </summary>
	private void UpdateStudentListView ()
	{
		this.listViewStudents.Items.Clear();

		foreach (var kvPair in Journal.ListStudents) {
			this.listViewStudents.Items.Add(CreateStudentListViewItem(kvPair.Value));
		}
	}

	/// <summary> Создание записи со студентом для списка в форме </summary>
	/// <param name="student">Студент из которого создаётся запись</param>
	/// <returns> Запись для добавления </returns>
	private static ListViewItem CreateStudentListViewItem (Electives.Student student)
	{
		ListViewItem item = new() { Tag = student, Text = student.Surname };

		item.SubItems.Add(student.Name);
		item.SubItems.Add(student.Patronim);
		item.SubItems.Add(student.Phone);
		item.SubItems.Add(student.Address.ToString());

		return item;
	}

	/// <summary> Обработчик создания нового занятия </summary>
	private void ClassAddStripMenuItem_Click (object sender, EventArgs e)
		=> this.AddOrEditClass(new Class());

	/// <summary> Обработчик редактирования существующего занятия </summary>
	private void ClassEditStripMenuItem_Click (object sender, EventArgs e)
	{
		if (listViewClasses.SelectedItems.Count <= 0) {
			MessageBox.Show("Не выбран редактируемый элемент");
			return;
		}
		this.AddOrEditClass(listViewClasses.SelectedItems[0].Tag as Electives.Class);

	}

	/// <summary> Обновление списка занятий в форме </summary>
	private void UpdateClassListView ()
	{
		this.listViewClasses.Items.Clear();

		foreach (var kvPair in Journal.ListClasses) {
			this.listViewClasses.Items.Add(CreateClassListViewItem(kvPair.Value));
		}
	}

	/// <summary> Создание элемента списка занятий для формы </summary>
	/// <param name="class">Предмет, из которого создаётся запись</param>
	/// <returns>Созданная запись</returns>
	private static ListViewItem CreateClassListViewItem (Electives.Class @class)
	{
		var item = new ListViewItem { Tag = @class, Text = @class.Name };

		item.SubItems.Add(@class.Lections.ToString());
		item.SubItems.Add(@class.LabWorks.ToString());
		item.SubItems.Add(@class.Practices.ToString());

		return item;
	}

	/// <summary> Ивент для двойного нажатия по студенту в форме </summary>
	/// <param name="sender"> Список студентов в форме </param>
	/// <param name="e"> Параметры мыши </param>
	private void listViewStudents_MouseDoubleClick (object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left) {
			return;
		}
		if (sender is not ListView list) {
			MessageBox.Show("sender is not ListView or null");
			return;
		}

		this.AddOrEditStudent(list.SelectedItems[0].Tag as Electives.Student);
	}

	/// <summary> Ивент для двойного нажатия по предмету в форме </summary>
	/// <param name="sender"> Список предмету в форме </param>
	/// <param name="e"> Параметры мыши </param>
	private void listViewClasses_MouseDoubleClick (object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left) {
			return;
		}
		if (sender is not ListView list) {
			MessageBox.Show("sender is not ListView or null");
			return;
		}

		this.AddOrEditClass(list.SelectedItems[0].Tag as Electives.Class);
	}

	private void PlanAddStripMenuItem_Click (object sender, EventArgs e)
	{
		new FormPlan().Show();
	}

	private void PlanEditStripMenuItem_Click (object sender, EventArgs e)
	{
		new FormPlan().Show();
	}
}
