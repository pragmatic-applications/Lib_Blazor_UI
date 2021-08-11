using PageFeatures;

namespace Lib_Blazor_UI.Views
{
    public partial class PageFeature : CoreComponent
    {
        public PagerData PagerDataValue { get; set; }

        protected override void OnParametersSet()
        {
            this.PagerDataValue = this.PagerDataParameter;
            this.SelectParameterValue = this.SelectParameter;
            this.PositionCssClassParameterValue = this.PositionCssClassParameter;
            this.SpreadValue = this.SpreadParameter;
        }
    }
}
