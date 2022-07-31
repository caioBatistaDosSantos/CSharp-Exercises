namespace election_day
{
    public class BallotBox
    {
        private int receivedOption1;
        private int receivedOption2;
        private int receivedOption3;
        private int optionNull;
        
        public int GetCountVoters()
        {
            var numberInsert = 0;
            var convertible = false;

            do
            {
                Console.Write("O número deve ser um inteiro maior que zero");
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
                Console.Write("Informe o número do candidato de 1 a 3, ou tecle qualquer outro digito para votar nulo: ");
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

                Console.Write("Voto registrado: " + vote.ToString());
            }
            
        }

        public void PrintResult()
        {
            Console.Write("Votação finalizada!!!!");
            Console.Write("A opção 1 recebeu: " + receivedOption1 + " voto(s)");
            Console.Write("A opção 2 recebeu: " + receivedOption2 + " voto(s)");
            Console.Write("A opção 3 recebeu: " + receivedOption3 + " voto(s)");
            Console.Write("Total de votos anulados: " + optionNull + " voto(s)");
        }
    }
}
