using System;
using Applied_Activity_2.Model;
using Applied_Activity_2.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Applied_Activity_2.Services
{
    interface IHolidayDataStore<Holiday>
    {
        Task<IEnumerable<Holiday>> GetHolidayAsync();

    }
}
