using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule08()
    {
        return new RuleDto
        {
            Name = "Fouls and Unsportsmanlike Conduct",
            NameNl = "Overtredingen en Onsportief Gedrag",
            NameFr = "Irrégularités et Comportements Antisportifs",
            NameSvn = "Prekrški In Nešportno Obnašanje",
            NameDe = "Regelwidrigkeiten und unsportliches Verhalten",
            NameSrb = "Прекршаји и неспортско понашање",
            NameZhHk = "犯規及不君子行為",
            RuleNumber = "8",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "During a counter-attack by WHITE team, BLACK 7 enters the court as an additional player and holds WHITE 5 in such a way that the clear chance of scoring is spoiled. Correct decision?",
                    PhraseNl =
                        "Tijdens een tegenaanval van team WIT loopt ZWART7 als bijkomende speler het veld op en klemt WIT5 zodanig dat de duidelijke doelkans verdwijnt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "За време контранапада БЕЛЕ екипе, ЦРНИ 7 улази на терен као прекобројни играч, хвата БЕЛОГ 5 и тако спречи јасну ситуацију за постизање гола. Исправна одлука?",
                    PhraseZhHk = "在白隊的一次反擊中，黑隊7號作爲額外球員進入場內，他抱住白隊5號而破壞了一次明顯的得分機會。如何判決？",
                    QuestionNumber = "8.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 7",
                            PhraseNl = "2-minuten uitsluiting voor ZWART7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против ЦРНОГ 7",
                            PhraseZhHk = "黑隊7號退場兩分鐘",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 7 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor ZWART7 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација ЦРНОГ 7 без писане пријаве (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消黑隊7號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 7 with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor ZWART7 met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација ЦРНОГ 7 са писаном пријавом (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消黑隊7號比賽資格及作出書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw",
                            PhraseNl = "Vrije worp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање",
                            PhraseZhHk = "自由球",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw",
                            PhraseNl = "7-meter worp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац",
                            AnswerNumber = "e",
                            PhraseZhHk = "七米球",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 8, who is not included in the score sheet, arrives late and runs straight from the locker room onto the court. He spoils a clear chance of scoring when pushing the jump-shooting player WHITE 6, so that he loses body control. Correct decision?",
                    PhraseNl =
                        "ZWART8 die niet op het wedstrijdformulier staat, komt te laat en loopt uit de kleedkamer direct het speelveld op. Hij verhindert een duidelijke doelkans, doordat hij de in sprong zijnde speler WIT6 zo duwt, dat deze de controle over zijn lichaam verliest. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНИ 8, који није унесен у записник утакмице, стиже касније и право из свлачионице утрчава на терен. Он спречи јасну ситуацију за постизање гола, гурајући у леђа БЕЛОГ 6, који је био у скок-шуту, тако да БЕЛИ 6 изгуби контролу над телом. Исправна одлука?",
                    PhraseZhHk = "黑隊8號遲到，亦沒有在記錄表上登記，他從更衣室直接跑進場內，從後推一名正跳起在射門的白隊球員，導致他失去平衡，並破壞其明顯得分機會。如何判決？",
                    QuestionNumber = "8.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 8 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART8 zonder schriftelijk verslag (rode kaart getoond door de \nscheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација ЦРНОГ 8 без писане пријаве (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消黑隊8號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 8 with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART8 met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација ЦРНОГ 8 са писаном пријавом (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消黑隊8號比賽資格及作出書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against the responsible team official of BLACK team",
                            PhraseNl =
                                "Progressieve bestraffing voor de verantwoordelijke team official van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против одговорног представника ЦРНЕ екипе",
                            PhraseZhHk = "漸進處罰黑隊“球隊職員代表”",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "On the way to the changing rooms (during the half-time break) team official B from WHITE team complains to the referees in an unsportsmanlike way. Team official A from WHITE team has already received a warning during the first half of the game. Correct decision?",
                    PhraseNl =
                        "Op weg naar de kleedkamers (tijdens de pauze) protesteert team official B van team WIT bij de scheidsrechters op een onsportieve wijze. Tijdens de eerste helft van de wedstrijd kreeg team official A van team WIT reeds een waarschuwing. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "На путу у свлачионицу за време паузе између два полувремена, званичник Б БЕЛЕ екипе приговара судијама на неспортски начин. Званичник А БЕЛЕ екипе је већ кажњен опоменом за време првог полувремена. Исправна одлука?",
                    PhraseZhHk = "半場休息，球隊返回更衣室途中，白隊球隊職員B向裁判抗議。白隊球隊職員A在上半場已被警告。如何判决？",
                    QuestionNumber = "8.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for team official B from WHITE team",
                            PhraseNl = "2-minuten uitsluiting voor team official B van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за званичника Б БЕЛЕ екипе",
                            PhraseZhHk = "白隊球隊職員B退場兩分鐘",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of team official B from WHITE team (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van team official B van team WIT (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација званичника Б БЕЛЕ екипе (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消白隊球隊職員B比賽資格（裁判出示紅牌）",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team begins the second half reduced by 1 player for 2 minutes.",
                            PhraseNl = "Team WIT begint de 2e speelhelft met een speler minder gedurende 2 minuten.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "БЕЛА екипа почиње друго полувреме са једним играчем мање у пољу за игру на 2 минута",
                            PhraseZhHk = "白隊下半場首兩分鐘減少一名場內球員",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "No punishment possible, but written report",
                            PhraseNl = "Geen bestraffing mogelijk, maar een schriftelijk verslag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Ниједна казна није могућа; Писани извештај",
                            PhraseZhHk = "不用判罰，但作出書面報告",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 6 has already been penalised twice with a 2-minute suspension. Now, WHITE 6 commits a faulty substitution. What is the decision, if he is also guilty of extremely unsportsmanlike conduct after the referees have informed him about the faulty substitution?",
                    PhraseNl =
                        "WIT6 werd reeds tweemaal voor 2 minuten uitgesloten. Nu begaat WIT6 een wisselfout. Hoe moet beslist worden, wanneer hij zich daarbij nog schuldig maakt aan extreem grof onsportief gedrag nadat de scheidsrechters hem geïnformeerd hebben over zijn wisselfout?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 6 је већ два пута био кажњен са 2 минута искључења. Сада БЕЛИ 6 прави погрешну замену. Која је исправна одлука, ако се он екстремно неспортски понаша, после судијске одлуке о погрешној замени?",
                    PhraseZhHk = "白隊6號已被判退場兩次，現在白隊6號第二次替補犯規。在裁判判罰白隊6號替補犯規後，白隊6號又隨即犯上嚴重不君子行為，如何判決?",
                    QuestionNumber = "8.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 6",
                            PhraseNl = "2-minuten uitsluiting voor WIT6",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 6",
                            PhraseZhHk = "白隊6號退場兩分鐘",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 6 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van WIT6 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација БЕЛОГ 6 без писане извештај (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消白隊6號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 6 with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van WIT6 met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација БЕЛОГ 6 са писаним извештајем (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消白隊6號比賽資格及作出書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team reduced by 1 player on the court for 2 minutes",
                            PhraseNl = "Team WIT speelt gedurende 2 minuten met één speler minder",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛА екипа ће бити редукована за једног играча у пољу за игру на 2 минута",
                            PhraseZhHk = "白隊減少一名球員比賽兩分鐘",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team reduced by 2 players on the court for 2 minutes",
                            PhraseNl = "Team WIT speelt gedurende 2 minuten met twee spelers minder",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛА екипа ће бити редукована за два играча у пољу за игру на 2 минута",
                            PhraseZhHk = "白隊減少兩名球員比賽兩分鐘",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team reduced by 1 player on the court for 4 minutes",
                            PhraseNl = "Team WIT speelt gedurende 4 minuten met één speler minder",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛА екипа ће бити редукована за једног играча у пољу за игру на 4 минута",
                            PhraseZhHk = "白隊減少一名球員比賽四分鐘",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 2 is suspended for 2 minutes, but official A sends him back onto the court after 1 minute. Before the timekeeper’s whistle WHITE 2 has already destroyed a clear chance of scoring for BLACK team. Correct decision?",
                    PhraseNl =
                        "WIT2 is uitgesloten voor 2 minuten, maar wordt al na 1 minuut door official A van team WIT terug het veld opgestuurd. Vooraleer de tijdwaarnemer fluit, heeft WIT2 een duidelijke doelkans voor team ZWART vernietigd. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 2 је искључен на 2 минута, али званичник А БЕЛЕ екипе га пошаље натраг у поље за игру након једног минута. Пре него што се огласи мерилац времена, БЕЛИ 2 спречава јасну прилику за постизање гола ЦРНЕ екипе. Исправна одлука?",
                    PhraseZhHk = "白隊2號被罰退場兩分鐘，一分鐘後白隊教練A指派白隊2號進場比賽，在計時員鳴哨前，白隊2號已經破壞了黑隊的明顯得分機會。如何判決？",
                    QuestionNumber = "8.5",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team and additional suspension for WHITE 2",
                            PhraseNl = "Vrije worp voor team ZWART en bijkomende uitsluiting voor WIT2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу и додатна временска казна за играча БЕЛОГ 2",
                            PhraseZhHk = "黑隊自由球，白隊2號再加罰退場兩分鐘",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "7-metre throw for BLACK team, additional suspension for WHITE 2, and further reduction of WHITE team for the remainder of WHITE 2’s suspension time",
                            PhraseNl =
                                "7m-worp voor team ZWART, bijkomende uitsluiting voor WIT2 en verder reduceren van team WIT voor de resterende uitsluitingstijd van WIT2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Седмерац за ЦРНУ екипу и додатна временска казна за БЕЛОГ 2 и БЕЛА екипа се даље редукује за остатак временске казне БЕЛОГ 2",
                            PhraseZhHk = "黑隊七米球，A2再加罰退場兩分鐘，由“另一球員”替白隊2號罰剩餘時間",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "7-metre throw, disqualification of WHITE 2 without written report, and further reduction of WHITE team for the remainder of WHITE 2’s suspension time (red card shown by the referees)",
                            PhraseNl =
                                "7m-worp, diskwalificatie van WIT2 zonder schriftelijk verslag en verder reduceren van team WIT voor de resterende uitsluitingstijd van WIT2 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Седмерац, дисквалификација БЕЛОГ 2 и БЕЛА екипа се даље редукује за остатак временске казне БЕЛОГ 2 (црвени картон показан од стране судија)",
                            PhraseZhHk = "黑隊七米球，取消白隊2號比賽資格，由“另一球員”替白隊2號罰剩餘時間（裁判出示紅牌）",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "7-metre throw, disqualification of WHITE 2, and further reduction of WHITE team for the remainder of WHITE 2’s suspension time; written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "7m-worp, diskwalificatie van WIT2 en verder reduceren van team WIT voor de resterende uitsluitingstijd van WIT2; schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Седмерац, дисквалификација БЕЛОГ 2 и екипа А се даље редукује за остатак временске казне БЕЛОГ2; писани извештај (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "黑隊七米球，取消白隊2號比賽資格，由“另一球員”替白隊2號罰剩餘時間，及作出書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "During the attack of WHITE team, pivot WHITE 7, who is not in possession of the ball, blocks BLACK 4 with his trunk. Correct decision?",
                    PhraseNl =
                        "Tijdens een aanval van team WIT, blokt WIT7, die niet in balbezit is, ZWART4 met de romp. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "За време напада БЕЛЕ екипе пивот БЕЛИ 7, који нема лопту у поседу, блокира ЦРНОГ 4 својим телом. Исправна одлука?",
                    PhraseZhHk = "白隊隊進攻，白隊中鋒球員7號沒有持球下以軀幹阻擋黑隊4號。如何判決？",
                    QuestionNumber = "8.6",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against WHITE 7",
                            PhraseNl = "Progressieve bestraffing tegen WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против БЕЛОГ 7",
                            PhraseZhHk = "漸進處罰白隊7號",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Het spel gaat verder zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
                            PhraseZhHk = "比賽繼續",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Wing player WHITE 4 has a clear chance of scoring. BLACK 7 tries to play the ball out of his hand, but he only hits his forearm. The ball misses the goal. Correct decision?",
                    PhraseNl =
                        "Buitenspeler WIT4 komt tot een duidelijke scorekans. ZWART7 probeert de bal uit zijn hand te spelen, maar raakt alleen zijn onderarm, De bal gaat aan het doel voorbij. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Крило БЕЛИ 4 има јасну ситуацију за постизање гола. ЦРНИ 7 покушава да одузме лопту из његове руке, али га удари по подлактици. Лопта промаши гол. Исправна одлука?",
                    PhraseZhHk = "白隊翼位4號有明顯得分機會，就在這一刻，黑隊7號想打走白隊4號手中的球，但只碰到他的前臂，球沒有射入。如何判決？",
                    QuestionNumber = "8.7",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 7",
                            PhraseNl = "2-minuten uitsluiting voor ZWART7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против ЦРНОГ 7",
                            PhraseZhHk = "黑隊7號退場兩分鐘",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 7",
                            PhraseNl = "Waarschuwing voor ZWART7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за ЦРНОГ 7",
                            PhraseZhHk = "警告黑隊7號",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "No progressive punishment for BLACK 7",
                            PhraseNl = "Geen progressieve bestraffing voor ZWART7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Нема прогресивне казне против ЦРНОГ 7",
                            PhraseZhHk = "不用處罰黑隊7號",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 6 is in a counter-attack, goalkeeper BLACK 12 leaves his goal area to gain possession of the ball, but collides with WHITE 6. However, a defender might have stopped WHITE 6 by using legal means. Correct decision?",
                    PhraseNl =
                        "WIT6 loopt in tegenaanval. Doelman ZWART12 verlaat zijn doelgebied, om in balbezit te komen, maar komt in botsing met WIT6. Maar mogelijk had echter een verdedigende speler WIT6 nog op correcte wijze kunnen afstoppen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 6 је у контранападу, голман ЦРНИ 12 напусти голманов простор да би освојио лопту, али се судари са БЕЛИМ 6. Међутим, одбрамбени играч ЦРНЕ екипе је могао да заустави БЕЛОГ 6 на исправан начин. Исправна одлука?",
                    PhraseZhHk = "白隊6號發動快攻反擊，黑隊守門員12號離開禁區並取得控球，但因此與白隊6號發生碰撞。此時，有一防守球員所在位置應能合法阻止其進攻。如何判決？",
                    QuestionNumber = "8.8",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 12",
                            PhraseNl = "2-minuten uitsluiting voor ZWART12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против ЦРНОГ 12",
                            PhraseZhHk = "黑隊12號退場兩分鐘",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 12 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie ZWART12 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација ЦРНОГ 12 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消黑隊12號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification for BLACK 12, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor ZWART12, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација ЦРНОГ 12 са писаним извештајем (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消黑隊12號比賽資格及作出書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 2 wants to pass the ball to a teammate into the other half of the court, but his teammate is held by BLACK 5. BLACK 5 has already received a warning for running into an opponent, who did not have the ball. Correct decision?",
                    PhraseNl =
                        "WIT2 wil een medespeler op de andere speelhelft aanspelen, maar deze wordt door ZWART5 vastgehouden. ZWART5 had voordien reeds een waarschuwing gekregen voor het aanlopen van een tegenspeler die niet in balbezit was. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 2 жели да дода лопту саиграчу на другој половини терена, али му саиграча држи ЦРНИ 5. ЦРНИ 5 већ има опомену, након што је натрчао на противника без лопте. Исправна одлука?",
                    PhraseZhHk = "白隊2號想傳球給前場的隊友，但其隊友被黑隊5號挾制。在此之前，黑隊5號因衝向沒有持球球員已被警告。如何判決？",
                    QuestionNumber = "8.9",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 5",
                            PhraseNl = "2-minuten uitsluiting voor ZWART5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против ЦРНОГ 5",
                            PhraseZhHk = "黑隊5號退場兩分鐘",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 5 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van ZWART5 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација ЦРНОГ 5 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消黑隊5號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Written report (blue card shown by the referees)",
                            PhraseNl = "Schriftelijk verslag (blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Писани извештај (плави картон показан од стране судија)",
                            PhraseZhHk = "提交書面報告（裁判出示藍牌）",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The ball is played to pivot WHITE 9, who is standing alone at the goal-area line of BLACK team. His throwing arm is then pulled back by BLACK 2. Correct decision?",
                    PhraseNl =
                        "De bal wordt naar de cirkelspeler WIT9 gespeeld, die alleen staat aan de doelgebiedlijn van team ZWART. Zijn werparm wordt dan naar achter getrokken door ZWART2. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Лопта долази до пивотмена БЕЛОГ 9 који сам стоји испред линије голмановог простора. За шутерску руку га повлачи отпозади ЦРНИ 2. Исправна одлука?",
                    PhraseZhHk = "無人防守的白隊進攻球員9號在禁區前接到球後，黑隊2號從後拉住他的投擲臂。如何判決？",
                    QuestionNumber = "8.10",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 2",
                            PhraseNl = "2-minuten uitsluiting voor ZWART2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључење против ЦРНОГ 2",
                            PhraseZhHk = "黑隊2號退場兩分鐘",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 2 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor ZWART2 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација ЦРНОГ 2 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消黑隊2號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Written report (blue card shown by the referees)",
                            PhraseNl =
                                "Schriftelijk rapport voor ZWART2 (blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Писани извештај (плави картон показан од стране судија)",
                            PhraseZhHk = "提交書面報告（裁判出示藍牌）",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Shortly after BLACK 9 has received a warning for pushing in the first minute of the game, BLACK 7 holds the pivot of WHITE team. There is no clear chance of scoring. Correct decision?",
                    PhraseNl =
                        "Kort nadat ZWART7 wegens duwen mondeling vermaand werd in de eerste minuut van de wedstrijd, omklemt ZWART7 de cirkelspeler van team WIT (er is geen duidelijke scorekans). Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Убрзо након што је БЕЛИ 9 опоменут због гурања у првом минуту утакмице, ЦРНИ 7 држи пивота БЕЛЕ екипе (није јасна ситуација за постизање гола). Исправна одлука?",
                    PhraseZhHk = "比賽開始一分鐘，黑隊9號因推人被警告。隨後黑隊7號挾制住白隊的中鋒球員 (該球員並無明顯得分機會)。如何判決？",
                    QuestionNumber = "8.11",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 7",
                            PhraseNl = "Waarschuwing voor ZWART7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за ЦРНОГ 7",
                            PhraseZhHk = "警告黑隊7號",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 7",
                            PhraseNl = "2-minuten uitsluiting voor ZWART7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења ЦРНОГ 7",
                            PhraseZhHk = "黑隊7號退場兩分鐘",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 4 receives the ball standing at the opponents’ goal-area line with only the goalkeeper in front of him. Before WHITE 4 tries to score, BLACK 3 pulls him down in a way that WHITE 4 loses the ball. Correct decision?",
                    PhraseNl =
                        "WIT4, krijgt de bal aan het doelgebied van de tegenstrever met enkel de doelman nog voor zich. Vooraleer WIT4 probeert te scoren, trekt ZWART3 hem neer zodat WIT4 de bal verliest. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 4 добије лопту код голмановог простора противника и испред њега је само голман. Пре него што БЕЛИ 4 покуша да постигне гол, ЦРНИ 7 га повуче за дрес са леђа и обори га, након чега БЕЛИ 4 губи лопту. Исправна одлука?",
                    PhraseZhHk = "白隊4號在對方禁區前接了球，準備射門時，黑隊3號將他拉倒，白隊4號亦因此失去了球。如何判決？",
                    QuestionNumber = "8.12",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 3",
                            PhraseNl = "Waarschuwing voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за ЦРНОГ 3",
                            PhraseZhHk = "警告黑隊3號",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 3",
                            PhraseNl = "2-minuten uitsluiting voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против ЦРНОГ 3",
                            PhraseZhHk = "黑隊3號退場兩分鐘",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 3 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor ZWART3 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација ЦРНОГ 3 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消黑隊3號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = " 7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "When must a player be disqualified (red or red and blue cards shown by the referees)?",
                    PhraseNl =
                        "Wanneer moet een speler gediskwalificeerd worden (rode of rode en blauwe kaart getoond door de scheidsrechters)?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Када се играч мора дисквалификовати (црвени или црвени и плави картон показани од стране судија)?",
                    PhraseZhHk = "什麼情況下球員會被取消比賽資格？(裁判出示紅牌或紅牌及藍牌)",
                    QuestionNumber = "8.13",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "For a foul that endangers the health of an opponent",
                            PhraseNl = "Bij een fout die de gezondheid van de tegenstrever in gevaar brengt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "За прекршај који угрожава здравље противника",
                            PhraseZhHk = "危及對方球員健康的行徑",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "For extremely unsportsmanlike conduct on or off the court",
                            PhraseNl = "Bij uitzonderlijk onsportief gedrag op of buiten het speeloppervlak",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "За екстремно неспортско понашање на терену и ван њега",
                            PhraseZhHk = "場內或場外的極端不君子行為",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "For repeated unsportsmanlike conduct on the court",
                            PhraseNl = "Bij herhaald onsportief gedrag op het speeloppervlak",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "За поновљено неспортско понашање на терену",
                            PhraseZhHk = "比賽場地內重覆不君子行爲",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "For faulty substitution during a suspension (no clear chance of scoring)",
                            PhraseNl = "Bij foutief wisselen tijdens een uitsluitingstijd (geen duidelijke doelkans)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "За неправилну замену током издржавања казне (није јасна ситуација за постизање гола)",
                            PhraseZhHk = "在退場期間替補犯規（沒有明顯得分機會）",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "During a counter-attack by WHITE 5, team official C from BLACK team runs from the bench onto the court in the direction of his own goal area. WHITE 5 becomes so confused that he stops running. In the referee’s opinion, WHITE 5 had a clear chance of scoring. The guilty official did not touch the opponent, who had the ball; his shortest distance to WHITE 5 was approximately ten metres. Correct decision?",
                    PhraseNl =
                        "Bij een tegenaanval van WIT5 loopt official C van team ZWART, van de bank uit, in de richting van het eigen doelgebied. WIT5 is zo verrast, dat hij stopt met lopen. Volgens de scheidsrechters had WIT5 een duidelijke scorekans. De schuldige official heeft noch bal, noch tegenstander aangeraakt, de kortste afstand tot WIT5 bedroeg ca. 10 meter. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "За време контранапада БЕЛОГ 5, званичник Ц ЦРНЕ екипе утрчава са клупе у правцу свог голмановог простора. БЕЛИ 5 се збуни тако да престане да трчи. По мишљењу судије БЕЛИ 5 је имао јасну ситуацију за постизање гола. Званичник Ц који је начинио прекршај није додирнуо противничког играча са лоптом; најкраћа удаљеност између њега и БЕЛОГ 5 била је отприлике 10 метара. Исправна одлука?",
                    PhraseZhHk = "白隊5號發動反擊時，黑隊球隊職員C從替補席跑向己方的禁區，白隊5號因感困惑而停了下來，裁判認為白隊5號有明顯得分機會，該職員離開白隊5號最少十米，亦沒有觸及白隊5號。如何判決？",
                    QuestionNumber = "8.14",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of team official C from BLACK team without written report (red card shown by the referees)",
                            PhraseNl =
                                " Diskwalificatie van team official C van team ZWART zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација званичника Ц ЦРНЕ екипе (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消黑隊職員C的比賽資格（裁判出示紅牌）",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of team official C from BLACK team, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van team official C van team ZWART met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација званичника Ц ЦРНЕ екипе; писани извештај (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消黑隊職員C的比賽資格及作出書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK team reduced by 1 player on the court for 2 minutes",
                            PhraseNl = "Team ZWART wordt op het speelveld met 1 speler gereduceerd gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "ЦРНА екипа се редукује за једног играча на терену на 2 минута",
                            PhraseZhHk = "黑隊場內減少一名球員兩分鐘",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is counter-attacking. WHITE 5 wants to play the ball to WHITE 7, who is all alone at the goal-area line of BLACK team. When WHITE 5 passes the ball, team official D from BLACK team runs onto the court and catches the ball. Correct decision?",
                    PhraseNl =
                        "Team WIT is in tegenaanval. WIT5 wil WIT7 aanspelen, die zich helemaal alleen aan de doelgebied lijn van team ZWART bevindt. Wanneer WIT5 de bal werpt, loopt team official D van team ZWART het speelveld op en vangt de bal. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛА екипа је у контранападу. БЕЛИ 5 жели да дода лопту БЕЛОМ 7 који је сам испред линије голмановог простора ЦРНЕ екипе. Када БЕЛИ 5 баци лопту, званичник Д ЦРНЕ екипе утрчава на терен и хвата лопту. Исправна одлука?",
                    PhraseZhHk = "白隊發動反擊，白隊5號想把球傳給靠近對方禁區線前無人防守的白隊7號；正當白隊5號傳球時，黑隊球隊職員D衝進場內把球接住。如何判決？",
                    QuestionNumber = "8.15",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for team official D from BLACK team",
                            PhraseNl = "2-minuten uitsluiting voor team official D van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења званичника Д ЦРНЕ екипе",
                            PhraseZhHk = "黑隊職員D退場兩分鐘",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of team official D from BLACK team without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor team official D van team ZWART zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација званичника Д ЦРНЕ екипе без писаног извештаја (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消黑隊職員D比賽資格（裁判出示紅牌）",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of team official D from BLACK team, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor team official D van team ZWART, met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација званичника Д ЦРНЕ екипе; писани извештај (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消黑隊職員D比賽資格及作出書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK team reduced by 1 player on the court for 2 minutes",
                            PhraseNl = "Team ZWART wordt op het speelveld gereduceerd met 1 speler gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "ЦРНА екипа се редукује за једног играча на терену на 2 минута",
                            PhraseZhHk = "黑隊場內減少一名球員兩分鐘",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Which of the following actions should be defined as extremely unsportsmanlike conduct and therefore be punished with a disqualification with a written report (red and blue cards shown by the referees)?",
                    PhraseNl =
                        "Welke van de volgende acties zou als extreem grof onsportief gedrag gedefinieerd moeten worden, en daarom met een diskwalificatie en schriftelijk verslag bestraft moeten worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Које се од наведених радњи дефинишу као екстремно неспортско понашање које ће бити кажњено дисквалификацијом за писаним извештајем (црвени и плави картон показани од стране судија)?",
                    PhraseZhHk = "以下那些動作屬於“極端不君子行爲”，需要取消比賽資格及作出書面報告？（裁判出示紅牌及藍牌）",
                    QuestionNumber = "8.16",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Repeated defending with the foot or lower leg by a court player",
                            PhraseNl = "Herhaald verdedigen met de voet of onderbeen door een veldspeler",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Поновљена одбрана стопалом или потколеницом од стране играча у пољу",
                            PhraseZhHk = "場內球員重覆地使用腳或小腿進行防守",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "A team official destroying a clear chance of scoring",
                            PhraseNl = "Verhinderen van een open doelkans door een team official",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Званичник спречава јасну ситуацију за постизање гола",
                            PhraseZhHk = "球隊職員破壞了明顯得分機會",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Spitting on another person",
                            PhraseNl = "Bespuwen van een ander persoon",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Пљување на другу особу",
                            PhraseZhHk = "向人吐口水",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeated delays of the game, with the purpose of wasting time",
                            PhraseNl = "Herhaalde spelvertragen om tijd te winnen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Поновљено одуговлачење игре у циљу трошења времена",
                            PhraseZhHk = "重覆地故意消極比賽",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "When entering the playing hall, the referees meet BLACK 4, who wears the player’s uniform, but is not included in the score sheet for the match. BLACK 4 shouts: “Not these idiots again!” After 12 minutes of the match have been played, BLACK 4 is added to the score sheet as his team’s 14th player. This is discovered by the referees. Correct decision?",
                    PhraseNl =
                        "Bij het betreden van de sporthal, komen de scheidsrechters de reeds omgeklede, maar nog niet op het wedstrijdformulier ingeschreven ZWART4 tegen. ZWART4 roep: “Toch niet weer deze idioten”. Nadat er 12 minuten gespeeld zijn in de wedstrijd, wordt ZWART4 als 14e speler van zijn team inschrijven op het wedstrijdformulier. Dit wordt vastgesteld door de scheidsrechter. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Док су улазили у халу у којој се игра утакмица судије сретну ЦРНОГ 4 који је у спортској опреми, али који није уписан у записник утакмице. ЦРНИ 4 је прокоментарисао “не опет ти идиоти!”. Играо се 12. минут утакмице, ЦРНИ 4 је додат у записник утакмице као 14. играч своје екипе. То су судије уочиле. Исправна одлука?",
                    PhraseZhHk = "當進入比賽場地時，裁判遇見黑隊4號。當時黑隊4號穿上球衣，但記錄表上沒有他的名字。他對裁判說：「又是你這個白痴!」。及後，比賽至12分鐘，黑隊4號在記錄表上登記成為第十四名球員，被裁判發覺。如何判決？",
                    QuestionNumber = "8.17",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 4 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART4 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација без писаног извештаја ЦРНОГ 4 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消黑隊4號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK team is reduced by 1 player on the court for 2 minutes",
                            PhraseNl = "Team ZWART wordt op het speelveld gereduceerd met 1 speler gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "ЦРНА екипа се редукује на терену за једног играча у трајању од 2 минута",
                            PhraseZhHk = "黑隊減少一名場內球員兩分鐘",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK team continues without a reduction of players on the court",
                            PhraseNl = "Team ZWART speelt verder zonder reducering van een speler op het speelveld",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "ЦРНА екипа наставља без редукције играча на терену",
                            PhraseZhHk = "黑隊毋須減少場內球員",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 4, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART4, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација ЦРНОГ 4, писани извештај (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消黑隊4號比賽資格及作出書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "BLACK team can add another player to complete the team’s allowed number of 14 players.",
                            PhraseNl =
                                "Team ZWART mag een andere speler toevoegen om zijn team tot 14 spelers te vervolledigen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "ЦРНА екипа може додати другог играча да комплетира своју екипу до броја од 14 играча",
                            PhraseZhHk = "黑隊可增加其他人成為第十四名球員",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "After a free throw for WHITE team, team official C from BLACK team enters the court and shouts: “But that should be a free throw for us!” No team officials from BLACK team have been punished earlier in the match. Correct decision?",
                    PhraseNl =
                        "Na een vrije worp voor team WIT, betreedt team official C van team ZWART het speelveld en roept: “Maar dat is toch vrije worp voor ons!”. Geen enkele team official van team ZWART werd eerder bestraft in de wedstrijd. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Након досуђеног слободног бацања за БЕЛУ екипу, званичник Ц ЦРНЕ екипе улази у поље за игру вичући “Али, то је требало бити слободно бацање за нас!”. Ниједан званичник ЦРНЕ екипе претходно није кажњен. Исправна одлука?",
                    PhraseZhHk = "裁判判白隊擲自由球後，黑隊球隊職員C進場大叫：“這個自由球應是我們的”。黑隊職員之前並沒有被警告的記錄。如何判決？",
                    QuestionNumber = "8.18",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The responsible team official from BLACK team must take team official C out of the hall.",
                            PhraseNl =
                                "De verantwoordelijke team official van team ZWART moet team official C uit de hal zetten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Одговорни представник ЦРНЕ екипе мора одвести званичника Ц напоље из хале",
                            PhraseZhHk = "黑隊“球隊職員代表”將黑隊職員C帶離球場",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for team official C from BLACK team, BLACK team is reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "2-minuten uitsluiting voor team official C van team ZWART, team ZWART wordt op het speelveld met 1 speler gereduceerd gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "2 минута искључења противн званичника Ц ЦРНЕ екипе, ЦРНА екипа је редукована за једног играча на терену на 2 минута",
                            PhraseZhHk = "黑隊職員C被判退場兩分鐘，由場內球員代罰",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for team official C from BLACK team",
                            PhraseNl = "Waarschuwing voor team official C van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за званичника Ц ЦРНЕ екипе",
                            PhraseZhHk = "警告黑隊職員C",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 3 receives a warning due to a foul on the court that requires progressive punishment. After restart of the game and after being substituted, WHITE 3 insults the referees from the substitutions bench. Correct decision?",
                    PhraseNl =
                        "WIT3 krijgt een waarschuwing omwille van een fout op het speelveld die een progressieve bestraffing vereist. Na herneming van het spel en na gewisseld te zijn, beschuldigd WIT3 de scheidsrechters vanaf de wisselbank. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 3 је добио опомену за прекршај у пољу за игру, који се прогресивно кажњава. После наставка игре и након што је замењен, БЕЛИ 3 вређа судије с клупе за резервне играче. Исправна одлука?",
                    PhraseZhHk = "白隊3號因漸進處罰而被警告；在替換出場後，他坐在替補席上辱駡裁判。如何處理？",
                    QuestionNumber = "8.19",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 3 without written report (red card shown by the referees, and WHITE team reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "Diskwalificatie van WIT3 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters) en team WIT wordt op het speelveld gereduceerd met 1 speler voor 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација за БЕЛОГ 3 без писаног извештаја (црвени картон показан од стране судија) и БЕЛА екипа се редукује за једног играча на терену на 2 минута",
                            PhraseZhHk = "取消白隊3號比賽資格，退場兩分鐘（裁判出示紅牌）",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 3, written report (red and blue cards shown by the referees), WHITE team reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "Diskwalificatie van WIT3 met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters) en team WIT wordt op het speelveld gereduceerd met 1 speler voor 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација БЕЛОГ 3 са писаним извештајем (црвени и плави картон показани од стране судија) и БЕЛА екипа се редукује за једног играча на терену на 2 минута",
                            PhraseZhHk = "取消白隊3號比賽資格，提交書面報告（裁判出示紅牌及藍牌），白隊場內減少一名球員兩分鐘",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for WHITE 3, and WHITE team reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "2-minuten uitsluiting van WIT3 en team WIT wordt op het speelveld gereduceerd met 1 speler voor 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "2 минута искључења против БЕЛОГ 3 и БЕЛА екипа се редукује за једног играча на терену на 2 минута",
                            PhraseZhHk = "白隊3號退場兩分鐘，白隊場內減少一名球員兩分鐘",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "比賽暫停",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "During a counter-attack BLACK 9 has his shirt pulled by WHITE 4, who has already received a warning. Despite this, BLACK 9 manages to play the ball to BLACK 8, who scores a goal. The referees want to penalise WHITE 4 afterwards, but by then he is already sitting on the substitution bench. Correct decision?",
                    PhraseNl =
                        "Bij een tegenaanval wordt ZWART9 door WIT4, die voordien reeds gewaarschuwd werd, aan zijn truitje vastgehouden. Desondanks kan ZWART9 de bal toch nog naar ZWART8 spelen, die een doelpunt scoort. De scheidsrechter wil nu WIT4 na bestraffen, doch die zit ondertussen op de wisselbank. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "За време контранапада БЕЛИ 4, који већ има опомену, повлачи ЦРНОГ 9 за дрес. Упркос томе ЦРНИ 9 успева да дода лопту ЦРНОМ 8 који постиже гол. Судије желе накнадно да казне БЕЛОГ 4, али он тада већ седи на клупи за резервне играче. Исправна одлука?",
                    PhraseZhHk = "快攻反擊時，已被警告的白隊4號拉住持球的黑隊9號，但黑隊9號仍能把球傳給黑隊8號射門得分。當裁判想判罰白隊4號時，他已坐到替補席上。如何判決？",
                    QuestionNumber = "8.20",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for WHITE 4, WHITE team is reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "2-minuten uitsluiting voor WIT4, team WIT wordt op het speelveld gereduceerd gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "2 минута искључења против БЕЛОГ 4; БЕЛА екипа се редукује за једног играча на терену на 2 минута",
                            PhraseZhHk = "白隊4號退場兩分鐘，場內減少一人兩分鐘",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE 4 is not allowed to play for the next 2 minutes, but the team remains complete on the court",
                            PhraseNl =
                                "WIT4 mag de volgende 2 minuten niet meer meespelen maar zijn team blijft volledig op het speelveld",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛИ 4 не сме да игра следећа 2 минута, али екипа у пољу комплетна",
                            PhraseZhHk = "白隊4號退場兩分鐘，場內不需減人",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Punishment no longer possible",
                            PhraseNl = "Geen bestraffing meer mogelijk",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Казна више није могућа",
                            PhraseZhHk = "不能判罰",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification for WHITE 4 (red card shown by the referees), and WHITE team is reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "Diskwalificatie voor WIT4 (rode kaart getoond door de scheidsrechters) en team WIT wordt met 1 speler op het speelveld gereduceerd gedurende twee minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација БЕЛОГ 4 (црвени картон показан од стране судија) БЕЛА екипа се редукује за једног играча на терену на 2 минута",
                            PhraseZhHk = "取消白隊4號比賽資格（裁判出示紅牌），場內減少一人兩分鐘",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "When must a player be disqualified (red card or red and blue cards shown by the referees)?",
                    PhraseNl =
                        "Wanneer moet een speler gediskwalificeerd worden (rode kaart of rode en blauwe kaart getoond door de scheidsrechters)?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Када треба дисквалификовати играча (црвени или црвени и плави картон показани од стране судија)?",
                    PhraseZhHk = "在什麼情况下要取消球員的比賽資格（裁判出示紅牌或紅牌及藍牌）？",
                    QuestionNumber = "8.21",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "For seriously unsportsmanlike conduct",
                            PhraseNl = "Bij grof onsportief gedrag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "За грубо неспортско понашање",
                            PhraseZhHk = "嚴重不君子行為",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "For destroying a clear chance of scoring through actively blocking a shot or pass by using his foot",
                            PhraseNl =
                                "Bij het verhinderen van een open doelkans door het actief blokken van een worp of pas met de voet",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "За спречавање јасне ситуације за постизање гола блокирањем шута или додавања намерним коришћењем стопала",
                            PhraseZhHk = "主動用腳阻擋或踢走球，以致破壞一個明顯得分機會時",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "For faulty substitution during suspension time (no clear chance of scoring)",
                            PhraseNl = "Bij foutief wisselen tijdens een tijdelijke uitsluiting (geen open doelkans)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "За неправилну замену у току трајања временске казне (није јасна ситуација за постизање гола)",
                            PhraseZhHk = "在被判退場兩分鐘期間內替補犯規（沒有明顯得分機會）",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "For not putting down the ball for a free throw against his own team (not in the last 30 seconds)",
                            PhraseNl =
                                "Voor het niet neerleggen van de bal voor een vrije worp tegen zijn eigen team (niet in de laatste 30 seconden)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "За неспуштање лопте кад је досуђено слободног бацања за противничку екипу (није у последњих 30 секунди)",
                            PhraseZhHk = "判對方擲自由球時不立即把球放下（不是最後30秒）",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK team is attacking. WHITE 11 takes the ball away from BLACK 6 by committing a foul that endangers the health of BLACK 6. WHITE 7 and WHITE 8 were positioned between BLACK 6 and the goal of WHITE team at the time of the foul. Correct decision?",
                    PhraseNl =
                        "Team ZWART is in de aanval. WIT11 ontneemt ZWART6 de bal, door een fout te begaan die de gezondheid van ZWART6 in gevaar brengt. WIT7 en WIT8 staan tussen ZWART6 en het doel van team WIT op het ogenblik van de fout. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНА екипа је у нападу, БЕЛИ 11 одузима лопту ЦРНОМ 6 прекршајем опасним по здравље ЦРНОГ 6. За време прекршаја још су БЕЛИ 7 и БЕЛИ 8 између ЦРНОГ 6 и гола БЕЛЕ екипе. Исправна одлука?",
                    PhraseZhHk = "黑隊進攻，白隊11號犯規奪得黑隊6號的球，同時危及黑隊6號的身體。當時在黑隊6號和球門之間還有白隊7號和白隊8號在防守。如何處理？",
                    QuestionNumber = "8.22",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 11",
                            PhraseNl = "2-minuten uitsluiting voor WIT11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 11",
                            PhraseZhHk = "白隊11號退場兩分鐘",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 11 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT11 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација за БЕЛОГ 11 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消白隊11號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Which of the following infractions must be punished with a disqualification with written report according to the rules (red and blue cards shown by the referees)?",
                    PhraseNl =
                        "Welke van de volgende inbreuken moeten volgens de spelregels met een diskwalificatie en een schriftelijk verslag bestraft worden (rode en blauwe kaard getoond door de scheidsrechters)?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Који од наведених прекршаја морају бити кажњени дисквалификацијом са писаним извештајем у складу са Правилима игре (црвени и плави картон показани од стране судија)?",
                    PhraseZhHk = "依據球例，下列那種情况必須判罰取消比賽資格及提交書面報告（裁判出示紅牌及藍牌）？",
                    QuestionNumber = "8.23",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "An official enters the court for the second time without permission.",
                            PhraseNl =
                                "Een official betreedt het speloppervlak voor de tweede maal zonder toestemming.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Званичник екипе други пут улази у поље за игру без дозволе",
                            PhraseZhHk = "球隊職員未經裁判許可第二次進入比賽場地",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "An official, who tries to force his team to abandon the game.",
                            PhraseNl = "Een official die zijn team aanzet tot het stoppen van de wedstrijd.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Званичник екипе покушава да присили своју екипу да напусти утакмицу",
                            PhraseZhHk = "球隊職員強迫球隊放棄比賽",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "When a 7-metre thrower hits the goalkeeper’s head, and the goalkeeper is not moving his head in the direction of the ball.",
                            PhraseNl =
                                "Wanneer een 7m werper het hoofd van de doelverdediger raakt, en de doelverdediger zijn hoofd niet in de richting van de bal beweegt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Када извођач седмерца погоди голмана у главу, а да голман није померао главу у правцу лопте",
                            PhraseZhHk = "擲七米球時，球擊中沒有移動的守門員的臉部",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After a decision by the referees, a player demonstratively throws the ball into the stands.",
                            PhraseNl =
                                "Na een beslissing van de scheidsrechters werpt een speler de bal demonstratief in de tribune.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Након судијске одлуке играч демонстративно баца лопту на трибине",
                            PhraseZhHk = "裁判作出判决後，球員不滿地把球抛向觀眾席",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "A player outside the playing court spits on a spectator.",
                            PhraseNl = "Een speler buiten het speeloppervlak spuwt naar een toeschouwer.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Играч изван терена пљуне на гледаоца",
                            PhraseZhHk = "球員在場外向觀眾吐口水",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 3 has received a 2-minute suspension for a foul and is sitting on the substitution bench. During a throw-in near the bench, WHITE 3 shouts at the referees to insult them. Correct decision?",
                    PhraseNl =
                        "WIT3 heeft een 2-minuten uitsluiting gekregen voor een fout en zit op de wisselbank. Bij een inworp in de buurt van de bank, roept WIT3 naar de scheidsrechter om hun te beledigen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 3 је искључен на 2 минута због прекршаја и седи на клупи. За време извођења аута у близини клупе, БЕЛИ 3 опсује судије. Исправна одлука?",
                    PhraseZhHk = "白隊3號犯規後被罰退場兩分鐘，退場後坐在替補席上。在替補席附近，正要擲界外球時，白隊3號大聲辱駡裁判。如何判決？",
                    QuestionNumber = "8.24",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minutes suspension for WHITE 3",
                            PhraseNl = "2-minuten uitsluiting voor WIT3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 3",
                            PhraseZhHk = "白隊3號退場兩分鐘",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 3 without written report (red card shown by the referees), which causes an immediate 2-minute reduction of WHITE team on the court",
                            PhraseNl =
                                "Diskwalificatie van WIT3, zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters), wat een onmiddellijke reductie gedurende 2 minuten van team WIT op het speelveld tot gevolg heeft",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација БЕЛОГ 3 без писаног извештаја (црвени картон показан од стране судија) која проузрокује моменталну редукцију БЕЛЕ екипе за једног играча на терену на 2 минута",
                            PhraseZhHk = "取消白隊3號比賽資格（裁判出示紅牌），白隊減少一名場內球員比賽兩分鐘",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team reduced by 1 player on the court for 4 minutes",
                            PhraseNl = "Team WIT wordt met één speler gereduceerd gedurende 4 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛА екипа се редукују за једног играча на терену на 4 минута",
                            PhraseZhHk = "白隊場內減少一名球員比賽四分鐘",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification for WHITE 3, written report (red and blue cards shown by the referees), which causes an immediate 2-minute reduction of WHITE team on the court",
                            PhraseNl =
                                "Diskwalificatie voor WIT3, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters), wat een onmiddellijke reductie gedurende 2 minuten van team WIT op het speelveld tot gevolg heeft",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација БЕЛОГ 3 са писаним извештајем (црвени и плави картон показани од стране судија) која проузрокује моменталну редукцију БЕЛЕ екипе за једног играча на терену на 2 минута",
                            PhraseZhHk = "取消白隊3號比賽資格，提交書面報告（裁判出示紅牌及藍牌），白隊減少一名場內球員比賽兩分鐘",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Due to disappointment over a mistake, WHITE 3 hits one of his teammates in the face. Correct decision?",
                    PhraseNl =
                        "Uit ontgoocheling over een fout slaat WIT3 een van zijn eigen medespeler in het gelaat. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Разочаран грешком, БЕЛИ 3 удари саиграча у лице. Исправна одлука?",
                    PhraseZhHk = "由於一次進攻失誤，白隊3號摑了他的隊友一巴。如何判決？",
                    QuestionNumber = "8.25",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "No action, because it involves a teammate",
                            PhraseNl = "Geen actie, aangezien het om een eigen medespeler gaat",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Ништа, јер је напао саиграча",
                            PhraseZhHk = "不作處理，因爲打的是隊友",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 3",
                            PhraseNl = "2-minuten uitsluiting voor WIT3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 3",
                            PhraseZhHk = "白隊3號退場兩分鐘",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 3 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor WIT3 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација за БЕЛОГ 3 (црвени картон показана од стране судија)",
                            PhraseZhHk = "取消白隊3號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification for WHITE 3, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor WIT3 met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација БЕЛОГ 3 са писаним извештајем (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消白隊3號比賽資格，提交書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "When entering the hall the referees meet BLACK 4, who already wears a player’s uniform and immediately shouts out: “Surely not these idiots again!” The referees verify that BLACK 4 is included in the score sheet for the match. Correct decision?",
                    PhraseNl =
                        "Bij het betreden van de hal, komen de scheidsrechters de reeds aangeklede speler ZWART4 tegen, die meteen roept: “Toch niet wéér deze idioten!”. De scheidsrechters stellen vóór aanvang van de wedstrijd vast dat ZWART4 op het wedstrijdformulier staat ingeschreven. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Улазећи у дворану судије сретну ЦРНОГ 4 који је већ обучен у дрес и који им довикне: “Ма, не опет ови идиоти!“. Судије су утврдиле да се ЦРНИ 4 налази у записнику утакмице. Исправна одлука?",
                    PhraseZhHk = "在進入比賽場館時，身穿比賽球衣的黑隊4號遇見裁判即大聲叫“千萬不要又是這幾個白痴”。裁判確認記錄表上有黑隊4號這名球員。如何判決？",
                    QuestionNumber = "8.26",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 4 at the beginning of the match",
                            PhraseNl = "2-minuten uitsluiting voor ZWART4 bij het begin van het spel",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против ЦРНОГ 4 на почетку утакмице",
                            PhraseZhHk = "比賽開始時，黑隊4號退場兩分鐘",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 4 without written report (red card shown by the referees), BLACK team is reduced by 1 player on the court for 2 minutes at the beginning of the match",
                            PhraseNl =
                                "Diskwalificatie van ZWART4 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters), team ZWART wordt bij het begin van de wedstrijd op het speelveld gereduceerd met 1 speler gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација ЦРНОГ 4 без писаног извештаја (црвени картон показан од стране судија) и ЦРНА екипа се редукује за једног играча на терену на 2 минута, на почетку утакмице",
                            PhraseZhHk = "取消黑隊4號比賽資格（裁判出示紅牌），比賽開始時，黑隊減少一名場內球員比賽兩分鐘",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 4, written report (red and blue cards shown by the referees), BLACK team may use 14 players in the match",
                            PhraseNl =
                                "Diskwalificatie van ZWART4, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters). Team ZWART mag 14 spelers in de wedstrijd opstellen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација ЦРНОГ 4 са писаним извештајем (црвени и плави картон показани од стране судија) и ЦРНА екипа може користити 14 играча на утакмици",
                            PhraseZhHk = "取消黑隊4號比賽資格，提交書面報告（裁判出示紅牌及藍牌），黑隊可用14名球員",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 4, written report (red and blue cards shown by the referees), BLACK team may use 14 players in the match but is reduced by 1 player on the court for 2 minutes at the beginning of the match",
                            PhraseNl =
                                "Diskwalificatie van ZWART4, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters). Team ZWART mag 14 spelers in de wedstrijd opstellen maar wordt bij het begin van de wedstrijd op het veld met 1 speler gereduceerd gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација ЦРНОГ 4 са писаним извештајем (црвени и плави картон показани од стране судија) и ЦРНА екипа може користити 14 играча на утакмици, али се редукује за једног играча на терену на 2 минута, на почетку утакмице",
                            PhraseZhHk = "取消黑隊4號比賽資格，提交書面報告（裁判出示紅牌及藍牌），黑隊可用14名球員，但比賽開始時必須減少一名場內球員兩分鐘",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "While warming up before the match, WHITE 3 and goalkeeper BLACK 1 collide by accident. The two players get upset with each other, and BLACK 1 hits WHITE 3. WHITE 3 hits him straight back. Both players are included in the score sheet for the match. Correct decision?",
                    PhraseNl =
                        "Bij het opwarmen voor de wedstrijd botsen WIT3 en de doelverdediger ZWART1 per ongeluk tegen elkaar. Beide spelers schelden elkaar uit en doelman ZWART1 slaat WIT3. WIT3 slaat meteen terug. Beide spelers staan op het wedstrijdformulier ingeschreven. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "На загревању пре утакмице БЕЛИ 3 и голман ЦРНИ 1 се нехотице сударе. Изнервирају се и ЦРНИ 1 удари БЕЛОГ 3. БЕЛИ 3 му одмах узврати. Оба играча су унесена у записник утакмице. Исправна одлука?",
                    PhraseZhHk = "在賽前熱身時，白隊3號和黑隊守門員1號因意外有碰撞，兩球員因此互相吵架；黑隊1號打了白隊3號一下，白隊3號立即還手。兩名球員都已登記在記錄表上。如何判決？",
                    QuestionNumber = "8.27",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 1, written report (red and blue cards shown by the referees) and a 2-minute suspension for WHITE 3. The teams may use 14 players each in the match.",
                            PhraseNl =
                                "Diskwalificatie van ZWART1, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters) en een 2-minuten uitsluiting van WIT3. De ploegen mogen elk tot 14 spelers aangevuld worden",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација ЦРНОГ 1 са писаним извештајем (црвени и плави картон показани од стране судија) и 2 минута искључења против БЕЛОГ 3; Екипе могу користити 14 играча",
                            PhraseZhHk = "取消黑隊1號比賽資格，提交書面報告（裁判出示紅牌及藍牌），白隊3號退場兩分鐘。雙方可用14名球員",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 1 and WHITE 3, written reports (red and blue cards shown by the referees). The teams may use 14 players each in the match, but both teams are reduced by 1 player on the court for 2 minutes at the beginning of the match.",
                            PhraseNl =
                                "Diskwalificatie van ZWART1 en WIT3, schriftelijke verslagen (rode en blauwe kaart getoond door de scheidsrechters). De ploegen mogen elk tot 14 spelers aangevuld worden, maar beide teams worden bij het begin van de wedstrijd op het speelveld met 1 speler gereduceerd gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација ЦРНОГ 1 и БЕЛОГ 3 са писаним извештајем (црвени и плави картон показани од стране судија) екипе могу користити 14 играча на утакмици, али обе екипе се редукују за једног играча на терену на 2 минута на почетку утакмице",
                            PhraseZhHk = "取消黑隊1號和白隊3號比賽資格，提交書面報告（裁判出示紅牌及藍牌），雙方可用14名球員，首兩分鐘雙方減少一名場內球員兩分鐘，提交書面報告",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Both players receive a 2-minute suspension, which must be served at the beginning of the match. Written report.",
                            PhraseNl =
                                "Beide spelers krijgen een 2-minuten uitsluiting die in het begin van de wedstrijd moet worden uitgezeten. Schriftelijk verslag.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Оба играча добијају 2 минута искључења које мора бити издржано на почетку утакмице. Писани извештај",
                            PhraseZhHk = "兩名球員均被判退場兩分鐘，由開始比賽時執行，提交書面報告",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 1 and WHITE 3, written reports (red and blue cards shown by the referees). The teams may use 14 players each in the match.",
                            PhraseNl =
                                "Diskwalificatie van ZWART1 en WIT3,, schriftelijke verslagen (rode en blauwe kaart getoond door de scheidsrechters) De ploegen mogen elk tot 14 spelers aangevuld worden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација ЦРНОГ 1 и БЕЛОГ 3 са писаним извештајем (црвени и плави картон показани од стране судија); Екипе могу корисити 14 играча на утакмици",
                            PhraseZhHk = "取消黑隊1號和白隊3號比賽資格，提交書面報告（裁判出示紅牌及藍牌），雙方可用14名球員",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 9 is taking a jump shot. BLACK 5 grabs WHITE 9’s shooting arm from behind and pulls him down. BLACK 10 and BLACK 11 are in position between WHITE 9 and the goal of BLACK team. Correct decision?",
                    PhraseNl =
                        "WIT9 is in sprongworp. ZWART5 grijpt de werparm van WIT9 langs achter en trekt hem neer. ZWART10 en ZWART11 staan nog tussen WIT9 en het doel van team ZWART. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 9 изводи скок-шут. ЦРНИ 5 га са леђа хвата за шутерску руку и повлачи надоле. ЦРНИ 10 и ЦРНИ 11 се налазе између БЕЛОГ 9 и гола ЦРНЕ екипе. Исправна одлука?",
                    PhraseZhHk = "白隊9號跳起射門，黑隊5號從後拉他的投擲臂並將他拉倒；此時，白隊9號面前還有兩名防守球員。如何判決？",
                    QuestionNumber = "8.28",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Семерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 5 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor ZWART5 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација без писаног извештаја за ЦРНОГ 5 (црвени картон од стране судија)",
                            PhraseZhHk = "取消黑隊5號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 5",
                            PhraseNl = "2-minuten uitsluiting voor ZWART5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против ЦРНОГ 5",
                            PhraseZhHk = "黑隊5號退場兩分鐘",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 5, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor ZWART5, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација са писаним извештајем за ЦРНОГ 5 (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消黑隊5號比賽資格，提交書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Which of the following infractions must be punished with a disqualification (red card shown by the referees)?",
                    PhraseNl =
                        "Welke van de volgende overtredingen moet bestraft worden met een diskwalificatie (rode kaart getoond door de scheidsrechters)?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Који од наведених прекршаја мора бити кажњен дисквалификацијом (црвени картон показан од стране судија)?",
                    PhraseZhHk = "下列那些犯規必須判罰取消比賽資格（裁判出示紅牌）？",
                    QuestionNumber = "8.29",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "An official enters the court for the second time without permission.",
                            PhraseNl =
                                "Een official betreedt voor de tweede keer het speeloppervlak zonder toestemming.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Званичник улази у поље за игру други пут без дозволе",
                            PhraseZhHk = "球隊職員第二次未經允許進入場內",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "A player in possession of the ball is pulled down when running during a counter-attack. The situation is not particularly dangerous.",
                            PhraseNl =
                                "Een speler in balbezit wordt neergetrokken terwijl hij in tegenaanval loopt, de situatie is niet zeer gevaarlijk.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Играч који трчи у контранапад је повучен и оборен. Ситуација није нарочито опасна.",
                            PhraseZhHk = "拉倒正在快速反擊跑動中的持球球員，這種情況並不是特別危險",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "A 7-metre throw hits the face of the goalkeeper, who is not moving in the direction of the ball.",
                            PhraseNl =
                                "Een 7-m-worp raakt het gezicht van de doelverdediger, die niet beweegt in de richting van de bal.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац изведен у лице голмана који се не помера у правцу лопте",
                            PhraseZhHk = "擲七米球時，擊中沒有移動的守門員的臉部",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "After a referee decision a player throws the ball into the stands as a protest.",
                            PhraseNl =
                                "Na een beslissing van de scheidsrechter werpt een speler uit protest de bal in de tribune.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Након судијске одлуке играч у знак протеста баца лопту на трибине",
                            PhraseZhHk = "裁判判决後，球員將球擲到觀眾席上以示不滿",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The goalkeeper leaves the goal area and gains possession of the ball, but causes a collision with an opponent, who is running in a counter-attack.",
                            PhraseNl =
                                "De doelverdediger verlaat het doelgebied en komt in balbezit, maar veroorzaakt een botsing met de tegenspeler die in tegenaanval loopt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Голман напушта голманов простор и хвата лопту, али приликом кретања изазове судар са противником који трчи у контранапад",
                            PhraseZhHk = "守門員為截取對方的傳球而離開禁區時，因他的動作引致與對方發生碰撞",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 9 receives his third 2-minute suspension and is therefore disqualified. Wearing his tracksuit he takes a seat in the first spectators’ row behind the sideline opposite the substitution area. Directly in front of him, BLACK 3 commits a particularly dangerous foul against WHITE 10. The player remains injured on the floor. Before the referees can punish BLACK 3, WHITE 9 runs onto the court and knocks BLACK 3 down. Correct decision?",
                    PhraseNl =
                        "WIT9 krijgt zijn derde 2-minuten uitsluiting en is daardoor gediskwalificeerd. In trainingspak neemt hij plaats, op de eerste rij toeschouwers aan de zijlijn, tegenover de wisselzone. Vlak voor hem begaat ZWART3 een grove fout tegen WIT10. De speler blijft gekwetst op de grond blijft liggen. Voor de scheidsrechters ZWART3 kunnen bestraffen, loopt WIT9 het plein op en slaat ZWART3 neer. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 9 је дисквалификован после трећег искључења на 2 минута. У тренерци седа у први ред гледалишта уз аут линију, насупрот простору за замену играча. Тачно испред њега, у ЦРНИ 3 направи посебно опасан прекршај против БЕЛОГ 10. Повређен играч остаје на поду. Пре него што су судије могле да казне ЦРНОГ 3, БЕЛИ 9 утрчи у поље за игру и ударцем обара ЦРНОГ 3. Исправна одлука?",
                    PhraseZhHk = "比賽至36分鐘時，白隊9號因第三次退場兩分鐘而被判取消資格；白隊9號穿起運動外套坐在替補區對面，邊線外的前排觀衆席上。比賽至55分鐘時，在白隊9號前面的場地內，黑隊3號作出特別危險動作使白隊10號受傷倒地，在裁判判罰黑隊3號犯規前，白隊9號跑進場內將黑隊3號擊倒。如何判決？",
                    QuestionNumber = "8.30",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 3, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART3, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација ЦРНОГ 3, писани извештај (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消黑隊3號比賽資格，提交書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE 9 is not involved in the match any more, no remarks possible",
                            PhraseNl = "WIT9 is niet meer betrokken bij het spel, vandaar geen vermeldingen mogelijk",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛИ 9 више не учествује у утакмици, није могућа напомена",
                            PhraseZhHk = "因白隊9號已被取消比賽資格，故不用進一步處理",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Written report about the behaviour of WHITE 9",
                            PhraseNl = "Schriftelijk verslag over het gedrag van WIT9",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Писани извештај о понашању БЕЛОГ 9",
                            PhraseZhHk = "關於白隊9號的行為提交書面報告",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 3 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART3 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација без писаног извештаја за ЦРНОГ 3 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消黑隊3號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE 10 must leave the court after receiving medical care and can only re-enter following the third attack of his team.",
                            PhraseNl =
                                "WIT10 moet na verzorging het speelveld verlaten en mag pas terug opkomen na drie aanvallen van zijn team.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "БЕЛИ 10 мора напустити терен после указане медицинске помоћи и може се вратити после трећег напада БЕЛЕ екипе",
                            PhraseZhHk =         "於球場內接受治理後，白隊10號必須離開球場，並且於其球隊完成3次進攻後，才可以進場比賽",
                            AnswerNumber = "f"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "A warning shall be given for:",
                    PhraseNl = "Een waarschuwing moet gegeven worden bij:",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Опомена ће бити дата за:",
                    PhraseZhHk = "什麼情况下應判警告？",
                    QuestionNumber = "8.31",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Infractions where the action is mainly or exclusively aimed at the body of the opponent",
                            PhraseNl =
                                "Overtredingen waarbij de actie voornamelijk of uitsluitend gericht is op het lichaam van de tegenstrever",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прекршај у којем је акција усмерена углавном или сасвим ка телу противника",
                            PhraseZhHk = "一般主要或刻意地針對對方身體的犯規動作",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Infractions while the opponents are executing a formal throw",
                            PhraseNl = "Overtredingen wanneer de tegenstander een gewone worp uitvoert",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прекршај приликом извођења неког од бацања противничке екипе",
                            PhraseZhHk = "妨礙對方球員擲球時",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Failure to put the ball down on the floor when a decision is made against one’s own team",
                            PhraseNl = "Het niet neerleggen van de bal bij beslissingen tegen het eigen team",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Неспуштање лопте на тло код досуђеног прекршаја против екипе која је имала лопту у поседу",
                            PhraseZhHk = "裁判判對方擲球時，持球球員不立即將球放在地上",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "A goalkeeper’s attempt to make a substitution when an opponent is ready to take a 7-metre throw",
                            PhraseNl =
                                "Een doelverdediger die aanstalten maakt om te wisselen wanneer de tegenstander klaarstaat voor de uitvoering van een 7-meterworp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Покушај голмана да обави замену када је противник спреман за извођење седмерца",
                            PhraseZhHk = "準備擲七米球時，防守隊替換守門員",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "What must be considered as unsportsmanlike conduct?",
                    PhraseNl = "Wat moet worden beschouwd als onsportief gedrag?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Шта се сматра неспортским понашањем?",
                    PhraseZhHk = "下列那些情况被視爲不君子行爲？",
                    QuestionNumber = "8.32",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Throwing the ball in the face of a defender, who is not moving in the direction of the ball",
                            PhraseNl =
                                "De bal in het gezicht van de tegenstrever werpen, die zich niet in de richting van de bal baweegt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Бацање лопте у главу одбрамбеног играча који се не креће у правцу лопте",
                            PhraseZhHk = "擲球擊中未有移動的防守球員的頭部",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Passive behaviour by the goalkeeper during the execution of a 7-metre throw, if it is apparent that he is not willing to save the shot",
                            PhraseNl =
                                "Passief gedrag van een doelverdediger bij een 7m-worp zodat duidelijk is dat hij de 7m-worp niet wil trachten te stoppen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Пасиван став голмана током извођења седмерца, када је очито да он не покушава да брани шут",
                            PhraseZhHk = "擲七米球時，守門員態度消極，明顯不悅地防守",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Trying to mislead the referees through fake actions",
                            PhraseNl = "Poging om de scheidsrechters met komedie te misleiden",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Покушај обмане судије симулирањем",
                            PhraseZhHk = "作出假動作，以誤導裁判",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Actively blocking a shot by using a foot or lower leg",
                            PhraseNl = "Actief blokken van een worp door gebruik van voeten en onderbeen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Активно блокирање шута на гол коришћењем ноге или потколенице",
                            PhraseZhHk = "主動地用腳封阻射門",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeated entering the goal area for tactical reasons",
                            PhraseNl = "Herhaaldelijk betreden van het doelgebied om tactische redenen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Поновљени улазак у голманов простор, из тактичких разлога",
                            PhraseZhHk = "由於戰術原因重覆進入禁區",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "An act of revenge after having been fouled",
                            PhraseNl = "Revanche actie na een ondergane overtreding",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Реванш после прекршаја",
                            PhraseZhHk = "被犯規後的報復行為",
                            AnswerNumber = "f"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "In which of the following situations must a disqualification lead to a written report (red and blue cards shown by the referees)?",
                    PhraseNl =
                        "In welke van de volgende gevallen moet een diskwalificatie een schriftelijk verslag tot gevolg hebben (rode en blauwe kaart getoond door de scheidsrechters)?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "У којим ситуацијама уз дисквалификацију мора следити писани извештај (црвени и плави картон показани од стране судија)?",
                    PhraseZhHk = "下列那些情況需要判取消比賽資格及提交書面報告（裁判出示紅牌及藍牌）？",
                    QuestionNumber = "8.33",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Assault on the playing court during the half-time break",
                            PhraseNl = "Een gewelddaad op het speeloppervlak tijdens de pauze",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Физички напад на терену, за време паузе између два полувремена",
                            PhraseZhHk = "中場休息時，在比賽場內發生歐鬥事件",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "A particularly reckless or dangerous action",
                            PhraseNl = "Een uitzonderlijk roekeloze en gevaarlijke overtreding",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Нарочито несмотрена и опасна акција",
                            PhraseZhHk = "特別魯莽或特別危險的動作",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "An act of revenge after having been fouled",
                            PhraseNl = "Revanche actie na een ondergane overtreding",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Реванш после прекршаја",
                            PhraseZhHk = "被犯規後的報復行為",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "A malicious action, which is not in any way related to the game situation",
                            PhraseNl =
                                "Een gemene en intentionele actie, die op geen enkele wijze verband houdt met de spelsituatie",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Злонамерна акција која никако није у вези са ситуацијом у игри",
                            PhraseZhHk = "有預謀或惡意的動作，而這行為與比賽並無關連",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "There is a throw-off for WHITE team. The referee has given the whistle signal, and WHITE 9 is ready to execute the throw-off. After the whistle signal, WHITE 3 crosses the centre line and is pulled down from behind by BLACK 5 in a way he totally loses body control. Correct decision?",
                    PhraseNl =
                        "Beginworp voor team WIT. De scheidsrechters hebben aangefloten en WIT9 is klaar om de beginworp uit te voeren. Na het fluitsignaal, overschrijdt WIT3 loopt de middellijn en wordt langs achter neergetrokken door ZWART5 zodat hij de lichaamscontrole verliest. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Почетно бацање за БЕЛУ екипу. Судија је дао звучни сигнал и лопта још увек није напустила руку извођача БЕЛОГ 9. Након звучног сигнала, БЕЛИ 3 трчи преко средишње линије и бива оборен с леђа од стране ЦРНОГ 5 и тотално губи контролу над телом. Исправна одлука?",
                    PhraseZhHk = "比賽至最後一分鐘，由白隊開球，裁判鳴哨後，當球還沒有離開擲球球員的手前，隊友白隊3號就跑過了中線，但被他身後的黑隊5號拉倒，並完全失去平衡。如何處理？",
                    QuestionNumber = "8.34",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 5",
                            PhraseNl = "2-minuten uitsluiting voor ZWART5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 5",
                            PhraseZhHk = "黑隊5號退場兩分鐘",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 5 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART5, zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација без писаног извештаја ЦРНОГ 5 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消黑隊5號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-off for WHITE team",
                            PhraseNl = "Beginworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Почетно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊開球",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 5, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART5, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација са писаним извештајем ЦРНОГ 5 (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消黑隊5號比賽資格，提交書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "f"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 8 has received a 2-minute suspension because of a faulty substitution. Two seconds after the game has been restarted, he makes a comment to the referees in an unsportsmanlike manner from his position on the bench. Correct decision?",
                    PhraseNl =
                        "ZWART8 heeft 2-minuten uitsluiting gekregen voor een foutieve wissel. Twee seconden nadat het spel hernomen werd, geeft hij commentaar op de scheidsrechters op een onsportieve wijze vanaf zijn positie op de bank. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНИ 8 је добио 2 минута искључења због погрешне замене. Две секунде после наставка игре, он протестује на неспортски начин, против судија, са клупе за резервне играче. Исправна одлука?",
                    PhraseZhHk = "黑隊8號因替補犯規被罰退場兩分鐘，在比賽恢復兩秒後，他在替補席上以不君子行為的方式批評裁判。如何判決?",
                    QuestionNumber = "8.35",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Additional 2-minute suspension for BLACK 8",
                            PhraseNl = "Een bijkomende 2-minuten uitsluiting voor ZWART8",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Додатна 2 минута искључења за ЦРНОГ 8",
                            PhraseZhHk = "黑隊8號再被罰退場兩分鐘",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 8 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor ZWART8 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација без писаног извештаја за ЦРНОГ 8 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消黑隊8號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "BLACK team will be reduced by 2 players on the court for the next 1 minute and 58 seconds and then by 1 player on the court for 2 seconds.",
                            PhraseNl =
                                "Team ZWART zal gereduceerd worden met 2 spelers op het speelveld voor de volgende 1’58” en daarna met 1 speler op het speelveld voor 2 seconden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "ЦРНА екипа ће бити редукована за два играча на терену за наредних 1 минут и 58 секунди, а затим за једног играча на терену на две секунде",
                            PhraseZhHk = "黑隊場內減少兩人比賽1分58秒，減少一人比賽2秒",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK team will be reduced by 2 players on the court for the next 2 minutes.",
                            PhraseNl =
                                "Team ZWART zal gereduceerd worden met twee spelers op het speelveld voor de volgende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "ЦРНА екипа ће бити редукована за два играча на терену за два наредна минута",
                            PhraseZhHk = "黑隊場內減少兩人比賽2分鐘",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 1 throws a long pass to WHITE 15, who is running alone towards the opponents’ goal. Goalkeeper BLACK 12 leaves his goal area, jumps up, catches the ball and collides with WHITE 15 while in the air. Both players fall to the ground and lie there injured. Correct decision?",
                    PhraseNl =
                        "Doelverdediger WIT1 werpt een lange pass naar WIT15, die alleen op het doel van de tegenstrever af loopt. Doelverdediger ZWART12 verlaat zijn doelgebied, springt op, vangt de bal en botst terwijl hij in de lucht is met WIT15. Beide spelers vallen op de grond en blijven gekwetst liggen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман БЕЛИ 1 упућује дугачко додавање према саиграчу БЕЛОМ 15, који трчи сам према противничком голу. Голман ЦРНИ 12 напушта свој голманов простор, скаче, хвата лопту и судари се са БЕЛИМ 15 док је у ваздуху. Оба играча падну на под и леже повређени. Исправна одлука?",
                    PhraseZhHk = "白隊守門員1號長傳給正在跑向對隊龍門的隊友白隊15號，黑隊守門員12號離開禁區，跳起在空中截取傳球並與白隊15號發生碰撞後雙雙倒地，如何判決？",
                    QuestionNumber = "8.36",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out, 2-minute suspension for WHITE 15",
                            PhraseNl = "Time-out, 2-minuten uitsluiting voor WIT15",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут, 2 минута искључења БЕЛОГ 15",
                            PhraseZhHk = "暫停，白隊15號被判退場兩分鐘",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out, 2-minute suspension for BLACK 12",
                            PhraseNl = "Time-out, 2-minuten uitsluiting voor ZWART12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут, 2 минута искључења ЦРНОГ 12",
                            PhraseZhHk = "暫停，黑隊12號被判退場兩分鐘",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out, disqualification for BLACK 12",
                            PhraseNl = "Time-out, diskwalificatie voor ZWART12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут, дисквалификација ЦРНОГ 12",
                            PhraseZhHk = "暫停，取消黑隊12號比賽資格",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK team is in possession of the ball. The delegate interrupts the game because official A from BLACK team has thrown a chair onto the court in protest at a referee decision. There were no previous punishments given to the team officials from BLACK team. BLACK 7 had a clear chance of scoring, when the game was interrupted. Correct decision?",
                    PhraseNl =
                        "Team ZWART heeft balbezit. De waarnemer onderbreekt het spel omdat official A van team ZWART een stoel op het speelveld heeft gegooid als protest tegen een beslissing van de scheidsrechter. Voordien was er nog geen bestraffing geweest tegen de teamofficials van team ZWART. ZWART 7 had een duidelijke scorekans toen het spel werd onderbroken. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНА екипа има лопту у поседу. Делегат прекида игру, јер је званичник А ЦРНЕ екипе бацио столицу у поље за игру, протестујући против одлуке судија. Претходно није било кажњавања званичника ЦРНЕ екипе. ЦРНИ 7 је у јасној ситуацији за постизање гола, када је игра прекинута. Исправна одлука?",
                    PhraseZhHk = "黑隊持球時， 黑隊球隊職員A將椅子掉進場內以表示抗議裁判的判決；故此，技術代表中斷了比賽。在此之前，黑隊球隊職員沒有被判罰過，而比賽中斷時黑隊7號有明顯的得分機會。如何判決？",
                    QuestionNumber = "8.37",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for official A from BLACK team",
                            PhraseNl = "Waarschuwing voor official A van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за званичника А ЦРНЕ екипе",
                            PhraseZhHk = "警告黑隊球隊職員A",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for official A from BLACK team",
                            PhraseNl = "2-minuten uitsluiting official A van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против званичника А ЦРНЕ екипе",
                            PhraseZhHk = "黑隊球隊職員A被判退場兩分鐘",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of official A from BLACK team without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor official A van team ZWART zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација без писаног извештаја за званичника А ЦРНЕ екипе (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消黑隊球隊職員A比賽資格（裁判出示紅牌）", 
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7-meter-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of official A from BLACK team, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor official A van team ZWART, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација са писанимизвештајем за званичника А ЦРНЕ екипе (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消黑隊球隊職員A比賽資格，提交書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Official A from WHITE team protests loudly at a referee decision against his team and states: “You are idiots!” Ten minutes earlier, official C from WHITE team has already received a warning. Correct decision?",
                    PhraseNl =
                        "Official A van team WIT protesteert met luid stem op een beslissing van de scheidsrechters tegen zijn team en schreeuwt “jullie zijn idioten”. 10 minuten eerder heeft official C van team WIT al een verwittiging gekregen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Званичник А БЕЛЕ екипе жучно протестује против одлуке судије против његове екипе, и изјављује: ''Ви сте идиоти''. Званичник Ц БЕЛЕ екипе већ је добио опомену 10 минута раније. Исправна одлука?",
                    PhraseZhHk = "白隊球隊職員A大大聲抗議裁判的判決，並說“你正一白痴”。白隊球隊職員C在十分鐘前已被警告。如何判決？",
                    QuestionNumber = "8.38",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for official A from WHITE team due to unsportsmanlike conduct",
                            PhraseNl = "Verwittiging van official A van team WIT wegens onsportief gedrag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за званичника А БЕЛЕ екипе због нестортског понашања",
                            PhraseZhHk = "警告白隊球隊職員A因其不君子行為",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for official A from WHITE team; WHITE team is reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "2-minuten uitsluiting voor official A van team WIT; team WIT wordt met 1 speler op het speelveld gereduceerd gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "2 минута искључења за званичника А БЕЛЕ екипе; БЕЛА екипа се на терену редукује 2 минута за једног играча",
                            PhraseZhHk = "白隊球隊職員A退場兩分鐘，白隊場內減少1名球員2分鐘",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of official A from WHITE team, written report (red and blue cards shown by the referees); WHITE team is reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "Diskwalificatie van official A van team WIT, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters). Team WIT wordt met 1 speler op het speelveld gereduceerd gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација званичника А БЕЛЕ екипе са писаним извештајем (црвени и плави картон показани од стране судија), једног играча",
                            PhraseZhHk = "取消白隊球隊職員A比賽資格，白隊場內減少1名球員2分鐘，提交書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 1 wants to carry out a goalkeeper throw. For the second time, BLACK 3 now enters the goal area and tries to prevent WHITE 1 from executing the throw without body contact with him. Correct decision?",
                    PhraseNl =
                        "Doelverdediger WIT1 wil een uitworp uitvoeren. Voor de tweede maal betreedt ZWART3 nu het doelgebied en probeert, zonder lichaamscontact, deze uitworp te hinderen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман БЕЛИ 1 жели да изведе голманово бацање. ЦРНИ 3 по други пут улази у голманов простор и покушава да спречи голмана БЕЛОГ 1 да изведе бацање, али без контакта са њим. Исправна одлука?",
                    PhraseZhHk = "白隊守門員1號準備擲守門員球，黑隊3號進入禁區內試圖阻止白隊1號擲守門員球，但沒有造成身體接觸，這是他第二次做出同一動作。如何判決？",
                    QuestionNumber = "8.39",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team after whistle signal",
                            PhraseNl = "Uitworp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипуе после звучног сигнала",
                            PhraseZhHk = "鳴哨後白隊擲守門員球",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 3",
                            PhraseNl = "Waarschuwing voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за ЦРНОГ 3",
                            PhraseZhHk = "警告黑隊3號",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 3",
                            PhraseNl = "2-minuten uitsluiting voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против ЦРНОГ 3",
                            PhraseZhHk = "黑隊3號退場兩分鐘",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 4 touches the ball that is rolling on the floor in the goal area of BLACK team. At this moment, he is pushed to the floor by BLACK 6. Correct decision?",
                    PhraseNl =
                        "WIT4 raakt de in het doelgebied van de team ZWART rollende bal. Op dat ogenblik wordt hij op de grond geduwd door ZWART6. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 4 додирује лопту која се котрља по поду голмановог простора ЦРНЕ екипе. У следећем тренутку он је гурнут на под од стране ЦРНОГ 6. Исправна одлука?",
                    PhraseZhHk = "白隊4號觸及在黑隊禁區地面上滾動的球，接着他被黑隊6號推倒在地上。如何判決？",
                    QuestionNumber = "8.40",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for BLACK 6",
                            PhraseNl = "Progressieve bestraffing van ZWART6",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против ЦРНОГ 6",
                            PhraseZhHk = "漸進處罰黑隊6號",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊守門員球",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 7 has just received a 2-minute suspension for unsportsmanlike conduct. This is his first suspension. Ten seconds after the game has been restarted, he makes strong gestures on the bench to show that he does not agree with the referees. Correct decision?",
                    PhraseNl =
                        "WIT7 heeft net een 2-minuten uitsluiting gekregen voor onsportief gedrag. Het is zijn eerste uitsluiting. 10 seconden nadat het spel hernomen werd maakt hij van op de bank met hevige gebaren duidelijk dat hij het niet eens is met de beslissing van de scheidsrechter. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 7 је управо добио 2 минута искључења због неспортског понашања. Ово је његово прво искључење. Десет секунди након што је утакмица настављена, он енергично гестикулира на клупи, и даље показујући да се не слаже са судијама. Исправна одлука?",
                    PhraseZhHk = "白隊7號因犯不君子行為第一次被罰退場兩分鐘，在比賽恢復後，他在替補席上以強烈的手勢來表示對裁判判罰的不滿。如何判決？",
                    QuestionNumber = "8.41",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 7 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor WIT7 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација без писаног извештаја за БЕЛОГ 7 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消白隊7號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for WHITE 7; WHITE 7 must remain on the bench for four minutes",
                            PhraseNl =
                                "2-minuten uitsluiting voor WIT7; WIT7 moet gedurende 4 minuten op de bank blijven",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 7; БЕЛИ 7 мора остати на клупи 4 минута",
                            PhraseZhHk = "白隊7號退場兩分鐘，必須留在替補席上四分鐘",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Additional 2-minute suspension for WHITE 7; WHITE team will be reduced by 2 players on the court for 1 minute and 50 seconds and then by 1 player on the court for 10 seconds.",
                            PhraseNl =
                                "Een bijkomende 2-minuten uitsluiting voor WIT7, team WIT moet met 2 spelers gereduceerd worden op het speelveld gedurende 1’50”, en daarna met 1 speler op het speelveld gedurende 10 seconden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "БЕЛИ 7 добија додатна 2 минута искључења; БЕЛА екипа ће бити редукована за два играча у пољу за игру за 1 минут и 50 секунди, а затим за једног играча у пољу за игру за 10 секунди",
                            PhraseZhHk = "白隊7號再罰退場兩分鐘。白隊場內減少2名球員1分50秒，然後減少1名球員10秒",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Warning because the progressive punishment on the bench is separate from the punishments on the court",
                            PhraseNl =
                                "Waarschuwing, aangezien de progressieve bestraffing op de bank gescheiden is van de progressieve bestraffingen op het speelveld",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена, зато што је кажњавање на клупи одвојено од кажњавања на терену",
                            PhraseZhHk = "警告，因為替補席上的漸進處罰有別於場內的處罰",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 6 is pushed by BLACK 3 and spits demonstratively on the floor in front of BLACK 3. How shall WHITE 6 be punished?",
                    PhraseNl =
                        "WIT6 wordt door ZWART3 geduwd; daarna spuwt WIT6 demonstratief op de grond voor ZWART3. Hoe moet WIT6 bestraft worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 6 је гурнут од стране ЦРНОГ 3, а овај демостративно пљуне на под испред ЦРНОГ 3. Како ће БЕЛИ 6 бити кажњен?",
                    PhraseZhHk = "黑隊3號推白隊6號，白隊6號憤怒地向黑隊3號面前的地板上吐口水。如何處罰白隊6號？",
                    QuestionNumber = "8.42",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment",
                            PhraseNl = "Progressieve bestraffing",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна",
                            PhraseZhHk = "漸進處罰",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Always with a 2-minute suspension",
                            PhraseNl = "Altijd met 2-minuten uitsluiting",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Увек са 2 минута искључења",
                            PhraseZhHk = "通常判罰退場兩分鐘",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација без писаног извештаја (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消白隊6號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација за писаним извештајем (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消白隊6號比賽資格，提交書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 12 runs from the goal area towards BLACK 10, who is counter-attacking. WHITE 12 approaches BLACK 10 from the side and holds on to him, but BLACK 10 is able to catch the ball to throw it into the empty goal. Correct decision?",
                    PhraseNl =
                        "Doelverdediger WIT12 loopt uit zijn doelgebied naar de in tegenaanval zijnde speler ZWART10. WIT12 nadert ZWART10 zijdelings en houdt hem vast, maar ZWART10 kan de bal vangen en deze in het lege doel werpt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман БЕЛИ 12 трчи из голмановог простора према ЦРНОМ 10 који је у контранападу. БЕЛИ 12 прилази ЦРНОМ 10 са стране и хвата га, али ЦРНИ 10 хвата лопту и упути шут у празан гол. Исправна одлука?",
                    PhraseZhHk = "白隊守門員12號跑向正在進行反擊的黑隊10號，白隊12號走近並從側邊抱住黑隊10號，但黑隊10號仍能接住球及射進空門，如何判決？",
                    QuestionNumber = "8.43",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Throw-off",
                            PhraseNl = "Beginworp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Почетно бацање",
                            PhraseZhHk = "開球",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм - аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification of WHITE 12",
                            PhraseNl = "Diskwalificatie voor WIT12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација БЕЛОГ 12",
                            PhraseZhHk = "取消白隊12號比賽資格",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 12",
                            PhraseNl = "2-minuten uitsluiting voor WIT12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута исккључења против БЕЛОГ 12",
                            PhraseZhHk = "白隊12號退場兩分鐘",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 12 executes a goalkeeper throw, playing a long pass in the direction of his teammate WHITE 4, who is running in a counter-attack. WHITE 4 jumps to receive the ball and immediately after this, he collides with goalkeeper BLACK 1, who has decided to leave his goal area in an attempt to stop the counter-attack. At the time of the collision, BLACK 1 stands completely still in front of the 9-metre line. After the collision, WHITE 4 loses his body control and falls to the floor. Correct decision?",
                    PhraseNl =
                        "Doelverdediger WIT12 voert de uitworp uit met een lange bal naar de in tegenaanval lopende medespeler WIT4. WIT4 springt omhoog om de bal te pakken en onmiddellijk daarna botst hij met de doelverdediger ZWART1, die besliste om zijn doelgebied te verlaten in een poging om de tegenaanval te verhinderen. Op het ogenblik van de botsing, staat ZWART1 volledig stil aan de 9m lijn. Na de botsing verliest WIT4 de lichaamscontrole en valt op de grond. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман БЕЛИ 16 изводи голманово бацање, упутивши дугачко додавање према саиграчу БЕЛОМ 4, који трчи у контранапад. БЕЛИ 4 скаче да ухвати лопту и одмах након тога се судари са голманом ЦРНИМ 1, који је одлучио да напусти свој голманов простор у покушају да заустави контранапад. У тренутку судара ЦРНИ 1 је стајао потпуно мирно испред линије 9 метара. После судара, БЕЛИ 4 изгуби контролу над телом и пада на под. Исправна одлука?",
                    PhraseZhHk = "白隊守門員12號長傳給白隊4號進行快擊反攻。白隊4號跳起後把球接住，黑隊守門員1號離開禁區試圖阻止其快攻。黑隊守門員1號隨即與白隊4號發生碰撞，白隊4號失去平衡倒地。與此同時，白隊4號站在九米線的前方。如何判決？",
                    QuestionNumber = "8.44",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Offensive foul, free throw for BLACK team",
                            PhraseNl = "Aanvallende fout, vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прекршај у нападу – слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "進攻犯規，黑隊自由球",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for BLACK 1",
                            PhraseNl = "Progressieve bestraffing voor ZWART1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против ЦРНОГ 1",
                            PhraseZhHk = "漸進處罰黑隊1號",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 1 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART1 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација без писаног извештаја за ЦРНОГ 1 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消黑隊1號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Which of the following infractions must be punished with a disqualification with written report according to the rules (red and blue cards shown by the referees)?",
                    PhraseNl =
                        "Welke van de volgende overtredingen moeten overeenkomstig de spelregels bestraft worden met een diskwalificatie en schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Који од наведених прекршаја мора бити кажњен дисквалификацијом са писаним извештајем, у складу са правилима (црвени и плави картон показани од стране судија)?",
                    PhraseZhHk = "根據球例，下列那種情况必須判罰取消比賽資格及提交書面報告（裁判出示紅牌及藍牌）？",
                    QuestionNumber = "8.45",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "A player spitting on an opponent",
                            PhraseNl = "Een speler bespuwt een tegenstrever",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Играч пљуне ка противнику и погоди га",
                            PhraseZhHk = "球員攻擊對隊球員或吐口水",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "An official trying to force his team to abandon the game",
                            PhraseNl = "Een official probeert zijn team te dwingen om de wedstrijd af te breken",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Званичник покушава да повуче екипу са терена",
                            PhraseZhHk = "球隊職員試圖強迫球隊放棄比賽",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "A 7-metre shooter hitting the goalkeeper’s head, with the goalkeeper not moving his head in the direction of the ball",
                            PhraseNl =
                                "Wanneer een 7m werper het hoofd van de doelverdediger raakt, waarbij de doelverdediger zijn hoofd niet richting bal beweegt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Извођач седмерца погоди голмана у главу, а да голман притом није померао главу у правцу лопте",
                            PhraseZhHk = "擲七米球時，球擊中沒有移動的守門員臉部",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After a referee decision, a player throws the ball demonstratively into the stands.",
                            PhraseNl =
                                "Na een beslissing van de scheidsrechters werpt een speler de bal demonstratief in de tribune.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "После судијске одлуке, играч демонстративно баци лопту на трибине",
                            PhraseZhHk = "裁判判决後，球員明顯不滿地把球扔向觀眾席",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "A player outside the playing court spitting on a spectator",
                            PhraseNl = "Een speler bespuwt buiten het speeloppervlak een toeschouwer",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Играч изван поља за игру пљуне гледаоца, тако да га погоди",
                            PhraseZhHk = "球員在場外向觀眾席吐口水，並吐中觀眾",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "A player intentionally hitting an opponent in the stomach",
                            PhraseNl = "Een speler slaat opzettelijk een tegenspeler in de maag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Играч намерно удара противника у стомак",
                            PhraseZhHk = "故意攻擊對隊球員的胃部",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The playing time is 59:26. Player BLACK 10 is running alone in a counter-attack. When he receives the ball from a teammate, BLACK 10 collides with goalkeeper WHITE 1, who has left the goal area, but before falling down he is able to pass the ball to BLACK 7, who shoots at the empty goal, but the ball goes wide. When the referees order a time-out, the playing time is 59:31. Correct decision?",
                    PhraseNl =
                        "Wedstrijdtijd is 59:26. Speler ZWART10 loopt alleen in tegenaanval. Wanneer hij de bal krijgt van een ploegmaat, botst ZWART10 met doelman WIT1 die zijn doelgebied verlaten heeft, maar alvorens neer te vallen slaagt hij erin om de bal naar ZWART7 te spelen die naar een leeg doel kan werpen, maar de bal gaat naast het doel. Wanneer de scheidsrechters een time-out geven staat de klok op 59:31. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Време игре 59:26. ЦРНИ 10 трчи сам у контранапад. Када добије лопту од саиграча, ЦРНИ 10 се судари са голманом БЕЛИМ 1 који је напустио голманов простор. Пре него што падне, ЦРНИ 10 успева да дода лопту ЦРНОМ 7 који шутира на празан гол, али промашује. Када судије дају тајм-аут време игре је 59:31. Исправна одлука?",
                    PhraseZhHk = "比賽進行到59:26。黑隊10號快速反擊。當他從隊友那裡接到球時，黑隊10號和已經離開禁區的白隊守門員1號相撞，但在倒下之前他將球傳給黑隊7號，黑隊7號射向空門但球沒有射入。當裁判要求暫停時，比賽時間是59:31。如何判決？",
                    QuestionNumber = "8.46",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw",
                            PhraseNl = "Vrije worp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање",
                            PhraseZhHk = "自由球",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw",
                            PhraseNl = "7m-worp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац",
                            PhraseZhHk = "七米球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Red card for WHITE 1",
                            PhraseNl = "Rode kaart voor WIT1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Црвени картон за БЕЛОГ 1",
                            PhraseZhHk = "白隊1號紅牌",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Blue card for WHITE 1",
                            PhraseNl = "Blauwe kaart voor WIT1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Плави картон за БЕЛОГ 1",
                            PhraseZhHk = "白隊1號藍牌",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw",
                            PhraseNl = "Uitworp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање",
                            PhraseZhHk = "守門員球",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in attack and plays with seven court players. BLACK 5 intercepts a pass and gets possession of the ball. He immediately tries to take a shot on goal. WHITE 2 tries to prevent BLACK 5 from taking a shot on goal by trying to play the ball out of his hand. By doing so, he hits BLACK 5’s forearm, and the ball misses the goal. Earlier in the match, WHITE team has received three warnings. Correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt met 7 veldspelers. ZWART5 onderschept een pas en komt in balbezit. Hij probeert onmiddellijk een worp naar doel te doen. WIT2 tracht te verhinderen dat ZWART5 naar doel kan werpen door de bal uit zijn hand te spelen? Hierbij raakt hij de onderarm van ZWART5 en de bal mist het doel. Team WIT heeft eerder in de wedstrijd 3 waarschuwingen gekregen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛА екипа је у нападу са 7 играча. ЦРНИ 5 пресеца додавање и има лопту у поседу. Он тренутно покуша да шутне на гол, БЕЛИ 2 покушава да га спречи у томе, покушавајући да узме лопту из његове руке. Чинећи то он удари ЦРНОГ 5 у подлактицу, тако да лопта промаши гол. БЕЛА екипа је раније већ добила 3 опомене. Исправна одлука?",
                    PhraseZhHk = "白隊使用七名場內球員進攻，黑隊5號攔截了一個傳球並立即射門。白隊2號試圖將球從黑隊5號的手中打走以阻止他射門，結果他擊中了黑隊5號的前臂，球沒有射入。白隊再之前已經收到了三次警告。如何判決？",
                    QuestionNumber = "8.47",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊守門員球",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 2",
                            PhraseNl = "2-minuten uitsluiting voor WIT2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 2",
                            PhraseZhHk = "白隊2號退場兩分鐘",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in attack and plays with seven court players. BLACK 5 intercepts a pass and gets possession of the ball. He immediately tries to take a shot on goal. WHITE 2 tries to prevent BLACK 5 from taking a shot on goal by pulling him down. The ball misses the goal. Correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt met 7 veldspelers. ZWART5 onderschept een pas en komt in balbezit. Hij probeert onmiddellijk een worp naar doel te doen. WIT2 probeert te verhinderen dat ZWART5 naar doel kan werpen door hem neer te trekken. De bal mist het doel. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛА екипа је у нападу са 7 играча. ЦРНИ 5 пресеца додавање и има лопту у поседу. Он тренутно покуша да шутне на гол, БЕЛИ 2 покушава да га спречи у томе, обарајући га. Лопта промаши гол. Исправна одлука?",
                    PhraseZhHk = "白隊使用七名場內球員進攻，黑隊5號攔截了一個傳球並立即射門。白隊2號從後拉倒黑隊5號來阻止他射門，結果球沒有射入。如何判決？",
                    QuestionNumber = "8.48",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊守門員球",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 2",
                            PhraseNl = "2-minuten uitsluiting voor WIT2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 2",
                            PhraseZhHk = "白隊2號退場兩分鐘",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in attack and plays with seven court players. WHITE 4 takes a shot on goal, but the ball is saved by goalkeeper BLACK 1. BLACK 1 passes the ball to BLACK 9. Just as goalkeeper WHITE 12 enters his goal area, BLACK 9 tries to take a shot on goal, but he is prevented by a foul from WHITE 2. The ball passes the outer goal line. Correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt met 7 veldspelers. WIT4 werpt naar doel, maar de bal wordt gered door doelman ZWART1. ZWART1 speelt de bal naar ZWART9. Net als doelman WIT12 in zijn doelgebied komt, tracht ZWART9 een worp naar doel te doen, maar dit wordt verhinderd door een fout van WIT2. De bal gaat over de buitendoellijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛА екипа је у нападу са 7 играча. БЕЛИ 4 шутира на гол, али је голман ЦРНИ 1 одбранио шут. ЦРНИ 1 додаје лопту ЦРНОМ 9. Баш када је голман БЕЛИ 12 ушао у свој голманов простор, ЦРНИ 9 покуша да шутира на гол, у чему га прекршајем спречи БЕЛИ 2. Лопта одлази преко гол-аут линије. Исправна одлука?",
                    PhraseZhHk = "白隊使用七名場內球員進攻，白隊4號射門被黑隊守門員1號擋出。黑隊1號將球傳給黑隊9號。此時白隊守門員12號進入禁區，黑隊9號準備射門時被白隊2號犯規阻止，球越過了外球門線。如何判決？",
                    QuestionNumber = "8.49",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊守門員球",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "c"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in attack and plays with seven court players. WHITE 4 takes a shot on goal, but the ball is saved by goalkeeper BLACK 1, who is standing with the ball in his goal area ready to execute the goalkeeper throw. At that moment, the delegate interrupts the game because of a faulty substitution, as goalkeeper WHITE 1 entered the court before WHITE 7 has left it. Correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt met 7 veldspelers. WIT4 werpt naar doel, maar de bal wordt gered door doelman ZWART1, die met de bal in zijn doelgebied staat, klaar om de uitworp uit te voeren. Op dat ogenblik onderbreekt de waarnemer het spel omwille van een foutieve wissel, omdat doelman WIT1 het speelveld betrad, vooraleer WIT7 het verlaten had. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛА екипа је у нападу са 7 играча. БЕЛИ 4 шутира на гол, али је голман ЦРНИ 1 одбранио шут и стоји са лоптом у свом голмановом простору, спреман да изведе голманово бацање. У том моменту делегат прекида игру, због погрешне замене, јер је голман БЕЛИ 1 ушао на терен пре него што га је БЕЛИ 7 напустио. Исправна одлука?",
                    PhraseZhHk = "白隊使用七名場內球員進攻，白隊4號射門被黑隊守門員1號擋出，黑隊1號站在禁區內準備擲守門員球。此時，因為白隊1號在白隊7號離開場地之前進入場地，技術代表中斷比賽。如何判決？",
                    QuestionNumber = "8.50",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for BLACK team after whistle signal",
                            PhraseNl = "Uitworp voor team ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за ЦРНУ екипу после звучног сигнала",
                            PhraseZhHk = "鳴哨後黑隊守門員球",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 1",
                            PhraseNl = "2-minuten uitsluiting voor WIT1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 1",
                            PhraseZhHk = "白隊1號退場兩分鐘",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 7",
                            PhraseNl = "2-minuten uitsluiting voor WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 7",
                            PhraseZhHk = "白隊7號退場兩分鐘",
                            AnswerNumber = "f"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in attack and plays with seven court players. WHITE 4 takes a shot on goal, but the ball is saved by goalkeeper BLACK 12. BLACK 12 passes the ball to BLACK 9. BLACK 9 takes a shot on goal. Court player WHITE 10 enters his own goal area and manages to save the ball. The ball passes the outer goal line. Correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt met 7 veldspelers. WIT4 werpt naar doel, maar de bal wordt gered door doelman ZWART12. ZWART12 speelt de bal naar ZWART9. ZWART9 werpt naar doel. Veldspeler WIT10 betreedt zijn eigen doelgebied en slaagt erin om de bal te redden. De bal gaat over de buitendoellijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛА екипа је у нападу са 7 играча. БЕЛИ 4 шутира на гол, али је голман ЦРНИ 12 одбранио шут. ЦРНИ 12 додаје ЦРНОМ 9 који шутира на гол. Играч у пољу БЕЛИ 10 уђе у свој голманов простор и успе да одбрани шут. Лопта одлази преко гол-аут линије. Исправна одлука?",
                    PhraseZhHk = "白隊使用七名場內球員進攻，白隊4號射門被黑隊守門員12號擋出，黑隊12號將球傳給黑隊9號，黑隊9號射門。白隊場內球員10號進入禁區擋球，球越過了外球門線。如何判決？",
                    QuestionNumber = "8.51",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Throw-in for BLACK team",
                            PhraseNl = "Inworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут за ЦРНУ екипу",
                            PhraseZhHk = "黑隊界外球",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for WHITE 10",
                            PhraseNl = "Progressieve bestraffing voor WIT10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против БЕЛОГ 10",
                            PhraseZhHk = "漸進處罰白隊10號",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for WHITE 10",
                            PhraseNl = "Directe 2-minuten uitsluiting voor WIT10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за БЕЛОГ 10",
                            PhraseZhHk = "白隊10號退場兩分鐘",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in attack and plays with seven court players. WHITE 6 takes a shot on goal, but the ball is saved by goalkeeper BLACK 1. BLACK 1 immediately tries to score in the empty goal, but he misses the goal, and the ball passes the outer goal line. Correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt met 7 veldspelers. WIT6 werpt naar doel, maar de bal wordt gered door de doelman ZWART1. ZWART1 probeert onmiddellijk in het lege doel te scoren, maar hij mist het doel, en de bal gaat over de buitendoellijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛА екипа је у нападу са 7 играча. БЕЛИ 6 шутира на гол, али је голман ЦРНИ 1 одбранио шут. ЦРНИ 1 тренутно покуша да погоди празан гол, али лопта промаши гол и одлази преко гол-аут линије. Исправна одлука?",
                    PhraseZhHk = "白隊使用七名場內球員進攻，白隊6號射門被黑隊守門員1號擋出，黑隊1號立即嘗試射空門，但球沒有射入，並越過了外球門線。如何判決？",
                    QuestionNumber = "8.52",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊守門員球",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The goalkeeper throw may be executed by any player on the court from WHITE team to keep the flow in the game.",
                            PhraseNl =
                                "De uitworp mag uitgevoerd worden door om het even welke speler van team WIT op het speelveld om het spel vlot te houden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Голманово бацање може извести неки од играча БЕЛЕ екипе у пољу, да би се задржао ток игре",
                            PhraseZhHk = "白隊任何一名場內球員都可以擲守門員球，以保持比賽的流暢性",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE team has to make a substitution to get a goalkeeper on the court to execute the goalkeeper throw.",
                            PhraseNl =
                                " Team WIT moet een wissel doen om een doelman in het speelveld te krijgen om de uitworp uit te voeren.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "БЕЛА екипа мора направити замену да би голман ушао на терен и извео голманово бацање",
                            PhraseZhHk = "白隊必須替補守門員擲守門員球",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out is obligatory",
                            PhraseNl = "Verplichte Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут је обавезан",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK team is playing with seven court players. BLACK 5 takes a shot on goal, but the shot is saved by goalkeeper WHITE 1. WHITE 1 tries to score in the empty goal. At the same time, goalkeeper BLACK 12 makes a faulty substitution, as he runs onto the court before BLACK 7 has left it. The delegate immediately interrupts the game with a whistle signal. Just after the whistle signal from the delegate, the ball crosses the outer goal line of BLACK team. Correct decision?",
                    PhraseNl =
                        "Team ZWART speelt met 7 veldspelers. ZWART5 werpt naar doel, maar het schot wordt door doelman WIT1 gered. WIT1 probeert te scoren in het lege doel. Op hetzelfde ogenblik maakt doelman ZWART12 een foutieve wissel, omdat hij op het veld loopt nog vooraleer ZWART7 het verlaten heeft. De waarnemer onderbreekt onmiddellijk het spel met een fluitsignaal. Vlak na het fluitsignaal van de waarnemer, gaat de bal over de buitendoellijn van team ZWART. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНА екипа игра са 7 играча у пољу. ЦРНИ 5 шутира на гол, али је голман БЕЛИ 1 одрбанио шут. БЕЛИ 1 покуша да погоди празан гол. У исто време голман ЦРНИ 12 прави погрешну замену, ушавши на терен пре него што га је ЦРНИ 7 напустио. Делегат тренутно прекида игру звучним сигналом. Баш после звучног сигнала од стране делегата, лопта прелази гол-аут линију ЦРНЕ екипе. Исправна одлука?",
                    PhraseZhHk = "黑隊七名場內球員，黑隊5號射門被白隊守門員1號擋出，白隊1號嘗試射空門，此時黑隊守門員12號替補犯規，他在黑隊7號離開場地之前進入場地，技術代表鳴哨中斷比賽。在鳴哨之後，球越過了黑隊的外球門線。如何判決？",
                    QuestionNumber = "8.53",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 12",
                            PhraseNl = "2-minuten uitsluiting voor ZWART12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против ЦРНОГ 12",
                            PhraseZhHk = "黑隊12號退場兩分鐘",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 7",
                            PhraseNl = "2-minuten uitsluiting voor ZWART7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против ЦРНОГ 7",
                            PhraseZhHk = "黑隊7號退場兩分鐘",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊守門員球",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK team is playing with seven court players. BLACK 6 takes a shot on goal, but the shot is saved by goalkeeper WHITE 1. WHITE 1 tries to score in the empty goal. At the same time, goalkeeper BLACK 12 makes a faulty substitution, as he runs onto the court before BLACK 7 has left it. The delegate immediately interrupts the game with a whistle signal. Just after the whistle signal from the delegate, the ball crosses the goal line into the goal of BLACK team. Correct decision?",
                    PhraseNl =
                        "Team ZWART speelt met 7 veldspelers. ZWART6 werpt naar doel, maar het schot wordt door doelman WIT1 gered. WIT1 probeert te scoren in het lege doel. Op hetzelfde ogenblik maakt doelman ZWART12 een foutieve wissel, omdat hij het speelveld op loopt vooraleer ZWART7 dit heeft verlaten. De waarnemer onderbreekt onmiddellijk het spel met een fluitsignaal. Net na het fluitsignaal van de waarnemer, overschrijdt de bal de doellijn in het doel van team ZWART. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНА екипа игра са 7 играча у пољу. ЦРНИ 6 шутира на гол, али је голман БЕЛИ 1 одрбанио шут. БЕЛИ 1 покуша да погоди празан гол. У исто време голман ЦРНИ 12 прави погрешну замену, ушавши на терен пре него што га је ЦРНИ 7 напустио. Делегат тренутно прекида игру звучним сигналом. Баш после звучног сигнала од стране делегата, лопта прелази гол линију ЦРНЕ екипе и улази у гол. Исправна одлука?",
                    PhraseZhHk = "黑隊七名場內球員，黑隊6號射門被白隊守門員1號擋出，白隊1號嘗試射空門，此時黑隊守門員12號替補犯規，他在黑隊7號離開場地之前進入場地，技術代表鳴哨中斷比賽。在鳴哨之後，球越過了黑隊的球門線進入了球門。如何判決？",
                    QuestionNumber = "8.54",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 12",
                            PhraseNl = "2-minuten uitsluiting voor ZWART12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против ЦРНОГ 12",
                            PhraseZhHk = "黑隊12號退場兩分鐘",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 7",
                            PhraseNl = "2-minuten uitsluiting voor ZWART7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против ЦРНОГ 7",
                            PhraseZhHk = "黑隊7號退場兩分鐘",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal for WHITE team",
                            PhraseNl = "Doelpunt voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за БЕЛУ екипу",
                            PhraseZhHk = "白隊進球",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK team is playing with seven court players. WHITE 9 intercepts the ball and manages to score in the empty goal. The ball gets to rest in the goal area. Correct decision?",
                    PhraseNl =
                        "Team zwart speelt met 7 veldspelers. WIT9 onderschept de bal en slaagt erin om te scoren in het lege doel. De bal blijft in het doelgebied liggen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНА екипа игра са 7 играча у пољу. БЕЛИ 9 пресеца додавање, хвата лопту и успе да погоди празан гол. Лопта остаје у голмановом простору. Исправна одлука?",
                    PhraseZhHk = "黑隊使用七名場內球員，白隊9號攔截了球並射入空門，球停在了禁區內。如何判決？",
                    QuestionNumber = "8.55",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal and throw-off for BLACK team",
                            PhraseNl = "Doelpunt en beginworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол и почетно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊得分，開球",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "A goalkeeper must enter the court under a correct substitution to get the ball in the goal area.",
                            PhraseNl =
                                "Een doelman moet op het speelveld komen via een correcte wissel om de bal in het doelgebied te halen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Голман мора ући у поље за игру исправном заменом, да би узео лопту из голмановог простора",
                            PhraseZhHk = "守門員必須正確替補以取回禁區內的球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The ball may be picked up by any court player from BLACK team.",
                            PhraseNl =
                                "De bal mag vrij opgehaald worden door gelijk welke speler op het speelveld van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Лопту може да узме било који играч ЦРНЕ екипе у пољу",
                            PhraseZhHk = "黑隊的任何場內球員都可以撿起球",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 27:27 with six seconds left in the match. WHITE team is in attack. WHITE 7 tries to pass the ball to pivot WHITE 3. BLACK 7 intercepts the ball. At that moment he is pulled down by WHITE 3. One second later the final signal from the public clock sounds to end the game. Correct decision?",
                    PhraseNl =
                        "De score is 27-27 met nog 6 seconden te spelen. Team WIT is in aanval. WIT7 probeert de bal naar pivot WIT3 te spelen. ZWART7 onderschept de bal. Op dat ogenblik wordt hij door WIT3 neergetrokken. Een seconde later weerklinkt het eindsignaal vanaf de muurklok om de wedstrijd te beëindigen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Резултат је 27:27, а остало је 6 секунди до краја утакмице. БЕЛА екипа је у нападу, БЕЛИ 7 покуша да дода лопту пивоту БЕЛОМ 3. ЦРНИ 7 ухвати лопту, у том моменту га обара БЕЛИ 3. Једну секунду касније звучни сигнал означава крај утакмице. Исправна одлука?",
                    PhraseZhHk = "比分為27:27，比賽時間尚餘6秒鐘，白隊進攻，白隊7號試圖將球傳給中鋒白隊3號，黑隊7號攔截了球，此時被白隊3號拉倒。一秒鐘後，自動結束訊號響了。如何判決？",
                    QuestionNumber = "8.56",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The game is over.",
                            PhraseNl = "De wedstrijd is afgelopen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра је завршена",
                            PhraseZhHk = "比賽結束",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 3",
                            PhraseNl = "2-minuten uitsluiting voor WIT3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 3",
                            PhraseZhHk = "白隊3號退場兩分鐘",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 3 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT3 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација БЕЛОГ 3 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消白隊3號資格（裁判出示紅牌）",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 3 with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie met schriftelijk verslag voor WIT3 (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација БЕЛОГ 3 са писаним извештајем (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消白隊3號資格，及作出書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "f"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 27:27 with ten seconds left in the match. WHITE team is in attack. BLACK 5 intercepts a pass and starts a counter-attack. A moment later he is attacked from behind by WHITE 11, who pushes him in a dangerous way, so that he loses body control. Before the referee whistles for the infraction, the final signal from the public clock sounds. Correct decision?",
                    PhraseNl =
                        "De score is 27-27 met nog 10 seconden te spelen. Team WIT is in aanval. ZWART5 onderschept een pas en start een tegenaanval. Een ogenblik later wordt hij langs achter aangevallen door WIT11, die hem op een gevaarlijke wijze duwt zodat hij zijn lichaamscontrole verliest. Vooraleer de scheidsrechters fluiten voor de overtreding, weerklinkt het eindsignaal van de wedstrijdklok. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Резултат је 27:27, а остало је 10 секунди до краја утакмице. БЕЛА екипа је у нападу, ЦРНИ 5 пресеца додавање и креће у контранапад. Тренутак касније БЕЛИ 11 га нападне са леђа, гурајући га на опасан начин, тако да он изгуби контролу над телом. Пре него што су судије свирале, огласи се завршни сигнал. Исправна одлука?",
                    PhraseZhHk = "比分為27:27，比賽時間尚餘10秒鐘，白隊進攻，黑隊5號攔截傳球並開始反擊，隨後被白隊11號從背後危險地推倒，導致他失去身體平衡，在裁判鳴哨之前，自動結束訊號響了。如何判決？",
                    QuestionNumber = "8.57",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The game is over.",
                            PhraseNl = "De wedstrijd is afgelopen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра је завршена",
                            PhraseZhHk = "比賽結束",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 11",
                            PhraseNl = "2-minuten uitsluiting voor WIT11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 11",
                            PhraseZhHk = "白隊11號退場兩分鐘",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 11 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT11 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација БЕЛОГ 11 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消白隊11號資格（裁判出示紅牌）",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 11 with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie met schriftelijk verslag voor WIT11 (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација БЕЛОГ 11 са писаним извештајем (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消白隊11號資格，及作出書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "f"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 10 is in possession of the ball. The time is 59:27 when he executes a jump shot. WHITE 2 pushes him so hard in the chest that he completely loses body control. He falls with the ball to the floor. The referee whistles, and the clock is stopped at 59:31. Correct decision?",
                    PhraseNl =
                        "ZWART10 is in balbezit. Het is 59:27 wanneer hij een sprongworp uitvoert. WIT2 duwt hem zo hard op de borst dat hij volledig de lichaamscontrole verliest. Hij valt met de bal op de vloer. De scheidsrechters fluiten en de klok wordt gestopt op 59:31. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНИ 10 има лопту у поседу. У 59:27 изводи скок-шут, а БЕЛИ 2 га гура у груди тако грубо да ЦРНИ 10 потпуно изгуби контролу над телом. Он пада са лоптом на под, судије свирају и заустављају сат на 59:31. Исправна одлука?",
                    PhraseZhHk = "黑隊10號控球，比賽時間59:27時他跳起射門，白隊2號重重地推了他胸部，導致他完全失去身體平衡，帶着球摔在地上，裁判鳴哨，時間停在59:31。如何判決？",
                    QuestionNumber = "8.58",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 2",
                            PhraseNl = "2-minuten uitsluiting voor WIT2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 2",
                            PhraseZhHk = "白隊2號退場兩分鐘",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 2 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT2 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација БЕЛОГ 2 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消白隊2號資格（裁判出示紅牌）",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "With 15 second left in the game, BLACK team is in possession of the ball. The referees give a free throw for BLACK team at the centre line. Before BLACK 7 is able to execute the free throw, he is blocked by WHITE 2. Correct decision?",
                    PhraseNl =
                        "Met nog 15 seconden te spelen, is team zwart in bezit van de bal. De scheidsrechters geven een vrije worp voor team ZWART aan de middenlijn. Vooraleer ZWART7 de vrije worp kan uitvoeren, wordt hij geblokt door WIT2. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Остало је још 15 секунди до краја утакмице, а ЦРНА екипа има лопту у поседу. Судије досуђују слободно бацање за ЦРНУ екипу на средишњој линији. ЦРНИ 7 може да изведе бацање, али је блокиран од стране БЕЛОГ 2. Ипсравна одлука?",
                    PhraseZhHk = "比賽時間尚餘15秒，黑隊控球。裁判在中線判了黑隊自由球。在黑隊7號能夠擲自由球之前，他被白隊2號阻擋。如何判決？",
                    QuestionNumber = "8.59",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Correction and a new free throw for BLACK team after whistle signal",
                            PhraseNl = "Correctie en een nieuwe vrije worp voor team ZWART na een fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Корекција и ново слободно бацање за ЦРНУ екипу после звучног сигнала",
                            PhraseZhHk = "更正，鳴哨後黑隊自由球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 2",
                            PhraseNl = "2-minuten uitsluiting voor WIT2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 2",
                            PhraseZhHk = "白隊2號退場兩分鐘",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 2 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT2 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација БЕЛОГ 2 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消白隊2號資格（裁判出示紅牌）",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 2 with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor WIT2, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација БЕЛОГ 2 са писаним извештајем (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消白隊2號資格，及作出書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "f"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK team is in attack. The referees give a free throw for BLACK team at the free-throw line with three seconds left in the match. BLACK 10 is in a correct position and ready to execute the free throw directly on the goal, but player WHITE 5, who is standing one metre from BLACK 10, blocks the shot on goal. Then the final signal sounds. Correct decision?",
                    PhraseNl =
                        "Team ZWART is in aanval. De scheidsrechters geven een vrije worp voor team ZWART aan de vrije worplijn met nog 3 seconden te spelen. ZWART10 is op de juiste plaats en klaar om de vrije worp uit te voeren direct naar doel, maar speler WIT5, die op 1 meter van ZWART10 staat, blokt de worp op doel. Dan weerklinkt het eindsignaal. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНА екипа је у нападу. Судије досуђују слободно бацање за ЦРНУ екипу са линије слободног бацања, 3 секунде пре краја утакмице. ЦРНИ 10 је у исправном положају и спреман да изведе слободно бацање директно на гол, али БЕЛИ 5, који стоји један метар од ЦРНОГ 10, блокира шут, а после блока се огласи завршни сигнал. Исправна одлука?",
                    PhraseZhHk = "黑隊進攻。裁判在比賽尚餘3秒時，判黑隊自由球。黑隊10號在正確的位置，準備直接擲自由球射門，被站在黑隊10號一米外的白隊5號阻擋了射門，隨後響起比賽結束訊號。如何判決？",
                    QuestionNumber = "8.60",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 5",
                            PhraseNl = "2-minuten uitsluiting voor WIT5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 5",
                            PhraseZhHk = "白隊5號退場兩分鐘",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 5 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT5 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација БЕЛОГ 5 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消白隊5號資格（裁判出示紅牌）",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team after whistle signal",
                            PhraseNl = "Vrije worp voor team ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу, после звучног сигнала",
                            PhraseZhHk = "鳴哨後黑隊自由球",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK team is in attack. The referees give a free throw for BLACK team at the free-throw line with three seconds left in the match. Player BLACK 10 is in a correct position to execute the free throw directly on the goal, but before he can take the shot, he is prevented by WHITE 5, who moves into a distance of one metre moving his arms and jumping in front of BLACK 10. Then the final signal sounds. Correct decision?",
                    PhraseNl =
                        "Team ZWART is in aanval. De scheidsrechters geven een vrije worp voor team ZWART aan de vrije worplijn met nog 3 seconden te spelen. ZWART10 is op de juiste plaats en klaar om de vrije worp uit te voeren direct naar doel, maar vooraleer hij de worp kan uitvoeren, wordt hij gehinderd door WIT5, die beweegt naar een afstand van 1m met zijn armen staat te wuiven en staat te springen voor ZWART10. Dan weerklinkt het eindsignaal. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНА екипа је у нападу. Судије досуђују слободно бацање за ЦРНУ екипу са линије слободног бацања, 3 секунде пре краја утакмице. ЦРНИ 10 је у исправном положају и спреман да изведе слободно бацање директно на гол, али пре него што је могао да га изведе, бива спречен од стране БЕЛОГ 5, који на удаљености од једног метра скаче и маше рукама када се огласи завршни сигнал. Исправна одлука?",
                    PhraseZhHk =
                        "黑隊進攻。裁判在比賽尚餘3秒時，判黑隊自由球。黑隊10號在正確的位置，準備直接擲自由球射門，被站在黑隊10號一米外的白隊5號不斷地跳起干擾，隨後響起比賽結束訊號。如何判決？",
                    QuestionNumber = "8.61",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 5",
                            PhraseNl = "2-minuten uitsluiting voor WIT5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 5",
                            PhraseZhHk = "白隊5號退場兩分鐘",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 5 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT5 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација БЕЛОГ 5 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消白隊5號資格（裁判出示紅牌）",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "With 19 seconds left in the match WHITE 2 is trying to break through, but the referees whistle steps against WHITE 2. After the whistle from the referees, WHITE 2 takes a shot on goal. The ball is grabbed by goalkeeper BLACK 12, and he is ready to start a counter-attack. Correct decision?",
                    PhraseNl =
                        "Met nog 19 seconden op de klok, probeert WIT2 een doorbraak te maken, maar de scheidsrechters fluiten loopfout tegen WIT2. Na het fluitsignaal van de scheidsrechters, werpt WIT2 naar het doel. De bal wordt snel opgenomen door doelman ZWART12, en hij is klaar om de tegenaanval te starten. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 2 покушава да се пробије 19 секунди пре краја утакмице, али судије досуђују кораке БЕЛОГ 2. После звиждука судија, БЕЛИ 2 шутира на гол. Лопту је ухватио голман ЦРНИ 12 и спреман је да започне контранапад. Исправна одлука?",
                    PhraseZhHk = "比賽時間尚餘19秒時，白隊2號試圖突破，但裁判判白隊2號走步犯規。裁判鳴哨後，白隊2號射門，球被黑隊12號門將撲住，準備發動反擊。如何判決？",
                    QuestionNumber = "8.62",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Play on",
                            PhraseNl = "Verder spelen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља",
                            PhraseZhHk = "比賽繼續",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 2",
                            PhraseNl = "2-minuten uitsluiting voor WIT2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 2",
                            PhraseZhHk = "白隊2號退場兩分鐘",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 2 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van WIT2 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација БЕЛОГ 2 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消白隊2號資格（裁判出示紅牌）",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 28:26 for WHITE team. With 25 seconds left in the match, BLACK team score a goal. Goalkeeper WHITE 12 kicks the ball away on purpose, so that it ends up in the spectators’ seats. It is clear that he kicks the ball with the intention of delaying the game, so that the throw-off cannot be executed immediately. What is the correct decision?",
                    PhraseNl =
                        "De score is 28:26 voor team WIT. Met nog 25 sec te gaan in de wedstrijd, scoort team ZWART. Doelman WIT12 schopt de bal opzettelijk weg, zo dat deze in de toeschouwer tribune terecht komt. Het is duidelijk dat hij de bal weg schopt met de intentie om het spel te vertragen, zodat de beginworp niet onmiddellijk kan genomen worden. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Резултат је 28:26 за БЕЛУ екипу, преостало је 25 секунди до краја утакмице, ЦРНА екипа постиже погодак. Голман БЕЛИ 12 намерно удари лопту која заврши у гледалишту, Јасно је да је голман намерно ударио лопту због одуговлачења игре, како почетно бацање не би било изведено одмах. Која је исправна одлука?",
                    PhraseZhHk = "比分為28:26，白隊領先，比賽時間尚餘25秒時，黑隊得分。白隊守門員12號故意將球踢到觀眾席，明顯是為了拖延比賽，讓開球無法快速進行。如何判決？",
                    QuestionNumber = "8.63",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-off for WHITE team",
                            PhraseNl = "Beginworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Почетно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊開球",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 12",
                            PhraseNl = "2-minuten uitsluiting voor WIT12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за БЕЛОГ 12",
                            PhraseZhHk = "白隊12號退場兩分鐘",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 12 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT12 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација БЕЛОГ 12 (судије показују црвени картон)",
                            PhraseZhHk = "取消白隊12號資格（裁判出示紅牌）",
                            AnswerNumber = "f",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification for WHITE 12 with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor WIT12 met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација с пријавом (судије показују црвени и плави картон)",
                            PhraseZhHk = "取消白隊12號資格，及作出書面報告（裁判出示紅牌和藍牌）",
                            AnswerNumber = "g"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 25:25 with 3 seconds left in the match. WHITE team are in attack. BLACK 5 causes a free throw for WHITE 2 at the free-throw line. Shortly after, the final signal sounds. The referees whistle for the execution of the free throw after the final signal. Before the ball has left the hand of the thrower, BLACK 6 steps forward and blocks the ball standing too close. What is the correct decision?",
                    PhraseNl =
                        "De score is 25-25 met nog 3 sec te gaan in de wedstrijd. Team WIT is in aanval. ZWART5 veroorzaakt een vrije worp voor WIT2 aan de vrije worplijn. Kort daarna weerklinkt het eindsignaal. De scheidsrechters fluiten voor de uitvoering van de vrije worp na het eindsignaal. Vooraleer de bal de hand van de werper verlaten heeft, stapt ZWART6 vooruit en blokt de bal terwijl hij te kortbij staat. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Резултат је 25:25, три секунде до краја утакмице. БЕЛА екипа је у нападу. ЦРНИ 5 прави прекршај над БЕЛИМ 2 на линији слободног бацања. Тренутак касније чује се завршни сигнал за крај утакмице. Судије досуђују слободно бацање после завршног сигнала. Пре него што је лопта напустила руку извођача, ЦРНИ 6 искорачи напред и стојећи преблизу извођача блокира ударац. Која је исправна одлука?",
                    PhraseZhHk = "比賽時間尚餘3秒，比分25:25，白隊進攻。白隊2號被黑隊5號犯規，裁判判白隊自由球。隨後，比賽結束訊號響起，裁判響哨完場訊號後的自由球擲球，在球離開擲球球員的手前，黑隊6號向前移動到很近的位置封擋了球。如何判決？",
                    QuestionNumber = "8.64",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The game is over.",
                            PhraseNl = "De wedstrijd is afgelopen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Крај утакмице",
                            PhraseZhHk = "比賽結束",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The free throw must be retaken.",
                            PhraseNl = "De vrije worp moet opnieuw genomen worden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање се мора поновити",
                            PhraseZhHk = "重擲自由球",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 6",
                            PhraseNl = "2-minuten uitsluiting voor ZWART6",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 6",
                            PhraseZhHk = "黑隊6號退場兩分鐘",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 6 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor ZWART6 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација ЦРНОГ 6 (судије показују црвени картон)",
                            PhraseZhHk = "取消黑隊6號資格（裁判出示紅牌）",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team are playing without a goalkeeper and with 7 field players. BLACK 5 intercepts a pass and runs with the ball in the direction of the empty goal of WHITE team. Goalkeeper WHITE 12 enters the court under a correct substitution and runs in the same direction as BLACK 5. Just as BLACK 5 takes a shot on goal, goalkeeper WHITE 12 pushes BLACK 5 from the side, so that he partly loses body control and his shot misses the goal. What is the correct decision?",
                    PhraseNl =
                        "Team WIT speelt zonder doelman en met 7 veldspelers. ZWART5 onderschept een pass en loopt met de bal in de richting van het lege doel van team WIT. Doelman WIT12 komt op het speelveld na een correcte wissel en loopt in dezelfde richting als ZWART5. Net op het ogenblik dat ZWART5 een worp naar doel doet, duwt WIT12, ZWART5 van op zij, zo dat hij gedeeltelijk zijn lichaamscontrole verliest en zijn worp het doel mist. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛА екипа игра у нападу без голмана и са 7 играча у пољу. ЦРНИ 5 пресече додавање и потрчи с лоптом у правцу празног гола БЕЛЕ екипе. Голман БЕЛИ 12 улази у поље за игру после исправно направљене замене и трчи у смеру ЦРНОГ 5. У тренутку шута ЦРНОГ 5, голман БЕЛИ 12 са стране гурне ЦРНОГ 5 који делимично изгуби контролу над телом и због тога промаши гол. Која је исправна одлука?",
                    PhraseZhHk = "白隊7名場內球員進攻，黑隊5號攔截了傳球，運球向白隊空門。白隊守門員12號正確替補進場，與黑隊5號相同的方向跑去，當黑隊5號射門時，白隊守門員12號從側面推了黑隊5號，使他失去部分身體平衡，射門偏出。如何判決？",
                    QuestionNumber = "8.65",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-Out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 12",
                            PhraseNl = "2-minuten uitsluiting voor WIT12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за БЕЛОГ 12",
                            PhraseZhHk = "白隊12號退場兩分鐘",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 12 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT12 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација БЕЛОГ 12 (судије показују црвени картон)",
                            PhraseZhHk = "取消白隊12號資格（裁判出示紅牌）",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 26:26 with 4 seconds left in the match. WHITE team are in attack. A free throw is caused for WHITE 4. WHITE 4 immediately executes the free throw. The ball is actively blocked by BLACK 5, who is standing too close. At the same time, the final signal sounds. What is the correct decision?",
                    PhraseNl =
                        "De score is 26:26 met nog 4 sec te spelen in de wedstrijd. Team WIT is in aanval. Een vrije worp wordt veroorzaakt tegen WIT4. WIT4 voert de vrije worp onmiddellijk uit. De bal wordt actief geblokt door ZWART5 die te kort bij staat. Op hetzelfde ogenblik weerklinkt het eindsignaal. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Резултат је 26:26, преостало је 4 секунде до краја утакмице. БЕЛА екипа је у нападу. Досуђено је слободно бацање за БЕЛОГ 4. Бели 4 одмах изводи слободно бацање. Извођење је активно блокирано од стране ЦРНОГ 5 који стоји преблизу. У истом тренутку зачује се завршни сигнал. Која је исправна одлука?",
                    PhraseZhHk = "比分26:26，比賽時間尚餘4秒，白隊進攻。白隊4號獲得自由球，並立即擲自由球，球被站得很近的黑隊5號主動封擋，此時，比賽結束訊號響起。如何判決？",
                    QuestionNumber = "8.66",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The free throw must be retaken.",
                            PhraseNl = "De vrije worp moet opnieuw genomen worden",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање се мора поновити",
                            PhraseZhHk = "重擲自由球",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 5",
                            PhraseNl = "2-minuten uitsluiting voor ZWART5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 5",
                            PhraseZhHk = "黑隊5號退場兩分鐘",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 5 (red card shown by the referees)",
                            PhraseNl = " Diskwalificatie van ZWART5 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација ЦРНОГ 5 (судије показују црвени картон)",
                            PhraseZhHk = "取消黑隊5號資格（裁判出示紅牌）",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 26:26 with 4 seconds left in the match. WHITE team are in attack. BLACK 5 causes a free throw for WHITE 6. BLACK 5 immediately moves back to the correct distance. WHITE 6 executes the free throw, and the ball hits BLACK 5, who does not take an active action. The ball rebounds back to WHITE 6. At the same time, the final signal sounds. What is the correct decision?",
                    PhraseNl =
                        "De score is 26:26 met nog 4 sec te spelen in de wedstrijd. Team WIT is in aanval. ZWART5 veroorzaakt een vrije worp voor WIT6. ZWART5 gaat onmiddellijk achteruit tot de correcte afstand. WIT6 voert de vrije worp uit, en de bal raakt ZWART5, die geen actieve actie onderneemt. De bal botst terug naar WIT6. Op hetzelfde ogenblik weerklinkt het eindsignaal. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Резултат је 26:26, преостало је 4 секунде до краја утакмице. БЕЛА екипа је у нападу. ЦРНИ 5 прави прекршај који проузрокује слободно бацање за БЕЛОГ 6. ЦРНИ 5 се одмах повлачи назад на прописану удаљеност. БЕЛИ 6 изводи слободно бацање и лопта погађа ЦРНОГ 5 који не предузима никакве активне радње. Лопта се одбија назад до БЕЛОГ 6. У истом тренутку зачује се завршни сигнал. Која је исправна одлука?",
                    PhraseZhHk = "比分26:26，比賽時間尚餘4秒，白隊進攻，黑隊5號犯規，白隊4號獲得自由球，黑隊5號立即移動到正確位置，白隊6號擲自由球，球打到沒有主動封擋的黑隊5號身上，球彈回到白隊6號手上。此時，比賽結束訊號響起。如何判決？",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "No further action. The match is over",
                            PhraseNl = "Geen verdere actie. De wedstrijd is ten einde",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Нема даљих акција, утакмица је завршена",
                            PhraseZhHk = "不作處理，比賽結束",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The free throw must be retaken.",
                            PhraseNl = "De vrije worp moet hernomen worden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање се мора поновити",
                            PhraseZhHk = "重擲自由球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 5",
                            PhraseNl = "2-minuten uitsluiting voor ZWART5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 5",
                            PhraseZhHk = "黑隊5號退場兩分鐘",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 5",
                            PhraseNl = "Diskwalificatie van ZWART5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација ЦРНОГ 5",
                            PhraseZhHk = "取消黑隊5號資格（裁判出示紅牌）",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 29:29 with 20 seconds left in the match. Goalkeeper WHITE 12 saves a shot on goal, and the ball crosses the outer goal line. The referees decide on goalkeeper throw for WHITE team. WHITE 12 wants to quickly execute the goalkeeper throw. BLACK 2 runs into the goal area and delays the execution of the throw. What is the correct decision?",
                    PhraseNl =
                        "De score is 29-29 met nog 20 sec te gaan in de wedstrijd. Doelman WIT12 stopt een worp op zijn doel en de bal overschrijdt de buiten doellijn. De scheidsrechters beslissen op uitworp voor team WIT. WIT12 wil snel de uitworp uitvoeren. ZWART2 loopt het doelgebied in en vertraagd de uitvoering van de uitworp. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Резултат је 29:29, преостало је 20 секунди до краја утакмице. Голман БЕЛИ 12 брани ударац на гол, те лопта прелази линију ван гола. Судије досуђују голманово бацање за БЕЛУ екипу. БЕЛИ 12 жели да брзо изведе голманово бацање. ЦРНИ 2 утрчи у голманов простор и омета извођење бацања. Која је исправна одлука?",
                    PhraseZhHk = "比分29:29，比賽時間尚餘20秒，白隊守門員12號封擋射門，球越過外球門線，裁判判白隊守門員擲球。白隊12號想快速擲球，黑隊2號跑進禁區阻礙擲球。如何判決？",
                    QuestionNumber = "8.68",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team after whistle signal",
                            PhraseNl = "Uitworp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛЕ после звиждука",
                            PhraseZhHk = "鳴哨後白隊守門員球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team after whistle signal",
                            PhraseNl = "Vrije worp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛЕ после звиждука",
                            PhraseZhHk = "鳴哨後白隊自由球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 2",
                            PhraseNl = "2-minuten uitsluiting voor ZWART2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 2",
                            PhraseZhHk = "黑隊2號退場兩分鐘",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 2 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van ZWART2 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација ЦРНОГ 2 (судије показују црвени картон)",
                            PhraseZhHk = "取消黑隊2號資格（裁判出示紅牌）",
                            AnswerNumber = "f",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification for BLACK 2 with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART2 met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација ЦРНОГ 2 са писаном пријавом (судије показују црвени и плави картон)",
                            PhraseZhHk = "取消黑隊2號資格，及作出書面報告（裁判出示紅牌和藍牌）",
                            AnswerNumber = "g"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 29:29 with 20 seconds left in the match. Goalkeeper WHITE 12 saves a shot on goal, and the ball crosses the outer goal line. The referees decide on goalkeeper throw for WHITE team. WHITE 12 gets ready to execute the goalkeeper throw. Before the ball has left his hand, a whistle signal sounds from the timekeeper because of a faulty substitution made by BLACK team. BLACK 3 has entered the court before BLACK 11 has left it. What is the correct decision?",
                    PhraseNl =
                        "De score is 29-29 met nog 20 sec te gaan in de wedstrijd. Doelman WIT12 stopt een worp op zijn doel en de bal overschrijdt de buiten doellijn. De scheidsrechters beslissen op uitworp voor team WIT. WIT12 is klaar om de uitworp uit te voeren. Vooraleer de bal zijn hand verlaten heeft, weerklinkt een fluitsignaal van de tijdwaarnemer omdat er een foutieve wissel gebeurde door team ZWART. ZWART3 heeft het speelveld betreden vooraleer ZWART11 het verlaten heeft. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Резултат је 29:29, преостало је 20 секунди до краја утакмице. Голман БЕЛИ 12 брани ударац на гол те лопта прелази линију ван гола. Судије досуђују голманово бацање за БЕЛУ екипу. БЕЛИ 12 је спреман да изведе голманово бацање. Пре него што је лопта напустила његову руку, чуо се звиждук мериоца времена, због погрешне замене ЦРНЕ екипе. ЦРНИ 3 је ушао у поље за игру пре него што је ЦРНИ 11 напустио поље за игру. Која је исправна одлука?",
                    PhraseZhHk = "比分29:29，比賽時間尚餘20秒，白隊守門員12號封擋射門，球越過外球門線，裁判判白隊守門員球。白隊12號準備擲球，在球離開他的手前，計時員鳴哨，黑隊3號在黑隊11號離場前進場。如何判決？",
                    QuestionNumber = "8.69",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team after whistle signal",
                            PhraseNl = "Uitworp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛЕ после звиждука",
                            PhraseZhHk = "鳴哨後白隊守門員球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team at the substitution area of BLACK team",
                            PhraseNl = "Vrije worp voor team WIT aan de wisselzone van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛЕ у висни простора за замену ЦРНЕ екипе",
                            PhraseZhHk = "白隊在黑隊替補區擲自由球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 3",
                            PhraseNl = "2-minuten uitsluiting voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 3",
                            PhraseZhHk = "黑隊3號退場兩分鐘",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 3 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van ZWART3 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација ЦРНОГ 3 (судије показују црвени картон)",
                            PhraseZhHk = "取消黑隊3號資格（裁判出示紅牌）",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 29:29 with 20 seconds left in the match. Goalkeeper WHITE 12 saves a shot on goal, and the ball crosses the outer goal line. The referees decide on goalkeeper throw for WHITE team. WHITE 12 executes the throw as a pass to WHITE 9, who is standing just outside the goal area. Before the ball has crossed the goal-area line, a whistle signal sounds from the timekeeper because of a faulty substitution made by BLACK team. BLACK 3 has entered the court before BLACK 11 has left it. What is the correct decision?",
                    PhraseNl =
                        "De score is 29-29 met nog 20 sec te gaan in de wedstrijd. Doelman WIT12 stopt een worp op zijn doel en de bal overschrijdt de buiten doellijn. De scheidsrechters beslissen op uitworp voor team WIT. WIT12 voert de uitworp uit met een pass naar WIT9 die net buiten het doelgebied staat. Vooraleer de bal de doelgebied lijn overschrijdt, weerklinkt een fluitsignaal van de tijdwaarnemer omdat er een foutieve wissel gebeurde door team ZWART. ZWART3 heeft het speelveld betreden vooraleer ZWART11 het verlaten heeft. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Резултат је 29:29, преостало је 20 секунди до краја утакмице. Голман БЕЛИ 12 брани ударац на гол, те лопта прелази линију ван гола. Судије досуђују голманово бацање за БЕЛУ екипу. БЕЛИ 12 изводи бацање додајући лопту БЕЛОМ 9, који стоји непосредно испред сопственог голмановог простора. Пре него што је лопта прешла линију голмановог простора, чуо се звиждук мериоца времена, због погрешне замене ЦРНЕ екипе. ЦРНИ 3 је ушао у поље за игру пре него што је ЦРНИ 11 напустио поље за игру. Која је исправна одлука?",
                    PhraseZhHk = "比分29:29，比賽時間尚餘20秒，白隊守門員12號封擋射門，球越過外球門線，裁判判白隊守門員球。白隊12號準備傳球給站在禁區外的白隊9號，在球穿越禁區線前，計時員鳴哨，黑隊替補犯規，黑隊3號在黑隊11號離場前進場。如何判決？",
                    QuestionNumber = "8.70",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team at the substitution area of BLACK team",
                            PhraseNl = "Vrije worp voor team WIT aan de wisselzone van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛЕ у висни простора за замену ЦРНЕ екипе",
                            PhraseZhHk = "白隊在黑隊替補區擲自由球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 3",
                            PhraseNl = "2-minuten uitsluiting voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 3",
                            PhraseZhHk = "黑隊3號退場兩分鐘",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 3 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van ZWART3 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација ЦРНОГ 3 (судије показују црвени картон)",
                            PhraseZhHk = "取消黑隊3號資格（裁判出示紅牌）",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 29:29 with 10 seconds left in the match. WHITE team are in a counter-attack. BLACK 10 attacks WHITE 9 in a way that is dangerous to his health. Before falling, WHITE 9 plays the ball to WHITE 11. WHITE 11 takes a shot on goal, but the ball is saved by goalkeeper BLACK 12. What is the correct decision?",
                    PhraseNl =
                        "De score is 29-29 met nog 10 sec te gaan in de wedstrijd. Team WIT is in tegenaanval. ZWART10 valt WIT9 aan op een wijze die gevaarlijk is voor zijn gezondheid. Alvorens te vallen speelt WIT9 de bal naar WIT11. WIT11 werpt naar doel, maar de bal wordt gered door doelman ZWART12. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Резултат је 29:29, преостало је 10 секунди до краја утакмице. БЕЛА екипа је у контранападу. ЦРНИ 10 зауставља и спречава БЕЛОГ 9 на начин који је опасан по његово здравље. Пре пада, БЕЛИ 9 додаје лопту до БЕЛОГ 11. БЕЛИ 11 шутира на гол, али голман ЦРНИ 12 брани ударац. Која је исправна одлука?",
                    PhraseZhHk = "比分29:29，比賽時間尚餘10秒，白隊進攻，黑隊10號以危及對方健康的方式攻擊白隊9號，白隊9號在倒下前將球傳給白隊11號，白隊11號射門，但被黑隊12號守門員封擋。如何判決？",
                    QuestionNumber = "8.71",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 10",
                            PhraseNl = "2-minuten uitsluiting voor ZWART10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 10",
                            PhraseZhHk = "黑隊10號退場兩分鐘",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 10 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van ZWART10 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација ЦРНОГ 10 (судије показују црвени картон)",
                            PhraseZhHk = "取消黑隊10號資格（裁判出示紅牌）",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊守門員球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 29:29 with 10 seconds left in the match. WHITE team are in a counter-attack. BLACK 10 attacks WHITE 9 in a way that is dangerous to his health. Before falling, WHITE 9 plays the ball to WHITE 11. WHITE 11 scores a goal. What is the correct decision?",
                    PhraseNl =
                        "De score is 29-29 met nog 10 sec te gaan in de wedstrijd. Team WIT is in tegenaanval. ZWART10 valt WIT9 aan op een wijze die gevaarlijk is voor zijn gezondheid. Alvorens te vallen speelt WIT9 de bal naar WIT11. WIT11 scoort een doelpunt. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Резултат је 29:29, преостало је 10 секунди до краја утакмице. БЕЛА екипа је у контранападу. ЦРНИ 10 зауставља и спречава БЕЛОГ 9 на начин који је опасан по његово здравље. Пре пада, БЕЛИ 9 додаје лопту до БЕЛОГ 11. БЕЛИ 11 постиже гол. Која је исправна одлука?",
                    PhraseZhHk = "比分29:29，比賽時間尚餘10秒，白隊快速反擊，黑隊10號以危及對方健康的方式攻擊白隊9號，白隊9號在倒下前將球傳給白隊11號，白隊11號射門得分。如何判決？",
                    QuestionNumber = "8.72",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 10",
                            PhraseNl = "2-minuten uitsluiting voor ZWART10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 10",
                            PhraseZhHk = "黑隊10號退場兩分鐘",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 10 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van ZWART10 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација ЦРНОГ 10 (судије показују црвени картон)",
                            PhraseZhHk = "取消黑隊10號資格（裁判出示紅牌）",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal for WHITE team",
                            PhraseNl = "Doelpunt voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за БЕЛУ екипу",
                            PhraseZhHk = "白隊得分",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 29:29 with 10 seconds left in the match. WHITE team are in a counter-attack. BLACK 10 attacks WHITE 9 in a way that is dangerous to his health. Before falling, WHITE 9 plays the ball to WHITE 11. WHITE 11 plays the ball to WHITE 4. What is the correct decision?",
                    PhraseNl =
                        "De score is 29-29 met nog 10 sec te gaan in de wedstrijd. Team WIT is in tegenaanval. ZWART10 valt WIT9 aan op een wijze die gevaarlijk is voor zijn gezondheid. Alvorens te vallen speelt WIT9 de bal naar WIT11. WIT11 speelt de bal door naar WIT4. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Резултат је 29:29, преостало је 10 секунди до краја утакмице. БЕЛА екипа је у контранападу. ЦРНИ 10 зауставља и спречава БЕЛОГ 9 на начин који је опасан по његово здравље. Пре пада, БЕЛИ 9 додаје лопту до БЕЛОГ 11. БЕЛИ 11 додаје БЕЛОМ 4. Која је исправна одлука?",
                    PhraseZhHk = "比分29:29，比賽時間尚餘10秒，白隊快速反擊，黑隊10號以危及對方健康的方式攻擊白隊9號，白隊9號在倒下前將球傳給白隊11號，白隊11號傳球給白隊4號。如何判決？",
                    QuestionNumber = "8.73",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 10",
                            PhraseNl = "2-minuten uitsluiting voor ZWART10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 10",
                            PhraseZhHk = "黑隊10號退場兩分鐘",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 10 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van ZWART10 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација ЦРНОГ 10 (судије показују црвени картон)",
                            PhraseZhHk = "取消黑隊10號資格（裁判出示紅牌）",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Referee whistles after the pass from WHITE 11 to WHITE 4",
                            PhraseNl = "De scheidsrechters fluiten na de pass van WIT11 naar WIT4",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Судије звижде после додавања БЕЛОГ 11 према БЕЛОМ 4",
                            PhraseZhHk = "在白隊11號傳球給白隊4號後吹哨",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 7 is in a counterattack. He has a clear chance of scoring and takes an unhindered shot on goal. The ball hits goalkeeper BLACK 12 in the head, and he falls to the floor. The rebounding ball is recovered by WHITE 9 who has a clear chance of scoring at the goal-area line of BLACK team. At that moment, the referees whistle to call for medical treatment for goalkeeper BLACK 12. What is the correct decision?",
                    PhraseNl =
                        "WIT7 is in tegenaanval. Hij heeft een duidelijke scoringskans en werpt ongehinderd naar doel. De bal raakt de doelverdediger ZWART12 op het hoofd, en hij valt op de grond. De terugkaatsende bal wordt bemachtigd door WIT9 die een duidelijke scorekans heeft aan de doelgebied lijn van team ZWART. Op dat ogenblik fluiten de scheidsrechters voor de medische behandeling van doelverdediger ZWART 12. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 7 је у контранападу. Нлази се у јасној ситуацији за постизање гола и неометано упућује шут на гол противника. Лопта погађа голмана ЦРНОГ 12 у главу након чега голман пада на под. Одбијена лопта одлази у руке играчу БЕЛОМ 9 који је у јасној ситуацији за постизање гола испрад голмановог простора ЦРНЕ екипе. У том тренутку судије прекидају игру и позивају медицинску помоћ за голмана ЦРНОГ 12. Која је исправна одлука?",
                    PhraseZhHk = "白隊7號快速反擊，並且有明顯得分機會，在無人防守下射門，球擊中黑隊守門員12號的頭部，令他倒在地上。站在黑隊禁區線外有明顯得分機會的白隊9號拿到彈回的球，此時，裁判鳴哨允許援助黑隊守門員12號，如何判決？",
                    QuestionNumber = "8.74",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 7.",
                            PhraseNl = "2-minuten uitsluiting voor WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за БЕЛОГ 7",
                            PhraseZhHk = "白隊7號退場兩分鐘",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for BLACK team.",
                            PhraseNl = "Uitworp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊守門員球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team.",
                            PhraseNl = "Vrije worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team.",
                            PhraseNl = "7m-worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team.",
                            PhraseNl = "Vrije worp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "No punishment for WHITE 7.",
                            PhraseNl = "Geen bestraffing voor WIT7.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Без казне за БЕЛОГ 7",
                            PhraseZhHk = "不用處罰白隊7號",
                            AnswerNumber = "f"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Goalkeeper BLACK 12 must leave the court and can only re-enter after his team have completed 3 attacks.",
                            PhraseNl =
                                "Doelverdediger ZWART12 moet het speelveld verlaten en mag pas opnieuw het speelveld betreden nadat zijn team haar derde aanval beëindigd heeft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Голман ЦРНИ 12 мора да напусти терен и може се вратити након 3 напада своје екипе",
                            PhraseZhHk = "黑隊守門員12號必須離開場地，並且在其隊伍完成3次進攻後才能重新進入場地。",
                            AnswerNumber = "g"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out.",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "h",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team leads by one goal with 7 seconds left until the end of the match. WHITE team are ready to execute a throw-off from the throw-off area, and the referees give the whistle signal for the execution. Instead of passing the ball to a teammate, WHITE 7 puts the ball down on the floor inside the throw-off area and walks away. No teammates are interested in entering the throw-off area to pick up the ball. What is the correct decision?",
                    PhraseNl =
                        "Team WIT leidt met 1 doelpunt met nog 7 seconden te spelen tot het einde van de wedstrijd. Team WIT staat klaar om een beginworp te nemen, en de scheidsrechters geven het fluitsignaal voor de uitvoering. In plaats van de bal naar een medespeler te spelen, legt WIT7 de bal op de grond binnen de beginworp-zone en wandelt weg. Geen enkele medespeler is geïnteresseerd om de beginworp-zone te betreden en de bal op te rapen. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛА екипа води једним голом разлике 7 секунди пре краја утакмице. БЕЛА екипа је спремна да изведе почетно бацање из простора за почетно бацање и судије дају знак за извођење. Уместо да дода лопту саиграчу, БЕЛИ 7 спушта лопту на под унутар простора за почетно бацање и одлази са места извођења. Ниједан саиграч извођача не жели да уђе у простор и да игра лоптом. Која је исправна одлука?",
                    PhraseZhHk = "比賽尚餘7秒，白隊領先一球，白隊在開球位置準備開球，裁判鳴哨開球，白隊7號沒有將球傳給隊友，而是把球放在開球位置內的地上走開了，沒有隊友打算進入開球位置撿球。如何判決？",
                    QuestionNumber = "8.75",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Correction of the throw-off.",
                            PhraseNl = "Correctie van de beginworp.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Корекција извођења почетног бацања",
                            PhraseZhHk = "修正開球",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out.",
                            PhraseNl = "Time-out.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The referees must wait 3 seconds after the whistle signal for the execution before they can give a free throw for BLACK team.",
                            PhraseNl =
                                "De scheidsrechters moeten 3 seconden wachten na het fluitsignaal voor de uitvoering vooraleer zij een vrije worp voor team ZWART kunnen geven.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Судије морају да сачекају 3 секунде након знака за извођење да би могли да досуде слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "裁判必須在鳴哨後等待3秒才能判黑隊自由球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for WHITE 7.",
                            PhraseNl = "Directe 2-minuten uitsluiting voor WIT7.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за БЕЛОГ 7",
                            PhraseZhHk = "白隊7號退場兩分鐘",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free-throw for BLACK team.",
                            PhraseNl = "Vrije worp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 8 breaks through the defence of WHITE team and has no players between himself and the goalkeeper WHITE 1. When he is about to shoot on goal, he is pushed from the side by WHITE 7. Even if he partly loses body control, he is able to shoot hard on goal. The ball hits the head of goalkeeper WHITE 1, changes direction and goes into the goal. What is the correct decision?",
                    PhraseNl =
                        "ZWART8 breekt door de verdediging van team WIT en heeft geen speler meer tussen hem en doelverdediger WIT1. Wanneer hij een doelworp wil nemen, wordt hij van op zij geduwd door WIT7. Zelfs wanneer hij gedeeltelijk zij lichaamscontrole versliest, is hij in staat om hard naar doel te werpen. De bal treft het hoofd van doelverdediger WIT1, verandert van richting en gaat in doel. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНИ 8 пролази кроз одбрану БЕЛЕ екипе и испред себе нема ниједног одбрамбеног играча осим голмана БЕЛОГ 1 на голу. Када је спреман да упути шут на гол, одгурнут је са стране од играча БЕЛОГ 7. Иако делимично губи контролу над телом, успева јако да шутне на гол. Лопта погађа голмана БЕЛОГ 1 у главу, промени правац и уђе у гол. Која је исправна одлука?",
                    PhraseZhHk = "黑隊8號突破白隊防守，和白隊守門員1號之間沒有任何球員，當他準備射門時，白隊7號從側面推了黑隊8號，即使他失去部分身體平衡，仍然能夠用力射門，球擊中白隊守門員1號的頭，改變方向進入球門。如何判決？",
                    QuestionNumber = "8.76",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal for BLACK team",
                            PhraseNl = "Doelpunt voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за ЦРНУ екипу",
                            PhraseZhHk = "黑隊得分",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for BLACK 8",
                            PhraseNl = "Directe 2-minuten uitsluiting voor ZWART8",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 8",
                            PhraseZhHk = "黑隊8號退場兩分鐘",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for WHITE 7",
                            PhraseNl = "Directe 2-minuten uitsluiting voor WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за БЕЛОГ 7",
                            PhraseZhHk = "白隊7號退場兩分鐘",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Line player BLACK 8 receives the ball. When he is trying to turn towards the goal, he is strongly held and pulled down by WHITE 7. However, he still regains full body control. Without any players between himself and the goalkeeper, he jumps above the goal area. He shoots hard with full body control. The ball hits goalkeeper WHITE 1 in the head. The head is the first point of contact with the ball. The ball changes direction and goes into the goal. What is the correct decision?",
                    PhraseNl =
                        "Cirkelspeler ZWART8 krijgt de bal. Wanneer hij zich richting doel wil draaien, wordt hij stevig vastgehouden en neergetrokken door WIT7. Niettemin behoudt hij volledige lichaamscontrole. Zonder enige speler tussen hem en de doelverdediger, springt hij boven het doelgebied. Hij werpt hard met volledige lichaamscontrole. De bal raakt doelverdediger WIT1 op het hoofd. Het hoofd is het eerste contact punt met de bal. De bal verandert van richting en gaat in het doel. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Пивот ЦРНИ 8 хвата лопту. Када је спреман да се окрене према голу противника, дуго је држан и оборен од стране БЕЛОГ 7. Упркос томе, успева да поврати пуну контролу над телом. Без играча између себе и голмана, скаче изнад голмановог простора и упућује снажан шут на гол. Лопта погађа голмана БЕЛОГ 1 у главу. Глава је место првог контакта са лоптом. Лопта мења правац и улази у гол. Која је исправна одлука?",
                    PhraseZhHk = "黑隊8號接到球，當他試圖轉身面向球門時，被白隊7號強行拉倒，然而他仍然能完全控制身體平衡，跳進禁區射門，他和守門員之間沒有任何球員，球擊中白隊守門員1號的頭部，頭部是與球的第一接觸點，球改變了方向進入了球門。如何判決？",
                    QuestionNumber = "8.77",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal for BLACK team",
                            PhraseNl = "Doelpunt voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за ЦРНУ екипу",
                            PhraseZhHk = "黑隊得分",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊自由球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for BLACK 8",
                            PhraseNl = "Directe 2-minuten uitsluiting voor ZWART8",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 8",
                            PhraseZhHk = "黑隊8號退場兩分鐘",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for WHITE 7",
                            PhraseNl = "Directe 2-minuten uitsluiting voor WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за БЕЛОГ 7",
                            PhraseZhHk = "白隊7號退場兩分鐘",
                            AnswerNumber = "f",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "g",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Wing player BLACK 3 has a clear chance of scoring and takes a shot on goal. The ball touches the side of the head of goalkeeper WHITE 1 without changing direction. The ball goes into the goal. What is the correct decision?",
                    PhraseNl =
                        "Hoekspeler ZWART3 heeft een duidelijke scorekans en werpt naar doel. De bal raakt de zijkant van het hoofd van doelverdediger WIT1 zonder van richting te veranderen. De bal gaat in het doel. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Крилни играч ЦРНИ 3 се налази у јасној ситуацији за постизање гола и затим шутира на гол. Лопта додирује главу голмана БЕЛОГ 1 и не мења правац. Лопта након тога улази у гол. Која је исправна одлука?",
                    PhraseZhHk = "黑隊翼衛3號有明顯得分機會並射門，球觸碰到白隊1號守門員的頭部後進了球門，球沒有改變方向。如何判決？",
                    QuestionNumber = "8.78",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for BLACK 3.",
                            PhraseNl = "Directe 2-minuten uitsluiting voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 3",
                            PhraseZhHk = "黑隊3號退場兩分鐘",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for WHITE 1.",
                            PhraseNl = "Progressieve bestraffing voor WIT1.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна за БЕЛОГ 1",
                            PhraseZhHk = "漸進處罰白隊1號",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal.",
                            PhraseNl = "Doelpunt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол",
                            PhraseZhHk = "得分",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team.",
                            PhraseNl = "Vrije worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Wing player BLACK 3 has a clear chance of scoring and takes a shot on goal. The ball hits the side of the head of goalkeeper WHITE 1 and changes direction. The head is the first point of contact with the ball. The ball goes into the goal. WHITE 1 falls to the floor, puts his hand on his head, and clearly needs medical assistance. What is the correct decision?",
                    PhraseNl =
                        "Hoekspeler ZWART3 heeft een duidelijke scorekans en werpt naar doel. De bal raakt de zijkant van het hoofd van doelverdediger WIT1 en verandert van richting. Het hoofd is het eerste contactpunt met de bal. De bal gaat in het doel. WIT1 valt op de grond, houdt zijn hand op het hoofd en heeft duidelijk medische verzorging nodig. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Крилни играч ЦРНИ 3 се налази у јасној ситуацији за постизање гола и затим шутира на гол. Лопта погађа главу голмана БЕЛОГ 1 и мења правац. Глава је место првог контакта са лоптом. Лопта након тога одлази у гол. БЕЛИ 1 пада на под, ставља руке на главу и видно му је потребна медицинска помоћ. Која је исправна одлука?",
                    PhraseZhHk = "黑隊翼衛3號有明顯得分機會並射門，球觸碰到白隊1號守門員的頭部並改變方向後進了球門，並未改變方向，頭是第一接觸點，白隊1號倒在地上，用手捂住自己的面，明顯需要治理。如何判決？",
                    QuestionNumber = "8.79",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out.",
                            PhraseNl = "Time-out.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            PhraseZhHk = "暫停",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The referees call for medical assistance for WHITE 1 by showing hand signals 15 and 16.",
                            PhraseNl =
                                "De scheidsrechters vragen medische assistentie voor WIT1 door de tekens 15 en 16 te tonen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Судије позивају медицинску помоћ за БЕЛОГ 1 показујући сигнале број 15 и 16",
                            PhraseZhHk = "裁判作出手號15及16，允許白隊球隊職員進場地援助白隊1號",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for BLACK 3.",
                            PhraseNl = "Directe 2-minuten uitsluiting voor ZWART3.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 3",
                            PhraseZhHk = "黑隊3號退場兩分鐘",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for WHITE 1.",
                            PhraseNl = "Progressieve bestraffing voor WIT1.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна за БЕЛОГ 1",
                            PhraseZhHk = "漸進處罰白隊1號",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal.",
                            PhraseNl = "Doelpunt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол",
                            PhraseZhHk = "得分",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team.",
                            PhraseNl = "Vrije worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            AnswerNumber = "f",
                            PhraseZhHk = "白隊自由球",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After receiving medical assistance WHITE 1 must leave the court and can only re-enter after his team completed 3 attacks.",
                            PhraseNl =
                                "Na medische assistentie ontvangen te hebben, moet WIT1 het speelveld verlaten en mag dit pas terug betreden nadat zijn team 3 aanvallen vervolledigd heeft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Након указане медицинске помоћи БЕЛИ 1 мора напустити терен и може се вратити тек након истека 3 напада своје екипе",
                            PhraseZhHk = "白隊1號在接受醫療援助後必須離開場地，並且只有在他的球隊完成3次進攻後才能重新進入場地。",
                            AnswerNumber = "g"
                        }
                    ]
                }
            ]
        };
    }
}
