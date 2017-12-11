using System.IO;
using System.Xml.Serialization;

namespace WebService.Shared.Serialize
{
    public static class XmlExtension
    {
        public static T XmlDeserialize<T>(this string input) where T : class
        {
            var ser = new XmlSerializer(typeof(T));

            using (var sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        public static string XmlSerialize<T>(this T objectToSerialize)
        {
            var xmlSerializer = new XmlSerializer(objectToSerialize.GetType());

            using (var textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, objectToSerialize);
                return textWriter.ToString();
            }
        }
    }
}