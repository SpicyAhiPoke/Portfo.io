using Portfolio.Authentication;
using Portfolio.Data;
namespace Portfolio.Data
{
    public class Comment
    {
        public int CommentId { get; set; } = 0;
        public int UserCommentId { get; set; } = 0;
        public string UserCommentName { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public int Likes { get; set; } = 0;
        public DateTime Add { get; set; } = DateTime.Now;
        public bool IsEdit { get; set; } = false;

        public Comment()
        {
            CommentId = 0;
            UserCommentId = 0;
            UserCommentName = "";
            Text = $"new comment";
            Add = DateTime.Now;
            IsEdit = false;
        }

    }
}
