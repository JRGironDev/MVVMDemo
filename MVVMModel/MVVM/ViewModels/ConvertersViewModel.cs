using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVVMModel.MVVM.Models;

namespace MVVMModel.MVVM.ViewModels
{
    public class ConvertersViewModel
    {
        public Data Data { get; set; }
        public ConvertersViewModel()
        {
            Data = new Data
            {
                Married = "YES"
            };
        }
    }
}