using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocalBackend.DataObjects
{
    public class Municipality : EntityData
    {
        public string Name { get; set; }

        public string Population { get; set; }

        public string MuniCode { get; set; }

        public string MuniName { get; set; }

        public string ImageUrl { get; set; }

        public string Info { get; set; }
    }
}