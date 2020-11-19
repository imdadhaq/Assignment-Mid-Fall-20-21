namespace Project
{
    public class Course
    {
        public teacher Teacher;
         private string cname;
         private string cnum;
        
                public string Cname
                {
                    get => cname;
                    set => cname = value;
                }
                
        
                public string Cnum
                {
                    get => cnum; 
                    set => cnum = value;
                }
    }
}