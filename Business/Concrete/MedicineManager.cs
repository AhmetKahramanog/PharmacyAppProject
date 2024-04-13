using Business.Abstract;
using Business.Constants;
using Core.Utilites.Abstract;
using Core.Utilites.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MedicineManager : IMedicineService
    {

        IMedicineDal _medicineDal;
        public MedicineManager(IMedicineDal medicineDal)
        {
            _medicineDal = medicineDal;
        }
        public IResult Add(Medicine medicine)
        {
            _medicineDal.Add(medicine);
            return new SuccessResult(Messages.MedicineAdded);
        }

        public IResult Delete(Medicine medicine)
        {
            _medicineDal.Delete(medicine);
            return new SuccessResult(Messages.MedicineDeleted);
        }

        public IDataResult<Medicine> Get(int id)
        {
            return new SuccessDataResult<Medicine>(_medicineDal.Get(m => m.Id == id));
        }

        public IDataResult<List<Medicine>> GetAll()
        {
            return new SuccessDataResult<List<Medicine>>(_medicineDal.GetAll(),Messages.MedicinesListed);
        }

        public IDataResult<List<Medicine>> GetByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Medicine>>(_medicineDal.GetAll(m => m.CategoryId == categoryId), Messages.MedicinesGetByCategoryId);
        }

        public IResult Update(Medicine medicine)
        {
            _medicineDal.Update(medicine);
            return new SuccessResult(Messages.MedicineUpdated);
        }
    }
}
