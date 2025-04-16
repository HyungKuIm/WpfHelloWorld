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
using HelloWorld.ViewModel;

namespace HelloWorld.Controls
{
    /// <summary>
    /// PlayerControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PlayerControl : UserControl
    {
        public PlayerControl()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("Player Clicked");
            if (sender is Border border && border.DataContext is PlayerViewModel player)
            {
                //MessageBox.Show(player.Name + " Clicked");
                //foreach (var item in ((KBOViewModel)DataContext).Players)
                //{
                //    item.IsSelected = false; // 모든 선수의 IsSelected를 false로 설정
                //}
                player.IsSelected = true; // 클릭한 선수의 IsSelected를 true로 설정

            }
        }
    }
}
