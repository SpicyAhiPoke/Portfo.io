using Portfolio.Authentication;
using Portfolio.Data;

namespace Tests
{
    public class Filter
    {
        private Func<Comment, bool> _quickFilter; 
        private string searchcomm = "";

        [SetUp]
        public void Setup()
        {
            _quickFilter = x =>
            {
                if (string.IsNullOrWhiteSpace(searchcomm))
                    return true;
                if (x.UserCommentName.Contains(searchcomm, StringComparison.OrdinalIgnoreCase))
                    return true;
                if (x.Text.Contains(searchcomm, StringComparison.OrdinalIgnoreCase))
                    return true;
                if ($"{x.CommentId} {x.Likes} {x.Add} {x.IsEdit}".Contains(searchcomm))
                    return true;
                return false;
            };

        }

        [TestCase("test", true)]
        [TestCase("this is a test", true)]
        [TestCase("143", true)]
        [TestCase("808", true)]
        [TestCase("NonExistent", true)]
        [TestCase("", true)]
        [TestCase("true", true)]
        [TestCase("false", true)]

        [Test]
        public void Test(string searchcomm, bool expected)
        {
            //assign
            Comment _acomm = new()
            {
                UserCommentName = "test",
                Text = "this is a test",
                CommentId = 143,
                Likes = 808,
                IsEdit = true
            };
            //act
            bool result = _quickFilter(_acomm);

            //assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}