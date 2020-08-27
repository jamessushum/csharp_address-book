namespace address_book
{
  public class Contact
  {
    // Instantiating public properties for Contact class
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    // Read-only class joining first and last name
    public string FullName
    {
      get
      {
        return $"{FirstName} {LastName}";
      }
    }
  }
}