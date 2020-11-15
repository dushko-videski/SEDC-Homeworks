using Homework.Class4.Models.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Homework.Class4.Models.DataTransferModels
{
    public class ProductDto
    {
        public string SerialNo { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ProductCategory Category { get; set; }

    }
}
