using Omadiko.Database;
using Omadiko.Entities;
using Omadiko.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.RepositoryServices.RepositoryServises
{
    public class StudentRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public IEnumerable<Student> GetAll()
        {
            return db.Students.ToList();
        }

        public Student GetById(int? id)
        {
            return db.Students.Find(id);
        }

        public void Insert(Student student)
        {
            db.Entry(student).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Update(Student student)
        {
            db.Entry(student).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var student = db.Students.Find(id);

            db.Entry(student).State = EntityState.Deleted;
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
