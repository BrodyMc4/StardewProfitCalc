namespace StardewValleyCalculator
{
    partial class StardewValleyCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StardewValleyCalculator));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEnterCrop = new System.Windows.Forms.Label();
            this.txtEnterCrop = new System.Windows.Forms.TextBox();
            this.lblSeedNumber = new System.Windows.Forms.Label();
            this.txtSeedNumber = new System.Windows.Forms.TextBox();
            this.lblFarmingLvl = new System.Windows.Forms.Label();
            this.lblFertilizer = new System.Windows.Forms.Label();
            this.lblCostPerSeed = new System.Windows.Forms.Label();
            this.txtCostPerSeed = new System.Windows.Forms.TextBox();
            this.btnCalculateProfit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMinProfit = new System.Windows.Forms.TextBox();
            this.txtMaxProfit = new System.Windows.Forms.TextBox();
            this.txtAvgProfit = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtFertilizer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTiller = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.txtProcessed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbKeg = new System.Windows.Forms.CheckBox();
            this.cbPreserves = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbFarmingLvl = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(279, 150);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 39);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblEnterCrop
            // 
            this.lblEnterCrop.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterCrop.Font = new System.Drawing.Font("Stardew Valley", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCrop.ForeColor = System.Drawing.Color.White;
            this.lblEnterCrop.Location = new System.Drawing.Point(373, 12);
            this.lblEnterCrop.Name = "lblEnterCrop";
            this.lblEnterCrop.Size = new System.Drawing.Size(169, 37);
            this.lblEnterCrop.TabIndex = 2;
            this.lblEnterCrop.Text = "Enter Crop:";
            this.lblEnterCrop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEnterCrop.UseCompatibleTextRendering = true;
            this.lblEnterCrop.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEnterCrop
            // 
            this.txtEnterCrop.BackColor = System.Drawing.Color.SteelBlue;
            this.txtEnterCrop.Font = new System.Drawing.Font("Stardew Valley", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterCrop.ForeColor = System.Drawing.Color.White;
            this.txtEnterCrop.Location = new System.Drawing.Point(557, 12);
            this.txtEnterCrop.Name = "txtEnterCrop";
            this.txtEnterCrop.Size = new System.Drawing.Size(270, 37);
            this.txtEnterCrop.TabIndex = 3;
            this.txtEnterCrop.TextChanged += new System.EventHandler(this.txtEnterCrop_TextChanged);
            // 
            // lblSeedNumber
            // 
            this.lblSeedNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblSeedNumber.Font = new System.Drawing.Font("Stardew Valley", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeedNumber.ForeColor = System.Drawing.Color.White;
            this.lblSeedNumber.Location = new System.Drawing.Point(298, 65);
            this.lblSeedNumber.Name = "lblSeedNumber";
            this.lblSeedNumber.Size = new System.Drawing.Size(244, 37);
            this.lblSeedNumber.TabIndex = 4;
            this.lblSeedNumber.Text = "Number of Seeds:";
            this.lblSeedNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSeedNumber.UseCompatibleTextRendering = true;
            // 
            // txtSeedNumber
            // 
            this.txtSeedNumber.BackColor = System.Drawing.Color.SteelBlue;
            this.txtSeedNumber.Font = new System.Drawing.Font("Stardew Valley", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeedNumber.ForeColor = System.Drawing.Color.White;
            this.txtSeedNumber.Location = new System.Drawing.Point(557, 65);
            this.txtSeedNumber.Name = "txtSeedNumber";
            this.txtSeedNumber.Size = new System.Drawing.Size(270, 37);
            this.txtSeedNumber.TabIndex = 5;
            // 
            // lblFarmingLvl
            // 
            this.lblFarmingLvl.BackColor = System.Drawing.Color.Transparent;
            this.lblFarmingLvl.Font = new System.Drawing.Font("Stardew Valley", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarmingLvl.ForeColor = System.Drawing.Color.White;
            this.lblFarmingLvl.Location = new System.Drawing.Point(876, 15);
            this.lblFarmingLvl.Name = "lblFarmingLvl";
            this.lblFarmingLvl.Size = new System.Drawing.Size(204, 40);
            this.lblFarmingLvl.TabIndex = 6;
            this.lblFarmingLvl.Text = "Farming Level:";
            this.lblFarmingLvl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFarmingLvl.UseCompatibleTextRendering = true;
            // 
            // lblFertilizer
            // 
            this.lblFertilizer.BackColor = System.Drawing.Color.Transparent;
            this.lblFertilizer.CausesValidation = false;
            this.lblFertilizer.Font = new System.Drawing.Font("Stardew Valley", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFertilizer.ForeColor = System.Drawing.Color.White;
            this.lblFertilizer.Location = new System.Drawing.Point(930, 114);
            this.lblFertilizer.Name = "lblFertilizer";
            this.lblFertilizer.Size = new System.Drawing.Size(149, 37);
            this.lblFertilizer.TabIndex = 7;
            this.lblFertilizer.Text = "Fertilizer: ";
            this.lblFertilizer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFertilizer.UseCompatibleTextRendering = true;
            // 
            // lblCostPerSeed
            // 
            this.lblCostPerSeed.BackColor = System.Drawing.Color.Transparent;
            this.lblCostPerSeed.Font = new System.Drawing.Font("Stardew Valley", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostPerSeed.ForeColor = System.Drawing.Color.White;
            this.lblCostPerSeed.Location = new System.Drawing.Point(865, 66);
            this.lblCostPerSeed.Name = "lblCostPerSeed";
            this.lblCostPerSeed.Size = new System.Drawing.Size(215, 37);
            this.lblCostPerSeed.TabIndex = 10;
            this.lblCostPerSeed.Text = "Cost Per Seed:";
            this.lblCostPerSeed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCostPerSeed.UseCompatibleTextRendering = true;
            // 
            // txtCostPerSeed
            // 
            this.txtCostPerSeed.BackColor = System.Drawing.Color.SteelBlue;
            this.txtCostPerSeed.Font = new System.Drawing.Font("Stardew Valley", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostPerSeed.ForeColor = System.Drawing.Color.White;
            this.txtCostPerSeed.Location = new System.Drawing.Point(1086, 63);
            this.txtCostPerSeed.Name = "txtCostPerSeed";
            this.txtCostPerSeed.Size = new System.Drawing.Size(80, 37);
            this.txtCostPerSeed.TabIndex = 11;
            this.txtCostPerSeed.TextChanged += new System.EventHandler(this.txtCostPerSeed_TextChanged);
            // 
            // btnCalculateProfit
            // 
            this.btnCalculateProfit.BackColor = System.Drawing.Color.White;
            this.btnCalculateProfit.Font = new System.Drawing.Font("Stardew Valley", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateProfit.Location = new System.Drawing.Point(27, 517);
            this.btnCalculateProfit.Name = "btnCalculateProfit";
            this.btnCalculateProfit.Size = new System.Drawing.Size(167, 59);
            this.btnCalculateProfit.TabIndex = 12;
            this.btnCalculateProfit.Text = "Calculate Profit";
            this.btnCalculateProfit.UseVisualStyleBackColor = false;
            this.btnCalculateProfit.Click += new System.EventHandler(this.btnCalculateProfit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Stardew Valley", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(804, 517);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 59);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMinProfit
            // 
            this.txtMinProfit.BackColor = System.Drawing.Color.SteelBlue;
            this.txtMinProfit.Font = new System.Drawing.Font("Stardew Valley", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinProfit.ForeColor = System.Drawing.Color.White;
            this.txtMinProfit.Location = new System.Drawing.Point(9, 350);
            this.txtMinProfit.Name = "txtMinProfit";
            this.txtMinProfit.ReadOnly = true;
            this.txtMinProfit.Size = new System.Drawing.Size(270, 37);
            this.txtMinProfit.TabIndex = 14;
            this.txtMinProfit.TextChanged += new System.EventHandler(this.txtMinProfit_TextChanged);
            // 
            // txtMaxProfit
            // 
            this.txtMaxProfit.BackColor = System.Drawing.Color.SteelBlue;
            this.txtMaxProfit.Font = new System.Drawing.Font("Stardew Valley", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxProfit.ForeColor = System.Drawing.Color.White;
            this.txtMaxProfit.Location = new System.Drawing.Point(611, 350);
            this.txtMaxProfit.Name = "txtMaxProfit";
            this.txtMaxProfit.ReadOnly = true;
            this.txtMaxProfit.Size = new System.Drawing.Size(270, 37);
            this.txtMaxProfit.TabIndex = 15;
            this.txtMaxProfit.TextChanged += new System.EventHandler(this.txtMaxProfit_TextChanged);
            // 
            // txtAvgProfit
            // 
            this.txtAvgProfit.BackColor = System.Drawing.Color.SteelBlue;
            this.txtAvgProfit.Font = new System.Drawing.Font("Stardew Valley", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgProfit.ForeColor = System.Drawing.Color.White;
            this.txtAvgProfit.Location = new System.Drawing.Point(310, 350);
            this.txtAvgProfit.Name = "txtAvgProfit";
            this.txtAvgProfit.ReadOnly = true;
            this.txtAvgProfit.Size = new System.Drawing.Size(270, 37);
            this.txtAvgProfit.TabIndex = 16;
            this.txtAvgProfit.TextChanged += new System.EventHandler(this.txtAvgProfit_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Stardew Valley", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(286, 517);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(167, 59);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear Results";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtFertilizer
            // 
            this.txtFertilizer.BackColor = System.Drawing.Color.SteelBlue;
            this.txtFertilizer.Font = new System.Drawing.Font("Stardew Valley", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFertilizer.ForeColor = System.Drawing.Color.White;
            this.txtFertilizer.Location = new System.Drawing.Point(1085, 114);
            this.txtFertilizer.Name = "txtFertilizer";
            this.txtFertilizer.Size = new System.Drawing.Size(80, 37);
            this.txtFertilizer.TabIndex = 19;
            this.txtFertilizer.TextChanged += new System.EventHandler(this.txtFertilizer_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Stardew Valley", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(879, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 92);
            this.label1.TabIndex = 20;
            this.label1.Text = "Note: Enter value based off key: No fertilizer is 0, Basic is 1, Quality is 2, an" +
    "d Deluxe is 3.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // cbTiller
            // 
            this.cbTiller.BackColor = System.Drawing.Color.Transparent;
            this.cbTiller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTiller.Font = new System.Drawing.Font("Stardew Valley", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTiller.ForeColor = System.Drawing.Color.White;
            this.cbTiller.Location = new System.Drawing.Point(298, 201);
            this.cbTiller.Name = "cbTiller";
            this.cbTiller.Size = new System.Drawing.Size(458, 45);
            this.cbTiller.TabIndex = 21;
            this.cbTiller.Text = "Tiller Proffesion Chosen";
            this.cbTiller.UseVisualStyleBackColor = false;
            this.cbTiller.CheckedChanged += new System.EventHandler(this.cbTiller_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stardew Valley", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 77);
            this.label2.TabIndex = 22;
            this.label2.Text = "Minimum Possible Profit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Stardew Valley", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(304, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 74);
            this.label3.TabIndex = 23;
            this.label3.Text = "Average Profit   (Per Harvest)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Stardew Valley", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(603, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 77);
            this.label4.TabIndex = 24;
            this.label4.Text = "Maximum Possible Profit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.White;
            this.btnClearAll.Font = new System.Drawing.Font("Stardew Valley", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(545, 517);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(167, 59);
            this.btnClearAll.TabIndex = 25;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // txtProcessed
            // 
            this.txtProcessed.BackColor = System.Drawing.Color.SteelBlue;
            this.txtProcessed.Font = new System.Drawing.Font("Stardew Valley", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcessed.ForeColor = System.Drawing.Color.White;
            this.txtProcessed.Location = new System.Drawing.Point(918, 350);
            this.txtProcessed.Name = "txtProcessed";
            this.txtProcessed.ReadOnly = true;
            this.txtProcessed.Size = new System.Drawing.Size(270, 37);
            this.txtProcessed.TabIndex = 26;
            this.txtProcessed.TextChanged += new System.EventHandler(this.txtProcessed_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Stardew Valley", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(918, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 34);
            this.label5.TabIndex = 27;
            this.label5.Text = "Processed Profit";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // cbKeg
            // 
            this.cbKeg.BackColor = System.Drawing.Color.Transparent;
            this.cbKeg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbKeg.Font = new System.Drawing.Font("Stardew Valley", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKeg.ForeColor = System.Drawing.Color.White;
            this.cbKeg.Location = new System.Drawing.Point(298, 111);
            this.cbKeg.Name = "cbKeg";
            this.cbKeg.Size = new System.Drawing.Size(458, 45);
            this.cbKeg.TabIndex = 28;
            this.cbKeg.Text = "Crops Will Be Processed via Keg";
            this.cbKeg.UseVisualStyleBackColor = false;
            this.cbKeg.CheckedChanged += new System.EventHandler(this.cbKeg_CheckedChanged);
            // 
            // cbPreserves
            // 
            this.cbPreserves.BackColor = System.Drawing.Color.Transparent;
            this.cbPreserves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPreserves.Font = new System.Drawing.Font("Stardew Valley", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPreserves.ForeColor = System.Drawing.Color.White;
            this.cbPreserves.Location = new System.Drawing.Point(298, 156);
            this.cbPreserves.Name = "cbPreserves";
            this.cbPreserves.Size = new System.Drawing.Size(458, 45);
            this.cbPreserves.TabIndex = 29;
            this.cbPreserves.Text = "Crops Will Be Processed via Preserves Jar";
            this.cbPreserves.UseVisualStyleBackColor = false;
            this.cbPreserves.CheckedChanged += new System.EventHandler(this.cbPreserves_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(988, 468);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 38);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cmbFarmingLvl
            // 
            this.cmbFarmingLvl.BackColor = System.Drawing.Color.SteelBlue;
            this.cmbFarmingLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFarmingLvl.Font = new System.Drawing.Font("Stardew Valley", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFarmingLvl.ForeColor = System.Drawing.Color.White;
            this.cmbFarmingLvl.FormattingEnabled = true;
            this.cmbFarmingLvl.Location = new System.Drawing.Point(1085, 16);
            this.cmbFarmingLvl.Name = "cmbFarmingLvl";
            this.cmbFarmingLvl.Size = new System.Drawing.Size(81, 33);
            this.cmbFarmingLvl.TabIndex = 31;
            this.cmbFarmingLvl.SelectedIndexChanged += new System.EventHandler(this.cmbFarmingLvl_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("Stardew Valley", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(977, 503);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(222, 84);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(997, 421);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 49);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // StardewValleyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1196, 588);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cmbFarmingLvl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbPreserves);
            this.Controls.Add(this.cbKeg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProcessed);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTiller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFertilizer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtAvgProfit);
            this.Controls.Add(this.txtMaxProfit);
            this.Controls.Add(this.txtMinProfit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateProfit);
            this.Controls.Add(this.txtCostPerSeed);
            this.Controls.Add(this.lblCostPerSeed);
            this.Controls.Add(this.lblFertilizer);
            this.Controls.Add(this.lblFarmingLvl);
            this.Controls.Add(this.txtSeedNumber);
            this.Controls.Add(this.lblSeedNumber);
            this.Controls.Add(this.txtEnterCrop);
            this.Controls.Add(this.lblEnterCrop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbLogo);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1212, 627);
            this.MinimumSize = new System.Drawing.Size(1212, 627);
            this.Name = "StardewValleyCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stardew Valley Profit Crop Calculator ";
            this.Load += new System.EventHandler(this.StardewValleyCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEnterCrop;
        private System.Windows.Forms.TextBox txtEnterCrop;
        private System.Windows.Forms.Label lblSeedNumber;
        private System.Windows.Forms.TextBox txtSeedNumber;
        private System.Windows.Forms.Label lblFarmingLvl;
        private System.Windows.Forms.Label lblFertilizer;
        private System.Windows.Forms.Label lblCostPerSeed;
        private System.Windows.Forms.TextBox txtCostPerSeed;
        private System.Windows.Forms.Button btnCalculateProfit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMinProfit;
        private System.Windows.Forms.TextBox txtMaxProfit;
        private System.Windows.Forms.TextBox txtAvgProfit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtFertilizer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbTiller;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.TextBox txtProcessed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbKeg;
        private System.Windows.Forms.CheckBox cbPreserves;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbFarmingLvl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

