using Microsoft.AspNetCore.Mvc;
using API_TEST.Data;
using API_TEST.Models;
namespace API_TEST.Controllers;

[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase
{   private readonly MovieContext _context;
    public MovieController( MovieContext context){
        _context =context;
    }
    [HttpGet]
    public IActionResult GetALL(){
        var ListMovie = _context.Movie.ToList();
        return Ok(ListMovie);
    }
    [HttpGet("{id}")]
    public IActionResult GetId(int id){
          var check = _context.Movie.SingleOrDefault( mv => id== mv.ID);
          if(check ==null){
            return NotFound();
          }else{
            return Ok(check);
          }
    }
    [HttpPost]
    public IActionResult createNew( Movie item){
        try{
        _context.Add(item);
        _context.SaveChanges();
        return Ok(item);
        }catch{
            return BadRequest();
        }
    }
    [HttpPut("{id}")]
    public IActionResult GetId(int id, Movie newItem){
          var check = _context.Movie.SingleOrDefault( mv => id== mv.ID);
          if(check ==null){
            return NotFound();
          }else{
            check.Title = newItem.Title;
            check.ReleaseDate = newItem.ReleaseDate;
            check.Price = newItem.Price;
            check.Genre = newItem.Genre;
            _context.SaveChanges();
            return NoContent();
          }
    }
    [HttpDelete("{id}")]
    public IActionResult delete(int id){
        var check = _context.Movie.SingleOrDefault( mv => id== mv.ID);
          if(check ==null){
            return NotFound();
          }else{
            _context.Remove(check);
            _context.SaveChanges();
            return Ok("remove movie have id= "+ check.ID);
          }
    }
}
