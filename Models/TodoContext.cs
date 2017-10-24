using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
	public class TodoContext : DbContext
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="options"></param>
		/// <returns></returns>
		public TodoContext(DbContextOptions<TodoContext> options) : base(options) {	}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public DbSet<TodoItem> TodoItems { get; set; }

	}
}