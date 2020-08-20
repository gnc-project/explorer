﻿using NBitcoin;
using Stratis.Bitcoin.Base;
using Stratis.Bitcoin.Configuration;
using Stratis.Bitcoin.Connection;
using Stratis.Bitcoin.Features.BlockStore;
using Stratis.Bitcoin.Utilities;

namespace Stratis.Bitcoin.Features.IndexStore
{
    public class IndexStoreManager : BlockStoreManager
    {
        public IndexStoreManager(ConcurrentChain chain, IConnectionManager connection, IIndexRepository indexRepository,
            IDateTimeProvider dateTimeProvider, NodeSettings nodeArgs, ChainState chainState, IndexStoreLoop indexStoreLoop) :
            base(chain, connection, indexRepository, dateTimeProvider, nodeArgs, chainState, indexStoreLoop)
        {

        }

        public IIndexRepository IndexRepository { get { return this.BlockRepository as IIndexRepository; } }
    }
}
