﻿using System.Collections.Generic;
using SampleApp.Entities.Models;

namespace SampleApp.Core.Interfaces.Services
{
    public interface IProvider
    {
        ProviderModel GetProvider(int id);
        List<ProviderModel> GetAllProviders();
        bool Delete(int id);
        bool Insert(ProviderModel providerModel);
        bool Update(ProviderModel providerModel);
    }
}
