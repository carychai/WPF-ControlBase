﻿using HeBianGu.Base.WpfBase;
using HeBianGu.General.WpfControlLib;
using HeBianGu.General.WpfMvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeBianGu.Application.LinkWindow
{
    [Route("Image")]
    class ImageController : Controller
    {
        public async Task<IActionResult> ImageCenter()
        {
            return await ViewAsync();
        }
    }
}
