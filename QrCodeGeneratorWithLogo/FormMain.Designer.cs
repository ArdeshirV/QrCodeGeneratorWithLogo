namespace ArdeshirV.Applications.QrCodeGeneratorWithLogo
{
	using ArdeshirV.Forms;

    partial class FormMain
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
        	this.PictureBoxOutput = new System.Windows.Forms.PictureBox();
        	this.GroupBoxLogo = new System.Windows.Forms.GroupBox();
        	this.GroupBoxBackground = new System.Windows.Forms.GroupBox();
        	this.LabelShadowColor = new System.Windows.Forms.Label();
        	this.LabelDevilIsHere = new System.Windows.Forms.Label();
        	this.LabelShadowBlend = new System.Windows.Forms.Label();
        	this.ComboBoxShadowShape = new System.Windows.Forms.ComboBox();
        	this.LabelShadowShapeLabel = new System.Windows.Forms.Label();
        	this.ButtonBrowseShadowColor = new System.Windows.Forms.Button();
        	this.LabelShadowColorLabel = new System.Windows.Forms.Label();
        	this.TrackBarShadowBlend = new System.Windows.Forms.TrackBar();
        	this.LabelShadowBlendPercent = new System.Windows.Forms.Label();
        	this.CheckBoxEnableShadow = new System.Windows.Forms.CheckBox();
        	this.CheckBoxEnableLogo = new System.Windows.Forms.CheckBox();
        	this.ButtonBrowseLogo = new System.Windows.Forms.Button();
        	this.TextBoxCustom = new System.Windows.Forms.TextBox();
        	this.ComboBoxDefault = new ArdeshirV.Forms.ComboBoxImage();
        	this.RadioButtonCustom = new System.Windows.Forms.RadioButton();
        	this.RadioButtonDefault = new System.Windows.Forms.RadioButton();
        	this.LabelText = new System.Windows.Forms.Label();
        	this.TextBoxInput = new System.Windows.Forms.TextBox();
        	this.ButtonPaste = new System.Windows.Forms.Button();
        	this.ButtonSave = new System.Windows.Forms.Button();
        	this.ButtonExit = new System.Windows.Forms.Button();
        	this.ButtonAbout = new System.Windows.Forms.Button();
        	this.menuStrip = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	((System.ComponentModel.ISupportInitialize)(this.PictureBoxOutput)).BeginInit();
        	this.GroupBoxLogo.SuspendLayout();
        	this.GroupBoxBackground.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.TrackBarShadowBlend)).BeginInit();
        	this.menuStrip.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// PictureBoxOutput
        	// 
        	this.PictureBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.PictureBoxOutput.BackColor = System.Drawing.Color.Transparent;
        	this.PictureBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.PictureBoxOutput.Location = new System.Drawing.Point(292, 12);
        	this.PictureBoxOutput.Name = "PictureBoxOutput";
        	this.PictureBoxOutput.Size = new System.Drawing.Size(100, 100);
        	this.PictureBoxOutput.TabIndex = 0;
        	this.PictureBoxOutput.TabStop = false;
        	// 
        	// GroupBoxLogo
        	// 
        	this.GroupBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.GroupBoxLogo.BackColor = System.Drawing.Color.Transparent;
        	this.GroupBoxLogo.Controls.Add(this.GroupBoxBackground);
        	this.GroupBoxLogo.Controls.Add(this.CheckBoxEnableLogo);
        	this.GroupBoxLogo.Controls.Add(this.ButtonBrowseLogo);
        	this.GroupBoxLogo.Controls.Add(this.TextBoxCustom);
        	this.GroupBoxLogo.Controls.Add(this.ComboBoxDefault);
        	this.GroupBoxLogo.Controls.Add(this.RadioButtonCustom);
        	this.GroupBoxLogo.Controls.Add(this.RadioButtonDefault);
        	this.GroupBoxLogo.Location = new System.Drawing.Point(12, 119);
        	this.GroupBoxLogo.Name = "GroupBoxLogo";
        	this.GroupBoxLogo.Size = new System.Drawing.Size(380, 219);
        	this.GroupBoxLogo.TabIndex = 3;
        	this.GroupBoxLogo.TabStop = false;
        	this.GroupBoxLogo.Text = "&Logo:";
        	// 
        	// GroupBoxBackground
        	// 
        	this.GroupBoxBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.GroupBoxBackground.Controls.Add(this.LabelShadowColor);
        	this.GroupBoxBackground.Controls.Add(this.LabelDevilIsHere);
        	this.GroupBoxBackground.Controls.Add(this.LabelShadowBlend);
        	this.GroupBoxBackground.Controls.Add(this.ComboBoxShadowShape);
        	this.GroupBoxBackground.Controls.Add(this.LabelShadowShapeLabel);
        	this.GroupBoxBackground.Controls.Add(this.ButtonBrowseShadowColor);
        	this.GroupBoxBackground.Controls.Add(this.LabelShadowColorLabel);
        	this.GroupBoxBackground.Controls.Add(this.TrackBarShadowBlend);
        	this.GroupBoxBackground.Controls.Add(this.LabelShadowBlendPercent);
        	this.GroupBoxBackground.Controls.Add(this.CheckBoxEnableShadow);
        	this.GroupBoxBackground.Location = new System.Drawing.Point(10, 99);
        	this.GroupBoxBackground.Name = "GroupBoxBackground";
        	this.GroupBoxBackground.Size = new System.Drawing.Size(359, 108);
        	this.GroupBoxBackground.TabIndex = 6;
        	this.GroupBoxBackground.TabStop = false;
        	this.GroupBoxBackground.Text = "Logo &Background Appearance";
        	// 
        	// LabelShadowColor
        	// 
        	this.LabelShadowColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.LabelShadowColor.BackColor = System.Drawing.Color.White;
        	this.LabelShadowColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.LabelShadowColor.Location = new System.Drawing.Point(250, 17);
        	this.LabelShadowColor.Name = "LabelShadowColor";
        	this.LabelShadowColor.Size = new System.Drawing.Size(24, 22);
        	this.LabelShadowColor.TabIndex = 2;
        	this.LabelShadowColor.Text = "     ";
        	this.LabelShadowColor.Click += new System.EventHandler(this.LabelShadowColor_Click);
        	// 
        	// LabelDevilIsHere
        	// 
        	this.LabelDevilIsHere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.LabelDevilIsHere.Location = new System.Drawing.Point(63, 103);
        	this.LabelDevilIsHere.Name = "LabelDevilIsHere";
        	this.LabelDevilIsHere.Size = new System.Drawing.Size(278, 23);
        	this.LabelDevilIsHere.TabIndex = 9;
        	this.LabelDevilIsHere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// LabelShadowBlend
        	// 
        	this.LabelShadowBlend.AutoSize = true;
        	this.LabelShadowBlend.Location = new System.Drawing.Point(16, 74);
        	this.LabelShadowBlend.Name = "LabelShadowBlend";
        	this.LabelShadowBlend.Size = new System.Drawing.Size(76, 13);
        	this.LabelShadowBlend.TabIndex = 6;
        	this.LabelShadowBlend.Text = "Shadow Blend";
        	// 
        	// ComboBoxShadowShape
        	// 
        	this.ComboBoxShadowShape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.ComboBoxShadowShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.ComboBoxShadowShape.FormattingEnabled = true;
        	this.ComboBoxShadowShape.Items.AddRange(new object[] {
			"Circle",
			"Square"});
        	this.ComboBoxShadowShape.Location = new System.Drawing.Point(94, 47);
        	this.ComboBoxShadowShape.Name = "ComboBoxShadowShape";
        	this.ComboBoxShadowShape.Size = new System.Drawing.Size(255, 21);
        	this.ComboBoxShadowShape.TabIndex = 5;
        	this.ComboBoxShadowShape.SelectedIndexChanged += new System.EventHandler(this.ComboBoxShadowShape_SelectedIndexChanged);
        	// 
        	// LabelShadowShapeLabel
        	// 
        	this.LabelShadowShapeLabel.AutoSize = true;
        	this.LabelShadowShapeLabel.Location = new System.Drawing.Point(9, 50);
        	this.LabelShadowShapeLabel.Name = "LabelShadowShapeLabel";
        	this.LabelShadowShapeLabel.Size = new System.Drawing.Size(83, 13);
        	this.LabelShadowShapeLabel.TabIndex = 4;
        	this.LabelShadowShapeLabel.Text = "Shadow Sha&pe:";
        	// 
        	// ButtonBrowseShadowColor
        	// 
        	this.ButtonBrowseShadowColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.ButtonBrowseShadowColor.Location = new System.Drawing.Point(279, 17);
        	this.ButtonBrowseShadowColor.Name = "ButtonBrowseShadowColor";
        	this.ButtonBrowseShadowColor.Size = new System.Drawing.Size(70, 22);
        	this.ButtonBrowseShadowColor.TabIndex = 3;
        	this.ButtonBrowseShadowColor.Text = "Color...";
        	this.ButtonBrowseShadowColor.UseVisualStyleBackColor = true;
        	this.ButtonBrowseShadowColor.Click += new System.EventHandler(this.ButtonBrowseShadowColor_Click);
        	// 
        	// LabelShadowColorLabel
        	// 
        	this.LabelShadowColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.LabelShadowColorLabel.AutoSize = true;
        	this.LabelShadowColorLabel.Location = new System.Drawing.Point(216, 22);
        	this.LabelShadowColorLabel.Name = "LabelShadowColorLabel";
        	this.LabelShadowColorLabel.Size = new System.Drawing.Size(37, 13);
        	this.LabelShadowColorLabel.TabIndex = 1;
        	this.LabelShadowColorLabel.Text = "Colo&r: ";
        	// 
        	// TrackBarShadowBlend
        	// 
        	this.TrackBarShadowBlend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.TrackBarShadowBlend.BackColor = System.Drawing.SystemColors.ActiveCaption;
        	this.TrackBarShadowBlend.Location = new System.Drawing.Point(94, 74);
        	this.TrackBarShadowBlend.Maximum = 100;
        	this.TrackBarShadowBlend.Name = "TrackBarShadowBlend";
        	this.TrackBarShadowBlend.Size = new System.Drawing.Size(223, 45);
        	this.TrackBarShadowBlend.TabIndex = 7;
        	this.TrackBarShadowBlend.TickFrequency = 5;
        	this.TrackBarShadowBlend.Value = 80;
        	this.TrackBarShadowBlend.Scroll += new System.EventHandler(this.TrackBarBackOpacity_Scroll);
        	// 
        	// LabelShadowBlendPercent
        	// 
        	this.LabelShadowBlendPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.LabelShadowBlendPercent.Location = new System.Drawing.Point(317, 78);
        	this.LabelShadowBlendPercent.Name = "LabelShadowBlendPercent";
        	this.LabelShadowBlendPercent.Size = new System.Drawing.Size(33, 13);
        	this.LabelShadowBlendPercent.TabIndex = 8;
        	this.LabelShadowBlendPercent.Text = "100%";
        	this.LabelShadowBlendPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        	// 
        	// CheckBoxEnableShadow
        	// 
        	this.CheckBoxEnableShadow.AutoSize = true;
        	this.CheckBoxEnableShadow.Location = new System.Drawing.Point(12, 21);
        	this.CheckBoxEnableShadow.Name = "CheckBoxEnableShadow";
        	this.CheckBoxEnableShadow.Size = new System.Drawing.Size(99, 17);
        	this.CheckBoxEnableShadow.TabIndex = 0;
        	this.CheckBoxEnableShadow.Text = "Enable shadow";
        	this.CheckBoxEnableShadow.UseVisualStyleBackColor = true;
        	this.CheckBoxEnableShadow.CheckedChanged += new System.EventHandler(this.CheckBoxEnableShadow_CheckedChanged);
        	// 
        	// CheckBoxEnableLogo
        	// 
        	this.CheckBoxEnableLogo.AutoSize = true;
        	this.CheckBoxEnableLogo.Location = new System.Drawing.Point(10, 19);
        	this.CheckBoxEnableLogo.Name = "CheckBoxEnableLogo";
        	this.CheckBoxEnableLogo.Size = new System.Drawing.Size(158, 17);
        	this.CheckBoxEnableLogo.TabIndex = 0;
        	this.CheckBoxEnableLogo.Text = "&Enable logo inside QR code";
        	this.CheckBoxEnableLogo.UseVisualStyleBackColor = true;
        	this.CheckBoxEnableLogo.CheckedChanged += new System.EventHandler(this.CheckBoxEnableLogo_CheckedChanged);
        	// 
        	// ButtonBrowseLogo
        	// 
        	this.ButtonBrowseLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.ButtonBrowseLogo.Location = new System.Drawing.Point(294, 71);
        	this.ButtonBrowseLogo.Name = "ButtonBrowseLogo";
        	this.ButtonBrowseLogo.Size = new System.Drawing.Size(75, 22);
        	this.ButtonBrowseLogo.TabIndex = 5;
        	this.ButtonBrowseLogo.Text = "&Browse...";
        	this.ButtonBrowseLogo.UseVisualStyleBackColor = true;
        	this.ButtonBrowseLogo.Click += new System.EventHandler(this.ButtonBrowseLogo_Click);
        	// 
        	// TextBoxCustom
        	// 
        	this.TextBoxCustom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.TextBoxCustom.BackColor = System.Drawing.SystemColors.ControlLight;
        	this.TextBoxCustom.Location = new System.Drawing.Point(70, 72);
        	this.TextBoxCustom.Name = "TextBoxCustom";
        	this.TextBoxCustom.ReadOnly = true;
        	this.TextBoxCustom.Size = new System.Drawing.Size(218, 20);
        	this.TextBoxCustom.TabIndex = 4;
        	// 
        	// ComboBoxDefault
        	// 
        	this.ComboBoxDefault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.ComboBoxDefault.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        	this.ComboBoxDefault.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.ComboBoxDefault.FormattingEnabled = true;
        	this.ComboBoxDefault.Images = null;
        	this.ComboBoxDefault.Location = new System.Drawing.Point(70, 42);
        	this.ComboBoxDefault.Name = "ComboBoxDefault";
        	this.ComboBoxDefault.Size = new System.Drawing.Size(299, 21);
        	this.ComboBoxDefault.TabIndex = 2;
        	this.ComboBoxDefault.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDefault_SelectedIndexChanged);
        	// 
        	// RadioButtonCustom
        	// 
        	this.RadioButtonCustom.AutoSize = true;
        	this.RadioButtonCustom.Location = new System.Drawing.Point(10, 74);
        	this.RadioButtonCustom.Name = "RadioButtonCustom";
        	this.RadioButtonCustom.Size = new System.Drawing.Size(63, 17);
        	this.RadioButtonCustom.TabIndex = 3;
        	this.RadioButtonCustom.TabStop = true;
        	this.RadioButtonCustom.Text = "&Custom:";
        	this.RadioButtonCustom.UseVisualStyleBackColor = true;
        	this.RadioButtonCustom.CheckedChanged += new System.EventHandler(this.RadioButtonCustom_CheckedChanged);
        	// 
        	// RadioButtonDefault
        	// 
        	this.RadioButtonDefault.AutoSize = true;
        	this.RadioButtonDefault.Location = new System.Drawing.Point(10, 44);
        	this.RadioButtonDefault.Name = "RadioButtonDefault";
        	this.RadioButtonDefault.Size = new System.Drawing.Size(62, 17);
        	this.RadioButtonDefault.TabIndex = 1;
        	this.RadioButtonDefault.TabStop = true;
        	this.RadioButtonDefault.Text = "&Default:";
        	this.RadioButtonDefault.UseVisualStyleBackColor = true;
        	this.RadioButtonDefault.CheckedChanged += new System.EventHandler(this.RadioButtonDefault_CheckedChanged);
        	// 
        	// LabelText
        	// 
        	this.LabelText.AutoSize = true;
        	this.LabelText.BackColor = System.Drawing.Color.Transparent;
        	this.LabelText.Location = new System.Drawing.Point(12, 33);
        	this.LabelText.Name = "LabelText";
        	this.LabelText.Size = new System.Drawing.Size(31, 13);
        	this.LabelText.TabIndex = 0;
        	this.LabelText.Text = "&Text:";
        	// 
        	// TextBoxInput
        	// 
        	this.TextBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.TextBoxInput.Location = new System.Drawing.Point(12, 49);
        	this.TextBoxInput.Multiline = true;
        	this.TextBoxInput.Name = "TextBoxInput";
        	this.TextBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        	this.TextBoxInput.Size = new System.Drawing.Size(274, 63);
        	this.TextBoxInput.TabIndex = 2;
        	this.TextBoxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
        	// 
        	// ButtonPaste
        	// 
        	this.ButtonPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.ButtonPaste.Location = new System.Drawing.Point(200, 27);
        	this.ButtonPaste.Name = "ButtonPaste";
        	this.ButtonPaste.Size = new System.Drawing.Size(87, 22);
        	this.ButtonPaste.TabIndex = 1;
        	this.ButtonPaste.Text = "&Paste";
        	this.ButtonPaste.UseVisualStyleBackColor = true;
        	this.ButtonPaste.Click += new System.EventHandler(this.ButtonPaste_Click);
        	// 
        	// ButtonSave
        	// 
        	this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.ButtonSave.Enabled = false;
        	this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	this.ButtonSave.Location = new System.Drawing.Point(12, 343);
        	this.ButtonSave.Name = "ButtonSave";
        	this.ButtonSave.Size = new System.Drawing.Size(263, 26);
        	this.ButtonSave.TabIndex = 4;
        	this.ButtonSave.Text = "&Save As Image...";
        	this.ButtonSave.UseVisualStyleBackColor = true;
        	this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
        	// 
        	// ButtonExit
        	// 
        	this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        	this.ButtonExit.Location = new System.Drawing.Point(342, 343);
        	this.ButtonExit.Name = "ButtonExit";
        	this.ButtonExit.Size = new System.Drawing.Size(50, 26);
        	this.ButtonExit.TabIndex = 7;
        	this.ButtonExit.Text = "E&xit";
        	this.ButtonExit.UseVisualStyleBackColor = true;
        	this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
        	// 
        	// ButtonAbout
        	// 
        	this.ButtonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.ButtonAbout.Location = new System.Drawing.Point(281, 343);
        	this.ButtonAbout.Name = "ButtonAbout";
        	this.ButtonAbout.Size = new System.Drawing.Size(55, 26);
        	this.ButtonAbout.TabIndex = 6;
        	this.ButtonAbout.Text = "&About...";
        	this.ButtonAbout.UseVisualStyleBackColor = true;
        	this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
        	// 
        	// menuStrip
        	// 
        	this.menuStrip.BackColor = System.Drawing.Color.Transparent;
        	this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.editToolStripMenuItem,
			this.helpToolStripMenuItem});
        	this.menuStrip.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip.Name = "menuStrip";
        	this.menuStrip.Size = new System.Drawing.Size(404, 24);
        	this.menuStrip.TabIndex = 8;
        	this.menuStrip.Text = "menuStrip1";
        	// 
        	// fileToolStripMenuItem
        	// 
        	this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.saveAsImageToolStripMenuItem,
			this.toolStripMenuItem1,
			this.exitToolStripMenuItem});
        	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        	this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        	this.fileToolStripMenuItem.Text = "&File";
        	// 
        	// saveAsImageToolStripMenuItem
        	// 
        	this.saveAsImageToolStripMenuItem.Image = global::ArdeshirV.Applications.QrCodeGeneratorWithLogo.Properties.Resources.Save_Picture;
        	this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
        	this.saveAsImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
        	this.saveAsImageToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
        	this.saveAsImageToolStripMenuItem.Text = "&Save As Image...";
        	this.saveAsImageToolStripMenuItem.Click += new System.EventHandler(this.ButtonSave_Click);
        	// 
        	// toolStripMenuItem1
        	// 
        	this.toolStripMenuItem1.Name = "toolStripMenuItem1";
        	this.toolStripMenuItem1.Size = new System.Drawing.Size(196, 6);
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
        	this.exitToolStripMenuItem.Text = "E&xit";
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.ButtonExit_Click);
        	// 
        	// editToolStripMenuItem
        	// 
        	this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.pasteToolStripMenuItem});
        	this.editToolStripMenuItem.Name = "editToolStripMenuItem";
        	this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
        	this.editToolStripMenuItem.Text = "&Edit";
        	// 
        	// pasteToolStripMenuItem
        	// 
        	this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
        	this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
			| System.Windows.Forms.Keys.V)));
        	this.pasteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
        	this.pasteToolStripMenuItem.Text = "&Paste";
        	this.pasteToolStripMenuItem.Click += new System.EventHandler(this.ButtonPaste_Click);
        	// 
        	// helpToolStripMenuItem
        	// 
        	this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aboutToolStripMenuItem});
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        	this.helpToolStripMenuItem.Text = "&Help";
        	// 
        	// aboutToolStripMenuItem
        	// 
        	this.aboutToolStripMenuItem.Image = global::ArdeshirV.Applications.QrCodeGeneratorWithLogo.Properties.Resources.About;
        	this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        	this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
        	this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
        	this.aboutToolStripMenuItem.Text = "&About...";
        	this.aboutToolStripMenuItem.Click += new System.EventHandler(this.ButtonAbout_Click);
        	// 
        	// FormMain
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.CancelButton = this.ButtonExit;
        	this.ClientSize = new System.Drawing.Size(404, 381);
        	this.Controls.Add(this.ButtonAbout);
        	this.Controls.Add(this.ButtonExit);
        	this.Controls.Add(this.ButtonSave);
        	this.Controls.Add(this.ButtonPaste);
        	this.Controls.Add(this.TextBoxInput);
        	this.Controls.Add(this.LabelText);
        	this.Controls.Add(this.GroupBoxLogo);
        	this.Controls.Add(this.PictureBoxOutput);
        	this.Controls.Add(this.menuStrip);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MainMenuStrip = this.menuStrip;
        	this.MaximizeBox = false;
        	this.MinimumSize = new System.Drawing.Size(320, 420);
        	this.Name = "FormMain";
        	this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
        	this.Text = "Qr Code Generator with Logo";
        	this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMainFormClosed);
        	this.Shown += new System.EventHandler(this.FormMainShown);
        	((System.ComponentModel.ISupportInitialize)(this.PictureBoxOutput)).EndInit();
        	this.GroupBoxLogo.ResumeLayout(false);
        	this.GroupBoxLogo.PerformLayout();
        	this.GroupBoxBackground.ResumeLayout(false);
        	this.GroupBoxBackground.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.TrackBarShadowBlend)).EndInit();
        	this.menuStrip.ResumeLayout(false);
        	this.menuStrip.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxOutput;
        private System.Windows.Forms.GroupBox GroupBoxLogo;
        private ComboBoxImage ComboBoxDefault;
        private System.Windows.Forms.RadioButton RadioButtonCustom;
        private System.Windows.Forms.RadioButton RadioButtonDefault;
        private System.Windows.Forms.Button ButtonBrowseLogo;
        private System.Windows.Forms.TextBox TextBoxCustom;
        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Button ButtonPaste;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonAbout;
        private System.Windows.Forms.TrackBar TrackBarShadowBlend;
        private System.Windows.Forms.CheckBox CheckBoxEnableLogo;
        private System.Windows.Forms.GroupBox GroupBoxBackground;
        private System.Windows.Forms.Button ButtonBrowseShadowColor;
        private System.Windows.Forms.Label LabelShadowColor;
        private System.Windows.Forms.Label LabelShadowColorLabel;
        private System.Windows.Forms.CheckBox CheckBoxEnableShadow;
        private System.Windows.Forms.ComboBox ComboBoxShadowShape;
        private System.Windows.Forms.Label LabelShadowShapeLabel;
        private System.Windows.Forms.Label LabelShadowBlendPercent;
        private System.Windows.Forms.Label LabelShadowBlend;
        private System.Windows.Forms.Label LabelDevilIsHere;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    }
}

