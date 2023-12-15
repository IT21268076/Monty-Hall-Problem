public class MontyHallService
{
    public MontyHallSimulationResult SimulateGames(int totalGames, bool switchDoor)
    {
        int stayWins = 0;
        int switchWins = 0;
        Random random = new Random();

        for (int i = 0; i < totalGames; i++)
        {
            int carPosition = random.Next(3);
            int selectedDoor = random.Next(3);

            if (selectedDoor == carPosition && !switchDoor)
            {
                stayWins++;
            }
            else if (selectedDoor != carPosition && switchDoor)
            {
                switchWins++;
            }
        }

        return new MontyHallSimulationResult
        {
            TotalGames = totalGames,
            StayWins = stayWins,
            SwitchWins = switchWins
        };
    }
}
