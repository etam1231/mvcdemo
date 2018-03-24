using MvcLifeCycle.Entity;
using MvcLifeCycle.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace MvcLifeCycle.Controllers
{
   
    public class HomeController : Controller
    {
        SampleEntities db = new SampleEntities();
        //public ActionResult Index()
        //{
        //    //List<tblPerson> obj = new List<tblPerson>();
        //    //var data = db.spGetPersonByCountry("India").ToList();
        //    //obj = db.GetPersonByCountry("India").ToList();

        //    //int Count = 0;
        //    //ObjectParameter returnCount= new ObjectParameter("PersonCount", typeof(Int32));
        //    //db.spGetPersonCountByCountry(returnCount, "India");
        //    ////var PersonCountByCountry = db.GetPersonCountByCountry(, "London");
        //    ////var value = Request.Cookies["UserInformation"].Values;
        //    ////HttpCookie ck = new HttpCookie("UserInformation");
        //    ////ck.Values.Add("Username", "etam1231@gmail.com");
        //    ////ck.Values.Add("Password", "12345678");
        //    ////Response.Cookies.Add(ck);

        //    //return RedirectToAction("Login", "Account");
        //}

        public ActionResult CreateStickyNote(stickyNote stickynote)
        {
            StickyNote obj = new StickyNote();
            obj.Text = stickynote.text;
            obj.Left = stickynote.left;
            obj.Top = stickynote.top;
            obj.Colour = stickynote.colour;
            obj.Width = stickynote.width;
            obj.Height = stickynote.height;
            db.StickyNotes.Add(obj);
            db.SaveChanges();           
            return Json(obj.Id,JsonRequestBehavior.AllowGet);
        }

        public ActionResult UpdateStickyNote(stickyNote stickynote)
        {
            StickyNote obj = new StickyNote();
            obj.Text = stickynote.text;
            obj.Left = stickynote.left;
            obj.Top = stickynote.top;
            obj.Colour = stickynote.colour;
            obj.Width = stickynote.width;
            obj.Height = stickynote.height;
            obj.Id = stickynote.id;
            db.Entry(obj).State= EntityState.Modified;
            db.SaveChanges();
            return Json(stickynote.id, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            
            //Inner Join
            //In sql Like querry

            var resultInnerJoinInSql = (from e in db.tblPersons
                          join d in db.tbldepartments
                          on e.DepartmentId equals d.Id
                          select new
                          {
                              EmployeeName = e.Name,
                              Country = e.Country,
                              Department = d.DepartmentName
                          }).ToList();

            //Lamada Expression

            var resultInnerJoinInLamada = db.tblPersons.Join(db.tbldepartments, x => x.DepartmentId, y => y.Id, (e, d) =>
                     new
                     {
                         EmployeeName = e.Name,
                         Country = e.Country,
                         DepartmentName = d.DepartmentName
                     }).ToList();

            //------------Left Outer Join-----------//
            //In sql like querry//

            var resultinLeftOuterJoin = (from e in db.tblPersons
                                         join d in db.tbldepartments
                                         on e.DepartmentId equals d.Id
                                         into egroup
                                         from d in egroup.DefaultIfEmpty()
                                         select new Employee
                                         {
                                             Name = e.Name,
                                             Country = e.Country,
                                             DepartmentName = egroup.Select(x => x.DepartmentName).FirstOrDefault()
                                         }).ToList();

            //----------------Group Join -----//

            var resultgroup = (db.tbldepartments.GroupJoin(db.tblPersons, x => x.Id, y => y.DepartmentId, (d,e) =>
                    new
                    {
                        Department = d,
                        Employees = e                                                
                    })).ToList();

           
                           

            int[] Numbers = { 2, 3, 4, 5 };

            int result = Numbers.Aggregate((a,b)=>a*b);
            int MaxNumber = Numbers.Max();
            int MinNumber = Numbers.Min();

            double AverageofNumber = Numbers.Average();
            int SumofNumber = Numbers.Sum();
            int Count = Numbers.Count();

            Console.WriteLine(result);

            GetResult("Etam");

            string[] stringArray =
             {
              "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
              "0123456789"
             };

            var result1 =  stringArray.SelectMany(x => x);

            var result2 = (from s in stringArray
                           from c in s
                           select c).ToList();



            ViewBag.Message = "Your application description page.";
            return View();
        }


        public void GetResult(string strname)
        {
            
            strname.ConverttoUpperLetterCase();
        }

        public class FindExceptionfilter : FilterAttribute,IExceptionFilter
        {
            public void OnException(ExceptionContext filterContext)
            {

            }
        }
        [FindExceptionfilter]
        [HttpPost]
        public ActionResult Contact(Employee e)
        {
           // return PartialView("_SendEmail");

            //try
            //{
                //List<string> obj = new List<string>();
                //List<string> objj = new List<string>();
                //obj.Add("aa");
                //obj.Add("bb");

                //IEnumerable<string> list = obj;
                //objj = list.ToList();
                ////var c= obj.FindIndex(x=>x=="bb");
                //var a = obj.IndexOf("bb");
                //int x;
                //int y;
                //int Sum = 3;
                //int Mul = 4;
                //GetResult(Sum, Mul, out x, out y);

                //int[] arr = new int[5];
                //arr[12] = 12;

                //ViewBag.Message = "Your contact page.";
            //}
            //catch(Exception e)
            //{

            //}
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            // return PartialView("_SendEmail");

            //try
            //{
            //List<string> obj = new List<string>();
            //List<string> objj = new List<string>();
            //obj.Add("aa");
            //obj.Add("bb");

            //IEnumerable<string> list = obj;
            //objj = list.ToList();
            ////var c= obj.FindIndex(x=>x=="bb");
            //var a = obj.IndexOf("bb");
            //int x;
            //int y;
            //int Sum = 3;
            //int Mul = 4;
            //GetResult(Sum, Mul, out x, out y);

            //int[] arr = new int[5];
            //arr[12] = 12;

            //ViewBag.Message = "Your contact page.";
            //}
            //catch(Exception e)
            //{

            //}
            return View();
        }

        public void GetResult(int s,int m,out int c,out int d)
        {
            c = s+m;
            d = s*m;
            
        }
        [HttpPost]
        public ActionResult SendEmail()
        {
             return PartialView("_SendEmail");
        }
        //public ActionResult GetAllStickyNotes()
        //{
            
        //    return Json(listofstickynotes, JsonRequestBehavior.AllowGet);
        //}
    }
}