using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.Repositories;
using Domain.Entities;

namespace Web.Helpers
{
    public class InTaskHelper
    {
        private readonly InTaskRepository _inTaskApp = new InTaskRepository();

        public IEnumerable<InTask> GetTasks()
        {
            return _inTaskApp.GetMany(x => !x.IsDeleted);
        }
    }
}