using System;
using System.Collections.Generic;
using System.Data;
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
	/// Логика взаимодействия для Create.xaml
	/// </summary>
	public partial class Create : Page
	{
		Children PRO;

		public void uploadFields()  // метод для заполнения списков
		{
			group.ItemsSource = ClassBase.BD.Group.ToList();
			group.SelectedValuePath = "ID_group";
			group.DisplayMemberPath = "Name_group";
		}

		public Create()
		{
			InitializeComponent();

			uploadFields();

			cog_1.SelectedIndex = 1;
			cog_2.SelectedIndex = 1;
			cog_3.SelectedIndex = 1;
			cog_4.SelectedIndex = 1;
			cog_5.SelectedIndex = 1;
			cog_6.SelectedIndex = 1;
			cog_7.SelectedIndex = 1;

			spe_1.SelectedIndex = 1;
			spe_2.SelectedIndex = 1;
			spe_3.SelectedIndex = 1;
			spe_4.SelectedIndex = 1;
			spe_5.SelectedIndex = 1;
			spe_6.SelectedIndex = 1;
			spe_7.SelectedIndex = 1;

			phy_1.SelectedIndex = 1;
			phy_2.SelectedIndex = 1;
			phy_3.SelectedIndex = 1;
			phy_4.SelectedIndex = 1;
			phy_5.SelectedIndex = 1;
			phy_6.SelectedIndex = 1;
			phy_7.SelectedIndex = 1;

			soc_1.SelectedIndex = 1;
			soc_2.SelectedIndex = 1;
			soc_3.SelectedIndex = 1;
			soc_4.SelectedIndex = 1;
			soc_5.SelectedIndex = 1;
			soc_6.SelectedIndex = 1;
			soc_7.SelectedIndex = 1;

			art_1.SelectedIndex = 1;
			art_2.SelectedIndex = 1;
			art_3.SelectedIndex = 1;
			art_4.SelectedIndex = 1;
			art_5.SelectedIndex = 1;
			art_6.SelectedIndex = 1;
			art_7.SelectedIndex = 1;

			group.SelectedIndex = 0;  // выбранное по умолчанию значение в списке с типами товаров ("1 младшая группа")
		}


		private void save_Click(object sender, RoutedEventArgs e)
		{
			
			if((name.Text != "") && (surname.Text != "") && (patr.Text != ""))
			{

				PRO = new Children();

				// заполняем поля таблицы 
				PRO.Name = name.Text;
				PRO.Surname = surname.Text;
				PRO.Patronymic = patr.Text;
				PRO.ID_group = group.SelectedIndex + 1;

				///////////////////////////////////////////////////////////////////////////////////////////////

				switch (soc_1.SelectedIndex)
				{
					case 0:
						{
							PRO.social_1 = "В";
						}
						break;
					case 1:
						{
							PRO.social_1 = "С";
						}
						break;
					case 2:
						{
							PRO.social_1 = "Н";
						}
						break;
					case 3:
						{
							PRO.social_1 = "Низ";
						}
						break;
				}

				switch (soc_2.SelectedIndex)
				{
					case 0:
						{
							PRO.social_2 = "В";
						}
						break;
					case 1:
						{
							PRO.social_2 = "С";
						}
						break;
					case 2:
						{
							PRO.social_2 = "Н";
						}
						break;
					case 3:
						{
							PRO.social_2 = "Низ";
						}
						break;
				}

				switch (soc_3.SelectedIndex)
				{
					case 0:
						{
							PRO.social_3 = "В";
						}
						break;
					case 1:
						{
							PRO.social_3 = "С";
						}
						break;
					case 2:
						{
							PRO.social_3 = "Н";
						}
						break;
					case 3:
						{
							PRO.social_3 = "Низ";
						}
						break;
				}

				switch (soc_4.SelectedIndex)
				{
					case 0:
						{
							PRO.social_4 = "В";
						}
						break;
					case 1:
						{
							PRO.social_4 = "С";
						}
						break;
					case 2:
						{
							PRO.social_4 = "Н";
						}
						break;
					case 3:
						{
							PRO.social_4 = "Низ";
						}
						break;

				}

				switch (soc_5.SelectedIndex)
				{
					case 0:
						{
							PRO.social_5 = "В";
						}
						break;
					case 1:
						{
							PRO.social_5 = "С";
						}
						break;
					case 2:
						{
							PRO.social_5 = "Н";
						}
						break;
					case 3:
						{
							PRO.social_5 = "Низ";
						}
						break;
				}

				switch (soc_6.SelectedIndex)
				{
					case 0:
						{
							PRO.social_6 = "В";
						}
						break;
					case 1:
						{
							PRO.social_6 = "С";
						}
						break;
					case 2:
						{
							PRO.social_6 = "Н";
						}
						break;
					case 3:
						{
							PRO.social_6 = "Низ";
						}
						break;
				}

				switch (soc_7.SelectedIndex)
				{
					case 0:
						{
							PRO.social_7 = "В";
						}
						break;
					case 1:
						{
							PRO.social_7 = "С";
						}
						break;
					case 2:
						{
							PRO.social_7 = "Н";
						}
						break;
					case 3:
						{
							PRO.social_7 = "Низ";
						}
						break;
				}


				//////////////////////////////////////////////////////////////////////////////////////////


				switch (spe_1.SelectedIndex)
				{
					case 0:
						{
							PRO.speech_1 = "В";
						}
						break;
					case 1:
						{
							PRO.speech_1 = "С";
						}
						break;
					case 2:
						{
							PRO.speech_1 = "Н";
						}
						break;
					case 3:
						{
							PRO.speech_1 = "Низ";
						}
						break;
				}

				switch (spe_2.SelectedIndex)
				{
					case 0:
						{
							PRO.speech_2 = "В";
						}
						break;
					case 1:
						{
							PRO.speech_2 = "С";
						}
						break;
					case 2:
						{
							PRO.speech_2 = "Н";
						}
						break;
					case 3:
						{
							PRO.speech_2 = "Низ";
						}
						break;
				}

				switch (spe_3.SelectedIndex)
				{
					case 0:
						{
							PRO.speech_3 = "В";
						}
						break;
					case 1:
						{
							PRO.speech_3 = "С";
						}
						break;
					case 2:
						{
							PRO.speech_3 = "Н";
						}
						break;
					case 3:
						{
							PRO.speech_3 = "Низ";
						}
						break;
				}

				switch (spe_4.SelectedIndex)
				{
					case 0:
						{
							PRO.speech_4 = "В";
						}
						break;
					case 1:
						{
							PRO.speech_4 = "С";
						}
						break;
					case 2:
						{
							PRO.speech_4 = "Н";
						}
						break;
					case 3:
						{
							PRO.speech_4 = "Низ";
						}
						break;

				}

				switch (spe_5.SelectedIndex)
				{
					case 0:
						{
							PRO.speech_5 = "В";
						}
						break;
					case 1:
						{
							PRO.speech_5 = "С";
						}
						break;
					case 2:
						{
							PRO.speech_5 = "Н";
						}
						break;
					case 3:
						{
							PRO.speech_5 = "Низ";
						}
						break;
				}

				switch (spe_6.SelectedIndex)
				{
					case 0:
						{
							PRO.speech_6 = "В";
						}
						break;
					case 1:
						{
							PRO.speech_6 = "С";
						}
						break;
					case 2:
						{
							PRO.speech_6 = "Н";
						}
						break;
					case 3:
						{
							PRO.speech_6 = "Низ";
						}
						break;
				}

				switch (spe_7.SelectedIndex)
				{
					case 0:
						{
							PRO.speech_7 = "В";
						}
						break;
					case 1:
						{
							PRO.speech_7 = "С";
						}
						break;
					case 2:
						{
							PRO.speech_7 = "Н";
						}
						break;
					case 3:
						{
							PRO.speech_7 = "Низ";
						}
						break;
				}



				//////////////////////////////////////////////////////////////////////////////////////////


				switch (phy_1.SelectedIndex)
				{
					case 0:
						{
							PRO.physical_1 = "В";
						}
						break;
					case 1:
						{
							PRO.physical_1 = "С";
						}
						break;
					case 2:
						{
							PRO.physical_1 = "Н";
						}
						break;
					case 3:
						{
							PRO.physical_1 = "Низ";
						}
						break;
				}

				switch (phy_2.SelectedIndex)
				{
					case 0:
						{
							PRO.physical_2 = "В";
						}
						break;
					case 1:
						{
							PRO.physical_2 = "С";
						}
						break;
					case 2:
						{
							PRO.physical_2 = "Н";
						}
						break;
					case 3:
						{
							PRO.physical_2 = "Низ";
						}
						break;
				}

				switch(phy_3.SelectedIndex)
				{
					case 0:
						{
							PRO.physical_3 = "В";
						}
						break;
					case 1:
						{
							PRO.physical_3 = "С";
						}
						break;
					case 2:
						{
							PRO.physical_3 = "Н";
						}
						break;
					case 3:
						{
							PRO.physical_3 = "Низ";
						}
						break;
				}

				switch (phy_4.SelectedIndex)
				{
					case 0:
						{
							PRO.physical_4 = "В";
						}
						break;
					case 1:
						{
							PRO.physical_4 = "С";
						}
						break;
					case 2:
						{
							PRO.physical_4 = "Н";
						}
						break;
					case 3:
						{
							PRO.physical_4 = "Низ";
						}
						break;

				}

				switch (phy_5.SelectedIndex)
				{
					case 0:
						{
							PRO.physical_5 = "В";
						}
						break;
					case 1:
						{
							PRO.physical_5 = "С";
						}
						break;
					case 2:
						{
							PRO.physical_5 = "Н";
						}
						break;
					case 3:
						{
							PRO.physical_5 = "Низ";
						}
						break;
				}

				switch (phy_6.SelectedIndex)
				{
					case 0:
						{
							PRO.physical_6 = "В";
						}
						break;
					case 1:
						{
							PRO.physical_6 = "С";
						}
						break;
					case 2:
						{
							PRO.physical_6 = "Н";
						}
						break;
					case 3:
						{
							PRO.physical_6 = "Низ";
						}
						break;
				}

				switch (phy_7.SelectedIndex)
				{
					case 0:
						{
							PRO.physical_7 = "В";
						}
						break;
					case 1:
						{
							PRO.physical_7 = "С";
						}
						break;
					case 2:
						{
							PRO.physical_7 = "Н";
						}
						break;
					case 3:
						{
							PRO.physical_7 = "Низ";
						}
						break;
				}


				//////////////////////////////////////////////////////////////////////////////////////////


				switch (art_1.SelectedIndex)
				{
					case 0:
						{
							PRO.artistic_1 = "В";
						}
						break;
					case 1:
						{
							PRO.artistic_1 = "С";
						}
						break;
					case 2:
						{
							PRO.artistic_1 = "Н";
						}
						break;
					case 3:
						{
							PRO.artistic_1 = "Низ";
						}
						break;
				}

				switch (art_2.SelectedIndex)
				{
					case 0:
						{
							PRO.artistic_2 = "В";
						}
						break;
					case 1:
						{
							PRO.artistic_2 = "С";
						}
						break;
					case 2:
						{
							PRO.artistic_2 = "Н";
						}
						break;
					case 3:
						{
							PRO.artistic_2 = "Низ";
						}
						break;
				}

				switch (art_3.SelectedIndex)
				{
					case 0:
						{
							PRO.artistic_3 = "В";
						}
						break;
					case 1:
						{
							PRO.artistic_3 = "С";
						}
						break;
					case 2:
						{
							PRO.artistic_3 = "Н";
						}
						break;
					case 3:
						{
							PRO.artistic_3 = "Низ";
						}
						break;
				}

				switch (art_4.SelectedIndex)
				{
					case 0:
						{
							PRO.artistic_4 = "В";
						}
						break;
					case 1:
						{
							PRO.artistic_4 = "С";
						}
						break;
					case 2:
						{
							PRO.artistic_4 = "Н";
						}
						break;
					case 3:
						{
							PRO.artistic_4 = "Низ";
						}
						break;

				}

				switch (art_5.SelectedIndex)
				{
					case 0:
						{
							PRO.artistic_5 = "В";
						}
						break;
					case 1:
						{
							PRO.artistic_5 = "С";
						}
						break;
					case 2:
						{
							PRO.artistic_5 = "Н";
						}
						break;
					case 3:
						{
							PRO.artistic_5 = "Низ";
						}
						break;
				}

				switch (art_6.SelectedIndex)
				{
					case 0:
						{
							PRO.artistic_6 = "В";
						}
						break;
					case 1:
						{
							PRO.artistic_6 = "С";
						}
						break;
					case 2:
						{
							PRO.artistic_6 = "Н";
						}
						break;
					case 3:
						{
							PRO.artistic_6 = "Низ";
						}
						break;
				}

				switch (art_7.SelectedIndex)
				{
					case 0:
						{
							PRO.artistic_7 = "В";
						}
						break;
					case 1:
						{
							PRO.artistic_7 = "С";
						}
						break;
					case 2:
						{
							PRO.artistic_7 = "Н";
						}
						break;
					case 3:
						{
							PRO.artistic_7 = "Низ";
						}
						break;
				}


				//////////////////////////////////////////////////////////////////////////////////////////


				switch (cog_1.SelectedIndex)
				{
					case 0:
						{
							PRO.cognitive_1 = "В";
						}
						break;
					case 1:
						{
							PRO.cognitive_1 = "С";
						}
						break;
					case 2:
						{
							PRO.cognitive_1 = "Н";
						}
						break;
					case 3:
						{
							PRO.cognitive_1 = "Низ";
						}
						break;
				}

				switch (cog_2.SelectedIndex)
				{
					case 0:
						{
							PRO.cognitive_2 = "В";
						}
						break;
					case 1:
						{
							PRO.cognitive_2 = "С";
						}
						break;
					case 2:
						{
							PRO.cognitive_2 = "Н";
						}
						break;
					case 3:
						{
							PRO.cognitive_2 = "Низ";
						}
						break;
				}

				switch (cog_3.SelectedIndex)
				{
					case 0:
						{
							PRO.cognitive_3 = "В";
						}
						break;
					case 1:
						{
							PRO.cognitive_3 = "С";
						}
						break;
					case 2:
						{
							PRO.cognitive_3 = "Н";
						}
						break;
					case 3:
						{
							PRO.cognitive_3 = "Низ";
						}
						break;
				}

				switch (cog_4.SelectedIndex)
				{
					case 0:
						{
							PRO.cognitive_4 = "В";
						}
						break;
					case 1:
						{
							PRO.cognitive_4 = "С";
						}
						break;
					case 2:
						{
							PRO.cognitive_4 = "Н";
						}
						break;
					case 3:
						{
							PRO.cognitive_4 = "Низ";
						}
						break;

				}

				switch (cog_5.SelectedIndex)
				{
					case 0:
						{
							PRO.cognitive_5 = "В";
						}
						break;
					case 1:
						{
							PRO.cognitive_5 = "С";
						}
						break;
					case 2:
						{
							PRO.cognitive_5 = "Н";
						}
						break;
					case 3:
						{
							PRO.cognitive_5 = "Низ";
						}
						break;
				}

				switch (cog_6.SelectedIndex)
				{
					case 0:
						{
							PRO.cognitive_6 = "В";
						}
						break;
					case 1:
						{
							PRO.cognitive_6 = "С";
						}
						break;
					case 2:
						{
							PRO.cognitive_6 = "Н";
						}
						break;
					case 3:
						{
							PRO.cognitive_6 = "Низ";
						}
						break;
				}

				switch (cog_7.SelectedIndex)
				{
					case 0:
						{
							PRO.cognitive_7 = "В";
						}
						break;
					case 1:
						{
							PRO.cognitive_7 = "С";
						}
						break;
					case 2:
						{
							PRO.cognitive_7 = "Н";
						}
						break;
					case 3:
						{
							PRO.cognitive_7 = "Низ";
						}
						break;
				}
				ClassBase.BD.Children.Add(PRO);

				ClassBase.BD.SaveChanges();
				MessageBox.Show("Информация добавлена");
				ClassFrame.frm_2.Navigate(new Create());
			}
			else
			{
                MessageBox.Show("ОШИБКА!!! \n" +
					"Возможно, вы не заполнели некоторые поля данными!");
			}
			
		}
	}
}
