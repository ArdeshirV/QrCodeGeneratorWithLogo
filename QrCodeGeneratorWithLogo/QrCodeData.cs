#region Header

// QrCodeData.cs: Provides QR code generator that is independent from interface.
// Copyright© 2021 ArdeshirV@protonmail.com, Licensed under LGPLv3+

using System;
using System.IO;
using System.Drawing;
using ArdeshirV.Forms;
using System.Drawing.Imaging;
using ArdeshirV.Tools.QrCode;
using System.Drawing.Drawing2D;

#endregion Header
//---------------------------------------------------------------------------------------
namespace ArdeshirV.Applications.QrCodeGeneratorWithLogo
{
    #region Enumerations
    internal enum ShadowShape
    {
        Circle = 0, Square = 1
    }
    #endregion
    //-----------------------------------------------------------------------------------
    internal class QrCodeData
    {
        #region Variables

        private int intScale;
        private int intBorder;
        private Size sizeImage;
        private string stringText;
        private bool boolEnabledLogo;
        private bool boolDefaultLogo;
        private bool boolAliveLayout;
        private bool boolEnabledShadow;
        private Color colorShadowColor;
        private ShadowShape shadowShape;
        private string stringDefaultLogo;
        private int intShadowBlendPercent;
        private string stringCustomLogoPath;

        #endregion
        //-------------------------------------------------------------------------------
        #region Events

        public delegate void UpdateImage(Image qr);
        public event UpdateImage UpdateImageTrigger;

        #endregion
        //-------------------------------------------------------------------------------
        #region Constructor
        public QrCodeData(Size sizeCanvas)
        {
            InitData();
   		 	sizeImage = sizeCanvas;
        }
        #endregion
        //-------------------------------------------------------------------------------
        #region Utility Methods
        private void InitData()
        {
        	intScale = 4;
        	intBorder = 1;
        	boolAliveLayout = true;
            boolDefaultLogo = true;
            boolEnabledLogo = true;
            boolEnabledShadow = true;
            stringText = string.Empty;
            intShadowBlendPercent = 80;
            stringDefaultLogo = "Bitcoin";
            colorShadowColor = Color.White;
        	sizeImage = new Size(100, 100);
            shadowShape = ShadowShape.Circle;
            stringCustomLogoPath = string.Empty;
        }
        //-------------------------------------------------------------------------------
        public void Update()
        {
        	if(boolAliveLayout)
        		UpdateImageTrigger.Invoke(this.Image);
        }
        //-------------------------------------------------------------------------------
        public void SuspendLayout()
        {
        	boolAliveLayout = false;
        }
        //-------------------------------------------------------------------------------
        public void ResumeLayout()
        {
        	boolAliveLayout = true;
        	Update();
        }
        //-------------------------------------------------------------------------------
        public void SaveImage(string stringFileName)
        {
        	Size sizeBack = sizeImage;
        	int intScaleBack = intScale;

        	try {
        		intScale = 9;
	        	QrCode qr = GetQrCode();
	        	if(qr != null) {
		        	int intImageSize = qr.Size * intScale;
		        	sizeImage = new Size(intImageSize, intImageSize);
		        	DrawQrCode(qr).Save(stringFileName, ImageFormat.Png);
	        	} else
	        		throw new ApplicationException("The input text is too long.");
        	} finally {
	        	sizeImage = sizeBack;
	        	intScale = intScaleBack;
        	}
        }
        //-------------------------------------------------------------------------------
        private QrCode GetQrCode()
        {
        	try {
        		return QrCode.EncodeText(stringText, QrCode.Ecc.High);
        	} catch {
        		throw new ApplicationException("The input text is too long.");
        	}
        }
        //-------------------------------------------------------------------------------
        private Image DrawQrCode(QrCode qr)
        {
        	if(qr == null) return null;
        	Image code = qr.ToBitmap(intScale, intBorder);
        	Image canvas = new Bitmap(sizeImage.Width, sizeImage.Height);
    		Graphics g = Graphics.FromImage(canvas);
			g.SmoothingMode = SmoothingMode.AntiAlias;
			g.DrawImage(code, 0, 0, sizeImage.Width, sizeImage.Height);
        	
    		if(boolEnabledLogo) {
	        	const int Divider = 3, marj = 1;
	        	int pbWidth = sizeImage.Width, wDiv5 = pbWidth / Divider;
	        	int pbHeight = sizeImage.Height, hDiv5 = pbHeight / Divider;
	        	int x1 = wDiv5 * marj, y1 = hDiv5 * marj;
        		
        		if(boolEnabledShadow) {
		        	int intPercent = (int)(intShadowBlendPercent * 255 / 100);
		        	Brush brush = new SolidBrush(
		        		Color.FromArgb(intPercent, colorShadowColor));
        			switch(shadowShape) {
        				case ShadowShape.Circle:
        					g.FillEllipse(brush, x1, y1, hDiv5, hDiv5);
        					break;
        				case ShadowShape.Square:
        					g.FillRectangle(brush, x1, y1, hDiv5, hDiv5);
        					break;
        				default:
        					throw new Exception(string.Format(
        						"Drawing the \"{0}\" is not implemented in QeCodeData.Image.get",
        						shadowShape.ToString()));
        			}
        			brush.Dispose();
        		}
        		
    			if(boolDefaultLogo) {  // Draw by one of predefined logos
    				try {
	        			// Message(stringDefaultLogo);  // Code test
    					Image logo = GlobalResouces.CurrencyLogos.
    						GetItemByName(stringDefaultLogo);
        				g.DrawImage(logo, x1, y1, hDiv5, hDiv5);
    				} catch(Exception exp) {
    					throw new FileLoadException(string.Format(
    						"\"{0}\" not found in GlobalResouces.CurrencyLogos.Items",
    						stringDefaultLogo), exp);
    				}
    			} else {  // Draw by custom logo
    				if(File.Exists(stringCustomLogoPath)) {
    					Image logo = Image.FromFile(stringCustomLogoPath);
    					g.DrawImage(logo, x1, y1, hDiv5, hDiv5);
	        		} else if(stringCustomLogoPath != string.Empty) {
	        			// Throw error only if file is set but not exists
	        			// Empty means not set
	        			throw new FileNotFoundException(string.Format(
	        				"The image file \"{0}\" not found.",
	        				stringCustomLogoPath));
	        		}
	        	}
			}
	        return canvas;
        }
        #endregion
        //-------------------------------------------------------------------------------
        #region Properties
        public Image Image
        {
            get {
            	return DrawQrCode(GetQrCode());
            }
        }
        //-------------------------------------------------------------------------------
        public string SVG
        {
        	get {
        		return GetQrCode().ToSvgString(intBorder);
        	}
        }
        //-------------------------------------------------------------------------------
        public string Text
        {
            set {
                stringText = value;
                Update();
            }
            get {
                return stringText;
            }
        }
        //-------------------------------------------------------------------------------
        public bool DefaultLogoEnabled
        {
            set {
                boolDefaultLogo = value;
                Update();
            }
            get {
                return boolDefaultLogo;
            }
        }
        //-------------------------------------------------------------------------------
        public bool EnabledLogo
        {
            set {
                boolEnabledLogo = value;
                Update();
            }
            get {
                return boolEnabledLogo;
            }
        }
        //-------------------------------------------------------------------------------
        public string CustomLogo
        {
            set {
                stringCustomLogoPath = value;
                Update();
            }
            get {
                return stringCustomLogoPath;
            }
        }
        //-------------------------------------------------------------------------------
        public Color ShadowColor
        {
            set {
                colorShadowColor = value;
                Update();
            }
            get {
                return colorShadowColor;
            }
        }
        //-------------------------------------------------------------------------------
        public int ShadowBlendPercent
        {
            set {
                intShadowBlendPercent = value;
                Update();
            }
            get {
                return intShadowBlendPercent;
            }
        }
        //-------------------------------------------------------------------------------
        public ShadowShape ShadowShape
        {
            set {
                shadowShape = value;
                Update();
            }
            get {
                return shadowShape;
            }
        }
        //-------------------------------------------------------------------------------
        public bool EnabledShadow
        {
            set {
                boolEnabledShadow = value;
                Update();
            }
            get {
                return boolEnabledShadow;
            }
        }
        //-------------------------------------------------------------------------------
        public Size OutputSize
        {
        	get {
        		return sizeImage;
        	}
        	set {
        		sizeImage = value;
        		Update();
        	}
        }
        //-------------------------------------------------------------------------------
        public string DefaultLogo
        {
            set {
            	if(GlobalResouces.CurrencyLogos.Contains(value)) {
                	stringDefaultLogo = value;
                	Update();
            	} else {
            		throw new Exception(string.Format("The \"{0}\" not found in Gl" +
                    	"obalResouces.CurrencyLogos. Error happend i" +
                    	"n QrCodeData.DefaultLogo.set.", value));
            	}
            }
            get {
                return stringDefaultLogo;
            }
        }
        #endregion
    }
}
