﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal :  EfEntityRepositoryBase<Car,CarDbContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from c in context.Cars
                    join b in context.Brands on c.BrandId equals b.BrandId
                    join p in context.Colors on c.ColorId equals p.ColorId
                    select new CarDetailDto
                    {
                        CarId = c.CarId,CarName = c.CarName,BrandName = b.BrandName,
                        ColorName = p.ColorName, ModelYear = c.ModelYear
                    };

                return result.ToList();
            }
        }
    }
}
