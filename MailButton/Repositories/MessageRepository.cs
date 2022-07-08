using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using MailButton.Models;

namespace MailButton.Repositories
{
    public class MessageRepository
    {
        string _dbPath;
        SQLiteConnection conn;

        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Message>();
        }

        public MessageRepository(string dbPath)
        { 
            _dbPath = dbPath;
            Init();
        }

        public void AddNewMessage(string email, string title, string body)
        {
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(body))
                {
                    throw new ArgumentException("email, title or body is empty");
                }
                conn.Insert(new Message
                {
                    Email = email, 
                    Title = title,
                    Body = body,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    Deleted = null
                });
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<Message> GetAllMessages()
        {
            try 
            {
                return conn.Table<Message>().Where( v => v.Deleted == null).ToList();
            }
            catch(Exception)
            {
                throw;
            }

            return new List<Message>();
        }

        //public void UpdateMessage(int id, string email, string title, string body)
        //{

        //    Message record = new Message { Id = id, Email = email, Title = title, Body = body, Updated = DateTime.Now };
        //    conn.Update(record);

        //}

        //public void DeleteMessage(int id)
        //{
        //    Message record = new Message { Id = id, Deleted = DateTime.Now };
        //    conn.Update(record);
        //}
        
    }
}
