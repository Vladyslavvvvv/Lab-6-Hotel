using Lab_6_Hotel.HotelGuestBook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6_Hotel
{
    public partial class Form1 : Form
    {
        private GuestEntryCollection<GuestEntry> startCollection;
        private GuestEntryCollection<GuestEntry> moreThenHourCollection;
        private GuestEntryCollection<GuestEntry> sortByRoomCollection;
        public Form1()
        {
            InitializeComponent();
            startCollection = new GuestEntryCollection<GuestEntry>();
            moreThenHourCollection = new GuestEntryCollection<GuestEntry>();
            sortByRoomCollection = new GuestEntryCollection<GuestEntry>();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            // Для заповнення з текстового файлу
            //string FilePath = @"C:\Users\acer\OneDrive\Робочий стіл\2 курс\Об'єктно-орієнтоване програмування\2 семестр\Лабораторна робота №6\Source.txt";
            //startCollection.LoadFromFileToFile(FilePath);

            // Повний шлях до файлу збереження даних про відвідувачів
            string filePath = @"C:\Users\acer\OneDrive\Робочий стіл\2 курс\Об'єктно-орієнтоване програмування\2 семестр\Лабораторна робота №6\Source.dat";

            //startCollection.SaveToFile(filePath);

            // Зчитування з файлу інформації про відвідувачів
            startCollection.LoadFromFile(filePath);
            moreThenHourCollection.LoadFromFile(filePath);
            sortByRoomCollection.LoadFromFile(filePath);

            // Очищення listBoxList перед виведенням нових даних
            listBoxList.Items.Clear();

            // Додавання повних імен відвідувачів до listBoxList
            foreach (var entry in startCollection.GetAllEntries())
            {
                listBoxList.Items.Add(entry.FullName);
            }
        }

        private void buttonWriteMoreThenHour_Click(object sender, EventArgs e)
        {
            // Повний шлях до файлу, в який буде записана інформація про відвідувачів, які перебували у готелі більше години
            string filePath = @"C:\Users\acer\OneDrive\Робочий стіл\2 курс\Об'єктно-орієнтоване програмування\2 семестр\Лабораторна робота №6\MoreThenHour.dat";

            // Фільтрація відвідувачів, які перебували у готелі більше години
            var filteredEntries = moreThenHourCollection.GetGuestsStayedMoreThanAnHour();

            // Додавання повних імен відвідувачів до listBoxMoreThenHour
            listBoxMoreThenHour.Items.Clear();
            foreach (var entry in filteredEntries)
            {
                listBoxMoreThenHour.Items.Add(entry.FullName);
            }

            // Запис інформації про відвідувачів, які перебували у готелі більше години, у файл
            moreThenHourCollection.SaveToFile(filePath);
        }

        private void buttonWriteSortByRoom_Click(object sender, EventArgs e)
        {
            // Повний шлях до файлу, в який буде записана інформація про відвідувачів посортованих за номером кімнати
            string filePath = @"C:\Users\acer\OneDrive\Робочий стіл\2 курс\Об'єктно-орієнтоване програмування\2 семестр\Лабораторна робота №6\SortByRoom.dat";

            // Сортування колекції за номером кімнати
            sortByRoomCollection.SortByRoomNumber();

            // Очищення listBoxSortByRoom перед виведенням нових даних
            listBoxSortByRoom.Items.Clear();

            // Додавання повних імен відвідувачів до listBoxSortByRoom
            foreach (var entry in sortByRoomCollection.GetAllEntries())
            {
                listBoxSortByRoom.Items.Add(entry.FullName);
            }

            // Запис інформації про відвідувачів посортованих за номером кімнати у файл
            sortByRoomCollection.SaveToFile(filePath);
        }

        private void listBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Отримання індексу вибраного елемента у listBoxList
            int selectedIndex = listBoxList.SelectedIndex;

            // Перевірка чи індекс є дійсним і не виходить за межі
            if (selectedIndex >= 0 && selectedIndex < startCollection.GetAllEntries().Count)
            {
                // Отримання вибраного запису гостя
                var selectedGuest = startCollection.GetAllEntries()[selectedIndex];

                // Виведення повної інформації про вибраного гостя у labelDetailInfo
                labelDetailInfo.Text = $"Повне ім'я: {selectedGuest.FullName}\n" +
                                       $"Прибуття: {selectedGuest.ArrivalDate}\n" +
                                       $"Відправлення: {selectedGuest.DepartureDate}\n" +
                                       $"Номер кімнати: {selectedGuest.RoomNumber}";
            }
        }

        private void listBoxSortByRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Отримання індексу вибраного елемента у listBoxList
            int selectedIndex = listBoxSortByRoom.SelectedIndex;

            // Перевірка чи індекс є дійсним і не виходить за межі
            if (selectedIndex >= 0 && selectedIndex < sortByRoomCollection.GetAllEntries().Count)
            {
                // Отримання вибраного запису гостя
                var selectedGuest = sortByRoomCollection.GetAllEntries()[selectedIndex];

                // Виведення повної інформації про вибраного гостя у labelDetailInfo
                labelDetailInfo.Text = $"Повне ім'я: {selectedGuest.FullName}\n" +
                                       $"Прибуття: {selectedGuest.ArrivalDate}\n" +
                                       $"Відправлення: {selectedGuest.DepartureDate}\n" +
                                       $"Номер кімнати: {selectedGuest.RoomNumber}";
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            // Отримуємо дані з текстових полів
            string fullName = textBoxAddName.Text.Trim();
            string arrivalDateText = textBoxArriveDate.Text.Trim();
            string departureDateText = textBoxDepartureDate.Text.Trim();
            string roomNumberText = textBoxRoom.Text.Trim();

            // Перевіряємо, чи всі поля заповнені
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(arrivalDateText) ||
                string.IsNullOrWhiteSpace(departureDateText) || string.IsNullOrWhiteSpace(roomNumberText))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!");
                return;
            }

            // Парсимо дати та номер кімнати
            DateTime arrivalDate, departureDate;
            int roomNumber;
            if (!DateTime.TryParse(arrivalDateText, out arrivalDate))
            {
                MessageBox.Show("Некоректний формат дати прибуття!");
                return;
            }
            if (!DateTime.TryParse(departureDateText, out departureDate))
            {
                MessageBox.Show("Некоректний формат дати виїзду!");
                return;
            }
            if (!int.TryParse(roomNumberText, out roomNumber))
            {
                MessageBox.Show("Некоректний формат номера кімнати!");
                return;
            }

            // Створюємо нового відвідувача з введеними даними
            GuestEntry newGuest = new GuestEntry();
            newGuest.FullName = fullName;
            newGuest.ArrivalDate = arrivalDate;
            newGuest.DepartureDate = departureDate;
            newGuest.RoomNumber = roomNumber;

            // Додаємо відвідувача до файлу
            try
            {
                string filePath = @"C:\Users\acer\OneDrive\Робочий стіл\2 курс\Об'єктно-орієнтоване програмування\2 семестр\Лабораторна робота №6\Source.dat";
               
                // Додаємо відвідувача до файлу
                startCollection.AddEntry(newGuest); // Припускаю, що у вас є вже створений об'єкт startCollection типу GuestEntryCollection

                startCollection.SaveToFile(filePath);

                // Виводимо повідомлення про успішне додавання
                MessageBox.Show("Нового відвідувача додано успішно!");

                // Очищуємо текстові поля
                textBoxAddName.Text = "";
                textBoxArriveDate.Text = "";
                textBoxDepartureDate.Text = "";
                textBoxRoom.Text = "";
            }
            catch (Exception ex)
            {
                // Якщо сталася помилка під час додавання, виводимо повідомлення про помилку
                MessageBox.Show($"Сталася помилка при додаванні відвідувача: {ex.Message}");
            }
        }
    }

    namespace HotelGuestBook
    {
        [Serializable] // Додаємо атрибут для серіалізації
        public class GuestEntry
        {
            // Поля
            public string FullName;
            public DateTime ArrivalDate;
            public DateTime DepartureDate;
            public int RoomNumber;

            public string fullName
            {
                get { return FullName; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        string[] parts = value.Split(' ');
                        if (parts.Length == 3)
                        {
                            FullName = value;
                        }
                        else
                        {
                            MessageBox.Show("Некоректний формат імені! Введіть у форматі 'Прізвище Ім'я По-батькові'");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Поле 'ПІБ' не може бути порожнім!");
                    }
                }
            }

            public DateTime arrivalDate
            {
                get { return ArrivalDate; }
                set
                {
                    if (value > DateTime.Now)
                    {
                        ArrivalDate = value;
                    }
                    else
                    {
                        MessageBox.Show("Дата прибуття не може бути раніше поточної дати!");
                    }
                }
            }

            public DateTime departureDate
            {
                get { return DepartureDate; }
                set
                {
                    if (value > ArrivalDate)
                    {
                        DepartureDate = value;
                    }
                    else
                    {
                        MessageBox.Show("Дата виїзду повинна бути пізніше дати прибуття!");
                    }
                }
            }

            public int roomNumber
            {
                get { return RoomNumber; }
                set
                {
                    if (value > 0)
                    {
                        RoomNumber = value;
                    }
                    else
                    {
                        MessageBox.Show("Номер кімнати повинен бути додатнім числом!");
                    }
                }
            }

            // Конструктор за замовчуванням
            public GuestEntry()
            {
                FullName = "Ім'я"; // Значення за замовчуванням для ПІБ
                ArrivalDate = DateTime.Now; // Поточна дата і час за замовчуванням для дати прибуття
                DepartureDate = DateTime.Now.AddDays(1); // Дата виїзду через один день за замовчуванням
                RoomNumber = 0; // Значення за замовчуванням для номера кімнати
            }

            // Перевизначення методу ToString() для зручного виведення
            public override string ToString()
            {
                return $"{FullName} - Номер кімнати: {RoomNumber}";
            }
        }

        public class GuestEntryCollection<T> where T : GuestEntry
        {
            private List<T> entries = new List<T>();

            // Функція додавання запису
            public void AddEntry(T entry)
            {
                entries.Add(entry);
            }

            // Отримати всі записи
            public List<T> GetAllEntries()
            {
                return entries;
            }

            // Сортування колекції за номером кімнати
            public void SortByRoomNumber()
            {
                entries.Sort((x, y) => x.RoomNumber.CompareTo(y.RoomNumber));
            }

            // Отримати список гостей, які перебували у готелі більше години
            public List<T> GetGuestsStayedMoreThanAnHour()
            {
                List<T> filteredEntries = new List<T>();
                foreach (var entry in entries)
                {
                    TimeSpan stayDuration = entry.DepartureDate - entry.ArrivalDate;
                    if (stayDuration.TotalHours > 1)
                    {
                        filteredEntries.Add(entry);
                    }
                }
                return filteredEntries;
            }

            // Запис колекції у файл
            public void SaveToFile(string filePath)
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, entries);
                }
            }

            // Зчитування колекції з файлу
            public void LoadFromFile(string filePath)
            {
                // Очищення поточної колекції перед завантаженням нових даних
                entries.Clear();

                // Зчитування даних з файлу
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    entries = (List<T>)formatter.Deserialize(fs);
                }
            }

            public void LoadFromFileToFile(string filePath)
            {
                // Очищення поточної колекції перед завантаженням нових даних
                entries.Clear();

                // Зчитування рядків з файлу
                string[] lines = File.ReadAllLines(filePath);

                // Читання кожного рядка та створення об'єктів GuestEntry
                foreach (string line in lines)
                {
                    // Розділення рядка на окремі частини
                    string[] parts = line.Split(',');

                    // Перевірка на правильність кількості частин
                    if (parts.Length == 4)
                    {
                        // Отримання даних з кожної частини рядка
                        string fullName = parts[0].Trim();
                        DateTime arrivalDate = DateTime.Parse(parts[1].Trim().TrimStart('(').TrimEnd(')'));
                        DateTime departureDate = DateTime.Parse(parts[2].Trim().TrimStart('(').TrimEnd(')'));
                        int roomNumber = int.Parse(parts[3].Trim());

                        // Створення нового об'єкта GuestEntry та додавання його до колекції
                        GuestEntry entry = new GuestEntry()
                        {
                            FullName = fullName,
                            ArrivalDate = arrivalDate,
                            DepartureDate = departureDate,
                            RoomNumber = roomNumber
                        };
                        entries.Add((T)entry);
                    }
                }
            }
        }
    }
}