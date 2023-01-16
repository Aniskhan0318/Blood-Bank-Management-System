using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_System
{
    internal class Class1
    {
        string Name;
        string Fname;
        int Age;
        string Bgroup;
        long Contact;
        string Address;
        string Mcondition;
        float Amount;
        public Class1(string name, string fname, int age, string bgroup, long contact, string address, string mconditon, float amount)
        {
            Name = name;
            Fname = fname;
            Age = age;
            Bgroup = bgroup;
            Contact = contact;
            Address = address;
            Mcondition = mconditon;
            Amount = amount;

        }
        public string getname()
        {
            return Name;
        }

        public string getfname()
        {
            return Fname;
        }
        public int getage()
        {
            return Age;
        }

        public string getbgroup()
        {
            return Bgroup;
        }

        public long getcontact()
        {
            return Contact;
        }
        public string getaddress()
        {
            return Address;
        }

        public string getmcondition()
        {
            return Mcondition;
        }

        public float getamount()
        {
            return Amount;
        }
    }
}
