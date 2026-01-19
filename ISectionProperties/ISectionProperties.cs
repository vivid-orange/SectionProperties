using VividOrange.Geometry;
using VividOrange.Serialization;

namespace VividOrange.Sections.SectionProperties
{
    public interface ISectionProperties : ITaxonomySerializable
    {
        ILocalDomain2d Extends { get; }
        ILocalPoint2d Centroid { get; }
        Length Perimeter { get; }
        Area Area { get; }
        SectionModulus ElasticSectionModulusYy { get; }
        SectionModulus ElasticSectionModulusZz { get; }
        AreaMomentOfInertia MomentOfInertiaYy { get; }
        AreaMomentOfInertia MomentOfInertiaZz { get; }
        Length RadiusOfGyrationYy { get; }
        Length RadiusOfGyrationZz { get; }
    }
}
