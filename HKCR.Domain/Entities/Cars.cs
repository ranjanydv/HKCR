namespace HKCR.Domain.Entities
{
    internal class Cars
    {
        public Guid CarID { get; set; } = new Guid();
        public string CarName { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarColor { get; set;}
        public string CarRentalRate { get; set;}
        public string CarAvailability { get; set;}
        public string CarNoOfRent { get; set;}
        public string CarLastRented { get; set;}
    }
}
