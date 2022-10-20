namespace WinFormsApp_Example
{
	public partial class MainForm : Form
	{
		public List<Worker> Workers { get; set; }
		public MainForm()
		{
			InitializeComponent();
			Workers = new List<Worker>
			{
				new Manager(3, "Грищенко Дмитро", 21),
				new Developer(4, "Горб Павло", "С#", 2),
				new Developer(5, "Михайлов Олександр", "С#", 5),
				new Manager(1, "Овчарчин Роман", 2),
				new Developer(6, "Харченко Богдан", "Java", 6),
				new Manager(2, "Рудовський Петро", 6),
				new Developer(7, "Шидловський Андрій", "С++", 1)
			};
			workerBindingSource.DataSource = Workers;
			dataGridView.Columns["Id"].Visible = false;
		}

		private void toolStripAdd_Click(object sender, EventArgs e)
		{
			var maxId = Workers.Count == 0 ? 0 : Workers.Max(w => w.Id);
			var newWorkerForm = new FormAddNewWorker(maxId);
			if (newWorkerForm.ShowDialog() == DialogResult.OK)
			{
				workerBindingSource.Add(newWorkerForm.NewWorker);
				MessageBox.Show(@"Додано нового співробітника");
			}
			else
			{
				MessageBox.Show(@"Додавання нового співробітника скасовано");
			}
		}

		private void toolStripRemove_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count > 0)
			{
				workerBindingSource.RemoveCurrent();
			}
		}
	}
}