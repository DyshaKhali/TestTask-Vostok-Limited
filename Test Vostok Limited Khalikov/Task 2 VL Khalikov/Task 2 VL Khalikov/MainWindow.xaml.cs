using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Task_2_VL_Khalikov
{
    public partial class MainWindow : Window
    {
        private List<string> AllCities = new List<string> { "Выберите город", "Москва", "Санкт-Петербург", "Тюмень" };

        public MainWindow()
        {
            InitializeComponent();
            LoadCities();
            cbCity.SelectionChanged += CbCity_SelectionChanged;
            cbPlant.SelectionChanged += CbPlant_SelectionChanged;
            cbEmployee.SelectionChanged += CbEmployee_SelectionChanged;
        }

        private void LoadCities()
        {
            cbCity.ItemsSource = AllCities;
            cbCity.SelectedIndex = 0;  
        }

        private void CbCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbCity.SelectedIndex > 0)
            {
                string selectedCity = cbCity.SelectedItem.ToString();
                switch (selectedCity)
                {
                    case "Москва":
                        cbPlant.ItemsSource = new List<string> { "Цех А", "Цех Б" };
                        break;
                    case "Санкт-Петербург":
                        cbPlant.ItemsSource = new List<string> { "Цех В", "Цех Г" };
                        break;
                    case "Тюмень":
                        cbPlant.ItemsSource = new List<string> { "Цех Д"};
                        break;
                    default:
                        cbPlant.ItemsSource = null;
                        break;
                }
                cbEmployee.ItemsSource = null; 
                cbBrigade.ItemsSource = null; 
            }
            else
            {
                cbPlant.ItemsSource = null;
                cbEmployee.ItemsSource = null;
                cbBrigade.ItemsSource = null;
            }
        }

        private void CbPlant_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbPlant.SelectedIndex >= 0)
            {
                string selectedPlant = cbPlant.SelectedItem.ToString();
                switch (selectedPlant)
                {
                    case "Цех А":
                        cbEmployee.ItemsSource = new List<string> { "Иван Иванов", "Петр Петров" };
                        break;
                    case "Цех Б":
                        cbEmployee.ItemsSource = new List<string> { "Сергей Сергеев", "Анна Аннова" };
                        break;
                    case "Цех В":
                        cbEmployee.ItemsSource = new List<string> { "Олег Олегов", "Мария Мариева" };
                        break;
                    case "Цех Г":
                        cbEmployee.ItemsSource = new List<string> { "Дмитрий Дмитриев", "Елена Еленова" };
                        break;
                    case "Цех Д":
                        cbEmployee.ItemsSource = new List<string> { "Николай Николаев", "Татьяна Татьянова" };
                        break;
                    default:
                        cbEmployee.ItemsSource = null;
                        break;
                }
                cbBrigade.ItemsSource = null; 
            }
            else
            {
                cbEmployee.ItemsSource = null;
                cbBrigade.ItemsSource = null;
            }
        }

        private void CbEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbEmployee.SelectedIndex >= 0)
            {
                string selectedEmployee = cbEmployee.SelectedItem.ToString();
                switch (selectedEmployee)
                {
                    case "Иван Иванов":
                        cbBrigade.ItemsSource = new List<string> { "Бригада 1", "Бригада 2" };
                        break;
                    case "Петр Петров":
                        cbBrigade.ItemsSource = new List<string> { "Бригада 3", "Бригада 4" };
                        break;
                    case "Сергей Сергеев":
                        cbBrigade.ItemsSource = new List<string> { "Бригада 5", "Бригада 6" };
                        break;
                    case "Анна Аннова":
                        cbBrigade.ItemsSource = new List<string> { "Бригада 7", "Бригада 8" };
                        break;
                    case "Олег Олегов":
                        cbBrigade.ItemsSource = new List<string> { "Бригада 1" };
                        break;
                    case "Мария Мариева":
                        cbBrigade.ItemsSource = new List<string> { "Бригада 2", "Бригада 9" };
                        break;
                    case "Дмитрий Дмитриев":
                        cbBrigade.ItemsSource = new List<string> { "Бригада 2", "Бригада 9" };
                        break;
                    case "Елена Еленова":
                        cbBrigade.ItemsSource = new List<string> { "Бригада 2" };
                        break;
                    case "Николай Николаев":
                        cbBrigade.ItemsSource = new List<string> { "Бригада 2", "Бригада 9" };
                        break;
                    case "Татьяна Татьянова":
                        cbBrigade.ItemsSource = new List<string> { "Бригада 2", "Бригада 9" };
                        break;
                    default:
                        cbBrigade.ItemsSource = new List<string> { "Общая бригада" };
                        break;
                }
            }
            else
            {
                cbBrigade.ItemsSource = null;
            }
        }
    }
}
