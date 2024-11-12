using System;

class LifePathDecisionTree
{
    static void Main()
    {
        bool exit = false ;

        while (!exit)
        {
            try
            {
                Console.WriteLine("You are on a life journey. Make decisions that will impact your future:");
                Console.WriteLine("1. Choose education and career path");
                Console.WriteLine("2. Choose relationships");
                Console.WriteLine("3. Choose health and lifestyle");
                Console.WriteLine("4. Choose ethical and spiritual values");
                Console.WriteLine("5. End journey and view moral conclusion");
                Console.Write("Please enter your choice (1-5): ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ChooseCareer();
                        break;

                    case 2:
                        ChooseRelationships();
                        break;

                    case 3:
                        ChooseHealthLifestyle();
                        break;

                    case 4:
                        ChooseEthicsAndSpirituality();
                        break;

                    case 5:
                        exit = true;
                        Console.WriteLine("End of the journey. Every choice in life has consequences that define your character.");
                        Console.WriteLine("Moral: Thoughtful and ethical decisions can lead to happiness and fulfillment.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            Console.WriteLine();
        }
    }

    static void ChooseCareer()
    {
        try
        {
            Console.WriteLine("You face an important choice regarding education and career:");
            Console.WriteLine("1. Pursue a high-paying but stressful career");
            Console.WriteLine("2. Choose a calmer, lower-paying career");
            Console.Write("Enter your choice (1 or 2): ");

            int careerChoice = int.Parse(Console.ReadLine());

            if (careerChoice == 1)
            {
                Console.WriteLine("Result: Financial stability can bring comfort, but high stress may harm your health. Balance is key.");
            }
            else if (careerChoice == 2)
            {
                Console.WriteLine("Result: A calmer life can lead to happiness, even if it means earning less.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number (1 or 2).");
        }
    }

    static void ChooseRelationships()
    {
        try
        {
            Console.WriteLine("You are making a choice about relationships:");
            Console.WriteLine("1. Seek a committed, long-term relationship");
            Console.WriteLine("2. Choose temporary, non-committed relationships");
            Console.Write("Enter your choice (1 or 2): ");

            int relationshipChoice = int.Parse(Console.ReadLine());

            if (relationshipChoice == 1)
            {
                Console.WriteLine("Result: A committed relationship can bring stability and growth.");
            }
            else if (relationshipChoice == 2)
            {
                Console.WriteLine("Result: Temporary relationships may be exciting, but could lead to loneliness.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number (1 or 2).");
        }
    }

    static void ChooseHealthLifestyle()
    {
        try
        {
            Console.WriteLine("You are making a choice about health and lifestyle:");
            Console.WriteLine("1. Follow a healthy lifestyle with exercise");
            Console.WriteLine("2. Ignore health and choose an unhealthy lifestyle");
            Console.Write("Enter your choice (1 or 2): ");

            int healthChoice = int.Parse(Console.ReadLine());

            if (healthChoice == 1)
            {
                Console.WriteLine("Result: A healthy lifestyle gives you energy and a longer life.");
            }
            else if (healthChoice == 2)
            {
                Console.WriteLine("Result: Ignoring health may lead to serious issues in the future.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number (1 or 2).");
        }
    }

    static void ChooseEthicsAndSpirituality()
    {
        try
        {
            Console.WriteLine("You are making a choice about ethics and spirituality:");
            Console.WriteLine("1. Follow a spiritual and ethical path");
            Console.WriteLine("2. Prioritize personal gain, ignoring ethical values");
            Console.Write("Enter your choice (1 or 2): ");

            int ethicsChoice = int.Parse(Console.ReadLine());

            if (ethicsChoice == 1)
            {
                Console.WriteLine("Result: Choosing a spiritual and ethical path brings inner peace and harmony.");
            }
            else if (ethicsChoice == 2)
            {
                Console.WriteLine("Result: Ignoring ethics may lead to regret and emptiness in the long run.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number (1 or 2).");
        }
    }
}