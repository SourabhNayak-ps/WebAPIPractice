using Microsoft.AspNetCore.Mvc;

namespace MyWebAppApis.Models.DTOs
{
    public class ProductReadDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
    }
}
