﻿namespace lab2
{
    partial class FlatForm
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
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Минск");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Могилев");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Гомель");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Беларусь", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Колорадо");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Вайоминг");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Техас");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("США", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Киев");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Львов");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Одесса");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Украина", new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Нюрбург");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Франкфурт");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Берлин");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Германия", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Москва");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Санкт-Петербург");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Владивосток");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Россия", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Страна", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode29,
            treeNode33,
            treeNode37,
            treeNode41});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlatForm));
            this.label1 = new System.Windows.Forms.Label();
            this.labelFootage = new System.Windows.Forms.Label();
            this.labelRooms = new System.Windows.Forms.Label();
            this.checkBoxKitchen = new System.Windows.Forms.CheckBox();
            this.checkBoxLivingRoom = new System.Windows.Forms.CheckBox();
            this.checkBoxBathroom = new System.Windows.Forms.CheckBox();
            this.checkBoxBalcony = new System.Windows.Forms.CheckBox();
            this.checkBoxBasement = new System.Windows.Forms.CheckBox();
            this.trackBarFootage = new System.Windows.Forms.TrackBar();
            this.labelYear = new System.Windows.Forms.Label();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.labelFloor = new System.Windows.Forms.Label();
            this.numericUpDownFloor = new System.Windows.Forms.NumericUpDown();
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.labelIndex = new System.Windows.Forms.Label();
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.textBoxNumberFlat = new System.Windows.Forms.TextBox();
            this.textBoxNumberHouse = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelFlatNumber = new System.Windows.Forms.Label();
            this.labelHouse = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelDistrict = new System.Windows.Forms.Label();
            this.treeViewCountry = new System.Windows.Forms.TreeView();
            this.numericUpDownRooms = new System.Windows.Forms.NumericUpDown();
            this.buttonOutputFlatInfo = new System.Windows.Forms.Button();
            this.textBoxFlatInfo = new System.Windows.Forms.TextBox();
            this.buttonClearInfo = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCostFlat = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.buttonAutoFill = new System.Windows.Forms.Button();
            this.labelBucks = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSearchYear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSearchDistrict = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSearchAmountRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortYear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortFootage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveResult = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSortResult = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSearchResult = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHideTool = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearched = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSorted = new System.Windows.Forms.TextBox();
            this.buttonSearchSave = new System.Windows.Forms.Button();
            this.buttonSortSave = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonSearch = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemYearSear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDistrictSear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRoomsSear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonSort = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemYear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFootage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonSave = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemSortRes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSearchRes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClearInfo = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelObjectsAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonNotSalling = new System.Windows.Forms.RadioButton();
            this.radioButtonSalling = new System.Windows.Forms.RadioButton();
            this.labelStateFlat = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonRepair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFootage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloor)).BeginInit();
            this.groupBoxAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRooms)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация о квартире";
            // 
            // labelFootage
            // 
            this.labelFootage.AutoSize = true;
            this.labelFootage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFootage.Location = new System.Drawing.Point(78, 116);
            this.labelFootage.Name = "labelFootage";
            this.labelFootage.Size = new System.Drawing.Size(169, 25);
            this.labelFootage.TabIndex = 1;
            this.labelFootage.Text = "Метраж:     (м^2)";
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRooms.Location = new System.Drawing.Point(78, 211);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(199, 25);
            this.labelRooms.TabIndex = 3;
            this.labelRooms.Text = "Количество комнат";
            // 
            // checkBoxKitchen
            // 
            this.checkBoxKitchen.AutoSize = true;
            this.checkBoxKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxKitchen.Location = new System.Drawing.Point(84, 291);
            this.checkBoxKitchen.Name = "checkBoxKitchen";
            this.checkBoxKitchen.Size = new System.Drawing.Size(87, 29);
            this.checkBoxKitchen.TabIndex = 5;
            this.checkBoxKitchen.Text = "Кухня";
            this.checkBoxKitchen.UseVisualStyleBackColor = true;
            // 
            // checkBoxLivingRoom
            // 
            this.checkBoxLivingRoom.AutoSize = true;
            this.checkBoxLivingRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxLivingRoom.Location = new System.Drawing.Point(84, 325);
            this.checkBoxLivingRoom.Name = "checkBoxLivingRoom";
            this.checkBoxLivingRoom.Size = new System.Drawing.Size(122, 29);
            this.checkBoxLivingRoom.TabIndex = 6;
            this.checkBoxLivingRoom.Text = "Гостиная";
            this.checkBoxLivingRoom.UseVisualStyleBackColor = true;
            // 
            // checkBoxBathroom
            // 
            this.checkBoxBathroom.AutoSize = true;
            this.checkBoxBathroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxBathroom.Location = new System.Drawing.Point(84, 359);
            this.checkBoxBathroom.Name = "checkBoxBathroom";
            this.checkBoxBathroom.Size = new System.Drawing.Size(185, 29);
            this.checkBoxBathroom.TabIndex = 7;
            this.checkBoxBathroom.Text = "Ванная комната";
            this.checkBoxBathroom.UseVisualStyleBackColor = true;
            // 
            // checkBoxBalcony
            // 
            this.checkBoxBalcony.AutoSize = true;
            this.checkBoxBalcony.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxBalcony.Location = new System.Drawing.Point(84, 395);
            this.checkBoxBalcony.Name = "checkBoxBalcony";
            this.checkBoxBalcony.Size = new System.Drawing.Size(100, 29);
            this.checkBoxBalcony.TabIndex = 8;
            this.checkBoxBalcony.Text = "Балкон";
            this.checkBoxBalcony.UseVisualStyleBackColor = true;
            // 
            // checkBoxBasement
            // 
            this.checkBoxBasement.AutoSize = true;
            this.checkBoxBasement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxBasement.Location = new System.Drawing.Point(84, 431);
            this.checkBoxBasement.Name = "checkBoxBasement";
            this.checkBoxBasement.Size = new System.Drawing.Size(103, 29);
            this.checkBoxBasement.TabIndex = 9;
            this.checkBoxBasement.Text = "Подвал";
            this.checkBoxBasement.UseVisualStyleBackColor = true;
            // 
            // trackBarFootage
            // 
            this.trackBarFootage.AllowDrop = true;
            this.trackBarFootage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.trackBarFootage.Location = new System.Drawing.Point(69, 143);
            this.trackBarFootage.Maximum = 300;
            this.trackBarFootage.Minimum = 1;
            this.trackBarFootage.Name = "trackBarFootage";
            this.trackBarFootage.Size = new System.Drawing.Size(194, 56);
            this.trackBarFootage.TabIndex = 10;
            this.trackBarFootage.TickFrequency = 50;
            this.trackBarFootage.Value = 1;
            this.trackBarFootage.Scroll += new System.EventHandler(this.trackBarFootage_Scroll);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelYear.Location = new System.Drawing.Point(77, 482);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(150, 25);
            this.labelYear.TabIndex = 11;
            this.labelYear.Text = "Год постройки";
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.CalendarMonthBackground = System.Drawing.Color.LightYellow;
            this.dateTimePickerYear.CustomFormat = "yyyy";
            this.dateTimePickerYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerYear.Location = new System.Drawing.Point(84, 518);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.Size = new System.Drawing.Size(75, 26);
            this.dateTimePickerYear.TabIndex = 12;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMaterial.Location = new System.Drawing.Point(79, 568);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(155, 25);
            this.labelMaterial.TabIndex = 13;
            this.labelMaterial.Text = "Тип материала";
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.BackColor = System.Drawing.Color.LightYellow;
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Items.AddRange(new object[] {
            "Кирпич",
            "Дерево",
            "Блоки",
            "Бетонные плиты"});
            this.comboBoxMaterial.Location = new System.Drawing.Point(84, 599);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(157, 28);
            this.comboBoxMaterial.TabIndex = 14;
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFloor.Location = new System.Drawing.Point(83, 633);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(65, 25);
            this.labelFloor.TabIndex = 15;
            this.labelFloor.Text = "Этаж";
            // 
            // numericUpDownFloor
            // 
            this.numericUpDownFloor.BackColor = System.Drawing.Color.LightYellow;
            this.numericUpDownFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownFloor.Location = new System.Drawing.Point(90, 661);
            this.numericUpDownFloor.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownFloor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFloor.Name = "numericUpDownFloor";
            this.numericUpDownFloor.Size = new System.Drawing.Size(46, 26);
            this.numericUpDownFloor.TabIndex = 16;
            this.numericUpDownFloor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.Controls.Add(this.labelState);
            this.groupBoxAddress.Controls.Add(this.labelStateFlat);
            this.groupBoxAddress.Controls.Add(this.textBoxIndex);
            this.groupBoxAddress.Controls.Add(this.labelIndex);
            this.groupBoxAddress.Controls.Add(this.comboBoxDistrict);
            this.groupBoxAddress.Controls.Add(this.textBoxNumberFlat);
            this.groupBoxAddress.Controls.Add(this.textBoxNumberHouse);
            this.groupBoxAddress.Controls.Add(this.textBoxStreet);
            this.groupBoxAddress.Controls.Add(this.labelFlatNumber);
            this.groupBoxAddress.Controls.Add(this.labelHouse);
            this.groupBoxAddress.Controls.Add(this.labelStreet);
            this.groupBoxAddress.Controls.Add(this.labelDistrict);
            this.groupBoxAddress.Controls.Add(this.treeViewCountry);
            this.groupBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxAddress.Location = new System.Drawing.Point(377, 75);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Size = new System.Drawing.Size(623, 296);
            this.groupBoxAddress.TabIndex = 17;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Адрес квартиры";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxIndex.Location = new System.Drawing.Point(275, 172);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.ShortcutsEnabled = false;
            this.textBoxIndex.Size = new System.Drawing.Size(145, 26);
            this.textBoxIndex.TabIndex = 34;
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelIndex.Location = new System.Drawing.Point(273, 149);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(70, 20);
            this.labelIndex.TabIndex = 33;
            this.labelIndex.Text = "Индекс";
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.AutoCompleteCustomSource.AddRange(new string[] {
            "Ленинский",
            "Первомайский",
            "Пушкинский",
            "Якубовского",
            "Казимировка"});
            this.comboBoxDistrict.BackColor = System.Drawing.Color.LightYellow;
            this.comboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Items.AddRange(new object[] {
            "Ленинский",
            "Первомайский",
            "Спутник",
            "Казимировка",
            "Пушкинский",
            "-Добавить-"});
            this.comboBoxDistrict.Location = new System.Drawing.Point(275, 47);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(146, 28);
            this.comboBoxDistrict.TabIndex = 32;
            this.comboBoxDistrict.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistrict_SelectedIndexChanged);
            // 
            // textBoxNumberFlat
            // 
            this.textBoxNumberFlat.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxNumberFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNumberFlat.Location = new System.Drawing.Point(456, 106);
            this.textBoxNumberFlat.Name = "textBoxNumberFlat";
            this.textBoxNumberFlat.ShortcutsEnabled = false;
            this.textBoxNumberFlat.Size = new System.Drawing.Size(145, 26);
            this.textBoxNumberFlat.TabIndex = 11;
            this.textBoxNumberFlat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberFlat_KeyPress);
            // 
            // textBoxNumberHouse
            // 
            this.textBoxNumberHouse.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxNumberHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNumberHouse.Location = new System.Drawing.Point(457, 40);
            this.textBoxNumberHouse.Name = "textBoxNumberHouse";
            this.textBoxNumberHouse.ShortcutsEnabled = false;
            this.textBoxNumberHouse.Size = new System.Drawing.Size(145, 26);
            this.textBoxNumberHouse.TabIndex = 10;
            this.textBoxNumberHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberHouse_KeyPress);
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxStreet.Location = new System.Drawing.Point(275, 104);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.ShortcutsEnabled = false;
            this.textBoxStreet.Size = new System.Drawing.Size(145, 26);
            this.textBoxStreet.TabIndex = 9;
            this.textBoxStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStreet_KeyPress);
            // 
            // labelFlatNumber
            // 
            this.labelFlatNumber.AutoSize = true;
            this.labelFlatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelFlatNumber.Location = new System.Drawing.Point(452, 83);
            this.labelFlatNumber.Name = "labelFlatNumber";
            this.labelFlatNumber.Size = new System.Drawing.Size(150, 20);
            this.labelFlatNumber.TabIndex = 8;
            this.labelFlatNumber.Text = "Номер квартиры";
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelHouse.Location = new System.Drawing.Point(452, 17);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(113, 20);
            this.labelHouse.TabIndex = 7;
            this.labelHouse.Text = "Номер дома";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelStreet.Location = new System.Drawing.Point(271, 83);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(60, 20);
            this.labelStreet.TabIndex = 3;
            this.labelStreet.Text = "Улица";
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDistrict.Location = new System.Drawing.Point(271, 21);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(60, 20);
            this.labelDistrict.TabIndex = 1;
            this.labelDistrict.Text = "Район";
            // 
            // treeViewCountry
            // 
            this.treeViewCountry.BackColor = System.Drawing.Color.LightYellow;
            this.treeViewCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.treeViewCountry.Location = new System.Drawing.Point(27, 47);
            this.treeViewCountry.Name = "treeViewCountry";
            treeNode22.Name = "Minsk";
            treeNode22.Text = "Минск";
            treeNode23.Name = "Mogilev";
            treeNode23.Text = "Могилев";
            treeNode24.Name = "Gomel";
            treeNode24.Text = "Гомель";
            treeNode25.Name = "Belarus";
            treeNode25.Text = "Беларусь";
            treeNode26.Name = "Colorado";
            treeNode26.Text = "Колорадо";
            treeNode27.Name = "Wayoming";
            treeNode27.Text = "Вайоминг";
            treeNode28.Name = "Texas";
            treeNode28.Text = "Техас";
            treeNode29.Name = "USA";
            treeNode29.Text = "США";
            treeNode30.Name = "Kiev";
            treeNode30.Text = "Киев";
            treeNode31.Name = "Lviv";
            treeNode31.Text = "Львов";
            treeNode32.Name = "Odessa";
            treeNode32.Text = "Одесса";
            treeNode33.Name = "Ukraine";
            treeNode33.Text = "Украина";
            treeNode34.Name = "Nurburg";
            treeNode34.Text = "Нюрбург";
            treeNode35.Name = "Frankfurt";
            treeNode35.Text = "Франкфурт";
            treeNode36.Name = "Berlin";
            treeNode36.Text = "Берлин";
            treeNode37.Name = "Germany";
            treeNode37.Text = "Германия";
            treeNode38.Name = "Moscow";
            treeNode38.Text = "Москва";
            treeNode39.Name = "SPB";
            treeNode39.Text = "Санкт-Петербург";
            treeNode40.Name = "Vladivostok";
            treeNode40.Text = "Владивосток";
            treeNode41.Name = "Russia";
            treeNode41.Text = "Россия";
            treeNode42.Name = "Country";
            treeNode42.Text = "Страна";
            this.treeViewCountry.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode42});
            this.treeViewCountry.Size = new System.Drawing.Size(214, 213);
            this.treeViewCountry.TabIndex = 0;
            // 
            // numericUpDownRooms
            // 
            this.numericUpDownRooms.BackColor = System.Drawing.Color.LightYellow;
            this.numericUpDownRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownRooms.Location = new System.Drawing.Point(82, 247);
            this.numericUpDownRooms.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRooms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRooms.Name = "numericUpDownRooms";
            this.numericUpDownRooms.Size = new System.Drawing.Size(89, 26);
            this.numericUpDownRooms.TabIndex = 21;
            this.numericUpDownRooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonOutputFlatInfo
            // 
            this.buttonOutputFlatInfo.BackColor = System.Drawing.Color.LightGreen;
            this.buttonOutputFlatInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonOutputFlatInfo.Location = new System.Drawing.Point(377, 386);
            this.buttonOutputFlatInfo.Name = "buttonOutputFlatInfo";
            this.buttonOutputFlatInfo.Size = new System.Drawing.Size(269, 85);
            this.buttonOutputFlatInfo.TabIndex = 22;
            this.buttonOutputFlatInfo.Text = "Вывести информацию о квартире";
            this.buttonOutputFlatInfo.UseVisualStyleBackColor = false;
            this.buttonOutputFlatInfo.Click += new System.EventHandler(this.buttonOutputInfo_Click);
            this.buttonOutputFlatInfo.MouseEnter += new System.EventHandler(this.buttonAutoFill_MouseEnter);
            this.buttonOutputFlatInfo.MouseLeave += new System.EventHandler(this.buttonAutoFill_MouseLeave);
            // 
            // textBoxFlatInfo
            // 
            this.textBoxFlatInfo.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxFlatInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxFlatInfo.Location = new System.Drawing.Point(377, 483);
            this.textBoxFlatInfo.Multiline = true;
            this.textBoxFlatInfo.Name = "textBoxFlatInfo";
            this.textBoxFlatInfo.ReadOnly = true;
            this.textBoxFlatInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFlatInfo.Size = new System.Drawing.Size(269, 274);
            this.textBoxFlatInfo.TabIndex = 23;
            // 
            // buttonClearInfo
            // 
            this.buttonClearInfo.BackColor = System.Drawing.Color.LightGreen;
            this.buttonClearInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonClearInfo.Location = new System.Drawing.Point(86, 801);
            this.buttonClearInfo.Name = "buttonClearInfo";
            this.buttonClearInfo.Size = new System.Drawing.Size(144, 57);
            this.buttonClearInfo.TabIndex = 24;
            this.buttonClearInfo.Text = "ОЧИСТИТЬ";
            this.buttonClearInfo.UseVisualStyleBackColor = false;
            this.buttonClearInfo.Click += new System.EventHandler(this.buttonClearInfo_Click);
            this.buttonClearInfo.MouseEnter += new System.EventHandler(this.buttonAutoFill_MouseEnter);
            this.buttonClearInfo.MouseLeave += new System.EventHandler(this.buttonAutoFill_MouseLeave);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSave.Location = new System.Drawing.Point(452, 801);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(198, 55);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "СОХРАНИТЬ\r\n данные о квартире\r\n";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.MouseEnter += new System.EventHandler(this.buttonAutoFill_MouseEnter);
            this.buttonSave.MouseLeave += new System.EventHandler(this.buttonAutoFill_MouseLeave);
            // 
            // labelCostFlat
            // 
            this.labelCostFlat.AutoSize = true;
            this.labelCostFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCostFlat.Location = new System.Drawing.Point(85, 690);
            this.labelCostFlat.Name = "labelCostFlat";
            this.labelCostFlat.Size = new System.Drawing.Size(213, 25);
            this.labelCostFlat.TabIndex = 27;
            this.labelCostFlat.Text = "Стоимость квартиры";
            // 
            // textBoxCost
            // 
            this.textBoxCost.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCost.Location = new System.Drawing.Point(90, 722);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.ReadOnly = true;
            this.textBoxCost.Size = new System.Drawing.Size(100, 26);
            this.textBoxCost.TabIndex = 28;
            // 
            // buttonAutoFill
            // 
            this.buttonAutoFill.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAutoFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAutoFill.Location = new System.Drawing.Point(236, 801);
            this.buttonAutoFill.Name = "buttonAutoFill";
            this.buttonAutoFill.Size = new System.Drawing.Size(210, 57);
            this.buttonAutoFill.TabIndex = 29;
            this.buttonAutoFill.Text = "АВТОЗАПОЛНЕНИЕ";
            this.buttonAutoFill.UseVisualStyleBackColor = false;
            this.buttonAutoFill.Click += new System.EventHandler(this.buttonAutoFill_Click);
            this.buttonAutoFill.MouseEnter += new System.EventHandler(this.buttonAutoFill_MouseEnter);
            this.buttonAutoFill.MouseLeave += new System.EventHandler(this.buttonAutoFill_MouseLeave);
            // 
            // labelBucks
            // 
            this.labelBucks.AutoSize = true;
            this.labelBucks.BackColor = System.Drawing.Color.Transparent;
            this.labelBucks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelBucks.Location = new System.Drawing.Point(200, 723);
            this.labelBucks.Name = "labelBucks";
            this.labelBucks.Size = new System.Drawing.Size(23, 25);
            this.labelBucks.TabIndex = 30;
            this.labelBucks.Text = "$";
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSearch,
            this.toolStripMenuItemSort,
            this.ToolStripMenuItemSaveResult,
            this.toolStripMenuItemSave,
            this.ToolStripMenuItemHideTool});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1361, 28);
            this.menuStripMain.TabIndex = 32;
            // 
            // toolStripMenuItemSearch
            // 
            this.toolStripMenuItemSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSearchYear,
            this.toolStripMenuItemSearchDistrict,
            this.toolStripMenuItemSearchAmountRooms});
            this.toolStripMenuItemSearch.Name = "toolStripMenuItemSearch";
            this.toolStripMenuItemSearch.Size = new System.Drawing.Size(66, 24);
            this.toolStripMenuItemSearch.Text = "Поиск";
            // 
            // toolStripMenuItemSearchYear
            // 
            this.toolStripMenuItemSearchYear.Name = "toolStripMenuItemSearchYear";
            this.toolStripMenuItemSearchYear.Size = new System.Drawing.Size(215, 26);
            this.toolStripMenuItemSearchYear.Text = "По году";
            this.toolStripMenuItemSearchYear.Click += new System.EventHandler(this.toolStripMenuItemSearchYear_Click);
            // 
            // toolStripMenuItemSearchDistrict
            // 
            this.toolStripMenuItemSearchDistrict.Name = "toolStripMenuItemSearchDistrict";
            this.toolStripMenuItemSearchDistrict.Size = new System.Drawing.Size(215, 26);
            this.toolStripMenuItemSearchDistrict.Text = "По району";
            this.toolStripMenuItemSearchDistrict.Click += new System.EventHandler(this.toolStripMenuItemSearchDistrict_Click);
            // 
            // toolStripMenuItemSearchAmountRooms
            // 
            this.toolStripMenuItemSearchAmountRooms.Name = "toolStripMenuItemSearchAmountRooms";
            this.toolStripMenuItemSearchAmountRooms.Size = new System.Drawing.Size(215, 26);
            this.toolStripMenuItemSearchAmountRooms.Text = "По кол-ву комнат";
            this.toolStripMenuItemSearchAmountRooms.Click += new System.EventHandler(this.toolStripMenuItemSearchAmountRooms_Click);
            // 
            // toolStripMenuItemSort
            // 
            this.toolStripMenuItemSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSortYear,
            this.toolStripMenuItemSortFootage,
            this.toolStripMenuItemSortPrice});
            this.toolStripMenuItemSort.Name = "toolStripMenuItemSort";
            this.toolStripMenuItemSort.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItemSort.Text = "Сортировать по:";
            // 
            // toolStripMenuItemSortYear
            // 
            this.toolStripMenuItemSortYear.Name = "toolStripMenuItemSortYear";
            this.toolStripMenuItemSortYear.Size = new System.Drawing.Size(154, 26);
            this.toolStripMenuItemSortYear.Text = "Году";
            this.toolStripMenuItemSortYear.Click += new System.EventHandler(this.toolStripMenuItemSortYear_Click);
            // 
            // toolStripMenuItemSortFootage
            // 
            this.toolStripMenuItemSortFootage.Name = "toolStripMenuItemSortFootage";
            this.toolStripMenuItemSortFootage.Size = new System.Drawing.Size(154, 26);
            this.toolStripMenuItemSortFootage.Text = "Метражу";
            this.toolStripMenuItemSortFootage.Click += new System.EventHandler(this.toolStripMenuItemSortFootage_Click);
            // 
            // toolStripMenuItemSortPrice
            // 
            this.toolStripMenuItemSortPrice.Name = "toolStripMenuItemSortPrice";
            this.toolStripMenuItemSortPrice.Size = new System.Drawing.Size(154, 26);
            this.toolStripMenuItemSortPrice.Text = "Цене";
            this.toolStripMenuItemSortPrice.Click += new System.EventHandler(this.toolStripMenuItemSortPrice_Click);
            // 
            // ToolStripMenuItemSaveResult
            // 
            this.ToolStripMenuItemSaveResult.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSortResult,
            this.ToolStripMenuItemSearchResult});
            this.ToolStripMenuItemSaveResult.Name = "ToolStripMenuItemSaveResult";
            this.ToolStripMenuItemSaveResult.Size = new System.Drawing.Size(168, 24);
            this.ToolStripMenuItemSaveResult.Text = "Сохранить результат";
            // 
            // ToolStripMenuItemSortResult
            // 
            this.ToolStripMenuItemSortResult.Name = "ToolStripMenuItemSortResult";
            this.ToolStripMenuItemSortResult.Size = new System.Drawing.Size(176, 26);
            this.ToolStripMenuItemSortResult.Text = "Сортировки";
            this.ToolStripMenuItemSortResult.Click += new System.EventHandler(this.ToolStripMenuItemSortResult_Click);
            // 
            // ToolStripMenuItemSearchResult
            // 
            this.ToolStripMenuItemSearchResult.Name = "ToolStripMenuItemSearchResult";
            this.ToolStripMenuItemSearchResult.Size = new System.Drawing.Size(176, 26);
            this.ToolStripMenuItemSearchResult.Text = "Поиска";
            this.ToolStripMenuItemSearchResult.Click += new System.EventHandler(this.ToolStripMenuItemSearchResult_Click);
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(118, 24);
            this.toolStripMenuItemSave.Text = "О программе";
            this.toolStripMenuItemSave.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
            // 
            // ToolStripMenuItemHideTool
            // 
            this.ToolStripMenuItemHideTool.Name = "ToolStripMenuItemHideTool";
            this.ToolStripMenuItemHideTool.Size = new System.Drawing.Size(229, 24);
            this.ToolStripMenuItemHideTool.Text = "Скрыть панель инструментов";
            this.ToolStripMenuItemHideTool.Click += new System.EventHandler(this.ToolStripMenuItemHideTool_Click);
            // 
            // textBoxSearched
            // 
            this.textBoxSearched.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxSearched.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSearched.Location = new System.Drawing.Point(689, 483);
            this.textBoxSearched.Multiline = true;
            this.textBoxSearched.Name = "textBoxSearched";
            this.textBoxSearched.ReadOnly = true;
            this.textBoxSearched.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSearched.Size = new System.Drawing.Size(311, 274);
            this.textBoxSearched.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(695, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Результат поискового запроса:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(1033, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Результат сортировки:";
            // 
            // textBoxSorted
            // 
            this.textBoxSorted.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSorted.Location = new System.Drawing.Point(1038, 122);
            this.textBoxSorted.Multiline = true;
            this.textBoxSorted.Name = "textBoxSorted";
            this.textBoxSorted.ReadOnly = true;
            this.textBoxSorted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSorted.Size = new System.Drawing.Size(243, 635);
            this.textBoxSorted.TabIndex = 37;
            // 
            // buttonSearchSave
            // 
            this.buttonSearchSave.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSearchSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSearchSave.Location = new System.Drawing.Point(689, 756);
            this.buttonSearchSave.Name = "buttonSearchSave";
            this.buttonSearchSave.Size = new System.Drawing.Size(311, 75);
            this.buttonSearchSave.TabIndex = 38;
            this.buttonSearchSave.Text = "СОХРАНИТЬ\r\n результат поиска";
            this.buttonSearchSave.UseVisualStyleBackColor = false;
            this.buttonSearchSave.Click += new System.EventHandler(this.buttonSearchSave_Click);
            // 
            // buttonSortSave
            // 
            this.buttonSortSave.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSortSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSortSave.Location = new System.Drawing.Point(1038, 754);
            this.buttonSortSave.Name = "buttonSortSave";
            this.buttonSortSave.Size = new System.Drawing.Size(243, 75);
            this.buttonSortSave.TabIndex = 39;
            this.buttonSortSave.Text = "СОХРАНИТЬ\r\n результат поиска";
            this.buttonSortSave.UseVisualStyleBackColor = false;
            this.buttonSortSave.Click += new System.EventHandler(this.buttonSortSave_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonSearch,
            this.toolStripDropDownButtonSort,
            this.toolStripDropDownButtonSave,
            this.toolStripButtonAbout,
            this.toolStripButtonClearInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1361, 27);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonSearch
            // 
            this.toolStripDropDownButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemYearSear,
            this.toolStripMenuItemDistrictSear,
            this.toolStripMenuItemRoomsSear});
            this.toolStripDropDownButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonSearch.Image")));
            this.toolStripDropDownButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonSearch.Name = "toolStripDropDownButtonSearch";
            this.toolStripDropDownButtonSearch.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButtonSearch.Text = "Поиск";
            // 
            // toolStripMenuItemYearSear
            // 
            this.toolStripMenuItemYearSear.Name = "toolStripMenuItemYearSear";
            this.toolStripMenuItemYearSear.Size = new System.Drawing.Size(193, 26);
            this.toolStripMenuItemYearSear.Text = "Году";
            this.toolStripMenuItemYearSear.Click += new System.EventHandler(this.toolStripMenuItemYearSear_Click);
            // 
            // toolStripMenuItemDistrictSear
            // 
            this.toolStripMenuItemDistrictSear.Name = "toolStripMenuItemDistrictSear";
            this.toolStripMenuItemDistrictSear.Size = new System.Drawing.Size(193, 26);
            this.toolStripMenuItemDistrictSear.Text = "Району";
            this.toolStripMenuItemDistrictSear.Click += new System.EventHandler(this.toolStripMenuItemDistrictSear_Click);
            // 
            // toolStripMenuItemRoomsSear
            // 
            this.toolStripMenuItemRoomsSear.Name = "toolStripMenuItemRoomsSear";
            this.toolStripMenuItemRoomsSear.Size = new System.Drawing.Size(193, 26);
            this.toolStripMenuItemRoomsSear.Text = "Кол-ву комнат";
            this.toolStripMenuItemRoomsSear.Click += new System.EventHandler(this.toolStripMenuItemRoomsSear_Click);
            // 
            // toolStripDropDownButtonSort
            // 
            this.toolStripDropDownButtonSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemYear,
            this.toolStripMenuItemFootage,
            this.toolStripMenuItemPrice});
            this.toolStripDropDownButtonSort.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonSort.Image")));
            this.toolStripDropDownButtonSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonSort.Name = "toolStripDropDownButtonSort";
            this.toolStripDropDownButtonSort.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButtonSort.Text = "Сортировка по:";
            // 
            // toolStripMenuItemYear
            // 
            this.toolStripMenuItemYear.Name = "toolStripMenuItemYear";
            this.toolStripMenuItemYear.Size = new System.Drawing.Size(154, 26);
            this.toolStripMenuItemYear.Text = "Году";
            this.toolStripMenuItemYear.Click += new System.EventHandler(this.toolStripMenuItemYear_Click);
            // 
            // toolStripMenuItemFootage
            // 
            this.toolStripMenuItemFootage.Name = "toolStripMenuItemFootage";
            this.toolStripMenuItemFootage.Size = new System.Drawing.Size(154, 26);
            this.toolStripMenuItemFootage.Text = "Метражу";
            this.toolStripMenuItemFootage.Click += new System.EventHandler(this.toolStripMenuItemFootage_Click);
            // 
            // toolStripMenuItemPrice
            // 
            this.toolStripMenuItemPrice.Name = "toolStripMenuItemPrice";
            this.toolStripMenuItemPrice.Size = new System.Drawing.Size(154, 26);
            this.toolStripMenuItemPrice.Text = "Цене";
            this.toolStripMenuItemPrice.Click += new System.EventHandler(this.toolStripMenuItemRooms_Click);
            // 
            // toolStripDropDownButtonSave
            // 
            this.toolStripDropDownButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSortRes,
            this.toolStripMenuItemSearchRes});
            this.toolStripDropDownButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonSave.Image")));
            this.toolStripDropDownButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonSave.Name = "toolStripDropDownButtonSave";
            this.toolStripDropDownButtonSave.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButtonSave.Text = "Сохранить результат";
            // 
            // toolStripMenuItemSortRes
            // 
            this.toolStripMenuItemSortRes.Name = "toolStripMenuItemSortRes";
            this.toolStripMenuItemSortRes.Size = new System.Drawing.Size(176, 26);
            this.toolStripMenuItemSortRes.Text = "Сортировки";
            this.toolStripMenuItemSortRes.Click += new System.EventHandler(this.toolStripMenuItemSortRes_Click);
            // 
            // toolStripMenuItemSearchRes
            // 
            this.toolStripMenuItemSearchRes.Name = "toolStripMenuItemSearchRes";
            this.toolStripMenuItemSearchRes.Size = new System.Drawing.Size(176, 26);
            this.toolStripMenuItemSearchRes.Text = "Поиска";
            this.toolStripMenuItemSearchRes.Click += new System.EventHandler(this.toolStripMenuItemSearchRes_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonAbout.Text = "О программе";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // toolStripButtonClearInfo
            // 
            this.toolStripButtonClearInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClearInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearInfo.Image")));
            this.toolStripButtonClearInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClearInfo.Name = "toolStripButtonClearInfo";
            this.toolStripButtonClearInfo.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonClearInfo.Text = "Очистить";
            this.toolStripButtonClearInfo.Click += new System.EventHandler(this.toolStripButtonClearInfo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDate,
            this.toolStripStatusLabelTime,
            this.toolStripStatusLabelLastAction,
            this.toolStripStatusLabelAction,
            this.toolStripStatusLabelObjectsAmount,
            this.toolStripStatusLabelAmount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 874);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1361, 29);
            this.statusStrip1.TabIndex = 41;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDate
            // 
            this.toolStripStatusLabelDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            this.toolStripStatusLabelDate.Size = new System.Drawing.Size(134, 23);
            this.toolStripStatusLabelDate.Text = "Текущее время:";
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(59, 23);
            this.toolStripStatusLabelTime.Text = "время";
            // 
            // toolStripStatusLabelLastAction
            // 
            this.toolStripStatusLabelLastAction.Name = "toolStripStatusLabelLastAction";
            this.toolStripStatusLabelLastAction.Size = new System.Drawing.Size(155, 23);
            this.toolStripStatusLabelLastAction.Text = "Последнее действие:";
            // 
            // toolStripStatusLabelAction
            // 
            this.toolStripStatusLabelAction.Name = "toolStripStatusLabelAction";
            this.toolStripStatusLabelAction.Size = new System.Drawing.Size(164, 23);
            this.toolStripStatusLabelAction.Text = "ничего не произошло";
            // 
            // toolStripStatusLabelObjectsAmount
            // 
            this.toolStripStatusLabelObjectsAmount.Name = "toolStripStatusLabelObjectsAmount";
            this.toolStripStatusLabelObjectsAmount.Size = new System.Drawing.Size(259, 23);
            this.toolStripStatusLabelObjectsAmount.Text = "Количество сохраненных объектов:";
            // 
            // toolStripStatusLabelAmount
            // 
            this.toolStripStatusLabelAmount.Name = "toolStripStatusLabelAmount";
            this.toolStripStatusLabelAmount.Size = new System.Drawing.Size(88, 23);
            this.toolStripStatusLabelAmount.Text = "количество";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButtonNotSalling);
            this.panel1.Controls.Add(this.radioButtonSalling);
            this.panel1.Location = new System.Drawing.Point(54, 755);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 40);
            this.panel1.TabIndex = 42;
            // 
            // radioButtonNotSalling
            // 
            this.radioButtonNotSalling.AutoSize = true;
            this.radioButtonNotSalling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonNotSalling.Location = new System.Drawing.Point(134, 3);
            this.radioButtonNotSalling.Name = "radioButtonNotSalling";
            this.radioButtonNotSalling.Size = new System.Drawing.Size(149, 24);
            this.radioButtonNotSalling.TabIndex = 1;
            this.radioButtonNotSalling.TabStop = true;
            this.radioButtonNotSalling.Text = "Не продается";
            this.radioButtonNotSalling.UseVisualStyleBackColor = true;
            this.radioButtonNotSalling.CheckedChanged += new System.EventHandler(this.radioButtonNotSalling_CheckedChanged);
            // 
            // radioButtonSalling
            // 
            this.radioButtonSalling.AutoSize = true;
            this.radioButtonSalling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonSalling.Location = new System.Drawing.Point(3, 3);
            this.radioButtonSalling.Name = "radioButtonSalling";
            this.radioButtonSalling.Size = new System.Drawing.Size(124, 24);
            this.radioButtonSalling.TabIndex = 0;
            this.radioButtonSalling.TabStop = true;
            this.radioButtonSalling.Text = "Продается";
            this.radioButtonSalling.UseVisualStyleBackColor = true;
            this.radioButtonSalling.CheckedChanged += new System.EventHandler(this.radioButtonSalling_CheckedChanged);
            // 
            // labelStateFlat
            // 
            this.labelStateFlat.AutoSize = true;
            this.labelStateFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelStateFlat.Location = new System.Drawing.Point(273, 225);
            this.labelStateFlat.Name = "labelStateFlat";
            this.labelStateFlat.Size = new System.Drawing.Size(191, 20);
            this.labelStateFlat.TabIndex = 35;
            this.labelStateFlat.Text = "Состояние квартиры:";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelState.Location = new System.Drawing.Point(273, 250);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(0, 25);
            this.labelState.TabIndex = 36;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton1.Location = new System.Drawing.Point(289, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(130, 24);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "На ремонте";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonRepair
            // 
            this.buttonRepair.BackColor = System.Drawing.Color.LightGreen;
            this.buttonRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonRepair.Location = new System.Drawing.Point(257, 599);
            this.buttonRepair.Name = "buttonRepair";
            this.buttonRepair.Size = new System.Drawing.Size(114, 28);
            this.buttonRepair.TabIndex = 43;
            this.buttonRepair.Text = "Ремонт";
            this.buttonRepair.UseVisualStyleBackColor = false;
            this.buttonRepair.Click += new System.EventHandler(this.buttonRepair_Click);
            // 
            // FlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1361, 903);
            this.Controls.Add(this.buttonRepair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonSortSave);
            this.Controls.Add(this.buttonSearchSave);
            this.Controls.Add(this.textBoxSorted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearched);
            this.Controls.Add(this.labelBucks);
            this.Controls.Add(this.buttonAutoFill);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.labelCostFlat);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClearInfo);
            this.Controls.Add(this.textBoxFlatInfo);
            this.Controls.Add(this.buttonOutputFlatInfo);
            this.Controls.Add(this.numericUpDownRooms);
            this.Controls.Add(this.groupBoxAddress);
            this.Controls.Add(this.numericUpDownFloor);
            this.Controls.Add(this.labelFloor);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.dateTimePickerYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.trackBarFootage);
            this.Controls.Add(this.checkBoxBasement);
            this.Controls.Add(this.checkBoxBalcony);
            this.Controls.Add(this.checkBoxBathroom);
            this.Controls.Add(this.checkBoxLivingRoom);
            this.Controls.Add(this.checkBoxKitchen);
            this.Controls.Add(this.labelRooms);
            this.Controls.Add(this.labelFootage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FlatForm";
            this.Text = "Квартира";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFootage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloor)).EndInit();
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRooms)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFootage;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.CheckBox checkBoxKitchen;
        private System.Windows.Forms.CheckBox checkBoxLivingRoom;
        private System.Windows.Forms.CheckBox checkBoxBathroom;
        private System.Windows.Forms.CheckBox checkBoxBalcony;
        private System.Windows.Forms.CheckBox checkBoxBasement;
        private System.Windows.Forms.TrackBar trackBarFootage;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.DateTimePicker dateTimePickerYear;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.NumericUpDown numericUpDownFloor;
        private System.Windows.Forms.GroupBox groupBoxAddress;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.TreeView treeViewCountry;
        private System.Windows.Forms.Label labelFlatNumber;
        private System.Windows.Forms.Label labelHouse;
        private System.Windows.Forms.NumericUpDown numericUpDownRooms;
        private System.Windows.Forms.Button buttonOutputFlatInfo;
        private System.Windows.Forms.TextBox textBoxFlatInfo;
        private System.Windows.Forms.Button buttonClearInfo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCostFlat;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Button buttonAutoFill;
        private System.Windows.Forms.TextBox textBoxNumberFlat;
        private System.Windows.Forms.TextBox textBoxNumberHouse;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelBucks;
        public System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortYear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortFootage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortPrice;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearchYear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearchDistrict;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearchAmountRooms;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxSearched;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxSorted;
        private System.Windows.Forms.Button buttonSearchSave;
        private System.Windows.Forms.Button buttonSortSave;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveResult;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSortResult;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSearchResult;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemYearSear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDistrictSear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRoomsSear;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonSort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemYear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFootage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPrice;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortRes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearchRes;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearInfo;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHideTool;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLastAction;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAction;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelObjectsAmount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonNotSalling;
        private System.Windows.Forms.RadioButton radioButtonSalling;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelStateFlat;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonRepair;
    }
}

