using System;

namespace RoomBookingApp.Core
{
    public class RoomBokingReturnProcessor
    {
        public RoomBokingReturnProcessor()
        {
        }

        public RoomBookingResult ProcessRequest(RoomBookingRequest request)
        {
            return new RoomBookingResult
            {
                FullName=request.FullName,
                Email=request.Email,
                Date=request.Date
            };
        }

    }
}