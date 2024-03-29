﻿namespace Entities.DataTransferObjects.Get
{
    public class GetAddressDto
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public GetGeoDto Geo { get; set; }
    }
}
