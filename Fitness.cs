using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fit_X
{
    class Fitness
    {
        public string Exercise;
        public double Duration;
        public double Calories;
        public DateTime Date;

        public double workOutCalories()
        {
            double caloriesBurned;
            string workOutType = Exercise.ToLower();

            if (workOutType == "jogging")
            {
                caloriesBurned = 8;
            }

            else if (workOutType == "cycling")
            {
                caloriesBurned = 10;
            }
            else if (workOutType == "swimming")
            {
                caloriesBurned = 18;
            }
            else if (workOutType == "squating")
            {
                caloriesBurned = 15;
            }
            else
            {
                caloriesBurned = 7;
            }

            return caloriesBurned * Duration;
        }
          
        public Fitness (string type, double duration)
        {
            Exercise = type;
            Duration = duration;
            Calories = workOutCalories();
        }

        public string summary()
        {
            return $"{Date} - {Exercise} for {Duration} mins => {Calories} cal";
        }
    }
}
