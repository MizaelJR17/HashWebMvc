﻿using HashWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
