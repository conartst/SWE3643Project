// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebsiteCal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\basil\source\repos\WebsiteCal\WebsiteCal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\basil\source\repos\WebsiteCal\WebsiteCal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\basil\source\repos\WebsiteCal\WebsiteCal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\basil\source\repos\WebsiteCal\WebsiteCal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\basil\source\repos\WebsiteCal\WebsiteCal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\basil\source\repos\WebsiteCal\WebsiteCal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\basil\source\repos\WebsiteCal\WebsiteCal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\basil\source\repos\WebsiteCal\WebsiteCal\_Imports.razor"
using WebsiteCal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\basil\source\repos\WebsiteCal\WebsiteCal\_Imports.razor"
using WebsiteCal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\basil\source\repos\WebsiteCal\WebsiteCal\Pages\Counter.razor"
using Calculator3;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\basil\source\repos\WebsiteCal\WebsiteCal\Pages\Counter.razor"
       

    private bool IsTextBoxRed { get; set; }

   
    private string ColorBox => IsTextBoxRed ? "background-color: #B70F0A; color: white; padding: 5px; width: 500px; height: 50px; text-align: center; display: flex; justify-content: center; align-items: center;" : "background-color: #FFECD7; color: black; padding: 5px; width: 500px; height: 50px; text-align: center; display: flex; justify-content: center; align-items: center;";

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\basil\source\repos\WebsiteCal\WebsiteCal\Pages\Counter.razor"
       

    public string SinCosTanRecip = "";

    public string myNumber { get; set; } = "0";
    public string myNumber2 { get; set; } = "0";

    public string Input1 = "";
    public string Input2 = "";



    public static double Answer;
    public string Error = "Enter a value(s) below and select an operation.";

    public string AnswerString;

    public string Symbol;


    private void Clearing()
    {
        myNumber = "";
        myNumber2 = "";
        Input1 = "";
        Input2 = "";
        Error = "Enter a value(s) below and select an operation.";
        Answer = 0;
        AnswerString = "";
        Symbol = "";
        IsTextBoxRed = false;
        SinCosTanRecip = "";


    }

    private void Empty()
    {
        AnswerString = "";
        Input1 = "";
        Input2 = "";
        Symbol = "";
        Error = "Please Enter a Number";
        SinCosTanRecip = "";
        IsTextBoxRed = true;
    }

    private void EmptyA()
    {
        AnswerString = "";
        Input1 = "";
        Input2 = "";
        Symbol = "";
        Error = "Please Enter Number For A";
        SinCosTanRecip = "";
        IsTextBoxRed = true;

    }


    private void EmptyCannotZero()
    {
        AnswerString = "";
        Answer = 0;

        Symbol = "/";
        Error = "= Not a Number";

        Input1 = myNumber;
        Input2 = myNumber2;

        SinCosTanRecip = "";

        IsTextBoxRed = true;

    }

    private void Adding()
    {
        double number1;
        double number2;

        if (myNumber == "" || myNumber2 == "")
        {
            Empty();
        }
        else if (!double.TryParse(myNumber, out number1) || !double.TryParse(myNumber2, out number2))
        {
            Input1 = "";
            Input2 = "";
            AnswerString = "";
            Symbol = "";
            Error = "Invalid Input, Numbers Only";
            IsTextBoxRed = true;

        }
        else
        {
            Answer = Calculator3.Program.Add(double.Parse(myNumber), double.Parse(myNumber2));
            Symbol = "+";
            AnswerString = Answer.ToString();
            Input1 = myNumber;
            Input2 = myNumber2 + " =";
            Error = "";
            SinCosTanRecip = "";
            IsTextBoxRed = false;
        }


    }

    private void Subtracting()
    {
        double number1;
        double number2;

        if (myNumber == "" || myNumber2 == "")
        {
            Empty();
        }
        else if (!double.TryParse(myNumber, out number1) || !double.TryParse(myNumber2, out number2))
        {
            Input1 = "";
            Input2 = "";
            AnswerString = "";
            Symbol = "";
            Error = "Invalid Input, Numbers Only";
            IsTextBoxRed = true;

        }
        else
        {
            Answer = Calculator3.Program.Subtract(double.Parse(myNumber), double.Parse(myNumber2));
            Symbol = "-";
            AnswerString = Answer.ToString();
            Input1 = myNumber;
            Input2 = myNumber2 + " =";
            Error = "";
            SinCosTanRecip = "";
            IsTextBoxRed = false;
        }

    }

    private void Multiplying()
    {
        double number1;
        double number2;
        if (myNumber == "" || myNumber2 == "")
        {
            Empty();
        }
        else if (!double.TryParse(myNumber, out number1) || !double.TryParse(myNumber2, out number2))
        {
            Input1 = "";
            Input2 = "";
            AnswerString = "";
            Symbol = "";
            Error = "Invalid Input, Numbers Only";
            IsTextBoxRed = true;

        }
        else
        {
            Answer = Calculator3.Program.Multiply(double.Parse(myNumber), double.Parse(myNumber2));
            Symbol = "*";
            AnswerString = Answer.ToString();
            Input1 = myNumber;
            Input2 = myNumber2 + " =";
            Error = "";
            SinCosTanRecip = "";
            IsTextBoxRed = false;
        }

    }

    private void Dividing()
    {
        double number1;
        double number2;
        if (myNumber == "" || myNumber2 == "")
        {

            Empty();
        }
        if (myNumber2 == "0")
        {
            EmptyCannotZero();
        }
        else if (!double.TryParse(myNumber, out number1) || !double.TryParse(myNumber2, out number2))
        {
            Input1 = "";
            Input2 = "";
            AnswerString = "";
            Symbol = "";
            Error = "Invalid Input, Numbers Only";
            IsTextBoxRed = true;

        }
        else
        {
            Answer = Calculator3.Program.Divide(double.Parse(myNumber), double.Parse(myNumber2));
            Symbol = "/";
            AnswerString = Answer.ToString();
            Input1 = myNumber;
            Input2 = myNumber2 + " =";
            Error = "";
            SinCosTanRecip = "";
            IsTextBoxRed = false;
        }

    }

    private void Equals()
    {
        double number1;
        double number2;
        if (myNumber == "" || myNumber2 == "")
        {
            Empty();
        }
        else if (!double.TryParse(myNumber, out number1) || !double.TryParse(myNumber2, out number2))
        {
            Input1 = "";
            Input2 = "";
            AnswerString = "";
            Symbol = "";
            Error = "Invalid Input, Numbers Only";
            IsTextBoxRed = true;

        }
        else
        {
            Answer = Calculator3.Program.Equals(double.Parse(myNumber), double.Parse(myNumber2));
            Symbol = "==";
            if (Answer == 0)
            {
                AnswerString = "False";

            }
            else
            {
                AnswerString = "True";
            }
            Input1 = myNumber;
            Input2 = myNumber2 + " =";
            Error = "";
            SinCosTanRecip = "";
            IsTextBoxRed = false;
        }

    }

    private void Powering()
    {
        double number1;
        double number2;
        if (myNumber == "" || myNumber2 == "")
        {
            Empty();
        }
        else if (!double.TryParse(myNumber, out number1) || !double.TryParse(myNumber2, out number2))
        {
            Input1 = "";
            Input2 = "";
            AnswerString = "";
            Symbol = "";
            Error = "Invalid Input, Numbers Only";
            IsTextBoxRed = true;

        }
        else
        {
            Answer = Calculator3.Program.Power(double.Parse(myNumber), double.Parse(myNumber2));
            Symbol = "^";
            AnswerString = Answer.ToString();
            Input1 = myNumber;
            Input2 = myNumber2 + " =";
            Error = "";
            SinCosTanRecip = "";
            IsTextBoxRed = false;
        }

    }

    private void Loging()
    {
        double number1;
        double number2;
        if (myNumber == "" || myNumber2 == "")
        {
            Empty();
        }
        else if (!double.TryParse(myNumber, out number1) || !double.TryParse(myNumber2, out number2))
        {
            Input1 = "";
            Input2 = "";
            AnswerString = "";
            Symbol = "";
            Error = "Invalid Input, Numbers Only";
            IsTextBoxRed = true;

        }
        else
        {
            Answer = Calculator3.Program.Log(double.Parse(myNumber), double.Parse(myNumber2));
            Symbol = "log";
            AnswerString = Answer.ToString();
            Input1 = myNumber;
            Input2 = myNumber2 + " =";
            Error = "";
            SinCosTanRecip = "";
            IsTextBoxRed = false;
        }

    }

    private void Rooting()
    {
        double number1;
        double number2;
        if (myNumber == "" || myNumber2 == "")
        {
            Empty();
        }
        else if (!double.TryParse(myNumber, out number1) || !double.TryParse(myNumber2, out number2))
        {
            Input1 = "";
            Input2 = "";
            AnswerString = "";
            Symbol = "";
            Error = "Invalid Input, Numbers Only";
            IsTextBoxRed = true;

        }
        else
        {
            Answer = Calculator3.Program.Root(double.Parse(myNumber), double.Parse(myNumber2));
            Symbol = "root";
            AnswerString = Answer.ToString();
            Input1 = myNumber;
            Input2 = myNumber2 + " =";
            Error = "";
            SinCosTanRecip = "";
            IsTextBoxRed = false;
        }

    }

    private void Factorialing()
    {
        double number1;
        if (myNumber == "")
        {
            EmptyA();
        }
        else if (!double.TryParse(myNumber, out number1))
        {
            Input1 = "";
            Input2 = "";
            AnswerString = "";
            Symbol = "";
            Error = "Invalid Input, Numbers Only";
            IsTextBoxRed = true;

        }
        else
        {
            Answer = Calculator3.Program.Factorial(double.Parse(myNumber));
            Symbol = "!";
            myNumber2 = "";
            AnswerString = Answer.ToString();
            Input1 = myNumber;
            Input2 = myNumber2 + " =";
            Error = "";
            SinCosTanRecip = "";
            IsTextBoxRed = false;
        }

    }

    private void SinAing()
    {
        double number1;
        if (myNumber == "")
        {
            EmptyA();
        }
        else if (!double.TryParse(myNumber, out number1))
        {
            Input1 = "";
            Input2 = "";
            AnswerString = "";
            Symbol = "";
            Error = "Invalid Input, Numbers Only";
            IsTextBoxRed = true;

        }
        else
        {
            Answer = Calculator3.Program.SinA(double.Parse(myNumber));
            Symbol = "";
            myNumber2 = "";
            AnswerString = Answer.ToString();
            Input1 = myNumber;
            Input2 = myNumber2 + " =";
            Error = "";
            SinCosTanRecip = "Sin ";
            IsTextBoxRed = false;
        }

    }

    private void CosAing()
    {
        double number1;
        if (myNumber == "")
        {
            EmptyA();
        }
        else if (!double.TryParse(myNumber, out number1))
        {
            Input1 = "";
            Input2 = "";
            AnswerString = "";
            Symbol = "";
            Error = "Invalid Input, Numbers Only";
            IsTextBoxRed = true;

        }
        else
        {
            Answer = Calculator3.Program.CosA(double.Parse(myNumber));
            Symbol = "";
            myNumber2 = "";
            AnswerString = Answer.ToString();
            Input1 = myNumber;
            Input2 = myNumber2 + " =";
            Error = "";
            SinCosTanRecip = "Cos ";
            IsTextBoxRed = false;
        }

    }

    private void TanAing()
    {
        double number1;
        if (myNumber == "")
        {
            EmptyA();
        }
        else if (!double.TryParse(myNumber, out number1))
        {
            Input1 = "";
            Input2 = "";
            AnswerString = "";
            Symbol = "";
            Error = "Invalid Input, Numbers Only";
            IsTextBoxRed = true;

        }
        else
        {
            Answer = Calculator3.Program.TanA(double.Parse(myNumber));
            Symbol = "";
            myNumber2 = "";
            AnswerString = Answer.ToString();
            Input1 = myNumber;
            Input2 = myNumber2 + " =";
            Error = "";
            SinCosTanRecip = "Tan ";
            IsTextBoxRed = false;
        }

    }

    private void ReciprocalAing()
    {
        double number1;
        if (myNumber == "")
        {
            EmptyA();
        }
        else if (!double.TryParse(myNumber, out number1))
        {
            Input1 = "";
            Input2 = "";
            AnswerString = "";
            Symbol = "";
            Error = "Invalid Input, Numbers Only";
            IsTextBoxRed = true;

        }
        else
        {
            Answer = Calculator3.Program.Reciprocal(double.Parse(myNumber));
            Symbol = "";
            myNumber2 = "";
            AnswerString = Answer.ToString();
            Input1 = myNumber;
            Input2 = myNumber2 + " =";
            Error = "";
            SinCosTanRecip = "1 / ";
            IsTextBoxRed = false;
        }

    }











#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
