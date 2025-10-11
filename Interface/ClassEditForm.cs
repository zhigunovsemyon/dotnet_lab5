namespace Interface
{
	/// <summary> Форма изменения информации о занятии </summary>
	public partial class ClassEditForm : Form
	{
		/// <summary> Конструктор формы </summary>
		/// <param name="class">Обрабатываемое занятие</param>
		public ClassEditForm(Electives.Class @class)
		{
			InitializeComponent();
			this.@class = @class;
		}

		/// <summary>
		/// Обработчик по запуске формы. 
		/// Наполняет поля формы данными из предмета, переданного в конструкторе
		/// </summary>
		private void set_boxes(object sender, EventArgs e)
		{
			this.ClassNameBox.Text = this.@class.name;
			this.LectionsInput.Value = this.@class.lections;
			this.PracticeInput.Value = this.@class.practices;
			this.LabsInput.Value = this.@class.lab_works;
		}

		/// <summary>
		/// Метод, заполняющий свойства предмета данными из полей формы.
		/// Вызывается при нажатии пользователем кнопки "ОК"
		/// </summary>
		private void get_from_boxes()
		{
			this.@class.name = this.ClassNameBox.Text;
			this.@class.lections = ((int)this.LectionsInput.Value);
			this.@class.practices = ((int)this.PracticeInput.Value);
			this.@class.lab_works = ((int)this.LabsInput.Value);
		}

		/// <summary> Свойство с занятием, обрабатываемым данной формой </summary>
		public Electives.Class @class { get; set; }

		/// <summary> Обработчик нажатия пользователем клавиши "ОК" </summary>
		private void OkButton_Click(object sender, EventArgs e)
		{
			get_from_boxes();

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		/// <summary>
		/// Очистка поля названия предмета от пробелов в начале и конце.
		/// Вызывается при завершении работы с полем
		/// </summary>
		private void ClassNameBox_LostFocus(object sender, EventArgs e)
		{
			this.ClassNameBox.Text = this.ClassNameBox.Text.Trim();
		}
	}
}
