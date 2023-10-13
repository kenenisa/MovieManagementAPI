using System;
using Xunit;
using MovieManagementAPI.Application.Movie; // Add the correct namespace for your MovieService

namespace MovieManagementAPI.Tests.Features.Movie
{
    public class MovieServiceTests
    {
        [Fact]
        public void CalculateTotalPrice_ValidInput_ShouldReturnCorrectTotalPrice()
        {
            // Arrange
            var movieService = new MovieService(); // Initialize your MovieService

            // Act
            var totalPrice = movieService.CalculateTotalPrice(5, 10); // Assume CalculateTotalPrice takes quantity and price

            // Assert
            Assert.Equal(50, totalPrice); // Assuming 5 * 10 should be 50
        }
    }

    internal class MovieService
    {
        public MovieService()
        {
        }

        internal object CalculateTotalPrice(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
