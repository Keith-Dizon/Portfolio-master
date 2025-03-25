using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class PortfolioController : Controller
{
    public IActionResult Portfolio()
    {
        var projects = new List<Project>
        {
            new Project { Id = 1, Title = "Project One", Description = "A cool project.", ImageUrl = "https://via.placeholder.com/400" },
            new Project { Id = 2, Title = "Project Two", Description = "Another amazing project.", ImageUrl = "https://via.placeholder.com/400" },
            new Project { Id = 3, Title = "Project Three", Description = "Yet another great project.", ImageUrl = "https://via.placeholder.com/400" }
        };

        return View(projects);
    }
}

