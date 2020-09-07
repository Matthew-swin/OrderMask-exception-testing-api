using System;

namespace MaskApi.models
{
    public class Order
    {
        public int OrderNo { get; set; }
        public Mask Mask { get; set; }
        public int Qty { get; set;}
        public double Price { get; set; }

        public Order(Mask mask, int qty)
        {
            this.OrderNo = this.GenerateOrderNo();
            this.Mask = mask;
            this.Qty = qty;
            //the price is being set in the below method will cause issue if have this.price as its void
            //could also work if in method have return this.Qty * Mask.Cost
            this.SetPrice();
        }
        public void SetPrice(){
            this.Price = this.Qty * Mask.Cost;
        }

        public int GenerateOrderNo(){
            Random rand = new Random();
            return rand.Next(1000,10000);
        }
    }
}