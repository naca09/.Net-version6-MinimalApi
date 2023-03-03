using Microsoft.EntityFrameworkCore;
 

namespace SixMinApi.Data
{
    public class CommandRepo : ICommandRepo
    {
        private readonly AppDbContext _context;
        public async CommandRepo(AppDbContext conntext)
        {
            _context = conntext;
        }
        public async Task CreateCommand(Command cmd)
        {
            throw new NotImplementException();
        }

        public async Task DeleteCommand(Command cmd)
        {
            throw new NotImplementException();
        }

        public async Task<IEnumerable<Command>> GetAllCommand()
        {
            return await _context.Commands!.ToListAsync();
        }

        public async Task<Command?> GetCommandById(int id)
        {
            return await _context.Command.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }     
}
