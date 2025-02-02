# BytesViewer.Blazor.Core

An interface for viewing different data in a Blazor-project.

## What is the meaning of this/What do this do.

This interface were created to simplify a process where you, after for instance uploading a file or getting the bytes from another resource, want to show this to the user. If you for instance only allow text-files or a specific video- or audio-file. This might be simple to do, as it is only one option. But if you want to be able to show the file for any video, audio and text-files. Or for instance also epub-files, it is easier to have an interface and some implementations to handle different cases, and then just gets a Razor-component that shows the content returned to you.

### Why was this originally created?

This interface was originally created to use in [GenericParameterCollection.RadzenBlazor](https://github.com/HeruEwasham/GenericParameterCollection.RadzenBlazor), but the interface is so generic that it can (based on the implementations used) be used in any Blazor-project.

## To use the interface

### A short description of what you need to do

To use this interface in an application, you would first have one or more implementations available. Then, when you shall show the data, you would need to get the data. At least the mime type, but if possible also the extension (with a leading dot) and the data as a byte-array. Then you would check through the implementations if any of them can do it by using the CanShowBytes(..)-method.

Then you would use a DynamicComponent and give the returned value of GetComponentParameters(..)-method and GetComponentType(..)-method to let it create the correct thing to show.

### Code-example

This should be used in a razor-page.

```
@if (_byteViewImplementations.Any(v => v.CanShowBytes(mimeType, dataAsBytes, extension)))
{
    var viewImp = _byteViewImplementations.First(v => v.CanShowBytes(mimeType, dataAsBytes, extension));
    <DynamicComponent Type="@viewImp.GetComponentType(mimeType, dataAsBytes, extension)" Parameters="@viewImp.GetComponentParameters(mimeType, dataAsBytes, extension)"></DynamicComponent>
}
```

### Working example

To see a full working example, look at the TestProject in the repository.

## To create your own implementation

Let the class you want to use implement the IBytesView-interface. It is three classes. One is for returning if you can show the data. The two others are for returning the type the razor-component is and for returning a Dictionary with the values to use when initiating the type.

To see examples, look at the code for any of the current implementations.