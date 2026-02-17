This is a clean and simple self-developed test automation framework that I spent about 24 hours on to show my experience as QA automation engineer (and as a small example of how I write code).
Some simple tests for the YouTube website are also included to demonstrate how it works.
It includes Reqnroll as a BDD testing framework, Selenium Webdriver for working with web browsers, NUnit as a testing framework and Allure for report generation (by the way, Reqnroll can generate HTML reports on its own).
To generate allure report: allure generate --clean --single-file

Patterns used in the implementation:
- Page object model
As a result of using it, I can create chains of elements that work with a specific part of the page, which makes the code more understandable and readable by separating the logic into different classes through composition:
      "HomePage.Header.SearchSection.SearchTextBox.EnterText(content.SearchValue);"
- Singleton
- Fluent classes
- Strategy (to create the required WebDriver type depending on the selected browser)
- Dependency Injection container

Screenshots are automatically created for every failed test.
BaseWebElement and Browser base classes contain a lot of functionality for pages and elements that I used many times when I worked as a QA engineer.

todo:
1) Add some kind of logger instead of console logs.
2) Add a custom class for executing multiple assertions in a loop that will create a screenshot for each failure, not just at the end of a failing step.
3) Check how the framework works during parallel test execution ("--agents X" when run via NUnit).
4) Find out why Allure can't access the screenshot folder (in one of its "attach" method overloads) and how to attach a screenshot directly to a failing step, rather than to the end of all steps (if that's even possible).
