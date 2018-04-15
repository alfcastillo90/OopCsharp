namespace PointAndLines
{
    class User
    {
        public readonly int HEIGHT;
        public readonly int ID;

        public static int currentID;

        public Race race;

        private string username;
        private int password;

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (value.Length >= 4 && value.Length <= 10) {
                    username = value;
                }
                else
                {
                    System.Console.WriteLine("Oops!. This is not a valid username");
                }

            }
        }

        public int Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value >= 4 && value <= 10)
                {
                    password = value;
                }
                else
                {
                    System.Console.WriteLine("Oops!. This is not a valid password");
                }

            }
        }

        public User ()
        {
            currentID++;
            ID = currentID;
        }
        public User (string username, Race race)
        {
            currentID++;
            ID = currentID;
            this.username = username;
            if (race == Race.Marsian)
            {
                HEIGHT = 100;
            }
            else if( race == Race.Earthling)
            {
                HEIGHT = 180;
            }
        }
    }
}


