﻿namespace BulkyBook.DataAccess.Repository
{
    using BulkyBook.Models;
    using BulkyBookWeb.Data;
    using BulkyBook.DataAccess.Repository.IRepository;

    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) 
            : base(db)
        {
            _db = db;
        }
        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
