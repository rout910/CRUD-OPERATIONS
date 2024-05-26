using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using megamind.Models;

namespace megamind.Repositories
{
    public interface ICrudRepository
    {
        public List<tblcrud> GetAll();
        public void Insert(tblcrud crud);
        public void Update(tblcrud crud);
        public void Delete(int id);
        public List<tblstate>GetallState();
        public List<tblcity> GetAllCity(int id);


    }
}