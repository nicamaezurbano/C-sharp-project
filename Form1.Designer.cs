namespace Project_Zurbano
{
    partial class Form1
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
            this.lstAddOns = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboFlavor = new System.Windows.Forms.ComboBox();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.endDay_FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDay_FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.bgColor_EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColor_EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fontStyle_EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.about_HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDay = new System.Windows.Forms.Label();
            this.rtxtOrder = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAddOns
            // 
            this.lstAddOns.Font = new System.Drawing.Font("Verdana", 9F);
            this.lstAddOns.FormattingEnabled = true;
            this.lstAddOns.ItemHeight = 14;
            this.lstAddOns.Items.AddRange(new object[] {
            "Banana",
            "Brownie",
            "Butterscotch",
            "Cherry",
            "Chocolate chips",
            "Oreo",
            "Wafer",
            "Whipped Cream"});
            this.lstAddOns.Location = new System.Drawing.Point(68, 367);
            this.lstAddOns.Margin = new System.Windows.Forms.Padding(4);
            this.lstAddOns.Name = "lstAddOns";
            this.lstAddOns.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstAddOns.Size = new System.Drawing.Size(220, 116);
            this.lstAddOns.Sorted = true;
            this.lstAddOns.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(600, 436);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 35);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(54, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(54, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Flavor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(54, 345);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add- Ons";
            // 
            // cmboFlavor
            // 
            this.cmboFlavor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboFlavor.Font = new System.Drawing.Font("Verdana", 9F);
            this.cmboFlavor.FormattingEnabled = true;
            this.cmboFlavor.Items.AddRange(new object[] {
            "Banana Cream Pie",
            "Cherry Vanilla",
            "Fruity Pebble",
            "Oreo Cheesecake",
            "Peanut Butter Brownie",
            "S\'mores",
            "Salted Caramel",
            "Strawberry Shortcake"});
            this.cmboFlavor.Location = new System.Drawing.Point(68, 285);
            this.cmboFlavor.Margin = new System.Windows.Forms.Padding(4);
            this.cmboFlavor.Name = "cmboFlavor";
            this.cmboFlavor.Size = new System.Drawing.Size(220, 22);
            this.cmboFlavor.Sorted = true;
            this.cmboFlavor.TabIndex = 5;
            this.cmboFlavor.SelectedIndexChanged += new System.EventHandler(this.cmboFlavor_SelectedIndexChanged);
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Font = new System.Drawing.Font("Verdana", 9F);
            this.radSmall.Location = new System.Drawing.Point(68, 164);
            this.radSmall.Margin = new System.Windows.Forms.Padding(4);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(58, 18);
            this.radSmall.TabIndex = 6;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            this.radSmall.CheckedChanged += new System.EventHandler(this.radSmall_CheckedChanged);
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Font = new System.Drawing.Font("Verdana", 9F);
            this.radLarge.Location = new System.Drawing.Point(68, 216);
            this.radLarge.Margin = new System.Windows.Forms.Padding(4);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(61, 18);
            this.radLarge.TabIndex = 7;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            this.radLarge.CheckedChanged += new System.EventHandler(this.radLarge_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Font = new System.Drawing.Font("Verdana", 9F);
            this.radMedium.Location = new System.Drawing.Point(68, 190);
            this.radMedium.Margin = new System.Windows.Forms.Padding(4);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(73, 18);
            this.radMedium.TabIndex = 8;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radMedium_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(814, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endDay_FileMenu,
            this.resetDay_FileMenu,
            this.exit_FileMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 19);
            this.fileMenu.Text = "File";
            // 
            // endDay_FileMenu
            // 
            this.endDay_FileMenu.Name = "endDay_FileMenu";
            this.endDay_FileMenu.Size = new System.Drawing.Size(125, 22);
            this.endDay_FileMenu.Text = "End Day";
            this.endDay_FileMenu.Click += new System.EventHandler(this.endDay_FileMenu_Click);
            // 
            // resetDay_FileMenu
            // 
            this.resetDay_FileMenu.Name = "resetDay_FileMenu";
            this.resetDay_FileMenu.Size = new System.Drawing.Size(125, 22);
            this.resetDay_FileMenu.Text = "Reset Day";
            this.resetDay_FileMenu.Click += new System.EventHandler(this.resetDay_FileMenu_Click);
            // 
            // exit_FileMenu
            // 
            this.exit_FileMenu.Name = "exit_FileMenu";
            this.exit_FileMenu.Size = new System.Drawing.Size(125, 22);
            this.exit_FileMenu.Text = "Exit";
            this.exit_FileMenu.Click += new System.EventHandler(this.exit_FileMenu_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bgColor_EditMenu,
            this.fontColor_EditMenu,
            this.fontStyle_EditMenu});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 19);
            this.editMenu.Text = "Edit";
            // 
            // bgColor_EditMenu
            // 
            this.bgColor_EditMenu.Name = "bgColor_EditMenu";
            this.bgColor_EditMenu.Size = new System.Drawing.Size(170, 22);
            this.bgColor_EditMenu.Text = "Background Color";
            this.bgColor_EditMenu.Click += new System.EventHandler(this.bgColor_EditMenu_Click);
            // 
            // fontColor_EditMenu
            // 
            this.fontColor_EditMenu.Name = "fontColor_EditMenu";
            this.fontColor_EditMenu.Size = new System.Drawing.Size(170, 22);
            this.fontColor_EditMenu.Text = "Font Color";
            this.fontColor_EditMenu.Click += new System.EventHandler(this.fontColor_EditMenu_Click);
            // 
            // fontStyle_EditMenu
            // 
            this.fontStyle_EditMenu.Name = "fontStyle_EditMenu";
            this.fontStyle_EditMenu.Size = new System.Drawing.Size(170, 22);
            this.fontStyle_EditMenu.Text = "Font Style";
            this.fontStyle_EditMenu.Click += new System.EventHandler(this.fontStyle_EditMenu_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about_HelpMenu});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 19);
            this.helpMenu.Text = "Help";
            // 
            // about_HelpMenu
            // 
            this.about_HelpMenu.Name = "about_HelpMenu";
            this.about_HelpMenu.Size = new System.Drawing.Size(107, 22);
            this.about_HelpMenu.Text = "About";
            this.about_HelpMenu.Click += new System.EventHandler(this.about_HelpMenu_Click);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblDay.Location = new System.Drawing.Point(446, 137);
            this.lblDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(56, 18);
            this.lblDay.TabIndex = 10;
            this.lblDay.Text = "Day 1";
            // 
            // rtxtOrder
            // 
            this.rtxtOrder.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtxtOrder.Font = new System.Drawing.Font("Verdana", 9F);
            this.rtxtOrder.Location = new System.Drawing.Point(448, 171);
            this.rtxtOrder.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtOrder.Name = "rtxtOrder";
            this.rtxtOrder.Size = new System.Drawing.Size(288, 214);
            this.rtxtOrder.TabIndex = 11;
            this.rtxtOrder.Text = "Order/s:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(447, 395);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(505, 392);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(148, 25);
            this.txtTotal.TabIndex = 13;
            // 
            // btnPlace
            // 
            this.btnPlace.Enabled = false;
            this.btnPlace.Location = new System.Drawing.Point(518, 483);
            this.btnPlace.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(135, 35);
            this.btnPlace.TabIndex = 15;
            this.btnPlace.Text = "Place Order";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(448, 436);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 35);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add Order";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.Location = new System.Drawing.Point(631, 137);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(104, 18);
            this.lblCustomer.TabIndex = 17;
            this.lblCustomer.Text = "Customer 1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 87);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project_Zurbano.Properties.Resources.s_large;
            this.pictureBox4.Location = new System.Drawing.Point(745, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 78);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project_Zurbano.Properties.Resources.s_medium;
            this.pictureBox3.Location = new System.Drawing.Point(699, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 63);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Zurbano.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 50);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_Zurbano.Properties.Resources.s_small;
            this.pictureBox2.Location = new System.Drawing.Point(658, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 50);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F);
            this.label4.Location = new System.Drawing.Point(161, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 14);
            this.label4.TabIndex = 20;
            this.label4.Text = "$10.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F);
            this.label5.Location = new System.Drawing.Point(161, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 21;
            this.label5.Text = "$15.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F);
            this.label7.Location = new System.Drawing.Point(161, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 14);
            this.label7.TabIndex = 22;
            this.label7.Text = "$20.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F);
            this.label8.Location = new System.Drawing.Point(212, 348);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 23;
            this.label8.Text = "$1.00 each";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(814, 550);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtxtOrder);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.radMedium);
            this.Controls.Add(this.radLarge);
            this.Controls.Add(this.radSmall);
            this.Controls.Add(this.cmboFlavor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lstAddOns);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 11F);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Mr. Frostie - Milkshake Shop ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAddOns;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboFlavor;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.RichTextBox rtxtOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ToolStripMenuItem endDay_FileMenu;
        private System.Windows.Forms.ToolStripMenuItem resetDay_FileMenu;
        private System.Windows.Forms.ToolStripMenuItem exit_FileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem bgColor_EditMenu;
        private System.Windows.Forms.ToolStripMenuItem fontColor_EditMenu;
        private System.Windows.Forms.ToolStripMenuItem fontStyle_EditMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem about_HelpMenu;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

