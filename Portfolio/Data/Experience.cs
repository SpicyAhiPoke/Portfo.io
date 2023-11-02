
namespace Portfolio.Data
{
    public class Experience
    {
        public int ExpId { get; set; }
        public string Name { get; set; }
		public ExpType Type { get; set; }
		public string Place { get; set; }
		public bool IsPicked { get; set; }

	}
	public enum ExpType
	{
		Language,
		Application,
		Framework,
		Database
	}
}
