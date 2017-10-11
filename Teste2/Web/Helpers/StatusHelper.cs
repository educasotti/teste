using Data.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Helpers
{
    public class StatusHelper
    {
        private readonly StatusRepository _statusApp = new StatusRepository();

        public IEnumerable<Status> GetStatus()
        {
            return _statusApp.GetMany(x => !x.IsDeleted);
        }
        
        public void AddStatus(Status status)
        {
            return _statusApp.Add(status);
        }
    }
}