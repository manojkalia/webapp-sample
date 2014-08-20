using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.Entities.Domain;
using SampleApp.Entities.Models;

namespace SampleApp.Service.Mappers
{
   public class ConsultantMapper
    {
        public static ConsultantModel ConvertEntityToModel(Consultant consultant)
        {
            ConsultantModel consultantModel = new ConsultantModel();
            consultantModel.Id = consultant.Id;
<<<<<<< HEAD
            consultantModel.Name = consultant.Name;
=======
            consultantModel.Name = consultant.Name;
>>>>>>> 2f9878a32a525f628e354fd8e385615d76fc0ed6
            consultantModel.ConsultantProviderIds = consultant.ProviderConsultant.Select(x => x.ProviderId).ToList();
            //consultantModel.ProviderConsultant = consultant...;

            return consultantModel;
        }


        public static Consultant ConvertModelToEntity(ConsultantModel consultantModel)
        {
            Consultant consultant = new Consultant();
            consultant.Id = consultantModel.Id;
            consultant.Name = consultantModel.Name;
            //consultant.ProviderConsultant = consultantModel.ProviderConsultant;

            return consultant;
        }
    }
}
