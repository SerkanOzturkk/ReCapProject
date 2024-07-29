﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constanst;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IDataResult<List<Customer>> GetAll()
        {
            if (DateTime.Now.Hour == 21)
            {
                return new ErrorDataResult<List<Customer>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<Customer> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.UserId == customerId));
        }

        public IResult Add(Customer customer)
        {
            if (customer.CompanyName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _customerDal.Add(customer);

            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CarDeleted);
        }
    }
}
