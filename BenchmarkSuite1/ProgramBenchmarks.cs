using BenchmarkDotNet.Attributes;
using System;
using Microsoft.VSDiagnostics;

namespace ProjetoPrimeiro.Benchmarks
{
    [CPUUsageDiagnoser]
    public class ProgramBenchmarks
    {
        private string mensagem;
        [GlobalSetup]
        public void Setup()
        {
            mensagem = "Boas vindas ao Screen Sound!";
        }

        [Benchmark]
        public string BuildMessage()
        {
            // Mede apenas a construção / acesso da mensagem
            return mensagem;
        }

        [Benchmark]
        public void PrintMessage()
        {
            // Não é recomendado escrever no console em benchmarks reais,
            // mas incluímos para representar o comportamento atual do programa.
            Console.WriteLine(mensagem);
        }
    }
}