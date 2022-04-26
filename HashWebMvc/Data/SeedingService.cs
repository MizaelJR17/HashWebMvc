using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HashWebMvc.Models;
using HashWebMvc.Models.Enums;
using HashWebMvc.Models.ViewModels;

namespace HashWebMvc.Data
{
    public class SeedingService
    {

        private HashWebMvcContext _context;

        public SeedingService(HashWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // o Banco de Dados já foi populado
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");



            Seller s1 = new Seller(1, "Mizael julio", "Mizael.jjunior@gmail.com", new DateTime(1998, 4, 25), 1000.00, d1);
            Seller s2 = new Seller(2, "Michael julio", "Michael.julio@gmail.com", new DateTime(1998, 4, 28), 1000.00, d4);
            Seller s3 = new Seller(3, "Alexandre", "Mizael.jjunior@gmail.com", new DateTime(1998, 4, 01), 1000.00, d2);
            Seller s4 = new Seller(4, "Jose ", "Jose.xavier@gmail.com", new DateTime(1998, 4, 15), 1000.00, d3);
            //Seller s5 = new Seller(1, "Joseff", "Joseff.silmar@gmail.com", new DateTime(1998, 4, 10), 1000.00, d1);
            //Seller s6 = new Seller(1, "Ana ", "Ana.xavier@gmail.com", new DateTime(1998, 4, 21), 1000.00, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 20), 11000.0, SalesStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 26), 11000.0, SalesStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 24), 11000.0, SalesStatus.Billed, s4);


            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4);

            _context.SalesRecord.AddRange(r1, r2, r3, r4);


            _context.SaveChanges();





        }

        private SalesRecord SalesRecord(int v1, DateTime dataTime, double v2, object hash)
        {
            throw new NotImplementedException();
        }
    }
}
