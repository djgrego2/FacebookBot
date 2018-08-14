using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace FacebookBot
{
    public partial class HomePage : Form
    {
        

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\Gregorio Perez\Desktop\ISF - PAC Prueba Automatizacion\AutomatizacionPacISF");
            driver.Navigate().GoToUrl("https://stackoverflow.com/questions/9088367/chromedriver-does-not-exist-in-selenium-webdriver-c-sharp-test-script");
        }
    }
}
