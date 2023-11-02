namespace Portfolio.Data
{
    public class ExpService
    {
        public IList<Experience> _exps;

        public ExpService() 
        {
            _exps = new List<Experience>()
            {
                new Experience() { Name = "C++", Type = ExpType.Language, Place = "Language" },
                new Experience() { Name = "C#", Type = ExpType.Language, Place = "Language" },

                new Experience() { Name = "Console", Type = ExpType.Application, Place = "Application" },
                new Experience() { Name = "Desktop", Type = ExpType.Application, Place = "Application" },
                new Experience() { Name = "Mobile", Type = ExpType.Application, Place = "Application" },
                new Experience() { Name = "Web", Type = ExpType.Application, Place = "Application" },

                new Experience() { Name = ".NET", Type = ExpType.Framework, Place = "Framework" },
                new Experience() { Name = "Xamarin", Type = ExpType.Framework, Place = "Framework" },
                new Experience() { Name = "Blazor", Type = ExpType.Framework, Place = "Framework" },

                new Experience() { Name = "PostgreSQL", Type = ExpType.Database, Place = "Database" },
                new Experience() { Name = "MySQL", Type = ExpType.Database, Place = "Database" },
                new Experience() { Name = "SQLite", Type = ExpType.Database, Place = "Database" },

            };
        }
    }
}
