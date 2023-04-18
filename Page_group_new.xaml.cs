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
	/// Логика взаимодействия для Page_group_new.xaml
	/// </summary>
	public partial class Page_group_new : Page
	{
		public Page_group_new()
		{
			InitializeComponent();
			listGroup.ItemsSource = ClassBase.BD.Group.ToList();
		}

		private void save_group_Click(object sender, RoutedEventArgs e)
		{
			if (name_group.Text != "")
			{

				Group UsersObject = ClassBase.BD.Group.FirstOrDefault(z => z.Name_group == name_group.Text);
				if (UsersObject == null)
				{
                    Group GroupObject = new Group()
					{
						Name_group = name_group.Text,
					};

					ClassBase.BD.Group.Add(GroupObject);
					ClassBase.BD.SaveChanges();
					MessageBox.Show("Группа добавлена");
					ClassFrame.frm_2.Navigate(new Page_group_new());
				}
				else
				{
					MessageBox.Show("Такая группа уже существует!");
				}
			}
			else
			{
				MessageBox.Show("Не заполнено поле 'Наименование группы'!");
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Button btn = (Button)sender;  // получаем доступ к Button из шаблона
			int index = Convert.ToInt32(btn.Uid);

			Group group = ClassBase.BD.Group.FirstOrDefault(x => x.ID_group == index);

			ClassBase.BD.Group.Remove(group); // удаление кота из базы            
			ClassBase.BD.SaveChanges();  // сохранение изменений в базе данных

			ClassFrame.frm_2.Navigate(new Page_group_new());
		}
	}
}
