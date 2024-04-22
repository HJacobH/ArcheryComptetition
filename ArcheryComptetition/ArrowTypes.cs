using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryComptetition
{
    public enum ArrowTypes
    {
        WOOD,
        ALUMINUM,
        DURAL,
        CARBON,
    }

    public static class ArrowTypesInfo
    {
        public static IEnumerable Items
        {
            get
            {
                return Enum.GetValues(typeof(ArrowTypes));
            }
        }

        public static ArrowTypes GetEnum(string name)
        {
            switch (name)
            {
                case "WOOD":
                    return ArrowTypes.WOOD;
                case "ALUMINUM":
                    return ArrowTypes.ALUMINUM;
                case "DURAL":
                    return ArrowTypes.DURAL;
                case "CARBON":
                    return ArrowTypes.CARBON;
                default:
                    return ArrowTypes.WOOD;
            }
        }

        public static string GetName(ArrowTypes arrowType)
        {
            switch (arrowType) {             
                case ArrowTypes.WOOD:
                    return "WOOD";
                case ArrowTypes.ALUMINUM:
                    return "ALUMINUM";
                case ArrowTypes.DURAL:
                    return "DURAL";
                case ArrowTypes.CARBON:
                    return "CARBON";
                default:
                    return "";
            
            }
        }
    }
}