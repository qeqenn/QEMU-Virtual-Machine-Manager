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
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
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
    }
}
