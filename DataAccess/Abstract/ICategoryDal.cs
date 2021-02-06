using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{   //generic constraint
    public interface ICategoryDal:IEntityRepository<Category> 
    {

       
    }
}
