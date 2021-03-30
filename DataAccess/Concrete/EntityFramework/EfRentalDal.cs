using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join cr in context.Cars on r.CarId equals cr.Id
                             join c in context.Customers on r.CustomerId equals c.Id
                             //join u in context.Users on c.UserId equals u.UserId
                             select new RentalDetailDto { RentalId = r.RentalId, CompanyName = c.CompanyName, RentDate = r.RentDate, ReturnDate = r.ReturnDate };
                return result.ToList();

            }
        }
    }
}
