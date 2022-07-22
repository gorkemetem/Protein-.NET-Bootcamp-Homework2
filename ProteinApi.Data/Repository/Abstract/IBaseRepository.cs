﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProteinApi.Data
{
    public interface IBaseRepository<Entity> where Entity : class
    {
        Task<Entity> GetByIdAsync(int entityId);
        Task InsertAsync(Entity entity);
        void RemoveAsync(Entity entity);
        void Update(Entity entity);
        Task<IEnumerable<Entity>> GetAllAsync();
    }
}
