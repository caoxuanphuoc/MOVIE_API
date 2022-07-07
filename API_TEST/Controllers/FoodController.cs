using Microsoft.AspNetCore.Mvc;
using API_TEST.Data;
namespace API_TEST.Controllers;
using API_TEST.Models;

[ApiController]
[Route("[controller]")]
public class FoodController : ControllerBase
{   private readonly MovieContext _context;
    public FoodController( MovieContext context){
        _context =context;
    }
    [HttpGet]
    public IActionResult GetALL(){
        var ListMovie = _context.Food.ToList();
        return Ok(ListMovie);
    }
    [HttpPost]
    public IActionResult create( Food item){
        try{
        _context.Add(item);
        _context.SaveChanges();
        return Ok(item);
        }catch (Exception loi){
            return Ok(loi.Message);
        }
    }
}
