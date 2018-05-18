﻿
using System;
using CrossBackEnd.Shared.Kernel.Core.ValueObjects;
using CrossBackEnd.Shared.Kernel.Core.Interfaces.Collections;
using CrossBackEnd.Shared.Kernel.Core.Interfaces.MVVM;
using System.Threading.Tasks;

namespace CrossBackEnd.Shared.Kernel.Core.Interfaces.AppServices
{
    public interface IBaseAppService<TViewModel>  where TViewModel : IViewModel
    {
        ExecutionResult<bool> Add(TViewModel obj);
        ExecutionResult AddRange(TViewModel[] array);
        ExecutionResult<bool> Update(TViewModel obj);
        ExecutionResult<bool> Remove(Guid id);
        ExecutionResult<bool> Exists(Guid id);
        ExecutionResult<bool> Exists(TViewModel item);
        ExecutionResult<TViewModel> SearchById(Guid id);
        ExecutionResult<IBaseCollection<TViewModel>> LoadAll();
        Task<ExecutionResult<IBaseCollection<TViewModel>>> LoadAllAsync();
    }
}