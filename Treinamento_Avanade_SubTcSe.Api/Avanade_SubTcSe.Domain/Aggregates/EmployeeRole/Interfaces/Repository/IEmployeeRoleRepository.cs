﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade_SubTcSe.Domain.Aggregates.EmployeeRole.Interfaces.Repository
{
    public interface IEmployeeRoleRepository
    {
        void AddEmployeeRole(Entities.EmployeeRole employeeRole);
    }
}
