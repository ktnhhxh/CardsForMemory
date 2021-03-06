﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardsForMemoryLibrary.IServices;
using CardsForMemoryLibrary.Services;
using GalaSoft.MvvmLight.Ioc;

namespace CardsForMemory.Locator {
    /// <summary>
    ///     定位器
    /// </summary>
    public class ViewModelLocator {
        /// <summary>
        ///     ViewModel定位器单件
        /// </summary>
        public static readonly ViewModelLocator Instance =
            new ViewModelLocator();

        /// <summary>
        ///     私有构造
        /// </summary>
        private ViewModelLocator() {
            SimpleIoc.Default.Register<ICardService, CardService>();
            SimpleIoc.Default.Register<IPackageService, PackageService>();
            SimpleIoc.Default.Register<ISqliteConnectionService, SqliteConnectionService>();
        }

        //public XxxViewModel XxxViewModel = SimpleIoc.Default.GetInstance<>();
    }
}
