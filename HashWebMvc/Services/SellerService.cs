using HashWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HashWebMvc.Services
{
    public class SellerService
    {

        private readonly HashWebMvcContext _context;

        public SellerService(HashWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj )
        {

            //obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller  FindById(int id)

        {     //Eager Loading -> Faz a Inclusão do ObJ ( Var qualquer ) do tipo Department
             // ---Quando o For clicado nos Details será chamado O FindById ---
             // O Eager Loading - já vai carregar os objetos que estão atrelados
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);

        }

        public void Remove (int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        } 

    }
}
