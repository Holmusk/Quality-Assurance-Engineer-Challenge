using System;

namespace Glyco_UI_tests.Models
{
    /// <summary>
    /// This class represent User model
    /// </summary>
    public class UserModel
    {       
        public UserModel()
        {
            _username = "testchallenge" + DateTime.Now.Ticks;
            _name = _username;
            _email = _username + "@email.com";
            _password = DateTime.Now.Ticks.ToString();
            _type2confirmation = true;
            _tc_confirmation = true;

            Random rand = new Random();

            _gender = (rand.Next(100) < 50);
            _height = rand.Next(150, 200);
            _weight = rand.Next(60, 200);
            _date_of_birth = DateTime.Now.AddYears(rand.Next(-24, -18));
            _ethnicity = _ethnicities[rand.Next(0, _ethnicities.Length - 1)];
        }

        private string _name { get; set; }

        private string _username { get; set; }

        private string _email { get; set; }

        private string _password { get; set; }

        private bool _type2confirmation { get; set; }

        private bool _tc_confirmation { get; set; }

        private bool _gender { get; set; }

        private int? _height { get; set; }

        private int? _weight { get; set; }

        private DateTime _date_of_birth { get; set; }

        private string[] _ethnicities = new string[] { "Chinese", "Malay", "Indian", "Japanese", "Asian Others", "White, non-Hispanic", "African", "Latino-Hispanic", "Others"};

        private string _ethnicity { get; set; }

        public string Name
        {
            get { return _name; } 
            set { _name = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public bool Type2Confirmation
        {
            get { return _type2confirmation; }
            set { _type2confirmation = value; }
        }

        public bool TC_Confirmation
        {
            get { return _tc_confirmation; }
            set { _tc_confirmation = value; }
        }

        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public int? Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int? Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _date_of_birth; }
            set { _date_of_birth = value; }
        }

        public string Ethnicity
        {
            get { return _ethnicity; }
            set { _ethnicity = value; }
        }
    }
}
