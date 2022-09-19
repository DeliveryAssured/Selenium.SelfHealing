# Selenium.SelfHealing

**Selenium Self-Healing** is a revolutionary technology and is set to become the industry standard for rock solid browser automation.

A must have technology for any organisation with a heavy investment in Selenium Automation.

Selenium Self-Healing is a technology suite working together heal your broken selectors, stabilize your Selenium Automation and deliver time-saving Insights.

Selenium Self-Healing will uplift your platform and deliver solid results you can count on.

[![Live self-healing report](https://raw.githubusercontent.com/DeliveryAssured/Selenium.SelfHealing/master/docs/images/healing-report.png)](https://htmlpreview.github.io/?https://raw.githubusercontent.com/DeliveryAssured/Selenium.SelfHealing/master/sample-healing-report/index.html)

---

## Problem Domain

### **Selenium Automation Stability**

After years of experience delivering large automation suites the stability of the scripts and the reliably of the scripts was always an issue. The types of issues we would see were

- StaleElementException
- ElementNotFoundException
- WebDriverTimeoutException

### **Broken Selenium Script**

Repeatedly we saw Selenium scripts written today only to be failing tomorrow.
The developers push some new code or the system got an upgrade and everything would fail.

### **Hard to get consistent results**

The classic problem, 'Works on my machine'

### **Raising Technical Debt**

Technical debt across a platform was ever increasing and there was never enough time allocated to maintenance.

### **Delivered code was ugly**

In order to handle all the errors thrown by the Selenium WebDriver the code was littered with

`Try.... Catch...`

`Thread.Sleep `

`new WebDriverWait(theDriver).Until(ExpectedCondition.....).`

### **> _There had to be a better way and that was our focus_**

---

## What is it?

Selenium is a technology suite implemented at the WebDriver level. A single line of code is all that is required to get started.

The technology suite covers the following areas.

### Self-Healing Engine

Self-Healing is the ability to repair broken selectors at run-time. It does not matter if the the elements attributes have changed or has moved to a new position in the UI.

### AutoWait Engine

Selenium was originally developed in 2004 when the web was relatively static. Modern web sites are high dynamic, elements are constantly changing and reacting to user input.

Without a modernizing library like Selenium Self-Healing the types of issues you would run into are

- WebElementException
- ElementNoFoundException
- WebElementTimeoutException
- StaleReferenceException.

If your frustrated by this, so to were we.

AutoWait feature is similar to that of Playwrite's AutoWait. Essentially web pages can be slow load and if the element is not found then a process of retry operations will kick in.

Overall as the developer, instantly you will see more stable Selenium sessions and better test execution results in your CICD pipeline.

## Selector Optimization Engine

The Selector Optimization Engine is responsible for reviewing selectors at run-time and making optimization suggestions.

These alternate selectors are guaranteed to uniquely find the same element you intended. They are surfaced through development logs and ultimately feed back into the Self-Healing Engine.

## Self-Healing Insights Report

The Self-Healing Insights report is a real time save when reviewing Test Execution Sessions and diagnosing issue.

The report easily integrates into your CICD processes and will save you time.

## Package Selection

Our technology operates at the WebDriver level and we have a NuGet package to suite your requirements.

Before installing this package you need to identify the version of Selenium.Support your are using. We have 3 technology solutions to target any major Selenium version and platform compatibility from .Net Framework 4.0 - .Net6.

There are packages available to support

[Selenium.SelfHealing.v2](https://www.nuget.org/packages/Selenium.SelfHealing.v2)

- [Selenium.Support v2 >= 2.53.1](https://www.nuget.org/packages/Selenium.Support/2.53.1)

[Selenium.SelfHealing.v3](https://www.nuget.org/packages/Selenium.SelfHealing.v3)

- [Selenium.Support v3 >= 3.10.0](https://www.nuget.org/packages/Selenium.Support/3.10.0)

[Selenium.SelfHealing.v4](https://www.nuget.org/packages/Selenium.SelfHealing.v4)

- [Selenium.Support v4 >= 4.10.0](https://www.nuget.org/packages/Selenium.Support/4.1.0)

~~[Selenium.WebDriver.SelfHealing](https://www.nuget.org/packages/Selenium.WebDriver.SelfHealing)~~

- Deprecated package that targeted [Selenium.SelfHealing.v4](https://www.nuget.org/packages/Selenium.SelfHealing.v4).
- Slitting the package enabled us to expand support to all major versions Selenium and the whole .Net Platform.

## Installation

---

Selenium.SelfHealing is distributed as a NuGet package.

### Pre-installation

Please ensure you have carefully reviewed the version of Selenium.Support you are using and choose the package to suite.

New projects will probably default to Selenium.SelfHealing.v4.

It is also good practice to ensure the following 2 NuGet packages are in sync.

- Selenium.Support
- Selenium.WebDriver

### Using command-line

The easiest way to get started is to run the following command.

> dotnet add package Selenium.SelfHealing.v4

### Using Package Manager

> Install-Package Selenium.SelfHealing.v4

## Getting Started

---

Once installed into the project getting started is just one line of code.

```
using Selenium.SelfHealing;

var options = new ChromeOptions();
var chromeDriver = new ChromeDriver(options);

// this creates a self-healing WebDriver
var selfHealingDriver = chromeDriver.ToSelfHealingDriver();
```

## Capabilities

---

### Resilient • Reduce flaky tests

**Self-healing**. Selenium.SelfHealing will repair broken selectors on the fly. Saving you time and money. Elements can change attributes or position and still be self-healed.

**Auto-wait**. Selenium.SelfHealing waits for elements to be actionable prior to performing actions. Auto-wait will search for interactable elements in preference. The combination of the **Auto-wait** and **Self-healing** eliminate the need for artificial timeouts - primary cause of flaky tests.

**Selector-optimization**. While your scripts are running, we analyse the chosen selector and provide optimization suggestions.

### No trade-offs • No limits

**Parallel test execution**. Run tests in parallel and save time. Our framework was build to handle everything.

**Selenium-insights**. While Selenium.SelfHealing is active all activity is logged for review.

## Self-Healing Insights Report

**Healing-report**. A detailed report is created after every session, detailing any broken selectors and the actions required to fix.

**TeamCity integration**. Easily integrate your self-healing report into a build tab.

**Emailable HTML Report**. Reports are viewable directly from the file system and can easily be emailed and shared.

## Sample Report

![Selenium.SelfHealing Report][healing-report]

## Sample Logs

![Selenium.SelfHealing Report][healing-logs]

[healing-logs]: https://raw.githubusercontent.com/DeliveryAssured/Selenium.SelfHealing/master/docs/images/healing-logs.png
[healing-report]: https://raw.githubusercontent.com/DeliveryAssured/Selenium.SelfHealing/master/docs/images/healing-report.png
[live-report]: https://htmlpreview.github.io/?https://raw.githubusercontent.com/DeliveryAssured/Selenium.SelfHealing/master/sample-healing-report/index.html
