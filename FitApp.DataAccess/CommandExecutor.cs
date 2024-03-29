﻿using FitApp.DataAccess.CQRS.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitApp.DataAccess
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly FitStorageContext _fitStorageContext;
        public CommandExecutor(FitStorageContext fitStorageContext) 
        {
            _fitStorageContext = fitStorageContext;
        }

        Task<TResult> ICommandExecutor.Executor<TParameters, TResult>(CommandBase<TParameters, TResult> command)
        {
            return command.Execute(_fitStorageContext);
        }


  
    }
}
