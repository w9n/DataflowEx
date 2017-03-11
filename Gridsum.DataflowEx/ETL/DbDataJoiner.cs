namespace Gridsum.DataflowEx.ETL
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Threading.Tasks;
    using System.Threading.Tasks.Dataflow;

    using Common.Logging;

    using Gridsum.DataflowEx.AutoCompletion;

    /// <summary>
    /// A wrapper for a data batch
    /// </summary>
    public struct JoinBatch<TIn> where TIn : class
    {
        public readonly TIn[] Data;
        public readonly CacheLookupStrategy Strategy;
        
        public JoinBatch(TIn[] batch, CacheLookupStrategy strategy)
        {
            Strategy = strategy;
            this.Data = batch;
        }
    }

    public enum CacheLookupStrategy
    {
        NoLookup,
        LocalLookup,
        RemoteLookup,
    }


}
