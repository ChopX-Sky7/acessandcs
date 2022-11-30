namespace WindowsFormsApp15
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label серия_паспортаLabel;
            System.Windows.Forms.Label номер_паспортаLabel;
            System.Windows.Forms.Label местоLabel;
            System.Windows.Forms.Label код_рейсаLabel;
            System.Windows.Forms.Label ценаLabel;
            this.аэропортDataSet = new WindowsFormsApp15.АэропортDataSet();
            this.билетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.билетыTableAdapter = new WindowsFormsApp15.АэропортDataSetTableAdapters.БилетыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp15.АэропортDataSetTableAdapters.TableAdapterManager();
            this.билетыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.серия_паспортаTextBox = new System.Windows.Forms.TextBox();
            this.номер_паспортаTextBox = new System.Windows.Forms.TextBox();
            this.местоTextBox = new System.Windows.Forms.TextBox();
            this.код_рейсаTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.первая = new System.Windows.Forms.Button();
            this.Последняя = new System.Windows.Forms.Button();
            this.Пред = new System.Windows.Forms.Button();
            this.След = new System.Windows.Forms.Button();
            this.Доб = new System.Windows.Forms.Button();
            this.Удал = new System.Windows.Forms.Button();
            this.Сохр = new System.Windows.Forms.Button();
            имяLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            серия_паспортаLabel = new System.Windows.Forms.Label();
            номер_паспортаLabel = new System.Windows.Forms.Label();
            местоLabel = new System.Windows.Forms.Label();
            код_рейсаLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.аэропортDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетыBindingNavigator)).BeginInit();
            this.билетыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // аэропортDataSet
            // 
            this.аэропортDataSet.DataSetName = "АэропортDataSet";
            this.аэропортDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // билетыBindingSource
            // 
            this.билетыBindingSource.DataMember = "Билеты";
            this.билетыBindingSource.DataSource = this.аэропортDataSet;
            // 
            // билетыTableAdapter
            // 
            this.билетыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp15.АэропортDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БилетыTableAdapter = this.билетыTableAdapter;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.РейсыTableAdapter = null;
            this.tableAdapterManager.СамолетыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Типы_самолетовTableAdapter = null;
            this.tableAdapterManager.ЭкипажиTableAdapter = null;
            // 
            // билетыBindingNavigator
            // 
            this.билетыBindingNavigator.AddNewItem = null;
            this.билетыBindingNavigator.BindingSource = this.билетыBindingSource;
            this.билетыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.билетыBindingNavigator.DeleteItem = null;
            this.билетыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2});
            this.билетыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.билетыBindingNavigator.MoveFirstItem = null;
            this.билетыBindingNavigator.MoveLastItem = null;
            this.билетыBindingNavigator.MoveNextItem = null;
            this.билетыBindingNavigator.MovePreviousItem = null;
            this.билетыBindingNavigator.Name = "билетыBindingNavigator";
            this.билетыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.билетыBindingNavigator.Size = new System.Drawing.Size(499, 25);
            this.билетыBindingNavigator.TabIndex = 0;
            this.билетыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(120, 49);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 1;
            имяLabel.Text = "Имя:";
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетыBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(158, 46);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(100, 20);
            this.имяTextBox.TabIndex = 2;
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(93, 75);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 3;
            фамилияLabel.Text = "Фамилия:";
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетыBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(158, 72);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(100, 20);
            this.фамилияTextBox.TabIndex = 4;
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(95, 101);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(57, 13);
            отчествоLabel.TabIndex = 5;
            отчествоLabel.Text = "Отчество:";
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетыBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(158, 98);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(100, 20);
            this.отчествоTextBox.TabIndex = 6;
            // 
            // серия_паспортаLabel
            // 
            серия_паспортаLabel.AutoSize = true;
            серия_паспортаLabel.Location = new System.Drawing.Point(61, 127);
            серия_паспортаLabel.Name = "серия_паспортаLabel";
            серия_паспортаLabel.Size = new System.Drawing.Size(91, 13);
            серия_паспортаLabel.TabIndex = 7;
            серия_паспортаLabel.Text = "Серия паспорта:";
            // 
            // серия_паспортаTextBox
            // 
            this.серия_паспортаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетыBindingSource, "Серия паспорта", true));
            this.серия_паспортаTextBox.Location = new System.Drawing.Point(158, 124);
            this.серия_паспортаTextBox.Name = "серия_паспортаTextBox";
            this.серия_паспортаTextBox.Size = new System.Drawing.Size(100, 20);
            this.серия_паспортаTextBox.TabIndex = 8;
            // 
            // номер_паспортаLabel
            // 
            номер_паспортаLabel.AutoSize = true;
            номер_паспортаLabel.Location = new System.Drawing.Point(58, 153);
            номер_паспортаLabel.Name = "номер_паспортаLabel";
            номер_паспортаLabel.Size = new System.Drawing.Size(94, 13);
            номер_паспортаLabel.TabIndex = 9;
            номер_паспортаLabel.Text = "Номер паспорта:";
            // 
            // номер_паспортаTextBox
            // 
            this.номер_паспортаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетыBindingSource, "Номер паспорта", true));
            this.номер_паспортаTextBox.Location = new System.Drawing.Point(158, 150);
            this.номер_паспортаTextBox.Name = "номер_паспортаTextBox";
            this.номер_паспортаTextBox.Size = new System.Drawing.Size(100, 20);
            this.номер_паспортаTextBox.TabIndex = 10;
            // 
            // местоLabel
            // 
            местоLabel.AutoSize = true;
            местоLabel.Location = new System.Drawing.Point(110, 179);
            местоLabel.Name = "местоLabel";
            местоLabel.Size = new System.Drawing.Size(42, 13);
            местоLabel.TabIndex = 11;
            местоLabel.Text = "Место:";
            // 
            // местоTextBox
            // 
            this.местоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетыBindingSource, "Место", true));
            this.местоTextBox.Location = new System.Drawing.Point(158, 176);
            this.местоTextBox.Name = "местоTextBox";
            this.местоTextBox.Size = new System.Drawing.Size(100, 20);
            this.местоTextBox.TabIndex = 12;
            // 
            // код_рейсаLabel
            // 
            код_рейсаLabel.AutoSize = true;
            код_рейсаLabel.Location = new System.Drawing.Point(90, 205);
            код_рейсаLabel.Name = "код_рейсаLabel";
            код_рейсаLabel.Size = new System.Drawing.Size(62, 13);
            код_рейсаLabel.TabIndex = 13;
            код_рейсаLabel.Text = "Код рейса:";
            // 
            // код_рейсаTextBox
            // 
            this.код_рейсаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетыBindingSource, "Код рейса", true));
            this.код_рейсаTextBox.Location = new System.Drawing.Point(158, 202);
            this.код_рейсаTextBox.Name = "код_рейсаTextBox";
            this.код_рейсаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_рейсаTextBox.TabIndex = 14;
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(116, 231);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(36, 13);
            ценаLabel.TabIndex = 15;
            ценаLabel.Text = "Цена:";
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетыBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(158, 228);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(100, 20);
            this.ценаTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(303, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Таблица Билеты";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // первая
            // 
            this.первая.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.первая.Location = new System.Drawing.Point(23, 283);
            this.первая.Name = "первая";
            this.первая.Size = new System.Drawing.Size(139, 39);
            this.первая.TabIndex = 18;
            this.первая.Text = "Первая";
            this.первая.UseVisualStyleBackColor = true;
            this.первая.Click += new System.EventHandler(this.button1_Click);
            // 
            // Последняя
            // 
            this.Последняя.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Последняя.Location = new System.Drawing.Point(168, 283);
            this.Последняя.Name = "Последняя";
            this.Последняя.Size = new System.Drawing.Size(139, 39);
            this.Последняя.TabIndex = 19;
            this.Последняя.Text = "Последняя";
            this.Последняя.UseVisualStyleBackColor = true;
            this.Последняя.Click += new System.EventHandler(this.button2_Click);
            // 
            // Пред
            // 
            this.Пред.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Пред.Location = new System.Drawing.Point(23, 328);
            this.Пред.Name = "Пред";
            this.Пред.Size = new System.Drawing.Size(139, 39);
            this.Пред.TabIndex = 20;
            this.Пред.Text = "Предыдущая";
            this.Пред.UseVisualStyleBackColor = true;
            this.Пред.Click += new System.EventHandler(this.button3_Click);
            // 
            // След
            // 
            this.След.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.След.Location = new System.Drawing.Point(168, 328);
            this.След.Name = "След";
            this.След.Size = new System.Drawing.Size(139, 39);
            this.След.TabIndex = 21;
            this.След.Text = "Следующая";
            this.След.UseVisualStyleBackColor = true;
            this.След.Click += new System.EventHandler(this.button4_Click);
            // 
            // Доб
            // 
            this.Доб.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Доб.Location = new System.Drawing.Point(23, 407);
            this.Доб.Name = "Доб";
            this.Доб.Size = new System.Drawing.Size(139, 39);
            this.Доб.TabIndex = 22;
            this.Доб.Text = "Добавить";
            this.Доб.UseVisualStyleBackColor = true;
            this.Доб.Click += new System.EventHandler(this.button5_Click);
            // 
            // Удал
            // 
            this.Удал.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Удал.Location = new System.Drawing.Point(168, 408);
            this.Удал.Name = "Удал";
            this.Удал.Size = new System.Drawing.Size(139, 36);
            this.Удал.TabIndex = 23;
            this.Удал.Text = "Удалить";
            this.Удал.UseVisualStyleBackColor = true;
            this.Удал.Click += new System.EventHandler(this.button6_Click);
            // 
            // Сохр
            // 
            this.Сохр.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Сохр.Location = new System.Drawing.Point(313, 407);
            this.Сохр.Name = "Сохр";
            this.Сохр.Size = new System.Drawing.Size(139, 38);
            this.Сохр.TabIndex = 24;
            this.Сохр.Text = "Сохранить";
            this.Сохр.UseVisualStyleBackColor = true;
            this.Сохр.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 482);
            this.Controls.Add(this.Сохр);
            this.Controls.Add(this.Удал);
            this.Controls.Add(this.Доб);
            this.Controls.Add(this.След);
            this.Controls.Add(this.Пред);
            this.Controls.Add(this.Последняя);
            this.Controls.Add(this.первая);
            this.Controls.Add(this.label1);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(код_рейсаLabel);
            this.Controls.Add(this.код_рейсаTextBox);
            this.Controls.Add(местоLabel);
            this.Controls.Add(this.местоTextBox);
            this.Controls.Add(номер_паспортаLabel);
            this.Controls.Add(this.номер_паспортаTextBox);
            this.Controls.Add(серия_паспортаLabel);
            this.Controls.Add(this.серия_паспортаTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(this.билетыBindingNavigator);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.аэропортDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетыBindingNavigator)).EndInit();
            this.билетыBindingNavigator.ResumeLayout(false);
            this.билетыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private АэропортDataSet аэропортDataSet;
        private System.Windows.Forms.BindingSource билетыBindingSource;
        private АэропортDataSetTableAdapters.БилетыTableAdapter билетыTableAdapter;
        private АэропортDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator билетыBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox серия_паспортаTextBox;
        private System.Windows.Forms.TextBox номер_паспортаTextBox;
        private System.Windows.Forms.TextBox местоTextBox;
        private System.Windows.Forms.TextBox код_рейсаTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button первая;
        private System.Windows.Forms.Button Последняя;
        private System.Windows.Forms.Button Пред;
        private System.Windows.Forms.Button След;
        private System.Windows.Forms.Button Доб;
        private System.Windows.Forms.Button Удал;
        private System.Windows.Forms.Button Сохр;
    }
}