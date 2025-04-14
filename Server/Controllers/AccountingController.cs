using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Models;  // �ޥμҫ��R�W�Ŷ�

namespace AccountingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountingController : ControllerBase
    {
        private readonly AccountingappContext _context;

        // �b�غc�l���`�J DbContext
        public AccountingController(AccountingappContext context)
        {
            _context = context;
        }

        // ���o�Ҧ�������
        [HttpGet("Transactions")]
        public async Task<ActionResult<IEnumerable<Transaction>>> GetTransactions()
        {
            return await _context.Transactions.ToListAsync();
        }

        // ���o�Ҧ��������
        [HttpGet("Categories")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        // ���o���w��������
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

        // ���o���w���������
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
