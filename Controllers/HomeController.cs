using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class HomeController : Controller
{
    private readonly AppDbContext _db;
    
    public HomeController(AppDbContext db)
    {
        _db = db;
    }
    
    public IActionResult Index()
    {
        var feedbacks = _db.Feedbacks.ToList();
        return View(feedbacks);
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(Feedback feedback)
    {
        _db.Feedbacks.Add(feedback);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
}
