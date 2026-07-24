using Microsoft.AspNetCore.Mvc;
namespace ProductManagementSystem.Controllers;
public class HomeController:Controller{
    public IActionResult Index()=>View();
}