using Microsoft.EntityFrameworkCore.Migrations;

namespace shop.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "SubCategoryId", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Детская одежда" },
                    { 102, 8, "Прочая электроника" },
                    { 101, 8, "Аксессуары и комплектующие" },
                    { 100, 8, "Индивидуальный уход" },
                    { 99, 8, "Климатическое оборудование" },
                    { 98, 8, "Техника для кухни" },
                    { 97, 8, "Техника для дома" },
                    { 96, 8, "Ноутбуки и аксессуары" },
                    { 95, 8, "Планшеты / эл. книги и аксессуары" },
                    { 94, 8, "Игры и игровые приставки" },
                    { 93, 8, "Аудиотехника" },
                    { 92, 8, "Тв / видеотехника" },
                    { 91, 8, "Фото / видео" },
                    { 90, 8, "Компьютеры и комплектующие" },
                    { 89, 8, "Телефоны и аксессуары" },
                    { 88, 7, "Прочие товары для дома" },
                    { 87, 7, "Хозяйственный инвентарь / бытовая химия" },
                    { 86, 7, "Садовый инвентарь" },
                    { 72, 6, "Сельхоз животные" },
                    { 73, 6, "Другие  животные" },
                    { 74, 6, "Зоотовары" },
                    { 75, 6, "Вязка" },
                    { 76, 6, "Бюро находок" },
                    { 77, 7, "Канцтовары / расходные материалы" },
                    { 103, 8, "Ремонт и обслуживание техники" },
                    { 78, 7, "Мебель" },
                    { 80, 7, "Сад / огород" },
                    { 81, 7, "Предметы интерьера" },
                    { 82, 7, "Строительство / ремонт" },
                    { 83, 7, "Инструменты" },
                    { 84, 7, "Комнатные растения" },
                    { 85, 7, "Посуда / кухонная утварь" },
                    { 79, 7, "Продукты питания / напитки" },
                    { 71, 6, "Рептилии" },
                    { 104, 9, "Строительство / ремонт / уборка" },
                    { 106, 9, "Перевозки / аренда транспорта" },
                    { 137, 11, "Поиск попутчиков" },
                    { 136, 11, "Билеты" },
                    { 135, 11, "CD / DVD / пластинки / кассеты" },
                    { 134, 11, "Книги / журналы" },
                    { 133, 11, "Спорт / отдых" },
                    { 132, 11, "Музыкальные инструменты" },
                    { 131, 11, "Антиквариат / коллекции" },
                    { 130, 10, "Мода разное" },
                    { 129, 10, "Красота / здоровье" },
                    { 128, 10, "Подарки" },
                    { 127, 10, "Аксессуары" },
                    { 126, 10, "Наручные часы" },
                    { 125, 10, "Для свадьбы" },
                    { 124, 10, "Одежда/обувь" },
                    { 123, 9, "Прочие услуги" },
                    { 122, 9, "Прокат товаров" },
                    { 121, 9, "Юридические услуги" },
                    { 107, 9, "Реклама / полиграфия / маркетинг / интернет" },
                    { 108, 9, "Няни / сиделки" },
                    { 109, 9, "Сырьё / материалы" },
                    { 110, 9, "Красота / здоровье" },
                    { 111, 9, "Оборудование" },
                    { 112, 9, "Образование / Спорт" },
                    { 105, 9, "Финансовые услуги / партнерство" },
                    { 113, 9, "Услуги для животных" },
                    { 115, 9, "Развлечения / Искусство / Фото / Видео" },
                    { 116, 9, "Туризм / иммиграция" },
                    { 117, 9, "Услуги переводчиков / набор текста" },
                    { 118, 9, "Авто / мото услуги" },
                    { 119, 9, "Ремонт и обслуживание техники" },
                    { 120, 9, "Сетевой маркетинг" },
                    { 114, 9, "Продажа бизнеса" },
                    { 138, 11, "Поиск групп / музыкантов" },
                    { 70, 6, "Грызуны" },
                    { 68, 6, "Аквариумистика" },
                    { 32, 3, "Электромобили" },
                    { 31, 3, "Нерастаможенные автомобили" },
                    { 30, 3, "Запчасти для транспорта" },
                    { 29, 3, "Другой транспорт" },
                    { 28, 3, "Прицепы / дома на колесах" },
                    { 27, 3, "Воздушный транспорт" },
                    { 26, 3, "Водный транспорт " },
                    { 25, 3, "Сельхозтехника" },
                    { 24, 3, "Спецтехника" },
                    { 23, 3, "Мото" },
                    { 22, 3, "Автобусы " },
                    { 21, 3, "Грузовые автомобили" },
                    { 20, 3, "Автомобили из Польши" },
                    { 19, 3, "Легковые автомобили" },
                    { 18, 2, "Недвижимость за рубежом" },
                    { 17, 2, "Предложения от застройщиков" },
                    { 16, 2, "Посуточная аренда жилья" },
                    { 2, 1, "Детская обувь" },
                    { 3, 1, "Детские коляски" },
                    { 4, 1, "Детские автокресла" },
                    { 5, 1, "Детская мебель" },
                    { 6, 1, "Игрушки" },
                    { 7, 1, "Детский транспорт" },
                    { 33, 4, "Автозапчасти и аксессуары" },
                    { 8, 1, "Товары для кормления" },
                    { 10, 1, "Прочие детские товары" },
                    { 11, 2, "Квартиры, комнаты" },
                    { 12, 2, "Дома" },
                    { 13, 2, "Земля" },
                    { 14, 2, "Коммерческая недвижимость" },
                    { 15, 2, "Гаражи, парковки" },
                    { 9, 1, "Товары для школьников" },
                    { 69, 6, "Птицы" },
                    { 34, 4, "Шины, диски и колёса" },
                    { 36, 4, "Мотозапчасти и аксессуары" },
                    { 67, 6, "Кошки" },
                    { 66, 6, "Собаки" },
                    { 65, 6, "Бесплатно (животные и вязка)" },
                    { 64, 5, "Работа за рубежом" },
                    { 63, 5, "Другие сферы занятий" },
                    { 62, 5, "Сервис и быт" },
                    { 61, 5, "Начало карьеры / Студенты" },
                    { 60, 5, "Частичная занятость" },
                    { 59, 5, "Cекретариат / АХО" },
                    { 58, 5, "Сельское хозяйство / агробизнес / лесное хозяйство" },
                    { 57, 5, "Производство / энергетика" },
                    { 56, 5, "Маркетинг / реклама / дизайн" },
                    { 55, 5, "Недвижимость" },
                    { 54, 5, "Банки / финансы / страхование" },
                    { 53, 5, "ИТ / телеком / компьютеры" },
                    { 52, 5, "Медицина / фармация" },
                    { 51, 5, "Культура / искусство" },
                    { 37, 4, "Прочие запчасти" },
                    { 38, 4, "Транспорт" },
                    { 39, 5, "Розничная торговля / продажи / закупки" },
                    { 40, 5, "Транспорт / логистика" },
                    { 41, 5, "Строительство" },
                    { 42, 5, "Телекоммуникации / связь" },
                    { 35, 4, "Запчасти для спец / с.х. техники" },
                    { 43, 5, "Бары / рестораны" },
                    { 45, 5, "Управление персоналом / HR" },
                    { 46, 5, "Охрана / безопасность" },
                    { 47, 5, "Домашний персонал" },
                    { 48, 5, "Красота / фитнес / спорт" },
                    { 49, 5, "Туризм / отдых / развлечения" },
                    { 50, 5, "Образование" },
                    { 44, 5, "Юриспруденция и бухгалтерия" },
                    { 139, 11, "Другое" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 139);
        }
    }
}
