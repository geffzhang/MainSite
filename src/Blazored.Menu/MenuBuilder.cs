﻿using Microsoft.AspNetCore.Components.Routing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blazored.Menu
{
	public class MenuBuilder
	{
		private List<MenuItem> _menuItems;

		public MenuBuilder()
		{
			_menuItems = new List<MenuItem>();
		}
		public MenuBuilder(List<MenuItem> menuItems)
		{
			_menuItems = menuItems;
		}
		public List<MenuItem> MenuItems { get { return _menuItems; }}

    public List<MenuItem> Build()
    {
        var menuItems = _menuItems.OrderBy(q => q.Position);
        return _menuItems.ToList();
		}
  }

  public class MenuItem
  {
		public int Position { get; set; }
		public string Link { get; set; }
		public string Title { get; set; }
		public NavLinkMatch Match { get; set; } = NavLinkMatch.Prefix;
		public List<MenuItem> MenuItems { get; set; }
		public string MatchLink { get; set; }

		public MenuItem Clone() {
			return new MenuItem {
				Position = this.Position,
				Link = this.Link,
				Title = this.Title,
				Match = this.Match,
				MenuItems = this.MenuItems,
				MatchLink = this.MatchLink
			};
		}

	}
	
}
