using System;
using System.Collections.Generic;

#nullable disable

namespace prs_serever_mvc.models
{
    public partial class RequestLine
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }

        public virtual Product Product { get; set; }
        public virtual Request Request { get; set; }
    }
}
