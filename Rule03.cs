using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule03()
    {
        return new RuleDto
        {
            Name = "The Ball",
            NameNl = "De Bal",
            NameFr = "Le Ballon",
            NameSvn = "Žoga",
            NameDe = "Der Ball",
            NameSrb = "Лопта",
            NameZhHk = "球",
            RuleNumber = "3",
            Questions =
            [
                new QuestionDto
                {
                    Phrase = "How many colours is the ball allowed to have?",
                    PhraseNl = "Hoeveel kleuren mag de wedstrijdbal hebben?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Колико боја може имати лопта?",
                    PhraseZhHk = "手球可有多少種顔色?",
                    QuestionNumber = "3.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "1",
                            PhraseNl = "1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "1",
                            PhraseZhHk = "1",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2",
                            PhraseNl = "2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2",
                            PhraseZhHk = "2",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "3",
                            PhraseNl = "3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "3",
                            PhraseZhHk = "3",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Unlimited",
                            PhraseNl = "zoveel men wil",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "неограничено",
                            PhraseZhHk = "無限",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "Which of the following balls must the referees select for a men’s game?",
                    PhraseNl =
                        "Welke van de volgende ballen, moet de scheidrechter kiezen voor een wedstrijd heren senioren?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Коју од наведене четири лопте треба да одаберу судије за утакмицу мушкараца?",
                    PhraseZhHk = "裁判應選用以下那一個球作為男子比賽用的球？",
                    QuestionNumber = "3.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Circumference 57cm, weight 450g",
                            PhraseNl = "Omtrek 57 cm, gewicht 450 g",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Обима 57 цм – тежине 450 грама",
                            PhraseZhHk = "圓周57厘米，重450克",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Circumference 58cm, weight 400g",
                            PhraseNl = "Omtrek 58 cm, gewicht 400 g",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Обима 58 цм – тежине 400 грама",
                            PhraseZhHk = "圓周58厘米，重400克",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Circumference 59cm, weight 425g",
                            PhraseNl = "Omtrek 59 cm, gewicht 425 g",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Обима 59 цм – тежине 425 грама",
                            PhraseZhHk = "圓周59厘米，重425克",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Circumference 60cm, weight 500g",
                            PhraseNl = "Omtrek 60 cm, gewicht 500 g",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Обима 60 цм – тежине 500 грама",
                            PhraseZhHk = "圓周60厘米，重500克",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "Which of the following balls must the referees select for at women’s game?",
                    PhraseNl =
                        "Welke van de volgende ballen, moet de scheidrechter kiezen voor een wedstrijd dames senioren?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Коју од наведене четири лопте треба да одаберу судије за утакмицу жена?",
                    PhraseZhHk = "裁判應選用以下那一個球作為女子比賽用的球？",
                    QuestionNumber = "3.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Circumference 53cm, weight 350g",
                            PhraseNl = "Omtrek 53 cm, gewicht 350 g",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Обима 53 цм – тежине 350 грама",
                            PhraseZhHk = "圓周53厘米，重350克",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Circumference 54cm, weight 300g",
                            PhraseNl = "Omtrek 54 cm, gewicht 300 g",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Обима 54 цм – тежине 300 грама",
                            PhraseZhHk = "圓周54厘米，重300克",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Circumference 55cm, weight 425g",
                            PhraseNl = "Omtrek 55 cm, gewicht 425 g",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Обима 55 цм – тежине 425 грама",
                            PhraseZhHk = "圓周55厘米，重425克",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Circumference 56cm, weight 375g",
                            PhraseNl = "Omtrek 56 cm, gewicht 375 g",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Обима 56 цм – тежине 375 грама",
                            PhraseZhHk = "圓周56厘米，重375克",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The referees have decided to bring the reserve ball into play. When should the original ball be used again?",
                    PhraseNl =
                        "De scheidsrechters hebben besloten om de reservebal in het spel te brengen. Wanneer moet de wedstrijdbal weer gebruikt worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Судије су донеле одлуку да се унесе резреврна лопта у игру. Када ће прва лопта бити поново коришћена?",
                    PhraseZhHk = "裁判決定使用備用球比賽後，何時應該再使用原來的球？",
                    QuestionNumber = "3.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "At the time of the next interruption",
                            PhraseNl = "Bij de volgende spelonderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "За време следећег прекида",
                            PhraseZhHk = "下一次比賽中斷時",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "It cannot be used again, unless it becomes impossible to continue to use the reserve ball.",
                            PhraseNl =
                                "Hij kan niet opnieuw gebruikt worden, tenzij het onmogelijk wordt om met de reservebal verder te spelen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Она не може бити поново коришћена, изузев ако је резервну лопту немогуће користити",
                            PhraseZhHk = "不再使用，除非備用球不能被繼續使用",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "When the referees find it necessary to use it again",
                            PhraseNl = "Wanneer de scheidsrechters het aangewezen vinden dat hij weer gebruikt wordt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Када судије нађу потребу за њено поновно коришћење",
                            PhraseZhHk = "裁判認為有必要再次使用時",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "If one of the teams request it",
                            PhraseNl = "Wanneer een der teams dit vraagt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Ако једна од екипа затражи њено поновно коришћење",
                            PhraseZhHk = "若其中一隊提出要求時",
                            AnswerNumber = "d"
                        }
                    ]
                }
            ]
        };
    }
}
