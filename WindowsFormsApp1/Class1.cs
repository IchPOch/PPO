using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
	public class Information
	{

		private int index_;
		private string Name_;
		private string bookname_;
		private string Janr_;
		private string pages_;
		private string opis_;
		public int index
		{
			get {return index_; }
			set {index_ = value; }
		}
		public string Name
		{
			get { return Name_; }
			set { Name_ = value; }
		}
		public string bookname
		{
			get { return bookname_; }
			set { bookname_ = value; }
		}
		public string Janr
		{
			get { return Janr_; }
			set { Janr_ = value; }
		}
		public string pages
		{
			get { return pages_; }
			set { pages_ = value; }
		}
		public string opis
		{
			get { return opis_; }
			set { opis_ = value; }
		}

		public Information() { }
		public void ToInformation(DataGridViewRow row)
		{
			this.index = Convert.ToInt32(row.Cells["Cod"].Value);
			this.Name = row.Cells["Name"].Value.ToString();
			this.bookname = row.Cells["Book"].Value.ToString();
			this.Janr = row.Cells["Janr"].Value.ToString();
			this.pages = row.Cells["Page"].Value.ToString();
			this.opis = row.Cells["Opis"].Value.ToString();
		}
	}

}
