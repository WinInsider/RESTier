RESTier solusion consists of three projects:

- [Restier.Core](https://www.nuget.org/packages/WinInsider.Microsoft.Restier.Core/ "Restier.Core") ([original](https://github.com/OData/RESTier/tree/master/src "original"))
- [Microsoft.Restier.Providers.EntityFrameworkCore](https://www.nuget.org/packages/Microsoft.Restier.Providers.EntityFrameworkCore/ "Microsoft.Restier.Providers.EntityFrameworkCore") ([original](https://github.com/OData/RESTier/tree/master/src/Microsoft.Restier.Providers.EntityFramework7 "original"))
- [WinInsider.HttpHosting.Restier](https://www.nuget.org/packages/WinInsider.HttpHosting.Restier/ "WinInsider.HttpHosting.Restier")  ("kind of" Microsoft.Restier.Publishers.OData [original](https://github.com/OData/RESTier/tree/master/src/Microsoft.Restier.Publishers.OData "original"))

While the first two projects are miror copy, retargeted for .NET Standard, with one excpetion (1);  WinInsider.HttpHosting.Restier is a diffrent implementation as it is based on [OWIN version](https://www.nuget.org/packages/WinInsider.Microsoft.Owin/ "OWIN version"), also retargeted for .NET Standard.

(1) Microsoft.Restier.Providers.EntityFrameworkCore, besides considering DbSet<> properties on DbContext, also considers IQueryable<>
