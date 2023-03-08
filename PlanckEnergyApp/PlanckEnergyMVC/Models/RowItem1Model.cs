namespace PlanckEnergyMVC.Models
{
    public class RowItem1Model
    {
        private string description;
        private string description1;
        private string description2;
        private string description3;

        //To be finished, when icons are figured out.
        //private bool isSuccess;

        public string Description { get { return description; } }
        public string Description1 { get { return description1; } }
        public string Description2 { get { return description2; } }
        public string Description3 { get { return description3; } }
        //public bool IsSuccess { get { return isSuccess; } set { IsSuccess = value; } }

        //Should be obsolete, once the database is connected.
        public RowItem1Model(string desc) 
        {
            description = desc;
        }
        
        public RowItem1Model(string d, string d1, string d2, string d3) 
        {
            description = d;
            description1 = d1;
            description2 = d2;
            description3 = d3;
        }
    }
}
