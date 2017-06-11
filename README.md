<a name="HOLTitle"></a>
# Winter of Xamarin Events in New Zeland #
This guide will help you set up for the in-person events and will guide you through the basic installation of Visual Studio 2017 with all the tools and extentions neccessary for the event.

More information about the events and competition - [http://aka.ms/winterofxamarin](http://aka.ms/winterofxamarin)

---

<a name="Overview"></a>
## Overview ##

One of the key challenges in developing mobile applications for multiple devices and platforms is the diverse set of tools, languages, and resources required to develop and maintain features and functionality across a variety of programming languages, APIs, and user-interface paradigms. 

[Xamarin](https://www.xamarin.com/) offers one solution to the problem by allowing apps to be written in C# for iOS, Android, and Windows using a common API based on Microsoft .NET. Because Xamarin apps use native user interface controls, apps look and act the way a user expects for a given device and platform. Xamarin apps also have access to the full spectrum of functionality exposed by the underlying operating system and device and are compiled into native binaries for performance.  

[Xamarin Forms](https://www.xamarin.com/forms) is a framework included with Xamarin that allows developers to create cross-platform user interfaces by defining those interfaces in XAML or code. Controls and UI elements created this way render native controls for the host platform, so iOS users see iOS controls and Android users see Android controls. Whereas classic Xamarin apps share code but not UI, Xamarin Forms apps share code *and* UI and are frequently able to share 95% of their source code across platforms.

[Visual Studio 2017](https://www.visualstudio.com/vs/) provides seamless support for Xamarin and Xamarin Forms so you can build cutting-edge mobile apps for a variety of platforms using a single set of tools and APIs. In Part 1 of Operation Remote Resupply, you will use Visual Studio 2017 and Xamarin Forms to create a drone-lander app that lets you fly simulated supply missions to Mars. In subsequent sessions, you will build upon what you created here to expand the app's features and capabilities.

<a name="Prerequisites"></a>
### Prerequisites ###

The following are required to complete this lab:

- [Visual Studio Community 2017](https://www.visualstudio.com/vs/) or higher
- A Microsoft Account - such as @live.com, @outlook.com. We will need this for signing up to Azure later on the day.  


---
<a name="Config"></a>
## Configure Visual Studio 2017 for Xamarin Development ##

If Visual Studio 2017 is already installed on your computer, it's important to make sure it is configured with the proper components and workloads to support Xamarin development. If it *isn't* installed, then you need to install it with the proper workloads. You can install the Community edition, which is free, or any other edition that you would like. The Community edition and other editions of Visual Studio 2017 can be downloaded from https://www.visualstudio.com/vs/.

If Visual Studio is already installed, you can determine which components and workloads are installed by starting the Visual Studio installer. (An easy way to do that is to press the Windows key, type "installer," and select **Visual Studio Installer** from the menu. You can then click the **Modify** button to view a list of installed components.) If you are installing Visual Studio for the first time, the same UI allows you to select the component and workloads to installed. Here is what must be installed for you to complete this lab and subsequent labs. 

1. Under "Workloads" in the Visual Studio installer, make sure **Universal Windows Platform development** and **.NET desktop development** are checked.

    ![Installing the UWP and .NET development workloads](Images/workload-1.png)

    _Installing the UWP and .NET development workloads_

1. Under "Workloads" in the Visual Studio installer, make sure **Mobile development with .NET** is checked.

    ![Installing the mobile development workload](Images/workload-2.png)

    _Installing the mobile development workload_

1. Under "Individual Components" in the Visual Studio installer, make sure **Visual Studio Emulator for Android** and **Windows 10 Mobile Emulator (Creators Update)** are checked. If you would prefer to use the Google Android emulator instead, you may do so if you choose.

	> If you haven't installed the Windows Creators Update, select the Anniversary Edition instead. If these emulators don't appear as options in the Visual Studio installer, it could because your PC doesn't support virtualization or that virtualization hasn't been enabled. For more information, see https://msdn.microsoft.com/en-us/library/mt228280.aspx.

    ![Installing emulators](Images/workload-3.png)

    _Installing emulators_

Once these workloads and components are installed, you are ready to begin creating Xamarin Forms apps.
