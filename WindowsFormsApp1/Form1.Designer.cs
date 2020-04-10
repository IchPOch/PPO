namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddBut = new System.Windows.Forms.Button();
            this.CancelBut = new System.Windows.Forms.Button();
            this.OkBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Код = new System.Windows.Forms.Label();
            this.CO = new System.Windows.Forms.TextBox();
            this.RedBut = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.OPI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.JA = new System.Windows.Forms.TextBox();
            this.PAG = new System.Windows.Forms.TextBox();
            this.NM = new System.Windows.Forms.TextBox();
            this.BO = new System.Windows.Forms.TextBox();
            this.sbros = new System.Windows.Forms.Button();
            this.DelBut = new System.Windows.Forms.Button();
            this.SaveBut = new System.Windows.Forms.Button();
            this.biblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursDataSet = new WindowsFormsApp1.KursDataSet();
            this.biblBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.biblTableAdapter2 = new WindowsFormsApp1.KursDataSetTableAdapters.BiblTableAdapter();
            this.tableAdapterManager2 = new WindowsFormsApp1.KursDataSetTableAdapters.TableAdapterManager();
            this.Table = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Janr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Page = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchBut = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.JaCh = new System.Windows.Forms.CheckBox();
            this.BoCh = new System.Windows.Forms.CheckBox();
            this.NmCh = new System.Windows.Forms.CheckBox();
            this.Find = new System.Windows.Forms.DataGridView();
            this.SbrosBut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Find)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBut
            // 
            this.AddBut.Location = new System.Drawing.Point(0, 171);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(75, 23);
            this.AddBut.TabIndex = 0;
            this.AddBut.Text = "Add";
            this.AddBut.UseVisualStyleBackColor = true;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // CancelBut
            // 
            this.CancelBut.Location = new System.Drawing.Point(165, 171);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(75, 23);
            this.CancelBut.TabIndex = 1;
            this.CancelBut.Text = "Cancel";
            this.CancelBut.UseVisualStyleBackColor = true;
            this.CancelBut.Click += new System.EventHandler(this.CancelBut_Click);
            // 
            // OkBut
            // 
            this.OkBut.Location = new System.Drawing.Point(84, 171);
            this.OkBut.Name = "OkBut";
            this.OkBut.Size = new System.Drawing.Size(75, 23);
            this.OkBut.TabIndex = 2;
            this.OkBut.Text = "OK";
            this.OkBut.UseVisualStyleBackColor = true;
            this.OkBut.Click += new System.EventHandler(this.OkBut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Код);
            this.groupBox1.Controls.Add(this.CO);
            this.groupBox1.Controls.Add(this.RedBut);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.OPI);
            this.groupBox1.Controls.Add(this.CancelBut);
            this.groupBox1.Controls.Add(this.OkBut);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddBut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.JA);
            this.groupBox1.Controls.Add(this.PAG);
            this.groupBox1.Controls.Add(this.NM);
            this.groupBox1.Controls.Add(this.BO);
            this.groupBox1.Location = new System.Drawing.Point(12, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 200);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "КНИГА";
            // 
            // Код
            // 
            this.Код.AutoSize = true;
            this.Код.Location = new System.Drawing.Point(31, 26);
            this.Код.Name = "Код";
            this.Код.Size = new System.Drawing.Size(26, 13);
            this.Код.TabIndex = 16;
            this.Код.Text = "Код";
            // 
            // CO
            // 
            this.CO.Location = new System.Drawing.Point(59, 19);
            this.CO.Name = "CO";
            this.CO.Size = new System.Drawing.Size(100, 20);
            this.CO.TabIndex = 16;
            // 
            // RedBut
            // 
            this.RedBut.Location = new System.Drawing.Point(246, 171);
            this.RedBut.Name = "RedBut";
            this.RedBut.Size = new System.Drawing.Size(75, 23);
            this.RedBut.TabIndex = 5;
            this.RedBut.Text = "Redact";
            this.RedBut.UseVisualStyleBackColor = true;
            this.RedBut.Click += new System.EventHandler(this.RedBut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Описание";
            // 
            // OPI
            // 
            this.OPI.Location = new System.Drawing.Point(59, 98);
            this.OPI.Multiline = true;
            this.OPI.Name = "OPI";
            this.OPI.Size = new System.Drawing.Size(264, 67);
            this.OPI.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Страницы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Жанр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Книга";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Автор";
            // 
            // JA
            // 
            this.JA.Location = new System.Drawing.Point(59, 72);
            this.JA.Name = "JA";
            this.JA.Size = new System.Drawing.Size(100, 20);
            this.JA.TabIndex = 5;
            // 
            // PAG
            // 
            this.PAG.Location = new System.Drawing.Point(229, 71);
            this.PAG.Name = "PAG";
            this.PAG.Size = new System.Drawing.Size(100, 20);
            this.PAG.TabIndex = 6;
            // 
            // NM
            // 
            this.NM.Location = new System.Drawing.Point(59, 45);
            this.NM.Name = "NM";
            this.NM.Size = new System.Drawing.Size(100, 20);
            this.NM.TabIndex = 7;
            // 
            // BO
            // 
            this.BO.Location = new System.Drawing.Point(229, 45);
            this.BO.Name = "BO";
            this.BO.Size = new System.Drawing.Size(100, 20);
            this.BO.TabIndex = 8;
            // 
            // sbros
            // 
            this.sbros.Location = new System.Drawing.Point(353, 455);
            this.sbros.Name = "sbros";
            this.sbros.Size = new System.Drawing.Size(107, 23);
            this.sbros.TabIndex = 6;
            this.sbros.Text = "Снять выделение";
            this.sbros.UseVisualStyleBackColor = true;
            this.sbros.Click += new System.EventHandler(this.sbros_Click);
            // 
            // DelBut
            // 
            this.DelBut.Location = new System.Drawing.Point(353, 363);
            this.DelBut.Name = "DelBut";
            this.DelBut.Size = new System.Drawing.Size(107, 42);
            this.DelBut.TabIndex = 7;
            this.DelBut.Text = "Delete";
            this.DelBut.UseVisualStyleBackColor = true;
            this.DelBut.Click += new System.EventHandler(this.DelBut_Click);
            // 
            // SaveBut
            // 
            this.SaveBut.Location = new System.Drawing.Point(353, 411);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(107, 38);
            this.SaveBut.TabIndex = 8;
            this.SaveBut.Text = "Save";
            this.SaveBut.UseVisualStyleBackColor = true;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // biblBindingSource
            // 
            this.biblBindingSource.DataMember = "Bibl";
            // 
            // biblBindingSource1
            // 
            this.biblBindingSource1.DataMember = "Bibl";
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "KursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biblBindingSource2
            // 
            this.biblBindingSource2.DataMember = "Bibl";
            this.biblBindingSource2.DataSource = this.kursDataSet;
            // 
            // biblTableAdapter2
            // 
            this.biblTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.BiblTableAdapter = this.biblTableAdapter2;
            this.tableAdapterManager2.UpdateOrder = WindowsFormsApp1.KursDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AutoGenerateColumns = false;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Name,
            this.Book,
            this.Janr,
            this.Page,
            this.Opis});
            this.Table.DataSource = this.biblBindingSource2;
            this.Table.Location = new System.Drawing.Point(353, 0);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(642, 285);
            this.Table.TabIndex = 9;
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellContentClick);
            this.Table.SelectionChanged += new System.EventHandler(this.Table_SelectionChanged);
            // 
            // Cod
            // 
            this.Cod.DataPropertyName = "Код";
            this.Cod.HeaderText = "Код";
            this.Cod.Name = "Cod";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Имя";
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            // 
            // Book
            // 
            this.Book.DataPropertyName = "Книга";
            this.Book.HeaderText = "Книга";
            this.Book.Name = "Book";
            // 
            // Janr
            // 
            this.Janr.DataPropertyName = "Жанр";
            this.Janr.HeaderText = "Жанр";
            this.Janr.Name = "Janr";
            // 
            // Page
            // 
            this.Page.DataPropertyName = "Страницы";
            this.Page.HeaderText = "Страницы";
            this.Page.Name = "Page";
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Описание";
            this.Opis.HeaderText = "Описание";
            this.Opis.Name = "Opis";
            // 
            // SearchBut
            // 
            this.SearchBut.Location = new System.Drawing.Point(106, 54);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(88, 25);
            this.SearchBut.TabIndex = 10;
            this.SearchBut.Text = "Serch";
            this.SearchBut.UseVisualStyleBackColor = true;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(12, 28);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(198, 20);
            this.SearchBox.TabIndex = 11;
            // 
            // JaCh
            // 
            this.JaCh.AutoSize = true;
            this.JaCh.Location = new System.Drawing.Point(170, 5);
            this.JaCh.Name = "JaCh";
            this.JaCh.Size = new System.Drawing.Size(46, 17);
            this.JaCh.TabIndex = 12;
            this.JaCh.Text = "Janr";
            this.JaCh.UseVisualStyleBackColor = true;
            this.JaCh.CheckedChanged += new System.EventHandler(this.JaCh_CheckedChanged);
            // 
            // BoCh
            // 
            this.BoCh.AutoSize = true;
            this.BoCh.Location = new System.Drawing.Point(92, 5);
            this.BoCh.Name = "BoCh";
            this.BoCh.Size = new System.Drawing.Size(72, 17);
            this.BoCh.TabIndex = 13;
            this.BoCh.Text = "По книге";
            this.BoCh.UseVisualStyleBackColor = true;
            this.BoCh.CheckedChanged += new System.EventHandler(this.BoCh_CheckedChanged);
            // 
            // NmCh
            // 
            this.NmCh.AutoSize = true;
            this.NmCh.Location = new System.Drawing.Point(12, 5);
            this.NmCh.Name = "NmCh";
            this.NmCh.Size = new System.Drawing.Size(75, 17);
            this.NmCh.TabIndex = 14;
            this.NmCh.Text = "По имени";
            this.NmCh.UseVisualStyleBackColor = true;
            this.NmCh.CheckedChanged += new System.EventHandler(this.NmCh_CheckedChanged);
            // 
            // Find
            // 
            this.Find.AllowUserToAddRows = false;
            this.Find.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Find.Location = new System.Drawing.Point(353, 0);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(642, 285);
            this.Find.TabIndex = 15;
            this.Find.SelectionChanged += new System.EventHandler(this.Find_SelectionChanged);
            // 
            // SbrosBut
            // 
            this.SbrosBut.Location = new System.Drawing.Point(12, 54);
            this.SbrosBut.Name = "SbrosBut";
            this.SbrosBut.Size = new System.Drawing.Size(88, 25);
            this.SbrosBut.TabIndex = 16;
            this.SbrosBut.Text = "Сброс";
            this.SbrosBut.UseVisualStyleBackColor = true;
            this.SbrosBut.Click += new System.EventHandler(this.SbrosBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 496);
            this.Controls.Add(this.SbrosBut);
            this.Controls.Add(this.NmCh);
            this.Controls.Add(this.BoCh);
            this.Controls.Add(this.JaCh);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchBut);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.SaveBut);
            this.Controls.Add(this.DelBut);
            this.Controls.Add(this.sbros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Find);
            //this.Name = "Form1";
            this.Text = "Сохранить";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Find)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.Button OkBut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RedBut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OPI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox JA;
        private System.Windows.Forms.TextBox PAG;
        private System.Windows.Forms.TextBox NM;
        private System.Windows.Forms.TextBox BO;
        private System.Windows.Forms.Button sbros;
        private System.Windows.Forms.Button DelBut;
        private System.Windows.Forms.Button SaveBut;

        private System.Windows.Forms.BindingSource biblBindingSource;

        private System.Windows.Forms.BindingSource biblBindingSource1;

        private KursDataSet kursDataSet;
        private System.Windows.Forms.BindingSource biblBindingSource2;
        private KursDataSetTableAdapters.BiblTableAdapter biblTableAdapter2;
        private KursDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button SearchBut;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.CheckBox JaCh;
        private System.Windows.Forms.CheckBox BoCh;
        private System.Windows.Forms.CheckBox NmCh;
        private System.Windows.Forms.DataGridView Find;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Janr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Page;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.TextBox CO;
        private System.Windows.Forms.Label Код;
        private System.Windows.Forms.Button SbrosBut;
    }
}

