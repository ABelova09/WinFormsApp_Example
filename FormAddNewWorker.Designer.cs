namespace WinFormsApp_Example
{
	partial class FormAddNewWorker
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonAdd = new System.Windows.Forms.Button();
			this.comboBoxWorkerType = new System.Windows.Forms.ComboBox();
			this.labelExperienceYears = new System.Windows.Forms.Label();
			this.labelLanguage = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxExperienceYears = new System.Windows.Forms.TextBox();
			this.textBoxLanguage = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(12, 14);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(135, 33);
			this.buttonAdd.TabIndex = 1;
			this.buttonAdd.Text = "Додати";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// comboBoxWorkerType
			// 
			this.comboBoxWorkerType.FormattingEnabled = true;
			this.comboBoxWorkerType.Items.AddRange(new object[] {
            "Розробник",
            "Менеджер"});
			this.comboBoxWorkerType.Location = new System.Drawing.Point(225, 14);
			this.comboBoxWorkerType.Name = "comboBoxWorkerType";
			this.comboBoxWorkerType.Size = new System.Drawing.Size(255, 33);
			this.comboBoxWorkerType.TabIndex = 2;
			this.comboBoxWorkerType.SelectedValueChanged += new System.EventHandler(this.comboBoxWorkerType_SelectedValueChanged);
			// 
			// labelExperienceYears
			// 
			this.labelExperienceYears.AutoSize = true;
			this.labelExperienceYears.Location = new System.Drawing.Point(15, 70);
			this.labelExperienceYears.Name = "labelExperienceYears";
			this.labelExperienceYears.Size = new System.Drawing.Size(145, 25);
			this.labelExperienceYears.TabIndex = 11;
			this.labelExperienceYears.Text = "Досвід (в роках)";
			// 
			// labelLanguage
			// 
			this.labelLanguage.AutoSize = true;
			this.labelLanguage.Location = new System.Drawing.Point(15, 107);
			this.labelLanguage.Name = "labelLanguage";
			this.labelLanguage.Size = new System.Drawing.Size(192, 25);
			this.labelLanguage.TabIndex = 10;
			this.labelLanguage.Text = "Мова програмування";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(15, 33);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(43, 25);
			this.labelName.TabIndex = 8;
			this.labelName.Text = "Ім\'я";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.textBoxExperienceYears);
			this.groupBox1.Controls.Add(this.labelExperienceYears);
			this.groupBox1.Controls.Add(this.textBoxLanguage);
			this.groupBox1.Controls.Add(this.textBoxName);
			this.groupBox1.Controls.Add(this.labelLanguage);
			this.groupBox1.Controls.Add(this.labelName);
			this.groupBox1.Location = new System.Drawing.Point(12, 53);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(489, 158);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			// 
			// textBoxExperienceYears
			// 
			this.textBoxExperienceYears.Location = new System.Drawing.Point(213, 67);
			this.textBoxExperienceYears.Name = "textBoxExperienceYears";
			this.textBoxExperienceYears.Size = new System.Drawing.Size(255, 31);
			this.textBoxExperienceYears.TabIndex = 17;
			// 
			// textBoxLanguage
			// 
			this.textBoxLanguage.Location = new System.Drawing.Point(213, 104);
			this.textBoxLanguage.Name = "textBoxLanguage";
			this.textBoxLanguage.Size = new System.Drawing.Size(255, 31);
			this.textBoxLanguage.TabIndex = 16;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(213, 33);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(255, 31);
			this.textBoxName.TabIndex = 15;
			// 
			// FormAddNewWorker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(513, 221);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.comboBoxWorkerType);
			this.Controls.Add(this.buttonAdd);
			this.MaximizeBox = false;
			this.MdiChildrenMinimizedAnchorBottom = false;
			this.MinimizeBox = false;
			this.Name = "FormAddNewWorker";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Новий співробітник";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private Button buttonAdd;
		private ComboBox comboBoxWorkerType;
		private Label labelExperienceYears;
		private Label labelLanguage;
		private Label labelName;
		private GroupBox groupBox1;
		private TextBox textBoxExperienceYears;
		private TextBox textBoxLanguage;
		private TextBox textBoxName;
	}
}