using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloAmsMVC.Models;

namespace HelloAmsMVC.ViewModels
{
    public class RandomMovieViewModel
    { 
        public Movie Movie { set; get; }
        public List<Customer> Customers { set; get; }
    }
}