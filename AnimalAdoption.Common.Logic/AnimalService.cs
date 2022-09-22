using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "Garfield", Age = 50, Description = "fluffy cat" },
            new Animal { Id = 2, Name = "Tom", Age = 50, Description = "Tom from Tom & Jerry" },
            new Animal { Id = 3, Name = "Thundercat", Age = 80, Description = "One of my favorite cartoon" },
        };
    }
}
