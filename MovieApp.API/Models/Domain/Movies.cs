﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.API.Models.Domain
{
    public class Movies
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? BackdropPath { get; set; }

        public int? Budget { get; set; }

        public string? Homepage { get; set; }

        public string? ImdbId { get; set; }

        public string? OriginalLanguage { get; set; }

        public string? OriginalTitle { get; set; }

        public string? Overview { get; set; }

        public double? Popularity { get; set; }

        public string? PosterPath { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public double? Revenue { get; set; }

        public int? Runtime { get; set; }

        public string? Status { get; set; }

        public string? Tagline { get; set; }

        //foreign key

        //[ForeignKey("Genre")]
        //public int GenreId { get; set; }

        //public Genre Genre { get; set; }


    }
}
