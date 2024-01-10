﻿using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Kar.Web3.Eth.MongoDB;

[ConnectionStringName(EthDbProperties.ConnectionStringName)]
public class EthMongoDbContext : AbpMongoDbContext, IEthMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureEth();
    }
}
