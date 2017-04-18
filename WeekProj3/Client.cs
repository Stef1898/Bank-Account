using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekProj3
{
    class Client
    {
        //Fields:
        protected string name; 
        private string phone;
        private string address;

        //Default Con
        public Client()
        {
            

        }

        //Properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }


        public string Address
        {
            get { return this.address; }
            set { this.address = value;}
        }



        //Constructor

        public Client(string name, string phone, string address)
        {
            this.name = name;
            this.phone = phone;
            this.address = address;
        }


        //Methods

        public void ClientInfo()
        {
            Console.WriteLine("Your saved client information is listed as: \n");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Client: " + name + ". \n");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Phone Number: " + phone + ". \n");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Address: " + address + ". \n");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("If any of the above information is incorrect, please call Customer Service at: \n(440) 634-5789 or head to your nearest WCC-IT International Banking location \nImmediately!");
            /*Wilson Pickett 1966*/
        }







    }
}
