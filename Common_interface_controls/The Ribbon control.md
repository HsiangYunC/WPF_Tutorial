# Ribbon

The Ribbon interface was invented by Microsoft and first used in Office 2007. It combines the original menu and toolbar(s) into one control, with various functions grouped into tabs and groups. The most important purpose was to make it easier for the user to discover all the functionality, instead of hiding it in long menus. The Ribbon also allows for prioritization of functionality, with the ability to use different sizes of buttons.

![[ribbon]](./ribbon.png)

WPF doesn't come with a built-in Ribbon control, but Microsoft has released one that you can download and use for free, as long as you promise to follow their implementation guide when using it. You can read much more about it at [MSDN](http://msdn.microsoft.com/en-us/library/ff799534.aspx), where you'll also find a [download link](http://go.microsoft.com/fwlink/?LinkId=196621) for the Ribbon control.

You can download and use a Microsoft created Ribbon control, but it's not yet a part of the .NET framework by default. Once it becomes an integrated part of the framework, we'll dig into it here at this tutorial. In the meantime, if you're looking for a more complete Ribbon implementation, you might want to look at some 3rd party alternatives - there are plenty of them, from some of the big WPF control vendors.
