using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKCR.Application.Common.DTO
{
    public class CarRequestDto
    {
        public string CarName { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarColor { get; set; }
        public string CarRentalRate { get; set; }
        public string CarAvailability { get; set; }
        public string CarNoOfRent { get; set; }
        public string CarLastRented { get; set; }
    }
}

