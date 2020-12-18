using System;
using System.Collections.Generic;
using System.Text;

namespace StudyWithNgoc.Data.Entities
{
    public class tblClass
    {
        public int ID { get; set; }
        public string ClassName { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDay { get; set; }
        public DateTime UpdateTime { get; set; }
        public int UserCreate { get; set; }
        public int LevelClass { get; set; }
    }
}
