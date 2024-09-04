using System;
using homework_3.Models;

namespace homework_3.Services
{
	public static class MovieService
	{
        private static List<Movie> Movies { get; set; }

        public static void Seed()
        {
            Movies = new List<Movie>()
            {
                new Movie()
                {
                    Id = 1,
                    Title = "Підбурювачі",
                    Poster = "https://uaserials.pro/posters/8929.jpg",
                    Director = "Даг Лайман",
                    Style = "Кримінал",
                    ShortDescription =
                        "Рорі та Коббі — несподівані спільники: батько, що зневірився, і колишній" +
                        "в'язень, які об'єдналися для пограбування. Коли все йде не за планом, вони, разом з" +
                        "несподіваним спільником, психотерапевтом Рорі, намагаються втекти від поліції та мстивого" +
                        "ватажка гангстерів.",
                    Sessions = new List<Session>()
                    {
                        new Session()
                        {
                            Id = 1,
                            Date = new DateTime(2024, 12, 13),
                            Time = new TimeOnly(17, 30)
                        },
                        new Session()
                        {
                            Id = 2,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(13, 20)
                        },
                        new Session()
                        {
                            Id = 3,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(17, 30)
                        },
                    }
                },
                new Movie()
                {
                    Id = 2,
                    Title = "Королівство планети мавп",
                    Poster = "https://uaserials.pro/posters/8871.jpg",
                    Director = "Вес Болл",
                    Style = "Фантастика",
                    ShortDescription =
                        "Мавпи — домінуючий вид, який гармонійно співіснує, а люди приречені на життя" +
                        "в тіні. Поки новий тиранічний мавпячий вождь будує свою імперію, одна молода мавпа вирушає" +
                        "у виснажливу подорож. Ця мандрівка змусить поставити під сумнів усе, що вона знала про" +
                        "минуле, і зробити вибір, який визначить майбутнє як мавп, так і людей.",
                    Sessions = new List<Session>()
                    {
                        new Session()
                        {
                            Id = 1,
                            Date = new DateTime(2024, 12, 13),
                            Time = new TimeOnly(17, 30)
                        },
                        new Session()
                        {
                            Id = 2,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(13, 20)
                        },
                        new Session()
                        {
                            Id = 3,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(17, 30)
                        },
                    }
                },
                new Movie()
                {
                    Id = 3,
                    Title = "Забери мене на місяць",
                    Poster = "https://uaserials.pro/posters/8983.jpg",
                    Director = "Грег Берланті",
                    Style = "Комедія",
                    ShortDescription =
                        "У 1961 році, на тлі досягнень Радянського Союзу в космічних перегонах," +
                        "президент США Джон Ф. Кеннеді оголошує на всю країну, що протягом цього десятиліття" +
                        "американська нація зможе відправити людину на Місяць. Так починається програма пілотованих" +
                        "польотів у космос «Аполлон», яка через дорожнечу та безліч аварій не користується" +
                        "підтримкою громадськості. НАСА наймає спеціаліста з маркетингу Келлі Джонс, щоб покращити" +
                        "суспільний імідж космічної програми, а також доручає їй зняти фальшиву висадку на Місяць на" +
                        "випадок, якщо справжній політ зазнає невдачі...",
                    Sessions = new List<Session>()
                    {
                        new Session()
                        {
                            Id = 1,
                            Date = new DateTime(2024, 12, 13),
                            Time = new TimeOnly(17, 30)
                        },
                        new Session()
                        {
                            Id = 2,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(13, 20)
                        },
                        new Session()
                        {
                            Id = 3,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(17, 30)
                        },
                    }
                },
                new Movie()
                {
                    Id = 4,
                    Title = "Казки на ніч",
                    Poster = "https://uaserials.pro/posters/8988.jpg",
                    Director = "Адам Шенкман",
                    Style = "Комедія",
                    ShortDescription =
                        "Якось увечері, залишившись придивитися за своїми племінниками, Скітер" +
                        "Бронсон розповідає казку на ніч, ще не підозрюючи, що вигадані персонажі почнуть оживати...",
                    Sessions = new List<Session>()
                    {
                        new Session()
                        {
                            Id = 1,
                            Date = new DateTime(2024, 12, 13),
                            Time = new TimeOnly(17, 30)
                        },
                        new Session()
                        {
                            Id = 2,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(13, 20)
                        },
                        new Session()
                        {
                            Id = 3,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(17, 30)
                        },
                    }
                },
                new Movie()
                {
                    Id = 5,
                    Title = "Каскадер",
                    Poster = "https://uaserials.pro/posters/8678.jpg",
                    Director = "Девід Літч",
                    Style = "Комедія",
                    ShortDescription =
                        "Після травми на зйомках каскадер Кольт Сіверс вже півтора року як пішов із професії, працює" +
                        "паркувальником і звинувачує себе за той невдалий трюк. Раптом йому дзвонить продюсерка та" +
                        "просить терміново прилетіти до Австралії, де його колишня дівчина-оператор Джоді знімає" +
                        "свій режисерський дебют, масштабну фантастику «Металшторм». Після приїзду з'ясовується, що" +
                        "Джоді бачити його не рада, а також справа ускладняться зникненням виконавця головної ролі —" +
                        "зірки бойовиків, у якого Кольт колись був дублером...",
                    Sessions = new List<Session>()
                    {
                        new Session()
                        {
                            Id = 1,
                            Date = new DateTime(2024, 12, 13),
                            Time = new TimeOnly(17, 30)
                        },
                        new Session()
                        {
                            Id = 2,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(13, 20)
                        },
                        new Session()
                        {
                            Id = 3,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(17, 30)
                        },
                    }
                },
            };
        }

        public static List<Movie> GetAll() => Movies;

        public static Movie GetById(int id) => Movies.FirstOrDefault(movie => movie.Id == id)!;
    }
}

