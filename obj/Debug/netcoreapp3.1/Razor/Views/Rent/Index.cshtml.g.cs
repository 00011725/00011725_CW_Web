#pragma checksum "E:\Users\00011725\Desktop\Library\Library\Views\Rent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99600651764750a31dda0bd4edf3b3648ed431c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rent_Index), @"mvc.1.0.view", @"/Views/Rent/Index.cshtml")]
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
#line 1 "E:\Users\00011725\Desktop\Library\Library\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Users\00011725\Desktop\Library\Library\Views\_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99600651764750a31dda0bd4edf3b3648ed431c7", @"/Views/Rent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Rent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Users\00011725\Desktop\Library\Library\Views\Rent\Index.cshtml"
  
    ViewData["Title"] = "Rent";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div ng-app=""Library"">
    <div ng-view></div>
</div>
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.8.2/angular.min.js""></script>
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.8.2/angular-route.min.js""></script>
<script type=""text/javascript"">
    // Creating a Module to use within index page
    var baseURL = 'https://localhost:44308/api/'
    angular
        .module('Library', ['ngRoute'])
        .config(function ($routeProvider) {
            $routeProvider
                .when('/',
                    {
                        templateUrl: 'pages/rentIndex.html',
                        controller: 'IndexController'
                    })
                .when('/create',
                    {
                        templateUrl: 'pages/rentCreate.html',
                        controller: 'CreateController'
                    })
                .when('/details/:rentId',
                    {
      ");
            WriteLiteral(@"                  templateUrl: 'pages/rentDetails.html',
                        controller: 'DetailsController'
                    })

                .when('/edit/:rentId',
                    {
                        templateUrl: 'pages/rentEdit.html',
                        controller: 'EditDeleteController'
                    })
                .otherwise({
                    redirectTo: '/'
                });

        })
        .controller('IndexController', ['$scope', '$http', function ($scope, $http) {
            $scope.rents = [];
            $http.get('https://localhost:44308/api/rents/')
                .then(function (res) {

                    $scope.rents = res.data;
                })
        }])
        .controller('CreateController', ['$scope', '$http', '$location', function ($scope, $http, $location) {
            $scope.rent =
            {
                Id: 0,
                bookName: '',
                rentState: '',
                orderDate: ''
");
            WriteLiteral(@"                 
            };
            $scope.AddRent = function () {
                $http.post('https://localhost:44308/api/rents/', $scope.rent)
                    .then(function (res) {
                        $location.path('/')
                    });
            }

        }])
        .controller('DetailsController', ['$scope', '$http', '$routeParams', function ($scope, $http, $routeParams) {
            $scope.details = [];

            $http.get('https://localhost:44308/api/rents/' + $routeParams.RentId)
                .then(function (res) {
                    $scope.details = res.data;
                });

        }])
        .controller('EditDeleteController', ['$scope', '$http', '$location', '$routeParams', function ($scope, $http, $location, $routeParams) {
            $scope.edit = [];

            $http.get('https://localhost:44308/api/rents/' + $routeParams.RentId)
                .then(function (res) {
                    $scope.edit = res.data;
             ");
            WriteLiteral(@"   });

            $scope.Edit = function () {
                $http.put('https://localhost:44308/api/rents/' + $routeParams.RentId, $scope.edit)
                    .then(function (res) {
                        $location.path('/');
                    });
            };
            $scope.Delete = function () {
                $http.delete('https://localhost:44308/api/rents/' + $routeParams.RentId, $scope.edit)
                    .then(function (res) {
                        $location.path('/');
                    });
            };

        }]);
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
