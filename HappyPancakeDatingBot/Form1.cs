using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;

namespace HappyPancakeDatingBot
{
    public partial class Form1 : Form
    {
        private bool doLoop = false;
        private ChromeDriver driver = new ChromeDriver();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!doLoop)
            {
                try
                {
                    Login();
                    button1.Text = "Avsluta flirtandet";
                    usernameTb.Enabled = false;
                    passwordTb.Enabled = false;
                    ageMaxTb.Enabled = false;
                    ageMinTb.Enabled = false;
                    lanTb.Enabled = false;
                    StartLoopingAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (doLoop)
            {
                MessageBox.Show("Flirt Stoppad");
                doLoop = false;
                usernameTb.Enabled = true;
                passwordTb.Enabled = true;
                ageMaxTb.Enabled = true;
                ageMinTb.Enabled = true;
                lanTb.Enabled = true;
                button1.Text = "Flirta";
            }
        }

        private async Task StartLoopingAsync()
        {
            doLoop = true;
            await Task.Run(() => LoopTask());
        }

        private async Task LoopTask()
        {
            MessageBox.Show("Flirt started");
            while (doLoop)
            {
                try
                {
                    for (int i = Convert.ToInt32(ageMinTb.Text); i < Convert.ToInt32(ageMaxTb.Text); i++)
                    {
                        DoFlirt(i);
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void DoFlirt(int i)
        {
            try
            {
                DoSearch(i);
                var html = driver.PageSource;
                var urllist = GetUrls(html, new List<string>());
                var ListToLookFor = SortListForAlreadySeen(urllist);
                VisitAndFlirt(i, ListToLookFor);
            }
            catch
            {

            }
            }

        private void VisitAndFlirt(int i, List<string> ListToLookFor)
        {
            for (int j = 0; j < ListToLookFor.Count; j++)
            {
                driver.Url = ListToLookFor[j];
                Thread.Sleep(2000);
                var _html = driver.PageSource;
                try
                {
                    if (!_html.Contains("Ja</dd>"))
                        driver.FindElementByLinkText("Flirta").Click();
                    Thread.Sleep(1000);
                }
                catch
                {
                }
            }
        }

        private List<string> GetUrls(string html, List<string> urllist)
        {
            for (int f = 1; f < 10; f++)
            {
                try
                {
                    string[] split = Regex.Split(html, "/visa-profil/");

                    for (int i = 1; i < split.Count(); i++)
                    {
                        string url = "http://www.happypancake.com/visa-profil/" + split[i].Substring(0, split[i].IndexOf("\""));
                        if (!url.Contains("onlinelist"))
                            urllist.Add(url);
                    }
                    driver.FindElementsByClassName("pager-row")[f].Click();
                    Thread.Sleep(2000);
                }
                catch
                {
                }
            }
            return urllist;
        }

        private void DoSearch(int i)
        {
            driver.Url = "http://www.happypancake.com/sok/";
            Thread.Sleep(1000);
            driver.FindElementById("ContentPlaceHolderDefault_PageContent_MainContent_lnkAdvancedSearch").Click();
            Thread.Sleep(2000);
            driver.FindElementById("ContentPlaceHolderDefault_PageContent_MainContent_chkLookingForMe").Click();
            driver.FindElementById("ContentPlaceHolderDefault_PageContent_MainContent_drpMinAge").SendKeys(i.ToString());
            driver.FindElementById("ContentPlaceHolderDefault_PageContent_MainContent_drpMaxAge").SendKeys(i.ToString());
            driver.FindElementById("ContentPlaceHolderDefault_PageContent_MainContent_drpProvince").SendKeys(lanTb.Text);
            if (sortNewestCb.Checked)
                driver.FindElementById("ContentPlaceHolderDefault_PageContent_MainContent_drpSortOrder")
                    .SendKeys("Nyaste Medlemmar");
            driver.FindElementById("ContentPlaceHolderDefault_PageContent_MainContent_chkPic").Click();
            if (onlineCb.Checked)
                driver.FindElementById("ContentPlaceHolderDefault_PageContent_MainContent_chkOnline").Click();
            Thread.Sleep(1000);
            driver.FindElementById("ContentPlaceHolderDefault_PageContent_MainContent_lnkBtnSearch").Click();
            Thread.Sleep(1000);
        }

        private List<string> SortListForAlreadySeen(List<string> urllist)
        {
            var returnList = new List<string>();
            string ExistingVisits = HappyPancakeDatingBot.Properties.Settings.Default.VisitedProfiles;
            if (ExistingVisits == null)
                ExistingVisits = "";
            string[] split = Regex.Split(ExistingVisits, ";");
            for (int i = 0; i < urllist.Count; i++)
            {
                bool itExists = false;
                for (int j = 0; j < split.Count(); j++)
                {
                    if (split[j] == urllist[i])
                        itExists = true;
                }
                for (int j = 0; j < returnList.Count; j++)
                {
                    if (returnList[j] == urllist[i])
                        itExists = true;
                }
                if (!itExists)
                {
                    returnList.Add(urllist[i]);
                    ExistingVisits += ";" + urllist[i];
                }
            }
            HappyPancakeDatingBot.Properties.Settings.Default.VisitedProfiles = ExistingVisits;
            HappyPancakeDatingBot.Properties.Settings.Default.Save();
            return returnList;
        }

        private void Login()
        {
            try
            {
                driver.Url = "http://happypancake.com/login";
                Thread.Sleep(1000);
                var loginfield = driver.FindElementById("ContentPlaceHolderDefault_mainContent_UserName");
                var passwordfield = driver.FindElementById("ContentPlaceHolderDefault_mainContent_Password");
                var LoginButton = driver.FindElementById("ContentPlaceHolderDefault_mainContent_lbLogin");
                loginfield.SendKeys(usernameTb.Text);
                passwordfield.SendKeys(passwordTb.Text);
                LoginButton.Click();
                Thread.Sleep(1000);
            }
            catch (Exception)
            {
                
            }
         
        }

       
    }
}
