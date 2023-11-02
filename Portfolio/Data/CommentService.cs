using MudBlazor;

namespace Portfolio.Data
{
    public class CommentService
    {
        //list
        public List<Comment> _comms;
        public CommentService()
        {
            _comms = new List<Comment>()
            {
                new Comment() { CommentId = 1, UserCommentId = 1, UserCommentName = "admin", Text = "Admin has entered the chat...", Likes = 1, Add = DateTime.Now, IsEdit = false},
                new Comment() { CommentId = 2, UserCommentId = 2, UserCommentName = "user", Text = "User has entered the chat!", Likes = 4, Add = DateTime.Now, IsEdit = false},
                new Comment() { CommentId = 3, UserCommentId = 1, UserCommentName = "admin", Text = "Admin has left the chat.", Likes = 3, Add = DateTime.Now, IsEdit = true},
				new Comment() { CommentId = 4, UserCommentId = 1, UserCommentName = "admin", Text = "User has left the chat", Likes = 999999999, Add = DateTime.Now, IsEdit = true},
			};
        }
        //get
        public List<Comment> GetComments()
        {
            return _comms.ToList();
        }
        // quick filter - filter globally across multiple columns with the same input
        public string searchcomm;
        public Func<Comment, bool> _quickFilter => x =>
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
        //add
        public void AddAdminComment()
        {
            int newid = _comms.Count() + 1;
            var admincomm = new Comment
            {
                CommentId = newid++,
                UserCommentId = 1,
                UserCommentName = "admin"
            };
            _comms.Add(admincomm);
        }
        public void AddUserComment(string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                int newid = _comms.Count() + 1;
                var usercomm = new Comment
                {
                    CommentId = newid++,
                    UserCommentId = 2,
                    UserCommentName = "user",
                    Text = text,
                    Likes = 0,
                    Add = DateTime.Now,
                    IsEdit = false
                };
                _comms.Add(usercomm);
            }
        }
        //likes
        public void LikeComment(Comment comment)
        {
            comment.Likes++;
        }
        //del
        private int selectedIndex = -1; // Initialize with an invalid index
        public void HandleRowClick(DataGridRowClickEventArgs<Comment> args)
        {
            selectedIndex = args.RowIndex;
        }
        public void RemoveUserComment()
        {
            if (selectedIndex >= 0 && selectedIndex < _comms.Count)
            {
                _comms.RemoveAt(selectedIndex);
            }
        }
    }

}
