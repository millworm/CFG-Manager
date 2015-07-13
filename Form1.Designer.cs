namespace CFG_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbteam = new System.Windows.Forms.ComboBox();
            this.lbplayers = new System.Windows.Forms.ListBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btninstall = new System.Windows.Forms.Button();
            this.btnrem = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задатьПутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверитьОбновленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сайтПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.перейтиНаСайтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиВГруппуВКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.notifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbteam
            // 
            this.cbteam.BackColor = System.Drawing.Color.AliceBlue;
            this.cbteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbteam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbteam.FormattingEnabled = true;
            this.cbteam.Items.AddRange(new object[] {
            "Загрузка"});
            this.cbteam.Location = new System.Drawing.Point(191, 27);
            this.cbteam.Margin = new System.Windows.Forms.Padding(5);
            this.cbteam.Name = "cbteam";
            this.cbteam.Size = new System.Drawing.Size(225, 23);
            this.cbteam.Sorted = true;
            this.cbteam.TabIndex = 1;
            this.cbteam.SelectedIndexChanged += new System.EventHandler(this.cbteam_SelectedIndexChanged_1);
            this.cbteam.SelectionChangeCommitted += new System.EventHandler(this.cbteam_SelectedIndexChanged);
            // 
            // lbplayers
            // 
            this.lbplayers.BackColor = System.Drawing.Color.AliceBlue;
            this.lbplayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbplayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbplayers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbplayers.FormattingEnabled = true;
            this.lbplayers.ItemHeight = 17;
            this.lbplayers.Location = new System.Drawing.Point(352, 204);
            this.lbplayers.Margin = new System.Windows.Forms.Padding(5);
            this.lbplayers.Name = "lbplayers";
            this.lbplayers.Size = new System.Drawing.Size(225, 85);
            this.lbplayers.Sorted = true;
            this.lbplayers.TabIndex = 2;
            this.lbplayers.SelectedIndexChanged += new System.EventHandler(this.lbplayers_SelectedIndexChanged);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.AliceBlue;
            this.btnback.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnback.FlatAppearance.BorderSize = 10;
            this.btnback.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnback.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnback.Location = new System.Drawing.Point(19, 42);
            this.btnback.Margin = new System.Windows.Forms.Padding(10);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(138, 55);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "Сделать бекап";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btninstall
            // 
            this.btninstall.BackColor = System.Drawing.Color.AliceBlue;
            this.btninstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btninstall.Enabled = false;
            this.btninstall.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btninstall.FlatAppearance.BorderSize = 10;
            this.btninstall.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btninstall.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btninstall.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btninstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btninstall.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btninstall.Location = new System.Drawing.Point(19, 204);
            this.btninstall.Margin = new System.Windows.Forms.Padding(10);
            this.btninstall.Name = "btninstall";
            this.btninstall.Size = new System.Drawing.Size(232, 85);
            this.btninstall.TabIndex = 5;
            this.btninstall.Text = "Установить";
            this.btninstall.UseVisualStyleBackColor = false;
            this.btninstall.Click += new System.EventHandler(this.btninstall_Click);
            // 
            // btnrem
            // 
            this.btnrem.BackColor = System.Drawing.Color.AliceBlue;
            this.btnrem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnrem.FlatAppearance.BorderSize = 10;
            this.btnrem.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnrem.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnrem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnrem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnrem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnrem.Location = new System.Drawing.Point(439, 42);
            this.btnrem.Margin = new System.Windows.Forms.Padding(10);
            this.btnrem.Name = "btnrem";
            this.btnrem.Size = new System.Drawing.Size(138, 55);
            this.btnrem.TabIndex = 6;
            this.btnrem.Text = "Восстановить";
            this.btnrem.UseVisualStyleBackColor = false;
            this.btnrem.Click += new System.EventHandler(this.btnrem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задатьПутьToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.ShowShortcutKeys = false;
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // задатьПутьToolStripMenuItem
            // 
            this.задатьПутьToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.задатьПутьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.задатьПутьToolStripMenuItem.Name = "задатьПутьToolStripMenuItem";
            this.задатьПутьToolStripMenuItem.ShowShortcutKeys = false;
            this.задатьПутьToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.задатьПутьToolStripMenuItem.Text = "Задать путь";
            this.задатьПутьToolStripMenuItem.Click += new System.EventHandler(this.задатьПутьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.оПрограммеToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проверитьОбновленияToolStripMenuItem,
            this.сайтПрограммыToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShowShortcutKeys = false;
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // проверитьОбновленияToolStripMenuItem
            // 
            this.проверитьОбновленияToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.проверитьОбновленияToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.проверитьОбновленияToolStripMenuItem.Name = "проверитьОбновленияToolStripMenuItem";
            this.проверитьОбновленияToolStripMenuItem.ShowShortcutKeys = false;
            this.проверитьОбновленияToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.проверитьОбновленияToolStripMenuItem.Text = "Проверить обновления";
            this.проверитьОбновленияToolStripMenuItem.Click += new System.EventHandler(this.проверитьОбновленияToolStripMenuItem_Click);
            // 
            // сайтПрограммыToolStripMenuItem
            // 
            this.сайтПрограммыToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.сайтПрограммыToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.сайтПрограммыToolStripMenuItem.Name = "сайтПрограммыToolStripMenuItem";
            this.сайтПрограммыToolStripMenuItem.ShowShortcutKeys = false;
            this.сайтПрограммыToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.сайтПрограммыToolStripMenuItem.Text = "Сайт программы";
            this.сайтПрограммыToolStripMenuItem.Click += new System.EventHandler(this.сайтПрограммыToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.notifyMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "CFG Manager";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // notifyMenu
            // 
            this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перейтиНаСайтToolStripMenuItem,
            this.перейтиВГруппуВКToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.notifyMenu.Name = "notifyMenu";
            this.notifyMenu.Size = new System.Drawing.Size(189, 70);
            // 
            // перейтиНаСайтToolStripMenuItem
            // 
            this.перейтиНаСайтToolStripMenuItem.Name = "перейтиНаСайтToolStripMenuItem";
            this.перейтиНаСайтToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.перейтиНаСайтToolStripMenuItem.Text = "Перейти на сайт";
            this.перейтиНаСайтToolStripMenuItem.Click += new System.EventHandler(this.перейтиНаСайтToolStripMenuItem_Click);
            // 
            // перейтиВГруппуВКToolStripMenuItem
            // 
            this.перейтиВГруппуВКToolStripMenuItem.Name = "перейтиВГруппуВКToolStripMenuItem";
            this.перейтиВГруппуВКToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.перейтиВГруппуВКToolStripMenuItem.Text = "Перейти в группу ВК";
            this.перейтиВГруппуВКToolStripMenuItem.Click += new System.EventHandler(this.перейтиВГруппуВКToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 308);
            this.Controls.Add(this.btnrem);
            this.Controls.Add(this.btninstall);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lbplayers);
            this.Controls.Add(this.cbteam);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.notifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbteam;
        private System.Windows.Forms.ListBox lbplayers;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btninstall;
        private System.Windows.Forms.Button btnrem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задатьПутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверитьОбновленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сайтПрограммыToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip notifyMenu;
        private System.Windows.Forms.ToolStripMenuItem перейтиНаСайтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перейтиВГруппуВКToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

