using Omadiko.Database;
using Omadiko.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omadiko.Entities;


namespace Omadiko.RepositoryServices.RepositoryServises
{
    class CourseRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public IEnumerable<Course> GetAll()
        {
            return db.Courses.ToList();
        }

        public Course GetById(int? id)
        {
            return db.Courses.Find(id);
        }

        public void Insert(Course course)
        {
            db.Entry(course).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Update(Course course)
        {
            db.Entry(course).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var course = db.Courses.Find(id);

            db.Entry(course).State = EntityState.Deleted;
            db.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
