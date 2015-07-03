using LocalInformator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalInformator.Services.Commands
{
    public interface IDeleteEntityCommandHandler<TEntity> where TEntity : BaseEntity
    {
        void Delete<TEntity>(Guid entityId);
    }
}
