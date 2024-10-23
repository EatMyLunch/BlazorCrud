using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace BlazorCrud.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
