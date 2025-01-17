using System.Collections.Immutable;
using System.IO;

namespace TheHouseThatJackBuilt
{
    internal class Program
    {
        static public ImmutableList<string> poem = [];
        static void Main(string[] args)
        {
            var part1 = new Part1();
            part1.AddPart(poem);

            var part2 = new Part2();
            part2.AddPart(part1.poem!);

            var part3 = new Part3();
            part3.AddPart(part2.poem!);

            var part4 = new Part4();
            part4.AddPart(part3.poem!);

            var part5 = new Part5();
            part5.AddPart(part4.poem!);

            var part6 = new Part6();
            part6.AddPart(part5.poem!);

            var part7 = new Part7();
            part7.AddPart(part6.poem!);

            var part8 = new Part8();
            part8.AddPart(part7.poem!);

            var part9 = new Part9();
            part9.AddPart(part8.poem!);

            Console.WriteLine("Part1 Poem:");
            foreach (var line in part1.poem!)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();

            Console.WriteLine("Part2 poem:");
            foreach (var line in part2.poem!)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();

            Console.WriteLine("Part3 poem:");
            foreach (var line in part3.poem!)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();

            Console.WriteLine("Part4 poem:");
            foreach (var line in part4.poem!)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();

            Console.WriteLine("Part5 poem:");
            foreach (var line in part5.poem!)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();

            Console.WriteLine("Part6 poem:");
            foreach (var line in part6.poem!)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();

            Console.WriteLine("Part7 poem:");
            foreach (var line in part7.poem!)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();

            Console.WriteLine("Part8 poem:");
            foreach (var line in part8.poem!)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();

            Console.WriteLine("Part9 poem:");
            foreach (var line in part9.poem!)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();
        }
    }

    class Part1
    {
        public ImmutableList<string>? poem;
        public void AddPart(ImmutableList<string> strings)
        {
            var newStrings = ImmutableList.Create(
                "Вот дом,",
                "Который построил Джек.");
            poem = strings.AddRange(newStrings);
        }
    }
    class Part2
    {
        public ImmutableList<string>? poem;
        public void AddPart(ImmutableList<string> strings)
        {
            var newStrings = ImmutableList.Create(
                "А это пшеница,",
                "Которая в темном чулане хранится",
                "В доме,",
                "Который построил Джек.");
            poem = strings.AddRange(newStrings);
        }
    }
    class Part3
    {
        public ImmutableList<string>? poem;
        public void AddPart(ImmutableList<string> strings)
        {
            var newStrings = ImmutableList.Create(
                "А это веселая птица-синица,",
                "Которая часто ворует пшеницу,",
                "Которая в темном чулане хранится",
                "В доме,",
                "Который построил Джек.");
            poem = strings.AddRange(newStrings);
        }
    }
    class Part4
    {
        public ImmutableList<string>? poem;
        public void AddPart(ImmutableList<string> strings)
        {
            var newStrings = ImmutableList.Create(
                "Вот кот,",
                "Который пугает и ловит синицу,",
                "Которая часто ворует пшеницу,",
                "Которая в темном чулане хранится",
                "В доме,",
                "Который построил Джек.");
            poem = strings.AddRange(newStrings);
        }
    }
    class Part5
    {
        public ImmutableList<string>? poem;
        public void AddPart(ImmutableList<string> strings)
        {
            var newStrings = ImmutableList.Create(
                "Вот пес без хвоста,",
                "Который за шиворот треплет кота,",
                "Который пугает и ловит синицу,",
                "Которая часто ворует пшеницу,",
                "Которая в темном чулане хранится",
                "В доме,",
                "Который построил Джек.");
            poem = strings.AddRange(newStrings);
        }
    }
    class Part6
    {
        public ImmutableList<string>? poem;
        public void AddPart(ImmutableList<string> strings)
        {
            var newStrings = ImmutableList.Create(
                "А это корова безрогая,",
                "Лягнувшая старого пса без хвоста,",
                "Который за шиворот треплет кота,",
                "Который пугает и ловит синицу,",
                "Которая часто ворует пшеницу,",
                "Которая в темном чулане хранится",
                "В доме,",
                "Который построил Джек.");
            poem = strings.AddRange(newStrings);
        }
    }
    class Part7
    {
        public ImmutableList<string>? poem;
        public void AddPart(ImmutableList<string> strings)
        {
            var newStrings = ImmutableList.Create(
                "А это старушка, седая и строгая,",
                "Которая доит корову безрогую,",
                "Лягнувшая старого пса без хвоста,",
                "Который за шиворот треплет кота,",
                "Который пугает и ловит синицу,",
                "Которая часто ворует пшеницу,",
                "Которая в темном чулане хранится",
                "В доме,",
                "Который построил Джек.");
            poem = strings.AddRange(newStrings);
        }
    }
    class Part8
    {
        public ImmutableList<string>? poem;
        public void AddPart(ImmutableList<string> strings)
        {
            var newStrings = ImmutableList.Create(
                "А это ленивый и толстый пастух,",
                "Который бранится с коровницей строгою,",
                "Которая доит корову безрогую,",
                "Лягнувшая старого пса без хвоста,",
                "Который за шиворот треплет кота,",
                "Который пугает и ловит синицу,",
                "Которая часто ворует пшеницу,",
                "Которая в темном чулане хранится",
                "В доме,",
                "Который построил Джек.");
            poem = strings.AddRange(newStrings);
        }
    }
    class Part9
    {
        public ImmutableList<string>? poem;
        public void AddPart(ImmutableList<string> strings)
        {
            var newStrings = ImmutableList.Create(
                "Вот два петуха,",
                "Которые будят того пастуха,",
                "Который бранится с коровницей строгою,",
                "Которая доит корову безрогую,",
                "Лягнувшая старого пса без хвоста,",
                "Который за шиворот треплет кота,",
                "Который пугает и ловит синицу,",
                "Которая часто ворует пшеницу,",
                "Которая в темном чулане хранится",
                "В доме,",
                "Который построил Джек.");
            poem = strings.AddRange(newStrings);
        }
    }

}
