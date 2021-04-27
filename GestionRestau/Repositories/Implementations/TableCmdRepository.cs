using GestionRestau.Models;
using GestionRestau.Models.Context;
using GestionRestau.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionRestau.Repositories.Implementations
{
    public class TableCmdRepository : ITableCmdRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public TableCmdRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ICollection<TableCmd> GetAll()
        {
            var tableCmds = _dbContext.TableCmds.ToList();
            return tableCmds;
        }
        public void Insert(TableCmd tableCmd)
        {
            _dbContext.TableCmds.Add(tableCmd);
        }
        public TableCmd GetById(int Id)
        {
            return _dbContext.TableCmds.Find(Id);
        }
        public void Update(TableCmd tableCmd)
        {
            _dbContext.Entry(tableCmd).State = EntityState.Modified;
        }
        public void DeleteById(int Id)
        {
            var tableCmdToDelete = _dbContext.TableCmds.Find(Id);
            _dbContext.TableCmds.Remove(tableCmdToDelete);
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
