namespace HouseBuilding
{
    internal class House
    {
       // ProjectCountPart projectCountPart = new ProjectCountPart(basement, wall, window, door, roof);

        public ProjectCountPart ProjectCountPart { get; }
        public Team Team { get; }

        public House(ProjectCountPart projectCountPart)
        {
            ProjectCountPart = projectCountPart;
        }

        public int basement, wall, window, door, roof;


        public House(int basement, int wall, int window, int door, int roof)
        {
            this.basement = basement;
            this.wall = wall;
            this.window = window;
            this.door = door;
            this.roof = roof;
        }

        public House(Team team)
        {
            Team = team;
        }
    }
}