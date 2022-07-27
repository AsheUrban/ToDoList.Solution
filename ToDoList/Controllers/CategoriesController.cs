// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc;
// using ToDoList.Models;
// using System.Collections.Generic;
// using System.Linq;

// namespace ToDoList.Controllers
// {
//   public class CategoriesController : Controller
//   {
//     private readonly ToDoListContext _db;

//     public CategoriesController(ToDoListContext db)
//     {
//       _db = db;
//     }

//     public ActionResult Index()
//     {
//       List<Category> model = _db.Categories.Include(category => category.Name).ToList();
//       return View(model);
//     }

//     public ActionResult Create()
//     {
//       return View();
//     }

//     [HttpPost]
//     public ActionResult Create(Category category)
//     {
//       _db.Categories.Add(category);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

    // public ActionResult Details(int id)
    // {
    //   Category thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
    //   return View(thisCategory);
    // }

    // public ActionResult Edit(int id)
    // {
    //   var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId ==id);
    //   return View(thisCategory);
    // }

    // [HttpPost]
    // public ActionResult Edit(Categories category)
    // {
    //   _db.Entry(category).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   var thisItem = _db.Items.FirstOrDefault(item => item.ItemId == id);
    //   return View(thisItem);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisItem = _db.Items.FirstOrDefault(item => item.ItemId == id);
    //   _db.Items.Remove(thisItem);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
//   }
// }




// using System.Collections.Generic;
// using System;
// using Microsoft.AspNetCore.Mvc;
// using ToDoList.Models;

// namespace ToDoList.Controllers
// {
//   public class CategoriesController : Controller
//   {
//     [HttpGet("/categories")]
//     public ActionResult Index()
//     {
//       List<Category> allCategories = Category.GetAll();
//       return View(allCategories);
//     }

//     [HttpGet("/categories/new")]
//     public ActionResult New()
//     {
//       return View();
//     }

//     [HttpPost("/categories")]
//     public ActionResult Create(string categoryName)
//     {
//       Category newCategory = new Category(categoryName);
//       return RedirectToAction("Index");
//     }

//     [HttpGet("/categories/{id}")]
//     public ActionResult Show(int id)
//     {
//       Dictionary<string, object> model = new Dictionary<string, object>();
//       Category selectedCategory = Category.Find(id);
//       List<Item> categoryItems = selectedCategory.Items;
//       model.Add("category", selectedCategory);
//       model.Add("items", categoryItems);
//       return View(model);
//     }

//     // This one creates new Items within a given Category, not new Categories:
//     [HttpPost("/categories/{categoryId}/items")]
//     public ActionResult Create(int categoryId, string itemDescription)
//     {
//       Dictionary<string, object> model = new Dictionary<string, object>();
//       Category foundCategory = Category.Find(categoryId);
//       Item newItem = new Item(itemDescription);
//       newItem.Save();    // New code
//       foundCategory.AddItem(newItem);
//       List<Item> categoryItems = foundCategory.Items;
//       model.Add("items", categoryItems);
//       model.Add("category", foundCategory);
//       return View("Show", model);
//     }

//   }
// }