namespace Portfolio.Data
{
    public class AboutService
    {
        public IList<About> _abouts;

        public AboutService()
        {
            _abouts = new List<About>()
            {
                new About() { Type = QuestionType.Who , Question = "Who's your favorite actor or actress?", Answer = "Keanu Reeves, for his humble personality  and role as John Wick."},
                new About() { Type = QuestionType.What , Question = "What is your go-to comfort food?", Answer = "Spicy ahi poke bowl: raw cubed tuna w/sriracha mayo over rice!"},
                new About() { Type = QuestionType.Where , Question = "Where did you go on your last vacation?", Answer = "Japan 2018; It was a breath of fresh air."},
                new About() { Type = QuestionType.When , Question = "When is your favorite season?", Answer = "Advent season!"},
                new About() { Type = QuestionType.Why , Question = "Why did you choose your current career path?", Answer = "I'm fascinated how objects are created and how they function."},
                new About() { Type = QuestionType.How , Question = "How do you find new music/artists?", Answer = "Since 2011, my goto is SOULECTION Radio."},

            };
        }
    }
}
