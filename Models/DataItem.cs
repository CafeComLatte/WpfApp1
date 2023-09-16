namespace Models
{

    public class DataItem
    {
        public string ProductName { get; set; }
        public string Process { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string Image { get; set; }
        public string Register { get; set; }

        public int QueryType { get; set; }

        
        
    }

    public class OriginDataItem
    {
        public OriginDataItem(DataItem item) {
            if(item != null)
            {
                this.OriginProductName = item.ProductName;
                this.OriginProcess = item.Process;
                this.OriginWeight = item.Weight;
                this.OriginHeight = item.Height;
                this.OriginImage = item.Image;
                this.OriginRegister = item.Register;
            }
        }
        public string OriginProductName { get; set; }
        public string OriginProcess { get; set; }
        public string OriginWeight { get; set; }
        public string OriginHeight { get; set; }
        public string OriginImage { get; set; }
        public string OriginRegister { get; set; }

    }

}

