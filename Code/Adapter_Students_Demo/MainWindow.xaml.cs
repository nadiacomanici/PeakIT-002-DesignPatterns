using System.Windows;
using Adapter_Students_Begin.Adapters;
using Structural_BLL;

namespace Adapter_Students_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StudentsReadService _studentsReadService;

        public MainWindow()
        {
            InitializeComponent();

            _studentsReadService = new StudentsReadService();

            // It will display only the Id, because the UI expects each student to have "FirstName" and "LastName" properties
            // but in reality, the models returned by the BLL have "Name" and "Surname"
            var adapter = new StudentAdapter();
            listViewStudents.ItemsSource = adapter.ConvertToViewModelList(_studentsReadService.GetAllStudents());
        }
    }
}
