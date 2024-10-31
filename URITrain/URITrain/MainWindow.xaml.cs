using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace URITrain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ImageURL _imageUrl = new ImageURL();

            DataContext = _imageUrl;
            /*            ce qui remplace le web client
            HttpClient _client = new HttpClient();
            TaskAwaiter<string> _awaiter = _client.GetStringAsync(URL).GetAwaiter();
            _awaiter.OnCompleted(() => _callback?.Invoke(_awaiter.GetResult()));*/
        }
    }
}