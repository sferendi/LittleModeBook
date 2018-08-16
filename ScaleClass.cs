using System;
namespace MyLittleModeBook
{
    public class ScaleClass
    {
        public string name { get; set; }
        public string notes { get; set; }
        public string tone { get; set; }
        public int identiScale { get; set; }

        public ScaleClass(string sname, string spacing, string mood, int id)
        {
            this.name = sname;
            this.notes = spacing;
            this.tone = mood;
            this.identiScale = id;
        }
    }
}