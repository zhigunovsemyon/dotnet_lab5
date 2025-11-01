
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
		this.DialogResult = DialogResult.OK;
		this.Close();
	}
}
