using System;
using System.Collections.Generic;
using System.Text;

namespace StreamG.Core.Domain
{
    interface IRepository<TEntity> where TEntity: IBaseEntity
    {
        IEnumerable<TEntity> Get();
        TEntity Get(int id);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
