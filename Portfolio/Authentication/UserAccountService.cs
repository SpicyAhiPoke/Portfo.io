using MudBlazor;
using Portfolio.Data;

namespace Portfolio.Authentication
{
    public class UserAccountService
    {
        //list
        public List<UserAccount> _accs;
        public UserAccountService()
        {
            _accs = new List<UserAccount>()
            {
                new UserAccount() {AccountId = 1, Username = "admin", Email = "shawnrccr@gmail.com", Password = "apassword", Role = "Administrator"},
                new UserAccount() {AccountId = 2, Username = "user", Email = "", Password = "upassword", Role = "User"},
            };
        }
        //get
        public List<UserAccount> GetAccounts()
        {
            return _accs.ToList();
        }

        public UserAccount? GetUsername(string username)
        {
            return _accs.FirstOrDefault(x => x.Username == username);
        }
        public UserAccount? GetId(int id)
        {
            return _accs.FirstOrDefault(x => x.AccountId == id);
        }
        //search
        public string searchacc;
        public Func<UserAccount, bool> _quickFilter => x =>
        {
            if (string.IsNullOrWhiteSpace(searchacc))
                return true;
            if (x.Username.Contains(searchacc, StringComparison.OrdinalIgnoreCase))
                return true;
            if (x.Email.Contains(searchacc, StringComparison.OrdinalIgnoreCase))
                return true;
            if (x.Password.Contains(searchacc, StringComparison.OrdinalIgnoreCase))
                return true;
            if (x.Role.Contains(searchacc, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{x.AccountId}".Contains(searchacc))
                return true;
            return false;
        };
        //del
        private int selectedIndex = -1; // Initialize with an invalid index
        public void HandleRowClick(DataGridRowClickEventArgs<UserAccount> args)
        {
            selectedIndex = args.RowIndex;
        }
        public void RemoveUserComment()
        {
            if (selectedIndex >= 0 && selectedIndex < _accs.Count)
            {
                _accs.RemoveAt(selectedIndex);
            }
        }

    }
}
