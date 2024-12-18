namespace MeetingApp.Models;

public static class Repository{
    private static List<UserInfo> _users = new List<UserInfo>();

    static Repository(){
        _users.Add(new UserInfo(){ Id = 1, Name = "Umut", Email = "umut@gmail.com", Phone = "5555555555", WillAttend = true});
        _users.Add(new UserInfo(){ Id = 2, Name = "Ahmet", Email = "ahmet@gmail.com", Phone = "5555555555", WillAttend = true});
        _users.Add(new UserInfo(){ Id = 3, Name = "Mehmet", Email = "mehmet@gmail.com", Phone = "5555555555", WillAttend = false});
        _users.Add(new UserInfo(){ Id = 4, Name = "Ayşe", Email = "ayse@gmail.com", Phone = "5555555555", WillAttend = true});
    }
    public static List<UserInfo> Users{
        get{
            return _users;
        }
    }
    public static void CreateUser(UserInfo user){
        Console.WriteLine($"Creating user: {user.Name}, WillAttend: {user.WillAttend}");
        user.Id = _users.Count + 1;
        _users.Add(user);
        Console.WriteLine($"User count after addition: {_users.Count}");
    }
    public static UserInfo? GetById(int id){
        return _users.FirstOrDefault(user => user.Id == id);
    }
}
