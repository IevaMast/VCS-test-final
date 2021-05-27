using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCStest.Test
{
    public class IkeaBusinessTest : BaseTest
    {
        [Test]
        public static void IkeaTest()
        {
            _ikeaBusinessPage.NavigateToPage();
            _ikeaBusinessPage.CloseCookie();
            _ikeaBusinessPage.ClickProduct();
            _ikeaBusinessPage.ClickColor();
            _ikeaBusinessPage.ClickConcreteColor();
            _ikeaBusinessPage.ClickDeselect();
            _ikeaBusinessPage.ClickPage();
            _ikeaBusinessPage.CheckResult("Prekių iš viso 149");
        }
    }
}
