using System.Diagnostics;
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
using HelloWorld.Pages;
using HelloWorld.ViewModel;

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //FontList();
            this.DataContext = new WindowViewModel();
            //this.MainFrame.Content = new ParisPage();
        }

        //private void FontList()
        //{
        //    List<string> fontList = new List<string>();
        //    foreach (FontFamily font in Fonts.SystemFontFamilies)
        //    {
        //        fontList.Add(string.Join(",", font.FamilyNames.Values));
        //        Debug.WriteLine(string.Join(",", font.FamilyNames.Values));
        //    }
        //}
    }
}