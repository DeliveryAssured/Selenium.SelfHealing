# Selenium.WebDriver.SelfHealing

Selenium.WebDriver.SelfHealing uplifts the native Selenium and makes it particularly suitable for the hardest to automate slow dynamic applications like Pega & Salesforce. Tried and tested in the toughest environments, it will bring stability to your Flaky Tests or rapidly changing UI.

Selenium.WebDriver.SelfHealing is the first to bring Selenium self-healing capabilities natively to the .Net Platform.

Innovative self-healing algorithm, mixed with auto-wait and selector optimization will allow you to deliver your next project on time.

Getting started is easy, self-healing does not require external network access and no servers need to be hosted.

[<img src="https://raw.githubusercontent.com/DeliveryAssured/Selenium.WebDriver.SelfHealing/master/docs/images/healing-report.png">](https://htmlpreview.github.io/?https://raw.githubusercontent.com/DeliveryAssured/Selenium.WebDriver.SelfHealing/master/sample-healing-report/index.html)

## Documentation

---

Selenium.WebDriver.SelfHealing is an addon to Selenium.WebDriver platform for Web Testing and Automation. Selenium.WebDriver.SelfHealing is built to enable cross-browser web automation that is ever-green, capable, reliable and suitable for the modern dynamic web.

Bring resilience to your Selenium scripts through it's ability to self-heal broken selectors on the fly.

## Installation

---

Selenium.WebDriver.SelfHealing is distributed as a NuGet package.

### Using command-line

The easiest way to get started is to run the following command.

> dotnet add package Selenium.WebDriver.SelfHealing

### Using Package Manager

> Install-Package Selenium.WebDriver.SelfHealing

## Getting Started

---

Once installed into the project getting started is just one line of code.

```
using Selenium.WebDriver.SelfHealing;

var options = new ChromeOptions();
var chromeDriver = new ChromeDriver(options);

// this creates a self-healing WebDriver
var selfHealingDriver = chromeDriver.ToSelfHealingDriver();
```

## Capabilities

---

### Resilient • Reduce flaky tests

**Self-healing**. Selenium.WebDriver.SelfHealing will repair broken selectors on the fly. Saving you time and money. Elements can change attributes or position and still be self-healed.

**Auto-wait**. Selenium.WebDriver.SelfHealing waits for elements to be actionable prior to performing actions. Auto-wait will search for interactable in preference. The combination of the **Auto-wait** and **Self-healing** eliminate the need for artificial timeouts - primary cause of flaky tests.

**Selector-optimization**. While your scripts are running, we analyse the chosen selector and provide optimization suggestions.

### No trade-offs • No limits

**Parallel test execution**. Run tests in parallel and save time. Our framework was build to handle everything.

**Selenium-insights**. While Selenium.WebDriver.SelfHealing is active all activity is logged for review.

## Self-healing Reports

**Healing-report**. After each WebDriver session is disposed a report will be created detailing any broken selectors.

**TeamCity integration**. Easily integrate your self-healing report into a build tab.

**Emailable HTML Report**. Reports are viewable directly from the file system and can easily be emailed from Integration scenarios.

## Sample Report

![Selenium.WebDriver.SelfHealing Report][healing-report]

## Sample Logs

![Selenium.WebDriver.SelfHealing Report][healing-logs]

[healing-logs]: https://raw.githubusercontent.com/DeliveryAssured/Selenium.WebDriver.SelfHealing/master/docs/images/healing-logs.png
[healing-report]: https://raw.githubusercontent.com/DeliveryAssured/Selenium.WebDriver.SelfHealing/master/docs/images/healing-report.png
[live-report]: https://htmlpreview.github.io/?https://raw.githubusercontent.com/DeliveryAssured/Selenium.WebDriver.SelfHealing/master/sample-healing-report/index.html
