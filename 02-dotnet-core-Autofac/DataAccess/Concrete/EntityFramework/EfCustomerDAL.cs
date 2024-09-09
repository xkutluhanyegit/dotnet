using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDAL:EfEntityRepositoryBase<Customer,DotnetContext>,IEntityRepository<Customer>,ICustomerDAL
    {
        
    }
}