namespace MySiteWebMVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        // Se le pone ? Para que acepte nulos
        public double Price { get; set; }
    }
}
