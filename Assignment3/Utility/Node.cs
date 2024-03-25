﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility
{
    public class Node
    {
        public User user { get; set; }
        public Node Next { get; set; }

        public Node(User user)
        {
            this.user = user;
            Next = null;
        }
    }
}