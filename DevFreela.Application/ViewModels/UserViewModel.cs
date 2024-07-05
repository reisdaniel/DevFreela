namespace DevFreela.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(string fullname, string email)
        {
            Fullname = fullname;
            Email = email;
        }
        public string Fullname { get; set; }
        public string Email { get; set; }
    }
}
