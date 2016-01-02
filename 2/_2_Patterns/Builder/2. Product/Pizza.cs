﻿using Builder.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product
{
    class Pizza
    {
        public Flour WheatFlour { get; set; }

        public Flour RyeFlour { get; set; }

        public Salt Salt { get; set; }

        public Additives Additives { get; set; }

        public Cheese Cheese { get; set; }

        public Meat Meat { get; set; }

        public Mushroom Mushroom { get; set; }

        public Seafood Seafood { get; set; }

        public Tomato Tomato { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (WheatFlour != null)
            {
                sb.Append("Wheat flour used " + WheatFlour.Sort + "\n");
            }
            if (RyeFlour != null)
            {
                sb.Append("Rye Flour used " + RyeFlour.Sort + "\n");
            }
            if (Salt != null)
            {
                sb.Append("Salt \n");
            }
            if (Additives != null)
            {
                sb.Append("Additives : " + Additives.Name + "\n");
            }

            if (Cheese != null)
            {
                sb.Append("Cheese : " + Cheese.Name + "\n");
            }
            if (Meat != null)
            {
                sb.Append("Meat : " + Meat.Name + "\n");
            }
            if (Mushroom != null)
            {
                sb.Append("Mushroom : " + Mushroom.Name + "\n");
            }
            if (Seafood != null)
            {
                sb.Append("Seafood : " + Seafood.Name + "\n");
            }
            if (Tomato != null)
            {
                sb.Append("Tomato \n");
            }

            return sb.ToString();
        }
    }
}
