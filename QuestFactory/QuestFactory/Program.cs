using System;

namespace QuestFactory
{
    class Program
    {
        public enum QuestType
        {
            GoblinDungeon,
            WarriorTavern,
            Garden
        }

        public static class QuestFactory
        {
            public static Quest CreateQuest(QuestType questType)
            {
                switch (questType)
                {
                    // -- Here are the if statements to replace with a switch statement --
                    case QuestType.GoblinDungeon:
                        return new Quest("Goblin Dungeon", "A dungeon full of goblins.. Please help us traveler!");
                        break;
                    case QuestType.Garden:
                        return new Quest("Rose Garden", "The roses are wonderful.. but smelling them will change your fate..");
                        break;
                    case QuestType.WarriorTavern:
                        return new Quest("Warrior's Tarvern", "A warrior who owns a tarvern has reached out to you. Visit him.");
                        break;
                    default:
                        Console.WriteLine("No Quest found for type " + questType);
                        return null;
                        break;
                }
            }
        }

        public class Quest
        {
            public string Title
            {
                get; private set;
            }

            public string Description
            {
                get; private set;
            }

            public Quest(string title, string description)
            {
                Title = title;
                Description = description;
            }
        }
    }
}
