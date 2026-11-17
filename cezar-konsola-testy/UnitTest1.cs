namespace cezar_konsola_testy
{
    public class UnitTest1
    {
        [Fact]
        public void SzyfrujProstyTekst()
        {
            string wynik = Program.SzyfrCezara("abc", 3);
            Assert.Equal("def", wynik);
        }

        [Fact]
        public void SzyfrujTekstZPrzekroczeniemZ()
        {
            string wynik = Program.SzyfrCezara("xyz", 3);
            Assert.Equal("abc", wynik);
        }
    }
}
