using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocalBackend.DataObjects
{
    public class Official : EntityData
    {
        public string Name { get; set; }

        public string Position { get; set; }

        public string MuniCode { get; set; }

        public string ImageUrl { get; set; }

        public string Municipality { get; set; }
    }
}