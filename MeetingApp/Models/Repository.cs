namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();


        static Repository(){
            _users.Add(new UserInfo() {Id=1,Name ="Ali",  Email = "alimali@gmail.com", Phone = "01233845678", WillAttend=true });
            _users.Add(new UserInfo() {Id=2,Name = "Veli", Email = "Velimali@gmail.com", Phone = "01279239720", WillAttend = false });
            _users.Add(new UserInfo() {Id=3 ,Name = "Samet", Email = "sametKucuk@gmail.com", Phone = "01286839323", WillAttend = true });
        }
        public static List<UserInfo> Users {
            get {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;


            _users.Add(user);
        }


        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
