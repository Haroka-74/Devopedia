using _01_SOAP.Enums;
using System.Runtime.Serialization;

namespace _01_SOAP.DTOs
{
    [DataContract]
    public class CreateProductDTO
    {
        [DataMember] public string Name { get; set; } = string.Empty;
        [DataMember] public string Description { get; set; } = string.Empty;
        [DataMember] public decimal Price { get; set; }
        [DataMember] public Category Category { get; set; }
        [DataMember] public int Stock { get; set; }
    }
}