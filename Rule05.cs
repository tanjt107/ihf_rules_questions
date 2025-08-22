using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule05()
    {
        return new RuleDto
        {
            Name = "The Goalkeeper",
            NameNl = "De Doelverdediger",
            NameFr = "Le Gardien de but",
            NameSvn = "Vratar",
            NameDe = "Der Torwart",
            NameSrb = "Голман",
            NameZhHk = "守門員",
            RuleNumber = "5",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper BLACK 1 saves a shot on goal and starts a counter-attack. In doing so, he crosses the goal-area line with his left foot. Correct decision?",
                    PhraseNl =
                        "Doelman ZWART1 kan een doelworp opvangen en de tegenaanval starten. Hierbij overschrijdt hij met de linkervoet de doelgebied lijn. Juiste beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман ЦРНИ 1 зауставља шут на гол и почиње противнапад, притом својим левим стопалом прелази линију голмановог простора. Исправна одлука?",
                    PhraseZhHk = "黑隊守門員1號擋住射門的球後並發動反擊，但在擲球時他的左腳越過了禁區線。如何判決？",
                    QuestionNumber = "5.1",
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
                            Phrase = "Repeat goalkeeper throw after restart signal",
                            PhraseNl = "Uitworp laten hernemen na een herstart fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање голмановог бацања после звиждука",
                            PhraseZhHk = "鳴哨後重擲守門員球",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 12 is standing outside his goal area on the court. While receiving the ball from a teammate, the goalkeeper steps back with one foot into the goal area, while the other foot remains where it is. Correct decision?",
                    PhraseNl =
                        "Doelman WIT12 staat buiten zijn doelgebied in het speelveld. Terwijl hij de bal toegespeeld krijgt door een ploegmaat, gaat de doelman een stap achteruit met een voet in het doelgebied terwijl de andere voet in het speelveld blijft. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман БЕЛИ 12 стоји изван свог голмановог простора, у пољу за игру. Примајући лопту од саиграча, голман БЕЛИ 12 направи корак уназад у властити голманов простор, а другом ногом остане у пољу за игру. Исправна одлука?",
                    PhraseZhHk = "白隊守門員12號站在禁區前的比賽場地，接到隊友的傳球後，向後一移，一隻腳踏入了己方的禁區內，另一隻腳還在禁區外。如何判决？",
                    QuestionNumber = "5.2",
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
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Verder spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
                            PhraseZhHk = "比賽繼續",
                            AnswerNumber = "b"
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
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for goalkeeper WHITE 12",
                            PhraseNl = "2-minuten uitsluiting voor doelman WIT12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Два минута искључења за голмана БЕЛОГ 12",
                            PhraseZhHk = "白隊守門員12號退場兩分鐘",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 12 saves a shot by diving towards the ball, which is moving in the direction of the playing area. WHITE 12 reaches the ball, but slides across the goal-area line and passes the ball in the playing area to a teammate. Correct decision?",
                    PhraseNl =
                        "Doelman WIT12 weert een worp af door naar de bal te duiken die zich in de richting van het speelveld beweegt. WIT12 bereikt de bal, maar glijdt over de doelgebied lijn en speelt in het speelveld een medespeler aan. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман БЕЛИ 12 брани шут и баца се на лопту која иде у смеру поља за игру. Голман БЕЛИ 12 хвата лопту и клизне преко линије голмановог простора, а затим дода лопту у поље за игру свом саиграчу. Исправна одлука?",
                    PhraseZhHk = "白隊守門員12號擋了射門的球後，球彈向場內，白隊12號飛撲接球。在接着球時，他的身體亦同時正滑出禁區線外，躺在比賽場內的地上將球傳給隊友。如何判決？",
                    QuestionNumber = "5.3",
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
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Verder spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекидања",
                            PhraseZhHk = "比賽繼續",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team after whistle signal",
                            PhraseNl = "Uitworp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу А после звучног сигнала",
                            PhraseZhHk = "鳴哨後由白隊擲守門員球",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper BLACK 1 stops a shot on goal. The ball is rolling towards the playing area. To stop the ball before it reaches WHITE 15, who is waiting at the goal-area line, he slides it with his foot across the outer goal line just before it reaches WHITE 15. Correct decision?",
                    PhraseNl =
                        "Doelman ZWART1 stopt een doelworp. De bal rolt richting het speelveld. Om de bal te stoppen vooraleer hij WIT15 bereikt, die aan de doelgebied lijn wacht, glijdt hij met zijn voet de bal over de buiten doellijn, net voordat de bal WIT15 bereikt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман ЦРНИ 1 зауставља шут на гол. Лопта се котрља према пољу за игру. У покушају да спречи да лопта дође до играча БЕЛОГ 15 који је чека на линији голмановог бацања, он одбије лопту ногом баш пре него што је играч БЕЛИ 15 дохвати, и тако је избаци преко гол-аут линије. Исправна одлука?",
                    PhraseZhHk = "黑隊守門員1號擋了射門的球，球滾動向比賽場地，爲了不讓靠近禁區線的白隊15號接到球，守門員用腳將球踢出底線外。如何判決？",
                    QuestionNumber = "5.4",
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
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Verder spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
                            PhraseZhHk = "比賽繼續",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against BLACK 1 since he has endangered an opponent",
                            PhraseNl =
                                "Progressieve bestraffing van ZWART1 omdat hij een tegenstrever in gevaar heeft gebracht",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивно кажњавање за голмана ЦРНОГ 1 зато што је угрозио противника",
                            PhraseZhHk = "漸進處罰黑隊守門員1號，因為他危及對方安全",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 12 has not managed to get the ball under control. The ball moves inside the goal area towards the side line. The goalkeeper uses his foot to play the ball across the outer goal line. Correct decision?",
                    PhraseNl =
                        "Doelman WIT12 heeft de bal niet onder controle gekregen. De bal beweegt zich in het doelgebied in de richting van de zijlijn. De doelman gebruikt zijn voet om de bal over de buiten doellijn te spelen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман БЕЛИ 12 не успева да задржи лопту под контролом. Лопта у голмановом простору иде према аут линији. Голман игра ногом и избаци лопту преко гол-аут линије. Исправна одлука?",
                    PhraseZhHk = "白隊守門員12號未能把球控制住，球在禁區內滾動向邊線，守門員用腳將球踢出底線外。如何判決？",
                    QuestionNumber = "5.5",
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
                            Phrase = "Throw-in for BLACK team",
                            PhraseNl = "Inworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут за ЦРНУ екипу",
                            PhraseZhHk = "黑隊界外球",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against the goalkeeper",
                            PhraseNl = "Progressieve bestraffing van de doelman",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против голмана",
                            PhraseZhHk = "漸進處罰守門員",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 1 blocks a shot. The ball rolls in the direction of the playing area, where BLACK 6 waits alone to pick up the ball. WHITE 1 manages to stop the ball with his foot, when the ball is on the goal-area line. Correct decision?",
                    PhraseNl =
                        "Doelman WIT1 blokt een worp, de bal rolt in de richting van het speelveld, waar ZWART6 alleen staat om hem op te rapen. WIT1 slaagt erin om de bal met de voet te stoppen wanneer de bal zich op de doelgebied lijn bevindt, Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман БЕЛИ 1 брани шут. Лопта се котрља према пољу за игру, где ЦРНИ 6 чека сам да је подигне. Голман БЕЛИ 1 успева да заустави лопту ногом, кад она дође на линију голмановог простора. Исправна оглука?",
                    PhraseZhHk = "白隊守門員1號擋了射門的球後，球滾動向比賽場地。在禁區線外只有黑隊6號獨自等候接球。白隊守門員1號在球滾動到禁區線上時用腳把球截停。如何判決？",
                    QuestionNumber = "5.6",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team after whistle signal",
                            PhraseNl = "Uitworp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу после звиждука",
                            PhraseZhHk = "鳴哨後白隊擲守門員球",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against WHITE 1",
                            PhraseNl = "Progressieve bestraffing voor doelman WIT1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против БЕЛОГ 1",
                            PhraseZhHk = "漸進處罰白隊守門員1號",
                            AnswerNumber = "b"
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
                            AnswerNumber = "c",
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
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 18 takes a shot on goal. The shot is blocked by WHITE 7, so that the ball changes direction and goes clearly in the direction of the outer goal line inside the goal area. Goalkeeper WHITE 1 runs after the ball and manages to put it over the outer goal line with his foot. Correct decision?",
                    PhraseNl =
                        "ZWART18 werpt naar het doel. De worp wordt geblokt door WIT7, waardoor de bal van richting verandert en duidelijk in de richting gaat van de buitendoellijn binnen het doelgebied. Doelman WIT1 loopt de bal na en slaagt er in hem met de voet over de buitendoellijn te leiden. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНИ 18 шутира на гол. Шут је изблокиран од БЕЛОГ 7, тако да лопта промени правац и иде јасно изван гол линије (унутар голмановог простора). Голман БЕЛИ 1 трчи за лоптом и помаже јој, ногом, да пређе гол-аут линију. Исправна одлука?",
                    PhraseZhHk = "白隊7號擋了黑隊18號射門的球後，球改變方向，明顯地向外底線方向(禁區內)滾去，白隊守門員1號追上去用腳使球越出外底線。如何判決？",
                    QuestionNumber = "5.7",
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
                            Phrase = "Throw-in for BLACK team",
                            PhraseNl = "Inworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут за ЦРНУ екипу",
                            PhraseZhHk = "黑隊界外球",
                            AnswerNumber = "b"
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
                            Phrase = "Warning for WHITE 1",
                            PhraseNl = "Waarschuwing voor WIT1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена БЕЛОМ 1",
                            PhraseZhHk = "警告白隊1號",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper BLACK 12 jumps up in his goal area to catch a long pass from WHITE 7. BLACK 12 catches the ball while he is in the air and lands with the ball with one foot in the goal area and one foot in the playing area. In this position he plays the ball to BLACK 3. Correct decision?",
                    PhraseNl =
                        "Doelverdediger ZWART12 springt op in zijn doelgebied om een lange bal te onderscheppen van WIT7. ZWART12 pakt de bal terwijl hij in de lucht hangt en landt met de bal met één voet in het doelgebied en één voet in het speelveld. In deze positie speelt hij de bal naar ZWART3. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман ЦРНИ 12 скочи увис у свом голмановом простору да ухвати дуго додавање према играчу БЕЛОМ 7. ЦРНИ 12 хвата лопту док је у ваздуху и доскаче једном ногом у голманов простор, а другом у поље за игру, држећи лопту у рукама. Из те позиције дода лопту до играча ЦРНОГ 3. Исправна одлука?",
                    PhraseZhHk = "黑隊守門員12號在禁區內跳起截取對隊長傳給白隊7號的球，他在空中接球後落地，一腳落在禁區內，另一腳落在禁區外，在該位置上傳球給黑隊3號。如何判決？",
                    QuestionNumber = "5.8",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "7-metre throw to WHITE team",
                            PhraseNl = "7-m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екупу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "a"
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
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw to WHITE team",
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
                            Phrase = "Correction and goalkeeper throw after whistle signal",
                            PhraseNl = "Correctie en uitworp na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Корекција голмановог бацања после звучног сигнала",
                            PhraseZhHk = "更正位置，鳴哨後擲守門員球",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 9 passes the ball to his goalkeeper WHITE 1, who is standing in the playing area. Because WHITE 9 is under pressure, he throws the ball too high, so that WHITE 1 must move back and enter the goal area with one foot, immediately after catching the ball. Correct decision?",
                    PhraseNl =
                        "WIT9 speelt de bal naar zijn doelverdediger WIT1 die in het speelveld staat. Omdat WIT9 onder druk staat, gooit hij de bal te hoog zodat WIT1 achteruit moet gaan en zijn doelgebied met één voet betreedt, onmiddellijk nadat hij de bal heeft gevangen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 9 додаје лопту своме голману БЕЛОМ 1, који стоји у пољу за игру. БЕЛИ 9 је на исправан начин ометан, зато баца лопту превише високо, тако да је голман БЕЛИ 1 принуђен да се врати назад и уђе у голманов простор једном ногом, у тренутку хватања лопте. Исправна одлука?",
                    PhraseZhHk = "白隊9號傳球給站在比賽場內的白隊守門員1號，由於防守的壓迫，白隊9號將球傳得過高，白隊1號必須退後接球，以致一隻腳進入了禁區才能把球接住。如何判決?",
                    QuestionNumber = "5.9",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Game continues without interruption",
                            PhraseNl = "verder spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
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
                            AnswerNumber = "b"
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
                        "The referees give a free throw for WHITE team at the goal-area line of WHITE team. Goalkeeper WHITE 1 is standing with one foot in the goal area and one foot in the playing area. He passes the ball to WHITE 8, who scores a goal. Correct decision?",
                    PhraseNl =
                        "De scheidsrechters geven een vrije worp voor team WIT aan de doelgebied lijn van team WIT. De doelverdediger WIT1 staat met één voet in zijn doelgebied en één voet in het speelveld. Hij speelt de bal naar WIT8 die een doelpunt scoort. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Судије досуђују слободно бацање за БЕЛУ екипу, испред линије голмановог простора БЕЛЕ екипе. Голман БЕЛИ 1 стоји једном ногом у голмановом простору, а другом у пољу за игру. Он додаје лопту играчу БЕЛОМ 8 који постиже гол. Исправна одлука?",
                    PhraseZhHk = "裁判判由白隊在白隊禁區線處擲自由球。白隊守門員1號一腳站在禁區內，另一腳站在禁區外，將球傳給白隊8號並射門得分。如何判決？",
                    QuestionNumber = "5.10",
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
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Repetition of the free throw outside the goal area of WHITE team",
                            PhraseNl = "Herhaling van de vrije worp buiten het doelgebied van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање слободног бацања изван голмановог простора БЕЛЕ екипе",
                            PhraseZhHk = "在白隊禁區外重擲自由球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team at the goal-area line of WHITE team",
                            PhraseNl = "Vrije worp voor ZWART aan de doelgebied lijn van WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу испред голмановог простора БЕЛЕ екипе",
                            PhraseZhHk = "黑隊在白隊的禁區線處擲自由球",
                            AnswerNumber = "c"
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
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7-meter-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The referee whistles because of too many steps by BLACK 21. BLACK 21 puts the ball down at the goal-area line of WHITE team. Goalkeeper WHITE 12 wants to throw the ball quickly. He supports himself with one hand on the floor in the playing area, and he has one foot on the floor in the goal area. From this position he plays the ball to WHITE 3, who starts a counter-attack that leads to a goal for WHITE team. Correct decision?",
                    PhraseNl =
                        "De scheidsrechters fluiten een loopfout tegen ZWART21. ZWART21 legt de bal neer aan de doelgebied lijn van team WIT. Doelverdediger WIT12 wil de vrije worp snel uitvoeren. Met één arm steunt hij buiten het doelgebied, één voet bevindt zich in het doelgebied op de grond. In deze houding past hij de bal naar WIT3, die een tegenaanval start, die tot een doelpunt leidt voor team WIT. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Судија је досудио кораке играчу ЦРНОМ 21. ЦРНИ 21 спушта лопту на тло, на линију голмановог простора БЕЛЕ екипе. Голман БЕЛИ 12 жели брзо да изведе бацање. Он се ослања једном руком о тло у пољу за игру, али истовремено је једним стопалом у голмановом простору. Из овог положаја он додаје лопту играчу БЕЛОМ 3 који почиње контранапад, који се завршава голом за БЕЛУ екипу. Исправна одлука?",
                    PhraseZhHk = "裁判鳴哨判黑隊21號走步，球員將球放在白隊的禁區線旁。白隊守門員16號為了迅速擲球，他用一手支撐在禁區線外的地上，一腳仍在禁區內，把球擲給白隊3號發動反攻，並射進黑隊的球門內。如何判決？",
                    QuestionNumber = "5.11",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Repeat the free throw for WHITE team after whistle signal.",
                            PhraseNl = "Herhaling van de vrije worp met fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање слободног бацања за БЕЛУ екипу после звиждука",
                            PhraseZhHk = "鳴哨後白隊重擲自由球",
                            AnswerNumber = "a",
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
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team because of illegal free-throw execution by WHITE 12",
                            PhraseNl = "Vrije worp voor team ZWART wegens foutieve uitvoering van de vrije worp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Слободно бацање за ЦРНУ екипу, јер је слободно бацање за БЕЛУ екипу изведено на неправилан начин",
                            PhraseZhHk = "黑隊自由球，因為白隊12號擲自由球違規",
                            AnswerNumber = "c"
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
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper BLACK 1 has left his goal area. He jumps up in the playing area, catches a pass from a teammate while in the air, and lands with both feet inside his goal area. Correct decision?",
                    PhraseNl =
                        "Doelverdediger ZWART1 heeft zijn doelgebied verlaten. Hij springt op in het speelveld en vangt een bal, komende van een medespeler, in de lucht, en landt met beide voeten in zijn doelgebied. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман ЦРНИ 1 је напустио свој голманов простор. Он скаче у пољу за игру и хвата додавање од свог саиграча док је у ваздуху. Затим пада, са оба стопала, у свој голманов простор. Исправна одлука?",
                    PhraseZhHk = "黑隊守門員1號離開了禁區，他從比賽場地跳起，在空中接住隊友回傳的球後，雙腳落在禁區內。如何判決？",
                    QuestionNumber = "5.12",
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
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за ЦРНУ екипу",
                            PhraseZhHk = "黑隊守門員球",
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
                            PhraseNl = "7-meter worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            PhraseZhHk = "白隊七米球",
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
                        "The ball is on the floor right outside the goal area of WHITE team. Goalkeeper WHITE 1 stands inside the goal area and picks up the ball to prevent an opponent from taking it. Correct decision?",
                    PhraseNl =
                        "De bal ligt op de vloer net buiten het doelgebied van team WIT. Doelverdediger WIT1 staat in zijn doelgebied en raapt de bal op om te verhinderen dat een tegenspeler hem zou bemachtigen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Лопта је на поду, одмах изван голмановог простора БЕЛЕ екипе. Голман БЕЛИ 1 стоји унутар голмановог простора и подиже лопту, да би спречио противника да је узме. Исправна одлука?",
                    PhraseZhHk = "球在白隊禁區外緊貼禁區線的地上，站在禁區內的白隊守門員1號為了阻止對方獲球而將球拾起。如何判決？",
                    QuestionNumber = "5.13",
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
                            PhraseNl = "7-meter worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            PhraseZhHk = "黑隊七米球",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for WHITE 1",
                            PhraseNl = "Progressieve bestraffing van WIT1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна за БЕЛОГ 1",
                            PhraseZhHk = "漸進處罰白隊1號",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "No intervention because it is allowed",
                            PhraseNl = "Geen tussenkomst van de scheidsrechters omdat dit toegelaten is",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Нема интервенције, зато што је ово дозвољено",
                            PhraseZhHk = "不作處理，因為這是容許的",
                            AnswerNumber = "d"
                        }
                    ]
                }
            ]
        };
    }
}
