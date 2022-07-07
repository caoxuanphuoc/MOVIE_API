// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using API_TEST.Models;
// using System.Threading.Tasks;

// namespace API_TEST.Controllers{

//     [Route("api/[Controller]")]
//     [ApiController]
//     public class HangHoaController : ControllerBase{
//         public static List<HangHoa> HangHoas = new List<HangHoa>();

//         [HttpGet]
//         //trả về giao diện cho các action
//         public IActionResult GetAll(){
//             return Ok(HangHoas);
//         }
//         [HttpGet("{id}")]
//         public IActionResult GetID(String id){
//             //LINQ [object ] query 
//             try{

//             var hanghoa2 = HangHoas.SingleOrDefault(hh => hh.id == Guid.Parse(id));
//             if(hanghoa2 == null){
//                 return NotFound();
//             }
//             else
//                 return Ok(hanghoa2);
//             } catch{ return BadRequest();}
//         }
        
//         [HttpPost]
//         public IActionResult Create( HangHoaTT item){
//             // hàm khởi tạo đối tượng
//             var hanghoa1 = new HangHoa{
//                 id = Guid.NewGuid(),
//                 Ten = item.Ten,
//                 Gia = item.Gia
//             };
//             HangHoas.Add(hanghoa1);
//             return Ok();
//         }
//         [HttpPut("{id}")]
//                public IActionResult put(String id, HangHoa Uitem){
//                 try{

//                 var hanghoa3 = HangHoas.SingleOrDefault(hh => hh.id== Guid.Parse(id));
//                 if(hanghoa3 == null)
//                     return NotFound();
//                 if( id != Uitem.id.ToString())
//                     return BadRequest();
//                 hanghoa3.id= Uitem.id;
//                 hanghoa3.Ten=Uitem.Ten;
//                 hanghoa3.Gia=Uitem.Gia;
//                 return Ok();
//                 }catch {return BadRequest();}
//             }
//         [HttpDelete ("{id}")]
//         public IActionResult delete(string id){
//             try{
//                 var hanghoa4 = HangHoas.SingleOrDefault(hh => hh.id == Guid.Parse(id));
//                 if( hanghoa4 == null)
//                     return NotFound();
//                 HangHoas.Remove(hanghoa4);
//                 return Ok();
//             }catch {
//                 return BadRequest();
//             }
//         }
//     }
// }
