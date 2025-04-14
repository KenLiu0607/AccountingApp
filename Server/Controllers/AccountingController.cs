using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Models;  // 引用模型命名空間

namespace AccountingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountingController : ControllerBase
    {
        private readonly AccountingappContext _context;

        // 在建構子中注入 DbContext
        public AccountingController(AccountingappContext context)
        {
            _context = context;
        }

        // 取得所有交易資料
        [HttpGet("Transactions")]
        public async Task<ActionResult<IEnumerable<Transaction>>> GetTransactions()
        {
            return await _context.Transactions.ToListAsync();
        }

        // 取得所有分類資料
        [HttpGet("Categories")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        // 取得指定的交易資料
        [HttpGet("Transactions/{id}")]
        public async Task<IActionResult> GetTransactions(int id)
        {
            var transaction = await _context.Transactions.FindAsync(id);

            if (transaction == null)
            {
                return NotFound();
            }

            return Ok(transaction);
        }

        // 取得指定的分類資料
        [HttpGet("Categories/{id}")]
        public async Task<ActionResult<Category>> GetCategories(int id)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }
    }
}
