using System;
using System.ComponentModel.DataAnnotations;

namespace HotelBookingsManagementSystem.Models.NewBookingsFactoryModels
{
	public class NewBookingsFactory
	{
		public int RoomNumber { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MinLength(3, ErrorMessage = "Name must have 3 or more characters.")]
		public required string ClientName { get; set; }

        [Required(ErrorMessage = "Surname is required.")]
        [MinLength(3, ErrorMessage = "Surname must have 3 or more characters.")]
        public required string ClientSurname { get; set; }

		public DateTime CheckInDate { get; set; }
		public DateTime CheckOutDate { get; set; }
		public double RoomRate { get; set; }

		public virtual double PriceOfStay()
		{
			var numberOfDays = (CheckOutDate - CheckInDate).Days;
			var price = numberOfDays * RoomRate;
			return price;
		}

	}
}

