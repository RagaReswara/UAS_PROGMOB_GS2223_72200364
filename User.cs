using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
namespace Blazorwasm.Pages;
public class User
{
    public int id { get; set; }

    public string? name { get; set; }

    public string? username { get; set; }

    public string? email { get; set; }

    public string? address { get; set; }

    public string? geo { get; set; }

    public string? phone { get; set; }

    public string? web { get; set; }

    public string? company { get; set; }
    
    public string? street { get; set; }
    public string? suite { get; set; }
    public string? city { get; set; }
    public string? zipcode { get; set; }
    public string? lat { get; set; }
    public string? lng { get; set; }
    public string? companyName { get; set; }
    public string? catchPhrase { get; set; }
    public string? bs { get; set; }
}