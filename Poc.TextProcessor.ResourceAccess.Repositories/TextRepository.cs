﻿using Poc.TextProcessor.CrossCutting.Utils;
using Poc.TextProcessor.ResourceAccess.Database.Abstractions;
using Poc.TextProcessor.ResourceAccess.Domains;
using Poc.TextProcessor.ResourceAccess.Entities;
using Poc.TextProcessor.ResourceAccess.Repositories.Abstractions;
using Poc.TextProcessor.ResourceAccess.Repositories.Base;

namespace Poc.TextProcessor.ResourceAccess.Repositories
{
    public class TextRepository(IDatabaseProvider databaseProvider) : RepositoryBase(databaseProvider), ITextRepository
    {
        public Text Get(int id)
        {
            var text = _databaseProvider.Get<TextEntity>(x => x.Id == id).Single();
            return AutoMap.Map<TextEntity, Text>(text);
        }
    }
}