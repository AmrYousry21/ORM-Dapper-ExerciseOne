﻿using System.Collections.Generic;

namespace BestBuyBestPractices
{
    public interface IDepartmentRepository 
    {
        IEnumerable<Department> GetAllDepartments();
    }
}
