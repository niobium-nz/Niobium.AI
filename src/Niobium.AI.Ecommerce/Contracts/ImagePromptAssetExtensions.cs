namespace Niobium.AI.Ecommerce.Contracts;

internal static class ImagePromptAssetExtensions
{
    public static ImageForm ToImageForm(this ImagePromptAsset input) => input.Orientation.Equals("portrait", StringComparison.InvariantCultureIgnoreCase)
            || input.Orientation.Equals("vertical", StringComparison.InvariantCultureIgnoreCase)
            ? ImageForm.Portrait
            : input.Orientation.Equals("landscape", StringComparison.InvariantCultureIgnoreCase)
                            || input.Orientation.Equals("horizontal", StringComparison.InvariantCultureIgnoreCase)
                ? ImageForm.Landscape
                : ImageForm.Square;
}
