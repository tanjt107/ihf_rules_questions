using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule13()
    {
        return new RuleDto
        {
            Name = "The Free Throw",
            NameNl = "De Vrije Worp",
            NameFr = "Le Jet Franc",
            NameSvn = "Prosti Met",
            NameDe = "Der Freiwurf",
            NameSrb = "Слободно бацање",
            NameZhHk = "自由球",
            RuleNumber = "13",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "There is a free throw for WHITE team. Before WHITE 5 can pick up the ball, BLACK 6 picks it up, putsit under his arm and runs towards his goal. After a few steps, he rolls the ball back to WHITE 5. Correct decision?",
                    PhraseNl =
                        "Vrije worp voor team WIT. Vooraleer WIT5 de bal kan oppakken, pakt ZWART6 deze op en loopt met de bal onder de arm in de richting van zijn eigen doel. Na enkele passen rolt hij de bal terug naar WIT5 toe. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Слободно бацање за БЕЛУ екипу. Пре него што је БЕЛИ 5 могао да узме лопту, узима је ЦРНИ 6 ставља је под руку и трчи у правцу свог гола. После неколико корака, он закотрља лопту према БЕЛОМ 5. Исправна одлука?",
                    PhraseZhHk = "白隊擲自由球，在白隊5號拿到球前，黑隊6號拾起球，以手臂夾着球向自己的球門區跑去，跑了幾步後，他把球滾回給白隊5號。如何判決？",
                    QuestionNumber = "13.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 6",
                            PhraseNl = "2-minuten uitsluiting voor ZWART6",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против ЦРНОГ 6",
                            PhraseZhHk = "黑隊6號退場兩分鐘",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team after whistle signal",
                            PhraseNl = "Vrije worp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу после звучног сигнала",
                            PhraseZhHk = "鳴哨後白隊擲自由球",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 6",
                            PhraseNl = "Waarschuwing voor ZWART6",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за ЦРНОГ 6",
                            PhraseZhHk = "警告黑隊6號",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Verder spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
                            PhraseZhHk = "比賽繼續",
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
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 7 is in possession of the ball and tries to start a counter-attack, but is held by WHITE 17. The referee is just about to whistle, but plays advantage, as BLACK 8 has just received the ball and takes a shot on goal of WHITE team. Goalkeeper WHITE 12 saves the shot and wants to start a counter-attack. Both teams have already received three warnings each earlier in the game. Correct decision?",
                    PhraseNl =
                        "ZWART7 is in balbezit en tracht een tegenaanval te starten, maar wordt door WIT17 vastgehouden. De scheidrechter wil net gaan fluiten, maar laat voordeel, wanneer ZWART8 net de bal gekregen heeft en een worp op het doel van WIT doet. Doelverdediger WIT12 vangt het shot op en wil de tegenaanval starten. Beide teams hebben eerder in de wedstrijd reeds 3 waarschuwingen gekregen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНИ 7 има лопту у поседу и покушава да крене у контранапад, али га држи БЕЛИ 17. Судија, мало пре него што да знак пиштаљком, види добру прилику за постизање гола и пушта предност, ЦРНИ 8 прима лопту и шутира на гол БЕЛЕ екипе. Голман БЕЛИ 12 брани шут и жели да започне контранапад. Обе екипе већ имају по 3 опомене, добијене раније у току игре. Исправна одлука?",
                    PhraseZhHk = "白隊17號抱住試圖反攻的黑隊7號，在裁判準備鳴哨時，黑隊8號已經把球接住。根據得益原則，裁判沒有鳴哨。黑隊8號接球後射門，球被白隊守門員12號擋住，並準備作出反擊。在此之前，兩隊均已被警告三次。如何判決？",
                    QuestionNumber = "13.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Verder spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
                            PhraseZhHk = "比賽繼續",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 17",
                            PhraseNl = "2-minuten uitsluiting voor WIT17",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 17",
                            PhraseZhHk = "白隊17號退場兩分鐘",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу",
                            PhraseZhHk = "白隊守門員球",
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
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team receives a free throw. BLACK 6 is in possession of the ball. He brings the ball with him, four metres from the place where the free-throw is to be executed. Correct decision?",
                    PhraseNl =
                        "Team WIT krijgt een vrije worp . ZWART6 in balbezit. Hij brengt de bal met zich mee, vier meter van de plaats waar WIT de vrije worp zou moeten uitvoeren. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "За БЕЛУ екипу је досуђено слободно бацање. ЦРНИ 6 има лопту у поседу. Он односи лопту 4 метра даље од места на којем треба да се изведе слободно бацање. Исправна одлука?",
                    PhraseZhHk = "白隊得自由球時，黑隊6號持球跑離犯規地點4米處。如何判決？",
                    QuestionNumber = "13.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 6",
                            PhraseNl = "Waarschuwing voor ZWART6",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за ЦРНОГ 6",
                            PhraseZhHk = "警告黑隊6號",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 6",
                            PhraseNl = "2-minuten uitsluiting van ZWART6",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против ЦРНОГ 6",
                            PhraseZhHk = "黑隊6號退場兩分鐘",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification of BLACK 6 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor ZWART6 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација ЦРНОГ 6 (црвени картон показан од стране судија)",
                            PhraseZhHk = "取消黑隊6號比賽資格（裁判出示紅牌）",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Free throw for WHITE team from the place of the infraction that has led to the free throw",
                            PhraseNl = "Vrije worp voor team WIT op de plaats van de fout die leidde tot de vrije worp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Слободно бацање за БЕЛУ екипу са места где се догодио прекршај због којег је досуђено слободно бацање",
                            PhraseZhHk = "白隊在原犯規地點擲自由球",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team from the place where the ball is",
                            PhraseNl = "Vrije worp voor team WIT op de plaats waar de bal is",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу са места где се лопта налази",
                            PhraseZhHk = "白隊在球所在位置擲自由球",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "A free throw is awarded against WHITE 4, who then takes the ball, crosses the goal area and puts the ball down. Correct decision?",
                    PhraseNl =
                        "Een vrije worp is toegekend tegen WIT4, die dan de bal neemt, het doelgebied doorkruist en de bal daar neerlegt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Слободно бацање је досуђено против БЕЛОГ 4, који затим узима лопту, улази у голманов простор и спушта лопту на тло. Исправна одлука?",
                    PhraseZhHk = "因白隊4號犯規判黑隊擲自由球，白隊4號拿着球走進禁區，然後放下球。如何判決？",
                    QuestionNumber = "13.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 4",
                            PhraseNl = "2-minuten uitsluiting voor WIT4",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 4",
                            PhraseZhHk = "白隊4號退場兩分鐘",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for WHITE 4",
                            PhraseNl = "Waarschuwing voor WIT4",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за БЕЛОГ 4",
                            PhraseZhHk = "警告白隊4號",
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
                        "WHITE 5 is in possession of the ball, when official B from WHITE team complains about the referees. The referees whistle, and the time is stopped. The referees warn official B from WHITE team. How should the game be resumed?",
                    PhraseNl =
                        "WIT5 is in balbezit wanneer official B van team WIT luidruchtig protesteert tegen de scheidsrechter. De scheidsrechters fluiten en de tijd wordt gestopt. De scheidsrechters waarschuwen official B van team WIT. Hoe zou het spel hervat moeten worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 5 има лопту у поседу, када званичник Б БЕЛЕ екипе протестује код судија. Судије свирају, дају тајм-аут и опомињу званичника Б БЕЛЕ екипе. Како треба да се настави игра?",
                    PhraseZhHk = "白隊5號持球時，白隊職員B正在向裁判抗議，裁判鳴哨暫停並警告白隊職員B。比賽應如何恢復？",
                    QuestionNumber = "13.5",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Free throw after whistle signal for BLACK team at the substitution area of WHITE team",
                            PhraseNl = "Vrije worp voor team ZWART na fluitsignaal aan de wisselzone van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Слободно бацање после звучног сигнала за ЦРНУ екипу, код простора за замену играча БЕЛЕ екипе",
                            PhraseZhHk = "鳴哨後由黑隊在白隊替補區處擲自由球",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Free throw after whistle signal for WHITE team at the substitution area of WHITE team",
                            PhraseNl = "Vrije worp voor team WIT na fluitsignaal aan de wisselzone van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Слободно бацање после звучног сигнала за БЕЛУ екипу, код простора за замену играча БЕЛЕ екипе",
                            PhraseZhHk = "鳴哨後由白隊在白隊替補區處擲自由球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Free throw after whistle signal for WHITE team, executed from the place where the ball was when the game was interrupted",
                            PhraseNl =
                                "Vrije worp voor team WIT na fluitsignaal uitgevoerd vanaf de plaats waar de bal zich bevond op het ogenblik van de spelonderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Слободно бацање после звучног сигнала за БЕЛУ екипу, тамо где је лопта била кад је игра прекинута",
                            PhraseZhHk = "鳴哨後由白隊在比賽中斷時球所在地點擲自由球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-in for BLACK team at the substitution area of WHITE team",
                            PhraseNl = "Inworp voor team ZWART aan de wisselzone van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут за ЦРНУ екипу код простора за замену играча БЕЛЕ екипе",
                            PhraseZhHk = "黑隊在白隊替補區擲界外球",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The game is interrupted by a whistle from the court referee, even though there has been no violation of the rules by any of the teams. No team time-out has been called. BLACK 13 has thrown the ball in the direction of the goal of WHITE team immediately prior to the whistle signal from the court referee. After the whistle signal, the ball goes into the goal without a chance for goalkeeper WHITE 1 to save it. How should the game be resumed?",
                    PhraseNl =
                        "Het spel wordt onderbroken door een fluitsignaal van de veldscheidsrechter zonder dat er een spelregelovertreding gebeurde door een van de teams. Er is ook geen time-out aangevraagd. ZWART13 heeft de bal in de richting van het doel van team WIT geworpen onmiddellijk voor het fluitsignaal van de veldscheidsrechter. Na het fluitsignaal gaat de bal in het doel zonder dat doelverdediger WIT1 een kans had de bal te redden. Hoe zou het spel hervat moeten worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Судија у пољу је звиждуком прекинуо игру и поред тога што није било прекршаја, а ниједна екипа није тражила тајм-аут. ЦРНИ 7 је упутио шут у правцу гола БЕЛЕ екипе, непосредно пре звиждука судије у пољу. После звиждука, лопта улази у гол, без шансе да је голман БЕЛИ 1 заустави. Како треба наставити игру?",
                    PhraseZhHk = "在雙方球員都沒有違例，亦沒有球隊申請暫停的情況下，裁判中斷了比賽。就在中斷比賽的訊號發出前，黑隊13號將球直接射向白隊球門，訊號發出時，球仍在空中，守門員來不及擋球，球進入了球門。比賽應如何恢復？",
                    QuestionNumber = "13.6",
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
                            Phrase = "Goal for BLACK team",
                            PhraseNl = "Doelpunt voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за ЦРНУ екипу",
                            PhraseZhHk = "黑隊得分",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 7 is in a counterattack. With one player from BLACK team between him and the goalkeeper, he shoots on goal and hits goalkeeper BLACK 12 in the head with the ball. BLACK 12 collapses. The ball rebounds to WHITE 9, who is standing alone at the goal-area line. WHITE 9 throws the ball in the direction of the empty goal. Just before the ball crosses the goal line, the referee whistles and interrupts the game. Goalkeeper BLACK 12 needs medical care on the court. Correct decision? ",
                    PhraseNl =
                        "WIT7 is in tegenaanval. Met een speler van team ZWART tussen hem en de doelverdediger, werpt hij naar doel en treft doelverdediger ZWART12 met de bal op het hoofd. ZWART12 valt neer. De bal springt terug naar WIT9, die vrij staat aan de doelgebied. WIT9 werpt de bal in de richting van het lege doel. Net voordat de bal de doellijn overschrijdt, fluit de scheidsrechter en onderbreekt het spel. Doelverdediger ZWART12 heeft medische verzorging nodig op het speelveld. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 7 је у контранападу. Између њега и голмана противничке екипе се налази један одбрамбени играч. Приликом шута на гол, он погађа голмана ЦРНОГ 12 лоптом у главу, тако да онесвести голмана. Лопта се одбија до БЕЛОГ 9, који сам стоји на линији голмановог простора. БЕЛИ 9 баца лопту према празном голу. Судија свира и прекида игру док је лопта у ваздуху изнад голмановог простора, а пре него што уђе у гол. Голману ЦРНОМ 12 је потребна медицинска помоћ на терену. Исправна одлука?",
                    PhraseZhHk = "白隊7號在快速反擊中射門，有一名黑隊球員在守門員和他之間，球擊中跳起的黑隊守門員12號守門員的頭部，黑隊12號昏倒地，需要接受治理。從黑隊12號頭彈回的球向禁區外的白隊9號飛去，白隊9號接到球後立即將球射進空門。若果球在禁區上空飛行途中，未進入球門前，裁判作出了鳴哨，如何判決？",
                    QuestionNumber = "13.7",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal for WHITE team",
                            PhraseNl = "Doelpunt voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за БЕЛУ екипу",
                            PhraseZhHk = "白隊得分",
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
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team after whistle signal",
                            PhraseNl = "Vrije worp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу, после звучног сигнала",
                            PhraseZhHk = "鳴哨後白隊擲自由球",
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
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "BLACK 12 must leave the court and can only re-enter following the third attack of his team.",
                            PhraseNl =
                                "ZWART12 moet het speelveld verlaten en kan enkel terugkomen na 3 aanvallen van zijn team.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "ЦРНИ 12 мора да напусти терен и може да се врати после 3 напада своје екипе",
                            PhraseZhHk = "黑隊12號必須離開球場，並且於其球隊完成3次進攻後，才可以進場比賽",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "There is a free-throw decision for BLACK 9, but WHITE 5 is still in possession of the ball. WHITE 5 moves towards one of the referees and politely gives the ball to him. Correct decision?",
                    PhraseNl =
                        "ZWART9 krijgt een vrije worp, maar WIT5 is nog in balbezit. WIT5 gaat dan naar een van de scheidsrechter en geeft hem “beleefd” de bal. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "За ЦРНОГ 9 је досуђено слободно бацање, али БЕЛИ 5 још увек има лопту у поседу. БЕЛИ 5 иде према судији и љубазно му даје лопту. Исправна одлука?",
                    PhraseZhHk = "黑隊自由球，但球還在白隊5號的手中。白隊5號持球走向裁判並“禮貌”地將球交給裁判。如何判決？",
                    QuestionNumber = "13.8",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for WHITE 5 and free throw for BLACK team from the spot where the ball is now",
                            PhraseNl =
                                "2-minuten uitsluiting voor WIT5 en vrije worp voor team ZWART op de plaats waar de bal nu is",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "2 минута искључења против БЕЛОГ 5 и слободно бацање за ЦРНУ екипу са места где се лопта налази у том тренутку",
                            PhraseZhHk = "白隊5號退場兩分鐘，黑隊在球所在地點擲自由球",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Warning for WHITE 5 and free throw for BLACK team from the spot where the ball is now",
                            PhraseNl =
                                "Waarschuwing voor WIT5 en vrije worp voor team ZWART op de plaats waar de bal nu is",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Опомена за БЕЛОГ 5 и слободно бацање за ЦРНУ екипу са места где се лопта налази у том тренутку",
                            PhraseZhHk = "警告白隊5號，黑隊在球所在地點擲自由球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for WHITE 5 and free throw for BLACK team from the spot where the foul was committed",
                            PhraseNl =
                                "2-minuten uitsluiting voor WIT5 en vrije worp voor team ZWART op de plaats waar de fout werd begaan",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "2 минута искључења против БЕЛОГ 5 и слободно бацање за ЦРНУ екипу са места где је начињен прекршај",
                            PhraseZhHk = "白隊5號退場兩分鐘，黑隊在犯規地點擲自由球",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Warning for WHITE 5 and free throw for BLACK team from the spot where the foul was committed",
                            PhraseNl =
                                "Waarschuwing voor WIT5 en vrije worp voor ZWART op de plaats waar de fout werd begaan",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Опомена за БЕЛОГ 5, слободно бацање за ЦРНУ екипу са места где је начињен прекршај",
                            PhraseZhHk = "警告白隊5號，黑隊在犯規地點擲自由球",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 5 makes a faulty substitution after the referees have just awarded a 7-metre throw for WHITE team. Correct decision?",
                    PhraseNl =
                        "WIT5 begaat een wisselfout, nadat de scheidsrechter net een 7m-worp heeft toegekend voor team WIT. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Погрешна замена од стране БЕЛОГ 5, након што су судије досудиле седмерац за БЕЛУ екипу. Исправна одлука?",
                    PhraseZhHk = "當裁判判白隊得七米球後，白隊5號出現替補犯規。如何判決？",
                    QuestionNumber = "13.9",
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
                            Phrase = "2-minute suspension for WHITE 5",
                            PhraseNl = "2-minuten uitsluiting voor WIT5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 5",
                            PhraseZhHk = "白隊5號退場兩分鐘",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for the responsible team official from WHITE team",
                            PhraseNl = "Waarschuwing voor de teamverantwoordelijke van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за одговорног представника БЕЛЕ екипе",
                            PhraseZhHk = "警告白隊“球隊職員代表”",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Which of the following statements about the place of execution of a free throw are correct?",
                    PhraseNl =
                        "Welke van de volgende uitspraken betreffende de plaats van uitvoering van een vrije worp zijn correct?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Које од следећих констатација, које се односе на место извођења слободног бацања, су исправне?",
                    PhraseZhHk = "有關擲自由球的位置，下列那些說法是正確的?",
                    QuestionNumber = "13.10",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "If the ball is not put down immediately after the free-throw decision, the opponents are allowed to execute the free throw from the place where the ball is.",
                            PhraseNl =
                                "Wanneer de bal niet onmiddellijk neergelegd wordt na een vrije worpbeslissing, is het de tegenstander toegestaan de vrije worp uit te voeren op de plaats waar de bal zich bevindt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Ако лопта није спуштена одмах, после одлуке о слободном бацању, противнику је дозвољено да изведе слободно бацање са места где се лопта налази у том тренутку",
                            PhraseZhHk = "判自由球後，若球沒有立即放下，容許對隊在球所在的位置擲自由球",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After a faulty substitution, the free throw can be taken from where the ball is, instead of at the substitution area, if this is advantageous to the team executing the throw.",
                            PhraseNl =
                                "Na een wisselfout mag de vrije worp genomen worden op de plaats waar de bal zich bevindt in plaats van aan de wisselzone, indien dit voordeliger is voor het uitvoerende team.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "После погрешне замене, слободно бацање може бити изведено са места где се лопта налази, уместо из простора за замену играча, ако је то повољније за екипу која изводи бацање",
                            PhraseZhHk = "替補犯規後，若在比賽中斷時球所在的位置比在替補區擲球更為有利時，擲球隊可在該位置擲自由球",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After passive play, the free throw is always taken from the place where the ball was when the free throw was given.",
                            PhraseNl =
                                "Na passief spel wordt de vrije worp altijd genomen op de plaats waar de bal was op het ogenblik dat de vrije worp werd toegekend.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "После пасивне игре, слободно бацање се увек изводи са места где је лопта била, у тренутку када је слободно бацање досуђено",
                            PhraseZhHk = "因消極比賽而判的自由球，總是在判罰時，球所在的位置執行擲球",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "For a free throw from the centre line, the tolerance to the side is about the same as in case of a throw-off.",
                            PhraseNl =
                                "Voor een vrije worp op de middenlijn is de zijwaartse tolerantie ongeveer dezelfde als die bij een beginworp.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "За слободно бацање код средишње линије, бочна толеранција је приближно иста као у случају почетног бацања",
                            PhraseZhHk = "在中線擲自由球的位置，其誤差範圍如同開球",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 11 has the ball in attack and tries to go around WHITE 2. Because of a whistle signal from the spectators’ area, WHITE 2 stops defending. BLACK 11 is now free to shoot. Correct decision?",
                    PhraseNl =
                        "ZWART11 heeft de bal in de aanval en tracht verdediger WIT2 te omspelen. Omwille van een fluitsignaal dat uit de tribune komt, stopt WIT2 zijn verdediging. ZWART11 is nu helemaal vrij om te werpen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНИ 11 има лопту у нападу и покушава да заобиђе БЕЛОГ 2. Због звиждука из гледалишта, БЕЛИ 2 престаје да игра одбрану. ЦРНИ 11 је потом сам и спреман да шутира на гол. Исправна одлука?",
                    PhraseZhHk = "黑隊11號持球進攻，並試圖擺脫防守球員白隊2號。由於觀眾席傳來哨子聲，白隊2號停了下來，沒有繼續防守，黑隊11號在無人防守下射門。如何判決？",
                    QuestionNumber = "13.11",
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
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out; consultation with the timekeeper",
                            PhraseNl = "Time-out; overleg met de tijdopnemer",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут; Консултација са мериоцем времена",
                            PhraseZhHk = "暫停，詢問計時員",
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
                        "WHITE team has the ball at the free-throw line of BLACK team. Official A from BLACK team protests so strongly against a referee decision that the referees interrupt the game. Correct decision?",
                    PhraseNl =
                        "Team WIT is in balbezit aan de vrije worplijn van team ZWART. Official A van team ZWART protesteert zo fel tegen een beslissing van de scheidsrechter, dat de scheidsrechters het spel onderbreken. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛА екипа има лопту на линији слободног бацања ЦРНЕ екипе. Званичник А ЦРНЕ екипе жестоко протестује против судијске одлуке, тако да судије прекидају игру. Исправна одлука?",
                    PhraseZhHk = "白隊在黑隊九米線附近控球進攻，黑隊球隊職員A強烈抗議裁判判决，使比賽中斷。比賽應如何恢復？",
                    QuestionNumber = "13.12",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for official A from BLACK team",
                            PhraseNl = "Progressieve bestraffing van official A van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против званичника А ЦРНЕ екипе",
                            PhraseZhHk = "漸進處罰黑隊球隊職員A",
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
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу, код простора за замену ЦРНЕ екипе",
                            PhraseZhHk = "白隊在黑隊的替補區擲自由球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team at the free-throw line of BLACK team",
                            PhraseNl = "Vrije worp voor team WIT aan de vrije worplijn van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу, са линије слободног бацања ЦРНЕ екипе",
                            PhraseZhHk = "白隊在黑隊九米線前擲自由球",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 6 receives a warning. When whistling for the execution of the subsequent free throw for WHITE team, the court referee does not see WHITE 11, who is between the goal-area line and the free-throw line. WHITE 11 receives the ball and has a clear chance of scoring. The goal-line referee noticed the situation. Correct decision?",
                    PhraseNl =
                        "ZWART6 krijgt een waarschuwing. Bij het fluitsignaal voor de uitvoering van de daaropvolgende vrije worp voor team WIT, verliest de veldscheidsrechter speler WIT11, die zich tussen de vrije worplijn en de doelgebied lijn bevindt, uit het oog. WIT11 krijgt de bal en heeft een open doelkans. De doelscheidsrechter had de situatie gezien. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Опомена за ЦРНОГ 6. Судија у пољу не види БЕЛОГ 11, који се налази између линије голмановог простора и линије слободног бацања, и даје знак за извођење слободног бацања за БЕЛУ екипу. БЕЛИ 11 добија лопту и долази у јасну ситуацију за постизање гола. Судија код гола уочава грешку. Исправна одлука?",
                    PhraseZhHk = "警告黑隊6號後，裁判即鳴哨由白隊擲自由球。鳴哨時，場內裁判沒有發現白隊11號站在九米線與禁區線之間，白隊11號接球後有明顯得分機會，底線裁判發現了這個情況。如何判決？",
                    QuestionNumber = "13.13",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Verder spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
                            PhraseZhHk = "繼續比賽",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeat the free throw after correction and whistle signal",
                            PhraseNl = "Herhaling van de vrije worp na correctie en fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање слободног бацања после корекције и звучног сигнала",
                            PhraseZhHk = "更正位置後，鳴哨重擲自由球",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The goal-line referee decides on a free throw for BLACK team.",
                            PhraseNl = "De doelscheidsrechter beslist tot vrije worp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Судија код гола досуђује слободно бацање за ЦРНУ екипу",
                            PhraseZhHk = "由底線裁判判黑隊自由球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The goal-line referee gives WHITE 11 a warning.",
                            PhraseNl = "De doelscheidsrechter geeft WIT11 een vaarschuwing.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Судија код гола даје опомену БЕЛОМ 11",
                            PhraseZhHk = "由底線裁判警告白隊11號",
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
                        "WHITE team are in possession of the ball. BLACK team have taken their positions in defence. WHITE 8 is running close to the sideline. WHITE 4 passes the ball in the direction of WHITE 8. WHITE 8 collides with a photographer, who is walking between the stands and the court and touching the sideline. WHITE 8 fails to catch the ball and loses body control. Before the referees interrupt the game, the ball passes the sideline. What is the correct decision?",
                    PhraseNl =
                        "Team WIT is in balbezit. Team ZWART heeft zijn posities in verdediging ingenomen. WIT8 loopt vlak bij de zijlijn. WIT4 speelt de bal in de richting van WIT8. WIT8 botst met een fotograaf die wandelt tussen de tribunes en het speelveld en de zijlijn raakt. WIT8 kan de bal niet vangen en verliest zijn lichaamscontrole. Vooraleer de scheidsrechters de wedstrijd onderbreken, gaat de bal over de zijlijn. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛА екипа има лопту у поседу. ЦРНА екипа је заузела положај у одбрани. БЕЛИ 8 трчи близу аут линије. БЕЛИ 4 додаје лопту у правцу БЕЛОГ 8. БЕЛИ 8 се судара са фотографом који се шета између трибина и простора за игру дотичући аут линију. БЕЛИ 8 не успева да ухвати лопту те губи контролу над телом. Пре него што су судије прекинуле игру, лопта је прешла аут линију. Која је исправна одлука?",
                    PhraseZhHk =
                        "白隊持球，黑隊已經在防守位置。白隊4號傳球給在邊線附近跑動的白隊8號，白隊8號撞倒了站在邊線的一名攝影師，白隊8號失去身體平衡，未能接住球。在裁判中斷比賽之前，球已經越過邊線。如何判決？",
                    QuestionNumber = "13.14",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The game is restarted with a throw-in for BLACK team.",
                            PhraseNl = "Het spel wordt hernomen met een inworp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља аутом за ЦРНУ екипу",
                            PhraseZhHk = "黑隊界外球恢復比賽",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The game is restarted with a free throw for WHITE team.",
                            PhraseNl = "Het spel wordt hernomen met een vrije worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља слободним бацањем за БЕЛУ екипу",
                            PhraseZhHk = "白隊自由球恢復比賽",
                            AnswerNumber = "b",
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
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Note in the match report in conformity with the regulations of the respective federation",
                            PhraseNl =
                                "Vermelding op het wedstrijdblad in overeenstemming met de reglementering van de respectievelijke federatie",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Забелешка у записнику у складу са прописима надлежне федерације",
                            PhraseZhHk = "在記錄表上註明",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK team are in attack. The referees give a free throw to BLACK 2. Before BLACK 2 can execute the free throw, BLACK 11 pulls WHITE 8 down. What is the correct decision?",
                    PhraseNl =
                        "Team ZWART is in aanval. De scheidsrechters geven een vrije worp aan ZWART2. Vooraleer ZWART2 de vrije worp kan uitvoeren, trekt ZWART11, WIT8 neer. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНА екипа је у нападу. Судије досуђују слободно бацање за ЦРНОГ 2. Пре него што ЦРНИ 2 изведе слободно бацање, ЦРНИ 11 обара БЕЛОГ 8. Која је исправна одлука?",
                    PhraseZhHk = "黑隊進攻，黑隊2號擲自由球。在黑隊2號擲球前，黑隊11號拉倒了白隊8號。如何判決？",
                    QuestionNumber = "13.15",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team after whistle signal",
                            PhraseNl = "Vrije worp voor team ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу након звиждука",
                            PhraseZhHk = "鳴哨後黑隊自由球",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team after whistle signal",
                            PhraseNl = "Vrije worp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу након звиждука",
                            PhraseZhHk = "鳴哨後白隊自由球",
                            AnswerNumber = "b"
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
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for BLACK 11",
                            PhraseNl = "Progressieve bestraffing voor ZWART11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна за ЦРНОГ 11",
                            PhraseZhHk = "漸進處罰黑隊11號",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for BLACK 11",
                            PhraseNl = "Directe 2-minuten uitsluiting voor ZWART11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 11",
                            PhraseZhHk = "黑隊11號退場兩分鐘",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 11 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor ZWART11 (Rode kaart getoond door de scheidsrechter)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација ЦРНОГ 11 (црвени картон)",
                            PhraseZhHk = "取消黑隊11號資格（裁判出示紅牌）",
                            AnswerNumber = "f"
                        }
                    ]
                }
            ]
        };
    }
}
