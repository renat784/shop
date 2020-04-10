using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace shop.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Ad> Ads { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, Name = "Детский мир" },
                new Category() { CategoryId = 2, Name = "Недвижимость" },
                new Category() { CategoryId = 3, Name = "Транспорт" },
                new Category() { CategoryId = 4, Name = "Запчасти для транспорта" },
                new Category() { CategoryId = 5, Name = "Работа" },
                new Category() { CategoryId = 6, Name = "Животные" },
                new Category() { CategoryId = 7, Name = "Дом и сад" },
                new Category() { CategoryId = 8, Name = "Электроника" },
                new Category() { CategoryId = 9, Name = "Бизнес и услуги" },
                new Category() { CategoryId = 10, Name = "Мода и стиль" },
                new Category() { CategoryId = 11, Name = "Хобби, отдых и спорт" },
                new Category() { CategoryId = 12, Name = "Отдам даром" },
                new Category() { CategoryId = 13, Name = "Обмен" }
            );

            modelBuilder.Entity<SubCategory>().HasData(
                new SubCategory() { SubCategoryId = 1, CategoryId = 1, Name = "Детская одежда" },
                new SubCategory() { SubCategoryId = 2, CategoryId = 1, Name = "Детская обувь" },
                new SubCategory() { SubCategoryId = 3, CategoryId = 1, Name = "Детские коляски" },
                new SubCategory() { SubCategoryId = 4, CategoryId = 1, Name = "Детские автокресла" },
                new SubCategory() { SubCategoryId = 5, CategoryId = 1, Name = "Детская мебель" },
                new SubCategory() { SubCategoryId = 6, CategoryId = 1, Name = "Игрушки" },
                new SubCategory() { SubCategoryId = 7, CategoryId = 1, Name = "Детский транспорт" },
                new SubCategory() { SubCategoryId = 8, CategoryId = 1, Name = "Товары для кормления" },
                new SubCategory() { SubCategoryId = 9, CategoryId = 1, Name = "Товары для школьников" },
                new SubCategory() { SubCategoryId = 10, CategoryId = 1, Name = "Прочие детские товары" },

                new SubCategory() { SubCategoryId = 11, CategoryId = 2, Name = "Квартиры, комнаты" },
                new SubCategory() { SubCategoryId = 12, CategoryId = 2, Name = "Дома" },
                new SubCategory() { SubCategoryId = 13, CategoryId = 2, Name = "Земля" },
                new SubCategory() { SubCategoryId = 14, CategoryId = 2, Name = "Коммерческая недвижимость" },
                new SubCategory() { SubCategoryId = 15, CategoryId = 2, Name = "Гаражи, парковки" },
                new SubCategory() { SubCategoryId = 16, CategoryId = 2, Name = "Посуточная аренда жилья" },
                new SubCategory() { SubCategoryId = 17, CategoryId = 2, Name = "Предложения от застройщиков" },
                new SubCategory() { SubCategoryId = 18, CategoryId = 2, Name = "Недвижимость за рубежом" },

                new SubCategory() { SubCategoryId = 19, CategoryId = 3, Name = "Легковые автомобили" },
                new SubCategory() { SubCategoryId = 20, CategoryId = 3, Name = "Автомобили из Польши" },
                new SubCategory() { SubCategoryId = 21, CategoryId = 3, Name = "Грузовые автомобили" },
                new SubCategory() { SubCategoryId = 22, CategoryId = 3, Name = "Автобусы " },
                new SubCategory() { SubCategoryId = 23, CategoryId = 3, Name = "Мото" },
                new SubCategory() { SubCategoryId = 24, CategoryId = 3, Name = "Спецтехника" },
                new SubCategory() { SubCategoryId = 25, CategoryId = 3, Name = "Сельхозтехника" },
                new SubCategory() { SubCategoryId = 26, CategoryId = 3, Name = "Водный транспорт " },
                new SubCategory() { SubCategoryId = 27, CategoryId = 3, Name = "Воздушный транспорт" },
                new SubCategory() { SubCategoryId = 28, CategoryId = 3, Name = "Прицепы / дома на колесах" },
                new SubCategory() { SubCategoryId = 29, CategoryId = 3, Name = "Другой транспорт" },
                new SubCategory() { SubCategoryId = 30, CategoryId = 3, Name = "Запчасти для транспорта" },
                new SubCategory() { SubCategoryId = 31, CategoryId = 3, Name = "Нерастаможенные автомобили" },
                new SubCategory() { SubCategoryId = 32, CategoryId = 3, Name = "Электромобили" },

                new SubCategory() { SubCategoryId = 33, CategoryId = 4, Name = "Автозапчасти и аксессуары" },
                new SubCategory() { SubCategoryId = 34, CategoryId = 4, Name = "Шины, диски и колёса" },
                new SubCategory() { SubCategoryId = 35, CategoryId = 4, Name = "Запчасти для спец / с.х. техники" },
                new SubCategory() { SubCategoryId = 36, CategoryId = 4, Name = "Мотозапчасти и аксессуары" },
                new SubCategory() { SubCategoryId = 37, CategoryId = 4, Name = "Прочие запчасти" },
                new SubCategory() { SubCategoryId = 38, CategoryId = 4, Name = "Транспорт" },

                new SubCategory() { SubCategoryId = 39, CategoryId = 5, Name = "Розничная торговля / продажи / закупки" },
                new SubCategory() { SubCategoryId = 40, CategoryId = 5, Name = "Транспорт / логистика" },
                new SubCategory() { SubCategoryId = 41, CategoryId = 5, Name = "Строительство" },
                new SubCategory() { SubCategoryId = 42, CategoryId = 5, Name = "Телекоммуникации / связь" },
                new SubCategory() { SubCategoryId = 43, CategoryId = 5, Name = "Бары / рестораны" },
                new SubCategory() { SubCategoryId = 44, CategoryId = 5, Name = "Юриспруденция и бухгалтерия" },
                new SubCategory() { SubCategoryId = 45, CategoryId = 5, Name = "Управление персоналом / HR" },
                new SubCategory() { SubCategoryId = 46, CategoryId = 5, Name = "Охрана / безопасность" },
                new SubCategory() { SubCategoryId = 47, CategoryId = 5, Name = "Домашний персонал" },
                new SubCategory() { SubCategoryId = 48, CategoryId = 5, Name = "Красота / фитнес / спорт" },
                new SubCategory() { SubCategoryId = 49, CategoryId = 5, Name = "Туризм / отдых / развлечения" },
                new SubCategory() { SubCategoryId = 50, CategoryId = 5, Name = "Образование" },
                new SubCategory() { SubCategoryId = 51, CategoryId = 5, Name = "Культура / искусство" },
                new SubCategory() { SubCategoryId = 52, CategoryId = 5, Name = "Медицина / фармация" },
                new SubCategory() { SubCategoryId = 53, CategoryId = 5, Name = "ИТ / телеком / компьютеры" },
                new SubCategory() { SubCategoryId = 54, CategoryId = 5, Name = "Банки / финансы / страхование" },
                new SubCategory() { SubCategoryId = 55, CategoryId = 5, Name = "Недвижимость" },
                new SubCategory() { SubCategoryId = 56, CategoryId = 5, Name = "Маркетинг / реклама / дизайн" },
                new SubCategory() { SubCategoryId = 57, CategoryId = 5, Name = "Производство / энергетика" },
                new SubCategory() { SubCategoryId = 58, CategoryId = 5, Name = "Сельское хозяйство / агробизнес / лесное хозяйство" },
                new SubCategory() { SubCategoryId = 59, CategoryId = 5, Name = "Cекретариат / АХО" },
                new SubCategory() { SubCategoryId = 60, CategoryId = 5, Name = "Частичная занятость" },
                new SubCategory() { SubCategoryId = 61, CategoryId = 5, Name = "Начало карьеры / Студенты" },
                new SubCategory() { SubCategoryId = 62, CategoryId = 5, Name = "Сервис и быт" },
                new SubCategory() { SubCategoryId = 63, CategoryId = 5, Name = "Другие сферы занятий" },
                new SubCategory() { SubCategoryId = 64, CategoryId = 5, Name = "Работа за рубежом" },

                new SubCategory() { SubCategoryId = 65, CategoryId = 6, Name = "Бесплатно (животные и вязка)" },
                new SubCategory() { SubCategoryId = 66, CategoryId = 6, Name = "Собаки" },
                new SubCategory() { SubCategoryId = 67, CategoryId = 6, Name = "Кошки" },
                new SubCategory() { SubCategoryId = 68, CategoryId = 6, Name = "Аквариумистика" },
                new SubCategory() { SubCategoryId = 69, CategoryId = 6, Name = "Птицы" },
                new SubCategory() { SubCategoryId = 70, CategoryId = 6, Name = "Грызуны" },
                new SubCategory() { SubCategoryId = 71, CategoryId = 6, Name = "Рептилии" },
                new SubCategory() { SubCategoryId = 72, CategoryId = 6, Name = "Сельхоз животные" },
                new SubCategory() { SubCategoryId = 73, CategoryId = 6, Name = "Другие  животные" },
                new SubCategory() { SubCategoryId = 74, CategoryId = 6, Name = "Зоотовары" },
                new SubCategory() { SubCategoryId = 75, CategoryId = 6, Name = "Вязка" },
                new SubCategory() { SubCategoryId = 76, CategoryId = 6, Name = "Бюро находок" },

                new SubCategory() { SubCategoryId = 77, CategoryId = 7, Name = "Канцтовары / расходные материалы" },
                new SubCategory() { SubCategoryId = 78, CategoryId = 7, Name = "Мебель" },
                new SubCategory() { SubCategoryId = 79, CategoryId = 7, Name = "Продукты питания / напитки" },
                new SubCategory() { SubCategoryId = 80, CategoryId = 7, Name = "Сад / огород" },
                new SubCategory() { SubCategoryId = 81, CategoryId = 7, Name = "Предметы интерьера" },
                new SubCategory() { SubCategoryId = 82, CategoryId = 7, Name = "Строительство / ремонт" },
                new SubCategory() { SubCategoryId = 83, CategoryId = 7, Name = "Инструменты" },
                new SubCategory() { SubCategoryId = 84, CategoryId = 7, Name = "Комнатные растения" },
                new SubCategory() { SubCategoryId = 85, CategoryId = 7, Name = "Посуда / кухонная утварь" },
                new SubCategory() { SubCategoryId = 86, CategoryId = 7, Name = "Садовый инвентарь" },
                new SubCategory() { SubCategoryId = 87, CategoryId = 7, Name = "Хозяйственный инвентарь / бытовая химия" },
                new SubCategory() { SubCategoryId = 88, CategoryId = 7, Name = "Прочие товары для дома" },

                new SubCategory() { SubCategoryId = 89, CategoryId = 8, Name = "Телефоны и аксессуары" },
                new SubCategory() { SubCategoryId = 90, CategoryId = 8, Name = "Компьютеры и комплектующие" },
                new SubCategory() { SubCategoryId = 91, CategoryId = 8, Name = "Фото / видео" },
                new SubCategory() { SubCategoryId = 92, CategoryId = 8, Name = "Тв / видеотехника" },
                new SubCategory() { SubCategoryId = 93, CategoryId = 8, Name = "Аудиотехника" },
                new SubCategory() { SubCategoryId = 94, CategoryId = 8, Name = "Игры и игровые приставки" },
                new SubCategory() { SubCategoryId = 95, CategoryId = 8, Name = "Планшеты / эл. книги и аксессуары" },
                new SubCategory() { SubCategoryId = 96, CategoryId = 8, Name = "Ноутбуки и аксессуары" },
                new SubCategory() { SubCategoryId = 97, CategoryId = 8, Name = "Техника для дома" },
                new SubCategory() { SubCategoryId = 98, CategoryId = 8, Name = "Техника для кухни" },
                new SubCategory() { SubCategoryId = 99, CategoryId = 8, Name = "Климатическое оборудование" },
                new SubCategory() { SubCategoryId = 100, CategoryId = 8, Name = "Индивидуальный уход" },
                new SubCategory() { SubCategoryId = 101, CategoryId = 8, Name = "Аксессуары и комплектующие" },
                new SubCategory() { SubCategoryId = 102, CategoryId = 8, Name = "Прочая электроника" },
                new SubCategory() { SubCategoryId = 103, CategoryId = 8, Name = "Ремонт и обслуживание техники" },

                new SubCategory() { SubCategoryId = 104, CategoryId = 9, Name = "Строительство / ремонт / уборка" },
                new SubCategory() { SubCategoryId = 105, CategoryId = 9, Name = "Финансовые услуги / партнерство" },
                new SubCategory() { SubCategoryId = 106, CategoryId = 9, Name = "Перевозки / аренда транспорта" },
                new SubCategory() { SubCategoryId = 107, CategoryId = 9, Name = "Реклама / полиграфия / маркетинг / интернет" },
                new SubCategory() { SubCategoryId = 108, CategoryId = 9, Name = "Няни / сиделки" },
                new SubCategory() { SubCategoryId = 109, CategoryId = 9, Name = "Сырьё / материалы" },
                new SubCategory() { SubCategoryId = 110, CategoryId = 9, Name = "Красота / здоровье" },
                new SubCategory() { SubCategoryId = 111, CategoryId = 9, Name = "Оборудование" },
                new SubCategory() { SubCategoryId = 112, CategoryId = 9, Name = "Образование / Спорт" },
                new SubCategory() { SubCategoryId = 113, CategoryId = 9, Name = "Услуги для животных" },
                new SubCategory() { SubCategoryId = 114, CategoryId = 9, Name = "Продажа бизнеса" },
                new SubCategory() { SubCategoryId = 115, CategoryId = 9, Name = "Развлечения / Искусство / Фото / Видео" },
                new SubCategory() { SubCategoryId = 116, CategoryId = 9, Name = "Туризм / иммиграция" },
                new SubCategory() { SubCategoryId = 117, CategoryId = 9, Name = "Услуги переводчиков / набор текста" },
                new SubCategory() { SubCategoryId = 118, CategoryId = 9, Name = "Авто / мото услуги" },
                new SubCategory() { SubCategoryId = 119, CategoryId = 9, Name = "Ремонт и обслуживание техники" },
                new SubCategory() { SubCategoryId = 120, CategoryId = 9, Name = "Сетевой маркетинг" },
                new SubCategory() { SubCategoryId = 121, CategoryId = 9, Name = "Юридические услуги" },
                new SubCategory() { SubCategoryId = 122, CategoryId = 9, Name = "Прокат товаров" },
                new SubCategory() { SubCategoryId = 123, CategoryId = 9, Name = "Прочие услуги" },

                new SubCategory() { SubCategoryId = 124, CategoryId = 10, Name = "Одежда/обувь" },
                new SubCategory() { SubCategoryId = 125, CategoryId = 10, Name = "Для свадьбы" },
                new SubCategory() { SubCategoryId = 126, CategoryId = 10, Name = "Наручные часы" },
                new SubCategory() { SubCategoryId = 127, CategoryId = 10, Name = "Аксессуары" },
                new SubCategory() { SubCategoryId = 128, CategoryId = 10, Name = "Подарки" },
                new SubCategory() { SubCategoryId = 129, CategoryId = 10, Name = "Красота / здоровье" },
                new SubCategory() { SubCategoryId = 130, CategoryId = 10, Name = "Мода разное" },

                new SubCategory() { SubCategoryId = 131, CategoryId = 11, Name = "Антиквариат / коллекции" },
                new SubCategory() { SubCategoryId = 132, CategoryId = 11, Name = "Музыкальные инструменты" },
                new SubCategory() { SubCategoryId = 133, CategoryId = 11, Name = "Спорт / отдых" },
                new SubCategory() { SubCategoryId = 134, CategoryId = 11, Name = "Книги / журналы" },
                new SubCategory() { SubCategoryId = 135, CategoryId = 11, Name = "CD / DVD / пластинки / кассеты" },
                new SubCategory() { SubCategoryId = 136, CategoryId = 11, Name = "Билеты" },
                new SubCategory() { SubCategoryId = 137, CategoryId = 11, Name = "Поиск попутчиков" },
                new SubCategory() { SubCategoryId = 138, CategoryId = 11, Name = "Поиск групп / музыкантов" },
                new SubCategory() { SubCategoryId = 139, CategoryId = 11, Name = "Другое" }

            );


            modelBuilder.Entity<Ad>().HasData(GenerateData());
        }

        private Ad[] GenerateData()
        {
            List<Ad> ads = new List<Ad>();

            int cat = 1;
            int subcat = 1;
            int price = 100;
            string city = "";
            string phone = "";
            string email = "";
            string contact = "";

            for (int i = 1; i < 500; i++)
            {

                if (cat == 12) cat = 1;
                if (subcat == 140) subcat = 1;

                if (subcat < 50)  { 
                    city = "Kiev";
                    phone = "096-456-56-58";
                    email = "roberto@gmail.com";
                    contact = "Roberto Mayers";
                }

                if (subcat >= 50 && subcat < 100)
                {
                    city = "Kharkov";
                    phone = "095-622-13-31";
                    email = "mike@gmail.com";
                    contact = "Mike Johns";
                }

                if (subcat >= 100)
                {
                    city = "Lviv";
                    phone = "097-678-58-44";
                    email = "bonJovi@gmail.com";
                    contact = "Bon Jovi";
                }

                ads.Add(new Ad
                {

                    AdId = i, 
                    CategoryId = cat, 
                    SubCategoryId = subcat, 
                    Price = price, 
                    Title = "title for advertasing N " + i,
                    Desc = "description for advertising number " + i,
                    City = city,
                    Phone = phone,
                    Email = email,
                    ContactPerson = contact
                });

                cat++;
                subcat++;
                price += 50;
            }

            return ads.ToArray();
        }
    }

}
