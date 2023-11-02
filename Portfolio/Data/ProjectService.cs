namespace Portfolio.Data
{
	public class ProjectService
	{
		public IList<Project> _projects;
        private string myname = "Shawn Rainiel C. Caday-Ramos";

        public ProjectService()
        {
			_projects = new List<Project>()
			{
				new Project() {ProjectId = 1, Name = "Portfo.io", Author = $"{myname}", Description = "A culmination of my academic journey, all placed into a website.", Url = "", Complete = new DateOnly(2023, 09, 30)},
				new Project() {ProjectId = 2, Name = "College Mobile", Author = $"{myname}", Description = "Develop a multiple-screen mobile application for college students to track terms, courses, and assessments. Using a SQLite datatbase and written in C#.", Url = "", Complete = new DateOnly(2023, 08, 15)},
				new Project() {ProjectId = 3, Name = "Global Consulting Agency", Author = $"{myname}", Description = "Develop a scheduling desktop application for am organization that conducts business in multiple languages and has main offices worldwide. Provided with a MySQL database and written in C#.", Url = "", Complete = new DateOnly(2023, 05, 23)},
				new Project() {ProjectId = 4, Name = "Taniti", Author = $"{myname}", Description = "As a UX designer, create a prototype of a tourism website for a local government.", Url = "https://sites.google.com/wgu.edu/taniti/", Complete = new DateOnly(2022, 08, 05)},
				new Project() {ProjectId = 5, Name = "Data Migration", Author = $"{myname}", Description = "As a data analyst, perform periodic extraction of data from a larger database by creating a repeatable data export, import, and analysis for various stakeholders.", Url = "", Complete = new DateOnly(2022, 03, 17)},
				new Project() {ProjectId = 6, Name = "Pet Professionals", Author = $"{myname}", Description = "As a UI designer, develop a responsive website for a pet consulting company.", Url = "", Complete = new DateOnly(2021, 11, 08)},
				new Project() {ProjectId = 7, Name = "Inventory Management System", Author = $"{myname}", Description = "Develop a new desktop application for a small manufacturing organization in C#.", Url = "", Complete = new DateOnly(2021, 09, 30)},
				new Project() {ProjectId = 8, Name = "Class Roster", Author = $"{myname}", Description = "Migration of an existing University student roster in C++.", Url = "", Complete = new DateOnly(2020, 09, 11)},
			};
		}
	}
}
