namespace RichezA.EFCore.IncludeEnums
{
    [Flags]
    public enum SampleIncludes
    {
        None = 0,
        
        [Includes(nameof(SampleModel.RelatedSampleModels))]
        RelatedSampleModels = 1 << 0,
        
        [Includes(nameof(SampleModel.RelatedSampleModels) + "." + nameof(RelatedSampleModel.SampleModel))]
        NestedRelatedSampleModel = 2 << 0,
        
        All = RelatedSampleModels | NestedRelatedSampleModel,
    }
}