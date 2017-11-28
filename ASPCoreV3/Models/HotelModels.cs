using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreV3.Models
{
    public class HotelModels
    {
        /// <summary>
        /// Hotel Room Model
        /// </summary>
        public class HotelRoom
        {
            public Guid Id { get; set; } = Guid.NewGuid();
            public int RoomNumber { get; set; }
            public int NumberSingleBeds { get; set; }
            public int NumberDoubleBeds { get; set; }
            public int NumberExtraBeds { get; set; } = 0;
            public float PriceSingle { get; set; }
            public float PriceDouble { get; set; }
            public float? PricePerExtra { get; set; }//WARN:    check this value later in program
        }

        /// <summary>
        /// Hotel Guest Model
        /// </summary>
        public class HotelGuest
        {
            public Guid Id { get; set; } = Guid.NewGuid();
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public int NumberOfGuests { get; set; }
            public int RoomBooked { get; set; }
            public HotelBooking Booking { get; set; }
            public int HotelBookingId { get; set; }
            public DateTimeOffset CheckIn { get; set; }
            public DateTimeOffset CheckOut { get; set; }
            public DateTimeOffset BookingDate { get; set; } = DateTimeOffset.Now;
        }

        /// <summary>
        /// Hotel Bill Model
        /// </summary>
        public class HotelBill
        {
            public Guid Id { get; set; } = Guid.NewGuid();
            public HotelGuest Guest { get; set; }
            public int HotelGuestId { get; set; }
            public float BarCharge { get; set; } = 0;
            public float WiFiCharge { get; set; } = 0;
            public float TelephoneCharge { get; set; } = 0;
            public float RoomCharge { get; set; }
        }

        /// <summary>
        /// Hotel Booking Model
        /// </summary>
        public class HotelBooking
        {
            public Guid Id { get; set; } = Guid.NewGuid();
            public HotelRoom Room { get; set; }
            public int HotelRoomId { get; set; }
            public DateTimeOffset BookingFrom { get; set; }
            public DateTimeOffset BookingTo { get; set; }
            public float RoomCost { get; set; }
        }

    }
}
