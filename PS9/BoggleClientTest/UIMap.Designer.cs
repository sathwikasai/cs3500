﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace BoggleClientTest
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
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// played one full game
        /// </summary>
        public void OneFullGame()
        {
            #region Variable Declarations
            WpfButton uISubmitButton = this.UIBoggleWindow.UISubmitButton;
            WpfEdit uIInputEdit = this.UIBoggleWindow.UIInputEdit;
            WpfButton uISubmitButton1 = this.UIBoggleWindow1.UISubmitButton;
            WpfEdit uIInputEdit1 = this.UIBoggleWindow1.UIInputEdit;
            #endregion

            // Launch '%VisualStudioDir%\Projects\PS9\Launcher\bin\Debug\Launcher.exe'
            ApplicationUnderTest launcherApplication = ApplicationUnderTest.Launch(this.OneFullGameParams.ExePath, this.OneFullGameParams.AlternateExePath);

            // Click 'Submit' button
            Mouse.Click(uISubmitButton, new Point(17, 9));

            // Click 'Submit' button
            Mouse.Click(uISubmitButton, new Point(17, 9));

            // Type '56' in 'Input' text box
            uIInputEdit.Text = this.OneFullGameParams.UIInputEditText;

            // Click 'Submit' button
            Mouse.Click(uISubmitButton, new Point(24, 5));

            // Click 'Submit' button
            Mouse.Click(uISubmitButton1, new Point(23, 5));

            // Type '90' in 'Input' text box
            uIInputEdit1.Text = this.OneFullGameParams.UIInputEditText1;

            // Click 'Submit' button
            Mouse.Click(uISubmitButton1, new Point(22, 18));

            // Type 'queue' in 'Input' text box
            uIInputEdit1.Text = this.OneFullGameParams.UIInputEditText2;

            // Click 'Submit' button
            Mouse.Click(uISubmitButton1, new Point(37, 24));

            // Type 'tap' in 'Input' text box
            uIInputEdit.Text = this.OneFullGameParams.UIInputEditText3;

            // Click 'Submit' button
            Mouse.Click(uISubmitButton, new Point(41, 16));

            // Type 'vil' in 'Input' text box
            uIInputEdit1.Text = this.OneFullGameParams.UIInputEditText4;

            // Click 'Submit' button
            Mouse.Click(uISubmitButton1, new Point(35, 5));

            // Type 'LOCALHOST' in 'Input' text box
            uIInputEdit.Text = this.OneFullGameParams.UIInputEditText5;
        }
        
        /// <summary>
        /// p1Score1 - Use 'p1Score1ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void p1Score1()
        {
            #region Variable Declarations
            WpfText uIScore1Text = this.UIBoggleWindow.UIScore1Text;
            #endregion

            // Verify that the 'AutomationId' property of 'score1' label equals '0'
            Assert.AreEqual(this.p1Score1ExpectedValues.UIScore1TextAutomationId, uIScore1Text.AutomationId, "FAIL");
        }
        
        /// <summary>
        /// player disconnects after player enters name
        /// </summary>
        public void prematureDisconnect()
        {
            #region Variable Declarations
            WpfButton uISubmitButton = this.UIBoggleWindow.UISubmitButton;
            WpfEdit uIInputEdit = this.UIBoggleWindow.UIInputEdit;
            WpfButton uICloseButton = this.UIBoggleWindow.UIBoggleTitleBar.UICloseButton;
            WinButton uICloseButton1 = this.UILauncherexeShortcutWindow.UILauncherexeShortcutTitleBar.UICloseButton;
            #endregion

            // Launch '%VisualStudioDir%\Projects\PS9\Launcher\bin\Debug\Launcher.exe'
            ApplicationUnderTest launcherApplication = ApplicationUnderTest.Launch(this.prematureDisconnectParams.ExePath, this.prematureDisconnectParams.AlternateExePath);

            // Click 'Submit' button
            Mouse.Click(uISubmitButton, new Point(23, 5));

            // Type 'ferd' in 'Input' text box
            uIInputEdit.Text = this.prematureDisconnectParams.UIInputEditText;

            // Click 'Submit' button
            Mouse.Click(uISubmitButton, new Point(28, 0));

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(28, 18));

            // Click 'Submit' button
            Mouse.Click(uISubmitButton, new Point(27, 10));

            // Type 'derp' in 'Input' text box
            uIInputEdit.Text = this.prematureDisconnectParams.UIInputEditText1;

            // Click 'Submit' button
            Mouse.Click(uISubmitButton, new Point(13, 10));

            // Click 'Submit' button
            Mouse.Click(uISubmitButton, new Point(22, 18));

            // Type 'derp' in 'Input' text box
            uIInputEdit.Text = this.prematureDisconnectParams.UIInputEditText2;

            // Click 'Submit' button
            Mouse.Click(uISubmitButton, new Point(22, 18));

            // Click 'Close' button
            Mouse.Click(uICloseButton1, new Point(42, 9));
        }
        
        #region Properties
        public virtual OneFullGameParams OneFullGameParams
        {
            get
            {
                if ((this.mOneFullGameParams == null))
                {
                    this.mOneFullGameParams = new OneFullGameParams();
                }
                return this.mOneFullGameParams;
            }
        }
        
        public virtual p1Score1ExpectedValues p1Score1ExpectedValues
        {
            get
            {
                if ((this.mp1Score1ExpectedValues == null))
                {
                    this.mp1Score1ExpectedValues = new p1Score1ExpectedValues();
                }
                return this.mp1Score1ExpectedValues;
            }
        }
        
        public virtual prematureDisconnectParams prematureDisconnectParams
        {
            get
            {
                if ((this.mprematureDisconnectParams == null))
                {
                    this.mprematureDisconnectParams = new prematureDisconnectParams();
                }
                return this.mprematureDisconnectParams;
            }
        }
        
        public UIBoggleWindow UIBoggleWindow
        {
            get
            {
                if ((this.mUIBoggleWindow == null))
                {
                    this.mUIBoggleWindow = new UIBoggleWindow();
                }
                return this.mUIBoggleWindow;
            }
        }
        
        public UIBoggleWindow1 UIBoggleWindow1
        {
            get
            {
                if ((this.mUIBoggleWindow1 == null))
                {
                    this.mUIBoggleWindow1 = new UIBoggleWindow1();
                }
                return this.mUIBoggleWindow1;
            }
        }
        
        public UILauncherexeShortcutWindow UILauncherexeShortcutWindow
        {
            get
            {
                if ((this.mUILauncherexeShortcutWindow == null))
                {
                    this.mUILauncherexeShortcutWindow = new UILauncherexeShortcutWindow();
                }
                return this.mUILauncherexeShortcutWindow;
            }
        }
        #endregion
        
        #region Fields
        private OneFullGameParams mOneFullGameParams;
        
        private p1Score1ExpectedValues mp1Score1ExpectedValues;
        
        private prematureDisconnectParams mprematureDisconnectParams;
        
        private UIBoggleWindow mUIBoggleWindow;
        
        private UIBoggleWindow1 mUIBoggleWindow1;
        
        private UILauncherexeShortcutWindow mUILauncherexeShortcutWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'OneFullGame'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class OneFullGameParams
    {
        
        #region Fields
        /// <summary>
        /// Launch '%VisualStudioDir%\Projects\PS9\Launcher\bin\Debug\Launcher.exe'
        /// </summary>
        public string ExePath = "C:\\Users\\samson559\\Documents\\Visual Studio 2012\\Projects\\PS9\\Launcher\\bin\\Debug\\L" +
            "auncher.exe";
        
        /// <summary>
        /// Launch '%VisualStudioDir%\Projects\PS9\Launcher\bin\Debug\Launcher.exe'
        /// </summary>
        public string AlternateExePath = "%VisualStudioDir%\\Projects\\PS9\\Launcher\\bin\\Debug\\Launcher.exe";
        
        /// <summary>
        /// Type '56' in 'Input' text box
        /// </summary>
        public string UIInputEditText = "56";
        
        /// <summary>
        /// Type '90' in 'Input' text box
        /// </summary>
        public string UIInputEditText1 = "90";
        
        /// <summary>
        /// Type 'queue' in 'Input' text box
        /// </summary>
        public string UIInputEditText2 = "queue";
        
        /// <summary>
        /// Type 'tap' in 'Input' text box
        /// </summary>
        public string UIInputEditText3 = "tap";
        
        /// <summary>
        /// Type 'vil' in 'Input' text box
        /// </summary>
        public string UIInputEditText4 = "vil";
        
        /// <summary>
        /// Type 'LOCALHOST' in 'Input' text box
        /// </summary>
        public string UIInputEditText5 = "LOCALHOST";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'p1Score1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class p1Score1ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'AutomationId' property of 'score1' label equals '0'
        /// </summary>
        public string UIScore1TextAutomationId = "0";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'prematureDisconnect'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class prematureDisconnectParams
    {
        
        #region Fields
        /// <summary>
        /// Launch '%VisualStudioDir%\Projects\PS9\Launcher\bin\Debug\Launcher.exe'
        /// </summary>
        public string ExePath = "C:\\Users\\samson559\\Documents\\Visual Studio 2012\\Projects\\PS9\\Launcher\\bin\\Debug\\L" +
            "auncher.exe";
        
        /// <summary>
        /// Launch '%VisualStudioDir%\Projects\PS9\Launcher\bin\Debug\Launcher.exe'
        /// </summary>
        public string AlternateExePath = "%VisualStudioDir%\\Projects\\PS9\\Launcher\\bin\\Debug\\Launcher.exe";
        
        /// <summary>
        /// Type 'ferd' in 'Input' text box
        /// </summary>
        public string UIInputEditText = "ferd";
        
        /// <summary>
        /// Type 'derp' in 'Input' text box
        /// </summary>
        public string UIInputEditText1 = "derp";
        
        /// <summary>
        /// Type 'derp' in 'Input' text box
        /// </summary>
        public string UIInputEditText2 = "derp";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIBoggleWindow : WpfWindow
    {
        
        public UIBoggleWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "Boggle";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Boggle");
            #endregion
        }
        
        #region Properties
        public WpfButton UISubmitButton
        {
            get
            {
                if ((this.mUISubmitButton == null))
                {
                    this.mUISubmitButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUISubmitButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "SubmitButton";
                    this.mUISubmitButton.WindowTitles.Add("Boggle");
                    #endregion
                }
                return this.mUISubmitButton;
            }
        }
        
        public WpfEdit UIInputEdit
        {
            get
            {
                if ((this.mUIInputEdit == null))
                {
                    this.mUIInputEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUIInputEdit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "Input";
                    this.mUIInputEdit.WindowTitles.Add("Boggle");
                    #endregion
                }
                return this.mUIInputEdit;
            }
        }
        
        public WpfText UIScore1Text
        {
            get
            {
                if ((this.mUIScore1Text == null))
                {
                    this.mUIScore1Text = new WpfText(this);
                    #region Search Criteria
                    this.mUIScore1Text.SearchProperties[WpfText.PropertyNames.AutomationId] = "Score1";
                    this.mUIScore1Text.WindowTitles.Add("Boggle");
                    #endregion
                }
                return this.mUIScore1Text;
            }
        }
        
        public UIBoggleTitleBar UIBoggleTitleBar
        {
            get
            {
                if ((this.mUIBoggleTitleBar == null))
                {
                    this.mUIBoggleTitleBar = new UIBoggleTitleBar(this);
                }
                return this.mUIBoggleTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUISubmitButton;
        
        private WpfEdit mUIInputEdit;
        
        private WpfText mUIScore1Text;
        
        private UIBoggleTitleBar mUIBoggleTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIBoggleTitleBar : WpfTitleBar
    {
        
        public UIBoggleTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTitleBar.PropertyNames.AutomationId] = "TitleBar";
            this.WindowTitles.Add("Boggle");
            #endregion
        }
        
        #region Properties
        public WpfButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "Close";
                    this.mUICloseButton.WindowTitles.Add("Boggle");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUICloseButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIBoggleWindow1 : WpfWindow
    {
        
        public UIBoggleWindow1()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "Boggle";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.FilterProperties[WpfWindow.PropertyNames.OrderOfInvocation] = "2";
            this.WindowTitles.Add("Boggle");
            #endregion
        }
        
        #region Properties
        public WpfButton UISubmitButton
        {
            get
            {
                if ((this.mUISubmitButton == null))
                {
                    this.mUISubmitButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUISubmitButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "SubmitButton";
                    this.mUISubmitButton.WindowTitles.Add("Boggle");
                    #endregion
                }
                return this.mUISubmitButton;
            }
        }
        
        public WpfEdit UIInputEdit
        {
            get
            {
                if ((this.mUIInputEdit == null))
                {
                    this.mUIInputEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUIInputEdit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "Input";
                    this.mUIInputEdit.WindowTitles.Add("Boggle");
                    #endregion
                }
                return this.mUIInputEdit;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUISubmitButton;
        
        private WpfEdit mUIInputEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UILauncherexeShortcutWindow : WinWindow
    {
        
        public UILauncherexeShortcutWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Launcher.exe - Shortcut";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ConsoleWindowClass";
            this.WindowTitles.Add("Launcher.exe - Shortcut");
            #endregion
        }
        
        #region Properties
        public UILauncherexeShortcutTitleBar UILauncherexeShortcutTitleBar
        {
            get
            {
                if ((this.mUILauncherexeShortcutTitleBar == null))
                {
                    this.mUILauncherexeShortcutTitleBar = new UILauncherexeShortcutTitleBar(this);
                }
                return this.mUILauncherexeShortcutTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UILauncherexeShortcutTitleBar mUILauncherexeShortcutTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UILauncherexeShortcutTitleBar : WinTitleBar
    {
        
        public UILauncherexeShortcutTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Launcher.exe - Shortcut");
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
                    this.mUICloseButton.WindowTitles.Add("Launcher.exe - Shortcut");
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
}