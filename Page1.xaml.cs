using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
	/// Логика взаимодействия для Page1.xaml
	/// </summary>
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
			listProduct.ItemsSource = ClassBase.BD.Children.ToList();

			List<Group> TT = ClassBase.BD.Group.ToList();

			// программное заполнение выпадающего списка
			cmbType.Items.Add("Все группы");
			for (int i = 0; i < TT.Count; i++)
			{
				cmbType.Items.Add(TT[i].Name_group);
			}

			cmbType.SelectedIndex = 0;  // выбранное по умолчанию значение в списке с типами товаров ("Все группы")
			cmbSort.SelectedIndex = 0;  // выбранное по умолчанию значение в списке с видами сортировки ("Без сортировки")

			tbCount.Text = "Количество детей: " + ClassBase.BD.Children.ToList().Count;
			
		}


		void Filter()  // метод для одновременной фильтрации, поиска и сортировки
		{
			List<Children> productList = ClassBase.BD.Children.ToList();

			string type = cmbType.SelectedValue.ToString();  // выбранное пользователем название типа
			int index = cmbType.SelectedIndex;

			// поиск значений, удовлетворяющих условия фильтра
			if (index != 0)
			{
				productList = ClassBase.BD.Children.Where(x => x.Group.Name_group == type).ToList();
			}
			else  // если выбран пункт "Все группы", то сбрасываем фильтрацию:
			{
				productList = ClassBase.BD.Children.ToList();
			}


			// сортировка
			switch (cmbSort.SelectedIndex)
			{
				case 1:
					{
						productList.Sort((x, y) => x.Surname.CompareTo(y.Surname));
					}
					break;
				case 2:
					{
						productList.Sort((x, y) => x.Surname.CompareTo(y.Surname));
						productList.Reverse();
					}
					break;
			}

			listProduct.ItemsSource = productList;
			if (productList.Count == 0)
			{
				MessageBox.Show("нет записей");
			}
			tbCount.Text = "Количество детей: " + productList.Count;

			// Высокий 

			List<Children> productList_1 = productList;
			listProduct.ItemsSource = productList_1;

			if (!string.IsNullOrWhiteSpace("В"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_1 = productList_1.Where(x => x.social_1.ToLower().Contains("В".ToLower())).ToList();
			}

			double social_1 = (100 / (double)productList.Count) * (double)productList_1.Count;

			soc_11.Text = "" + social_1.ToString("F0") + "%" + " (" + productList_1.Count + ")";

			List<Children> productList_2 = productList;
			listProduct.ItemsSource = productList_2;

			if (!string.IsNullOrWhiteSpace("В"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_2 = productList_2.Where(x => x.social_2.ToLower().Contains("В".ToLower())).ToList();
			}

			double social_12 = (100 / (double)productList.Count) * (double)productList_2.Count;

			soc_12.Text = "" + social_12.ToString("F0") + "%" + " (" + productList_2.Count + ")";

			List<Children> productList_3 = productList;
			listProduct.ItemsSource = productList_3;

			if (!string.IsNullOrWhiteSpace("В"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_3 = productList_3.Where(x => x.social_3.ToLower().Contains("В".ToLower())).ToList();
			}

			double social_13 = (100 / (double)productList.Count) * (double)productList_3.Count;

			soc_13.Text = "" + social_13.ToString("F0") + "%" + " (" + productList_3.Count + ")";

			List<Children> productList_4 = productList;
			listProduct.ItemsSource = productList_4;

			if (!string.IsNullOrWhiteSpace("В"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_4 = productList_4.Where(x => x.social_4.ToLower().Contains("В".ToLower())).ToList();
			}

			double social_14 = (100 / (double)productList.Count) * (double)productList_4.Count;

			soc_14.Text = "" + social_14.ToString("F0") + "%" + " (" + productList_4.Count + ")";

			List<Children> productList_5 = productList;
			listProduct.ItemsSource = productList_5;

			if (!string.IsNullOrWhiteSpace("В"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_5 = productList_5.Where(x => x.social_5.ToLower().Contains("В".ToLower())).ToList();
			}

			double social_15 = (100 / (double)productList.Count) * (double)productList_5.Count;

			soc_15.Text = "" + social_15.ToString("F0") + "%" + " (" + productList_5.Count + ")";
			
			List<Children> productList_6 = productList;
			listProduct.ItemsSource = productList_6;

			if (!string.IsNullOrWhiteSpace("В"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_6 = productList_6.Where(x => x.social_6.ToLower().Contains("В".ToLower())).ToList();
			}

			double social_16 = (100 / (double)productList.Count) * (double)productList_6.Count;

			soc_16.Text = "" + social_16.ToString("F0") + "%" + " (" + productList_6.Count + ")";
			
			List<Children> productList_7 = productList;
			listProduct.ItemsSource = productList_7;

			if (!string.IsNullOrWhiteSpace("В"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_7 = productList_7.Where(x => x.social_7.ToLower().Contains("В".ToLower())).ToList();
			}

			double social_17 = (100 / (double)productList.Count) * (double)productList_7.Count;

			soc_17.Text = "" + social_17.ToString("F0") + "%" + " (" + productList_7.Count + ")";


			/////////////////////////////////////////////////////////////////////////////////////////////////////
			///
			// Средний 

			List<Children> productList_11 = productList;
			listProduct.ItemsSource = productList_11;

			if (!string.IsNullOrWhiteSpace("С"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_11 = productList_11.Where(x => x.social_1.ToLower().Contains("С".ToLower())).ToList();
			}

			double social_11 = (100 / (double)productList.Count) * (double)productList_11.Count;

			soc_111.Text = "" + social_11.ToString("F0") + "%" + " (" + productList_11.Count + ")";

			List<Children> productList_21 = productList;
			listProduct.ItemsSource = productList_21;

			if (!string.IsNullOrWhiteSpace("С"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_21 = productList_21.Where(x => x.social_2.ToLower().Contains("С".ToLower())).ToList();
			}

			double social_21 = (100 / (double)productList.Count) * (double)productList_21.Count;

			soc_122.Text = "" + social_21.ToString("F0") + "%" + " (" + productList_21.Count + ")";

			List<Children> productList_31 = productList;
			listProduct.ItemsSource = productList_31;

			if (!string.IsNullOrWhiteSpace("С"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_31 = productList_31.Where(x => x.social_3.ToLower().Contains("С".ToLower())).ToList();
			}

			double social_31 = (100 / (double)productList.Count) * (double)productList_31.Count;

			soc_133.Text = "" + social_31.ToString("F0") + "%" + " (" + productList_31.Count + ")";


			List<Children> productList_41 = productList;
			listProduct.ItemsSource = productList_41;

			if (!string.IsNullOrWhiteSpace("С"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_41 = productList_41.Where(x => x.social_4.ToLower().Contains("С".ToLower())).ToList();
			}

			double social_41 = (100 / (double)productList.Count) * (double)productList_41.Count;

			soc_144.Text = "" + social_41.ToString("F0") + "%" + " (" + productList_41.Count + ")";


			List<Children> productList_51 = productList;
			listProduct.ItemsSource = productList_51;

			if (!string.IsNullOrWhiteSpace("С"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_51 = productList_51.Where(x => x.social_5.ToLower().Contains("С".ToLower())).ToList();
			}

			double social_51 = (100 / (double)productList.Count) * (double)productList_51.Count;

			soc_155.Text = "" + social_51.ToString("F0") + "%" + " (" + productList_51.Count + ")";

			List<Children> productList_61 = productList;
			listProduct.ItemsSource = productList_61;

			if (!string.IsNullOrWhiteSpace("С"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_61 = productList_61.Where(x => x.social_6.ToLower().Contains("С".ToLower())).ToList();
			}

			double social_61 = (100 / (double)productList.Count) * (double)productList_61.Count;

			soc_166.Text = "" + social_61.ToString("F0") + "%" + " (" + productList_61.Count + ")";


			List<Children> productList_71 = productList;
			listProduct.ItemsSource = productList_71;

			if (!string.IsNullOrWhiteSpace("С"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_71 = productList_71.Where(x => x.social_7.ToLower().Contains("С".ToLower())).ToList();
			}

			double social_71 = (100 / (double)productList.Count) * (double)productList_71.Count;

			soc_177.Text = "" + social_71.ToString("F0") + "%" + " (" + productList_71.Count + ")";


			/////////////////////////////////////////////////////////////////////////////////////////////////////

			// Низкий

			List<Children> productList_12 = productList;
			listProduct.ItemsSource = productList_12;

			if (!string.IsNullOrWhiteSpace("Н"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_12 = productList_12.Where(x => x.social_1.ToLower().Contains("Н".ToLower())).ToList();
			}

			double social_1111 = (100 / (double)productList.Count) * (double)productList_12.Count;

			soc_1111.Text = "" + social_1111.ToString("F0") + "%" + " (" + productList_12.Count + ")";


			List<Children> productList_22 = productList;
			listProduct.ItemsSource = productList_22;

			if (!string.IsNullOrWhiteSpace("Н"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_22 = productList_22.Where(x => x.social_2.ToLower().Contains("Н".ToLower())).ToList();
			}

			double social_2111 = (100 / (double)productList.Count) * (double)productList_22.Count;

			soc_1222.Text = "" + social_2111.ToString("F0") + "%" + " (" + productList_22.Count + ")";

			List<Children> productList_32 = productList;
			listProduct.ItemsSource = productList_32;

			if (!string.IsNullOrWhiteSpace("Н"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_32 = productList_32.Where(x => x.social_3.ToLower().Contains("Н".ToLower())).ToList();
			}

			double social_3111 = (100 / (double)productList.Count) * (double)productList_32.Count;

			soc_1333.Text = "" + social_3111.ToString("F0") + "%" + " (" + productList_32.Count + ")";

			List<Children> productList_42 = productList;
			listProduct.ItemsSource = productList_42;

			if (!string.IsNullOrWhiteSpace("Н"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_42 = productList_42.Where(x => x.social_4.ToLower().Contains("Н".ToLower())).ToList();
			}

			double social_4111 = (100 / (double)productList.Count) * (double)productList_42.Count;

			soc_1444.Text = "" + social_4111.ToString("F0") + "%" + " (" + productList_42.Count + ")";

			List<Children> productList_52 = productList;
			listProduct.ItemsSource = productList_52;

			if (!string.IsNullOrWhiteSpace("Н"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_52 = productList_52.Where(x => x.social_5.ToLower().Contains("Н".ToLower())).ToList();
			}

			double social_5111 = (100 / (double)productList.Count) * (double)productList_52.Count;

			soc_1555.Text = "" + social_5111.ToString("F0") + "%" + " (" + productList_52.Count + ")";

			List<Children> productList_62 = productList;
			listProduct.ItemsSource = productList_62;

			if (!string.IsNullOrWhiteSpace("Н"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_62 = productList_62.Where(x => x.social_6.ToLower().Contains("Н".ToLower())).ToList();
			}

			double social_6111 = (100 / (double)productList.Count) * (double)productList_62.Count;

			soc_1666.Text = "" + social_6111.ToString("F0") + "%" + " (" + productList_62.Count + ")";

			List<Children> productList_72 = productList;
			listProduct.ItemsSource = productList_72;

			if (!string.IsNullOrWhiteSpace("Н"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_72 = productList_72.Where(x => x.social_7.ToLower().Contains("Н".ToLower())).ToList();
			}

			double social_7111 = (100 / (double)productList.Count) * (double)productList_72.Count;

			soc_1777.Text = "" + social_7111.ToString("F0") + "%" + " (" + productList_72.Count + ")";

			/////////////////////////////////////////////////////////////////////////////////////////////////////

			// Низший

			List<Children> productList_13 = productList;
			listProduct.ItemsSource = productList_13;

			if (!string.IsNullOrWhiteSpace("Низ"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_13 = productList_13.Where(x => x.social_1.ToLower().Contains("Низ".ToLower())).ToList();
			}

			double social_11111 = (100 / (double)productList.Count) * (double)productList_13.Count;

			soc_11111.Text = "" + social_11111.ToString("F0") + "%" + " (" + productList_13.Count + ")";

			List<Children> productList_23 = productList;
			listProduct.ItemsSource = productList_23;

			if (!string.IsNullOrWhiteSpace("Низ"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_23 = productList_23.Where(x => x.social_2.ToLower().Contains("Низ".ToLower())).ToList();
			}

			double social_21111 = (100 / (double)productList.Count) * (double)productList_23.Count;

			soc_12222.Text = "" + social_21111.ToString("F0") + "%" + " (" + productList_23.Count + ")";

			List<Children> productList_33 = productList;
			listProduct.ItemsSource = productList_33;

			if (!string.IsNullOrWhiteSpace("Низ"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_33 = productList_33.Where(x => x.social_3.ToLower().Contains("Низ".ToLower())).ToList();
			}

			double social_31111 = (100 / (double)productList.Count) * (double)productList_33.Count;

			soc_13333.Text = "" + social_31111.ToString("F0") + "%" + " (" + productList_33.Count + ")";


			List<Children> productList_43 = productList;
			listProduct.ItemsSource = productList_43;

			if (!string.IsNullOrWhiteSpace("Низ"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_43 = productList_43.Where(x => x.social_4.ToLower().Contains("Низ".ToLower())).ToList();
			}

			double social_41111 = (100 / (double)productList.Count) * (double)productList_43.Count;

			soc_14444.Text = "" + social_41111.ToString("F0") + "%" + " (" + productList_43.Count + ")";


			List<Children> productList_53 = productList;
			listProduct.ItemsSource = productList_53;

			if (!string.IsNullOrWhiteSpace("Низ"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_53 = productList_53.Where(x => x.social_5.ToLower().Contains("Низ".ToLower())).ToList();
			}

			double social_51111 = (100 / (double)productList.Count) * (double)productList_53.Count;

			soc_15555.Text = "" + social_51111.ToString("F0") + "%" + " (" + productList_53.Count + ")";


			List<Children> productList_63 = productList;
			listProduct.ItemsSource = productList_63;

			if (!string.IsNullOrWhiteSpace("Низ"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_63 = productList_63.Where(x => x.social_6.ToLower().Contains("Низ".ToLower())).ToList();
			}

			double social_61111 = (100 / (double)productList.Count) * (double)productList_63.Count;

			soc_16666.Text = "" + social_61111.ToString("F0") + "%" + " (" + productList_63.Count + ")";


			List<Children> productList_73 = productList;
			listProduct.ItemsSource = productList_73;

			if (!string.IsNullOrWhiteSpace("Низ"))  // если строка не пустая и если она не состоит из пробелов
			{
				productList_73 = productList_73.Where(x => x.social_7.ToLower().Contains("Низ".ToLower())).ToList();
			}

			double social_71111 = (100 / (double)productList.Count) * (double)productList_73.Count;

			soc_17777.Text = "" + social_71111.ToString("F0") + "%" + " (" + productList_73.Count + ")";


			/////////////////////////////////////////////////////////////////////////////////////////////////////
		}

		private void cmbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Filter();
		}

		private void cmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Filter();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Button btn = (Button)sender;  // получаем доступ к Button из шаблона
			int index = Convert.ToInt32(btn.Uid);

			Children children = ClassBase.BD.Children.FirstOrDefault(x => x.ID_children == index);

			ClassBase.BD.Children.Remove(children); // удаление кота из базы            
			ClassBase.BD.SaveChanges();  // сохранение изменений в базе данных

			ClassFrame.frm_2.Navigate(new Page1());
		}
    }
}
