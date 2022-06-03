using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IdentityDbContextCustomFields.Data.Models;

public class ApplicationUser : IdentityDbContext
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PayrollNumber { get; set; }
    public string? Region { get; set; }
    public string? Branch { get; set; }
    public string? Position { get; set; }
}