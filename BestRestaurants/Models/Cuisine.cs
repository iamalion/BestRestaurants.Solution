namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public int CuisineId { get; set; }
    public string Description { get; set; }
    public int RestaurantID { get; set; }
    public Restaurant Restaurant { get; set; } 

  }
}
