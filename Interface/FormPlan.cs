using Electives;

namespace Interface;

public partial class FormPlan : Form
{
	public Electives.Plan Plan { get; init; }
	public FormPlan (Electives.Plan plan)
	{
		this.Plan = plan;
		this.InitializeComponent();
	}

	private void buttonClose_Click (object sender, EventArgs e) => this.Close();

	private void buttonOK_Click (object sender, EventArgs e)
	{
		var selectedStudent = this.comboBoxStudents.SelectedItem as Electives.Student;
		var selectedClass = this.comboBoxClasses.SelectedItem as Electives.Class;
		var selectedMark = this.comboBoxMarks.SelectedItem as Electives.Mark;
		if (null == selectedClass || selectedStudent == null|| selectedMark == null) {

			this.DialogResult = DialogResult.Retry;
			return;
		}

		this.Plan.Class = selectedClass;
		this.Plan.Student = selectedStudent;
		this.Plan.Mark = selectedMark;

		this.DialogResult = DialogResult.OK;
		this.Close();
	}

	private void FormPlan_SetBoxes (object sender, EventArgs e)
	{
		foreach (var kvPair in Journal.ListClasses) { 
			this.comboBoxClasses.Items.Add(kvPair.Value);
		}

		foreach (var kvPair in Journal.ListStudents) {
			this.comboBoxStudents.Items.Add(kvPair.Value);
		}

		foreach (var posMark in Electives.Mark.Types){
			this.comboBoxMarks.Items.Add(posMark);
		}

		//todo: наполнение полей при редактировании существующего плана

		this.comboBoxMarks.SelectedIndex = (int)this.Plan.Mark.Value;
		this.comboBoxStudents.SelectedItem = this.Plan.Student;
		this.comboBoxClasses.SelectedItem = this.Plan.Class;
	}
}
