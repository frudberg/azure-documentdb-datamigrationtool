using Microsoft.DataTransfer.JsonNet.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Microsoft.DataTransfer.JsonFile.Serialization
{
    static class JsonSerializersFactory
    {
        public static JsonSerializer Create(bool prettify)
        {
            return JsonSerializer.CreateDefault(new JsonSerializerSettings
            {
                Converters =
                {
                    DataItemJsonConverter.Instance,
                    new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-ddTHH\\:mm\\:ss.FFFFFFF" },
                    GeoJsonConverter.Instance
                },
                Formatting = prettify ? Formatting.Indented : Formatting.None
            });
        }
    }
}
