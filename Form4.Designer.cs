namespace WindowsFormsApp15
{
    partial class Form4
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
            System.Windows.Forms.Label дата_и_времяLabel;
            System.Windows.Forms.Label откудаLabel;
            System.Windows.Forms.Label кудаLabel;
            System.Windows.Forms.Label код_экипажаLabel;
            System.Windows.Forms.Label код_самолетаLabel;
            System.Windows.Forms.Label время_полетаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.аэропортDataSet = new WindowsFormsApp15.АэропортDataSet();
            this.рейсыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рейсыTableAdapter = new WindowsFormsApp15.АэропортDataSetTableAdapters.РейсыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp15.АэропортDataSetTableAdapters.TableAdapterManager();
            this.рейсыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.рейсыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.дата_и_времяDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.откудаTextBox = new System.Windows.Forms.TextBox();
            this.кудаTextBox = new System.Windows.Forms.TextBox();
            this.код_экипажаTextBox = new System.Windows.Forms.TextBox();
            this.код_самолетаTextBox = new System.Windows.Forms.TextBox();
            this.время_полетаTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            дата_и_времяLabel = new System.Windows.Forms.Label();
            откудаLabel = new System.Windows.Forms.Label();
            кудаLabel = new System.Windows.Forms.Label();
            код_экипажаLabel = new System.Windows.Forms.Label();
            код_самолетаLabel = new System.Windows.Forms.Label();
            время_полетаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.аэропортDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingNavigator)).BeginInit();
            this.рейсыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // дата_и_времяLabel
            // 
            дата_и_времяLabel.AutoSize = true;
            дата_и_времяLabel.Location = new System.Drawing.Point(57, 58);
            дата_и_времяLabel.Name = "дата_и_времяLabel";
            дата_и_времяLabel.Size = new System.Drawing.Size(80, 13);
            дата_и_времяLabel.TabIndex = 2;
            дата_и_времяLabel.Text = "Дата и время:";
            // 
            // откудаLabel
            // 
            откудаLabel.AutoSize = true;
            откудаLabel.Location = new System.Drawing.Point(116, 97);
            откудаLabel.Name = "откудаLabel";
            откудаLabel.Size = new System.Drawing.Size(46, 13);
            откудаLabel.TabIndex = 4;
            откудаLabel.Text = "Откуда:";
            // 
            // кудаLabel
            // 
            кудаLabel.AutoSize = true;
            кудаLabel.Location = new System.Drawing.Point(128, 148);
            кудаLabel.Name = "кудаLabel";
            кудаLabel.Size = new System.Drawing.Size(34, 13);
            кудаLabel.TabIndex = 6;
            кудаLabel.Text = "Куда:";
            // 
            // код_экипажаLabel
            // 
            код_экипажаLabel.AutoSize = true;
            код_экипажаLabel.Location = new System.Drawing.Point(86, 194);
            код_экипажаLabel.Name = "код_экипажаLabel";
            код_экипажаLabel.Size = new System.Drawing.Size(76, 13);
            код_экипажаLabel.TabIndex = 8;
            код_экипажаLabel.Text = "Код экипажа:";
            // 
            // код_самолетаLabel
            // 
            код_самолетаLabel.AutoSize = true;
            код_самолетаLabel.Location = new System.Drawing.Point(81, 232);
            код_самолетаLabel.Name = "код_самолетаLabel";
            код_самолетаLabel.Size = new System.Drawing.Size(81, 13);
            код_самолетаLabel.TabIndex = 10;
            код_самолетаLabel.Text = "Код самолета:";
            // 
            // время_полетаLabel
            // 
            время_полетаLabel.AutoSize = true;
            время_полетаLabel.Location = new System.Drawing.Point(81, 276);
            время_полетаLabel.Name = "время_полетаLabel";
            время_полетаLabel.Size = new System.Drawing.Size(81, 13);
            время_полетаLabel.TabIndex = 12;
            время_полетаLabel.Text = "Время полета:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(387, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Рейсы";
            // 
            // аэропортDataSet
            // 
            this.аэропортDataSet.DataSetName = "АэропортDataSet";
            this.аэропортDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рейсыBindingSource
            // 
            this.рейсыBindingSource.DataMember = "Рейсы";
            this.рейсыBindingSource.DataSource = this.аэропортDataSet;
            // 
            // рейсыTableAdapter
            // 
            this.рейсыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp15.АэропортDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БилетыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.РейсыTableAdapter = this.рейсыTableAdapter;
            this.tableAdapterManager.СамолетыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Типы_самолетовTableAdapter = null;
            this.tableAdapterManager.ЭкипажиTableAdapter = null;
            // 
            // рейсыBindingNavigator
            // 
            this.рейсыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.рейсыBindingNavigator.BindingSource = this.рейсыBindingSource;
            this.рейсыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.рейсыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.рейсыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.рейсыBindingNavigatorSaveItem});
            this.рейсыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.рейсыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.рейсыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.рейсыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.рейсыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.рейсыBindingNavigator.Name = "рейсыBindingNavigator";
            this.рейсыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.рейсыBindingNavigator.Size = new System.Drawing.Size(908, 25);
            this.рейсыBindingNavigator.TabIndex = 2;
            this.рейсыBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // рейсыBindingNavigatorSaveItem
            // 
            this.рейсыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.рейсыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("рейсыBindingNavigatorSaveItem.Image")));
            this.рейсыBindingNavigatorSaveItem.Name = "рейсыBindingNavigatorSaveItem";
            this.рейсыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.рейсыBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // дата_и_времяDateTimePicker
            // 
            this.дата_и_времяDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.рейсыBindingSource, "Дата и время", true));
            this.дата_и_времяDateTimePicker.Location = new System.Drawing.Point(143, 54);
            this.дата_и_времяDateTimePicker.Name = "дата_и_времяDateTimePicker";
            this.дата_и_времяDateTimePicker.Size = new System.Drawing.Size(125, 20);
            this.дата_и_времяDateTimePicker.TabIndex = 3;
            // 
            // откудаTextBox
            // 
            this.откудаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Откуда", true));
            this.откудаTextBox.Location = new System.Drawing.Point(168, 94);
            this.откудаTextBox.Name = "откудаTextBox";
            this.откудаTextBox.Size = new System.Drawing.Size(100, 20);
            this.откудаTextBox.TabIndex = 5;
            // 
            // кудаTextBox
            // 
            this.кудаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Куда", true));
            this.кудаTextBox.Location = new System.Drawing.Point(168, 145);
            this.кудаTextBox.Name = "кудаTextBox";
            this.кудаTextBox.Size = new System.Drawing.Size(100, 20);
            this.кудаTextBox.TabIndex = 7;
            // 
            // код_экипажаTextBox
            // 
            this.код_экипажаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Код экипажа", true));
            this.код_экипажаTextBox.Location = new System.Drawing.Point(168, 191);
            this.код_экипажаTextBox.Name = "код_экипажаTextBox";
            this.код_экипажаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_экипажаTextBox.TabIndex = 9;
            // 
            // код_самолетаTextBox
            // 
            this.код_самолетаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Код самолета", true));
            this.код_самолетаTextBox.Location = new System.Drawing.Point(168, 229);
            this.код_самолетаTextBox.Name = "код_самолетаTextBox";
            this.код_самолетаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_самолетаTextBox.TabIndex = 11;
            // 
            // время_полетаTextBox
            // 
            this.время_полетаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Время полета", true));
            this.время_полетаTextBox.Location = new System.Drawing.Point(168, 273);
            this.время_полетаTextBox.Name = "время_полетаTextBox";
            this.время_полетаTextBox.Size = new System.Drawing.Size(100, 20);
            this.время_полетаTextBox.TabIndex = 13;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(662, 292);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 38);
            this.button7.TabIndex = 31;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(517, 293);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 36);
            this.button6.TabIndex = 30;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(372, 292);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 39);
            this.button5.TabIndex = 29;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(517, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 39);
            this.button4.TabIndex = 28;
            this.button4.Text = "Следующая";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(372, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 39);
            this.button3.TabIndex = 27;
            this.button3.Text = "Предыдущая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(517, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 39);
            this.button2.TabIndex = 26;
            this.button2.Text = "Последняя";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(372, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 39);
            this.button1.TabIndex = 25;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 454);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(время_полетаLabel);
            this.Controls.Add(this.время_полетаTextBox);
            this.Controls.Add(код_самолетаLabel);
            this.Controls.Add(this.код_самолетаTextBox);
            this.Controls.Add(код_экипажаLabel);
            this.Controls.Add(this.код_экипажаTextBox);
            this.Controls.Add(кудаLabel);
            this.Controls.Add(this.кудаTextBox);
            this.Controls.Add(откудаLabel);
            this.Controls.Add(this.откудаTextBox);
            this.Controls.Add(дата_и_времяLabel);
            this.Controls.Add(this.дата_и_времяDateTimePicker);
            this.Controls.Add(this.рейсыBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "\\";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.аэропортDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingNavigator)).EndInit();
            this.рейсыBindingNavigator.ResumeLayout(false);
            this.рейсыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private АэропортDataSet аэропортDataSet;
        private System.Windows.Forms.BindingSource рейсыBindingSource;
        private АэропортDataSetTableAdapters.РейсыTableAdapter рейсыTableAdapter;
        private АэропортDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator рейсыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton рейсыBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker дата_и_времяDateTimePicker;
        private System.Windows.Forms.TextBox откудаTextBox;
        private System.Windows.Forms.TextBox кудаTextBox;
        private System.Windows.Forms.TextBox код_экипажаTextBox;
        private System.Windows.Forms.TextBox код_самолетаTextBox;
        private System.Windows.Forms.TextBox время_полетаTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}