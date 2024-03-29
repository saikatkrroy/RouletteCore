﻿using Microsoft.EntityFrameworkCore;
using Roulette.DataAccess.Interfaces;
using RouletteCore.DataAccess;

namespace Roulette.DataAccess.Services
{
    public class UnitOfWork :  IUnitOfWork
    {
        private readonly RouletteDbContext _context;

        public UnitOfWork(DbContext context)
        {
            _context = context as RouletteDbContext;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void RejectChanges()
        {
            _context.RejectChanges();
        }


        //public DbContextConfiguration Config
        //{
        //    get
        //    {
        //        return _context.Configuration;
        //    }
        //}
    }
}
