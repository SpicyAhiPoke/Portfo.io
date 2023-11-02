using Microsoft.AspNetCore.Components;
namespace Portfolio.Data
{
    public class Project
    {
        public int ProjectId { get; set; } = 0;
        [Parameter]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
		public string Author { get; set; } = string.Empty;
		public string Url { get; set; } = string.Empty;
		public DateOnly Complete { get; set; }
    }
}
