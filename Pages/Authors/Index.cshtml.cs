﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Moise_Hanna_Lab2.Data;
using Moise_Hanna_Lab2.Models;

namespace Moise_Hanna_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Moise_Hanna_Lab2.Data.Moise_Hanna_Lab2Context _context;

        public IndexModel(Moise_Hanna_Lab2.Data.Moise_Hanna_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
