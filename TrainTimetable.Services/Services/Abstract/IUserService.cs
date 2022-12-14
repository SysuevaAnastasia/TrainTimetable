using TrainTimetable.Services.Models;

namespace TrainTimetable.Services.Abstract;

public interface IUserService
{
    UserModel GetUser(Guid id);

    UserModel UpdateUser(Guid id, UpdateUserModel user);

    void DeleteUser(Guid id);

    PageModel<UserModel> GetUsers(int limit = 20, int offset = 0);
}