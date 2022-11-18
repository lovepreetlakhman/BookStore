using LovepreetsBooks.DataAccess.Repository.IRepository;
using LovepreetsBooks.Models;
using System;
using LovepreetsBookStore.DataAccess.Data;
using System.Collections.Generic;
using System.Text;

namespace LovepreetsBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}

