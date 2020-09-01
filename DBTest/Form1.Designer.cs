namespace DBTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label addressIDLabel;
            System.Windows.Forms.Label addressLine1Label;
            System.Windows.Forms.Label addressLine2Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateProvinceLabel;
            System.Windows.Forms.Label countryRegionLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label rowguidLabel;
            System.Windows.Forms.Label modifiedDateLabel;
            this.tSOPPTESTDataSet = new DBTest.TSOPPTESTDataSet();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTableAdapter = new DBTest.TSOPPTESTDataSetTableAdapters.AddressTableAdapter();
            this.tableAdapterManager = new DBTest.TSOPPTESTDataSetTableAdapters.TableAdapterManager();
            this.addressBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.addressBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.addressIDTextBox = new System.Windows.Forms.TextBox();
            this.addressLine1TextBox = new System.Windows.Forms.TextBox();
            this.addressLine2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateProvinceTextBox = new System.Windows.Forms.TextBox();
            this.countryRegionTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.rowguidTextBox = new System.Windows.Forms.TextBox();
            this.modifiedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            addressIDLabel = new System.Windows.Forms.Label();
            addressLine1Label = new System.Windows.Forms.Label();
            addressLine2Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateProvinceLabel = new System.Windows.Forms.Label();
            countryRegionLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            rowguidLabel = new System.Windows.Forms.Label();
            modifiedDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tSOPPTESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingNavigator)).BeginInit();
            this.addressBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tSOPPTESTDataSet
            // 
            this.tSOPPTESTDataSet.DataSetName = "TSOPPTESTDataSet";
            this.tSOPPTESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "Address";
            this.addressBindingSource.DataSource = this.tSOPPTESTDataSet;
            // 
            // addressTableAdapter
            // 
            this.addressTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddressTableAdapter = this.addressTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuildVersionTableAdapter = null;
            this.tableAdapterManager.CustomerAddressTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.ErrorLogTableAdapter = null;
            this.tableAdapterManager.ProductCategoryTableAdapter = null;
            this.tableAdapterManager.ProductDescriptionTableAdapter = null;
            this.tableAdapterManager.ProductModelProductDescriptionTableAdapter = null;
            this.tableAdapterManager.ProductModelTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.SalesOrderDetailTableAdapter = null;
            this.tableAdapterManager.SalesOrderHeaderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DBTest.TSOPPTESTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // addressBindingNavigator
            // 
            this.addressBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.addressBindingNavigator.BindingSource = this.addressBindingSource;
            this.addressBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.addressBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.addressBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.addressBindingNavigatorSaveItem});
            this.addressBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.addressBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.addressBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.addressBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.addressBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.addressBindingNavigator.Name = "addressBindingNavigator";
            this.addressBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.addressBindingNavigator.Size = new System.Drawing.Size(1393, 25);
            this.addressBindingNavigator.TabIndex = 0;
            this.addressBindingNavigator.Text = "bindingNavigator1";
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
            // addressBindingNavigatorSaveItem
            // 
            this.addressBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addressBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("addressBindingNavigatorSaveItem.Image")));
            this.addressBindingNavigatorSaveItem.Name = "addressBindingNavigatorSaveItem";
            this.addressBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.addressBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.addressBindingNavigatorSaveItem.Click += new System.EventHandler(this.addressBindingNavigatorSaveItem_Click_3);
            // 
            // addressIDLabel
            // 
            addressIDLabel.AutoSize = true;
            addressIDLabel.Location = new System.Drawing.Point(12, 34);
            addressIDLabel.Name = "addressIDLabel";
            addressIDLabel.Size = new System.Drawing.Size(62, 13);
            addressIDLabel.TabIndex = 1;
            addressIDLabel.Text = "Address ID:";
            // 
            // addressIDTextBox
            // 
            this.addressIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "AddressID", true));
            this.addressIDTextBox.Location = new System.Drawing.Point(101, 31);
            this.addressIDTextBox.Name = "addressIDTextBox";
            this.addressIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressIDTextBox.TabIndex = 2;
            // 
            // addressLine1Label
            // 
            addressLine1Label.AutoSize = true;
            addressLine1Label.Location = new System.Drawing.Point(12, 60);
            addressLine1Label.Name = "addressLine1Label";
            addressLine1Label.Size = new System.Drawing.Size(77, 13);
            addressLine1Label.TabIndex = 3;
            addressLine1Label.Text = "Address Line1:";
            // 
            // addressLine1TextBox
            // 
            this.addressLine1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "AddressLine1", true));
            this.addressLine1TextBox.Location = new System.Drawing.Point(101, 57);
            this.addressLine1TextBox.Name = "addressLine1TextBox";
            this.addressLine1TextBox.Size = new System.Drawing.Size(200, 20);
            this.addressLine1TextBox.TabIndex = 4;
            // 
            // addressLine2Label
            // 
            addressLine2Label.AutoSize = true;
            addressLine2Label.Location = new System.Drawing.Point(12, 86);
            addressLine2Label.Name = "addressLine2Label";
            addressLine2Label.Size = new System.Drawing.Size(77, 13);
            addressLine2Label.TabIndex = 5;
            addressLine2Label.Text = "Address Line2:";
            // 
            // addressLine2TextBox
            // 
            this.addressLine2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "AddressLine2", true));
            this.addressLine2TextBox.Location = new System.Drawing.Point(101, 83);
            this.addressLine2TextBox.Name = "addressLine2TextBox";
            this.addressLine2TextBox.Size = new System.Drawing.Size(200, 20);
            this.addressLine2TextBox.TabIndex = 6;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(12, 112);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(101, 109);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityTextBox.TabIndex = 8;
            // 
            // stateProvinceLabel
            // 
            stateProvinceLabel.AutoSize = true;
            stateProvinceLabel.Location = new System.Drawing.Point(12, 138);
            stateProvinceLabel.Name = "stateProvinceLabel";
            stateProvinceLabel.Size = new System.Drawing.Size(80, 13);
            stateProvinceLabel.TabIndex = 9;
            stateProvinceLabel.Text = "State Province:";
            // 
            // stateProvinceTextBox
            // 
            this.stateProvinceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "StateProvince", true));
            this.stateProvinceTextBox.Location = new System.Drawing.Point(101, 135);
            this.stateProvinceTextBox.Name = "stateProvinceTextBox";
            this.stateProvinceTextBox.Size = new System.Drawing.Size(200, 20);
            this.stateProvinceTextBox.TabIndex = 10;
            // 
            // countryRegionLabel
            // 
            countryRegionLabel.AutoSize = true;
            countryRegionLabel.Location = new System.Drawing.Point(12, 164);
            countryRegionLabel.Name = "countryRegionLabel";
            countryRegionLabel.Size = new System.Drawing.Size(83, 13);
            countryRegionLabel.TabIndex = 11;
            countryRegionLabel.Text = "Country Region:";
            // 
            // countryRegionTextBox
            // 
            this.countryRegionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "CountryRegion", true));
            this.countryRegionTextBox.Location = new System.Drawing.Point(101, 161);
            this.countryRegionTextBox.Name = "countryRegionTextBox";
            this.countryRegionTextBox.Size = new System.Drawing.Size(200, 20);
            this.countryRegionTextBox.TabIndex = 12;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(12, 190);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(67, 13);
            postalCodeLabel.TabIndex = 13;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "PostalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(101, 187);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.postalCodeTextBox.TabIndex = 14;
            // 
            // rowguidLabel
            // 
            rowguidLabel.AutoSize = true;
            rowguidLabel.Location = new System.Drawing.Point(12, 216);
            rowguidLabel.Name = "rowguidLabel";
            rowguidLabel.Size = new System.Drawing.Size(47, 13);
            rowguidLabel.TabIndex = 15;
            rowguidLabel.Text = "rowguid:";
            // 
            // rowguidTextBox
            // 
            this.rowguidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "rowguid", true));
            this.rowguidTextBox.Location = new System.Drawing.Point(101, 213);
            this.rowguidTextBox.Name = "rowguidTextBox";
            this.rowguidTextBox.Size = new System.Drawing.Size(200, 20);
            this.rowguidTextBox.TabIndex = 16;
            // 
            // modifiedDateLabel
            // 
            modifiedDateLabel.AutoSize = true;
            modifiedDateLabel.Location = new System.Drawing.Point(12, 243);
            modifiedDateLabel.Name = "modifiedDateLabel";
            modifiedDateLabel.Size = new System.Drawing.Size(76, 13);
            modifiedDateLabel.TabIndex = 17;
            modifiedDateLabel.Text = "Modified Date:";
            // 
            // modifiedDateDateTimePicker
            // 
            this.modifiedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.addressBindingSource, "ModifiedDate", true));
            this.modifiedDateDateTimePicker.Location = new System.Drawing.Point(101, 239);
            this.modifiedDateDateTimePicker.Name = "modifiedDateDateTimePicker";
            this.modifiedDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.modifiedDateDateTimePicker.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 575);
            this.Controls.Add(addressIDLabel);
            this.Controls.Add(this.addressIDTextBox);
            this.Controls.Add(addressLine1Label);
            this.Controls.Add(this.addressLine1TextBox);
            this.Controls.Add(addressLine2Label);
            this.Controls.Add(this.addressLine2TextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateProvinceLabel);
            this.Controls.Add(this.stateProvinceTextBox);
            this.Controls.Add(countryRegionLabel);
            this.Controls.Add(this.countryRegionTextBox);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(rowguidLabel);
            this.Controls.Add(this.rowguidTextBox);
            this.Controls.Add(modifiedDateLabel);
            this.Controls.Add(this.modifiedDateDateTimePicker);
            this.Controls.Add(this.addressBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tSOPPTESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingNavigator)).EndInit();
            this.addressBindingNavigator.ResumeLayout(false);
            this.addressBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TSOPPTESTDataSet tSOPPTESTDataSet;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private TSOPPTESTDataSetTableAdapters.AddressTableAdapter addressTableAdapter;
        private TSOPPTESTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator addressBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton addressBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox addressIDTextBox;
        private System.Windows.Forms.TextBox addressLine1TextBox;
        private System.Windows.Forms.TextBox addressLine2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateProvinceTextBox;
        private System.Windows.Forms.TextBox countryRegionTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox rowguidTextBox;
        private System.Windows.Forms.DateTimePicker modifiedDateDateTimePicker;
    }
}

