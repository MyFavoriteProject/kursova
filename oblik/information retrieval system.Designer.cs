using oblik.Domain.Services;

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
            this.countLabel = new System.Windows.Forms.NumericUpDown();
            this.removeDateLabel = new System.Windows.Forms.DateTimePicker();
            this.dateReceiptLabel = new System.Windows.Forms.DateTimePicker();
            this.placeStorageLabel = new System.Windows.Forms.ComboBox();
            this.responsibleperson = new System.Windows.Forms.Label();
            this.responsiblePersonTextBlock = new System.Windows.Forms.TextBox();
            this.placeofstorage = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.TextBox();
            this.yearIssueLabel = new System.Windows.Forms.TextBox();
            this.graduationyear = new System.Windows.Forms.Label();
            this.dateofdeparture = new System.Windows.Forms.Label();
            this.dateofreceipt = new System.Windows.Forms.Label();
            this.nameMaterialValuesLabel = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.countLabel)).BeginInit();
            this.menu.SuspendLayout();
            this.searchbynamelabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statement
            // 
            this.statement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statement.Location = new System.Drawing.Point(12, 35);
            this.statement.Name = "statement";
            this.statement.Size = new System.Drawing.Size(565, 127);
            this.statement.TabIndex = 1;
            // 
            // inventory
            // 
            this.inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inventory.Controls.Add(this.countLabel);
            this.inventory.Controls.Add(this.removeDateLabel);
            this.inventory.Controls.Add(this.dateReceiptLabel);
            this.inventory.Controls.Add(this.placeStorageLabel);
            this.inventory.Controls.Add(this.responsibleperson);
            this.inventory.Controls.Add(this.responsiblePersonTextBlock);
            this.inventory.Controls.Add(this.placeofstorage);
            this.inventory.Controls.Add(this.edit);
            this.inventory.Controls.Add(this.delete);
            this.inventory.Controls.Add(this.add);
            this.inventory.Controls.Add(this.open);
            this.inventory.Controls.Add(this.suma);
            this.inventory.Controls.Add(this.price);
            this.inventory.Controls.Add(this.number);
            this.inventory.Controls.Add(this.sumLabel);
            this.inventory.Controls.Add(this.priceLabel);
            this.inventory.Controls.Add(this.yearIssueLabel);
            this.inventory.Controls.Add(this.graduationyear);
            this.inventory.Controls.Add(this.dateofdeparture);
            this.inventory.Controls.Add(this.dateofreceipt);
            this.inventory.Controls.Add(this.nameMaterialValuesLabel);
            this.inventory.Controls.Add(this.nameofmaterialvalues);
            this.inventory.Location = new System.Drawing.Point(583, 35);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(428, 296);
            this.inventory.TabIndex = 3;
            // 
            // numberlabel
            // 
            this.countLabel.Location = new System.Drawing.Point(135, 113);
            this.countLabel.Name = "numberlabel";
            this.countLabel.Size = new System.Drawing.Size(91, 20);
            this.countLabel.TabIndex = 6;
            // 
            // dateofdeparturelabel
            // 
            this.removeDateLabel.Location = new System.Drawing.Point(135, 63);
            this.removeDateLabel.Name = "dateofdeparturelabel";
            this.removeDateLabel.Size = new System.Drawing.Size(91, 20);
            this.removeDateLabel.TabIndex = 30;
            // 
            // dateofreceiptlabel
            // 
            this.dateReceiptLabel.Location = new System.Drawing.Point(135, 37);
            this.dateReceiptLabel.Name = "dateofreceiptlabel";
            this.dateReceiptLabel.Size = new System.Drawing.Size(91, 20);
            this.dateReceiptLabel.TabIndex = 6;
            // 
            // placeofstoragelabel
            // 
            this.placeStorageLabel.FormattingEnabled = true;
            this.placeStorageLabel.Items.AddRange(new object[] {
            "Склад 1",
            "Склад 2"});
            this.placeStorageLabel.Location = new System.Drawing.Point(135, 192);
            this.placeStorageLabel.Name = "placeofstoragelabel";
            this.placeStorageLabel.Size = new System.Drawing.Size(91, 21);
            this.placeStorageLabel.TabIndex = 6;
            // 
            // responsibleperson
            // 
            this.responsibleperson.AutoSize = true;
            this.responsibleperson.Location = new System.Drawing.Point(13, 222);
            this.responsibleperson.Name = "responsibleperson";
            this.responsibleperson.Size = new System.Drawing.Size(111, 13);
            this.responsibleperson.TabIndex = 26;
            this.responsibleperson.Text = "Відповідальна особа";
            // 
            // person
            // 
            this.responsiblePersonTextBlock.Location = new System.Drawing.Point(135, 219);
            this.responsiblePersonTextBlock.Name = "person";
            this.responsiblePersonTextBlock.Size = new System.Drawing.Size(91, 20);
            this.responsiblePersonTextBlock.TabIndex = 25;
            // 
            // placeofstorage
            // 
            this.placeofstorage.AutoSize = true;
            this.placeofstorage.Location = new System.Drawing.Point(13, 196);
            this.placeofstorage.Name = "placeofstorage";
            this.placeofstorage.Size = new System.Drawing.Size(94, 13);
            this.placeofstorage.TabIndex = 24;
            this.placeofstorage.Text = "Місце зберігання";
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(135, 262);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(91, 23);
            this.edit.TabIndex = 22;
            this.edit.Text = "Змінити";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(251, 262);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(91, 23);
            this.delete.TabIndex = 21;
            this.delete.Text = "Видалити";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(16, 262);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(91, 23);
            this.add.TabIndex = 20;
            this.add.Text = "Добавити";
            this.add.UseVisualStyleBackColor = true;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(251, 217);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(91, 23);
            this.open.TabIndex = 19;
            this.open.Text = "Відкрити";
            this.open.UseVisualStyleBackColor = true;
            // 
            // suma
            // 
            this.suma.AutoSize = true;
            this.suma.Location = new System.Drawing.Point(13, 167);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(33, 13);
            this.suma.TabIndex = 18;
            this.suma.Text = "Сума";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(13, 141);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(29, 13);
            this.price.TabIndex = 17;
            this.price.Text = "Ціна";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(13, 115);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(53, 13);
            this.number.TabIndex = 16;
            this.number.Text = "Кількість";
            // 
            // sumalabel
            // 
            this.sumLabel.Location = new System.Drawing.Point(135, 167);
            this.sumLabel.Name = "sumalabel";
            this.sumLabel.Size = new System.Drawing.Size(91, 20);
            this.sumLabel.TabIndex = 15;
            // 
            // pricelabel
            // 
            this.priceLabel.Location = new System.Drawing.Point(135, 141);
            this.priceLabel.Name = "pricelabel";
            this.priceLabel.Size = new System.Drawing.Size(91, 20);
            this.priceLabel.TabIndex = 14;
            // 
            // graduationyearlabel
            // 
            this.yearIssueLabel.Location = new System.Drawing.Point(135, 89);
            this.yearIssueLabel.Name = "graduationyearlabel";
            this.yearIssueLabel.Size = new System.Drawing.Size(91, 20);
            this.yearIssueLabel.TabIndex = 12;
            // 
            // graduationyear
            // 
            this.graduationyear.AutoSize = true;
            this.graduationyear.Location = new System.Drawing.Point(13, 92);
            this.graduationyear.Name = "graduationyear";
            this.graduationyear.Size = new System.Drawing.Size(65, 13);
            this.graduationyear.TabIndex = 11;
            this.graduationyear.Text = "Рік випуску";
            // 
            // dateofdeparture
            // 
            this.dateofdeparture.AutoSize = true;
            this.dateofdeparture.Location = new System.Drawing.Point(13, 66);
            this.dateofdeparture.Name = "dateofdeparture";
            this.dateofdeparture.Size = new System.Drawing.Size(75, 13);
            this.dateofdeparture.TabIndex = 9;
            this.dateofdeparture.Text = "Дата вибуття";
            // 
            // dateofreceipt
            // 
            this.dateofreceipt.AutoSize = true;
            this.dateofreceipt.Location = new System.Drawing.Point(13, 37);
            this.dateofreceipt.Name = "dateofreceipt";
            this.dateofreceipt.Size = new System.Drawing.Size(103, 13);
            this.dateofreceipt.TabIndex = 7;
            this.dateofreceipt.Text = "Дата надходження";
            // 
            // nameofmaterialvalueslabel
            // 
            this.nameMaterialValuesLabel.Location = new System.Drawing.Point(135, 11);
            this.nameMaterialValuesLabel.Name = "nameofmaterialvalueslabel";
            this.nameMaterialValuesLabel.Size = new System.Drawing.Size(91, 20);
            this.nameMaterialValuesLabel.TabIndex = 6;
            // 
            // nameofmaterialvalues
            // 
            this.nameofmaterialvalues.AutoSize = true;
            this.nameofmaterialvalues.Location = new System.Drawing.Point(13, 14);
            this.nameofmaterialvalues.Name = "nameofmaterialvalues";
            this.nameofmaterialvalues.Size = new System.Drawing.Size(116, 13);
            this.nameofmaterialvalues.TabIndex = 5;
            this.nameofmaterialvalues.Text = "Назва мат. цінностей";
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filemenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(56, 24);
            this.menu.TabIndex = 4;
            this.menu.Text = "menuStrip1";
            // 
            // filemenu
            // 
            this.filemenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.save,
            this.print});
            this.filemenu.Name = "filemenu";
            this.filemenu.Size = new System.Drawing.Size(48, 20);
            this.filemenu.Text = "Файл";
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(131, 22);
            this.save.Text = "Зберегти";
            // 
            // print
            // 
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(131, 22);
            this.print.Text = "Друкувати";
            // 
            // searchbynamelabel
            // 
            this.searchbynamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbynamelabel.Controls.Add(this.exit);
            this.searchbynamelabel.Controls.Add(this.search);
            this.searchbynamelabel.Controls.Add(this.name);
            this.searchbynamelabel.Controls.Add(this.namelabel);
            this.searchbynamelabel.Controls.Add(this.searchbyname);
            this.searchbynamelabel.Location = new System.Drawing.Point(583, 337);
            this.searchbynamelabel.Name = "searchbynamelabel";
            this.searchbynamelabel.Size = new System.Drawing.Size(428, 97);
            this.searchbynamelabel.TabIndex = 5;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(293, 63);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(91, 23);
            this.exit.TabIndex = 31;
            this.exit.Text = "Вихід";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(293, 22);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(91, 23);
            this.search.TabIndex = 27;
            this.search.Text = "Пошук";
            this.search.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(135, 24);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(138, 20);
            this.name.TabIndex = 27;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(13, 27);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(116, 13);
            this.namelabel.TabIndex = 28;
            this.namelabel.Text = "Назва мат. цінностей";
            // 
            // searchbyname
            // 
            this.searchbyname.AutoSize = true;
            this.searchbyname.Location = new System.Drawing.Point(13, 0);
            this.searchbyname.Name = "searchbyname";
            this.searchbyname.Size = new System.Drawing.Size(84, 13);
            this.searchbyname.TabIndex = 27;
            this.searchbyname.Text = "Пошук по назві";
            // 
            // Statementofmaterialvalue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 466);
            this.Controls.Add(this.searchbynamelabel);
            this.Controls.Add(this.statement);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.menu);
            this.Name = "Statementofmaterialvalue";
            this.Text = "Statement of material value";
            ((System.ComponentModel.ISupportInitialize)(this.statement)).EndInit();
            this.inventory.ResumeLayout(false);
            this.inventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countLabel)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.searchbynamelabel.ResumeLayout(false);
            this.searchbynamelabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Exit_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Search_Click(object sender, System.EventArgs e)
        {
            StatementOfMaterialValueService.Instance.SearchMaterialValues();
        }

        private void Open_Click(object sender, System.EventArgs e)
        {
            StatementOfMaterialValueService.Instance.OpenFile();
        }

        private void Add_Click(object sender, System.EventArgs e)
        {
            StatementOfMaterialValueService.Instance.AddNewMaterialValues();
        }

        private void Delete_Click(object sender, System.EventArgs e)
        {
            StatementOfMaterialValueService.Instance.DeleteMaterialValues();
        }

        private void Edit_Click(object sender, System.EventArgs e)
        {
            StatementOfMaterialValueService.Instance.EditMaterialValues(nameMaterialValuesLabel.Text, dateReceiptLabel.Value, removeDateLabel.Value, yearIssueLabel.Text, countLabel.Value, priceLabel.Text, placeStorageLabel.Text, responsiblePersonTextBlock.Text);
        }

        #endregion
        private System.Windows.Forms.DataGridView statement;
        private System.Windows.Forms.Panel inventory;
        private System.Windows.Forms.NumericUpDown countLabel;
        private System.Windows.Forms.DateTimePicker removeDateLabel;
        private System.Windows.Forms.DateTimePicker dateReceiptLabel;
        private System.Windows.Forms.ComboBox placeStorageLabel;
        private System.Windows.Forms.Label responsibleperson;
        private System.Windows.Forms.TextBox responsiblePersonTextBlock;
        private System.Windows.Forms.Label placeofstorage;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Label suma;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.TextBox sumLabel;
        private System.Windows.Forms.TextBox priceLabel;
        private System.Windows.Forms.TextBox yearIssueLabel;
        private System.Windows.Forms.Label graduationyear;
        private System.Windows.Forms.Label dateofdeparture;
        private System.Windows.Forms.Label dateofreceipt;
        private System.Windows.Forms.TextBox nameMaterialValuesLabel;
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

