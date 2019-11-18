using System;
using System.Windows.Forms;

namespace SimpleWFApp
{
    class Program
    {
        static void Main() 
        {
            Application.Run(new MainWindow("Mike's Window", 300, 300));
        }
    }
	
    class MainWindow : Form 
    {
		// Members for a simple menus system
        private MenuStrip mnuMainMenu = new MenuStrip();
        private ToolStripMenuItem mnuFile = new ToolStripMenuItem();
        private ToolStripMenuItem mnuFileExit = new ToolStripMenuItem();
        public MainWindow() { }
        public MainWindow(string title, int height, int width) 
		{ 
			// Set various properties from the parent classes
            Text = title;
            Width = width;
            Height = height;

            // Inherited method to center the form on the screen
            CenterToScreen();

            // Method to create the menu system
            BuildMenuSystem();
		}
		
		private void BuildMenuSystem()
        {
            // Add the File menu item to the main menu
            mnuFile.Text = "&File";
            mnuMainMenu.Items.Add(mnuFile);

            // Now add the Exit menu to the File menu
            mnuFileExit.Text = "E&xit";
            mnuFile.DropDownItems.Add(mnuFileExit);
            mnuFileExit.Click += (o, s) =>
            {
                MessageBox.Show(string.Format("{0} sent this event", o.ToString()));
                Application.Exit();
            };

            // Finally, set the menu for this Form
            Controls.Add(this.mnuMainMenu);
            MainMenuStrip = this.mnuMainMenu;
        }
    }
}