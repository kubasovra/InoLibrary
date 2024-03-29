﻿using InoLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace InoLibrary.ViewModels
{
    public class CreatePublicationViewModel
    {
        [Required(ErrorMessage ="Название не может быть пустым")]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Аннотация не может быть пустой")]
        [Display(Name = "Аннотация")]
        public string Annotation { get; set; }

        [Required(ErrorMessage = "Укажите год издания")]
        [Display(Name = "Год издания")]
        public int PublishingYear { get; set; }

        [Required(ErrorMessage = "Укажите рубрики")]
        [Display(Name = "Выберите рубрики")]
        public List<string> Categories { get; set; }

        [Required(ErrorMessage = "Выберите файл")]
        public IFormFile File { get; set; }
        public string FilePath { get; set; }
    }
}
