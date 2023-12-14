using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoginSteps;
using Login;
using TechTalk.SpecFlow;

namespace LoginSteps.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private LoginService loginService;

        private bool result;

        [BeforeScenario]
        public void Setup()
        {
            loginService = new LoginService();
        }

        [Given("the user is on the login page")]
        public void GivenUserIsOnLoginPage()
        {
            // Implement navigation to the login page if needed
        }

        [When("the user selects \"(.*)\" from the dropdown")]
        public void WhenUserSelectsFromTheDropdown(string userType)
        {
            // Implement selecting user type from dropdown
        }

        [When("enters the name and password")]
        public void WhenUserEntersNameAndPassword()
        {
            // Implement entering name and password
        }

        [When("clicks the login button")]
        public void WhenUserClicksLoginButton()
        {
            // Implement clicking login button
        }

        [Then("the user should be logged in")]
        public void ThenUserShouldBeLoggedIn()
        {
            Assert.IsTrue(result);
        }
    }
}