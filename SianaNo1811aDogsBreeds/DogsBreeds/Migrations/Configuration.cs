namespace DogsBreeds.Migrations
{
    using DogsBreeds.Models;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DogsBreeds.Models.AnimalsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DogsBreeds.Models.AnimalsContext context)
        {
            // Добавяне на породи
            context.Breeds.AddOrUpdate(
                b => b.Name,
                new Breed { Name = "Лабрадор" },
                new Breed { Name = "Немска овчарка" },
                new Breed { Name = "Хъски" },
                new Breed { Name = "Голдън ретривър" },
                new Breed { Name = "Бийгъл" },
                new Breed { Name = "Булдог" },
                new Breed { Name = "Пудел" },
                new Breed { Name = "Смесена порода" },
                new Breed { Name = "Ротвайлер" },
                new Breed { Name = "Доберман" },
                new Breed { Name = "Кокер шпаньол" },
                new Breed { Name = "Чихуахуа" },
                new Breed { Name = "Померан" },
                new Breed { Name = "Ши-тцу" },
                new Breed { Name = "Мопс" },
                new Breed { Name = "Бордър коли" },
                new Breed { Name = "Акита" },
                new Breed { Name = "Самоед" },
                new Breed { Name = "Далматинец" },
                new Breed { Name = "Санбернар" }
            );

            context.SaveChanges();

            // Добавяне на животни
            context.Animals.AddOrUpdate(
                a => a.Name,

                new Animal
                {
                    Name = "Рекс",
                    Description = "Средно едро куче с къса кафява козина. Обича топки и разходки.",
                    Age = 3,
                    BreedID = GetBreedId(context, "Лабрадор")
                },

                new Animal
                {
                    Name = "Бела",
                    Description = "Спокойна немска овчарка с изправени уши. Обича тренировки.",
                    Age = 2,
                    BreedID = GetBreedId(context, "Немска овчарка")
                },

                new Animal
                {
                    Name = "Макс",
                    Description = "Сиво-бяло хъски със сини очи. Обича да тича навън.",
                    Age = 4,
                    BreedID = GetBreedId(context, "Хъски")
                },

                new Animal
                {
                    Name = "Луна",
                    Description = "Златиста и дружелюбна. Обича деца и игри с пръчка.",
                    Age = 1,
                    BreedID = GetBreedId(context, "Голдън ретривър")
                },

                new Animal
                {
                    Name = "Чарли",
                    Description = "Малък бийгъл с дълги уши. Обича да души и да търси следи.",
                    Age = 2,
                    BreedID = GetBreedId(context, "Бийгъл")
                },

                new Animal
                {
                    Name = "Роки",
                    Description = "Набит булдог със спокоен характер. Обича да почива.",
                    Age = 5,
                    BreedID = GetBreedId(context, "Булдог")
                },

                new Animal
                {
                    Name = "Дейзи",
                    Description = "Бял пудел с пухкава козина. Обича внимание и гушкане.",
                    Age = 3,
                    BreedID = GetBreedId(context, "Пудел")
                },

                new Animal
                {
                    Name = "Мило",
                    Description = "Шарено куче от смесена порода. Обича игри и разходки.",
                    Age = 2,
                    BreedID = GetBreedId(context, "Смесена порода")
                },

                new Animal
                {
                    Name = "Арчи",
                    Description = "Силен ротвайлер с черно-кафява козина. Обича тренировки.",
                    Age = 2,
                    BreedID = GetBreedId(context, "Ротвайлер")
                },

                new Animal
                {
                    Name = "Лъки",
                    Description = "Елегантен доберман с къса козина. Обича тичане.",
                    Age = 4,
                    BreedID = GetBreedId(context, "Доберман")
                },

                new Animal
                {
                    Name = "Шаро",
                    Description = "Кокер шпаньол с кафяви петна. Обича деца и игри.",
                    Age = 3,
                    BreedID = GetBreedId(context, "Кокер шпаньол")
                },

                new Animal
                {
                    Name = "Томи",
                    Description = "Малка чихуахуа с големи очи. Обича да стои до хората.",
                    Age = 1,
                    BreedID = GetBreedId(context, "Чихуахуа")
                },

                new Animal
                {
                    Name = "Нора",
                    Description = "Пухкав померан с оранжева козина. Обича внимание.",
                    Age = 2,
                    BreedID = GetBreedId(context, "Померан")
                },

                new Animal
                {
                    Name = "Лили",
                    Description = "Ши-тцу с дълга мека козина. Обича спокойни разходки.",
                    Age = 3,
                    BreedID = GetBreedId(context, "Ши-тцу")
                },

                new Animal
                {
                    Name = "Пухчо",
                    Description = "Мопс с весело изражение. Обича да спи и да се гушка.",
                    Age = 2,
                    BreedID = GetBreedId(context, "Мопс")
                },

                new Animal
                {
                    Name = "Боби",
                    Description = "Бордър коли с черно-бяла козина. Обича команди и препятствия.",
                    Age = 5,
                    BreedID = GetBreedId(context, "Бордър коли")
                },

                new Animal
                {
                    Name = "Зара",
                    Description = "Акита с гъста козина и спокоен характер. Обича дълги разходки.",
                    Age = 3,
                    BreedID = GetBreedId(context, "Акита")
                },

                new Animal
                {
                    Name = "Снежи",
                    Description = "Самоед със снежнобяла козина. Обича студено време и игри.",
                    Age = 2,
                    BreedID = GetBreedId(context, "Самоед")
                },

                new Animal
                {
                    Name = "Рони",
                    Description = "Далматинец с черни петна. Обича движение и бягане.",
                    Age = 4,
                    BreedID = GetBreedId(context, "Далматинец")
                },

                new Animal
                {
                    Name = "Мечо",
                    Description = "Едър санбернар с гъста козина. Обича спокойствие.",
                    Age = 6,
                    BreedID = GetBreedId(context, "Санбернар")
                },

                new Animal
                {
                    Name = "Тайсън",
                    Description = "Мускулест ротвайлер. Обича пазене, обучение и активност.",
                    Age = 4,
                    BreedID = GetBreedId(context, "Ротвайлер")
                },

                new Animal
                {
                    Name = "Ая",
                    Description = "Хъски със светла козина и сини очи. Обича бягане.",
                    Age = 2,
                    BreedID = GetBreedId(context, "Хъски")
                },

                new Animal
                {
                    Name = "Бруно",
                    Description = "Немска овчарка със силно тяло. Обича упражнения и команди.",
                    Age = 5,
                    BreedID = GetBreedId(context, "Немска овчарка")
                },

                new Animal
                {
                    Name = "Кая",
                    Description = "Голдън ретривър с мека козина. Обича плуване и хора.",
                    Age = 3,
                    BreedID = GetBreedId(context, "Голдън ретривър")
                },

                new Animal
                {
                    Name = "Сами",
                    Description = "Лабрадор с кремава козина. Обича вода и апортиране.",
                    Age = 2,
                    BreedID = GetBreedId(context, "Лабрадор")
                }
            );

            context.SaveChanges();
        }

        private int GetBreedId(DogsBreeds.Models.AnimalsContext context, string breedName)
        {
            return context.Breeds.First(b => b.Name == breedName).Id;
        }
    }
}
