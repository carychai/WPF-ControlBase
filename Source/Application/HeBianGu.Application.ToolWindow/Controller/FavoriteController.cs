﻿using HeBianGu.Base.WpfBase;
using HeBianGu.General.WpfControlLib;
using HeBianGu.General.WpfMvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace HeBianGu.Application.ToolWindow
{
    [Route("Favorite")]
    internal class FavoriteController : Controller<FavoriteViewModel>
    {
        public async Task<IActionResult> Home()
        {
            return await ViewAsync();
        }
    }
}
