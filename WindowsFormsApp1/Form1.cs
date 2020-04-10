using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;



namespace WindowsFormsApp1
{


	public partial class Form1 : Form
	{
		public List<Information> Objects = new List<Information>();
		public List<TextBox> List_Text_Box = new List<TextBox>();
		public Form1()
		{
			InitializeComponent();
			List_Text_Box.Add(NM);
			List_Text_Box.Add(BO);
			List_Text_Box.Add(JA);
			List_Text_Box.Add(PAG);
			List_Text_Box.Add(OPI);
			List_Text_Box.Add(CO);

		}

		private void SaveBut_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Сохранить изменения?",
				"сохранение",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2);
			if (dr == DialogResult.OK)
			{
				this.Validate();
				this.biblBindingSource.EndEdit();
				biblTableAdapter2.Update(this.kursDataSet.Bibl);
				kursDataSet.Tables[0].AcceptChanges();
				Bibl.data_update(this.Table, this.Objects);
			}

		}

		private void biblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();

			this.biblBindingSource.EndEdit();

			Bibl.data_recover(this.Table, this.Objects);
			Bibl.data_update(this.Table, this.Objects);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Bibl". При необходимости она может быть перемещена или удалена.
			this.biblTableAdapter2.Fill(this.kursDataSet.Bibl);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Office_Access_2007_База_данныхDataSet1.Bibl". При необходимости она может быть перемещена или удалена.

			Bibl.data_recover(this.Table, this.Objects);
			Bibl.data_update(this.Table, this.Objects);

		}

		private void DelBut_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Удалить запись?",
				"Удаление",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2);
			if (dr == DialogResult.OK)
			{
				Bibl.position_delete(this.Table, this.Objects);
			}

		}

		private void SearchBut_Click(object sender, EventArgs e)
		{
			if (NmCh.Checked)
			{
				if (SearchBox.Text.Length == 0) SearchBox.Text = "Вы не ввели параметр для поиска";
				else
				{
					List<Information> find_pos = new List<Information>();
					find_pos = Bibl.find_person_Name(this.Objects, SearchBox.Text);
					if (find_pos.Count == 0)
					{
						DialogResult dr = MessageBox.Show("Записи не найдены",
						"Поиск",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning,
						MessageBoxDefaultButton.Button1);
					}
					else
					{
						Find.BringToFront();
						Find.DataSource = find_pos;
					}
				}
			}
			if (JaCh.Checked)
			{
				if (SearchBox.Text.Length == 0) SearchBox.Text = "Вы не ввели параметр для поиска";
				else
				{
					List<Information> find_pos = new List<Information>();
					find_pos = Bibl.find_person_janr(this.Objects, SearchBox.Text);
					if (find_pos.Count == 0)
					{
						DialogResult dr = MessageBox.Show("Записи не найдены",
						"Поиск",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning,
						MessageBoxDefaultButton.Button1);
					}
					else
					{
						Find.BringToFront();
						Find.DataSource = find_pos;
					}
				}
			}
			if (BoCh.Checked)
			{
				List<Information> find_pos = new List<Information>();
				find_pos = Bibl.find_person_book(this.Objects, SearchBox.Text);
				if (find_pos.Count == 0)
				{
					DialogResult dr = MessageBox.Show("Записи не найдены",
					"Поиск",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning,
					MessageBoxDefaultButton.Button1);
				}
				else
				{
					Find.BringToFront();
					Find.DataSource = find_pos;
				}
			}

		}

		private void NmCh_CheckedChanged(object sender, EventArgs e)
		{
			BoCh.Enabled = false;
			JaCh.Enabled = false;

		}

		private void BoCh_CheckedChanged(object sender, EventArgs e)
		{
			NmCh.Enabled = false;
			JaCh.Enabled = false;
		}

		private void JaCh_CheckedChanged(object sender, EventArgs e)
		{
			BoCh.Enabled = false;
			NmCh.Enabled = false;
		}
		private void button_off()
		{
			OkBut.Enabled = false;
			CancelBut.Enabled = false;
			AddBut.Enabled = false;
			NM.Enabled = false;
			BO.Enabled = false;
			JA.Enabled = false;
			OPI.Enabled = false;
			PAG.Enabled = false;
			CO.Enabled = false;
		}
		private void button_on()
		{
			OkBut.Enabled = true;
			CancelBut.Enabled = true;
			AddBut.Enabled = true;
			NM.Enabled = true;
			BO.Enabled = true;
			JA.Enabled = true;
			OPI.Enabled = true;
			PAG.Enabled = true;
			CO.Enabled = true;
		}

		private void Table_SelectionChanged(object sender, EventArgs e)
		{
			button_off();
			foreach (DataGridViewRow row in Table.SelectedRows)
			{
				Bibl.Show(List_Text_Box, row);
			}

		}

		private void RedBut_Click(object sender, EventArgs e)
		{
			button_on();
		}

		private void OkBut_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Изменить запись?",
			"Редактирование",
			MessageBoxButtons.OKCancel,
			MessageBoxIcon.Question,
			MessageBoxDefaultButton.Button2);
			if (dr == DialogResult.OK)
			{
				if (NM.Text != "" && PAG.Text != "" && BO.Text != "" && OPI.Text
				!= "" && JA.Text != "")
				{
					foreach (DataGridViewRow row in Table.SelectedRows)
					{
						Bibl.edit(List_Text_Box, row);
					}
					Table.Refresh();
					Bibl.data_update(this.Table, this.Objects);
					MessageBox.Show("Изменения внесены!");
				}
				else
				{
					MessageBox.Show("Некорректный ввод! Поля пусты.",
					"Редактирование",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information,
					MessageBoxDefaultButton.Button1);
				}
			}


		}

		private void CancelBut_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Отменить изменения?",
				"Изменение",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2);
			if (dr == DialogResult.OK)
			{
				foreach (DataGridViewRow row in Table.SelectedRows)
					Bibl.Show(List_Text_Box, row);
			}

		}

		private void AddBut_Click(object sender, EventArgs e)
		{
			if (NM.Text != "" && BO.Text != "" && OPI.Text != "" && JA.Text != "" && PAG.Text != "")
			{
				DialogResult dr = MessageBox.Show("Добавить запись?",
				"Добавление",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2);
				if (dr == DialogResult.OK)
				{
					bool flag = false;
					for (int i = 0; i < Objects.Count; i++)
					{
						if (NM.Text == Objects[i].Name &&
							BO.Text == Objects[i].bookname &&
							JA.Text == Objects[i].Janr &&
							OPI.Text == Objects[i].opis ||
							CO.Text == Objects[i].index.ToString())
						{
							flag = true;
						}
					}
					if (!flag)
					{
						this.Validate();
						this.biblBindingSource.EndEdit();
						DataRow nRow = kursDataSet.Tables[0].NewRow();
						nRow["Код"] = CO.Text.ToString();
						nRow["Имя"] = NM.Text.ToString();
						nRow["Книга"] = BO.Text.ToString();
						nRow["Жанр"] = JA.Text.ToString();
						nRow["Страницы"] = PAG.Text.ToString();
						nRow["Описание"] = OPI.Text.ToString();
						kursDataSet.Tables[0].Rows.Add(nRow);
						biblTableAdapter2.Update(kursDataSet.Bibl);
						kursDataSet.Tables[0].AcceptChanges();
						Table.Refresh();
						Bibl.data_update(this.Table, this.Objects);
						NM.Clear();
						BO.Clear();
						JA.Clear();
						PAG.Clear();
						OPI.Clear();
						CO.Clear();
					}
					if (flag)
					{
						DialogResult er = MessageBox.Show("Такая запись уже существует!",
							"Добавление",
							MessageBoxButtons.OK,
							MessageBoxIcon.Warning,
							MessageBoxDefaultButton.Button1);
					}
				}
			}
			else
			{
				DialogResult dr = MessageBox.Show("Некорректный ввод! Поля пусты.",
				"Добавление",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information,
				MessageBoxDefaultButton.Button1);
			}

		}

		private void sbros_Click(object sender, EventArgs e)
		{
			button_off();
			foreach (DataGridViewRow row in Table.SelectedRows)
			{
				row.Selected = false;
			}
			NM.Clear(); PAG.Clear(); BO.Clear(); OPI.Clear();
			JA.Clear(); CO.Clear();

		}

		private void Find_SelectionChanged(object sender, EventArgs e)//отображениевыбранного сотрудника из dgv поиска
		{
			button_off();
			foreach (DataGridViewRow row in Find.SelectedRows)
			{
				Bibl.Show_Find(List_Text_Box, row);
				foreach (DataGridViewRow Drow in Table.Rows)
				{
					if (row.Cells["index"].Value.ToString() ==
					Drow.Cells["Cod"].Value.ToString() &&
					row.Cells["Name"].Value.ToString() ==
					Drow.Cells["name"].Value.ToString() &&
					row.Cells["bookname"].Value.ToString() ==
					Drow.Cells["Book"].Value.ToString() &&
					row.Cells["Janr"].Value.ToString() ==
					Drow.Cells["janr"].Value.ToString()
					&&
					row.Cells["Opis"].Value.ToString() ==
					Drow.Cells["opis"].Value.ToString())
					{
						foreach (DataGridViewRow Drow2 in
						Table.SelectedRows)
						{
							Drow2.Selected = false;
						}
						Drow.Selected = true;
					}
				}
			}
		}




		private void SbrosBut_Click(object sender, EventArgs e)
		{
			BoCh.Enabled = true;
			BoCh.Checked = false;
			JaCh.Enabled = true;
			JaCh.Checked = false;
			NmCh.Enabled = true;
			NmCh.Checked = false;
			SearchBox.Enabled = true;
			Table.BringToFront();
			SearchBox.Clear();
		}

		private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}

