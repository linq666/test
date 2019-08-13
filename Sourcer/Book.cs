using System;
using System.Collections.Generic;
using System.Text;

namespace Sourcer
{
    public class Book
    {
        public int Id { get; set; }
        //书名
        public string BookName { get; set; }
        
        //作者姓名（一本书有一个位作者）fk.
        public int AuthorId { get; set; }
        //导航属性，一本书有一个作者 nva. prop.
        public Author Author { get; set; }

    }
}
