﻿using WMS.Views.Picklists;
using WMS.Views.Products;

namespace WMS;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(
            $"{nameof(PicklistListPage)}/{nameof(PicklistDetailPage)}",
            typeof(PicklistDetailPage)
        );

        Routing.RegisterRoute(
            $"{nameof(ProductListPage)}/{nameof(ProductDetailPage)}",
            typeof(ProductDetailPage)
        );

        Routing.RegisterRoute(
            $"{nameof(ProductListPage)}/{nameof(ProductDetailPage)}/{nameof(TransferStockPage)}",
            typeof(TransferStockPage)
        );
    }
}
