namespace RichezA.EFCore.IncludeEnums
{
    /// <summary>
    /// Use this attribute on enums to reflect the include paths.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class IncludesAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the attribute.
        /// </summary>
        /// <param name="paths">The relative path to include entities.</param>
        public IncludesAttribute(params string[] paths)
        {
            this.Paths = paths;
        }
        
        /// <summary>
        /// Gets the include path.
        /// </summary>
        public string[] Paths { get; }
    }
}