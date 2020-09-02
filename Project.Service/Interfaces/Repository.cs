using Microsoft.EntityFrameworkCore;
using Project.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Interfaces
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private CoreDbContext _context = null;
        private DbSet<T> table = null;
        public Repository()
        {
            this._context = new CoreDbContext();
            table = _context.Set<T>();
        }
        public Repository(CoreDbContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }
        public async Task<T> GetById(object id)
        {
            return await table.FindAsync(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
