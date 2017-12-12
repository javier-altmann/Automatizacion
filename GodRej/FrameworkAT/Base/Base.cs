using OpenQA.Selenium.Support.PageObjects;


namespace FrameworkAT.Base
{
    public class Base
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(IniciarTest.Driver, page);
            return page;
        }

    }
}
