namespace OOP.Week09_S.O.L.I.D.S
{
    internal class DataPlayer
    {
        public int Health;
        public string PlayerName;
        public float PositionX;
        public float PositionY;

        public DataPlayer(int health, string playerName, float positionX, float positionY)
        {
            Health = health;
            PlayerName = playerName;
            PositionX = positionX;
            PositionY = positionY;
        }
    }
}
