namespace Electives
{
	/// <summary> Класс, содержащий информацию о студенте </summary>
	public class Student : IValidatable
	{
		/// <summary>
		/// Пустой конструтор студента с занулёнными полями
		/// </summary>
		public Student() { }

		/// <summary>
		/// Конструктор студента с параметрами
		/// </summary>
		/// <param name="address">Адрес</param>
		/// <param name="phone">Телефон</param>
		/// <param name="name">Имя</param>
		/// <param name="surname">Фамилия</param>
		/// <param name="patronim">Отчество (опционально)</param>
		public Student(Address address, string phone, string name,
			string surname, string patronim = "")
		{
			this.Name = name;
			this.Surname = surname;
			this.Patronim = patronim;
			this.Phone = phone;
			this.Address = address;
		}
		
		public bool IsValid => this.Address.IsValid && !(
			string.IsNullOrWhiteSpace(this.Name) ||
			string.IsNullOrWhiteSpace(this.Surname) ||
			string.IsNullOrWhiteSpace(this.Phone) ||
			this.Patronim == null
		);

		/// <summary> Имя студента </summary>
		public string Name { get; set; } = "";

		/// <summary>/ Фамилия студента </summary>
		public string Surname { get; set; } = "";

		/// <summary>/ Отчество студента </summary>
		public string Patronim { get; set; } = "";

		/// <summary> Адрес студента </summary>
		public Address Address { get; set; } = new Address();

		/// <summary>/ Телефон студента </summary>
		public string Phone { get; set; } = "";

		public override string ToString()
			=> $"{Surname} {Name} {Patronim} {Phone} {Address}";

		/// <summary> Создание копии данного студента </summary>
		/// <returns>Копия студента</returns>
		public Student clone()
		{
			return new Student
			{
				Address = this.Address.clone(),
				Name = this.Name,
				Surname = this.Surname,
				Patronim = this.Patronim,
				Phone = this.Phone
			};
		}
	}
}
