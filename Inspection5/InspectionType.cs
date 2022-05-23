using System.ComponentModel.DataAnnotations;

namespace Inspection5
{
    public class InspectionType
    {
        public int  id { get; set; }

        [StringLength(20)]

        public string InspectionName { get; set; } = String.Empty;
    }
}
