using Microsoft.EntityFrameworkCore;

namespace Airline.Enities
{
    [Owned]
    internal class Crew
    {
        public string? MajorPilot { get; set; }
        public string? AssistantPilot { get; set; }
        public string? Host1 { get; set; }
        public string? Host2 { get; set; }
    }
}
