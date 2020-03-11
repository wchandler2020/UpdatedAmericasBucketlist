using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using updated_group_project.Models;

namespace updated_group_project.Interfaces
{
    public interface IEventService
    {
        Task<EventObject> GetEvent();
    }
}
