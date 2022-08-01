namespace election_day
{
    public class BallotBox
    {
        public int receivedOption1;
        public int receivedOption2;
        public int receivedOption3;
        public int optionNull;
        
        public int GetCountVoters()
        {
            var numberInsert = 0;
            var convertible = false;

            do
            {
                Console.Write("\r\nO número deve ser um inteiro maior que zero\r\n");
                var response = Console.ReadLine();
                convertible = int.TryParse(response, out numberInsert);

            }
            while(!convertible);

            if (numberInsert <= 0) return 1;
            return numberInsert;
        }

        public void Start(int countVoters)
        {
            for (var i = 0; i < countVoters; i++)
            {
                Console.Write("\r\nInforme o número do candidato de 1 a 3, ou tecle qualquer outro digito para votar nulo: ");
                var vote = GetCountVoters();

                switch (vote)
                {
                    case 1:
                        receivedOption1 ++;
                        break;
                    case 2:
                        receivedOption2 ++;
                        break;
                    case 3:
                        receivedOption3 ++;
                        break;
                    default:
                        optionNull ++;
                        break;
                }

                Console.Write($"\r\nVoto registrado: {vote}\r\n");
            }
            
        }

        public void PrintResult()
        {
            Console.WriteLine($"\r\nVotação finalizada!!!!\r\n");

            int[] options = { receivedOption1, receivedOption2, receivedOption3 };

            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"A opção {i + 1} recebeu: {options[i]} voto(s)\r\n");
            }
            Console.WriteLine($"Total de votos anulados: {optionNull} voto(s)");
        }
    }
}
