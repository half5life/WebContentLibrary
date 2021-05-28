using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebContentLibrary.Models;

namespace WebContentLibrary.Controllers
{
    public class FileExtensionsController : Controller
    {
        private ItemContext db = new ItemContext();

        // GET: FileExtensions
        [Authorize]
        public async Task<ActionResult> Index()
        {
            return View(await db.FileExtensions.ToListAsync());
        }

        // GET: FileExtensions/Details/5
        [Authorize]
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FileExtension fileExtension = await db.FileExtensions.FindAsync(id);
            if (fileExtension == null)
            {
                return HttpNotFound();
            }
            return View(fileExtension);
        }

        // GET: FileExtensions/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: FileExtensions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(string[] fileExtensions)
        {
            if (ModelState.IsValid)
            {
                foreach(var ext in fileExtensions)
                {
                    FileExtension fileExtension = new FileExtension();
                    fileExtension.NameExt = ext;
                    db.FileExtensions.Add(fileExtension);
                }
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        // GET: FileExtensions/Edit/5
        [Authorize]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FileExtension fileExtension = await db.FileExtensions.FindAsync(id);
            if (fileExtension == null)
            {
                return HttpNotFound();
            }
            return View(fileExtension);
        }

        // POST: FileExtensions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,NameExt")] FileExtension fileExtension)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fileExtension).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(fileExtension);
        }

        // GET: FileExtensions/Delete/5
        [Authorize]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FileExtension fileExtension = await db.FileExtensions.FindAsync(id);
            if (fileExtension == null)
            {
                return HttpNotFound();
            }
            return View(fileExtension);
        }

        // POST: FileExtensions/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FileExtension fileExtension = await db.FileExtensions.FindAsync(id);
            db.FileExtensions.Remove(fileExtension);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
