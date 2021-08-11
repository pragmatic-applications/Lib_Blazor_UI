//using System;
//using System.Net.Http;
//using System.Threading.Tasks;

//using Domain;

//using HttpServices;

//using Interfaces;

//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.Components.Forms;

//using PageFeatures;

//namespace Lib_Blazor_UI
//{
//    public class Component : ComponentBase 
//    { 
//    }

//    public class CoreComponent : Component
//    {
//        protected override void OnInitialized()
//        {
//            base.OnInitialized();

//            this.CurrentTitle = string.IsNullOrWhiteSpace(this.TitleParameter) ? "Blazor & MVC" : this.TitleParameter;
//        }

//        public bool IsDebugConsole { get; set; } = true;

//        public static int EntityId = 0;
//        public string ButtonText { get; set; } = "Save";

//        public FormMode FormMode { get; set; } = FormMode.Create;
//        public string FormTitle { get; set; }

//        [Parameter] public RenderFragment ChildContent { get; set; }

//        [Parameter] public int IdParameter { get; set; } = 0;
//        [Parameter] public string UrlParameter { get; set; } = string.Empty;

//        [Inject] public NavigationManager NavigationManager { get; set; }

//        public string CurrentTitle { get; set; } = string.Empty;
//        public string PageToNavigateTo { get; set; } = string.Empty;

//        public ISelect SelectParameterValue { get; set; }
//        [Parameter] public ISelect SelectParameter { get; set; }
//        public ISelect ItemSelect { get; set; }


//        public string PositionCssClass { get; set; }
//        public string PositionCssClassParameterValue { get; set; }
//        [Parameter] public string PositionCssClassParameter { get; set; }
        

//        [Parameter] public int SpreadParameter { get; set; }
//        [Parameter] public PagerData PagerDataParameter { get; set; }

//        [Parameter] public string AdminTitleParameter { get; set; }
//        [Parameter] public string HomeTitleParameter { get; set; }
//        [Parameter] public string AboutTitleParameter { get; set; }
//        [Parameter] public string ItemTitleParameter { get; set; }
//        [Parameter] public string ProductTitleParameter { get; set; }
//        [Parameter] public string StudentTitleParameter { get; set; }
//        [Parameter] public string ShopTitleParameter { get; set; }

//        [Parameter] public string ButtonLogoValueParameter { get; set; }

//        [Parameter] public string TitleParameter { get; set; }

//        public string HeadTitleValue { get; set; }
//        public int SpreadValue { get; set; }

//        [Parameter] public string BannerTitleParameter { get; set; }
//        public string BannerTitleValue { get; set; }
//        public string HeaderTitle { get; set; }

//        [Parameter] public string AppNameParameter { get; set; }
//        public string AppNameValue { get; set; }
//        public string AppName { get; set; }

//        [CascadingParameter(Name = "ItemTitleValue")] public string ItemTitleCParameter { get; set; }
//        [CascadingParameter(Name = "ProductTitleValue")] public string ProductTitleCParameter { get; set; }
//        [CascadingParameter(Name = "StudentTitleValue")] public string StudentTitleCParameter { get; set; }
//        [CascadingParameter(Name = "AdminTitleValue")] public string AdminTitleCParameter { get; set; }
//        [CascadingParameter(Name = "HomeTitleValue")] public string HomeTitleCParameter { get; set; }
//        [CascadingParameter(Name = "AboutTitleValue")] public string AboutTitleCParameter { get; set; }

//        [CascadingParameter(Name = "ShopTitleValue")] public string ShopTitleCParameter { get; set; }
//        [CascadingParameter(Name = "TitleValue")] public string TitleCParameter { get; set; }
//        [CascadingParameter] public string TitleCascadingParameter { get; set; }

//        [Parameter] public bool IsPageIndexParameter { get; set; } = false;
//        [Parameter] public bool IsCrudParameter { get; set; } = false;
//        [Parameter] public bool IsPageAdminParameter { get; set; } = false;

//        public string UrlUpdate { get; set; }
//        public string UrlDelete { get; set; }

//        protected int ImageCount { get; set; } = 0;

//        protected virtual void ClearFields() { }


//        protected virtual void Reload()
//        {
//            this.ClearFields();
//            this.NavigationManager.NavigateTo("/");
//        }

//        protected void GoToPage(string pageToNavigateTo)
//        {
//            this.ClearFields();
//            this.StateHasChanged();
//            this.NavigationManager.NavigateTo(pageToNavigateTo);
//        }

//        [Inject] public PagingEntity PagingEntity { get; set; }
//        [Inject] public PagerData PagerData { get; set; }

//        [Parameter] public EventCallback<string> OnSearchChanged { get; set; }
//        protected async Task SearchChanged(string searchTerm)
//        {
//            this.PagingEntity.PageNumber = 1;
//            this.PagingEntity.SearchTerm = searchTerm;
//            await this.GetAsync();
//        }

//        [Parameter] public EventCallback<string> OnSortChanged { get; set; }
//        protected async Task SortChanged(string orderBy)
//        {
//            this.PagingEntity.OrderBy = orderBy;
//            await this.GetAsync();
//        }

//        [Parameter] public EventCallback<int> OnSelectedPage { get; set; }
//        protected async Task SelectedPage(int page)
//        {
//            this.PagingEntity.PageNumber = page;

//            await this.GetAsync();
//        }

//        public bool IsLoading { get; set; }
//        public bool IsError { get; set; }

//        protected virtual void LoadDataFail(Exception exception) { }
//        protected virtual void LoadDataCategoryFail(Exception exception) { }

//        protected virtual Task GetAsync() => Task.FromResult(default(object));
//        protected virtual Task GetAsync(int id) => Task.FromResult(default(object));
//        protected virtual Task InsertAsync() => Task.FromResult(default(object));
//        protected virtual Task UpdateAsync() => Task.FromResult(default(object));
//        protected virtual Task DeleteAsync() => Task.FromResult(default(object));
//        protected virtual Task GetEntityCategoryAsync() => Task.FromResult(default(object));
//    }
//}
