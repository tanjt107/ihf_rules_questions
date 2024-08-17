using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule01()
    {
        return new RuleDto
        {
            Name = "Playing Court",
            NameNl = "Speeloppervlak",
            NameFr = "L'aire de jeu",
            NameSvn = "Igrišče",
            NameDe = "Die Spielfläche",
            RuleNumber = "1",
            Questions =
            [
                new QuestionDto
                {
                    Phrase = "What are the measurements of the playing court according to the rules?",
                    PhraseNl = "Wat zijn de afmetingen van het speelveld volgens de spelregels?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    QuestionNumber = "1.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "40 x 20 metres",
                            PhraseNl = "40 m x 20 m",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "42 x 20 metres",
                            PhraseNl = "42 m x 20 m",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "38 x 18 metres",
                            PhraseNl = "38 m x 18 m",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Length between 38 and 42, width between 18 and 22 metres",
                            PhraseNl = "Lengte tussen 38 en 42 m, breedte tussen 18 en 22 m",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "What are the required interior measurements of the goal?",
                    PhraseNl = "Welke zijn de vereiste binnen afmetingen van het doel?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    QuestionNumber = "1.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "1.92 x 2.92 metres",
                            PhraseNl = "1,92 m x 2,92 m",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2.00 x 3.00 metres",
                            PhraseNl = "2,00 m x 3,00 m",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2.05 x 3.05 metres",
                            PhraseNl = "2,05 m x 3,05 m",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "2.08 x 3.08 metres",
                            PhraseNl = "2,08 m x 3,08 m",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "How wide is the goal line between the posts?",
                    PhraseNl = "Hoe breed is de doellijn tussen de doelpalen?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    QuestionNumber = "1.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "5cm",
                            PhraseNl = "5 cm",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "6cm",
                            PhraseNl = "6 cm",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "8cm",
                            PhraseNl = "8 cm",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "10cm",
                            PhraseNl = "10 cm",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "Which statements are correct about the throw-off area?",
                    PhraseNl = "Welke uitspraken zijn juist over het beginworpgebied?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    QuestionNumber = "1.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "It consists of a circle with a diameter of 3 metres.",
                            PhraseNl = "Het bestaat uit een cirkel met een diameter van 3 meter",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "It consists of a circle with a diameter of 4 metres.",
                            PhraseNl = "Het bestaat uit een cirkel met een diameter van 4 meter",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The throw-off area can be an area with a different colour than the playing court.",
                            PhraseNl = "Het beginworpgebied kan een gebied zijn met een andere kleur dan het speelveld",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The throw-off area can be a circle line.",
                            PhraseNl = "Het beginworpgebied kan een cirkellijn zijn",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The throw-off area is mandatory for all events in handball.",
                            PhraseNl = "Het beginworpgebied is verplicht voor alle evenementen in handbal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "e"
                        }
                    ]
                }
            ]
        };
    }
}