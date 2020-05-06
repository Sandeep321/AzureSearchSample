using System;
using Newtonsoft.Json;

namespace AzureSearchSample
{
    public partial class Address
    {
        public override string ToString() =>
            IsEmpty ?
                string.Empty :
                $"{StreetAddress}\n{City}, {StateProvince} {PostalCode}\n{Country}";

        [JsonIgnore]
        public bool IsEmpty => String.IsNullOrEmpty(StreetAddress) &&
                               String.IsNullOrEmpty(City) &&
                               String.IsNullOrEmpty(StateProvince) &&
                               String.IsNullOrEmpty(PostalCode) &&
                               String.IsNullOrEmpty(Country);
    }
}