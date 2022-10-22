using System.Security.Claims;

namespace SDT.Web.Extensions
{
    public static class UserInfoExtensions
    {
        public static int? GetUserId(this ClaimsPrincipal user)
        {
            var userIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);

            if (userIdClaim != null)
            {
                if (int.TryParse(userIdClaim.Value, out var userId))
                {
                    return userId;
                }
            }

            return null;
        }

        public static string GetUserAvatar(this ClaimsPrincipal user)
        {
            var userAvatarClaim = user.FindFirst(ClaimTypes.UserData);

            if(userAvatarClaim != null)
            {
                return userAvatarClaim.Value;
            }

            return string.Empty;
        }

        public static string GetUserName(this ClaimsPrincipal user)
        {
            var userNameClaim = user.FindFirst(ClaimTypes.Name);

            if(userNameClaim != null)
            {
                return userNameClaim.Value;
            }

            return null;
        }
    }
}