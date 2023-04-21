using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using static GetDataMvc.BusinessObjects.Color;



namespace GetDataMvc.BusinessObjects
{
    public static class ColorHelper
    {
        public static string ToHtmlColor(Color color)
        {
            switch (color)
            {
                case White:
                    //return "white";
                    return "azure";
                case Yellow:
                    return "yellow";
                case Orange:
                    return "orange";
                case Purple:
                    return "purple";
                case Magenta:
                    return "magenta";
                case Lilac:
                    //return "lilac";  // lilac does not exist
                    return "darkviolet";
                case Red:
                    return "red";
                case Green:
                    return "green";
                case Blue:
                    return "blue";
                case Brown:
                    return "brown";
                case Black:
                    return "black";
                default:
                    return "black";
            }
        }
    }
}
