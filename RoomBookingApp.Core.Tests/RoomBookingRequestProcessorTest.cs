using System;
using Xunit;

namespace RoomBookingApp.Core
{
    public  class RoomBookingRequestProcessorTest
    {
        [Fact]
        public void Should_Return_Room_Booking_Request()
        {
            //Arange
            var request = new RoomBookingRequest
            {
                FullName="testName",
                Email="test@testRequest.com",
                Date=new DateTime(2023,01,27)

            };
            var Processor = new RoomBokingReturnProcessor();

            //Act

            RoomBookingResult result = Processor.ProcessRequest(request);

            //Assert

            Assert.NotNull(request);
            Assert.Equal(request.FullName, result.FullName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Date, result.Date);
        }
    }
}
