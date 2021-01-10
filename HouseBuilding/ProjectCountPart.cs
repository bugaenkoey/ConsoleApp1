namespace HouseBuilding
{
    struct ProjectCountPart
    {
       public int basement, wall, window, door, roof;

        public ProjectCountPart(int basement, int wall, int window, int door, int roof)
        {
            this.basement = basement;
            this.wall = wall;
            this.window = window;
            this.door = door;
            this.roof = roof;
        }
    }
}
