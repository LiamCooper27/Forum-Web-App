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
using Microsoft.AspNetCore.Authorization;

namespace Cw916153.Controllers
{
    [Authorize]
    public class PostsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Posts
        public IActionResult Index()
        {
            //return View(await _context.Post.ToListAsync());
            return RedirectToAction("Index", "Modules");
        }

        // GET: Posts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Post
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            PostCommentViewModel viewModel = await GetPostCommentViewModelFromPost(post);

            return View(viewModel);
        }

        //POST this method adds a comment to the DB with the post as a foreign key
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "canUsePostControls, canCreateComment")]
        public async Task<IActionResult> Details([Bind("Id,Content,IsAnon,PostId")] PostCommentViewModel viewModel)
        {
            Post post = await _context.Post
                    .FirstOrDefaultAsync(x => x.Id == viewModel.PostId);

            if (post == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                Comment comment = GetCommentToAddToPost(viewModel, post);

                _context.Comment.Add(comment);
                _context.SaveChanges();

                viewModel = await GetPostCommentViewModelFromPost(post);
                return View(viewModel);
            }

            PostCommentViewModel notValidView = await GetPostCommentViewModelFromPost(post);
            return View(notValidView);
        }

        // Gets the comment values from the viewmodel ready to add to database
        private Comment GetCommentToAddToPost(PostCommentViewModel viewModel, Post post)
        {
            Comment comment = new Comment();

            comment.CreatedDateTime = DateTime.Now;
            comment.Content = viewModel.Content;
            comment.IsAnon = viewModel.IsAnon;
            comment.PostId = post.Id;
            comment.Post = post;

            string LoggedInUser = User.Identity.Name;
            IdentityUser currentUser = _context.Users.FirstOrDefault
                (x => x.Email == LoggedInUser);

            comment.User = currentUser.UserName;

            return comment;
        }

        // sets the correct values to the viewmodel to display
        private async Task<PostCommentViewModel> GetPostCommentViewModelFromPost(Post post)
        {
            PostCommentViewModel viewModel = new PostCommentViewModel();
            viewModel.Post = post;
            viewModel.Module = post.Module;

            List<Comment> comments = await _context.Comment
                .Where(m => m.Post.Id == post.Id).ToListAsync();

            viewModel.Comments = comments;

            return viewModel;
        }


        // GET: Posts/Edit/5
        [Authorize(Roles = "canUsePostControls")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Post.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        // POST: Posts/Edit/5
        // Saves changes to the correct post if valid
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "canUsePostControls")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,CreatedDateTime,ModuleId,User")] Post post)
        {
            if (id != post.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(post);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Details", "Posts", new { id = post.Id });
            }
            return View(post);
        }

        // GET: Posts/Delete/5
        [Authorize(Roles = "canUsePostControls")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Post
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Posts/Delete/5
        // Deletes the post and its corresponding comments
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "canUsePostControls")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await _context.Post.FindAsync(id);

            List<Comment> comments = _context.Comment
                .Where(m => m.Post.Id == post.Id).ToList();

            // deletes comments for a post
            foreach (Comment item in comments)
            {
                _context.Comment.Remove(item);
            }

            _context.Post.Remove(post);
            await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
            return RedirectToAction("Details", "Modules", new { id = post.ModuleId });
        }

        private bool PostExists(int id)
        {
            return _context.Post.Any(e => e.Id == id);
        }
    }
}
