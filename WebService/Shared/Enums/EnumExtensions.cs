using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace WebService.Shared.Enums
{
    public static class EnumExtensions
    {
        public static string ToDisplayName(this System.Enum enumValue)
        {
            var items = enumValue.GetType().GetMember(enumValue.ToString());
            if (items.Length == 0)
                return null;

            var item = items.First().GetCustomAttribute<DisplayAttribute>();
            if (item == null)
                return items.First().GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            else
                return item.GetName();
        }
    }
}