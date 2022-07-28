using Microsoft.EntityFrameworkCore;

namespace ContactPage.Data
{
    public class ContactDB
    {
        public ContactDB(ApplicationDbContext context)
        {
            this.context = context;
        }
        private readonly ApplicationDbContext context;

        public async Task<bool> AddEntry(Entry newEntry)
        {
            newEntry.Id=Guid.NewGuid();
            await context.Entries.AddAsync(newEntry);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Entry>>GetAllEntries()
        {
            return await context.Entries.ToListAsync();
        }

        public async Task DeleteEntry(Entry e)
        {
            var entry = await context.Entries.FirstOrDefaultAsync(e => e.Id == e.Id);
            if (entry != null)
            {
                context.Remove(entry);
                await context.SaveChangesAsync();
            }

        }
        
        public async Task EditEntry(Entry OldEntry)
        {
            var entry = await context.Entries.FirstOrDefaultAsync(e => e.Id == OldEntry.Id);
            if (entry != null)
            {
                entry.PhoneNumber = OldEntry.PhoneNumber;
                entry.BirthDate=OldEntry.BirthDate;
                entry.FirstName= OldEntry.FirstName;
                entry.LastName= OldEntry.LastName;
                await context.SaveChangesAsync();
            }

        }
    }
}
