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
        public string exercise;
        public double timeSpan;
        public double calories;
        public DateTime date;

        public double WorkOutCalories()
        {
            double caloriesBurned;
            string workOutType = exercise.ToLower();

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

            return caloriesBurned * duration;
        }
          
        public Fitness (string type, double duration)
        {
            exercise = type;
            timeSpan = duration;
            calories = WorkOutCalories();
        }

        public string Summary()
        {
            return $"{date} - {exercise} for {timeSpan} mins => {calories} cal";
        }
    }
}
