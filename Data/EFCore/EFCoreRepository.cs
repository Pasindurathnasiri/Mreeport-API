using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace MReportAPI.Data.EFCore
{
    public abstract class HAEFCoreRepository<THAEntity, THAContext> : IAHRepository<THAEntity>
       where THAEntity : class, IHAuthEntity
       where THAContext : DbContext
    {
        private readonly THAContext HAcontext;
        public HAEFCoreRepository(THAContext HAcontext)
        {
            this.HAcontext = HAcontext;
        }

        [Authorize]
        //authentication login
        public async Task<THAEntity> Auth(string id)
        {
            var entity = await HAcontext.Set<THAEntity>()
                                       .Where(ent => ent.OwnerNIC == id)
                                       .FirstOrDefaultAsync();

            return entity;
        }

        //post
        public async Task<THAEntity> Add(THAEntity entity)
        {
            HAcontext.Set<THAEntity>().Add(entity);
            await HAcontext.SaveChangesAsync();
            return entity;
        }

        //delete
        public async Task<THAEntity> Delete(int id)
        {
            var entity = await HAcontext.Set<THAEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            HAcontext.Set<THAEntity>().FindAsync(id);
            await HAcontext.SaveChangesAsync();

            return entity;
        }

        //get by id
        public async Task<THAEntity> Get(int id)
        {
            return await HAcontext.Set<THAEntity>().FindAsync(id);
        }

        //getall
        public async Task<List<THAEntity>> GetAll()
        {
            return await HAcontext.Set<THAEntity>().ToListAsync();
        }

        //update
        public async Task<THAEntity> Update(THAEntity entity)
        {
            HAcontext.Entry(entity).State = EntityState.Modified;
            await HAcontext.SaveChangesAsync();
            return entity;
        }
    }

    public abstract class AEFCoreRepository<TAEntity, TAContext> : IARepository<TAEntity>
        where TAEntity : class, IAuthEntity
        where TAContext : DbContext
    {
        private readonly TAContext Acontext;
        public AEFCoreRepository(TAContext Acontext)
        {
            this.Acontext = Acontext;
        }

        [Authorize]
        //authentication login
        public async Task<TAEntity> Auth(string id)
        {
            var entity = await Acontext.Set<TAEntity>()
                                       .Where(ent => ent.NIC == id )
                                       .FirstOrDefaultAsync();

            return entity;
        }

        //post
        public async Task<TAEntity> Add(TAEntity entity)
        {
            Acontext.Set<TAEntity>().Add(entity);
            await Acontext.SaveChangesAsync();
            return entity;
        }

        //delete
        public async Task<TAEntity> Delete(int id)
        {
            var entity = await Acontext.Set<TAEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            Acontext.Set<TAEntity>().FindAsync(id);
            await Acontext.SaveChangesAsync();

            return entity;
        }

        //get by id
        public async Task<TAEntity> Get(int id)
        {
            return await Acontext.Set<TAEntity>().FindAsync(id);
        }

        //getall
        public async Task<List<TAEntity>> GetAll()
        {
            return await Acontext.Set<TAEntity>().ToListAsync();
        }

        //update
        public async Task<TAEntity> Update(TAEntity entity)
        {
            Acontext.Entry(entity).State = EntityState.Modified;
            await Acontext.SaveChangesAsync();
            return entity;
        }
    }

    public abstract class EFCoreRepository<TEntity,TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        private readonly TContext context;
        public EFCoreRepository(TContext context)
        {
            this.context = context;
        }

        //post
        public async Task<TEntity> Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        //delete
        public async Task<TEntity> Delete(int id)
        {
            var entity = await context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        //get by id
        public async Task<TEntity> Get(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        //getall
        public async Task<List<TEntity>> GetAll()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        //update
        public async Task<TEntity> Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }

    }
}
