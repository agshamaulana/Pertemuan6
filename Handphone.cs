using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsuletion
{
    internal class Handphone
    {
        //field
        public string hp;
        public string merk;
        protected string emei;

        //propeties
        public string Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        public string Merk
        {
            get { return merk; }
            set { merk = value; }
        }

        public string Emei
        {
            get { return emei; }
            set { emei = value; }
        }
        //method
        public void SetHandphone(string hp, string merk)
        {
            this.hp = hp;
            this.merk = merk;
            Console.WriteLine("Type Handphone : {0}", this.hp);
            Console.WriteLine("Merk Handphone : {0}", this.merk);
            Console.ReadKey();
        }
        public void SetEmei(string emei)
        {
            this.emei = emei;
            Console.WriteLine("Nomor Emei : {0}", this.emei);
            Console.ReadKey();
        }
    }
}