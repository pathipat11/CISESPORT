﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISESPORT
{
    public class Player
    {
        private string name, lastname, studentID, major, displayname, mail, phone;
        private int age = 0;

        public Player(string name, string lastname, string studentID, string major, string displayname, string mail, string phone, int age)
        {
            this.name = name;
            this.lastname = lastname;
            this.studentID = studentID;
            this.major = major;
            this.displayname = displayname;
            this.mail = mail;
            this.phone = phone;
            this.age = age;
        }
        public string Name { get => name; } 
        public string Lastname { get => lastname; } 
        public string StudentID { get => studentID; } 
        public string Major { get => major; } 
        public string DisplayName { get => displayname; }
        public string Mail { get => mail; }
        public string Phone { get => phone; }
        public int Age { get => age;}
    }
}
