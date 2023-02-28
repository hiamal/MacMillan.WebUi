using System;
using Architecture;

namespace Pages
{
    public class TextBoxPage
    {
        public Element txtFullName = new Element(LocatorType.Id, "userName");
        public Element txtEmail = new Element(LocatorType.Id, "userEmail");
        public Element txtCurrentAddress = new Element(LocatorType.Id, "currentAddress");
        public Element txtPermanentAddress = new Element(LocatorType.Id, "permanentAddress");
        public Element btnSubmit = new Element(LocatorType.Id, "submit");
        public Element txtOutput = new Element(LocatorType.Id, "output");


        public void EnterDetails(TextBoxDetails details)
        {
            txtFullName.Text = details.fullName;
            txtEmail.Text = details.email;
            txtCurrentAddress.Text = details.currentAddress;
            txtPermanentAddress.Text = details.permanentAddress;
        }

        public void ClickSubmit() => btnSubmit.Click();

        public string OutputText => txtOutput.Text;

    }

    public class TextBoxDetails
    {
        public string fullName { get; set; }
        public string email { get; set; }
        public string currentAddress { get; set; }
        public string permanentAddress { get; set; }
    }
}
