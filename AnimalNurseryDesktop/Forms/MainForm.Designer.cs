﻿namespace AnimalNurseryDesktop
{
    partial class MainForm
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
            this.listViewAnimals = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCommand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBirhday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLoadAnimals = new System.Windows.Forms.Button();
            this.buttonAddAnimal = new System.Windows.Forms.Button();
            this.buttonUpdateAnimal = new System.Windows.Forms.Button();
            this.buttonDeleteAnimal = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewAnimals
            // 
            this.listViewAnimals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAnimals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderType,
            this.columnHeaderCommand,
            this.columnHeaderBirhday});
            this.listViewAnimals.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewAnimals.FullRowSelect = true;
            this.listViewAnimals.HideSelection = false;
            this.listViewAnimals.Location = new System.Drawing.Point(12, 12);
            this.listViewAnimals.Name = "listViewAnimals";
            this.listViewAnimals.Size = new System.Drawing.Size(965, 368);
            this.listViewAnimals.TabIndex = 0;
            this.listViewAnimals.UseCompatibleStateImageBehavior = false;
            this.listViewAnimals.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Имя";
            this.columnHeaderName.Width = 200;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Вид";
            this.columnHeaderType.Width = 200;
            // 
            // columnHeaderCommand
            // 
            this.columnHeaderCommand.Text = "Команды";
            this.columnHeaderCommand.Width = 400;
            // 
            // columnHeaderBirhday
            // 
            this.columnHeaderBirhday.Text = "День Рождение";
            this.columnHeaderBirhday.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddCommands,
            this.toolStripMenuItemUpdate,
            this.toolStripMenuItemDeleteAnimal});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 70);
            this.contextMenuStrip1.Text = "1";
            // 
            // toolStripMenuItemAddCommands
            // 
            this.toolStripMenuItemAddCommands.Name = "toolStripMenuItemAddCommands";
            this.toolStripMenuItemAddCommands.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItemAddCommands.Text = "Добавить команду";
            this.toolStripMenuItemAddCommands.Click += new System.EventHandler(this.toolStripMenuItemAddCommands_Click);
            // 
            // toolStripMenuItemUpdate
            // 
            this.toolStripMenuItemUpdate.Name = "toolStripMenuItemUpdate";
            this.toolStripMenuItemUpdate.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItemUpdate.Text = "Изменить животное";
            this.toolStripMenuItemUpdate.Click += new System.EventHandler(this.toolStripMenuItemUpdate_Click);
            // 
            // toolStripMenuItemDeleteAnimal
            // 
            this.toolStripMenuItemDeleteAnimal.Name = "toolStripMenuItemDeleteAnimal";
            this.toolStripMenuItemDeleteAnimal.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItemDeleteAnimal.Text = "Удалить животное";
            this.toolStripMenuItemDeleteAnimal.Click += new System.EventHandler(this.toolStripMenuItemDeleteAnimal_Click);
            // 
            // buttonLoadAnimals
            // 
            this.buttonLoadAnimals.Location = new System.Drawing.Point(12, 406);
            this.buttonLoadAnimals.Name = "buttonLoadAnimals";
            this.buttonLoadAnimals.Size = new System.Drawing.Size(104, 32);
            this.buttonLoadAnimals.TabIndex = 1;
            this.buttonLoadAnimals.Text = "Загрузить всех";
            this.buttonLoadAnimals.UseVisualStyleBackColor = true;
            this.buttonLoadAnimals.Click += new System.EventHandler(this.buttonLoadAnimals_Click);
            // 
            // buttonAddAnimal
            // 
            this.buttonAddAnimal.Location = new System.Drawing.Point(145, 406);
            this.buttonAddAnimal.Name = "buttonAddAnimal";
            this.buttonAddAnimal.Size = new System.Drawing.Size(126, 32);
            this.buttonAddAnimal.TabIndex = 2;
            this.buttonAddAnimal.Text = "Добавить животное";
            this.buttonAddAnimal.UseVisualStyleBackColor = true;
            this.buttonAddAnimal.Click += new System.EventHandler(this.buttonAddAnimal_Click);
            // 
            // buttonUpdateAnimal
            // 
            this.buttonUpdateAnimal.Location = new System.Drawing.Point(299, 406);
            this.buttonUpdateAnimal.Name = "buttonUpdateAnimal";
            this.buttonUpdateAnimal.Size = new System.Drawing.Size(126, 32);
            this.buttonUpdateAnimal.TabIndex = 4;
            this.buttonUpdateAnimal.Text = "Изменить животное";
            this.buttonUpdateAnimal.UseVisualStyleBackColor = true;
            this.buttonUpdateAnimal.Click += new System.EventHandler(this.buttonUpdateAnimal_Click);
            // 
            // buttonDeleteAnimal
            // 
            this.buttonDeleteAnimal.Location = new System.Drawing.Point(455, 406);
            this.buttonDeleteAnimal.Name = "buttonDeleteAnimal";
            this.buttonDeleteAnimal.Size = new System.Drawing.Size(126, 32);
            this.buttonDeleteAnimal.TabIndex = 5;
            this.buttonDeleteAnimal.Text = "Удалить животное";
            this.buttonDeleteAnimal.UseVisualStyleBackColor = true;
            this.buttonDeleteAnimal.Click += new System.EventHandler(this.buttonDeleteAnimal_Click);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 5000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.buttonDeleteAnimal);
            this.Controls.Add(this.buttonUpdateAnimal);
            this.Controls.Add(this.buttonAddAnimal);
            this.Controls.Add(this.buttonLoadAnimals);
            this.Controls.Add(this.listViewAnimals);
            this.Name = "MainForm";
            this.Text = "Мой приют";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAnimals;
        private System.Windows.Forms.Button buttonLoadAnimals;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderCommand;
        private System.Windows.Forms.ColumnHeader columnHeaderBirhday;
        private System.Windows.Forms.Button buttonAddAnimal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddCommands;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpdate;
        private System.Windows.Forms.Button buttonUpdateAnimal;
        private System.Windows.Forms.Button buttonDeleteAnimal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteAnimal;
        private System.Windows.Forms.Timer timerUpdate;
    }
}

