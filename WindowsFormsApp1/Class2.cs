using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public static class Bibl
    {
		public static void data_recover(DataGridView a, List<Information> l)
		{
			foreach (DataGridViewRow row in a.Rows)
			{
				Information buf = new Information();
				buf.ToInformation(row);
				l.Add(buf);
			}
		}
		public static void edit(List<TextBox> list, DataGridViewRow row)	
		{
			row.Cells["Name"].Value = list[0].Text;
			row.Cells["Book"].Value = list[1].Text;
			row.Cells["Janr"].Value = list[2].Text;
			row.Cells["Page"].Value = list[3].Text;
			row.Cells["Opis"].Value = list[4].Text;
			row.Cells["Cod"].Value = list[5].Text;
		}
		public static void data_update(DataGridView a, List<Information> l)
		{

			l.Clear();
			foreach (DataGridViewRow row in a.Rows)
			{
				Information buf = new Information();
				buf.ToInformation(row);
				l.Add(buf);
			}
		}
		public static void position_delete(DataGridView a, List<Information> l)
		{
			Information buf = new Information();
			foreach (DataGridViewRow row in a.SelectedRows)
			{
				a.Rows.Remove(row);
			}
			Bibl.data_update(a, l);
		}
		public static List<Information> find_person_Name(List<Information> l, string s)
		{
			List<Information> find = new List<Information>();
			foreach (Information person in l)
			{
				if (person.Name.Contains(s))
				{
					find.Add(person);
				}
			}
			return find;
		}
		public static List<Information> find_person_book(List<Information> l, string s)
		{
			List<Information> find = new List<Information>();
			foreach (Information person in l)
			{
				if (person.bookname.Contains(s))
				{
					find.Add(person);
				}
			}
			return find;
		}
		public static List<Information> find_person_janr(List<Information> l, string s)
		{
			List<Information> find = new List<Information>();
			foreach (Information person in l)
			{
				if (person.Janr.Contains(s))
				{
					find.Add(person);
				}
			}
			return find;
		}
		public static void Show(List<TextBox> f, DataGridViewRow row)
		{
			f[0].Text = row.Cells["Name"].Value.ToString();
			f[1].Text = row.Cells["Book"].Value.ToString();
			f[2].Text = row.Cells["Janr"].Value.ToString();
			f[3].Text = row.Cells["Page"].Value.ToString();
			f[4].Text = row.Cells["Opis"].Value.ToString();
			f[5].Text = row.Cells["Cod"].Value.ToString();
		}
		public static void Show_Find(List<TextBox> f, DataGridViewRow row)
		{
					f[0].Text = row.Cells["Name"].Value.ToString();
			f[1].Text = row.Cells["bookname"].Value.ToString();
			f[2].Text = row.Cells["Janr"].Value.ToString();
			f[3].Text = row.Cells["Pages"].Value.ToString();
			f[4].Text = row.Cells["Opis"].Value.ToString();
			f[5].Text = row.Cells["index"].Value.ToString();
		}

	}
}
