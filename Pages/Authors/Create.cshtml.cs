﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Moise_Hanna_Lab2.Data;
using Moise_Hanna_Lab2.Models;

namespace Moise_Hanna_Lab2.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Moise_Hanna_Lab2.Data.Moise_Hanna_Lab2Context _context;

        public CreateModel(Moise_Hanna_Lab2.Data.Moise_Hanna_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; } = default!;
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Console.WriteLine($"FirstName: {Author.FirstName}, LastName: {Author.LastName}");

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}