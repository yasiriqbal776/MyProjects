﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Neo4j.Driver.V1;
namespace TraveloSystem
{
    public partial class ShowRoutes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //    int count = 0;
            //    var driver = GraphDatabase.Driver("bolt://localhost", AuthTokens.Basic("neo4j", "neo4travelo"));
            //    var session = driver.Session();
            //    var resultinroute = session.Run("Match(R:Route) return COUNT(R)");
            //    foreach (var result in resultinroute)
            //    {
            //        count = Int32.Parse(result[0].As<string>());
            //    }
            //    int rowcount = 0;
            //    int columncount = 1;
            //    String[,] arr = new string[count, 2];

            //    var totalroute = session.Run("Match(R:Route) return R.name,R.capacity");
            //    foreach (var routecount in totalroute)
            //    {
            //        String Routename = routecount[0].As<string>();
            //        String capacity = routecount[1].As<string>();
            //        arr[rowcount, 0] = Routename;
            //        arr[rowcount, 1] = capacity;
            //        rowcount++;
            //    }
            //    DataTable dt1 = new DataTable();
            //    for (int i = 0; i < 2; i++)
            //    {
            //        dt1.Columns.Add();
            //        if (i == 0)
            //        {
            //            dt1.Columns[i].ColumnName = "Routes";
            //        }
            //        else
            //        {
            //            dt1.Columns[i].ColumnName = "Capacity";
            //        }
            //    }

            //    for (int j = 0; j < count; j++)
            //    {
            //        DataRow row1 = dt1.NewRow();
            //        for (int i = 0; i < 2; i++)
            //        {
            //            row1[i] = arr[j, i];
            //        }
            //        dt1.Rows.Add(row1);
            //    }
            //    GridView1.DataSource = dt1;
            //    GridView1.DataBind();
            //    List<String> routenames = new List<string>();
            //    List<int> rowscountlist = new List<int>();
            //    var resultset=session.Run("Match (R:Route) return R.name");
            //    foreach (var record in resultset)
            //    {
            //        routenames.Add(record[0].As<string>());
            //    }

            //    for (int i = 0; i < routenames.Count; i++)
            //    {
            //        resultset = session.Run("match(r:Route{name:'" + routenames[i] + "'})-[R:CONTAINS]->(s:Soource)-[R1:NEXT_STOP*]->(s1:Soource) return  count(s1.name)");
            //        foreach (var record in resultset)
            //        {
            //            rowscountlist.Add(Int32.Parse(record[0].As<string>())+1);
            //        }
            //    }
            //    String[,] array2d = new String[rowscountlist.Max(), routenames.Count * 2];
            //    int colcounter = 0;
            //    for (int i = 0; i < routenames.Count; i++)
            //    {
            //        resultset = session.Run("Match(r:Route{name:'" + routenames[i] + "'})-[R:CONTAINS]->(s:Soource) return s.name,s.capacity");
            //        foreach (var record in resultset)
            //        {
            //           array2d[0,colcounter]=record[0].As<string>();
            //           array2d[0, colcounter+1] = record[1].As<string>();
            //           colcounter = colcounter + 2;
            //        }
            //    }
            //    int kcounter = 0;
            //    int maincolcount = 0;
            //    for (int i = 0; i < routenames.Count; i++)
            //    {
            //        int j = 1;
            //        kcounter = j;
            //        resultset = session.Run("match(r:Route{name:'" + routenames[i] + "'})-[R:CONTAINS]->(s:Soource)-[R1:NEXT_STOP*]->(s1:Soource) return  s1.name,s1.capacity");
            //            foreach (var record in resultset)
            //            {
            //                array2d[j, maincolcount] = record[0].As<string>();
            //                array2d[j, maincolcount+1] = record[1].As<string>();
            //            j++;
            //            }
            //        j= 1;
            //        maincolcount = maincolcount + 2;
            //    }

            //    DataTable dt = new DataTable();
            //    for (int i = 0; i < routenames.Count*2; i++)
            //    {
            //        dt.Columns.Add();
            //        if (i == 0)
            //        {
            //            dt.Columns[i].ColumnName = "Route " + i;
            //        }
            //        else if (i % 2 == 0)
            //        {
            //            dt.Columns[i].ColumnName = "Route " + (i);
            //        }
            //        else
            //        {
            //            dt.Columns[i].ColumnName = "Capacity Of Route " + (i - 1);
            //        }

            //    }
            //    int iterator = 0;
            //    for (int j = 0; j < rowscountlist.Max(); j++)
            //    {
            //        DataRow row = dt.NewRow();
            //        for (int i = 0; i < rowscountlist.Count*2; i++)
            //        {
            //            row[i] = array2d[j,i];
            //        }
            //        dt.Rows.Add(row);
            //        iterator++;
            //    }
            //    GridView2.DataSource = dt;
            //    GridView2.DataBind();
            //}
        }
    }
}