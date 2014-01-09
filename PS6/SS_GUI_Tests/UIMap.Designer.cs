﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace SS_GUI_Tests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// file->new clicked
        /// </summary>
        public void FileNew()
        {
            #region Variable Declarations
            WinMenuItem uINewMenuItem = this.UISpreadSheetsheet0Window.UIFile_menuMenuBar.UIFileMenuItem.UINewMenuItem;
            #endregion

            // Launch '%VisualStudioDir%\Projects\PS6\SpreadsheetGUI\bin\x86\Debug\SpreadsheetGUI.exe'
            ApplicationUnderTest uISpreadSheetsheet0Window = ApplicationUnderTest.Launch(this.FileNewParams.UISpreadSheetsheet0WindowExePath, this.FileNewParams.UISpreadSheetsheet0WindowAlternateExePath);

            // Click 'File' -> 'New' menu item
            Mouse.Click(uINewMenuItem, new Point(44, 7));
        }
        
        /// <summary>
        /// assertion about clicking new
        /// </summary>
        public void newFormAssertion()
        {
            #region Variable Declarations
            WinEdit uICellContentsEdit = this.UISpreadSheetsheet0Window.UICellContentsWindow.UICellContentsEdit;
            #endregion

            // Verify that the 'Text' property of 'CellContents' text box equals ''
            Assert.AreEqual(this.newFormAssertionExpectedValues.UICellContentsEditText, uICellContentsEdit.Text);
			Assert.AreEqual(2, SpreadsheetGUI.SSContextSingleton.getContext().formCount);

        }
        
        #region Properties
        public virtual FileNewParams FileNewParams
        {
            get
            {
                if ((this.mFileNewParams == null))
                {
                    this.mFileNewParams = new FileNewParams();
                }
                return this.mFileNewParams;
            }
        }
        
        public virtual newFormAssertionExpectedValues newFormAssertionExpectedValues
        {
            get
            {
                if ((this.mnewFormAssertionExpectedValues == null))
                {
                    this.mnewFormAssertionExpectedValues = new newFormAssertionExpectedValues();
                }
                return this.mnewFormAssertionExpectedValues;
            }
        }
        
        public UIGooooooooWindow UIGooooooooWindow
        {
            get
            {
                if ((this.mUIGooooooooWindow == null))
                {
                    this.mUIGooooooooWindow = new UIGooooooooWindow();
                }
                return this.mUIGooooooooWindow;
            }
        }
        
        public UISpreadSheetsheet0Window UISpreadSheetsheet0Window
        {
            get
            {
                if ((this.mUISpreadSheetsheet0Window == null))
                {
                    this.mUISpreadSheetsheet0Window = new UISpreadSheetsheet0Window();
                }
                return this.mUISpreadSheetsheet0Window;
            }
        }
        #endregion
        
        #region Fields
        private FileNewParams mFileNewParams;
        
        private newFormAssertionExpectedValues mnewFormAssertionExpectedValues;
        
        private UIGooooooooWindow mUIGooooooooWindow;
        
        private UISpreadSheetsheet0Window mUISpreadSheetsheet0Window;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'FileNew'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class FileNewParams
    {
        
        #region Fields
        /// <summary>
        /// Launch '%VisualStudioDir%\Projects\PS6\SpreadsheetGUI\bin\x86\Debug\SpreadsheetGUI.exe'
        /// </summary>
        public string UISpreadSheetsheet0WindowExePath = "C:\\Users\\samson559\\Documents\\Visual Studio 2012\\Projects\\PS6\\SpreadsheetGUI\\bin\\x" +
            "86\\Debug\\SpreadsheetGUI.exe";
        
        /// <summary>
        /// Launch '%VisualStudioDir%\Projects\PS6\SpreadsheetGUI\bin\x86\Debug\SpreadsheetGUI.exe'
        /// </summary>
        public string UISpreadSheetsheet0WindowAlternateExePath = "%VisualStudioDir%\\Projects\\PS6\\SpreadsheetGUI\\bin\\x86\\Debug\\SpreadsheetGUI.exe";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'newFormAssertion'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class newFormAssertionExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Text' property of 'CellContents' text box equals ''
        /// </summary>
        public string UICellContentsEditText = "";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIGooooooooWindow : WinWindow
    {
        
        public UIGooooooooWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "goooooooo";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("goooooooo");
            #endregion
        }
        
        #region Properties
        public UIGooooooooTitleBar UIGooooooooTitleBar
        {
            get
            {
                if ((this.mUIGooooooooTitleBar == null))
                {
                    this.mUIGooooooooTitleBar = new UIGooooooooTitleBar(this);
                }
                return this.mUIGooooooooTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UIGooooooooTitleBar mUIGooooooooTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIGooooooooTitleBar : WinTitleBar
    {
        
        public UIGooooooooTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("goooooooo");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("goooooooo");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UISpreadSheetsheet0Window : WinWindow
    {
        
        public UISpreadSheetsheet0Window()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "SpreadSheet- sheet0";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("SpreadSheet- sheet0");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UICellContentsWindow UICellContentsWindow
        {
            get
            {
                if ((this.mUICellContentsWindow == null))
                {
                    this.mUICellContentsWindow = new UICellContentsWindow(this);
                }
                return this.mUICellContentsWindow;
            }
        }
        
        public UIPanelWindow UIPanelWindow
        {
            get
            {
                if ((this.mUIPanelWindow == null))
                {
                    this.mUIPanelWindow = new UIPanelWindow(this);
                }
                return this.mUIPanelWindow;
            }
        }
        
        public UIFile_menuMenuBar UIFile_menuMenuBar
        {
            get
            {
                if ((this.mUIFile_menuMenuBar == null))
                {
                    this.mUIFile_menuMenuBar = new UIFile_menuMenuBar(this);
                }
                return this.mUIFile_menuMenuBar;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UICellContentsWindow mUICellContentsWindow;
        
        private UIPanelWindow mUIPanelWindow;
        
        private UIFile_menuMenuBar mUIFile_menuMenuBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "2";
            this.WindowTitles.Add("SpreadSheet- sheet0");
            #endregion
        }
        
        #region Properties
        public WinClient UIPanelClient
        {
            get
            {
                if ((this.mUIPanelClient == null))
                {
                    this.mUIPanelClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIPanelClient.WindowTitles.Add("SpreadSheet- sheet0");
                    #endregion
                }
                return this.mUIPanelClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIPanelClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICellContentsWindow : WinWindow
    {
        
        public UICellContentsWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "CellContents";
            this.WindowTitles.Add("SpreadSheet- sheet0");
            #endregion
        }
        
        #region Properties
        public WinEdit UICellContentsEdit
        {
            get
            {
                if ((this.mUICellContentsEdit == null))
                {
                    this.mUICellContentsEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUICellContentsEdit.WindowTitles.Add("SpreadSheet- sheet0");
                    #endregion
                }
                return this.mUICellContentsEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUICellContentsEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPanelWindow : WinWindow
    {
        
        public UIPanelWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "Panel";
            this.WindowTitles.Add("SpreadSheet- sheet0");
            #endregion
        }
        
        #region Properties
        public WinClient UIPanelClient
        {
            get
            {
                if ((this.mUIPanelClient == null))
                {
                    this.mUIPanelClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIPanelClient.WindowTitles.Add("SpreadSheet- sheet0");
                    #endregion
                }
                return this.mUIPanelClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIPanelClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIFile_menuMenuBar : WinMenuBar
    {
        
        public UIFile_menuMenuBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenu.PropertyNames.Name] = "File";
            this.WindowTitles.Add("SpreadSheet- sheet0");
            #endregion
        }
        
        #region Properties
        public UIFileMenuItem UIFileMenuItem
        {
            get
            {
                if ((this.mUIFileMenuItem == null))
                {
                    this.mUIFileMenuItem = new UIFileMenuItem(this);
                }
                return this.mUIFileMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private UIFileMenuItem mUIFileMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIFileMenuItem : WinMenuItem
    {
        
        public UIFileMenuItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenuItem.PropertyNames.Name] = "File";
            this.WindowTitles.Add("SpreadSheet- sheet0");
            #endregion
        }
        
        #region Properties
        public WinMenuItem UINewMenuItem
        {
            get
            {
                if ((this.mUINewMenuItem == null))
                {
                    this.mUINewMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUINewMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "New";
                    this.mUINewMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUINewMenuItem.WindowTitles.Add("SpreadSheet- sheet0");
                    #endregion
                }
                return this.mUINewMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUINewMenuItem;
        #endregion
    }
}
