using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Catalog> List() => Catalog.Lists;

        [HttpGet("{id}")]
        public Catalog Find(int id) => Catalog.Lists.FirstOrDefault(a => a.Id == id);
    }

    public class Catalog
    {
        public Catalog(int id, string title, int price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public int Price { get; set; }

        public static IEnumerable<Catalog> Lists => new List<Catalog>
        {
            new Catalog(1, "Catalog 1", 1000),
            new Catalog(2, "Catalog 2", 2000),
            new Catalog(3, "Catalog 3", 3000),
            new Catalog(4, "Catalog 4", 4000),
        };
    }
}
