namespace StrategyDesignPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var translationStrategy = new TranslationStrategy();
            translationStrategy.SetTranslator(new GoogleTranslator());
            translationStrategy.TranslateToUz("test", "en");
            translationStrategy.TranslateToEn("test", "uz");

            translationStrategy.SetTranslator(new CambridgeTranslator());
            translationStrategy.TranslateToUz("test", "en");
            translationStrategy.TranslateToEn("test", "uz");
        }
    }
}
