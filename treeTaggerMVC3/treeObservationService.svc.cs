using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Data.Objects;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;
using treeTaggerMVC3.Models;
using System.Data.Entity.Infrastructure;

namespace treeTaggerMVC3
{
    public class treeObservationService : DataService< treeTaggerMVC3Entities>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            config.SetEntitySetAccessRule("treeObservations", EntitySetRights.AllRead);
           // config.SetServiceOperationAccessRule("treeObservationService", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
        }

        //protected override ObjectContext CreateDataSource()
        //{
        //    var ctx = ((IObjectContextAdapter)new treeOBSEntities()).ObjectContext;
        //    ctx.ContextOptions.ProxyCreationEnabled = false;
        //    return ctx;
        //}
    }
}
