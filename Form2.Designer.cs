namespace WindowsFormsApp15
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label маркаLabel;
            System.Windows.Forms.Label вместимостьLabel;
            System.Windows.Forms.Label грузоподъемностьLabel;
            System.Windows.Forms.Label код_типаLabel;
            System.Windows.Forms.Label тТХLabel;
            System.Windows.Forms.Label дата_выпускаLabel;
            System.Windows.Forms.Label налетLabel;
            System.Windows.Forms.Label дата_последнего_ремонтаLabel;
            System.Windows.Forms.Label код_сотрудникаLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.аэропортDataSet = new WindowsFormsApp15.АэропортDataSet();
            this.самолетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.самолетыTableAdapter = new WindowsFormsApp15.АэропортDataSetTableAdapters.СамолетыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp15.АэропортDataSetTableAdapters.TableAdapterManager();
            this.самолетыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.самолетыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.маркаTextBox = new System.Windows.Forms.TextBox();
            this.вместимостьTextBox = new System.Windows.Forms.TextBox();
            this.грузоподъемностьTextBox = new System.Windows.Forms.TextBox();
            this.код_типаTextBox = new System.Windows.Forms.TextBox();
            this.тТХTextBox = new System.Windows.Forms.TextBox();
            this.дата_выпускаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.налетTextBox = new System.Windows.Forms.TextBox();
            this.дата_последнего_ремонтаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            маркаLabel = new System.Windows.Forms.Label();
            вместимостьLabel = new System.Windows.Forms.Label();
            грузоподъемностьLabel = new System.Windows.Forms.Label();
            код_типаLabel = new System.Windows.Forms.Label();
            тТХLabel = new System.Windows.Forms.Label();
            дата_выпускаLabel = new System.Windows.Forms.Label();
            налетLabel = new System.Windows.Forms.Label();
            дата_последнего_ремонтаLabel = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.аэропортDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingNavigator)).BeginInit();
            this.самолетыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(157, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица Самолеты";
            // 
            // аэропортDataSet
            // 
            this.аэропортDataSet.DataSetName = "АэропортDataSet";
            this.аэропортDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // самолетыBindingSource
            // 
            this.самолетыBindingSource.DataMember = "Самолеты";
            this.самолетыBindingSource.DataSource = this.аэропортDataSet;
            // 
            // самолетыTableAdapter
            // 
            this.самолетыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp15.АэропортDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БилетыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.РейсыTableAdapter = null;
            this.tableAdapterManager.СамолетыTableAdapter = this.самолетыTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Типы_самолетовTableAdapter = null;
            this.tableAdapterManager.ЭкипажиTableAdapter = null;
            // 
            // самолетыBindingNavigator
            // 
            this.самолетыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.самолетыBindingNavigator.BindingSource = this.самолетыBindingSource;
            this.самолетыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.самолетыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.самолетыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.самолетыBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.самолетыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.самолетыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.самолетыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.самолетыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.самолетыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.самолетыBindingNavigator.Name = "самолетыBindingNavigator";
            this.самолетыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.самолетыBindingNavigator.Size = new System.Drawing.Size(650, 25);
            this.самолетыBindingNavigator.TabIndex = 2;
            this.самолетыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // самолетыBindingNavigatorSaveItem
            // 
            this.самолетыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.самолетыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("самолетыBindingNavigatorSaveItem.Image")));
            this.самолетыBindingNavigatorSaveItem.Name = "самолетыBindingNavigatorSaveItem";
            this.самолетыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.самолетыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.самолетыBindingNavigatorSaveItem.Click += new System.EventHandler(this.самолетыBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // маркаLabel
            // 
            маркаLabel.AutoSize = true;
            маркаLabel.Location = new System.Drawing.Point(66, 52);
            маркаLabel.Name = "маркаLabel";
            маркаLabel.Size = new System.Drawing.Size(43, 13);
            маркаLabel.TabIndex = 2;
            маркаLabel.Text = "Марка:";
            // 
            // маркаTextBox
            // 
            this.маркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.самолетыBindingSource, "Марка", true));
            this.маркаTextBox.Location = new System.Drawing.Point(115, 49);
            this.маркаTextBox.Name = "маркаTextBox";
            this.маркаTextBox.Size = new System.Drawing.Size(100, 20);
            this.маркаTextBox.TabIndex = 3;
            // 
            // вместимостьLabel
            // 
            вместимостьLabel.AutoSize = true;
            вместимостьLabel.Location = new System.Drawing.Point(30, 90);
            вместимостьLabel.Name = "вместимостьLabel";
            вместимостьLabel.Size = new System.Drawing.Size(79, 13);
            вместимостьLabel.TabIndex = 4;
            вместимостьLabel.Text = "Вместимость:";
            // 
            // вместимостьTextBox
            // 
            this.вместимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.самолетыBindingSource, "Вместимость", true));
            this.вместимостьTextBox.Location = new System.Drawing.Point(115, 87);
            this.вместимостьTextBox.Name = "вместимостьTextBox";
            this.вместимостьTextBox.Size = new System.Drawing.Size(100, 20);
            this.вместимостьTextBox.TabIndex = 5;
            // 
            // грузоподъемностьLabel
            // 
            грузоподъемностьLabel.AutoSize = true;
            грузоподъемностьLabel.Location = new System.Drawing.Point(2, 126);
            грузоподъемностьLabel.Name = "грузоподъемностьLabel";
            грузоподъемностьLabel.Size = new System.Drawing.Size(107, 13);
            грузоподъемностьLabel.TabIndex = 6;
            грузоподъемностьLabel.Text = "Грузоподъемность:";
            // 
            // грузоподъемностьTextBox
            // 
            this.грузоподъемностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.самолетыBindingSource, "Грузоподъемность", true));
            this.грузоподъемностьTextBox.Location = new System.Drawing.Point(115, 123);
            this.грузоподъемностьTextBox.Name = "грузоподъемностьTextBox";
            this.грузоподъемностьTextBox.Size = new System.Drawing.Size(100, 20);
            this.грузоподъемностьTextBox.TabIndex = 7;
            // 
            // код_типаLabel
            // 
            код_типаLabel.AutoSize = true;
            код_типаLabel.Location = new System.Drawing.Point(54, 163);
            код_типаLabel.Name = "код_типаLabel";
            код_типаLabel.Size = new System.Drawing.Size(55, 13);
            код_типаLabel.TabIndex = 8;
            код_типаLabel.Text = "Код типа:";
            // 
            // код_типаTextBox
            // 
            this.код_типаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.самолетыBindingSource, "Код типа", true));
            this.код_типаTextBox.Location = new System.Drawing.Point(115, 160);
            this.код_типаTextBox.Name = "код_типаTextBox";
            this.код_типаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_типаTextBox.TabIndex = 9;
            // 
            // тТХLabel
            // 
            тТХLabel.AutoSize = true;
            тТХLabel.Location = new System.Drawing.Point(460, 49);
            тТХLabel.Name = "тТХLabel";
            тТХLabel.Size = new System.Drawing.Size(31, 13);
            тТХLabel.TabIndex = 10;
            тТХLabel.Text = "ТТХ:";
            // 
            // тТХTextBox
            // 
            this.тТХTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.самолетыBindingSource, "ТТХ", true));
            this.тТХTextBox.Location = new System.Drawing.Point(497, 45);
            this.тТХTextBox.Name = "тТХTextBox";
            this.тТХTextBox.Size = new System.Drawing.Size(100, 20);
            this.тТХTextBox.TabIndex = 11;
            // 
            // дата_выпускаLabel
            // 
            дата_выпускаLabel.AutoSize = true;
            дата_выпускаLabel.Location = new System.Drawing.Point(373, 94);
            дата_выпускаLabel.Name = "дата_выпускаLabel";
            дата_выпускаLabel.Size = new System.Drawing.Size(82, 13);
            дата_выпускаLabel.TabIndex = 12;
            дата_выпускаLabel.Text = "Дата выпуска:";
            // 
            // дата_выпускаDateTimePicker
            // 
            this.дата_выпускаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.самолетыBindingSource, "Дата выпуска", true));
            this.дата_выпускаDateTimePicker.Location = new System.Drawing.Point(463, 90);
            this.дата_выпускаDateTimePicker.Name = "дата_выпускаDateTimePicker";
            this.дата_выпускаDateTimePicker.Size = new System.Drawing.Size(131, 20);
            this.дата_выпускаDateTimePicker.TabIndex = 13;
            // 
            // налетLabel
            // 
            налетLabel.AutoSize = true;
            налетLabel.Location = new System.Drawing.Point(450, 129);
            налетLabel.Name = "налетLabel";
            налетLabel.Size = new System.Drawing.Size(41, 13);
            налетLabel.TabIndex = 14;
            налетLabel.Text = "Налет:";
            // 
            // налетTextBox
            // 
            this.налетTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.самолетыBindingSource, "Налет", true));
            this.налетTextBox.Location = new System.Drawing.Point(497, 126);
            this.налетTextBox.Name = "налетTextBox";
            this.налетTextBox.Size = new System.Drawing.Size(100, 20);
            this.налетTextBox.TabIndex = 15;
            // 
            // дата_последнего_ремонтаLabel
            // 
            дата_последнего_ремонтаLabel.AutoSize = true;
            дата_последнего_ремонтаLabel.Location = new System.Drawing.Point(313, 180);
            дата_последнего_ремонтаLabel.Name = "дата_последнего_ремонтаLabel";
            дата_последнего_ремонтаLabel.Size = new System.Drawing.Size(144, 13);
            дата_последнего_ремонтаLabel.TabIndex = 16;
            дата_последнего_ремонтаLabel.Text = "Дата последнего ремонта:";
            // 
            // дата_последнего_ремонтаDateTimePicker
            // 
            this.дата_последнего_ремонтаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.самолетыBindingSource, "Дата последнего ремонта", true));
            this.дата_последнего_ремонтаDateTimePicker.Location = new System.Drawing.Point(463, 176);
            this.дата_последнего_ремонтаDateTimePicker.Name = "дата_последнего_ремонтаDateTimePicker";
            this.дата_последнего_ремонтаDateTimePicker.Size = new System.Drawing.Size(134, 20);
            this.дата_последнего_ремонтаDateTimePicker.TabIndex = 17;
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Location = new System.Drawing.Point(401, 225);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(90, 13);
            код_сотрудникаLabel.TabIndex = 18;
            код_сотрудникаLabel.Text = "Код сотрудника:";
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.самолетыBindingSource, "Код сотрудника", true));
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(497, 222);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_сотрудникаTextBox.TabIndex = 19;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(327, 365);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 38);
            this.button7.TabIndex = 31;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(182, 366);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 36);
            this.button6.TabIndex = 30;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(37, 365);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 39);
            this.button5.TabIndex = 29;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(182, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 39);
            this.button4.TabIndex = 28;
            this.button4.Text = "Следующая";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(37, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 39);
            this.button3.TabIndex = 27;
            this.button3.Text = "Предыдущая";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(182, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 39);
            this.button2.TabIndex = 26;
            this.button2.Text = "Последняя";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(37, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 39);
            this.button1.TabIndex = 25;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(дата_последнего_ремонтаLabel);
            this.Controls.Add(this.дата_последнего_ремонтаDateTimePicker);
            this.Controls.Add(налетLabel);
            this.Controls.Add(this.налетTextBox);
            this.Controls.Add(дата_выпускаLabel);
            this.Controls.Add(this.дата_выпускаDateTimePicker);
            this.Controls.Add(тТХLabel);
            this.Controls.Add(this.тТХTextBox);
            this.Controls.Add(код_типаLabel);
            this.Controls.Add(this.код_типаTextBox);
            this.Controls.Add(грузоподъемностьLabel);
            this.Controls.Add(this.грузоподъемностьTextBox);
            this.Controls.Add(вместимостьLabel);
            this.Controls.Add(this.вместимостьTextBox);
            this.Controls.Add(маркаLabel);
            this.Controls.Add(this.маркаTextBox);
            this.Controls.Add(this.самолетыBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.аэропортDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingNavigator)).EndInit();
            this.самолетыBindingNavigator.ResumeLayout(false);
            this.самолетыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private АэропортDataSet аэропортDataSet;
        private System.Windows.Forms.BindingSource самолетыBindingSource;
        private АэропортDataSetTableAdapters.СамолетыTableAdapter самолетыTableAdapter;
        private АэропортDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator самолетыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton самолетыBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox маркаTextBox;
        private System.Windows.Forms.TextBox вместимостьTextBox;
        private System.Windows.Forms.TextBox грузоподъемностьTextBox;
        private System.Windows.Forms.TextBox код_типаTextBox;
        private System.Windows.Forms.TextBox тТХTextBox;
        private System.Windows.Forms.DateTimePicker дата_выпускаDateTimePicker;
        private System.Windows.Forms.TextBox налетTextBox;
        private System.Windows.Forms.DateTimePicker дата_последнего_ремонтаDateTimePicker;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}