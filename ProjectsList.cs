using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public static class ProjectsList
    {
        public static List<Project> GetPojects()
        {
			var projectList = new List<Project>
			{
				new Project
				{
					Title = "Holiday",
					Active = true,
					Description = "Day Off",
					Id = 1234,
				},
				new Project
				{
					Title = "Amazon",
					Active = true,
					Description = "Onlineshop update",
					Id = 2222,
				},
				new Project
				{
					Title = "Google",
					Active = true,
					Description = "Searchengine optimization",
					Id = 1212,
				},
				new Project
				{
					Title = "Facebook",
					Active = true,
					Description = "VR Gloves Testing",
					Id = 1254,
				},
				new Project
				{
					Title = "Tesla",
					Active = true,
					Description = "Battery optimization",
					Id = 1111,
				},
			};
			return projectList;
		}
    }
}
