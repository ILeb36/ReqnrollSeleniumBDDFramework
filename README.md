This is a simple (actually, not really) framework for QA automation, made by me in three days.
It contains Reqnroll as BDD-testing framework, Selenium Webdriver as a way of operating with web browsers, NUnit as testing framework and Allure for reports generating (by the way, Reqnroll can generage html-reports itself).
To generate allure report: allure generate --clean --single-file

Some simple tests for Youtube web site just to show how it works are also included.
Patterns that were used during implementation:
- Page object model
As a result, I can use chains of elements, operating with specific part of the page, like "this.homePage.Header.SearchSection.SearchTextBox.EnterText(content.SearchValue);", making it more understandable and readable, separating logic to different classes due to composition.
- Singleton
- Fluent classes
- Strategy (for creating the required type of WebDriver according to selected browser)
- Dependency Injection container

Screenshots are automatically created for every failed test.
Base Web Element and Browser classes contain a lot of functionality for pages and elements, that I had to use many times when I was a QA engineer.

To do:
1) Adding some logger instead of Console logs.
2) Adding custom class for executing multiple assertions in a cicle, that will create a screenshot for every fail, not just at the end of the failed step.
3) To check how framework works during parallel tests running ("--agents X" when staring via NUnit).
4) To investigate why Allure doesn't have an access to screenshots folder and how to attach screenshot right into failed step, not to the end of all steps (if it's possible at all).
