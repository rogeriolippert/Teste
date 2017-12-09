using System;
using Xunit;
using app;

namespace test
{
    public class EquipeTest
    {
        [Fact]
        public void TestCriaNovo()
        {   
            Equipe equipe = new Equipe("Internacional", 10);
            Assert.Equal("Internacional", equipe.nome);
            Assert.Equal(10, equipe.pontuacao);
        }
    }
}