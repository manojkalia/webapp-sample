using SampleApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Service.Provider
{
  public  interface IProvider
    {
      ProviderModel GetProvider(int id);
    }
}
