using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;

namespace Application.Bases
{
    public class BaseHandler
    {
        public readonly IMapping _mapping;
        public readonly IUnitOfWork unitOfWork;
        public BaseHandler(IMapping mapping, IUnitOfWork unitOfWork)
        {
            this._mapping = mapping;
            this.unitOfWork = unitOfWork;
        }
    }
}
