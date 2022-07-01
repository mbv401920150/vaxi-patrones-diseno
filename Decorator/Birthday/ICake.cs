using Decorator.Common;

namespace Decorator.Birthday;

interface ICake
{
    public string Name { get; }
    public Size GetDimensions(Length PropagandaHeight);
}

