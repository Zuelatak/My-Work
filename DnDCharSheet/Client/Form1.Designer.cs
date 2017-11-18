﻿namespace Client
{
    partial class mainForm
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
            this.labelConstitution = new System.Windows.Forms.Label();
            this.textConstitution = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.groupConstitution = new System.Windows.Forms.GroupBox();
            this.groupDexterity = new System.Windows.Forms.GroupBox();
            this.textDexterity = new System.Windows.Forms.TextBox();
            this.labelDexterity = new System.Windows.Forms.Label();
            this.groupStrength = new System.Windows.Forms.GroupBox();
            this.textStrength = new System.Windows.Forms.TextBox();
            this.labelStrength = new System.Windows.Forms.Label();
            this.groupCharisma = new System.Windows.Forms.GroupBox();
            this.textCharisma = new System.Windows.Forms.TextBox();
            this.labelCharisma = new System.Windows.Forms.Label();
            this.groupWisdom = new System.Windows.Forms.GroupBox();
            this.textWisdom = new System.Windows.Forms.TextBox();
            this.labelWisdom = new System.Windows.Forms.Label();
            this.groupIntelligence = new System.Windows.Forms.GroupBox();
            this.textIntelligence = new System.Windows.Forms.TextBox();
            this.labelIntelligence = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupConstitution.SuspendLayout();
            this.groupDexterity.SuspendLayout();
            this.groupStrength.SuspendLayout();
            this.groupCharisma.SuspendLayout();
            this.groupWisdom.SuspendLayout();
            this.groupIntelligence.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelConstitution
            // 
            this.labelConstitution.AutoSize = true;
            this.labelConstitution.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConstitution.Location = new System.Drawing.Point(22, 18);
            this.labelConstitution.Name = "labelConstitution";
            this.labelConstitution.Size = new System.Drawing.Size(0, 24);
            this.labelConstitution.TabIndex = 0;
            // 
            // textConstitution
            // 
            this.textConstitution.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textConstitution.Location = new System.Drawing.Point(25, 45);
            this.textConstitution.MaxLength = 2;
            this.textConstitution.Name = "textConstitution";
            this.textConstitution.Size = new System.Drawing.Size(22, 20);
            this.textConstitution.TabIndex = 3;
            this.textConstitution.TextChanged += new System.EventHandler(this.textConstitution_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 759);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.groupIntelligence);
            this.tabPage1.Controls.Add(this.groupWisdom);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupStrength);
            this.tabPage1.Controls.Add(this.groupCharisma);
            this.tabPage1.Controls.Add(this.groupDexterity);
            this.tabPage1.Controls.Add(this.groupConstitution);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 733);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(292, 638);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(448, 369);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar2.TabIndex = 21;
            // 
            // groupConstitution
            // 
            this.groupConstitution.Controls.Add(this.textConstitution);
            this.groupConstitution.Controls.Add(this.labelConstitution);
            this.groupConstitution.Location = new System.Drawing.Point(3, 211);
            this.groupConstitution.Name = "groupConstitution";
            this.groupConstitution.Size = new System.Drawing.Size(76, 71);
            this.groupConstitution.TabIndex = 4;
            this.groupConstitution.TabStop = false;
            this.groupConstitution.Text = "Constitution";
            // 
            // groupDexterity
            // 
            this.groupDexterity.Controls.Add(this.textDexterity);
            this.groupDexterity.Controls.Add(this.labelDexterity);
            this.groupDexterity.Location = new System.Drawing.Point(3, 134);
            this.groupDexterity.Name = "groupDexterity";
            this.groupDexterity.Size = new System.Drawing.Size(76, 71);
            this.groupDexterity.TabIndex = 4;
            this.groupDexterity.TabStop = false;
            this.groupDexterity.Text = "Dexterity";
            // 
            // textDexterity
            // 
            this.textDexterity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textDexterity.Location = new System.Drawing.Point(25, 45);
            this.textDexterity.MaxLength = 2;
            this.textDexterity.Name = "textDexterity";
            this.textDexterity.Size = new System.Drawing.Size(22, 20);
            this.textDexterity.TabIndex = 3;
            this.textDexterity.TextChanged += new System.EventHandler(this.textDexterity_TextChanged);
            // 
            // labelDexterity
            // 
            this.labelDexterity.AutoSize = true;
            this.labelDexterity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDexterity.Location = new System.Drawing.Point(22, 18);
            this.labelDexterity.Name = "labelDexterity";
            this.labelDexterity.Size = new System.Drawing.Size(0, 24);
            this.labelDexterity.TabIndex = 0;
            // 
            // groupStrength
            // 
            this.groupStrength.Controls.Add(this.textStrength);
            this.groupStrength.Controls.Add(this.labelStrength);
            this.groupStrength.Location = new System.Drawing.Point(3, 57);
            this.groupStrength.Name = "groupStrength";
            this.groupStrength.Size = new System.Drawing.Size(76, 71);
            this.groupStrength.TabIndex = 4;
            this.groupStrength.TabStop = false;
            this.groupStrength.Text = "Strength";
            // 
            // textStrength
            // 
            this.textStrength.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textStrength.Location = new System.Drawing.Point(25, 45);
            this.textStrength.MaxLength = 2;
            this.textStrength.Name = "textStrength";
            this.textStrength.Size = new System.Drawing.Size(22, 20);
            this.textStrength.TabIndex = 3;
            this.textStrength.TextChanged += new System.EventHandler(this.textStrength_TextChanged);
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStrength.Location = new System.Drawing.Point(22, 18);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(0, 24);
            this.labelStrength.TabIndex = 0;
            // 
            // groupCharisma
            // 
            this.groupCharisma.Controls.Add(this.textCharisma);
            this.groupCharisma.Controls.Add(this.labelCharisma);
            this.groupCharisma.Location = new System.Drawing.Point(6, 442);
            this.groupCharisma.Name = "groupCharisma";
            this.groupCharisma.Size = new System.Drawing.Size(76, 71);
            this.groupCharisma.TabIndex = 4;
            this.groupCharisma.TabStop = false;
            this.groupCharisma.Text = "Charisma";
            // 
            // textCharisma
            // 
            this.textCharisma.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textCharisma.Location = new System.Drawing.Point(25, 45);
            this.textCharisma.MaxLength = 2;
            this.textCharisma.Name = "textCharisma";
            this.textCharisma.Size = new System.Drawing.Size(22, 20);
            this.textCharisma.TabIndex = 3;
            this.textCharisma.TextChanged += new System.EventHandler(this.textCharisma_TextChanged);
            // 
            // labelCharisma
            // 
            this.labelCharisma.AutoSize = true;
            this.labelCharisma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharisma.Location = new System.Drawing.Point(22, 18);
            this.labelCharisma.Name = "labelCharisma";
            this.labelCharisma.Size = new System.Drawing.Size(0, 24);
            this.labelCharisma.TabIndex = 0;
            // 
            // groupWisdom
            // 
            this.groupWisdom.Controls.Add(this.textWisdom);
            this.groupWisdom.Controls.Add(this.labelWisdom);
            this.groupWisdom.Location = new System.Drawing.Point(6, 365);
            this.groupWisdom.Name = "groupWisdom";
            this.groupWisdom.Size = new System.Drawing.Size(76, 71);
            this.groupWisdom.TabIndex = 4;
            this.groupWisdom.TabStop = false;
            this.groupWisdom.Text = "Wisdom";
            // 
            // textWisdom
            // 
            this.textWisdom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textWisdom.Location = new System.Drawing.Point(25, 45);
            this.textWisdom.MaxLength = 2;
            this.textWisdom.Name = "textWisdom";
            this.textWisdom.Size = new System.Drawing.Size(22, 20);
            this.textWisdom.TabIndex = 3;
            this.textWisdom.TextChanged += new System.EventHandler(this.textWidsom_TextChanged);
            // 
            // labelWisdom
            // 
            this.labelWisdom.AutoSize = true;
            this.labelWisdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWisdom.Location = new System.Drawing.Point(22, 18);
            this.labelWisdom.Name = "labelWisdom";
            this.labelWisdom.Size = new System.Drawing.Size(0, 24);
            this.labelWisdom.TabIndex = 0;
            // 
            // groupIntelligence
            // 
            this.groupIntelligence.Controls.Add(this.textIntelligence);
            this.groupIntelligence.Controls.Add(this.labelIntelligence);
            this.groupIntelligence.Location = new System.Drawing.Point(6, 288);
            this.groupIntelligence.Name = "groupIntelligence";
            this.groupIntelligence.Size = new System.Drawing.Size(76, 71);
            this.groupIntelligence.TabIndex = 4;
            this.groupIntelligence.TabStop = false;
            this.groupIntelligence.Text = "Intelligence";
            // 
            // textIntelligence
            // 
            this.textIntelligence.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textIntelligence.Location = new System.Drawing.Point(25, 45);
            this.textIntelligence.MaxLength = 2;
            this.textIntelligence.Name = "textIntelligence";
            this.textIntelligence.Size = new System.Drawing.Size(22, 20);
            this.textIntelligence.TabIndex = 3;
            this.textIntelligence.TextChanged += new System.EventHandler(this.textIntelligence_TextChanged);
            // 
            // labelIntelligence
            // 
            this.labelIntelligence.AutoSize = true;
            this.labelIntelligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntelligence.Location = new System.Drawing.Point(22, 18);
            this.labelIntelligence.Name = "labelIntelligence";
            this.labelIntelligence.Size = new System.Drawing.Size(0, 24);
            this.labelIntelligence.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(285, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 71);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Location = new System.Drawing.Point(25, 45);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(22, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textStrength_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 783);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainForm";
            this.Text = "Character Sheet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupConstitution.ResumeLayout(false);
            this.groupConstitution.PerformLayout();
            this.groupDexterity.ResumeLayout(false);
            this.groupDexterity.PerformLayout();
            this.groupStrength.ResumeLayout(false);
            this.groupStrength.PerformLayout();
            this.groupCharisma.ResumeLayout(false);
            this.groupCharisma.PerformLayout();
            this.groupWisdom.ResumeLayout(false);
            this.groupWisdom.PerformLayout();
            this.groupIntelligence.ResumeLayout(false);
            this.groupIntelligence.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelConstitution;
        private System.Windows.Forms.TextBox textConstitution;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.GroupBox groupIntelligence;
        private System.Windows.Forms.TextBox textIntelligence;
        private System.Windows.Forms.Label labelIntelligence;
        private System.Windows.Forms.GroupBox groupWisdom;
        private System.Windows.Forms.TextBox textWisdom;
        private System.Windows.Forms.Label labelWisdom;
        private System.Windows.Forms.GroupBox groupStrength;
        private System.Windows.Forms.TextBox textStrength;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.GroupBox groupCharisma;
        private System.Windows.Forms.TextBox textCharisma;
        private System.Windows.Forms.Label labelCharisma;
        private System.Windows.Forms.GroupBox groupDexterity;
        private System.Windows.Forms.TextBox textDexterity;
        private System.Windows.Forms.Label labelDexterity;
        private System.Windows.Forms.GroupBox groupConstitution;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

