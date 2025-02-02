namespace YngveHestem.BytesViewer.Blazor.Core;

public interface IBytesView
{
    /// <summary>
    /// Check if the given mime-type/extension/bytes can be viewed by this implementation.
    /// </summary>
    /// <param name="mimeType">The given mime type.</param>
    /// <param name="bytes">The bytes that shall be shown. This parameter can be null, but some implementations might want to require it, so read the implementations documentation of what is used/required.</param>
    /// <param name="extension">The given extension with a leading dot. This parameter can be null, but some implementations might require it, so read the implementations documentation of what is used/required.</param>
    /// <returns></returns>
    public Task<bool> CanShowBytes(string mimeType, byte[]? bytes = null, string? extension = null);
    
    /// <summary>
    /// Gets the parameters for the component that will be created to show the data the bytes contains.
    /// 
    /// Mark that while some type-checking might be done because an implementation might do something different based on the type, it is not required to, so if CanShowBytes(..) are not checkedd first, this might give exception or show something that look strange.
    /// </summary>
    /// <param name="mimeType">The given mime type.</param>
    /// <param name="bytes">The bytes that shall be shown.</param>
    /// <param name="extension">The given extension with a leading dot. This parameter can be null, but some implementations might require it.</param>
    /// <returns>A dictionary containing the component parameters.</returns>
    public Task<Dictionary<string, object>> GetComponentParameters(string mimeType, byte[] bytes, string? extension = null);

    /// <summary>
    /// Returns the type of razor-component that will be created. The parameters are still sent in if an implementation send out different types based on the data.
    /// </summary>
    /// <param name="mimeType">The given mime type.</param>
    /// <param name="bytes">The bytes that shall be shown. This parameter can be null, but some implementations might want to require it, so read the implementations documentation of what is used/required.</param>
    /// <param name="extension">The given extension with a leading dot. This parameter can be null, but some implementations might require it, so read the implementations documentation of what is used/required.</param>
    /// <returns>The type that should be created to show the data.</returns>
    public Task<Type> GetComponentType(string mimeType, byte[]? bytes = null, string? extension = null);
}
