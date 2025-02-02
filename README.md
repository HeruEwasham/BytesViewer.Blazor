# BytesViewer.Blazor

An interface for viewing different data in a Blazor-project. Including some implementations.

## What is the meaning of this/What do this do.

The interface were created to simplify a process where you, after for instance uploading a file or getting the bytes from another resource, want to show this to the user. If you for instance only allow text-files or a specific video- or audio-file. This might be simple, as it is only one option. But if you want to be able to show the file for any video, audio and text-files. Or for instance also epub-files, it is easier to have an interface and some implementations to handle different cases, and then just gets a Razor-component that shows the content returned to you.

### Why was this originally created?

This interface was originally created to use in [GenericParameterCollection.RadzenBlazor](https://github.com/HeruEwasham/GenericParameterCollection.RadzenBlazor), but the interface is so generic that it can (based on the implementations used) be used in any Blazor-project.

## To use the interface or create your own implementation

To implement the usage of this interface, you will just need to use the Core-package, which every implementation needs. Read more about the interface andd how to use it in the Core's README.

## A note about the license.

All code in this repository is under the MIT-license, including the Core-package. Mark however that some implementations of the interface might use nuget-packages under another license. Read more about evt. 3rd-party packages used in each of the implementations.