using SEDC.Exercise.TryBeingFit.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Domain.Core.Db
{
    public class LocalDb<T> where T : BaseEntity
    {
        public int IdCount { get; set; }
        private List<T> db;

        public LocalDb()
        {
            IdCount = 1;
            db = new List<T>();
        }

        public T GetById(int id)
        {
            T foundItem = db.SingleOrDefault(x => x.Id == id);

            if (foundItem == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error. Invalid id!");
                Console.ResetColor();
            }
            return foundItem;
        }

        public int Insert(T entity)
        {
            //go setirame ID-to na novoto entity sto go dodavame na iDCount 
            //sto ima default vrednost 1 pa so sekoe dodavanje se zgolemuva
            entity.Id = IdCount;
            db.Add(entity);
            IdCount++;
            return entity.Id;

        }

        public void RemoveById(int id)
        {
            T itemToBeRemoved = db.SingleOrDefault(x => x.Id == id);

            if (itemToBeRemoved == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error. Invalid id!");
                Console.ResetColor();
            }
            db.Remove(itemToBeRemoved);                   
        }

        public void Update(T entity)
        {
            T item = db.SingleOrDefault(x => x.Id == entity.Id);
            item = entity;
        }

        public List<T> GetAll()
        {
            return db;
        }
    }
}
