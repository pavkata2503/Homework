public class Buyer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public int? ProductId { get; set; }
    public Product? Product { get; set; }

}
