using System;
using System.Threading.Tasks;
using Microsoft.Playwright;
using NUnit.Framework;


namespace PlaywrightTests
{
    public class Tests
    {
        private IPage page;
        private IBrowser browser;

        [SetUp]
        public async Task SetUpAsync()
        {
            var playwright = await Playwright.CreateAsync();
            browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            page = await browser.NewPageAsync();

            await page.GotoAsync("https://localhost:44335/");
        }

        [Test]
        public async Task CalculatorWebUi_AddTwo_InputsPass()
        {
            await page.FillAsync("input[placeholder=\"Enter Number A\"]", "10");
            await page.FillAsync("input[placeholder=\"Enter Number B\"]", "5");

            await page.ClickAsync("button:has-text(\"A + B\")");

            var resultText = await page.TextContentAsync("#textbox");
            Assert.That(resultText, Contains.Substring("15"));
        }

        [Test]
        public async Task CalculatorUI_PageTitle_IsCalculator()
        {
            var pageTitle = await page.TitleAsync();
            Assert.AreEqual("Calculator", pageTitle);
        }

        [Test]
        public async Task CalculatorWebUi_DivideFloatingPointValueAndZero_ReturnsNotANumberError()
        {
            await page.FillAsync("input[placeholder=\"Enter Number A\"]", "10");

            await page.FillAsync("input[placeholder=\"Enter Number B\"]", "0");

            await page.ClickAsync("button:has-text(\"A / B\")");

            await page.WaitForSelectorAsync("#textbox");

            var resultText = await page.TextContentAsync("#textbox");

            Assert.That(resultText, Contains.Substring("Not a Number"));
        }

        [Test]
        public async Task CalculatorWebUi_TextInInputBox_ReturnsInvalidInputError()
        {
            await page.FillAsync("input[placeholder=\"Enter Number A\"]", "10");

            await page.FillAsync("input[placeholder=\"Enter Number B\"]", "fifteen");

            await page.ClickAsync("button:has-text(\"A + B\")");

            await page.WaitForSelectorAsync("#textbox");

            var resultText = await page.TextContentAsync("#textbox");

            Assert.That(resultText, Contains.Substring("Invalid Input, Numbers Only"));
        }

        [Test]
        public async Task CalculatorWebUi_Clear_DefaultState()
        {
            await page.FillAsync("input[placeholder=\"Enter Number A\"]", "10");

            await page.FillAsync("input[placeholder=\"Enter Number B\"]", "5");

            await page.ClickAsync("button:has-text(\"A + B\")");

            await page.ClickAsync("button:has-text(\"Clear\")");

            await page.WaitForSelectorAsync("#textbox");

            var resultText = await page.TextContentAsync("#textbox");

            var inputAValue = await page.InputValueAsync("input[placeholder=\"Enter Number A\"]");
            var inputBValue = await page.InputValueAsync("input[placeholder=\"Enter Number B\"]");

            Assert.That(resultText, Contains.Substring("Enter a value(s) below and select an operation."));
            Assert.AreEqual("0", inputAValue);
            Assert.AreEqual("0", inputBValue);
        }

        [TearDown]
        public async Task TearDownAsync()
        {
            await browser.CloseAsync();
        }
    }
}
