namespace greenByte.Pages
{
    partial class MoistureControlPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // Başlık paneli
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();

            // Ana içerik paneli
            this.panelContent = new System.Windows.Forms.Panel();

            // Nem ayarları paneli
            this.panelHumiditySettings = new System.Windows.Forms.Panel();
            this.labelHumiditySettingsTitle = new System.Windows.Forms.Label();
            this.labelDesiredHumidity = new System.Windows.Forms.Label();
            this.trackBarHumidity = new System.Windows.Forms.TrackBar();
            this.labelMinHumidity = new System.Windows.Forms.Label();
            this.labelMaxHumidity = new System.Windows.Forms.Label();
            this.labelAutoControl = new System.Windows.Forms.Label();
            this.switchAutoControl = new System.Windows.Forms.CheckBox();

            // Minimum nem paneli
            this.panelMinHumidity = new System.Windows.Forms.Panel();
            this.labelMinHumidityTitle = new System.Windows.Forms.Label();
            this.numericMinHumidity = new System.Windows.Forms.NumericUpDown();
            this.labelMinHumidityPercent = new System.Windows.Forms.Label();

            // Maksimum nem paneli
            this.panelMaxHumidity = new System.Windows.Forms.Panel();
            this.labelMaxHumidityTitle = new System.Windows.Forms.Label();
            this.numericMaxHumidity = new System.Windows.Forms.NumericUpDown();
            this.labelMaxHumidityPercent = new System.Windows.Forms.Label();

            // Nem programları paneli
            this.panelHumidityPrograms = new System.Windows.Forms.Panel();
            this.labelHumidityProgramsTitle = new System.Windows.Forms.Label();
            this.panelProgram1 = new System.Windows.Forms.Panel();
            this.radioProgram1 = new System.Windows.Forms.RadioButton();
            this.labelProgram1 = new System.Windows.Forms.Label();
            this.panelProgram2 = new System.Windows.Forms.Panel();
            this.radioProgram2 = new System.Windows.Forms.RadioButton();
            this.labelProgram2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();

            // Mevcut nem paneli
            this.panelCurrentHumidity = new System.Windows.Forms.Panel();
            this.labelCurrentHumidityTitle = new System.Windows.Forms.Label();
            this.labelCurrentHumidityValue = new System.Windows.Forms.Label();
            this.labelLastUpdate = new System.Windows.Forms.Label();

            // Hızlı kontrol paneli
            this.panelQuickControls = new System.Windows.Forms.Panel();
            this.labelQuickControlsTitle = new System.Windows.Forms.Label();
            this.btnProgram1 = new System.Windows.Forms.Button();
            this.btnProgram2 = new System.Windows.Forms.Button();
            this.btnProgramGeneral = new System.Windows.Forms.Button();

            // Designer init
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelHumiditySettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHumidity)).BeginInit();
            this.panelMinHumidity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinHumidity)).BeginInit();
            this.panelMaxHumidity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxHumidity)).BeginInit();
            this.panelHumidityPrograms.SuspendLayout();
            this.panelProgram1.SuspendLayout();
            this.panelProgram2.SuspendLayout();
            this.panelCurrentHumidity.SuspendLayout();
            this.panelQuickControls.SuspendLayout();
            this.SuspendLayout();

            // panelHeader - Başlık paneli
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 60);
            this.panelHeader.TabIndex = 0;

            // labelTitle - Ana başlık
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(0, 100, 0);
            this.labelTitle.Location = new System.Drawing.Point(20, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(150, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Nem Kontrolü";

            // panelContent - Ana içerik paneli
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.Location = new System.Drawing.Point(20, 70);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(960, 510);
            this.panelContent.TabIndex = 1;

            // panelHumiditySettings - Nem ayarları paneli
            this.panelHumiditySettings.BackColor = System.Drawing.Color.White;
            this.panelHumiditySettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHumiditySettings.Location = new System.Drawing.Point(20, 20);
            this.panelHumiditySettings.Name = "panelHumiditySettings";
            this.panelHumiditySettings.Size = new System.Drawing.Size(550, 220);
            this.panelHumiditySettings.TabIndex = 0;

            // labelHumiditySettingsTitle - Nem ayarları başlığı
            this.labelHumiditySettingsTitle.AutoSize = true;
            this.labelHumiditySettingsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelHumiditySettingsTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.labelHumiditySettingsTitle.Location = new System.Drawing.Point(15, 15);
            this.labelHumiditySettingsTitle.Name = "labelHumiditySettingsTitle";
            this.labelHumiditySettingsTitle.Size = new System.Drawing.Size(115, 21);
            this.labelHumiditySettingsTitle.TabIndex = 0;
            this.labelHumiditySettingsTitle.Text = "Nem Ayarları";

            // labelDesiredHumidity - İstenen nem etiketi
            this.labelDesiredHumidity.AutoSize = true;
            this.labelDesiredHumidity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelDesiredHumidity.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.labelDesiredHumidity.Location = new System.Drawing.Point(15, 50);
            this.labelDesiredHumidity.Name = "labelDesiredHumidity";
            this.labelDesiredHumidity.Size = new System.Drawing.Size(137, 20);
            this.labelDesiredHumidity.TabIndex = 1;
            this.labelDesiredHumidity.Text = "İstenen Nem Oranı: 65%";

            // trackBarHumidity - Nem ayar çubuğu
            this.trackBarHumidity.Location = new System.Drawing.Point(15, 80);
            this.trackBarHumidity.Maximum = 90;
            this.trackBarHumidity.Minimum = 40;
            this.trackBarHumidity.Name = "trackBarHumidity";
            this.trackBarHumidity.Size = new System.Drawing.Size(500, 45);
            this.trackBarHumidity.TabIndex = 2;
            this.trackBarHumidity.TickFrequency = 5;
            this.trackBarHumidity.Value = 65;

            // labelMinHumidity - Minimum nem etiketi
            this.labelMinHumidity.AutoSize = true;
            this.labelMinHumidity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelMinHumidity.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.labelMinHumidity.Location = new System.Drawing.Point(15, 120);
            this.labelMinHumidity.Name = "labelMinHumidity";
            this.labelMinHumidity.Size = new System.Drawing.Size(30, 15);
            this.labelMinHumidity.TabIndex = 3;
            this.labelMinHumidity.Text = "40%";

            // labelMaxHumidity - Maksimum nem etiketi
            this.labelMaxHumidity.AutoSize = true;
            this.labelMaxHumidity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelMaxHumidity.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.labelMaxHumidity.Location = new System.Drawing.Point(485, 120);
            this.labelMaxHumidity.Name = "labelMaxHumidity";
            this.labelMaxHumidity.Size = new System.Drawing.Size(30, 15);
            this.labelMaxHumidity.TabIndex = 4;
            this.labelMaxHumidity.Text = "90%";

            // labelAutoControl - Otomatik kontrol etiketi
            this.labelAutoControl.AutoSize = true;
            this.labelAutoControl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelAutoControl.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.labelAutoControl.Location = new System.Drawing.Point(15, 165);
            this.labelAutoControl.Name = "labelAutoControl";
            this.labelAutoControl.Size = new System.Drawing.Size(150, 20);
            this.labelAutoControl.TabIndex = 5;
            this.labelAutoControl.Text = "Otomatik Nem Kontrolü";

            // switchAutoControl - Otomatik kontrol switch'i
            this.switchAutoControl.Appearance = System.Windows.Forms.Appearance.Button;
            this.switchAutoControl.AutoSize = true;
            this.switchAutoControl.Checked = true;
            this.switchAutoControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.switchAutoControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchAutoControl.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.switchAutoControl.ForeColor = System.Drawing.Color.White;
            this.switchAutoControl.Location = new System.Drawing.Point(475, 165);
            this.switchAutoControl.Name = "switchAutoControl";
            this.switchAutoControl.Size = new System.Drawing.Size(40, 25);
            this.switchAutoControl.TabIndex = 6;

            // panelMinHumidity - Minimum nem paneli
            this.panelMinHumidity.BackColor = System.Drawing.Color.White;
            this.panelMinHumidity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMinHumidity.Location = new System.Drawing.Point(20, 260);
            this.panelMinHumidity.Name = "panelMinHumidity";
            this.panelMinHumidity.Size = new System.Drawing.Size(260, 100);
            this.panelMinHumidity.TabIndex = 1;

            // labelMinHumidityTitle - Minimum nem başlığı
            this.labelMinHumidityTitle.AutoSize = true;
            this.labelMinHumidityTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelMinHumidityTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.labelMinHumidityTitle.Location = new System.Drawing.Point(15, 15);
            this.labelMinHumidityTitle.Name = "labelMinHumidityTitle";
            this.labelMinHumidityTitle.Size = new System.Drawing.Size(100, 20);
            this.labelMinHumidityTitle.TabIndex = 0;
            this.labelMinHumidityTitle.Text = "Minimum Nem";

            // numericMinHumidity - Minimum nem seçici
            this.numericMinHumidity.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.numericMinHumidity.Location = new System.Drawing.Point(35, 45);
            this.numericMinHumidity.Maximum = new decimal(new int[] { 70, 0, 0, 0 });
            this.numericMinHumidity.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            this.numericMinHumidity.Name = "numericMinHumidity";
            this.numericMinHumidity.Size = new System.Drawing.Size(120, 32);
            this.numericMinHumidity.TabIndex = 1;
            this.numericMinHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericMinHumidity.Value = new decimal(new int[] { 55, 0, 0, 0 });

            // labelMinHumidityPercent - Minimum nem yüzde işareti
            this.labelMinHumidityPercent.AutoSize = true;
            this.labelMinHumidityPercent.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelMinHumidityPercent.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.labelMinHumidityPercent.Location = new System.Drawing.Point(165, 47);
            this.labelMinHumidityPercent.Name = "labelMinHumidityPercent";
            this.labelMinHumidityPercent.Size = new System.Drawing.Size(28, 25);
            this.labelMinHumidityPercent.TabIndex = 2;
            this.labelMinHumidityPercent.Text = "%";

            // panelMaxHumidity - Maksimum nem paneli
            this.panelMaxHumidity.BackColor = System.Drawing.Color.White;
            this.panelMaxHumidity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMaxHumidity.Location = new System.Drawing.Point(310, 260);
            this.panelMaxHumidity.Name = "panelMaxHumidity";
            this.panelMaxHumidity.Size = new System.Drawing.Size(260, 100);
            this.panelMaxHumidity.TabIndex = 2;

            // labelMaxHumidityTitle - Maksimum nem başlığı
            this.labelMaxHumidityTitle.AutoSize = true;
            this.labelMaxHumidityTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelMaxHumidityTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.labelMaxHumidityTitle.Location = new System.Drawing.Point(15, 15);
            this.labelMaxHumidityTitle.Name = "labelMaxHumidityTitle";
            this.labelMaxHumidityTitle.Size = new System.Drawing.Size(104, 20);
            this.labelMaxHumidityTitle.TabIndex = 0;
            this.labelMaxHumidityTitle.Text = "Maksimum Nem";

            // numericMaxHumidity - Maksimum nem seçici
            this.numericMaxHumidity.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.numericMaxHumidity.Location = new System.Drawing.Point(35, 45);
            this.numericMaxHumidity.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            this.numericMaxHumidity.Minimum = new decimal(new int[] { 60, 0, 0, 0 });
            this.numericMaxHumidity.Name = "numericMaxHumidity";
            this.numericMaxHumidity.Size = new System.Drawing.Size(120, 32);
            this.numericMaxHumidity.TabIndex = 1;
            this.numericMaxHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericMaxHumidity.Value = new decimal(new int[] { 75, 0, 0, 0 });

            // labelMaxHumidityPercent - Maksimum nem yüzde işareti
            this.labelMaxHumidityPercent.AutoSize = true;
            this.labelMaxHumidityPercent.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelMaxHumidityPercent.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.labelMaxHumidityPercent.Location = new System.Drawing.Point(165, 47);
            this.labelMaxHumidityPercent.Name = "labelMaxHumidityPercent";
            this.labelMaxHumidityPercent.Size = new System.Drawing.Size(28, 25);
            this.labelMaxHumidityPercent.TabIndex = 2;
            this.labelMaxHumidityPercent.Text = "%";

            // panelHumidityPrograms - Nem programları paneli
            this.panelHumidityPrograms.BackColor = System.Drawing.Color.White;
            this.panelHumidityPrograms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHumidityPrograms.Location = new System.Drawing.Point(20, 380);
            this.panelHumidityPrograms.Name = "panelHumidityPrograms";
            this.panelHumidityPrograms.Size = new System.Drawing.Size(550, 110);
            this.panelHumidityPrograms.TabIndex = 3;

            // labelHumidityProgramsTitle - Nem programları başlığı
            this.labelHumidityProgramsTitle.AutoSize = true;
            this.labelHumidityProgramsTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelHumidityProgramsTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.labelHumidityProgramsTitle.Location = new System.Drawing.Point(15, 15);
            this.labelHumidityProgramsTitle.Name = "labelHumidityProgramsTitle";
            this.labelHumidityProgramsTitle.Size = new System.Drawing.Size(115, 20);
            this.labelHumidityProgramsTitle.TabIndex = 0;
            this.labelHumidityProgramsTitle.Text = "Nem Programları";

            // panelProgram1 - Program 1 paneli
            this.panelProgram1.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.panelProgram1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProgram1.Location = new System.Drawing.Point(20, 45);
            this.panelProgram1.Name = "panelProgram1";
            this.panelProgram1.Size = new System.Drawing.Size(240, 40);
            this.panelProgram1.TabIndex = 1;

            // radioProgram1 - Program 1 radio butonu
            this.radioProgram1.AutoSize = true;
            this.radioProgram1.Checked = true;
            this.radioProgram1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.radioProgram1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.radioProgram1.Location = new System.Drawing.Point(10, 9);
            this.radioProgram1.Name = "radioProgram1";
            this.radioProgram1.Size = new System.Drawing.Size(14, 13);
            this.radioProgram1.TabIndex = 0;
            this.radioProgram1.TabStop = true;
            this.radioProgram1.UseVisualStyleBackColor = true;

            // labelProgram1 - Program 1 etiketi
            this.labelProgram1.AutoSize = true;
            this.labelProgram1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelProgram1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.labelProgram1.Location = new System.Drawing.Point(30, 9);
            this.labelProgram1.Name = "labelProgram1";
            this.labelProgram1.Size = new System.Drawing.Size(131, 17);
            this.labelProgram1.TabIndex = 1;
            this.labelProgram1.Text = "Çeri Domates (70%)";

            // panelProgram2 - Program 2 paneli
            this.panelProgram2.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.panelProgram2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProgram2.Location = new System.Drawing.Point(270, 45);
            this.panelProgram2.Name = "panelProgram2";
            this.panelProgram2.Size = new System.Drawing.Size(240, 40);
            this.panelProgram2.TabIndex = 2;

            // radioProgram2 - Program 2 radio butonu
            this.radioProgram2.AutoSize = true;
            this.radioProgram2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.radioProgram2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.radioProgram2.Location = new System.Drawing.Point(10, 9);
            this.radioProgram2.Name = "radioProgram2";
            this.radioProgram2.Size = new System.Drawing.Size(14, 13);
            this.radioProgram2.TabIndex = 0;
            this.radioProgram2.UseVisualStyleBackColor = true;

            // labelProgram2 - Program 2 etiketi
            this.labelProgram2.AutoSize = true;
            this.labelProgram2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelProgram2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.labelProgram2.Location = new System.Drawing.Point(30, 9);
            this.labelProgram2.Name = "labelProgram2";
            this.labelProgram2.Size = new System.Drawing.Size(102, 17);
            this.labelProgram2.TabIndex = 1;
            this.labelProgram2.Text = "Menekşe (55%)";

            // btnSave - Kaydet butonu
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(430, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;

            // panelCurrentHumidity - Mevcut nem paneli
            this.panelCurrentHumidity.BackColor = System.Drawing.Color.White;
            this.panelCurrentHumidity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurrentHumidity.Location = new System.Drawing.Point(590, 20);
            this.panelCurrentHumidity.Name = "panelCurrentHumidity";
            this.panelCurrentHumidity.Size = new System.Drawing.Size(350, 220);
            this.panelCurrentHumidity.TabIndex = 4;

            // labelCurrentHumidityTitle - Mevcut nem başlığı
            this.labelCurrentHumidityTitle.AutoSize = true;
            this.labelCurrentHumidityTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelCurrentHumidityTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.labelCurrentHumidityTitle.Location = new System.Drawing.Point(15, 15);
            this.labelCurrentHumidityTitle.Name = "labelCurrentHumidityTitle";
            this.labelCurrentHumidityTitle.Size = new System.Drawing.Size(100, 21);
            this.labelCurrentHumidityTitle.TabIndex = 0;
            this.labelCurrentHumidityTitle.Text = "Mevcut Nem";

            // labelCurrentHumidityValue - Mevcut nem değeri
            this.labelCurrentHumidityValue.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.labelCurrentHumidityValue.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.labelCurrentHumidityValue.Location = new System.Drawing.Point(0, 80);
            this.labelCurrentHumidityValue.Name = "labelCurrentHumidityValue";
            this.labelCurrentHumidityValue.Size = new System.Drawing.Size(350, 86);
            this.labelCurrentHumidityValue.TabIndex = 1;
            this.labelCurrentHumidityValue.Text = "65%";
            this.labelCurrentHumidityValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelLastUpdate - Son güncelleme zamanı
            this.labelLastUpdate.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelLastUpdate.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.labelLastUpdate.Location = new System.Drawing.Point(0, 190);
            this.labelLastUpdate.Name = "labelLastUpdate";
            this.labelLastUpdate.Size = new System.Drawing.Size(350, 15);
            this.labelLastUpdate.TabIndex = 2;
            this.labelLastUpdate.Text = "Son Güncelleme: 03.05.2025 10:15";
            this.labelLastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelQuickControls - Hızlı kontrol paneli
            this.panelQuickControls.BackColor = System.Drawing.Color.White;
            this.panelQuickControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuickControls.Location = new System.Drawing.Point(590, 260);
            this.panelQuickControls.Name = "panelQuickControls";
            this.panelQuickControls.Size = new System.Drawing.Size(350, 230);
            this.panelQuickControls.TabIndex = 5;

            // labelQuickControlsTitle - Hızlı kontrol başlığı
            this.labelQuickControlsTitle.AutoSize = true;
            this.labelQuickControlsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelQuickControlsTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.labelQuickControlsTitle.Location = new System.Drawing.Point(15, 15);
            this.labelQuickControlsTitle.Name = "labelQuickControlsTitle";
            this.labelQuickControlsTitle.Size = new System.Drawing.Size(120, 21);
            this.labelQuickControlsTitle.TabIndex = 0;
            this.labelQuickControlsTitle.Text = "Hızlı Kontroller";

            // btnProgram1 - Program 1 butonu
            this.btnProgram1.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnProgram1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgram1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnProgram1.ForeColor = System.Drawing.Color.White;
            this.btnProgram1.Location = new System.Drawing.Point(25, 50);
            this.btnProgram1.Name = "btnProgram1";
            this.btnProgram1.Size = new System.Drawing.Size(300, 40);
            this.btnProgram1.TabIndex = 1;
            this.btnProgram1.Text = "Çeri Domates (70%)";
            this.btnProgram1.UseVisualStyleBackColor = false;

            // btnProgram2 - Program 2 butonu
            this.btnProgram2.BackColor = System.Drawing.Color.White;
            this.btnProgram2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgram2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnProgram2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.btnProgram2.Location = new System.Drawing.Point(25, 110);
            this.btnProgram2.Name = "btnProgram2";
            this.btnProgram2.Size = new System.Drawing.Size(300, 40);
            this.btnProgram2.TabIndex = 2;
            this.btnProgram2.Text = "Menekşe (55%)";
            this.btnProgram2.UseVisualStyleBackColor = true;

            // btnProgramGeneral - Genel program butonu
            this.btnProgramGeneral.BackColor = System.Drawing.Color.White;
            this.btnProgramGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramGeneral.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnProgramGeneral.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.btnProgramGeneral.Location = new System.Drawing.Point(25, 170);
            this.btnProgramGeneral.Name = "btnProgramGeneral";
            this.btnProgramGeneral.Size = new System.Drawing.Size(300, 40);
            this.btnProgramGeneral.TabIndex = 3;
            this.btnProgramGeneral.Text = "Genel (60%)";
            this.btnProgramGeneral.UseVisualStyleBackColor = true;

            // Ana kontrol - panellerin birleştirilmesi
            this.panelHumiditySettings.Controls.Add(this.labelHumiditySettingsTitle);
            this.panelHumiditySettings.Controls.Add(this.labelDesiredHumidity);
            this.panelHumiditySettings.Controls.Add(this.trackBarHumidity);
            this.panelHumiditySettings.Controls.Add(this.labelMinHumidity);
            this.panelHumiditySettings.Controls.Add(this.labelMaxHumidity);
            this.panelHumiditySettings.Controls.Add(this.labelAutoControl);
            this.panelHumiditySettings.Controls.Add(this.switchAutoControl);

            this.panelMinHumidity.Controls.Add(this.labelMinHumidityTitle);
            this.panelMinHumidity.Controls.Add(this.numericMinHumidity);
            this.panelMinHumidity.Controls.Add(this.labelMinHumidityPercent);

            this.panelMaxHumidity.Controls.Add(this.labelMaxHumidityTitle);
            this.panelMaxHumidity.Controls.Add(this.numericMaxHumidity);
            this.panelMaxHumidity.Controls.Add(this.labelMaxHumidityPercent);

            this.panelProgram1.Controls.Add(this.radioProgram1);
            this.panelProgram1.Controls.Add(this.labelProgram1);

            this.panelProgram2.Controls.Add(this.radioProgram2);
            this.panelProgram2.Controls.Add(this.labelProgram2);

            this.panelHumidityPrograms.Controls.Add(this.labelHumidityProgramsTitle);
            this.panelHumidityPrograms.Controls.Add(this.panelProgram1);
            this.panelHumidityPrograms.Controls.Add(this.panelProgram2);
            this.panelHumidityPrograms.Controls.Add(this.btnSave);

            this.panelCurrentHumidity.Controls.Add(this.labelCurrentHumidityTitle);
            this.panelCurrentHumidity.Controls.Add(this.labelCurrentHumidityValue);
            this.panelCurrentHumidity.Controls.Add(this.labelLastUpdate);

            this.panelQuickControls.Controls.Add(this.labelQuickControlsTitle);
            this.panelQuickControls.Controls.Add(this.btnProgram1);
            this.panelQuickControls.Controls.Add(this.btnProgram2);
            this.panelQuickControls.Controls.Add(this.btnProgramGeneral);

            this.panelContent.Controls.Add(this.panelHumiditySettings);
            this.panelContent.Controls.Add(this.panelMinHumidity);
            this.panelContent.Controls.Add(this.panelMaxHumidity);
            this.panelContent.Controls.Add(this.panelHumidityPrograms);
            this.panelContent.Controls.Add(this.panelCurrentHumidity);
            this.panelContent.Controls.Add(this.panelQuickControls);

            this.panelHeader.Controls.Add(this.labelTitle);

            // Ana panel kontrollerinin eklenmesi
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelContent);

            // HumidityControlPage
            this.Name = "HumidityControlPage";
            this.Size = new System.Drawing.Size(1000, 600);
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelHumiditySettings.ResumeLayout(false);
            this.panelHumiditySettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHumidity)).EndInit();
            this.panelMinHumidity.ResumeLayout(false);
            this.panelMinHumidity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinHumidity)).EndInit();
            this.panelMaxHumidity.ResumeLayout(false);
            this.panelMaxHumidity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxHumidity)).EndInit();
            this.panelHumidityPrograms.ResumeLayout(false);
            this.panelHumidityPrograms.PerformLayout();
            this.panelProgram1.ResumeLayout(false);
            this.panelProgram1.PerformLayout();
            this.panelProgram2.ResumeLayout(false);
            this.panelProgram2.PerformLayout();
            this.panelCurrentHumidity.ResumeLayout(false);
            this.panelCurrentHumidity.PerformLayout();
            this.panelQuickControls.ResumeLayout(false);
            this.panelQuickControls.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;

        private System.Windows.Forms.Panel panelContent;

        private System.Windows.Forms.Panel panelHumiditySettings;
        private System.Windows.Forms.Label labelHumiditySettingsTitle;
        private System.Windows.Forms.Label labelDesiredHumidity;
        private System.Windows.Forms.TrackBar trackBarHumidity;
        private System.Windows.Forms.Label labelMinHumidity;
        private System.Windows.Forms.Label labelMaxHumidity;
        private System.Windows.Forms.Label labelAutoControl;
        private System.Windows.Forms.CheckBox switchAutoControl;

        private System.Windows.Forms.Panel panelMinHumidity;
        private System.Windows.Forms.Label labelMinHumidityTitle;
        private System.Windows.Forms.NumericUpDown numericMinHumidity;
        private System.Windows.Forms.Label labelMinHumidityPercent;

        private System.Windows.Forms.Panel panelMaxHumidity;
        private System.Windows.Forms.Label labelMaxHumidityTitle;
        private System.Windows.Forms.NumericUpDown numericMaxHumidity;
        private System.Windows.Forms.Label labelMaxHumidityPercent;

        private System.Windows.Forms.Panel panelHumidityPrograms;
        private System.Windows.Forms.Label labelHumidityProgramsTitle;
        private System.Windows.Forms.Panel panelProgram1;
        private System.Windows.Forms.RadioButton radioProgram1;
        private System.Windows.Forms.Label labelProgram1;
        private System.Windows.Forms.Panel panelProgram2;
        private System.Windows.Forms.RadioButton radioProgram2;
        private System.Windows.Forms.Label labelProgram2;
        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.Panel panelCurrentHumidity;
        private System.Windows.Forms.Label labelCurrentHumidityTitle;
        private System.Windows.Forms.Label labelCurrentHumidityValue;
        private System.Windows.Forms.Label labelLastUpdate;

        private System.Windows.Forms.Panel panelQuickControls;
        private System.Windows.Forms.Label labelQuickControlsTitle;
        private System.Windows.Forms.Button btnProgram1;
        private System.Windows.Forms.Button btnProgram2;
        private System.Windows.Forms.Button btnProgramGeneral;
    }
}
