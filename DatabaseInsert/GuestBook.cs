using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseInsert
{
    public partial class GuestBook
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Message { set; get; }
    }
}
