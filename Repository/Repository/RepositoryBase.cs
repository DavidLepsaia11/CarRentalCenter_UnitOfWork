using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public  class RepositoryBase<TEntity> : IDisposable
        where TEntity : class
    {
		private readonly CarRentalCentarDbContext _context;
		private readonly DbSet<TEntity> _dbSet;


		internal RepositoryBase(CarRentalCentarDbContext context)
		{
			_context = context ?? throw new ArgumentNullException(nameof(context));
			_dbSet = _context.Set<TEntity>();
		}

		public TEntity Get(params object[] key)
		{
			return _dbSet.Find(key);
		}

		public IEnumerable<TEntity> Set(Func<TEntity, bool> predicate)
		{
			return _dbSet.Where(predicate);
		}

		public void Save(TEntity entry)
		{
			if (_context.Entry(entry) == null || _context.Entry(entry).State == EntityState.Detached)
			{
				_dbSet.Add(entry);
			}
		}

		public void Delete(params object[] key)
		{
			var entity = Get(key);
			_dbSet.Remove(entity);
		}

		public void Delete(TEntity entry)
		{
			_dbSet.Remove(entry);
		}

		public TEntity GetLastEntity(Func<TEntity, object> predicate)
		{
			return _dbSet.OrderBy(predicate).LastOrDefault();
		}

		public void Dispose()
		{
			_context.Dispose();
			GC.SuppressFinalize(this);
		}
	}
}
