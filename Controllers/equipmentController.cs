using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GearGo_Equipment_Rental.Models;

namespace GearGo_Equipment_Rental.Controllers;

public class EquipmentController : Controller
{
    List<Equipment> equipmentList = new List<Equipment>
        {
            new Equipment { Id = 1, Name = "Camera", Description = "High-quality DSLR camera", DailyRate = 50.00, Category = "Photography", Availability = true },
            new Equipment { Id = 2, Name = "Tripod", Description = "Sturdy tripod for stable shots", DailyRate = 20.00, Category = "Photography", Availability = true },
            new Equipment { Id = 3, Name = "Lighting Kit", Description = "Professional lighting kit for photography", DailyRate = 100.00, Category = "Photography", Availability = false },
            new Equipment { Id = 4, Name = "Microphone", Description = "High-fidelity microphone for clear audio", DailyRate = 30.00, Category = "Audio", Availability = true },
            new Equipment { Id = 5, Name = "Drone", Description = "Quadcopter drone for aerial shots", DailyRate = 200.00, Category = "Aerial", Availability = false }
        };

    public IActionResult Index()
    {
        return View(equipmentList);
    }

    public IActionResult Details(int id)
    {
        Equipment equipment = equipmentList.Find(item => item.Id == id);
        if(equipment == null)
        {
            return RedirectToAction("Index");
        }
        return View(equipment);
    }
    /*This  will show when there is an error*/
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
