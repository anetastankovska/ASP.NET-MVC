
using SEDC.PizzaApp02.App.Models.Domain;
using SEDC.PizzaApp02.App.Models.ViewModels;

namespace SEDC.PizzaApp02.App.Helpers
{
    public static class UserMapper
    {
        public static UserSelectViewModel MapToUserSelectViewModel(this User user)
        {
            return new UserSelectViewModel
            {
                Id = user.Id,
                FullName = $"{user.FirstName} {user.LastName}",
            };
        }
    }
}
