using TrainTimetable.Entities.Models;

namespace TrainTimetable.Services.Models;

public class LoginUserModel
{
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
}
