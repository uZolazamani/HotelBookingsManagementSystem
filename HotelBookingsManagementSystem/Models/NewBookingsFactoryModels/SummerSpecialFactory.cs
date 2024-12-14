using System;
namespace HotelBookingsManagementSystem.Models.NewBookingsFactoryModels
{
	public class SummerSpecialFactory : NewBookingsFactory
	{
		public double SummerSpecialRate { get; set; }
        public override double PriceOfStay()
        {
            return base.PriceOfStay()*SummerSpecialRate;
        }
    }
}

