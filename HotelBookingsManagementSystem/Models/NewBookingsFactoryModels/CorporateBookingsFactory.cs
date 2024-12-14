using System;
namespace HotelBookingsManagementSystem.Models.NewBookingsFactoryModels
{
	public class CorporateBookingsFactory : NewBookingsFactory
	{
		public double CorporateRate { get; set; }
		public override double PriceOfStay()
		{
			return base.PriceOfStay() * CorporateRate;
		}
	}
}

