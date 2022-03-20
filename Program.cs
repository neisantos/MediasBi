


 class Program
    {
        static void Main(string[] args)
        {
           int qtdAlunos;

           Console.WriteLine("Calcular Média Bimestral");
           Console.Write("Digite o número de alunos da turma: ");
           qtdAlunos = int.Parse(Console.ReadLine());

           Console.WriteLine("Primeiro Bimestre");
           var notasPrimBim = PreecherVetor(qtdAlunos);

           Console.WriteLine("Segundo Bimestre");
           var notasSegBim = PreecherVetor(qtdAlunos);

            Console.WriteLine("Terceiro Bimestre");
           var notasTerBim = PreecherVetor(qtdAlunos);

            Console.WriteLine("Quarto Bimestre");
           var notasQuartBim = PreecherVetor(qtdAlunos);

           ImprimirNotas(notasPrimBim);
           ImprimirNotas(notasSegBim);
           ImprimirNotas(notasTerBim);
           ImprimirNotas(notasQuartBim);
           ImprimirMedias(notasPrimBim, notasSegBim, notasTerBim, notasQuartBim);
           
        }

        static float[] PreecherVetor(int qtd)
        {
            float[] vetNotas = new float[qtd];

            for(int i = 0; i < vetNotas.Length; i++)
            {
                Console.Write($"Digite a nota do {i+1}º aluno: ");
                vetNotas[i] = float.Parse(Console.ReadLine());
            }

            return vetNotas;
        }

        static void ImprimirNotas(float[] vetNotas)
        {
            for(int i = 0; i < vetNotas.Length; i++)
            {
                Console.Write($" {vetNotas[i]} |");
            }
            Console.WriteLine();
        }

        static void ImprimirMedias(float[] notasPrimBim, float[] notasSegBim, float []notasTerBim, float[] notasQuartBim)
        {

        }

    }

