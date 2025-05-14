using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;

namespace api.Controller
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public StockController(ApplicationDBContext context)
        {
            _context = context;
        }


        //? GetAll -> là api get toàn bộ data từ Entity Stocks
        //? gán data từ Stocks vào stocks chỉ mới là query
        //? để có thể chạy được data khi get thì cần ToList()
        [HttpGet]
        public IActionResult GetAll(){
            var stocks = _context.Stocks.ToList();

            return Ok(stocks);
        }

        //? GetByID -> là tìm Stock theo ID
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id ){
            var stock = _context.Stocks.Find(id);

            if(stock == null){
                return NotFound();
            }
            return Ok(stock);
        }
    }
}