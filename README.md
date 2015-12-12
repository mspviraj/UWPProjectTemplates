# UWPProjectTemplates
Visual Studio 2015 Project Templates for Universal Windows Platform


**Acknowledgements** - Most of the code for UWPShellTemplate came from these 2 sources

1. Channel 9 Build 2015 - Mical Lewis - Universal Navigation and Commanding for Your XAML - https://channel9.msdn.com/Events/Build/2015/2-97
2. Universal Windows Sample - https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlNavigation which is the code from the Channel 9 video.


**UWPShellTemplate Features**

1. AppShell with SplitView/Frame
2. Uses custom NavMenuListView for SplitView.Pane
3. Highlights select item in NavMenuListView
4. Keyboard support is very good
5. Support Hierarchical navigation with a DrillinPage and a BasicSubPage
6. CommandBar Page uses CommandBar and Menu flyouts in CommandBar.SecondaryCommands
7. AdaptiveTrigger changes SplitView DisplayMode at "0" and "720" widths


**My Changes**

1. AppShell.xaml
	* Replaced HamburgerButton ToogleButton with a Button because ToogleButton wouldn't respond to the Enter key.
	* Added HamburgerButton_Click in code behind to toggle SplitView pane.
	* Moved BackButton from controls:NavMenuListView to the right side of HamburgerButton.
	* Added  horizontal StackPanel to contain HamburgerButton, BackButton, Page Title, AutoSuggestBox.
	* Changed BackButton IsEnabled attribute to a Visibility attribute.
	* Added a BooleanToVisibilityConverter to BackButton's Visibility attribute
2. Styles.xaml
	* Commented out TextBlock in NavigationBackButtonStyle to make BackButton content just the back arrow
3. Changes are commented in the code.

	
**Steps to make either solution a Visual Studio Project Template**:

1. Main Men
2. Export Template
3. Choose Template (Select Project Template)
4. Select Template Options (Enter Description)
5. Finish
6.Project Template appears in Visual Studio under Installed -> Templates -> Visual C# Visual Studio creates a .zip file in:
	* ..\Users\(user)\Documents\Visual Studio 2015\Templates\ProjectTemplates
	* ..\Users\(user)\Documents\Visual Studio 2015\MyExportedTemplates
	* ..\Users\(user)\AppData\Roaming\Microsoft\VisualStudio\14.0\ProjectTemplatesCache (after it has been used)
7. To remove the Project Template just delete the .zip files from the above 3 locations.


**FixUps**

When the Visual C# Project Template is used to create a New Project all the namespaces are converted to the New Project name but the Packages.appxmanifest still contains template names so I replace the word UWPShellTemplate with <New Project Name> in these places:

1. Application tab
	* Display name
	* Entry point - keep the .App
	* Description
2. Packaging tab
	* Package display name
	* Delete the Package name GUID and replace with a new one from Tools->Create GUID->#4 Registry removing the brackets

**UWPShellTemplate Views** 

1. LandingPage - good place for app features and instructions
2. BasicPage - ordinary page
3. DrillInPage - good sample for Hierarchical navigation
4. BasicSubPage - works with DrillInPage 
5. CommandBarPage - good example of commands and button flyouts

Feel free to delete any of the example pages and substitute your own.

Remember to:

1. Give each page a name so that it's shown in the PageTitle
2. Update AppShell.xaml.cs with NavMenuItems (including item icon and label) corresponding to your pages.
3. Update AppShell.xaml with SplitView 'OpenPanelLength' to show complete NavMenuItem label


**UWPSimpleTemplate** is bare bones. No SplitView but some converters. Saves creating some basic folders for a MVVM type project.

**Future Project Templates** based on Navigation Patterns:

1. Master-Detail
2. Tabs
3. Hub & Spoke
4. Pivots

	





