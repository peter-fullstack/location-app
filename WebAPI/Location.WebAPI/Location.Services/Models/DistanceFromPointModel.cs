namespace Location.Services.Models
{
    public class DistanceFromPointModel
    {
        public double Distance { get; set; }
        public CoordinateModel Origin { get; set; }
        public SuburbLocationModel SuburbLocation { get; set; }
    }
}
