namespace month_name;
public class MonthNameInCalendar
{
    /// <summary>
    /// Esta função retorna o nome do mês passado como parâmetro de entrada.
    /// </summary>
    /// <param month="mes"> Um número inteiro com o mês. </param>   
    /// <returns> Nome do mês</returns>
    public static string MonthName(int month)
    {
        string monthIndicate;

        switch(month)
        {
            case 1:
                monthIndicate = "Janeiro";
                break;
            
            case 2:
                monthIndicate = "Fevereiro";
                break;
            
            case 3:
                monthIndicate = "Março";
                break;
            
            case 4:
                monthIndicate = "Abril";
                break;
            
            case 5:
                monthIndicate = "Maio";
                break;
            
            case 6:
                monthIndicate = "Junho";
                break;
            
            case 7:
                monthIndicate = "Julho";
                break;
            
            case 8:
                monthIndicate = "Agosto";
                break;

            case 9:
                monthIndicate = "Setembro";
                break;

            case 10:
                monthIndicate = "Outubro";
                break;

            case 11:
                monthIndicate = "Novembro";
                break;

            case 12:
                monthIndicate = "Dezembro";
                break;

            default:
                monthIndicate = "inválido";
                break;
        }

        return monthIndicate;
    }
}