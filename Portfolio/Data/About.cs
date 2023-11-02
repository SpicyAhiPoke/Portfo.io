using Portfolio.Pages;

namespace Portfolio.Data
{
    public class About
    {
        //Testing
        public int AboutId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public QuestionType Type { get; set; }

    }

    public enum QuestionType
    {
        Who,
        What,
        Where,
        When,
        Why,
        How
    }

}
