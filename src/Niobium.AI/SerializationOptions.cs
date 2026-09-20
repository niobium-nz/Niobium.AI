using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace Niobium.AI;

public class SerializationOptions
{
    public static readonly JsonSerializerOptions SnakeCase = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        DictionaryKeyPolicy = JsonNamingPolicy.SnakeCaseLower,
        TypeInfoResolver = new DefaultJsonTypeInfoResolver(),
    };

    public static readonly JsonSerializerOptions Web = JsonSerializerOptions.Web;
}
