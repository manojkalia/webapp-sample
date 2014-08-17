using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.Entities.Models;

namespace SampleApp.Core.Interfaces.Services
{
    public interface IConsultant
    {
        ConsultantModel GetConsultant(int id);
        List<ConsultantModel> GetAllConsultants();
        bool Delete(int id);
        bool Insert(ConsultantModel contractModel);
        bool Update(ConsultantModel contractModel);
    }
}
