using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrapPlay.Models
{
    public class MulitModel
    {
        public string GroupName { get; set; }
        public IEnumerable<itemfoo> FooThings {get; set;}

    }
    public class itemfoo
    {
        public int Id { get; set; }
        public string Foo { get; set; }
    }
        
}