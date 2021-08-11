﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using PageFeatures;

namespace Lib_Blazor_UI
{
    public class AppComponent : CoreComponent
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.PagingEntity.SearchTerm = string.Empty;
        }
    }
    public class AppComponent<TEntity> : AppComponent where TEntity : class
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.PagingEntity.SearchTerm = string.Empty;
        }

        protected virtual void LoadDataSuccess(PagingResponse<TEntity> data)
        {
            this.IsLoading = false;
            this.IsError = false;
        }
        protected virtual Task TryLoadAsync(Action<PagingResponse<TEntity>> success, Action<Exception> fail) => Task.FromResult(default(object));
    }
    public class AppComponent<TEntity, TEntityCategory> : AppComponent where TEntity : class where TEntityCategory : class
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.PagingEntity.SearchTerm = string.Empty;
        }

        protected virtual void LoadDataSuccess(PagingResponse<TEntity> data)
        {
            this.IsLoading = false;
            this.IsError = false;
        }

        //// NN ??
        //protected virtual void LoadDataSuccess<TDto>(PagingResponse<TDto> data) where TDto : class
        //{
        //    this.IsLoading = false;
        //    this.IsError = false;
        //}
        //// NN ??

        protected virtual Task TryLoadAsync(Action<PagingResponse<TEntity>> success, Action<Exception> fail) => Task.FromResult(default(object));

        protected virtual void LoadEntityCategoryDataSuccess(List<TEntityCategory> data)
        {
            this.IsLoading = false;
            this.IsError = false;
        }
        protected virtual Task TryLoadAsync(Action<List<TEntityCategory>> success, Action<Exception> fail) => Task.FromResult(default(object));
    }
}
