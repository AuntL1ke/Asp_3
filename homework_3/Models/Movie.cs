﻿using System;
namespace homework_3.Models
{
	public class Movie
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Poster { get; set; }
		public string Director { get; set; }
		public string Style { get; set; }
        public string ShortDescription { get; set; }
		public List<Session> Sessions { get; set; }
    }
}

