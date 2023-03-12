/**
 * Sok Kim Thanh 7:30 PM 12/03/2023
 * Chuong trinh thu nghiem bai tap lap trinh huong doi tuong
 * Cai dat class Author
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT2_TAODOITUONG.src.Author
{
    internal class Author
    {
        private string name;
        private string email;
        private char gender;

        ~Author() { }

        public Author()
        {
            name = string.Empty;
            email = string.Empty;
            gender = 'u';
        }
        public Author(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }

        public string Name { get => name; set => name = value; }
        public string Email
        {
            get => email;

            set
            {
                email = value;
                if (!email.Contains('@'))
                {
                    email = "-1";
                }
            }
        }
        public char Gender
        {
            get => gender;
            set
            {
                gender = value;
                if (gender.ToString() != "f" || gender.ToString() != "m" || gender.ToString() != "u")
                {
                    gender = 'u';
                }
            }
        }
        public string getName()
        {
            return this.Name;
        }

        public string getEmail()
        {
            return this.Email;
        }
        public void setEmail(string email)
        {
            this.Email = email;
        }
        public char getGender()
        {
            return this.Gender;
        }
        public void Print()
        {
            string genderString = this.gender == 'f' ? "female" : this.gender == 'm' ? "male" : "unknow";
            Console.WriteLine($"{name}({genderString}) at {email}");
        }

        public void Nhap()
        {

            // Nhap ten tac gia
            do
            {
                Console.Write("Vui long nhap ten: ");
                this.name = Console.ReadLine();
            } while (this.name == null);
            // nhap email
            do
            {
                Console.Write("Vui long nhap email: ");
                this.setEmail(Console.ReadLine());
            } while (this.email == "-1");
            // nhap gender
            bool check = false;
            char gender;
            do
            {
                Console.Write("Vui long nhap gender: ");
                check = char.TryParse(Console.ReadLine(), out gender);
                this.Gender = gender;
            } while (this.gender.ToString().Length <= 0 || this.gender.ToString().Length > 1);

        }
    }
}
