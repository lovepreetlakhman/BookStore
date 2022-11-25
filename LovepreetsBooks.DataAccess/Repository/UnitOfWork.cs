﻿using LovepreetsBooks.DataAccess.Repository.IRepository;
using LovepreetsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LovepreetsBooks.DataAccess.Repository.IRepository
{
    public class UnitOfWork : IUnitOfWork   // make the method public to access the class
    {
        private readonly ApplicationDbContext _db;   // the using statment

        public UnitOfWork(ApplicationDbContext db)   // constructor to use DI and inject in to the repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }

        public ISP_Call SP_Call { get; private set; }

        public ICoverTypeRepository CoverType { get; private set; }

        public IProductRepository Product { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()    // all changes will be saved when the saved method  is called at the 'parent' level
        {
            _db.SaveChanges();
        }
    }
}