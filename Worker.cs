namespace WinFormsApp_Example
{
	public class Worker
	{
		public int Id { get; protected set; }
		public string Name { get; set; }
		public string Position { get; protected set; }
		public virtual string GetAdditionalInfo { get; }
	}

	public class Developer : Worker
	{
		public Developer(int id, string name, string languge, int experienceYears)
		{
			Id = id;
			Name = name;
			Language = languge;
			ExperienceYears = experienceYears;
			Position = @"Розробник";
		}

		//public string Name { get; }
		//public string Position { get; }
		public string Language { get; private set; }
		public int ExperienceYears { get; private set; }

		public override string GetAdditionalInfo => $"Мова програмування: {Language}, досвід {ExperienceYears} р.";
	}

	public class Manager : Worker
	{
		public Manager(int id, string name, int countProjects)
		{
			Id = id;
			Name = name;
			CountProjects = countProjects;
			Position = @"Менеджер";
		}

		//public string Name { get; }
		//public string Position { get; }
		public int CountProjects { get; private set; }

		public override string GetAdditionalInfo => $"К-ть проектів: {CountProjects}";
	}

	public enum WorkerType
	{
		Developer,
		Manager
	}
}