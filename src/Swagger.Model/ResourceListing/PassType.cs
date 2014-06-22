using Swagger.Model.Attributes;

namespace Swagger.Model.ResourceListing
{
    /// <summary>
    /// Used in <see cref="Authorization"/> to denote how an API key should be passed.
    /// </summary>
    [SwaggerData]
    public enum PassType
    {
        [SwaggerEnumValue("header")] Header,

        [SwaggerEnumValue("query")] Query
    }
}