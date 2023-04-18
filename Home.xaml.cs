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

namespace WPF_WPF
{
	/// <summary>
	/// Логика взаимодействия для Home.xaml
	/// </summary>
	public partial class Home : Page
	{
		public Home()
		{
			InitializeComponent();
			ClassFrame.frm_2 = Fram_2;
			//ClassFrame.frm_2.Navigate(new Autorisacia());
		}

		private void btn_1_Click(object sender, RoutedEventArgs e)
		{
			ClassFrame.frm_2.Navigate(new Page1());
		}

		private void btn_2_Click(object sender, RoutedEventArgs e)
		{
			ClassFrame.frm_2.Navigate(new Page2());
		}

		private void btn_3_Click(object sender, RoutedEventArgs e)
		{
			ClassFrame.frm_2.Navigate(new Page3());
		}

		private void btn_4_Click(object sender, RoutedEventArgs e)
		{
			ClassFrame.frm_2.Navigate(new Page4());
		}

		private void btn_5_Click(object sender, RoutedEventArgs e)
		{
			ClassFrame.frm_2.Navigate(new Page5());
		}

		private void groups_Click(object sender, RoutedEventArgs e)
		{
			ClassFrame.frm_2.Navigate(new Page_group_new());

		}

		private void new_children_Click(object sender, RoutedEventArgs e)
		{
			ClassFrame.frm_2.Navigate(new Create());
		}
    }
}
