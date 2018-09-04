using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using sathishtsTest.Models;

namespace sathishtsTest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        List<SampleDataModel> SampleData = new List<SampleDataModel>();
        public ValuesController()
        {
            SampleData.Add(new SampleDataModel()
            {

                _Id = "3f2b12b8-2a06-45b4-b057-45949279b4e5",
                _ApplicationId = 197104,
                _Type = "Debit",
                _Summary = "Payment",
                _Amount = 58.26,
                _PostingDate = Convert.ToDateTime("2016-07-01T00:00:00"),
                _IsCleared = true,
                _ClearedDate = Convert.ToDateTime("2016-07-02T00:00:00")
            });
            SampleData.Add(new SampleDataModel
            {

                _Id = "d2032222-47a6-4048-9894-11ab8ebb9f69",
                _ApplicationId = 197104,
                _Type = "Debit",
                _Summary = "Payment",
                _Amount = 50.09,
                _PostingDate = Convert.ToDateTime("2016-08-01T00:00:00"),
                _IsCleared = true,
                _ClearedDate = Convert.ToDateTime("2016-08-02T00:00:00")
            });
            SampleData.Add(new SampleDataModel
            {

                _Id = "d8f156f3-bd57-49c3-9dcb-fcaaa52308f5",
                _ApplicationId = 197104,
                _Type = "Debit",
                _Summary = "Payment",
                _Amount = 59.43,
                _PostingDate = Convert.ToDateTime("2016-09-01T00:00:00"),
                _IsCleared = true,
                _ClearedDate = Convert.ToDateTime("2016-09-02T00:00:00")
            });
            SampleData.Add(new SampleDataModel
            {

                _Id = "194f0d46-6b87-4b59-a73c-e543f035ae1a",
                _ApplicationId = 197104,
                _Type = "Debit",
                _Summary = "Payment",
                _Amount = 58.39,
                _PostingDate = Convert.ToDateTime("2016-10-01T00:00:00"),
                _IsCleared = true,
                _ClearedDate = Convert.ToDateTime("2016-10-02T00:00:00")
            });
            SampleData.Add(new SampleDataModel
            {

                _Id = "ba67f438-c016-473d-93f8-373ca5a80567",
                _ApplicationId = 197104,
                _Type = "Debit",
                _Summary = "Payment",
                _Amount = 57.55,
                _PostingDate = Convert.ToDateTime("2016-11-01T00:00:00"),
                _IsCleared = true,
                _ClearedDate = Convert.ToDateTime("2016-11-02T00:00:00")
            });
            SampleData.Add(new SampleDataModel
            {

                _Id = "f37dd903-f833-4bd2-9350-81b0e947d9ad",
                _ApplicationId = 197104,
                _Type = "Debit",
                _Summary = "Payment",
                _Amount = 51.23,
                _PostingDate = Convert.ToDateTime("2016-12-01T00:00:00"),
                _IsCleared = true,
                _ClearedDate = Convert.ToDateTime("2016-12-02T00:00:00")
            });
            SampleData.Add(new SampleDataModel
            {

                _Id = "fcd0ab16-9ccc-4a24-825b-d11c283c2d58",
                _ApplicationId = 197104,
                _Type = "Debit",
                _Summary = "Payment",
                _Amount = 59.03,
                _PostingDate = Convert.ToDateTime("2017-01-01T00:00:00"),
                _IsCleared = true,
                _ClearedDate = Convert.ToDateTime("2017-01-02T00:00:00")
            });
            SampleData.Add(new SampleDataModel
            {

                _Id = "b2874279-04e3-480e-9670-c4d4d3ed8a43",
                _ApplicationId = 456299,
                _Type = "Debit",
                _Summary = "Payment",
                _Amount = 51.51,
                _PostingDate = Convert.ToDateTime("2016-07-01T00:00:00"),
                _IsCleared = true,
                _ClearedDate = Convert.ToDateTime("2016-07-02T00:00:00")
            });
            SampleData.Add(new SampleDataModel
            {

                _Id = "fc099e30-6629-4015-a9e8-91edf442d69e",
                _ApplicationId = 456299,
                _Type = "Debit",
                _Summary = "Payment",
                _Amount = 59.10,
                _PostingDate = Convert.ToDateTime("2016-08-01T00:00:00"),
                _IsCleared = true,
                _ClearedDate = Convert.ToDateTime("2016-08-02T00:00:00")
            });
            SampleData.Add(new SampleDataModel
            {

                _Id = "5f19429f-3ab8-41b1-b058-66b1ff0f46bc",
                _ApplicationId = 456299,
                _Type = "Debit",
                _Summary = "Payment",
                _Amount = 53.73,
                _PostingDate = Convert.ToDateTime("2016-09-01T00:00:00"),
                _IsCleared = true,
                _ClearedDate = Convert.ToDateTime("2016-09-02T00:00:00")
            });
            SampleData.Add(new SampleDataModel
            {

                _Id = "53f931be-6f8e-44ea-913f-051aa2cc7b6e",
                _ApplicationId = 456299,
                _Type = "Debit",
                _Summary = "Payment",
                _Amount = 52.07,
                _PostingDate = Convert.ToDateTime("2016-10-01T00:00:00"),
                _IsCleared = true,
                _ClearedDate = Convert.ToDateTime("2016-10-02T00:00:00")
            });
            SampleData.Add(new SampleDataModel
            {

                _Id = "66d28c93-3002-4816-b65c-f4777152faaa",
                _ApplicationId = 456299,
                _Type = "Debit",
                _Summary = "Payment",
                _Amount = 52.86,
                _PostingDate = Convert.ToDateTime("2016-11-01T00:00:00"),
                _IsCleared = true,
                _ClearedDate = Convert.ToDateTime("2016-11-02T00:00:00")
            });
            SampleData.Add(new SampleDataModel
            {

                _Id = "7557e1e0-6a60-495e-9e4d-df9cf6cc4c00",
                _ApplicationId = 456299,
                _Type = "Debit",
                _Summary = "Payment",
                _Amount = 53.82,
                _PostingDate = Convert.ToDateTime("2016-12-01T00:00:00"),
                _IsCleared = true,
                _ClearedDate = Convert.ToDateTime("2016-12-02T00:00:00")
            });
            SampleData.Add(new SampleDataModel
            {

                _Id = "0f6eb0a1-3e48-49b6-8990-705a962fb048",
                _ApplicationId = 456299,
                _Type = "Debit",
                _Summary = "Payment",
                _Amount = 52.92,
                _PostingDate = Convert.ToDateTime("2017-01-01T00:00:00"),
                _IsCleared = true,
                _ClearedDate = Convert.ToDateTime("2017-01-02T00:00:00")
            });
            SampleData.Add(new SampleDataModel
            {

                _Id = "2ce5dfae-3e59-4074-9601-beace62af588",
                _ApplicationId = 456299,
                _Type = "Credit",
                _Summary = "Refund",
                _Amount = 24.36,
                _PostingDate = Convert.ToDateTime("2017-01-19T00:00:00"),
                _IsCleared = true,
                _ClearedDate = Convert.ToDateTime("2017-01-20T00:00:00")
            });
            SampleData.Add(new SampleDataModel
            {

                _Id = "2b5192b3-61f6-4635-adba-69b1b3ff3718",
                _ApplicationId = 456299,
                _Type = "Credit",
                _Summary = "Refund",
                _Amount = 8.62,
                _PostingDate = Convert.ToDateTime("2017-01-22T00:00:00"),
                _IsCleared = false,
                _ClearedDate = null
            });
            SampleData.Add(new SampleDataModel
            {

                _Id = "7a66f608-2979-4b79-ba2e-d9b4d573b294",
                _ApplicationId = 456299,
                _Type = "Debit",
                _Summary = "Payment",
                _Amount = 95.11,
                _PostingDate = Convert.ToDateTime("2017-01-23T00:00:00"),
                _IsCleared = false,
                _ClearedDate = null
            });
        }
        public IEnumerable<SampleDataModel> Get()
        {
            return SampleData.ToList();

        }

        // GET api/values/5
        public SampleDataModel Get(string id)
        {
            // var query = from c in SampleData.AsEnumerable().Where(p => p._Id == id).Select().fist
            return (from c in SampleData.AsEnumerable().Where(p => p._Id == id) select c).FirstOrDefault();
            

        }

        // POST api/values
        public void Post([FromBody]SampleDataModel value)
        {
            SampleData.Add(value);
        }

        // PUT api/values/5
        public void Put(string id, [FromBody]SampleDataModel value)
        {
            var query = (from c in SampleData.AsEnumerable().Where(p => p._Id == id) select c).FirstOrDefault();
            query._ApplicationId = value._ApplicationId;
            query._Amount = value._Amount;
            query._ClearedDate = value._ClearedDate;
            query._IsCleared = value._IsCleared;
            query._PostingDate = value._PostingDate;
            query._Summary = value._Summary;
            query._Type = value._Type;

        }

        // DELETE api/values/5
        public void Delete(string id)
        {
            var query = (from c in SampleData.AsEnumerable().Where(p => p._Id == id) select c).FirstOrDefault();
            SampleData.Remove(query);
        }
    }
}
