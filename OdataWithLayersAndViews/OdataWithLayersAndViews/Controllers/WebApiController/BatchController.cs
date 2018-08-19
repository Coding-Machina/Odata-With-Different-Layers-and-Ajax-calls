using Microsoft.AspNet.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BM.EF;
using BM.BF;

namespace OdataWithLayersAndViews.Controllers.WebApiController
{
    public class BatchController : ODataController
    {
        [EnableQuery]
        [System.Web.Http.HttpGet]
        public IQueryable<BatchManagement> Get()
        {
            BatchService batchService = new BatchService();
            return batchService.GetItem();
        }

        public IHttpActionResult Post(BatchManagement batch)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            BatchService batchService = new BatchService();
            return Created(batchService.AddItem(batch));
        }
    }
}
