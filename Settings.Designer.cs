
using System.Collections;

namespace Nigma
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ListBox lstSelectedRotors;
        private System.Windows.Forms.Label lblRotorStructure;
        private System.Windows.Forms.ListBox lstAvailableRotors;
        private System.Windows.Forms.ToolTip ttDown;
        private System.Windows.Forms.ToolTip ttSelect;
        private System.Windows.Forms.ToolTip ttDeselect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttUp;
        private string rotor1, rotor2, rotor3, rotor4, rotor5, rotor1_1, rotor2_1, rotor3_1, rotor4_1, rotor5_1;
        private MainForm mf;
        private ArrayList al1, al2, al3, al1_1, al2_1, al3_1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.ttUp = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ttDeselect = new System.Windows.Forms.ToolTip(this.components);
            this.ttSelect = new System.Windows.Forms.ToolTip(this.components);
            this.ttDown = new System.Windows.Forms.ToolTip(this.components);
            this.lblRotorStructure = new System.Windows.Forms.Label();
            this.lstAvailableRotors = new System.Windows.Forms.ListBox();
            this.lstSelectedRotors = new System.Windows.Forms.ListBox();
            this.language_selection = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnOk = new MaterialSkin.Controls.MaterialButton();
            this.materialButton8 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.btnDown = new MaterialSkin.Controls.MaterialButton();
            this.btnUp = new MaterialSkin.Controls.MaterialButton();
            this.btnDeselect = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.btnSelect = new MaterialSkin.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.cmbReflector = new MaterialSkin.Controls.MaterialComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.label5 = new System.Windows.Forms.Label();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.label3 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label2 = new System.Windows.Forms.Label();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialProgressBar2 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialProgressBar3 = new MaterialSkin.Controls.MaterialProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialCard14 = new MaterialSkin.Controls.MaterialCard();
            this.btnCancel_1 = new MaterialSkin.Controls.MaterialButton();
            this.btnOk_1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton14 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard13 = new MaterialSkin.Controls.MaterialCard();
            this.cmbReflector_1 = new MaterialSkin.Controls.MaterialComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.materialButton10 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard12 = new MaterialSkin.Controls.MaterialCard();
            this.lstSelectedRotors_1 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.materialCard11 = new MaterialSkin.Controls.MaterialCard();
            this.lstAvailableRotors_1 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.materialButton9 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard10 = new MaterialSkin.Controls.MaterialCard();
            this.lblRotorStructure_1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard9 = new MaterialSkin.Controls.MaterialCard();
            this.btnDown_1 = new MaterialSkin.Controls.MaterialButton();
            this.btnUp_1 = new MaterialSkin.Controls.MaterialButton();
            this.btnDeselect_1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton11 = new MaterialSkin.Controls.MaterialButton();
            this.btnSelect_1 = new MaterialSkin.Controls.MaterialButton();
            this.label9 = new System.Windows.Forms.Label();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialProgressBar4 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialProgressBar6 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialProgressBar5 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.themeToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.ttUp_1 = new System.Windows.Forms.ToolTip(this.components);
            this.ttDeselect_1 = new System.Windows.Forms.ToolTip(this.components);
            this.ttSelect_1 = new System.Windows.Forms.ToolTip(this.components);
            this.ttDown_1 = new System.Windows.Forms.ToolTip(this.components);
            this.materialCard8 = new MaterialSkin.Controls.MaterialCard();
            this.materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.language_selection.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.materialCard14.SuspendLayout();
            this.materialCard13.SuspendLayout();
            this.materialCard12.SuspendLayout();
            this.materialCard11.SuspendLayout();
            this.materialCard10.SuspendLayout();
            this.materialCard9.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.materialCard8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRotorStructure
            // 
            this.lblRotorStructure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRotorStructure.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.lblRotorStructure.Location = new System.Drawing.Point(15, 54);
            this.lblRotorStructure.Name = "lblRotorStructure";
            this.lblRotorStructure.Size = new System.Drawing.Size(434, 22);
            this.lblRotorStructure.TabIndex = 9;
            this.lblRotorStructure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstAvailableRotors
            // 
            this.lstAvailableRotors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstAvailableRotors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstAvailableRotors.ItemHeight = 20;
            this.lstAvailableRotors.Items.AddRange(new object[] {
            "Rotor I",
            "Rotor II",
            "Rotor III",
            "Rotor IV",
            "Rotor V"});
            this.lstAvailableRotors.Location = new System.Drawing.Point(17, 33);
            this.lstAvailableRotors.Name = "lstAvailableRotors";
            this.lstAvailableRotors.Size = new System.Drawing.Size(147, 144);
            this.lstAvailableRotors.TabIndex = 0;
            this.lstAvailableRotors.SelectedIndexChanged += new System.EventHandler(this.LstAvailableRotorsSelectedIndexChanged);
            // 
            // lstSelectedRotors
            // 
            this.lstSelectedRotors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstSelectedRotors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstSelectedRotors.ItemHeight = 20;
            this.lstSelectedRotors.Location = new System.Drawing.Point(17, 33);
            this.lstSelectedRotors.Name = "lstSelectedRotors";
            this.lstSelectedRotors.Size = new System.Drawing.Size(147, 144);
            this.lstSelectedRotors.TabIndex = 5;
            this.lstSelectedRotors.SelectedIndexChanged += new System.EventHandler(this.lstSelectedRotors_SelectedIndexChanged);
            // 
            // language_selection
            // 
            this.language_selection.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.language_selection.Controls.Add(this.tabPage1);
            this.language_selection.Controls.Add(this.tabPage2);
            this.language_selection.Cursor = System.Windows.Forms.Cursors.Default;
            this.language_selection.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.language_selection.Location = new System.Drawing.Point(8, 132);
            this.language_selection.Name = "language_selection";
            this.language_selection.SelectedIndex = 0;
            this.language_selection.Size = new System.Drawing.Size(694, 429);
            this.language_selection.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage1.Controls.Add(this.materialButton4);
            this.tabPage1.Controls.Add(this.materialCard6);
            this.tabPage1.Controls.Add(this.materialCard5);
            this.tabPage1.Controls.Add(this.materialCard4);
            this.tabPage1.Controls.Add(this.materialCard3);
            this.tabPage1.Controls.Add(this.materialCard2);
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.Controls.Add(this.materialProgressBar1);
            this.tabPage1.Controls.Add(this.materialProgressBar2);
            this.tabPage1.Controls.Add(this.materialProgressBar3);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "English";
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(14, -30);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(658, 39);
            this.materialButton4.TabIndex = 31;
            this.materialButton4.Text = " \r\n";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.btnCancel);
            this.materialCard6.Controls.Add(this.btnOk);
            this.materialCard6.Controls.Add(this.materialButton8);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(480, 289);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(192, 92);
            this.materialCard6.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = global::Nigma.Properties.Resources.Delete;
            this.btnCancel.Location = new System.Drawing.Point(18, 49);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(147, 36);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.AutoSize = false;
            this.btnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOk.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnOk.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOk.Depth = 0;
            this.btnOk.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.HighEmphasis = true;
            this.btnOk.Icon = global::Nigma.Properties.Resources.Check;
            this.btnOk.Location = new System.Drawing.Point(18, 7);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOk.Name = "btnOk";
            this.btnOk.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOk.Size = new System.Drawing.Size(147, 36);
            this.btnOk.TabIndex = 28;
            this.btnOk.Text = "Apply";
            this.btnOk.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOk.UseAccentColor = false;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // materialButton8
            // 
            this.materialButton8.AutoSize = false;
            this.materialButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton8.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton8.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton8.Depth = 0;
            this.materialButton8.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.materialButton8.HighEmphasis = true;
            this.materialButton8.Icon = null;
            this.materialButton8.Location = new System.Drawing.Point(173, -26);
            this.materialButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton8.Name = "materialButton8";
            this.materialButton8.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton8.Size = new System.Drawing.Size(46, 255);
            this.materialButton8.TabIndex = 27;
            this.materialButton8.Text = " \r\n";
            this.materialButton8.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton8.UseAccentColor = false;
            this.materialButton8.UseVisualStyleBackColor = true;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.btnDown);
            this.materialCard5.Controls.Add(this.btnUp);
            this.materialCard5.Controls.Add(this.btnDeselect);
            this.materialCard5.Controls.Add(this.materialButton1);
            this.materialCard5.Controls.Add(this.btnSelect);
            this.materialCard5.Controls.Add(this.label4);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(480, 13);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(192, 202);
            this.materialCard5.TabIndex = 20;
            // 
            // btnDown
            // 
            this.btnDown.AutoSize = false;
            this.btnDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDown.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnDown.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDown.Depth = 0;
            this.btnDown.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDown.HighEmphasis = true;
            this.btnDown.Icon = global::Nigma.Properties.Resources.Down;
            this.btnDown.Location = new System.Drawing.Point(18, 160);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDown.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDown.Name = "btnDown";
            this.btnDown.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDown.Size = new System.Drawing.Size(147, 36);
            this.btnDown.TabIndex = 30;
            this.btnDown.Text = "Down";
            this.btnDown.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDown.UseAccentColor = false;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.AutoSize = false;
            this.btnUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUp.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUp.Depth = 0;
            this.btnUp.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUp.HighEmphasis = true;
            this.btnUp.Icon = global::Nigma.Properties.Resources.Up;
            this.btnUp.Location = new System.Drawing.Point(18, 118);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUp.Name = "btnUp";
            this.btnUp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUp.Size = new System.Drawing.Size(147, 36);
            this.btnUp.TabIndex = 29;
            this.btnUp.Text = "Up";
            this.btnUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUp.UseAccentColor = false;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDeselect
            // 
            this.btnDeselect.AutoSize = false;
            this.btnDeselect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeselect.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnDeselect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeselect.Depth = 0;
            this.btnDeselect.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeselect.HighEmphasis = true;
            this.btnDeselect.Icon = global::Nigma.Properties.Resources.Delete;
            this.btnDeselect.Location = new System.Drawing.Point(18, 76);
            this.btnDeselect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeselect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeselect.Size = new System.Drawing.Size(147, 36);
            this.btnDeselect.TabIndex = 28;
            this.btnDeselect.Text = "Dsel";
            this.btnDeselect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeselect.UseAccentColor = false;
            this.btnDeselect.UseVisualStyleBackColor = true;
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(173, -26);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(46, 255);
            this.materialButton1.TabIndex = 27;
            this.materialButton1.Text = " \r\n";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.AutoSize = false;
            this.btnSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelect.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnSelect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelect.Depth = 0;
            this.btnSelect.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelect.HighEmphasis = true;
            this.btnSelect.Icon = global::Nigma.Properties.Resources.Check;
            this.btnSelect.Location = new System.Drawing.Point(18, 34);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSelect.Size = new System.Drawing.Size(147, 36);
            this.btnSelect.TabIndex = 25;
            this.btnSelect.Text = "Select";
            this.btnSelect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelect.UseAccentColor = false;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(51, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Control";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.cmbReflector);
            this.materialCard4.Controls.Add(this.label6);
            this.materialCard4.Controls.Add(this.materialButton5);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(14, 296);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(456, 85);
            this.materialCard4.TabIndex = 30;
            // 
            // cmbReflector
            // 
            this.cmbReflector.AutoResize = false;
            this.cmbReflector.BackColor = System.Drawing.Color.White;
            this.cmbReflector.Depth = 0;
            this.cmbReflector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbReflector.DropDownHeight = 174;
            this.cmbReflector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReflector.DropDownWidth = 121;
            this.cmbReflector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbReflector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbReflector.FormattingEnabled = true;
            this.cmbReflector.IntegralHeight = false;
            this.cmbReflector.ItemHeight = 43;
            this.cmbReflector.Items.AddRange(new object[] {
            "Reflector B = YRUHQSLDPXNGOKMIEBFZCWVJAT",
            "Reflector C = FVPJIAOYEDRZXWGCTKUQSBNMHL"});
            this.cmbReflector.Location = new System.Drawing.Point(7, 29);
            this.cmbReflector.MaxDropDownItems = 4;
            this.cmbReflector.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbReflector.Name = "cmbReflector";
            this.cmbReflector.Size = new System.Drawing.Size(442, 49);
            this.cmbReflector.StartIndex = 0;
            this.cmbReflector.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(27, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Reflector";
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSize = false;
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(-19, -38);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(46, 255);
            this.materialButton5.TabIndex = 26;
            this.materialButton5.Text = " \r\n";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.label5);
            this.materialCard3.Controls.Add(this.lblRotorStructure);
            this.materialCard3.Controls.Add(this.label1);
            this.materialCard3.Controls.Add(this.materialButton2);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(14, 13);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(456, 81);
            this.materialCard3.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(27, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Rotor layout";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(-19, -38);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(46, 255);
            this.materialButton2.TabIndex = 26;
            this.materialButton2.Text = " \r\n";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lstSelectedRotors);
            this.materialCard2.Controls.Add(this.label3);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(292, 103);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(178, 186);
            this.materialCard2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Selected rotors";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.lstAvailableRotors);
            this.materialCard1.Controls.Add(this.materialButton3);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 103);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(178, 186);
            this.materialCard1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Available rotors";
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(-19, -38);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(46, 255);
            this.materialButton3.TabIndex = 26;
            this.materialButton3.Text = " \r\n";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(191, 143);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(100, 5);
            this.materialProgressBar1.TabIndex = 17;
            this.materialProgressBar1.Value = 100;
            // 
            // materialProgressBar2
            // 
            this.materialProgressBar2.Depth = 0;
            this.materialProgressBar2.Location = new System.Drawing.Point(191, 228);
            this.materialProgressBar2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar2.Name = "materialProgressBar2";
            this.materialProgressBar2.Size = new System.Drawing.Size(100, 5);
            this.materialProgressBar2.TabIndex = 27;
            this.materialProgressBar2.Value = 100;
            // 
            // materialProgressBar3
            // 
            this.materialProgressBar3.Depth = 0;
            this.materialProgressBar3.Location = new System.Drawing.Point(191, 217);
            this.materialProgressBar3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar3.Name = "materialProgressBar3";
            this.materialProgressBar3.Size = new System.Drawing.Size(100, 5);
            this.materialProgressBar3.TabIndex = 28;
            this.materialProgressBar3.Value = 100;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage2.Controls.Add(this.materialCard14);
            this.tabPage2.Controls.Add(this.materialCard13);
            this.tabPage2.Controls.Add(this.materialCard12);
            this.tabPage2.Controls.Add(this.materialCard11);
            this.tabPage2.Controls.Add(this.materialCard10);
            this.tabPage2.Controls.Add(this.materialCard9);
            this.tabPage2.Controls.Add(this.materialButton6);
            this.tabPage2.Controls.Add(this.materialProgressBar4);
            this.tabPage2.Controls.Add(this.materialProgressBar6);
            this.tabPage2.Controls.Add(this.materialProgressBar5);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Русский";
            // 
            // materialCard14
            // 
            this.materialCard14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard14.Controls.Add(this.btnCancel_1);
            this.materialCard14.Controls.Add(this.btnOk_1);
            this.materialCard14.Controls.Add(this.materialButton14);
            this.materialCard14.Depth = 0;
            this.materialCard14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard14.Location = new System.Drawing.Point(480, 289);
            this.materialCard14.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard14.Name = "materialCard14";
            this.materialCard14.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard14.Size = new System.Drawing.Size(192, 92);
            this.materialCard14.TabIndex = 22;
            // 
            // btnCancel_1
            // 
            this.btnCancel_1.AutoSize = false;
            this.btnCancel_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel_1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnCancel_1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel_1.Depth = 0;
            this.btnCancel_1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel_1.HighEmphasis = true;
            this.btnCancel_1.Icon = global::Nigma.Properties.Resources.Delete;
            this.btnCancel_1.Location = new System.Drawing.Point(18, 49);
            this.btnCancel_1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel_1.Name = "btnCancel_1";
            this.btnCancel_1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel_1.Size = new System.Drawing.Size(147, 36);
            this.btnCancel_1.TabIndex = 29;
            this.btnCancel_1.Text = "Отмена";
            this.btnCancel_1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel_1.UseAccentColor = false;
            this.btnCancel_1.UseVisualStyleBackColor = true;
            this.btnCancel_1.Click += new System.EventHandler(this.btnCancel_1_Click);
            // 
            // btnOk_1
            // 
            this.btnOk_1.AutoSize = false;
            this.btnOk_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOk_1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnOk_1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOk_1.Depth = 0;
            this.btnOk_1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk_1.HighEmphasis = true;
            this.btnOk_1.Icon = global::Nigma.Properties.Resources.Check;
            this.btnOk_1.Location = new System.Drawing.Point(18, 7);
            this.btnOk_1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOk_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOk_1.Name = "btnOk_1";
            this.btnOk_1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOk_1.Size = new System.Drawing.Size(147, 36);
            this.btnOk_1.TabIndex = 28;
            this.btnOk_1.Text = "Применить";
            this.btnOk_1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOk_1.UseAccentColor = false;
            this.btnOk_1.UseVisualStyleBackColor = true;
            this.btnOk_1.Click += new System.EventHandler(this.btnOk_1_Click);
            // 
            // materialButton14
            // 
            this.materialButton14.AutoSize = false;
            this.materialButton14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton14.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton14.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton14.Depth = 0;
            this.materialButton14.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.materialButton14.HighEmphasis = true;
            this.materialButton14.Icon = null;
            this.materialButton14.Location = new System.Drawing.Point(173, -26);
            this.materialButton14.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton14.Name = "materialButton14";
            this.materialButton14.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton14.Size = new System.Drawing.Size(46, 255);
            this.materialButton14.TabIndex = 27;
            this.materialButton14.Text = " \r\n";
            this.materialButton14.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton14.UseAccentColor = false;
            this.materialButton14.UseVisualStyleBackColor = true;
            // 
            // materialCard13
            // 
            this.materialCard13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard13.Controls.Add(this.cmbReflector_1);
            this.materialCard13.Controls.Add(this.label13);
            this.materialCard13.Controls.Add(this.materialButton10);
            this.materialCard13.Depth = 0;
            this.materialCard13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard13.Location = new System.Drawing.Point(14, 296);
            this.materialCard13.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard13.Name = "materialCard13";
            this.materialCard13.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard13.Size = new System.Drawing.Size(456, 85);
            this.materialCard13.TabIndex = 31;
            // 
            // cmbReflector_1
            // 
            this.cmbReflector_1.AutoResize = false;
            this.cmbReflector_1.BackColor = System.Drawing.Color.White;
            this.cmbReflector_1.Depth = 0;
            this.cmbReflector_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbReflector_1.DropDownHeight = 174;
            this.cmbReflector_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReflector_1.DropDownWidth = 121;
            this.cmbReflector_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbReflector_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbReflector_1.FormattingEnabled = true;
            this.cmbReflector_1.IntegralHeight = false;
            this.cmbReflector_1.ItemHeight = 43;
            this.cmbReflector_1.Items.AddRange(new object[] {
            "Reflector А = ВШЭМСРЬТЫЗКДЯЕЪЮНЦЩАЛУИГПЧЙФБХЖО",
            "Reflector Х = ЯЧФЫЭВЪМЬУХЗНШСДАЖПЕБЦЩИЛЙТГЮКРО",
            "Reflector Ч = ШЫЩПЖЮЙЧВГКХАЪФУЬЦЛТРЕНДМЯБЭСЗОИ"});
            this.cmbReflector_1.Location = new System.Drawing.Point(7, 29);
            this.cmbReflector_1.MaxDropDownItems = 4;
            this.cmbReflector_1.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbReflector_1.Name = "cmbReflector_1";
            this.cmbReflector_1.Size = new System.Drawing.Size(442, 49);
            this.cmbReflector_1.StartIndex = 0;
            this.cmbReflector_1.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(27, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 23);
            this.label13.TabIndex = 25;
            this.label13.Text = "Отражатель";
            // 
            // materialButton10
            // 
            this.materialButton10.AutoSize = false;
            this.materialButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton10.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton10.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton10.Depth = 0;
            this.materialButton10.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.materialButton10.HighEmphasis = true;
            this.materialButton10.Icon = null;
            this.materialButton10.Location = new System.Drawing.Point(-19, -38);
            this.materialButton10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton10.Name = "materialButton10";
            this.materialButton10.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton10.Size = new System.Drawing.Size(46, 255);
            this.materialButton10.TabIndex = 26;
            this.materialButton10.Text = " \r\n";
            this.materialButton10.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton10.UseAccentColor = false;
            this.materialButton10.UseVisualStyleBackColor = true;
            // 
            // materialCard12
            // 
            this.materialCard12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard12.Controls.Add(this.lstSelectedRotors_1);
            this.materialCard12.Controls.Add(this.label12);
            this.materialCard12.Depth = 0;
            this.materialCard12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard12.Location = new System.Drawing.Point(273, 103);
            this.materialCard12.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard12.Name = "materialCard12";
            this.materialCard12.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard12.Size = new System.Drawing.Size(197, 186);
            this.materialCard12.TabIndex = 19;
            // 
            // lstSelectedRotors_1
            // 
            this.lstSelectedRotors_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstSelectedRotors_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstSelectedRotors_1.ItemHeight = 20;
            this.lstSelectedRotors_1.Location = new System.Drawing.Point(24, 33);
            this.lstSelectedRotors_1.Name = "lstSelectedRotors_1";
            this.lstSelectedRotors_1.Size = new System.Drawing.Size(147, 144);
            this.lstSelectedRotors_1.TabIndex = 17;
            this.lstSelectedRotors_1.SelectedIndexChanged += new System.EventHandler(this.lstSelectedRotors_1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(9, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(181, 23);
            this.label12.TabIndex = 25;
            this.label12.Text = "Выбранные роторы";
            // 
            // materialCard11
            // 
            this.materialCard11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard11.Controls.Add(this.lstAvailableRotors_1);
            this.materialCard11.Controls.Add(this.label11);
            this.materialCard11.Controls.Add(this.materialButton9);
            this.materialCard11.Depth = 0;
            this.materialCard11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard11.Location = new System.Drawing.Point(14, 103);
            this.materialCard11.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard11.Name = "materialCard11";
            this.materialCard11.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard11.Size = new System.Drawing.Size(209, 186);
            this.materialCard11.TabIndex = 25;
            // 
            // lstAvailableRotors_1
            // 
            this.lstAvailableRotors_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstAvailableRotors_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstAvailableRotors_1.ItemHeight = 20;
            this.lstAvailableRotors_1.Items.AddRange(new object[] {
            "Rotor I",
            "Rotor II",
            "Rotor III",
            "Rotor IV",
            "Rotor V"});
            this.lstAvailableRotors_1.Location = new System.Drawing.Point(17, 33);
            this.lstAvailableRotors_1.Name = "lstAvailableRotors_1";
            this.lstAvailableRotors_1.Size = new System.Drawing.Size(147, 144);
            this.lstAvailableRotors_1.TabIndex = 11;
            this.lstAvailableRotors_1.SelectedIndexChanged += new System.EventHandler(this.lstAvailableRotors_1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(27, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "Доступные роторы";
            // 
            // materialButton9
            // 
            this.materialButton9.AutoSize = false;
            this.materialButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton9.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton9.Depth = 0;
            this.materialButton9.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.materialButton9.HighEmphasis = true;
            this.materialButton9.Icon = null;
            this.materialButton9.Location = new System.Drawing.Point(-19, -38);
            this.materialButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton9.Name = "materialButton9";
            this.materialButton9.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton9.Size = new System.Drawing.Size(46, 255);
            this.materialButton9.TabIndex = 26;
            this.materialButton9.Text = " \r\n";
            this.materialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton9.UseAccentColor = false;
            this.materialButton9.UseVisualStyleBackColor = true;
            // 
            // materialCard10
            // 
            this.materialCard10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard10.Controls.Add(this.lblRotorStructure_1);
            this.materialCard10.Controls.Add(this.label10);
            this.materialCard10.Controls.Add(this.label8);
            this.materialCard10.Controls.Add(this.materialButton7);
            this.materialCard10.Depth = 0;
            this.materialCard10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard10.Location = new System.Drawing.Point(14, 13);
            this.materialCard10.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard10.Name = "materialCard10";
            this.materialCard10.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard10.Size = new System.Drawing.Size(456, 81);
            this.materialCard10.TabIndex = 30;
            // 
            // lblRotorStructure_1
            // 
            this.lblRotorStructure_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRotorStructure_1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.lblRotorStructure_1.Location = new System.Drawing.Point(15, 54);
            this.lblRotorStructure_1.Name = "lblRotorStructure_1";
            this.lblRotorStructure_1.Size = new System.Drawing.Size(434, 21);
            this.lblRotorStructure_1.TabIndex = 9;
            this.lblRotorStructure_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(27, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "Раскладка ротора";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.label8.Location = new System.Drawing.Point(15, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(434, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialButton7
            // 
            this.materialButton7.AutoSize = false;
            this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton7.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton7.Depth = 0;
            this.materialButton7.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = null;
            this.materialButton7.Location = new System.Drawing.Point(-19, -38);
            this.materialButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton7.Size = new System.Drawing.Size(46, 255);
            this.materialButton7.TabIndex = 26;
            this.materialButton7.Text = " \r\n";
            this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton7.UseAccentColor = false;
            this.materialButton7.UseVisualStyleBackColor = true;
            // 
            // materialCard9
            // 
            this.materialCard9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard9.Controls.Add(this.btnDown_1);
            this.materialCard9.Controls.Add(this.btnUp_1);
            this.materialCard9.Controls.Add(this.btnDeselect_1);
            this.materialCard9.Controls.Add(this.materialButton11);
            this.materialCard9.Controls.Add(this.btnSelect_1);
            this.materialCard9.Controls.Add(this.label9);
            this.materialCard9.Depth = 0;
            this.materialCard9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard9.Location = new System.Drawing.Point(480, 13);
            this.materialCard9.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard9.Name = "materialCard9";
            this.materialCard9.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard9.Size = new System.Drawing.Size(192, 202);
            this.materialCard9.TabIndex = 21;
            // 
            // btnDown_1
            // 
            this.btnDown_1.AutoSize = false;
            this.btnDown_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDown_1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnDown_1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDown_1.Depth = 0;
            this.btnDown_1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDown_1.HighEmphasis = true;
            this.btnDown_1.Icon = global::Nigma.Properties.Resources.Down;
            this.btnDown_1.Location = new System.Drawing.Point(18, 160);
            this.btnDown_1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDown_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDown_1.Name = "btnDown_1";
            this.btnDown_1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDown_1.Size = new System.Drawing.Size(147, 36);
            this.btnDown_1.TabIndex = 30;
            this.btnDown_1.Text = "Опустить";
            this.btnDown_1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDown_1.UseAccentColor = false;
            this.btnDown_1.UseVisualStyleBackColor = true;
            this.btnDown_1.Click += new System.EventHandler(this.btnDown_1_Click);
            // 
            // btnUp_1
            // 
            this.btnUp_1.AutoSize = false;
            this.btnUp_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUp_1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnUp_1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUp_1.Depth = 0;
            this.btnUp_1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUp_1.HighEmphasis = true;
            this.btnUp_1.Icon = global::Nigma.Properties.Resources.Up;
            this.btnUp_1.Location = new System.Drawing.Point(18, 118);
            this.btnUp_1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUp_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUp_1.Name = "btnUp_1";
            this.btnUp_1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUp_1.Size = new System.Drawing.Size(147, 36);
            this.btnUp_1.TabIndex = 29;
            this.btnUp_1.Text = "Поднять";
            this.btnUp_1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUp_1.UseAccentColor = false;
            this.btnUp_1.UseVisualStyleBackColor = true;
            this.btnUp_1.Click += new System.EventHandler(this.btnUp_1_Click);
            // 
            // btnDeselect_1
            // 
            this.btnDeselect_1.AutoSize = false;
            this.btnDeselect_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeselect_1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnDeselect_1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeselect_1.Depth = 0;
            this.btnDeselect_1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeselect_1.HighEmphasis = true;
            this.btnDeselect_1.Icon = global::Nigma.Properties.Resources.Delete;
            this.btnDeselect_1.Location = new System.Drawing.Point(18, 76);
            this.btnDeselect_1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeselect_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeselect_1.Name = "btnDeselect_1";
            this.btnDeselect_1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeselect_1.Size = new System.Drawing.Size(147, 36);
            this.btnDeselect_1.TabIndex = 28;
            this.btnDeselect_1.Text = "Снять";
            this.btnDeselect_1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeselect_1.UseAccentColor = false;
            this.btnDeselect_1.UseVisualStyleBackColor = true;
            this.btnDeselect_1.Click += new System.EventHandler(this.btnDeselect_1_Click);
            // 
            // materialButton11
            // 
            this.materialButton11.AutoSize = false;
            this.materialButton11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton11.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton11.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton11.Depth = 0;
            this.materialButton11.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.materialButton11.HighEmphasis = true;
            this.materialButton11.Icon = null;
            this.materialButton11.Location = new System.Drawing.Point(173, -26);
            this.materialButton11.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton11.Name = "materialButton11";
            this.materialButton11.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton11.Size = new System.Drawing.Size(46, 255);
            this.materialButton11.TabIndex = 27;
            this.materialButton11.Text = " \r\n";
            this.materialButton11.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton11.UseAccentColor = false;
            this.materialButton11.UseVisualStyleBackColor = true;
            // 
            // btnSelect_1
            // 
            this.btnSelect_1.AutoSize = false;
            this.btnSelect_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelect_1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnSelect_1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelect_1.Depth = 0;
            this.btnSelect_1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelect_1.HighEmphasis = true;
            this.btnSelect_1.Icon = global::Nigma.Properties.Resources.Check;
            this.btnSelect_1.Location = new System.Drawing.Point(18, 34);
            this.btnSelect_1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelect_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelect_1.Name = "btnSelect_1";
            this.btnSelect_1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSelect_1.Size = new System.Drawing.Size(147, 36);
            this.btnSelect_1.TabIndex = 25;
            this.btnSelect_1.Text = "Выбрать";
            this.btnSelect_1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelect_1.UseAccentColor = false;
            this.btnSelect_1.UseVisualStyleBackColor = true;
            this.btnSelect_1.Click += new System.EventHandler(this.btnSelect_1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(38, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Управление";
            // 
            // materialButton6
            // 
            this.materialButton6.AutoSize = false;
            this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton6.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton6.Depth = 0;
            this.materialButton6.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold);
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = null;
            this.materialButton6.Location = new System.Drawing.Point(14, -30);
            this.materialButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton6.Size = new System.Drawing.Size(658, 39);
            this.materialButton6.TabIndex = 32;
            this.materialButton6.Text = " \r\n";
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton6.UseAccentColor = false;
            this.materialButton6.UseVisualStyleBackColor = true;
            // 
            // materialProgressBar4
            // 
            this.materialProgressBar4.Depth = 0;
            this.materialProgressBar4.Location = new System.Drawing.Point(191, 143);
            this.materialProgressBar4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar4.Name = "materialProgressBar4";
            this.materialProgressBar4.Size = new System.Drawing.Size(100, 5);
            this.materialProgressBar4.TabIndex = 33;
            this.materialProgressBar4.Value = 100;
            // 
            // materialProgressBar6
            // 
            this.materialProgressBar6.Depth = 0;
            this.materialProgressBar6.Location = new System.Drawing.Point(191, 217);
            this.materialProgressBar6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar6.Name = "materialProgressBar6";
            this.materialProgressBar6.Size = new System.Drawing.Size(100, 5);
            this.materialProgressBar6.TabIndex = 35;
            this.materialProgressBar6.Value = 100;
            // 
            // materialProgressBar5
            // 
            this.materialProgressBar5.Depth = 0;
            this.materialProgressBar5.Location = new System.Drawing.Point(191, 228);
            this.materialProgressBar5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar5.Name = "materialProgressBar5";
            this.materialProgressBar5.Size = new System.Drawing.Size(100, 5);
            this.materialProgressBar5.TabIndex = 34;
            this.materialProgressBar5.Value = 100;
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.themeToggle);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(510, 74);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(188, 52);
            this.materialCard7.TabIndex = 17;
            // 
            // themeToggle
            // 
            this.themeToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.themeToggle.AutoSize = true;
            this.themeToggle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.themeToggle.Checked = global::Nigma.Properties.Settings.Default.check4;
            this.themeToggle.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Nigma.Properties.Settings.Default, "check4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.themeToggle.Depth = 0;
            this.themeToggle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.themeToggle.Location = new System.Drawing.Point(15, 8);
            this.themeToggle.Margin = new System.Windows.Forms.Padding(0);
            this.themeToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.themeToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeToggle.Name = "themeToggle";
            this.themeToggle.Ripple = true;
            this.themeToggle.Size = new System.Drawing.Size(149, 37);
            this.themeToggle.TabIndex = 16;
            this.themeToggle.Text = "Select theme";
            this.themeToggle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.themeToggle.UseVisualStyleBackColor = true;
            this.themeToggle.CheckedChanged += new System.EventHandler(this.themeToggle_CheckedChanged);
            // 
            // materialCard8
            // 
            this.materialCard8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard8.Controls.Add(this.materialRadioButton3);
            this.materialCard8.Controls.Add(this.materialRadioButton2);
            this.materialCard8.Controls.Add(this.materialRadioButton1);
            this.materialCard8.Depth = 0;
            this.materialCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard8.Location = new System.Drawing.Point(12, 74);
            this.materialCard8.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard8.Name = "materialCard8";
            this.materialCard8.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard8.Size = new System.Drawing.Size(491, 52);
            this.materialCard8.TabIndex = 18;
            // 
            // materialRadioButton3
            // 
            this.materialRadioButton3.AutoSize = true;
            this.materialRadioButton3.Checked = global::Nigma.Properties.Settings.Default.checked3;
            this.materialRadioButton3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Nigma.Properties.Settings.Default, "checked3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.materialRadioButton3.Depth = 0;
            this.materialRadioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialRadioButton3.Location = new System.Drawing.Point(311, 8);
            this.materialRadioButton3.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton3.Name = "materialRadioButton3";
            this.materialRadioButton3.Ripple = true;
            this.materialRadioButton3.Size = new System.Drawing.Size(176, 37);
            this.materialRadioButton3.TabIndex = 21;
            this.materialRadioButton3.TabStop = true;
            this.materialRadioButton3.Text = "Amber/Оранжевый";
            this.materialRadioButton3.UseVisualStyleBackColor = true;
            this.materialRadioButton3.CheckedChanged += new System.EventHandler(this.materialRadioButton3_CheckedChanged);
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Checked = global::Nigma.Properties.Settings.Default.checked2;
            this.materialRadioButton2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Nigma.Properties.Settings.Default, "checked2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialRadioButton2.Location = new System.Drawing.Point(175, 8);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(119, 37);
            this.materialRadioButton2.TabIndex = 20;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "Blue/Синий";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            this.materialRadioButton2.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Checked = global::Nigma.Properties.Settings.Default.checked1;
            this.materialRadioButton1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Nigma.Properties.Settings.Default, "checked1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialRadioButton1.Location = new System.Drawing.Point(14, 8);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(148, 37);
            this.materialRadioButton1.TabIndex = 19;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Green/Зелёный";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            this.materialRadioButton1.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(713, 566);
            this.Controls.Add(this.materialCard8);
            this.Controls.Add(this.materialCard7);
            this.Controls.Add(this.language_selection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nigma/settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Settings_KeyUp);
            this.language_selection.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.materialCard14.ResumeLayout(false);
            this.materialCard13.ResumeLayout(false);
            this.materialCard13.PerformLayout();
            this.materialCard12.ResumeLayout(false);
            this.materialCard12.PerformLayout();
            this.materialCard11.ResumeLayout(false);
            this.materialCard11.PerformLayout();
            this.materialCard10.ResumeLayout(false);
            this.materialCard10.PerformLayout();
            this.materialCard9.ResumeLayout(false);
            this.materialCard9.PerformLayout();
            this.materialCard7.ResumeLayout(false);
            this.materialCard7.PerformLayout();
            this.materialCard8.ResumeLayout(false);
            this.materialCard8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl language_selection;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblRotorStructure_1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstSelectedRotors_1;
        private System.Windows.Forms.ListBox lstAvailableRotors_1;
        private System.Windows.Forms.ToolTip ttUp_1;
        private System.Windows.Forms.ToolTip ttDeselect_1;
        private System.Windows.Forms.ToolTip ttSelect_1;
        private System.Windows.Forms.ToolTip ttDown_1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label2;
        public MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar2;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.Label label5;
        public MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialComboBox cmbReflector;
        private System.Windows.Forms.Label label6;
        public MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        public MaterialSkin.Controls.MaterialButton btnCancel;
        public MaterialSkin.Controls.MaterialButton btnOk;
        public MaterialSkin.Controls.MaterialButton materialButton8;
        public MaterialSkin.Controls.MaterialButton btnDown;
        public MaterialSkin.Controls.MaterialButton btnUp;
        public MaterialSkin.Controls.MaterialButton btnDeselect;
        public MaterialSkin.Controls.MaterialButton materialButton1;
        public MaterialSkin.Controls.MaterialButton btnSelect;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        public MaterialSkin.Controls.MaterialButton materialButton4;
        public MaterialSkin.Controls.MaterialButton materialButton6;
        private MaterialSkin.Controls.MaterialCard materialCard9;
        public MaterialSkin.Controls.MaterialButton btnDown_1;
        public MaterialSkin.Controls.MaterialButton btnUp_1;
        public MaterialSkin.Controls.MaterialButton btnDeselect_1;
        public MaterialSkin.Controls.MaterialButton materialButton11;
        public MaterialSkin.Controls.MaterialButton btnSelect_1;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialCard materialCard14;
        public MaterialSkin.Controls.MaterialButton btnCancel_1;
        public MaterialSkin.Controls.MaterialButton btnOk_1;
        public MaterialSkin.Controls.MaterialButton materialButton14;
        private MaterialSkin.Controls.MaterialCard materialCard13;
        private MaterialSkin.Controls.MaterialComboBox cmbReflector_1;
        private System.Windows.Forms.Label label13;
        public MaterialSkin.Controls.MaterialButton materialButton10;
        private MaterialSkin.Controls.MaterialCard materialCard12;
        private System.Windows.Forms.Label label12;
        private MaterialSkin.Controls.MaterialCard materialCard11;
        private System.Windows.Forms.Label label11;
        public MaterialSkin.Controls.MaterialButton materialButton9;
        private MaterialSkin.Controls.MaterialCard materialCard10;
        private System.Windows.Forms.Label label10;
        public MaterialSkin.Controls.MaterialButton materialButton7;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar4;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar6;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar5;
        public MaterialSkin.Controls.MaterialSwitch themeToggle;
        public MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        public MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        public MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
    }
}