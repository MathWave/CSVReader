namespace CSVReader
{
    partial class Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Table));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.create = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.savein = new System.Windows.Forms.ToolStripMenuItem();
            this.saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.close = new System.Windows.Forms.ToolStripMenuItem();
            this.DispanserToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.change = new System.Windows.Forms.ToolStripMenuItem();
            this.remove = new System.Windows.Forms.ToolStripMenuItem();
            this.отсортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поChiefNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameGrow = new System.Windows.Forms.ToolStripMenuItem();
            this.NameRise = new System.Windows.Forms.ToolStripMenuItem();
            this.поChiefGenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenderGrow = new System.Windows.Forms.ToolStripMenuItem();
            this.GenderRise = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterSame = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterSpecialization = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterChiefPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CreateToolStrip = new System.Windows.Forms.ToolStripButton();
            this.OpenToolStrip = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStrip = new System.Windows.Forms.ToolStripButton();
            this.SaveAsToolStrip = new System.Windows.Forms.ToolStripButton();
            this.SaveInToolStrip = new System.Windows.Forms.ToolStripButton();
            this.CloseToolStrip = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.DispanserToolStrip,
            this.отсортироватьToolStripMenuItem,
            this.фильтрToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1324, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.create,
            this.open,
            this.save,
            this.savein,
            this.saveas,
            this.close});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // create
            // 
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(252, 30);
            this.create.Text = "Создать";
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(252, 30);
            this.open.Text = "Открыть";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(252, 30);
            this.save.Text = "Сохранить";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // savein
            // 
            this.savein.Name = "savein";
            this.savein.Size = new System.Drawing.Size(252, 30);
            this.savein.Text = "Сохранить в...";
            this.savein.Click += new System.EventHandler(this.savein_Click);
            // 
            // saveas
            // 
            this.saveas.Name = "saveas";
            this.saveas.Size = new System.Drawing.Size(252, 30);
            this.saveas.Text = "Сохранить как...";
            this.saveas.Click += new System.EventHandler(this.saveas_Click);
            // 
            // close
            // 
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(252, 30);
            this.close.Text = "Закрыть";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // DispanserToolStrip
            // 
            this.DispanserToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.change,
            this.remove});
            this.DispanserToolStrip.Name = "DispanserToolStrip";
            this.DispanserToolStrip.Size = new System.Drawing.Size(111, 29);
            this.DispanserToolStrip.Text = "Диспансер";
            // 
            // add
            // 
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(175, 30);
            this.add.Text = "Добавить";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // change
            // 
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(175, 30);
            this.change.Text = "Изменить";
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // remove
            // 
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(175, 30);
            this.remove.Text = "Удалить";
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // отсортироватьToolStripMenuItem
            // 
            this.отсортироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поChiefNameToolStripMenuItem,
            this.поChiefGenderToolStripMenuItem});
            this.отсортироватьToolStripMenuItem.Name = "отсортироватьToolStripMenuItem";
            this.отсортироватьToolStripMenuItem.Size = new System.Drawing.Size(149, 29);
            this.отсортироватьToolStripMenuItem.Text = "Отсортировать";
            // 
            // поChiefNameToolStripMenuItem
            // 
            this.поChiefNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NameGrow,
            this.NameRise});
            this.поChiefNameToolStripMenuItem.Name = "поChiefNameToolStripMenuItem";
            this.поChiefNameToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.поChiefNameToolStripMenuItem.Text = "По ChiefName";
            // 
            // NameGrow
            // 
            this.NameGrow.Name = "NameGrow";
            this.NameGrow.Size = new System.Drawing.Size(233, 30);
            this.NameGrow.Text = "По возрастанию";
            this.NameGrow.Click += new System.EventHandler(this.NameGrow_Click);
            // 
            // NameRise
            // 
            this.NameRise.Name = "NameRise";
            this.NameRise.Size = new System.Drawing.Size(233, 30);
            this.NameRise.Text = "По убыванию";
            this.NameRise.Click += new System.EventHandler(this.NameRise_Click);
            // 
            // поChiefGenderToolStripMenuItem
            // 
            this.поChiefGenderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenderGrow,
            this.GenderRise});
            this.поChiefGenderToolStripMenuItem.Name = "поChiefGenderToolStripMenuItem";
            this.поChiefGenderToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.поChiefGenderToolStripMenuItem.Text = "По ChiefGender";
            // 
            // GenderGrow
            // 
            this.GenderGrow.Name = "GenderGrow";
            this.GenderGrow.Size = new System.Drawing.Size(233, 30);
            this.GenderGrow.Text = "По возрастанию";
            this.GenderGrow.Click += new System.EventHandler(this.GenderGrow_Click);
            // 
            // GenderRise
            // 
            this.GenderRise.Name = "GenderRise";
            this.GenderRise.Size = new System.Drawing.Size(233, 30);
            this.GenderRise.Text = "По убыванию";
            this.GenderRise.Click += new System.EventHandler(this.GenderRise_Click);
            // 
            // фильтрToolStripMenuItem
            // 
            this.фильтрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterSame,
            this.FilterSpecialization,
            this.FilterChiefPosition});
            this.фильтрToolStripMenuItem.Name = "фильтрToolStripMenuItem";
            this.фильтрToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.фильтрToolStripMenuItem.Text = "Фильтр";
            // 
            // FilterSame
            // 
            this.FilterSame.Name = "FilterSame";
            this.FilterSame.Size = new System.Drawing.Size(350, 30);
            this.FilterSame.Text = "Совпадение по специализации";
            this.FilterSame.Click += new System.EventHandler(this.FilterSame_Click);
            // 
            // FilterSpecialization
            // 
            this.FilterSpecialization.Name = "FilterSpecialization";
            this.FilterSpecialization.Size = new System.Drawing.Size(350, 30);
            this.FilterSpecialization.Text = "Specialization";
            this.FilterSpecialization.Click += new System.EventHandler(this.FilterSpecialization_Click);
            // 
            // FilterChiefPosition
            // 
            this.FilterChiefPosition.Name = "FilterChiefPosition";
            this.FilterChiefPosition.Size = new System.Drawing.Size(350, 30);
            this.FilterChiefPosition.Text = "ChiefPosition";
            this.FilterChiefPosition.Click += new System.EventHandler(this.FilterChiefPosition_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1300, 583);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1149, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сбросить фильтр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStrip,
            this.OpenToolStrip,
            this.SaveToolStrip,
            this.SaveAsToolStrip,
            this.SaveInToolStrip,
            this.CloseToolStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1324, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CreateToolStrip
            // 
            this.CreateToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("CreateToolStrip.Image")));
            this.CreateToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateToolStrip.Name = "CreateToolStrip";
            this.CreateToolStrip.Size = new System.Drawing.Size(28, 28);
            this.CreateToolStrip.Text = "&Создать";
            this.CreateToolStrip.Click += new System.EventHandler(this.create_Click);
            // 
            // OpenToolStrip
            // 
            this.OpenToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStrip.Image")));
            this.OpenToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStrip.Name = "OpenToolStrip";
            this.OpenToolStrip.Size = new System.Drawing.Size(28, 28);
            this.OpenToolStrip.Text = "&Открыть";
            this.OpenToolStrip.Click += new System.EventHandler(this.open_Click);
            // 
            // SaveToolStrip
            // 
            this.SaveToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStrip.Image")));
            this.SaveToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStrip.Name = "SaveToolStrip";
            this.SaveToolStrip.Size = new System.Drawing.Size(28, 28);
            this.SaveToolStrip.Text = "&Сохранить";
            this.SaveToolStrip.Click += new System.EventHandler(this.save_Click);
            // 
            // SaveAsToolStrip
            // 
            this.SaveAsToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAsToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsToolStrip.Image")));
            this.SaveAsToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAsToolStrip.Name = "SaveAsToolStrip";
            this.SaveAsToolStrip.Size = new System.Drawing.Size(28, 28);
            this.SaveAsToolStrip.Text = "Сохранить как...";
            this.SaveAsToolStrip.Click += new System.EventHandler(this.saveas_Click);
            // 
            // SaveInToolStrip
            // 
            this.SaveInToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveInToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("SaveInToolStrip.Image")));
            this.SaveInToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveInToolStrip.Name = "SaveInToolStrip";
            this.SaveInToolStrip.Size = new System.Drawing.Size(28, 28);
            this.SaveInToolStrip.Text = "Сохранить в...";
            this.SaveInToolStrip.Click += new System.EventHandler(this.savein_Click);
            // 
            // CloseToolStrip
            // 
            this.CloseToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("CloseToolStrip.Image")));
            this.CloseToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseToolStrip.Name = "CloseToolStrip";
            this.CloseToolStrip.Size = new System.Drawing.Size(28, 28);
            this.CloseToolStrip.Text = "Закрыть";
            this.CloseToolStrip.Click += new System.EventHandler(this.close_Click);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 679);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Table";
            this.Text = "CSVReader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem create;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem saveas;
        private System.Windows.Forms.ToolStripMenuItem close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem DispanserToolStrip;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem remove;
        private System.Windows.Forms.ToolStripMenuItem change;
        private System.Windows.Forms.ToolStripMenuItem отсортироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поChiefNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NameGrow;
        private System.Windows.Forms.ToolStripMenuItem NameRise;
        private System.Windows.Forms.ToolStripMenuItem поChiefGenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GenderGrow;
        private System.Windows.Forms.ToolStripMenuItem GenderRise;
        private System.Windows.Forms.ToolStripMenuItem фильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilterSame;
        private System.Windows.Forms.ToolStripMenuItem FilterSpecialization;
        private System.Windows.Forms.ToolStripMenuItem FilterChiefPosition;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton CreateToolStrip;
        private System.Windows.Forms.ToolStripButton OpenToolStrip;
        private System.Windows.Forms.ToolStripButton SaveToolStrip;
        private System.Windows.Forms.ToolStripButton SaveAsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem savein;
        private System.Windows.Forms.ToolStripButton SaveInToolStrip;
        private System.Windows.Forms.ToolStripButton CloseToolStrip;
    }
}

