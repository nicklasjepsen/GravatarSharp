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
