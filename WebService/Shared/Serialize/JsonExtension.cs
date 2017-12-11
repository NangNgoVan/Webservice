using Newtonsoft.Json;

namespace WebService.Shared.Serialize
{
    public static class JsonExtension
    {
        public static string JsonSerilaize(this object datas)
        {
            return JsonConvert.SerializeObject(datas);
        }

        public static T JsonDeserialize<T>(this string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }

        public static T Copy<T>(this T source)
        {
            var serialized = JsonConvert.SerializeObject(source);
            return JsonConvert.DeserializeObject<T>(serialized);
        }
    }
}
