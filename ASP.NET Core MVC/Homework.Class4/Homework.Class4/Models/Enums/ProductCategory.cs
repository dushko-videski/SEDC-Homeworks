using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Homework.Class4.Models.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductCategory
    {
        Electronics = 1,
        Books = 2,
        Furniture = 3,
        Food = 4,
        Kids = 5,
        Babies = 6,
        Clothes = 7,
        Textile = 8
    }
}
