using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PyramidFunnelTypeSample.Pages
{
    public class FunnelCustomizationModel : PageModel
    {
        public void OnGet()
        {
        }
        public class FunnelChartData
        {
            public string xValue;
            public double yValue;
        }
    }
}
