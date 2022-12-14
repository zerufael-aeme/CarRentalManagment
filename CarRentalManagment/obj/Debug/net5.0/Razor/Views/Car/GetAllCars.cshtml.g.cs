#pragma checksum "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feaba6b228676e1dd4c6b903baceaf1ba6a079e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_GetAllCars), @"mvc.1.0.view", @"/Views/Car/GetAllCars.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\_ViewImports.cshtml"
using CarRentalManagment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\_ViewImports.cshtml"
using CarRentalManagment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feaba6b228676e1dd4c6b903baceaf1ba6a079e4", @"/Views/Car/GetAllCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84edda3bef20d461164c430178333769f3c6da74", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Car_GetAllCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Car>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n   <div");
            BeginWriteAttribute("class", " class=\"", 89, "\"", 97, 0);
            EndWriteAttribute();
            WriteLiteral(@">
      <table class=""table"">
        <tr class=""bg-dark text-primary rounded"">
            <th>Car Id</th>
            <th>Catagory</th>
            <th>Name</th>
            <th>License No</th>
            <th>Rented</th>
            <th>Booked</th>
            <th><a href=""/Car/AddCar"" class=""btn btn-primary"">Add a New Car</a></th>
        </tr>
");
#nullable restore
#line 18 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
               Write(item.carId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 22 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
                      
                        if (@item.catagory == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>City Car</td>\r\n");
#nullable restore
#line 26 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
                        }else if (@item.catagory == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>SUV</td>\r\n");
#nullable restore
#line 29 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
                        }else if (@item.catagory == 3)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Off-Road</td>\r\n");
#nullable restore
#line 32 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 34 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
               Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
               Write(item.licNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 36 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
                  
                if (@item.isRented==true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Rented</td>\r\n");
#nullable restore
#line 40 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Not Rented</td>\r\n");
#nullable restore
#line 44 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
                }
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
                  
                if (@item.isBooked==true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Booked</td>\r\n");
#nullable restore
#line 50 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Not Booked</td>\r\n");
#nullable restore
#line 54 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
                }
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
                  if (@item.isRented == false && @item.isBooked==false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1778, "\"", 1815, 2);
            WriteAttributeValue("", 1785, "/RentOrder/RentCar/", 1785, 19, true);
#nullable restore
#line 59 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
WriteAttributeValue("", 1804, item.carId, 1804, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\" > Rent Car</a>\r\n                          </td>    \r\n");
#nullable restore
#line 61 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1984, "\"", 2018, 2);
            WriteAttributeValue("", 1991, "/Car/DeleteById/", 1991, 16, true);
#nullable restore
#line 64 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
WriteAttributeValue("", 2007, item.carId, 2007, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Delete</a>\r\n                </td>\r\n");
#nullable restore
#line 66 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
                  if (@item.isBooked == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <td>\r\n                                     <a");
            BeginWriteAttribute("href", " href=\"", 2231, "\"", 2267, 2);
            WriteAttributeValue("", 2238, "/BookOrder/UnBook/", 2238, 18, true);
#nullable restore
#line 69 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
WriteAttributeValue("", 2256, item.carId, 2256, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">UnBook</a>\r\n                                 </td>\r\n");
#nullable restore
#line 71 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
                      
                        if (@item.isRented == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                 <a");
            BeginWriteAttribute("href", " href=\"", 2546, "\"", 2585, 2);
            WriteAttributeValue("", 2553, "/RentOrder/ReturnCar/", 2553, 21, true);
#nullable restore
#line 76 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
WriteAttributeValue("", 2574, item.carId, 2574, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Return</a>\r\n                             </td>\r\n");
#nullable restore
#line 78 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 80 "C:\Users\hp\source\repos\CarRentalManagment\CarRentalManagment\Views\Car\GetAllCars.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </table>\r\n   </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Car>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
