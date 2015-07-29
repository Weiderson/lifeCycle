﻿using System;

namespace MvvmLifeStyle.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new DataItem("Bem Vindo ao MVVM Light");
            callback(item, null);
        }
    }
}