using GuessNumberGame;
RandomGenerator randomGenerator = new RandomGenerator(new Random());
Game game = new(randomGenerator);



var reuslt = game.Play();
Game.PrintResultMessage(reuslt);

Console.ReadLine();