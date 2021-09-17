using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LINQDataContext;

namespace ExerciceDeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext();

            #region 2.SELECT
            /////2.1
            //var result = dc.Students.Select(s => new { s.Last_Name, s.BirthDate, s.Login, s.Year_Result });
            //var exp_request = from Student s in dc.Students
            //                  select new { s.Last_Name, s.BirthDate, s.Login, s.Year_Result };

            //foreach (var stud in result)
            //{
            //    Console.WriteLine($"{stud.Last_Name} {stud.BirthDate} {stud.Login} {stud.Year_Result}");
            //}

            //foreach (var stud in exp_request)
            //{
            //    Console.WriteLine($"{stud.Last_Name} {stud.BirthDate} {stud.Login} {stud.Year_Result}");
            //}

            /////2.2
            //var result = dc.Students.Select(s => new { NomComplet = $"{s.Last_Name} {s.First_Name}", s.Student_ID, s.BirthDate});
            //var exp_request = from Student s in dc.Students
            //                  select new { NomComplet = $"{s.Last_Name} {s.First_Name}", s.Student_ID, s.BirthDate };

            //foreach (var stud in result)
            //{
            //    Console.WriteLine($"{stud.NomComplet} {stud.BirthDate} {stud.Student_ID}");
            //}

            //foreach (var stud in exp_request)
            //{
            //    Console.WriteLine($"{stud.NomComplet} {stud.BirthDate} {stud.Student_ID}");
            //}

            /////2.3
            //IEnumerable<string> result = dc.Students.Select(s => $"{s.Student_ID}|{s.Last_Name}|{s.First_Name}|{s.BirthDate}|{s.Section_ID}|{s.Course_ID}|{s.Login}|{s.Year_Result}");
            //IEnumerable<string> exp_request = from Student s in dc.Students
            //                                  select $"{s.Student_ID}|{s.Last_Name}|{s.First_Name}|{s.BirthDate}|{s.Section_ID}|{s.Course_ID}|{s.Login}|{s.Year_Result}";

            //foreach (string stud in result)
            //{
            //    Console.WriteLine(stud);
            //}
            //foreach (string stud in exp_request)
            //{
            //    Console.WriteLine(stud);
            //}

            #endregion
            #region 3.WHERE / ORDER BY
            /////3.1
            //var result = dc.Students
            //    .Where(s => s.BirthDate.Year < 1955)
            //    .Select(s => new { s.Last_Name, s.Year_Result, Status = (s.Year_Result >= 12) ? "OK" : "KO" });

            //var exp_request = from Student s in dc.Students
            //                  where s.BirthDate.Year < 1955
            //                  select new { s.Last_Name, s.Year_Result, Status = (s.Year_Result >= 12) ? "OK" : "KO" };

            //foreach (var stud in result)
            //{
            //    Console.WriteLine($"{stud.Last_Name} {stud.Year_Result} {stud.Status}");
            //}

            //foreach (var stud in exp_request)
            //{
            //    Console.WriteLine($"{stud.Last_Name} {stud.Year_Result} {stud.Status}");
            //}

            /////3.2
            //var result = dc.Students
            //    .Where(s => s.BirthDate.Year >= 1955 && s.BirthDate.Year <= 1965)
            //    .Select(s => new { 
            //        s.Last_Name, 
            //        s.Year_Result, 
            //        Categorie = (s.Year_Result < 10) ? 
            //                            "inférieur" : 
            //                            (s.Year_Result == 10) ? 
            //                                    "neutre" : 
            //                                    "supérieur" });

            //var exp_request = from Student s in dc.Students
            //                  where s.BirthDate.Year >= 1955 && s.BirthDate.Year <= 1965
            //                  select new
            //                  {
            //                      s.Last_Name,
            //                      s.Year_Result,
            //                      Categorie = (s.Year_Result < 10) ?
            //                            "inférieur" :
            //                            (s.Year_Result == 10) ?
            //                                    "neutre" :
            //                                    "supérieur"
            //                  };

            //foreach (var stud in result)
            //{
            //    Console.WriteLine($"{stud.Last_Name} {stud.Year_Result} {stud.Categorie}");
            //}

            //foreach (var stud in exp_request)
            //{
            //    Console.WriteLine($"{stud.Last_Name} {stud.Year_Result} {stud.Categorie}");
            //}

            /////3.3
            //var result = dc.Students
            //    .Where(s => s.Last_Name.EndsWith("r")) //.Where(s => s.Last_Name.Substring(s.Last_Name.Length-1, 1) == "r")
            //    .Select(s => new { s.Last_Name, s.Section_ID });

            //var exp_request = from Student s in dc.Students
            //                  where s.Last_Name.EndsWith("r")
            //                  select new { s.Last_Name, s.Section_ID };


            //foreach (var stud in result)
            //{
            //    Console.WriteLine($"{stud.Last_Name} {stud.Section_ID}");
            //}

            //foreach (var stud in exp_request)
            //{
            //    Console.WriteLine($"{stud.Last_Name} {stud.Section_ID}");
            //}

            /////3.4
            //var result = dc.Students
            //    .Where(s => s.Year_Result <= 3)
            //    .Select(s => new { s.Last_Name, s.Year_Result })
            //    .OrderByDescending(s => s.Year_Result);

            //var exp_request = from Student s in dc.Students
            //                  where s.Year_Result <= 3
            //                  orderby s.Year_Result descending
            //                  select new { s.Last_Name, s.Year_Result };

            //foreach (var stud in result)
            //{
            //    Console.WriteLine($"{stud.Last_Name} {stud.Year_Result}");
            //}

            //foreach (var stud in exp_request)
            //{
            //    Console.WriteLine($"{stud.Last_Name} {stud.Year_Result}");
            //}

            /////3.5
            //var result = dc.Students
            //    .Where(s => s.Section_ID == 1110)
            //    .Select(s => new { NomComplet = $"{s.Last_Name} {s.First_Name}", s.Year_Result })
            //    .OrderBy(s => s.NomComplet);

            //var exp_request = from Student s in dc.Students
            //                  where s.Section_ID == 1110
            //                  orderby s.Last_Name
            //                  select new { NomComplet = $"{s.Last_Name} {s.First_Name}", s.Year_Result };

            //foreach (var stud in result)
            //{
            //    Console.WriteLine($"{stud.NomComplet} {stud.Year_Result}");
            //}


            //foreach (var stud in exp_request)
            //{
            //    Console.WriteLine($"{stud.NomComplet} {stud.Year_Result}");
            //}

            /////3.6
            //var result = dc.Students
            //    .Where(s => s.Year_Result < 12 || s.Year_Result > 18)
            //    .Where(s => s.Section_ID == 1010 || s.Section_ID == 1020)
            //    //.Where( s => (s.Year_Result < 12 || s.Year_Result > 18) && (s.Section_ID == 1010 || s.Section_ID == 1020))
            //    .OrderBy(s => s.Section_ID)
            //    .Select(s => new { s.Last_Name, s.Section_ID, s.Year_Result });

            //var exp_request = from Student s in dc.Students
            //                  where s.Year_Result < 12 || s.Year_Result > 18
            //                  where s.Section_ID == 1010 || s.Section_ID == 1020
            //                  orderby s.Section_ID
            //                  select new { s.Last_Name, s.Section_ID, s.Year_Result };

            //foreach (var stud in result)
            //{
            //    Console.WriteLine($"{stud.Last_Name} {stud.Section_ID} {stud.Year_Result}");
            //}

            //foreach (var stud in exp_request)
            //{
            //    Console.WriteLine($"{stud.Last_Name} {stud.Section_ID} {stud.Year_Result}");
            //}


            /////3.7
            var result = dc.Students
                .Where(s => s.Section_ID.ToString().StartsWith("13"))
                //.Where(s => s.Section_ID >=1300 && s.Section_ID <= 1300 )
                //.Where(s => s.Section_ID/100 == 13)
                .Select(s => new { s.Last_Name, s.Section_ID, result_100 = s.Year_Result * 5 })
                .Where(s => s.result_100 <= 60)
                .OrderByDescending(s => s.result_100);

            var exp_request = from st in (
                                  from Student s in dc.Students
                                  where s.Section_ID.ToString().StartsWith("13")
                                  select new { s.Last_Name, s.Section_ID, result_100 = s.Year_Result * 5 })
                              where st.result_100 <=60
                              orderby st.result_100 descending
                              select st;

            foreach (var stud in result)
            {
                Console.WriteLine($"{stud.Last_Name} {stud.Section_ID} {stud.result_100}");
            }

            foreach (var stud in exp_request)
            {
                Console.WriteLine($"{stud.Last_Name} {stud.Section_ID} {stud.result_100}");
            }
            #endregion

            #region Console.ReadLine()
            Console.ReadLine();
            #endregion
        }
    }
}
