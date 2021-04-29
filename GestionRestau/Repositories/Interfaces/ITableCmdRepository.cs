using GestionRestau.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionRestau.Repositories.Interfaces
{
    public interface ITableCmdRepository
    {
        public ICollection<TableCmd> GetAll();
        public ICollection<TableCmd> GetAllWithServers();
        public void Insert(TableCmd tableCmd);
        public TableCmd GetById(int Id);
        public void Update(TableCmd tableCmd);
        public void DeleteById(int Id);
        public void Save();
    }
}
