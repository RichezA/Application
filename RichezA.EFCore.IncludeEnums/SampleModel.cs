namespace RichezA.EFCore.IncludeEnums
{
    public class SampleModel
    {
        /// <summary>
        /// Reflects your database entity relationships.
        /// </summary>
        public IEnumerable<RelatedSampleModel> RelatedSampleModels { get; set; }
    }

    public class RelatedSampleModel
    {
        public SampleModel SampleModel { get; set; }
        
        public NestedRelatedSampleModel NestedRelatedSampleModel { get; set; }
    }

    public class NestedRelatedSampleModel
    {
        public int Id { get; set; }
    }
}