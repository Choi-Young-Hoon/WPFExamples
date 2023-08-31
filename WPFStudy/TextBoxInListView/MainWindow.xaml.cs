using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextBoxInListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            personListView.Items.Add(new Person() { Name = "CHOI1", Age = 100 });
            personListView.Items.Add(new Person() { Name = "CHOI2", Age = 200 });
            personListView.Items.Add(new Person() { Name = "CHOI3", Age = 300 });
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person person = (Person)((Button)sender).DataContext;
            MessageBox.Show($"{person.Name}, {person.Age}");
        }
    }
}
