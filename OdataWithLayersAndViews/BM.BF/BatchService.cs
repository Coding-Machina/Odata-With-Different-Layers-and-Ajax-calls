using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BM.EF;

namespace BM.BF
{
    public class BatchService
    {
        private BatchManagement1Entities ctx;

        public BatchService()
        {
            ctx = new BatchManagement1Entities();
        }

        public BatchManagement AddItem(BatchManagement batch)
        {
            ctx.BatchManagements.Add(batch);
            ctx.SaveChanges();
            return (batch);
        }

        public IQueryable<BatchManagement> GetItem()
        {
            return ctx.BatchManagements.AsQueryable();
        }
    }
}
