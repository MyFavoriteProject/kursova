namespace oblik
{
    partial class Statementofmaterialvalue
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
            this.statement = new System.Windows.Forms.DataGridView();
            this.inventory = new System.Windows.Forms.Panel();
            this.numberlabel = new System.Windows.Forms.NumericUpDown();
            this.dateofdeparturelabel = new System.Windows.Forms.DateTimePicker();
            this.dateofreceiptlabel = new System.Windows.Forms.DateTimePicker();
            this.placeofstoragelabel = new System.Windows.Forms.ComboBox();
            this.responsibleperson = new System.Windows.Forms.Label();
            this.person = new System.Windows.Forms.TextBox();
            this.placeofstorage = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.sumalabel = new System.Windows.Forms.TextBox();
            this.pricelabel = new System.Windows.Forms.TextBox();
            this.graduationyearlabel = new System.Windows.Forms.TextBox();
            this.graduationyear = new System.Windows.Forms.Label();
            this.dateofdeparture = new System.Windows.Forms.Label();
            this.dateofreceipt = new System.Windows.Forms.Label();
            this.nameofmaterialvalueslabel = new System.Windows.Forms.TextBox();
            this.nameofmaterialvalues = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.filemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.print = new System.Windows.Forms.ToolStripMenuItem();
            this.searchbynamelabel = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.searchbyname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statement)).BeginInit();
            this.inventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberlabel)).BeginInit();
            this.menu.SuspendLayout();
            this.searchbynamelabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.statement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statement.Location = new System.Drawing.Point(12, 35);
            this.statement.Name = "dataGridView1";
            this.statement.Size = new System.Drawing.Size(565, 127);
            this.statement.TabIndex = 1;
            // 
            // panel2
            // 
            this.inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inventory.Controls.Add(this.numberlabel);
            this.inventory.Controls.Add(this.dateofdeparturelabel);
            this.inventory.Controls.Add(this.dateofreceiptlabel);
            this.inventory.Controls.Add(this.placeofstoragelabel);
            this.inventory.Controls.Add(this.responsibleperson);
            this.inventory.Controls.Add(this.person);
            this.inventory.Controls.Add(this.placeofstorage);
            this.inventory.Controls.Add(this.edit);
            this.inventory.Controls.Add(this.delete);
            this.inventory.Controls.Add(this.add);
            this.inventory.Controls.Add(this.open);
            this.inventory.Controls.Add(this.suma);
            this.inventory.Controls.Add(this.price);
            this.inventory.Controls.Add(this.number);
            this.inventory.Controls.Add(this.sumalabel);
            this.inventory.Controls.Add(this.pricelabel);
            this.inventory.Controls.Add(this.graduationyearlabel);
            this.inventory.Controls.Add(this.graduationyear);
            this.inventory.Controls.Add(this.dateofdeparture);
            this.inventory.Controls.Add(this.dateofreceipt);
            this.inventory.Controls.Add(this.nameofmaterialvalueslabel);
            this.inventory.Controls.Add(this.nameofmaterialvalues);
            this.inventory.Location = new System.Drawing.Point(583, 35);
            this.inventory.Name = "panel2";
            this.inventory.Size = new System.Drawing.Size(428, 296);
            this.inventory.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numberlabel.Location = new System.Drawing.Point(135, 113);
            this.numberlabel.Name = "numericUpDown1";
            this.numberlabel.Size = new System.Drawing.Size(91, 20);
            this.numberlabel.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateofdeparturelabel.Location = new System.Drawing.Point(135, 63);
            this.dateofdeparturelabel.Name = "dateTimePicker2";
            this.dateofdeparturelabel.Size = new System.Drawing.Size(91, 20);
            this.dateofdeparturelabel.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateofreceiptlabel.Location = new System.Drawing.Point(135, 37);
            this.dateofreceiptlabel.Name = "dateTimePicker1";
            this.dateofreceiptlabel.Size = new System.Drawing.Size(91, 20);
            this.dateofreceiptlabel.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.placeofstoragelabel.FormattingEnabled = true;
            this.placeofstoragelabel.Items.AddRange(new object[] {
            "Склад 1",
            "Склад 2"});
            this.placeofstoragelabel.Location = new System.Drawing.Point(135, 192);
            this.placeofstoragelabel.Name = "comboBox1";
            this.placeofstoragelabel.Size = new System.Drawing.Size(91, 21);
            this.placeofstoragelabel.TabIndex = 6;
            // 
            // label9
            // 
            this.responsibleperson.AutoSize = true;
            this.responsibleperson.Location = new System.Drawing.Point(13, 222);
            this.responsibleperson.Name = "label9";
            this.responsibleperson.Size = new System.Drawing.Size(111, 13);
            this.responsibleperson.TabIndex = 26;
            this.responsibleperson.Text = "Відповідальна особа";
            // 
            // textBox9
            // 
            this.person.Location = new System.Drawing.Point(135, 219);
            this.person.Name = "textBox9";
            this.person.Size = new System.Drawing.Size(91, 20);
            this.person.TabIndex = 25;
            // 
            // label1
            // 
            this.placeofstorage.AutoSize = true;
            this.placeofstorage.Location = new System.Drawing.Point(13, 196);
            this.placeofstorage.Name = "label1";
            this.placeofstorage.Size = new System.Drawing.Size(94, 13);
            this.placeofstorage.TabIndex = 24;
            this.placeofstorage.Text = "Місце зберігання";
            // 
            // button4
            // 
            this.edit.Location = new System.Drawing.Point(135, 262);
            this.edit.Name = "button4";
            this.edit.Size = new System.Drawing.Size(91, 23);
            this.edit.TabIndex = 22;
            this.edit.Text = "Змінити";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.delete.Location = new System.Drawing.Point(251, 262);
            this.delete.Name = "button3";
            this.delete.Size = new System.Drawing.Size(91, 23);
            this.delete.TabIndex = 21;
            this.delete.Text = "Видалити";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.add.Location = new System.Drawing.Point(16, 262);
            this.add.Name = "button2";
            this.add.Size = new System.Drawing.Size(91, 23);
            this.add.TabIndex = 20;
            this.add.Text = "Добавити";
            this.add.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.open.Location = new System.Drawing.Point(251, 217);
            this.open.Name = "button1";
            this.open.Size = new System.Drawing.Size(91, 23);
            this.open.TabIndex = 19;
            this.open.Text = "Відкрити";
            this.open.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.suma.AutoSize = true;
            this.suma.Location = new System.Drawing.Point(13, 167);
            this.suma.Name = "label8";
            this.suma.Size = new System.Drawing.Size(33, 13);
            this.suma.TabIndex = 18;
            this.suma.Text = "Сума";
            // 
            // label7
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(13, 141);
            this.price.Name = "label7";
            this.price.Size = new System.Drawing.Size(29, 13);
            this.price.TabIndex = 17;
            this.price.Text = "Ціна";
            // 
            // label6
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(13, 115);
            this.number.Name = "label6";
            this.number.Size = new System.Drawing.Size(53, 13);
            this.number.TabIndex = 16;
            this.number.Text = "Кількість";
            // 
            // textBox7
            // 
            this.sumalabel.Location = new System.Drawing.Point(135, 167);
            this.sumalabel.Name = "textBox7";
            this.sumalabel.Size = new System.Drawing.Size(91, 20);
            this.sumalabel.TabIndex = 15;
            // 
            // textBox6
            // 
            this.pricelabel.Location = new System.Drawing.Point(135, 141);
            this.pricelabel.Name = "textBox6";
            this.pricelabel.Size = new System.Drawing.Size(91, 20);
            this.pricelabel.TabIndex = 14;
            // 
            // textBox4
            // 
            this.graduationyearlabel.Location = new System.Drawing.Point(135, 89);
            this.graduationyearlabel.Name = "textBox4";
            this.graduationyearlabel.Size = new System.Drawing.Size(91, 20);
            this.graduationyearlabel.TabIndex = 12;
            // 
            // label5
            // 
            this.graduationyear.AutoSize = true;
            this.graduationyear.Location = new System.Drawing.Point(13, 92);
            this.graduationyear.Name = "label5";
            this.graduationyear.Size = new System.Drawing.Size(65, 13);
            this.graduationyear.TabIndex = 11;
            this.graduationyear.Text = "Рік випуску";
            // 
            // label4
            // 
            this.dateofdeparture.AutoSize = true;
            this.dateofdeparture.Location = new System.Drawing.Point(13, 66);
            this.dateofdeparture.Name = "label4";
            this.dateofdeparture.Size = new System.Drawing.Size(75, 13);
            this.dateofdeparture.TabIndex = 9;
            this.dateofdeparture.Text = "Дата вибуття";
            // 
            // label3
            // 
            this.dateofreceipt.AutoSize = true;
            this.dateofreceipt.Location = new System.Drawing.Point(13, 37);
            this.dateofreceipt.Name = "label3";
            this.dateofreceipt.Size = new System.Drawing.Size(103, 13);
            this.dateofreceipt.TabIndex = 7;
            this.dateofreceipt.Text = "Дата надходження";
            // 
            // textBox1
            // 
            this.nameofmaterialvalueslabel.Location = new System.Drawing.Point(135, 11);
            this.nameofmaterialvalueslabel.Name = "textBox1";
            this.nameofmaterialvalueslabel.Size = new System.Drawing.Size(91, 20);
            this.nameofmaterialvalueslabel.TabIndex = 6;
            // 
            // label2
            // 
            this.nameofmaterialvalues.AutoSize = true;
            this.nameofmaterialvalues.Location = new System.Drawing.Point(13, 14);
            this.nameofmaterialvalues.Name = "label2";
            this.nameofmaterialvalues.Size = new System.Drawing.Size(116, 13);
            this.nameofmaterialvalues.TabIndex = 5;
            this.nameofmaterialvalues.Text = "Назва мат. цінностей";
            // 
            // menuStrip1
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filemenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menuStrip1";
            this.menu.Size = new System.Drawing.Size(56, 24);
            this.menu.TabIndex = 4;
            this.menu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.filemenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.save,
            this.print});
            this.filemenu.Name = "файлToolStripMenuItem";
            this.filemenu.Size = new System.Drawing.Size(48, 20);
            this.filemenu.Text = "Файл";
            // 
            // зберегтиToolStripMenuItem
            // 
            this.save.Name = "зберегтиToolStripMenuItem";
            this.save.Size = new System.Drawing.Size(131, 22);
            this.save.Text = "Зберегти";
            // 
            // друкуватиToolStripMenuItem
            // 
            this.print.Name = "друкуватиToolStripMenuItem";
            this.print.Size = new System.Drawing.Size(131, 22);
            this.print.Text = "Друкувати";
            // 
            // panel1
            // 
            this.searchbynamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbynamelabel.Controls.Add(this.exit);
            this.searchbynamelabel.Controls.Add(this.search);
            this.searchbynamelabel.Controls.Add(this.name);
            this.searchbynamelabel.Controls.Add(this.namelabel);
            this.searchbynamelabel.Controls.Add(this.searchbyname);
            this.searchbynamelabel.Location = new System.Drawing.Point(583, 337);
            this.searchbynamelabel.Name = "panel1";
            this.searchbynamelabel.Size = new System.Drawing.Size(428, 97);
            this.searchbynamelabel.TabIndex = 5;
            // 
            // button6
            // 
            this.exit.Location = new System.Drawing.Point(293, 63);
            this.exit.Name = "button6";
            this.exit.Size = new System.Drawing.Size(91, 23);
            this.exit.TabIndex = 31;
            this.exit.Text = "Вихід";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.search.Location = new System.Drawing.Point(293, 22);
            this.search.Name = "button5";
            this.search.Size = new System.Drawing.Size(91, 23);
            this.search.TabIndex = 27;
            this.search.Text = "Пошук";
            this.search.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.name.Location = new System.Drawing.Point(135, 24);
            this.name.Name = "textBox10";
            this.name.Size = new System.Drawing.Size(138, 20);
            this.name.TabIndex = 27;
            // 
            // label11
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(13, 27);
            this.namelabel.Name = "label11";
            this.namelabel.Size = new System.Drawing.Size(116, 13);
            this.namelabel.TabIndex = 28;
            this.namelabel.Text = "Назва мат. цінностей";
            // 
            // label10
            // 
            this.searchbyname.AutoSize = true;
            this.searchbyname.Location = new System.Drawing.Point(13, 0);
            this.searchbyname.Name = "label10";
            this.searchbyname.Size = new System.Drawing.Size(84, 13);
            this.searchbyname.TabIndex = 27;
            this.searchbyname.Text = "Пошук по назві";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 466);
            this.Controls.Add(this.searchbynamelabel);
            this.Controls.Add(this.statement);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.Text = "Statement of material value";
            ((System.ComponentModel.ISupportInitialize)(this.statement)).EndInit();
            this.inventory.ResumeLayout(false);
            this.inventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberlabel)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.searchbynamelabel.ResumeLayout(false);
            this.searchbynamelabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView statement;
        private System.Windows.Forms.Panel inventory;
        private System.Windows.Forms.NumericUpDown numberlabel;
        private System.Windows.Forms.DateTimePicker dateofdeparturelabel;
        private System.Windows.Forms.DateTimePicker dateofreceiptlabel;
        private System.Windows.Forms.ComboBox placeofstoragelabel;
        private System.Windows.Forms.Label responsibleperson;
        private System.Windows.Forms.TextBox person;
        private System.Windows.Forms.Label placeofstorage;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Label suma;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.TextBox sumalabel;
        private System.Windows.Forms.TextBox pricelabel;
        private System.Windows.Forms.TextBox graduationyearlabel;
        private System.Windows.Forms.Label graduationyear;
        private System.Windows.Forms.Label dateofdeparture;
        private System.Windows.Forms.Label dateofreceipt;
        private System.Windows.Forms.TextBox nameofmaterialvalueslabel;
        private System.Windows.Forms.Label nameofmaterialvalues;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem filemenu;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem print;
        private System.Windows.Forms.Panel searchbynamelabel;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label searchbyname;
        private System.Windows.Forms.Button exit;
    }
}

