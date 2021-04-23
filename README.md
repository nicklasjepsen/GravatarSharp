[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=nicklasjepsen_GravatarSharp&metric=alert_status)](https://sonarcloud.io/dashboard?id=nicklasjepsen_GravatarSharp)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=nicklasjepsen_GravatarSharp&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=nicklasjepsen_GravatarSharp)
[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=nicklasjepsen_GravatarSharp&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=nicklasjepsen_GravatarSharp)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=nicklasjepsen_GravatarSharp&metric=security_rating)](https://sonarcloud.io/dashboard?id=nicklasjepsen_GravatarSharp)
[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=nicklasjepsen_GravatarSharp&metric=sqale_index)](https://sonarcloud.io/dashboard?id=nicklasjepsen_GravatarSharp)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=nicklasjepsen_GravatarSharp&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=nicklasjepsen_GravatarSharp)

[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=nicklasjepsen_GravatarSharp&metric=bugs)](https://sonarcloud.io/dashboard?id=nicklasjepsen_GravatarSharp)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=nicklasjepsen_GravatarSharp&metric=duplicated_lines_density)](https://sonarcloud.io/dashboard?id=nicklasjepsen_GravatarSharp)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=nicklasjepsen_GravatarSharp&metric=coverage)](https://sonarcloud.io/dashboard?id=nicklasjepsen_GravatarSharp)
[![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=nicklasjepsen_GravatarSharp&metric=code_smells)](https://sonarcloud.io/dashboard?id=nicklasjepsen_GravatarSharp)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=nicklasjepsen_GravatarSharp&metric=ncloc)](https://sonarcloud.io/dashboard?id=nicklasjepsen_GravatarSharp)

# GravatarSharp
A very simple API for interacting with Gravatar using C#

## How to use
If you just want to use the library, use [the Nuget package](https://www.nuget.org/packages/GravatarSharp.Core).

Otherwise, feel free to get the source code and include it in any project you like.

## Examples
You can get a Gravatar image url from an email address pretty simple:
  `GravatarController.GetImageUrl(someone@mail.com);`
  
If you need a specific image size then do:
  `GravatarController.GetImageUrl(someone@mail.com, 64);` (Default is 128 px)

You can get the Gravatar user profile:

  `var controller = new GravatarController();`
  
  `var profileResult = await controller.GetProfile(someone@mail.com);`
  
This profile provides various information that the user has entered, for instance name, location and other handy stuff.
  
## Read more
[Here](https://blog.jepsen.ninja/gravatar-c-api) is a blog post about this library.

And [here](https://blog.jepsen.ninja/getting-a-users-gravatar-data-using-azure-functions) is an article on how to use the library in a Azure Function.
