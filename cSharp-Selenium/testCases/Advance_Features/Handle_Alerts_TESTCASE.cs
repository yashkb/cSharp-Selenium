using cSharp_Selenium.Base;
using cSharp_Selenium.pages.Advance_Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Selenium.testCases.Advance_Features
{
    internal class Handle_Alerts_TESTCASE : BaseClass
    {
        [SetUp]
        public void SetUp()
        {
            NavigateURL("https://demo.automationtesting.in/Alerts.html");

        }
        [Test]
        public void TC_001_AlertOK()
        {
            Handle_Alerts_PAGE obj = new Handle_Alerts_PAGE(_driver);
            obj.ClickAlertOK();
        }
        [Test]
        public void TC_002_AlertCancel()
        {
            Handle_Alerts_PAGE obj = new Handle_Alerts_PAGE(_driver);
            obj.ClickAlertCancel();
        }
        [Test]
        public void TC_003_AlertTextBox()
        {
            Handle_Alerts_PAGE obj = new Handle_Alerts_PAGE(_driver);
            obj.ClickAlertTxtBox();
        }

    }
}
