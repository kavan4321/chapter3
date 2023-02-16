
namespace chapter3.Model
{
    public  class Page5Model
    {
        public double ModeloPrize
        {
            get => 3.55;
            set { }
        }
        public bool ModeloCheck { get; set; }
        public int ModeloValue { get; set; }


        public double SurelyPrize
        {
            get => 6.99;
            set { }
        }
        public bool SurelyCheck { get; set; }
        public int SurelyValue { get; set; }


        public double BaiPrize
        {
            get => 1.23;
            set { }
        }
        public bool BaiCheck { get; set; }
        public int BaiValue { get; set; }

        public string PromoCode { get; set; }
             
        public double SubTotal { get; set; }

        public double Shipping
        {
            get => 2.99;
            set { }
        }

        public int Item { get; set; }
        public double CheckOut { get; set; }

    }
}
