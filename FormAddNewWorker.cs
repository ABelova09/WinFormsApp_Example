namespace WinFormsApp_Example
{
	public partial class FormAddNewWorker : Form
	{
		public Worker NewWorker { get; private set; }
		private int _newId;

		public FormAddNewWorker(int maxId)
		{
			InitializeComponent();
			_newId = maxId++;
			comboBoxWorkerType.SelectedIndex = 0;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			try
			{
				var count = Convert.ToInt32(textBoxExperienceYears.Text);
				if (comboBoxWorkerType.SelectedItem.ToString() == "Розробник")
				{
					NewWorker = new Developer(_newId, textBoxName.Text, textBoxLanguage.Text, count);
				}
				else
				{
					NewWorker = new Manager(_newId, textBoxName.Text, count);
				}
				DialogResult = DialogResult.OK;
				Close();
			}
			catch
			{
				MessageBox.Show(@"Неуспішна валідація даних!");
			}
		}

		private void comboBoxWorkerType_SelectedValueChanged(object sender, EventArgs e)
		{
			if(comboBoxWorkerType.SelectedItem.ToString() == "Розробник")
			{
				labelExperienceYears.Text = @"Досвід (в роках)";
				labelLanguage.Visible = textBoxLanguage.Visible = true;
			}
			else
			{
				labelExperienceYears.Text = @"К-ть проектів";
				labelLanguage.Visible = textBoxLanguage.Visible = false;
			}
		}
	}
}