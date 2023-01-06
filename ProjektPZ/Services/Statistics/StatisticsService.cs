namespace ProjektPZ.Services.Statistics
{
    using System.Linq;
    using ProjektPZ.Data;

    public class StatisticsService : IStatisticsService
    {
        private readonly ProjektPZDbContext data;

        public StatisticsService(ProjektPZDbContext data)
            => this.data = data;

        public StatisticsServiceModel Total()
        {
            var totalCars = this.data.Cars.Count(c => c.IsPublic);
            var totalUsers = this.data.Users.Count();

            return new StatisticsServiceModel
            {
                TotalCars = totalCars,
                TotalUsers = totalUsers
            };
        }
    }
}
