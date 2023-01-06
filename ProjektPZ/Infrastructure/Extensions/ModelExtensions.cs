namespace ProjektPZ.Infrastructure.Extensions
{
    using ProjektPZ.Services.Cars.Models;
    using System.ComponentModel;

    public static class ModelExtensions
    {
        public static string GetInformation(this ICarModel car)
            => car.Brand + "-" + car.Model + "-" + car.Year + "-";
    }
}
