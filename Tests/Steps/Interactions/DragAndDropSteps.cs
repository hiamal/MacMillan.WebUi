using System;
using TechTalk.SpecFlow;
using Architecture.Web;
using Pages.PageObjects;
using NUnit.Framework;using Architecture.EnvironmentConfig;
using Pages.PageObjects.Interactions;

namespace Tests.Steps.Interactions
{
    [Binding]
    public class DragAndDropSteps
    {
        DragAndDropPage DragAndDropPage = new DragAndDropPage();
			
        [Given(@"I'm on the Droppable Page")]
        public void GivenImontheDroppablePage()
        {
            Browser.GoToUrl($"{EnvironmentDetails.BaseUrl}/droppable");
        }

        [When(@"I drag the source element onto the target element")]
        public void WhenIdragthesourceelementontothetargetelement()
        {
            DragAndDropPage.DragAndDrop();
        }

        [Then(@"The source element is present inside the target element")]
        public void ThenThesourceelementispresentinsidethetargetelement()
        {
            StringAssert.Contains("Drag me", DragAndDropPage.TargetElementText);
        }

    }
}