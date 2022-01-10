namespace BattleShip
{
    class Player
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }

        public string FullName
        {
            get
            {
                return _firstName + " , " + _lastName;
            }
        }
        public int Score { get; set; } = 0;

        public Player(string firstname, string lastname, int score)
        {
            _firstName = firstname;
            _lastName = lastname;
            Score = score;
        }
    }
}
