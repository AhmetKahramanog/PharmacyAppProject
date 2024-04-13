using Core.Utilites.Abstract;
using Core.Utilites.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMedicineService
    {
        IResult Add(Medicine medicine);
        IResult Delete(Medicine medicine);
        IResult Update(Medicine medicine);
        IDataResult<List<Medicine>> GetAll();
        IDataResult<Medicine> Get(int id);
        IDataResult<List<Medicine>> GetByCategoryId(int categoryId);
    }
}
