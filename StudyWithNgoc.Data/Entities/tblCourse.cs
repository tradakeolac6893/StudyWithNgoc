using System;
using System.Collections.Generic;
using System.Text;

namespace StudyWithNgoc.Data.Entities
{
    public class tblCourse
    {
        public int ID { get; set; }
        public string CourseName { get; set; }
        public int Subject { get; set; }
        public tblClass Class { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDay { get; set; }
        public DateTime UpdateTime { get; set; }
        public int UserCreate { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Sale { get; set; }
        //public  tblUser teacher { get; set; }//infor Teacher is infor usser
    }
}
