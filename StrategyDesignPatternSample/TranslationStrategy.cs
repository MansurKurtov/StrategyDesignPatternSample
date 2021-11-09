namespace StrategyDesignPatternSample
{
    public class TranslationStrategy
    {
        private ITranslator _translator;
        public void SetTranslator(ITranslator translator)
        {
            _translator = translator;
        }

        public string TranslateToEn(string s, string lang)
        {
            return _translator.TranslateToEn(s, lang);
        }

        public string TranslateToUz(string s, string lang)
        {
            return _translator.TranslateToUz(s, lang);
        }
    }
}
