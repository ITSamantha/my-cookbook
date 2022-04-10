using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd
{
    public class Recipe
    {
        private int id;
        private string name;//!
        private string category;//!
        private string ingredients;
        private string guide;
        private string marklike;
        private string time;//!
        private bool star;
        private string markdif;
        private byte[]  pic;
      
        public Recipe(  int id,   string category, string ingredients, string time, string guide, string marklike, string name, string markdif, bool star) {
            this.id = id;
            this.name = name;
            this.category = category;
            this.ingredients = ingredients;
            this.guide = guide;
            this.marklike = marklike;
            this.markdif = markdif;
            this.star = star;
            this.time = time;
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name;  }
            set { name = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
        public string Guide
        {
            get { return guide; }
            set { guide = value; }
        }
        public string Marklike
        {
            get { return marklike; }
            set { marklike = value;  }
        }
        public string Markdif
        {
            get { return markdif; }
            set { markdif = value; }
        }
        public bool Star
        {
            get { return star; }
            set { star = value; }
        }
        public byte[] Pic
        {
            get { return pic; }
            set { pic = value; }
        }

    }
}
