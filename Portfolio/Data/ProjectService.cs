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
				new Project() {ProjectId = 2, Name = "College Mobile", Author = $"{myname}", Description = "A multiple-screen mobile application for college students to track terms, courses, and assessments.", Url = "", Complete = new DateOnly(2023, 08, 15)},
				new Project() {ProjectId = 3, Name = "Global Consulting Agency", Author = $"{myname}", Description = "An application scheduling desktop application for an organization that conducts business in multiple languages and has main offices worldwide.", Url = "", Complete = new DateOnly(2023, 05, 23)},
				new Project() {ProjectId = 4, Name = "Taniti", Author = $"{myname}", Description = "A UX prototype of a tourism website for a local government.", Url = "https://sites.google.com/wgu.edu/taniti/", Complete = new DateOnly(2022, 08, 05)},
				new Project() {ProjectId = 5, Name = "Data Migration", Author = $"{myname}", Description = "A periodic extraction of data from a larger database by creating a repeatable data export, import, and analysis for various stakeholders.", Url = "", Complete = new DateOnly(2022, 03, 17)},
				new Project() {ProjectId = 6, Name = "Pet Professionals", Author = $"{myname}", Description = "As a UI designer, develop a responsive website for a pet consulting company.", Url = "", Complete = new DateOnly(2021, 11, 08)},
				new Project() {ProjectId = 7, Name = "Inventory Management System", Author = $"{myname}", Description = "A inventory desktop application for a small manufacturing organization.", Url = "", Complete = new DateOnly(2021, 09, 30)},
				new Project() {ProjectId = 8, Name = "Class Roster", Author = $"{myname}", Description = "Data migration of an existing University student roster.", Url = "", Complete = new DateOnly(2020, 09, 11)},
			};
		}
	}
}
