#region Header

// FormMain.cs: Defines the main windows-form of QrCodeGeneratorWithLogo
// Copyright© 2021 ArdeshirV@protonmail.com, Licensed under LGPLv3+

using System;
using System.IO;
using System.Drawing;
using ArdeshirV.Forms;
using System.Windows.Forms;
using ArdeshirV.Applications.QrCodeGeneratorWithLogo.Properties;

#endregion Header
//---------------------------------------------------------------------------------------
namespace ArdeshirV.Applications.QrCodeGeneratorWithLogo
{
    public partial class FormMain : FormBase
    {
        #region Variables

        private QrCodeData qr;
        private const int intMaxTextLength = 1273;
        private const string _stringEmail = "ArdeshirV@protonmail.com";
        private const string _stringWebsite =
        	"https://ArdeshirV.github.io/QrCodeGeneratorWithLogo/";
        private const string _stringGithub =
        	"https://github.com/ArdeshirV/QrCodeGeneratorWithLogo";

        #endregion Variables
        //-------------------------------------------------------------------------------
        #region Constructor
        public FormMain()
        {
            InitializeComponent();
            EnableSaveAbility(false);
            qr = new QrCodeData(PictureBoxOutput.ClientSize);
            qr.SuspendLayout();
            qr.UpdateImageTrigger += UpdateOutput;
            MoveFormWithMouse = false;
        }
        #endregion Constructor
        //-------------------------------------------------------------------------------
        #region Event Handlers
		private void FormMainShown(object sender, EventArgs e)
		{
			// Here method call order is very important!
			SuspendLayout();
            qr.SuspendLayout();
            LoadSettings();
            if(qr.CustomLogo != string.Empty && !File.Exists(qr.CustomLogo)) {
            	qr.CustomLogo = TextBoxInput.Text = string.Empty;
            	FormMessage.Show(this, Text, string.Format(
            		"The image file \"{0}\" not found.", qr.CustomLogo),
            		MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateComboBoxDefaultValues();
            UpdateAppByQrData();
			UpdateTrackBarPosition();
			try {
				qr.ResumeLayout();
			} catch(FileNotFoundException exp) {
				qr.CustomLogo = TextBoxInput.Text = string.Empty;
				qr.ResumeLayout();
				HandleException(exp);
			} finally {
				TextBoxInput.Focus();
				TextBoxInput.SelectionLength = 0;
				TextBoxInput.SelectionStart = TextBoxInput.Text.Length;
			}
        	ResumeLayout();
		}
        //-------------------------------------------------------------------------------
        private void ButtonPaste_Click(object sender, EventArgs e)
        {
        	string stringClipboard = Clipboard.GetText();
        	int intBack = TextBoxInput.SelectionStart;
        	TextBoxInput.Text = TextBoxInput.Text.Insert(
        		TextBoxInput.SelectionStart, stringClipboard);
        	TextBoxInput.SelectionStart = intBack + stringClipboard.Length;
        	TextBoxInput.Focus();
        }
        //-------------------------------------------------------------------------------
        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {
        	UpdateTextInput();
        }
        //-------------------------------------------------------------------------------
        private void CheckBoxEnableLogo_CheckedChanged(object sender, EventArgs e)
        {
        	try {
        		qr.SuspendLayout();
	        	TextBoxCustom.Enabled =
	        	ComboBoxDefault.Enabled =
	        	ButtonBrowseLogo.Enabled =
	        	RadioButtonCustom.Enabled =
	        	RadioButtonDefault.Enabled =
	        	CheckBoxEnableShadow.Checked =
	        	CheckBoxEnableShadow.Enabled =
	            qr.EnabledLogo = CheckBoxEnableLogo.Checked;
	        	qr.ResumeLayout();
        	} catch(Exception exp) {
        		HandleException(exp);
        	}
        }
        //-------------------------------------------------------------------------------
        private void RadioButtonDefault_CheckedChanged(object sender, EventArgs e)
        {
        	try {
	        	TextBoxCustom.Enabled =
	        	ButtonBrowseLogo.Enabled =
	        	!(ComboBoxDefault.Enabled =
	        	  qr.DefaultLogoEnabled = RadioButtonDefault.Checked);
        	} catch(Exception exp) {
        		HandleException(exp);
        	}
        }
        //-------------------------------------------------------------------------------
        private void RadioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
        	try {
        		if(RadioButtonCustom.Checked && TextBoxCustom.Text == string.Empty)
        			ButtonBrowseLogo_Click(sender, e);
        	} catch(Exception exp) {
        		HandleException(exp);
        	}
        }
        //-------------------------------------------------------------------------------
        private void ComboBoxDefault_SelectedIndexChanged(object sender, EventArgs e)
        {
        	if(ComboBoxDefault.SelectedIndex >= 0) {
        		try {
        			qr.DefaultLogo = (string)ComboBoxDefault.SelectedItem;
	        	} catch(Exception exp) {
	        		HandleException(exp);
	        	}
        	}
        }
        //-------------------------------------------------------------------------------
        private void ButtonBrowseLogo_Click(object sender, EventArgs e)
        {
        	var open = new OpenFileDialog();
        	open.Filter = "Images (*.jpg;*.jpeg;*.png;*.bmp;*.jfif)" +
        		          "|*.jpg;*.jpeg;*.png;*.bmp;*.jfif";
        	open.Title = "Open Image as Logo on QR Code";
        	bool boolBack = MoveFormWithMouse;
        	this.MoveFormWithMouse = false;
        	if(open.ShowDialog(this) == DialogResult.OK) {
        		try {
        			TextBoxCustom.Text = qr.CustomLogo = open.FileName;
	        	} catch(Exception exp) {
	        		HandleException(exp);
	        	}
        	}
        	this.MoveFormWithMouse = boolBack;
        }
        //-------------------------------------------------------------------------------
        private void CheckBoxEnableShadow_CheckedChanged(object sender, EventArgs e)
        {
        	try {
	        	qr.EnabledShadow =
	        	LabelShadowColor.Enabled =
	        	LabelShadowBlend.Enabled =
	        	ComboBoxShadowShape.Enabled =
	        	TrackBarShadowBlend.Enabled =
	        	LabelShadowColorLabel.Enabled =
	        	LabelShadowBlendPercent.Enabled =
	        	ButtonBrowseShadowColor.Enabled =
	        	LabelShadowShapeLabel.Enabled = CheckBoxEnableShadow.Checked;
        	} catch(Exception exp) {
        		HandleException(exp);
        	}
        }
        //-------------------------------------------------------------------------------
        private void LabelShadowColor_Click(object sender, EventArgs e)
        {
        	ButtonBrowseShadowColor_Click(sender, e);
        }
        //-------------------------------------------------------------------------------
        private void ButtonBrowseShadowColor_Click(object sender, EventArgs e)
        {
        	var color = new ColorDialog();
        	color.Color = qr.ShadowColor;
        	color.SolidColorOnly = false;
        	bool boolBack = MoveFormWithMouse;
        	this.MoveFormWithMouse = false;
        	if(color.ShowDialog(this) == DialogResult.OK) {
        		try {
        	 		LabelShadowColor.BackColor = qr.ShadowColor = color.Color;
	        	} catch(Exception exp) {
	        		HandleException(exp);
	        	}
        	}
        	this.MoveFormWithMouse = boolBack;
        }
        //-------------------------------------------------------------------------------
        private void ComboBoxShadowShape_SelectedIndexChanged(object sender, EventArgs e)
        {
        	if(ComboBoxShadowShape.SelectedIndex >= 0) {
        		try {
        			qr.ShadowShape = (ShadowShape)ComboBoxShadowShape.SelectedIndex;
	        	} catch(Exception exp) {
	        		HandleException(exp);
	        	}
        	}
        }
        //-------------------------------------------------------------------------------
        private void TrackBarBackOpacity_Scroll(object sender, EventArgs e)
        {
        	UpdateTrackBarPosition();
        }
        //-------------------------------------------------------------------------------
        private void ButtonSave_Click(object sender, EventArgs e)
        {
        	var save = new SaveFileDialog();
        	save.AddExtension = true;
        	save.DefaultExt = "*.png";
        	save.Filter = "PNG (*.png)|*.png";
        	save.Title = "Save Qr Code as PNG Image";
        	try {
        		if(save.ShowDialog(this) == DialogResult.OK) {
	        		qr.SaveImage(save.FileName);
	                EnableSaveAbility(true);
        		}
        	} catch(Exception exp) {
        		HandleException(exp);
        	}
        }
        //-------------------------------------------------------------------------------
        private void ButtonSaveAsSVG_Click(object sender, EventArgs e)
        {
        	var save = new SaveFileDialog();
        	save.AddExtension = true;
        	save.DefaultExt = "*.svg";
        	save.Filter = "SVG (*.svg)|*.svg";
        	save.Title = "Save Qr Code as SVG Image";        	
        	try {
        		if(save.ShowDialog(this) == DialogResult.OK) {
        			System.IO.File.WriteAllText(save.FileName, qr.SVG);
	                EnableSaveAbility(true);
        		}
        	} catch(Exception exp) {
        		HandleException(exp);
        	}
        }
        //-------------------------------------------------------------------------------
        private void ButtonAbout_Click(object sender, EventArgs e)
        {
			string stringAssemblyProductName = Application.ProductName;

			var donations = new Donations[] {
				new Donations( 
				stringAssemblyProductName,
				DefaultDonationList.Items)};
			
			string stringCreditDesc = string.Format(
@"ArdeshirV is creator and developer of ""QrCodeGeneratorWithLogo""
Web Site: {0}
Github: {1}
Email: {2}", _stringWebsite, _stringGithub, _stringEmail);
			
			var credits = new Credits[] {
				new Credits(stringAssemblyProductName, new Credit[] {
				            	new Credit(
				            		"ArdeshirV",
				            		stringCreditDesc, GlobalResouces.AuthorsPhotos.ArdeshirV),
				            	new Credit("Muhammad Haq - Qr Code Icon",
@"qr, code icon

Copyrights(c) Muhammad Haq, Licensed under Creative Commons(Attribution-NonCommercial 3.0 unported)

Shared by freeicons.io
Download Reference: https://freeicons.io/user-interface-icons-7/qr-code-icon-37247", Resources.QrCodeLogo)
				            })
			};
			
			var copyrights = new Copyright[] {
				new Copyright(this, Resources.QrCodeLogo)
			};
			
			var licenses = new License[] {
				new License(stringAssemblyProductName,
				            GlobalResouces.Licenses.GPLLicense,
				            GlobalResouces.Licenses.GPLLicenseLogo)
			};
			
        	var data = new FormAboutData(this,
			                             copyrights,
										 credits,
										 licenses,
										 donations,
										 _stringWebsite,
										 _stringEmail);
        	FormAbout.Show(data);
        }
        //-------------------------------------------------------------------------------
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //-------------------------------------------------------------------------------
		void FormMainFormClosed(object sender, FormClosedEventArgs e)
		{
			SaveSettings();
		}
        #endregion
        //-------------------------------------------------------------------------------
        #region Utility Methods
        private void LoadSettings()
        {
            try {
	        	Settings.Default.Reload();
	        	qr.Text = Settings.Default.QRText;
	        	Width = Settings.Default.FormMainWidth;
	        	Height = Settings.Default.FormMainHeight;
	        	Location = Settings.Default.FormMainLocation;
	        	qr.EnabledLogo = Settings.Default.QRLogoEnable;
	        	qr.ShadowColor = Settings.Default.QRShadowColor;
	        	qr.DefaultLogo = Settings.Default.QRDefaultLogo;
	        	qr.CustomLogo = Settings.Default.QRCustomLogoPath;
	        	qr.EnabledShadow = Settings.Default.QRShadowEnable;
	        	qr.ShadowBlendPercent = Settings.Default.QRShadowPercent;
	        	qr.DefaultLogoEnabled = Settings.Default.QRDefaultLogoEnable;
	        	qr.ShadowShape = (ShadowShape)Settings.Default.QRShadowShape;
        	} catch(Exception exp) {
        		Warning(exp.Message);
        		UpdateAppByQrData();
        	}
        }
        //-------------------------------------------------------------------------------
        private void SaveSettings()
        {
        	try {
	        	Settings.Default.QRText = qr.Text;
	        	Settings.Default.FormMainWidth = Width;
	        	Settings.Default.FormMainHeight = Height;
	        	Settings.Default.FormMainLocation = Location;
	        	Settings.Default.QRLogoEnable = qr.EnabledLogo;
	        	Settings.Default.QRShadowColor = qr.ShadowColor;
	        	Settings.Default.QRDefaultLogo = qr.DefaultLogo;
	        	Settings.Default.QRCustomLogoPath = qr.CustomLogo;
	        	Settings.Default.QRShadowEnable = qr.EnabledShadow;
	        	Settings.Default.QRShadowShape = (int)qr.ShadowShape;
	        	Settings.Default.QRShadowPercent = qr.ShadowBlendPercent;
	        	Settings.Default.QRDefaultLogoEnable = qr.DefaultLogoEnabled;
	        	Settings.Default.Save();
        	} catch(Exception exp) {
        		HandleException(exp);
        	}
        }
        //-------------------------------------------------------------------------------
        private void UpdateComboBoxDefaultValues()
        {
        	string i = string.Empty;
        	try {
	        	var imgList = new ImageList();
	        	ComboBoxDefault.Images = imgList;
	        	foreach(string item in GlobalResouces.CurrencyLogos.NamesList) {
	        		i = item;
	        		ComboBoxDefault.Items.Add(item);
	        		imgList.Images.Add(item, GlobalResouces.CurrencyLogos.
	        		                   GetItemByName(item));
	        	}
	        	ComboBoxDefault.SuspendLayout();
	        	ComboBoxDefault.Images = imgList;
	        	ComboBoxDefault.SelectedIndex = ComboBoxDefault.Items.IndexOf(qr.DefaultLogo);
	            ComboBoxDefault.ResumeLayout();
        	} catch {
        		const string stringTemp = "Failed to retrieve \"{0}\" " +
        			"with GlobalResouces.CurrencyLogos.GetItem(...) " +
        			"in FormMain.UpdateComboBoxDefaultValues";
        		throw new Exception(string.Format(stringTemp, i));
        	}
        }
        //-------------------------------------------------------------------------------
        private void UpdateAppByQrData()
        {
        	TextBoxInput.Text = qr.Text;
        	TextBoxCustom.Text = qr.CustomLogo;
        	LabelShadowColor.BackColor = qr.ShadowColor;
        	CheckBoxEnableLogo.Checked = qr.EnabledLogo;
        	CheckBoxEnableShadow.Checked = qr.EnabledShadow;
        	TrackBarShadowBlend.Value = qr.ShadowBlendPercent;
        	RadioButtonCustom.Checked = !qr.DefaultLogoEnabled;
        	RadioButtonDefault.Checked = qr.DefaultLogoEnabled;
        	ComboBoxShadowShape.SelectedIndex = (int)qr.ShadowShape;
        }
        //-------------------------------------------------------------------------------
        private void UpdateTextInput()
        {
            try {
        		if(TextBoxInput.Text.Length <= intMaxTextLength) {
	                qr.Text = TextBoxInput.Text;
	                Application.DoEvents();
	                EnableSaveAbility(TextBoxInput.Text.Length > 0);
        		} else {
        			qr.Text = TextBoxInput.Text =
        				TextBoxInput.Text.Substring(0, intMaxTextLength);
	                Warning(string.Format(
	                	"The maximum acceptable length of input text is {0} character",
	                	intMaxTextLength));
        		}
        	} catch(Exception exp) {
        		HandleException(exp);
        	}
        }
        //-------------------------------------------------------------------------------
        private void UpdateTrackBarPosition()
        {
        	int alphaValue = (int)(TrackBarShadowBlend.Value * 255 / 100);
            LabelShadowColor.BackColor = Color.FromArgb(
            	alphaValue, qr.ShadowColor);
            LabelShadowBlendPercent.Text =
            	string.Format("{0}%", TrackBarShadowBlend.Value);
            try {
            	qr.ShadowBlendPercent = TrackBarShadowBlend.Value;
        	} catch(Exception exp) {
        		HandleException(exp);
        	}
        }
        //-------------------------------------------------------------------------------
        private void EnableSaveAbility(bool boolIsEnable)
        {
        	saveAsImageToolStripMenuItem.Enabled =
            ButtonSave.Enabled = /*ButtonSaveAsSVG.Enabled =*/ boolIsEnable;
        }
        //-------------------------------------------------------------------------------
        private void UpdateOutput(Image img)
        {
        	try {
            	PictureBoxOutput.Image = img;
                EnableSaveAbility(true);
            	Application.DoEvents();
        	} catch(Exception exp) {
        		HandleException(exp);
        	}
        }
        //-------------------------------------------------------------------------------
        private void HandleException(Exception exp) 
        {
    		EnableSaveAbility(false);
    		Warning(exp.Message);
    		TextBoxInput.SelectAll();
    		TextBoxInput.Focus();
        }
        //-------------------------------------------------------------------------------
        private void Warning(string stringMessage)
    	{
            FormMessage.Show(null, stringMessage, Text,
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Warning);
        }
        #endregion Utility Methods
    }
}
