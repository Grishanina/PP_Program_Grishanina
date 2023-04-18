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
	/// Логика взаимодействия для Register.xaml
	/// </summary>
	public partial class Register : Page
	{
		public Register()
		{
			InitializeComponent();
		}

		private void Btn4_Click(object sender, RoutedEventArgs e)
		{
			if (tbsurname.Text != "")
			{
				if (tbname.Text != "")
				{
					if (tbpatronymic.Text != "")
					{
						if (tblogin.Text != "")
						{
							if (pbpas.Text != "")
							{
								Users UsersObject = new Users()
								{
									UserSurname = tbsurname.Text,
									UserName = tbname.Text,
									UserPatronymic = tbpatronymic.Text,
									Login = tblogin.Text,
									Password = pbpas.Text
								};

								ClassBase.BD.Users.Add(UsersObject);
								ClassBase.BD.SaveChanges();
								MessageBox.Show("Пользователь добавлен");
								ClassFrame.frm.Navigate(new Autorisasia());
							}
							else
							{
								MessageBox.Show("Не заполнено поле 'Пароль'!");
							}
						}
						else
						{
							MessageBox.Show("Не заполнено поле 'Логин'!");
						}
					}
					else
					{
						MessageBox.Show("Не заполнено поле 'Отчество'!");
					}
				}
				else
				{
					MessageBox.Show("Не заполнено поле 'Имя'!");
				}
			}
			else
			{
				MessageBox.Show("Не заполнено поле 'Фамилия'!");
			}

		}

		private void Btn5_Click(object sender, RoutedEventArgs e)
		{
			ClassFrame.frm.Navigate(new Autorisasia());
		}
	}
}
