﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW1c.Models;
using HW1c.Backend;

namespace HW1c.Controllers
{
    public class ReportController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            var myViewModel = new ReportViewModel();

            myViewModel.LogViewModel = LogBackend.Instance.Index();
            myViewModel.NumberOfUsers = 3;

            return View(myViewModel);
        }

        /// <summary>
        /// Look up the record passed in
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Read(string id = null)
        {
            // If no ID passed in, jump to the Index page
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var myData = LogBackend.Instance.Read(id);
            return View(myData);
        }

        /// <summary>
        /// Show the Data to Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Delete(string id = null)
        {
            // If no ID passed in, jump to the Index page
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var myData = LogBackend.Instance.Read(id);
            return View(myData);
        }

        /// <summary>
        /// Delete Action
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed([Bind(Include ="ID")] string id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            // If no ID passed in, jump to the Index page
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var myData = LogBackend.Instance.Read(id);
            if (myData != null)
            {
                LogBackend.Instance.Delete(id);
            }
            return RedirectToAction("Index");
        }
    }
}