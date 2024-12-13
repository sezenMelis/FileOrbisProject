using SQLite;

namespace FileOrbisProject.Models;

public class Clients
{
    [PrimaryKey,AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string? Image { get; set; }
}
