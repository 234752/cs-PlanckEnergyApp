namespace PlanckEnergyMVC.Models
{
    public class RowItem1Model
    {
        private string description;
        //To be finished, when icons are figured out.
        //private bool isSuccess;

        public string Description { get { return description; } }
        //public bool IsSuccess { get { return isSuccess; } set { IsSuccess = value; } }

        //Should be obsolete, once the database is connected.
        public RowItem1Model(string desc) 
        {
            description = desc;
        }
    }
}
