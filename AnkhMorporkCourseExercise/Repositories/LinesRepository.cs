namespace AnkhMorporkCourseExercise.Repositories
{
    class LinesRepository
    {
        public string AssassinsStartLine = $"{new string('-', 15)}\n You're in a Shades. It is pretty easy to get into a trouble in here.\n" +
                                            " Someone will definitely kill you.\n" +
                                           $" But you can create a contract with the Assassins to protect yourself.\n{new string('-', 15)}";

        public string AssassinsEndLine = " You're on your own now.";

        public string ThievesStartLine = $"{new string('-', 15)}\n Out of nowhere you feel a piece of cold, sharp steel pressed firmly against your back and hear a voice,\n" +
                                         " just as cold, demanding to choose between a little payment and your life.\n" +
                                         $" You can give away some money or give up.\n{new string('-', 15)}";

        public string ThievesEndLine = " Even though you decided on resisting, there's little you could do against a dagger. Oops.";

        public string BeggarsStartLine = $"{new string('-', 15)}\n Suddenly, you feel a rough pat on your shoulder. You turn around to see a beggar, a plea in his eyes.\n" +
                                         $" You can give an Alm or try to ignore him.\n{new string('-', 15)}";

        public string BeggarsEndLine = " Your attempt to leave was fruitless - no matter what you do you cant escape the feel of constant chase." +
                                       " Your hindered sanity has eventually led you to your impending doom and slow, inevitable death. Sucks to be you.";

        public string FoolsStartLine = $"{new string('-', 15)}\n While walking down the street, you sight a fool rapidly approaching you, offering you an ordeal.\n" +
                                       $" You can earn some money by replacing him for today or skip it.\n{new string('-', 15)}";

        public string FoolsEndLine = " After giving it some thought, you decided on declining his generous offer.";
    }
}
