using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VeterinarskaStanica.Web.Models
{
    public class UploadForm
    {
       
        public HttpPostedFileBase file { get; set; }

        public IEnumerable<HttpPostedFileBase> files { get; set; }
        
    }
}