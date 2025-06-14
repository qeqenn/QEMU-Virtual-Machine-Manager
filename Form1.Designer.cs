namespace QEMU_Virtual_Machine_Manager
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Runbutton = new Button();
            Importbutton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            boardlabel = new Label();
            MachinetypeLabel = new Label();
            MachineType = new ComboBox();
            CPUModel = new ComboBox();
            label2 = new Label();
            CPUCores = new ComboBox();
            label3 = new Label();
            RAM = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            HDA = new TextBox();
            HDB = new TextBox();
            HDC = new TextBox();
            HDD = new TextBox();
            helpProvider1 = new HelpProvider();
            FLB = new TextBox();
            FLA = new TextBox();
            CDR = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Runbutton
            // 
            resources.ApplyResources(Runbutton, "Runbutton");
            Runbutton.Name = "Runbutton";
            Runbutton.UseCompatibleTextRendering = true;
            Runbutton.UseVisualStyleBackColor = true;
            Runbutton.Click += button1_Click;
            // 
            // Importbutton
            // 
            Importbutton.Cursor = Cursors.No;
            resources.ApplyResources(Importbutton, "Importbutton");
            Importbutton.Name = "Importbutton";
            Importbutton.UseCompatibleTextRendering = true;
            Importbutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // boardlabel
            // 
            resources.ApplyResources(boardlabel, "boardlabel");
            boardlabel.Name = "boardlabel";
            // 
            // MachinetypeLabel
            // 
            resources.ApplyResources(MachinetypeLabel, "MachinetypeLabel");
            MachinetypeLabel.Name = "MachinetypeLabel";
            MachinetypeLabel.Click += label2_Click;
            // 
            // MachineType
            // 
            MachineType.FormattingEnabled = true;
            MachineType.Items.AddRange(new object[] { resources.GetString("MachineType.Items"), resources.GetString("MachineType.Items1") });
            resources.ApplyResources(MachineType, "MachineType");
            MachineType.Name = "MachineType";
            // 
            // CPUModel
            // 
            CPUModel.FormattingEnabled = true;
            CPUModel.Items.AddRange(new object[] { resources.GetString("CPUModel.Items"), resources.GetString("CPUModel.Items1"), resources.GetString("CPUModel.Items2"), resources.GetString("CPUModel.Items3"), resources.GetString("CPUModel.Items4"), resources.GetString("CPUModel.Items5"), resources.GetString("CPUModel.Items6"), resources.GetString("CPUModel.Items7"), resources.GetString("CPUModel.Items8"), resources.GetString("CPUModel.Items9"), resources.GetString("CPUModel.Items10"), resources.GetString("CPUModel.Items11"), resources.GetString("CPUModel.Items12"), resources.GetString("CPUModel.Items13"), resources.GetString("CPUModel.Items14"), resources.GetString("CPUModel.Items15"), resources.GetString("CPUModel.Items16"), resources.GetString("CPUModel.Items17"), resources.GetString("CPUModel.Items18"), resources.GetString("CPUModel.Items19"), resources.GetString("CPUModel.Items20"), resources.GetString("CPUModel.Items21") });
            resources.ApplyResources(CPUModel, "CPUModel");
            CPUModel.Name = "CPUModel";
            CPUModel.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // CPUCores
            // 
            CPUCores.FormattingEnabled = true;
            CPUCores.Items.AddRange(new object[] { resources.GetString("CPUCores.Items"), resources.GetString("CPUCores.Items1"), resources.GetString("CPUCores.Items2"), resources.GetString("CPUCores.Items3"), resources.GetString("CPUCores.Items4"), resources.GetString("CPUCores.Items5"), resources.GetString("CPUCores.Items6"), resources.GetString("CPUCores.Items7"), resources.GetString("CPUCores.Items8"), resources.GetString("CPUCores.Items9"), resources.GetString("CPUCores.Items10"), resources.GetString("CPUCores.Items11"), resources.GetString("CPUCores.Items12"), resources.GetString("CPUCores.Items13") });
            resources.ApplyResources(CPUCores, "CPUCores");
            CPUCores.Name = "CPUCores";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // RAM
            // 
            RAM.FormattingEnabled = true;
            RAM.Items.AddRange(new object[] { resources.GetString("RAM.Items"), resources.GetString("RAM.Items1"), resources.GetString("RAM.Items2"), resources.GetString("RAM.Items3"), resources.GetString("RAM.Items4"), resources.GetString("RAM.Items5"), resources.GetString("RAM.Items6"), resources.GetString("RAM.Items7"), resources.GetString("RAM.Items8"), resources.GetString("RAM.Items9"), resources.GetString("RAM.Items10"), resources.GetString("RAM.Items11"), resources.GetString("RAM.Items12") });
            resources.ApplyResources(RAM, "RAM");
            RAM.Name = "RAM";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // HDA
            // 
            resources.ApplyResources(HDA, "HDA");
            HDA.Name = "HDA";
            // 
            // HDB
            // 
            resources.ApplyResources(HDB, "HDB");
            HDB.Name = "HDB";
            // 
            // HDC
            // 
            resources.ApplyResources(HDC, "HDC");
            HDC.Name = "HDC";
            // 
            // HDD
            // 
            resources.ApplyResources(HDD, "HDD");
            HDD.Name = "HDD";
            // 
            // FLB
            // 
            resources.ApplyResources(FLB, "FLB");
            FLB.Name = "FLB";
            helpProvider1.SetShowHelp(FLB, (bool)resources.GetObject("FLB.ShowHelp"));
            // 
            // FLA
            // 
            resources.ApplyResources(FLA, "FLA");
            FLA.Name = "FLA";
            helpProvider1.SetShowHelp(FLA, (bool)resources.GetObject("FLA.ShowHelp"));
            // 
            // CDR
            // 
            resources.ApplyResources(CDR, "CDR");
            CDR.Name = "CDR";
            helpProvider1.SetShowHelp(CDR, (bool)resources.GetObject("CDR.ShowHelp"));
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            helpProvider1.SetShowHelp(label11, (bool)resources.GetObject("label11.ShowHelp"));
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            helpProvider1.SetShowHelp(label12, (bool)resources.GetObject("label12.ShowHelp"));
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.Name = "label13";
            helpProvider1.SetShowHelp(label13, (bool)resources.GetObject("label13.ShowHelp"));
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            helpProvider1.SetShowHelp(label14, (bool)resources.GetObject("label14.ShowHelp"));
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(FLB);
            Controls.Add(FLA);
            Controls.Add(CDR);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(HDD);
            Controls.Add(HDC);
            Controls.Add(HDB);
            Controls.Add(HDA);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(RAM);
            Controls.Add(label4);
            Controls.Add(CPUCores);
            Controls.Add(label3);
            Controls.Add(CPUModel);
            Controls.Add(label2);
            Controls.Add(MachineType);
            Controls.Add(MachinetypeLabel);
            Controls.Add(boardlabel);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(Importbutton);
            Controls.Add(Runbutton);
            Name = "Main";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        public Button Runbutton;
        public Button Importbutton;
        private PictureBox pictureBox1;
        private Label boardlabel;
        private Label MachinetypeLabel;
        private ComboBox MachineType;
        private ComboBox CPUModel;
        private Label label2;
        private ComboBox CPUCores;
        private Label label3;
        private ComboBox RAM;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox HDA;
        private TextBox HDB;
        private TextBox HDC;
        private TextBox HDD;
        private HelpProvider helpProvider1;
        private TextBox FLB;
        private TextBox FLA;
        private TextBox CDR;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}
