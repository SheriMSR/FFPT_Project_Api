﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFPT_Service.Models.Response
{
    public class BaseResponsePagingViewModel<T>
    {
        public PagingMetadata Metadata { get; set; }
        public List<T> Data { get; set; }
    }
    public class PagingMetadata
    {
        public int Page { get; set; }
        public int Size { get; set; }
        public int Total { get; set; }
    }
}
