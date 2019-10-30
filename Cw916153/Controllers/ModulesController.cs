using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cw916153.Data;
using Cw916153.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Cw916153.Controllers
{
    [Authorize]
    public class ModulesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ModulesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Modules
        public async Task<IActionResult> Index()
        {

            return View(await _context.Module.ToListAsync());
        }

        // GET: Modules/Details/5
        // Details of a Module
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @module = await _context.Module
                .FirstOrDefaultAsync(m => m.Id == id);

            if (@module == null)
            {
                return NotFound();
            }

            ModulePostViewModel viewModel = await GetModulePostViewModelFromModule(@module);

            return View(viewModel);
        }

        // POST This method Adds a post to the database for a chosen module
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "canUsePostControls")]
        public async Task<ActionResult> Details([Bind("Title,Content,ModuleId")] ModulePostViewModel viewModel)
        {
            Module module = await _context.Module
                    .FirstOrDefaultAsync(m => m.Id == viewModel.ModuleId);

            if (module == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                Post post = GetPostToAddToModule(viewModel, module);

                _context.Post.Add(post);
                _context.SaveChanges();

                viewModel = await GetModulePostViewModelFromModule(module);

                return View(viewModel);
            } 

            ModulePostViewModel notValidReturn = await GetModulePostViewModelFromModule(module);
            return View(notValidReturn);
            
            //return View(viewModel);
        }

        // Sets the Values to the post from the viewmodel
        private Post GetPostToAddToModule(ModulePostViewModel viewModel, Module module)
        {
            Post post = new Post();

            post.CreatedDateTime = DateTime.Now;
            post.Title = viewModel.Title;
            post.Content = viewModel.Content;
            post.Module = module;
            post.ModuleId = module.Id;

            string LoggedInUser = User.Identity.Name;
            IdentityUser currentUser = _context.Users.FirstOrDefault
                (x => x.Email == LoggedInUser);

            post.User = currentUser.UserName;

            return post;
        }

        // Returns the View Model which is a list of posts for given module
        private async Task<ModulePostViewModel> GetModulePostViewModelFromModule(Module module)
        {
            ModulePostViewModel viewModel = new ModulePostViewModel();
            viewModel.Module = module;

            List<Post> posts = await _context.Post
                .Where(m => m.Module.Id == module.Id).ToListAsync();

            viewModel.Posts = posts;

            return viewModel;
        }

        // GET: Modules/Create
        [Authorize(Roles = "canUseModuleControls")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Modules/Create
        // Creates a Module
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "canUseModuleControls")]
        public async Task<IActionResult> Create([Bind("Id,Name")] Module @module)
        {
            if (ModelState.IsValid)
            {

                _context.Add(@module);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@module);
        }

        // GET: Modules/Edit/5
        [Authorize(Roles = "canUseModuleControls")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @module = await _context.Module.FindAsync(id);
            if (@module == null)
            {
                return NotFound();
            }
            return View(@module);
        }

        // POST: Modules/Edit/5
        // Sets the saved changes to the Module
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "canUseModuleControls")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Module @module)
        {
            if (id != @module.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@module);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModuleExists(@module.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(@module);
        }

        // GET: Modules/Delete/5
        [Authorize(Roles = "canUseModuleControls")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @module = await _context.Module
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@module == null)
            {
                return NotFound();
            }

            return View(@module);
        }

        // POST: Modules/Delete/5
        // Deletes the Module along with corresponding Posts and comments of the Posts
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "canUseModuleControls")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @module = await _context.Module.FindAsync(id);

            List<Post> posts = _context.Post
                .Where(x => x.Module.Id == id).ToList();

            // deletes all the posts for the selected module
            foreach (Post delPost in posts)
            {
                _context.Post.Remove(delPost);

                List<Comment> comments = _context.Comment
                    .Where(m => m.Post.Id == delPost.Id).ToList();

                // deletes all the comments for posts whic are in selected module
                foreach (Comment delComment in comments)
                {
                    _context.Comment.Remove(delComment);
                }
            }

            _context.Module.Remove(@module);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModuleExists(int id)
        {
            return _context.Module.Any(e => e.Id == id);
        }
    }
}
