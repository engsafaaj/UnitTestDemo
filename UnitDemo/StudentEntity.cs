using System;
using System.Collections.Generic;
using System.Text;

namespace UnitDemo
{
    public class StudentEntity : IDataHelper<Students>
    {
        // Fields
        DBContext db;

        // Constructor
        public StudentEntity()
        {
            db = new DBContext();
        }
        public int Add(Students table)
        {
            if (db.Database.CanConnect())
            {
                db.Students.Add(table);
                db.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Delete(Students table)
        {
            throw new NotImplementedException();
        }

        public int Edit(Students table)
        {
            throw new NotImplementedException();
        }

        public Students Find(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Students> GetData()
        {
            throw new NotImplementedException();
        }

        public List<Students> Search(string SearchItem)
        {
            throw new NotImplementedException();
        }
    }
}
