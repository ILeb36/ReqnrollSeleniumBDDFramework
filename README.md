This is a clean and simple self-developed test automation framework. It exists just to show how Page Object Model can be impelemented in C# automation framewok. Nothing but this, since I have lack of time.<br />
Some simple tests for the YouTube website are also included to demonstrate how it works. <br />
It includes Reqnroll as a BDD testing framework, Selenium Webdriver for working with web browsers, NUnit as a testing framework and Allure for report generation (by the way, Reqnroll can generate HTML reports on its own). <br />
To generate allure report (require Allure to be installed in OS): "allure generate --clean --single-file".

Patterns that were used in the implementation:
- Page object model <br />
As a result of using it, I can create chains of elements that work with a specific part of the page, which makes the code more understandable and readable by separating the logic into different classes through composition: <br />
Example of using: "HomePage.Header.SearchSection.SearchTextBox.EnterText(content.SearchValue);"
- Singleton
- Fluent classes
- Strategy (to create the required WebDriver type depending on the selected browser)
- Dependency Injection container

Screenshots are automatically created for every failed test and attached to Allure report. <br />
BaseWebElement and Browser base classes contain a lot of functionality for pages and elements that I used many times when I worked as a QA engineer.

todo, when I have some spare time:
1) Add some kind of logger instead of console logs.
2) Unit tests.
3) Add a custom class for executing multiple assertions in a loop that will create a screenshot for each failure, not just at the end of a failing step.
4) Check how the framework works during parallel test execution ("--agents X" when run via NUnit).
5) Find out why Allure can't access the screenshot folder (in one of its "attach" method overloads).
6) Investigate how to attach a screenshot directly to a failing step, rather than to the end of all steps, if that's even possible (still doing it even if called from [AfterStep] hook).
