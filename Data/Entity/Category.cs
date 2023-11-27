using PCInternetineParduotuve.Authentication.Model;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Security.Cryptography;

namespace PCInternetineParduotuve.Data.Entity;

public class Category
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required Shop Shop { get; set; }

}

public record CategoryDto(int Id, string Name);