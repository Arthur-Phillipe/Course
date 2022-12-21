    Trabalho 2) Biblioteca/Library (ArtSoft.Talk): implementa diálogo mais fluido com o console.
 Veja exemplo abaixo:(Say, Ask, AskDate, AskDouble, AskInt). 
Substitui o Console.Write e Console.ReadLine e faz as conversões
 do string de resposta para o tipo correspondente.

for (int i=1; i<=n; i++)
            {
                Say($"\nEnter {i}º contract data: \n");
                DateTime date = AskDate("Date (DD/MM/YYY): ");
                double valuePerHour = AskDouble("Value per hour: ");
                int hours = AskInt("Duration (hours): ");
                HourContract contract = new HourContract(date, valuePerHour, hours);  
                worker.AddContract(contract);
            }