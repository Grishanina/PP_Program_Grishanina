using Microsoft.Win32;
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
	/// Логика взаимодействия для Autorisasia.xaml
	/// </summary>
	public partial class Autorisasia : Page
	{
		public Autorisasia()
		{
			InitializeComponent();
		}

		private void Go_Click(object sender, RoutedEventArgs e)
		{

			Users UsersObject = ClassBase.BD.Users.FirstOrDefault(z => z.Login == login.Text && z.Password == pass.Text);
			if (UsersObject == null)
			{
				MessageBox.Show("Не верно введены логин или пароль!");
			}
			else
			{
				// Данные для входа      Логин: mironova225      Пароль: 14789
				ClassFrame.frm.Navigate(new Home());
				MessageBox.Show("Привет!");
			}
		}

		private void Register_Click(object sender, RoutedEventArgs e)
		{
			ClassFrame.frm.Navigate(new Register());
		}
	}
}
