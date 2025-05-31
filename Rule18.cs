using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule18()
    {
        return new RuleDto
        {
            Name = "The Timekeeper and the Scorekeeper",
            NameNl = "De Tijdopnemer en de Secretaris",
            NameFr = "Le Chronométreur et le Secrétaire",
            NameSvn = "Časomerilec In Zaposnikar",
            NameDe = "Zeitnehmer und Sekretär",
            NameSrb = "Мерилац времена и записничар",
            NameZhHk = "計時員及記錄員",
            RuleNumber = "18",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "What do the Rules of the Game prescribe regarding the work distribution between timekeeper and scorekeeper?",
                    PhraseNl =
                        "Wat schrijven de spelregels voor met betrekking tot de taakverdeling tussen tijdwaarnemer en wedstrijdsecretaris?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Шта Правила игре прописују у погледу поделе посла између мериоца времена и записничара?",
                    PhraseZhHk = "下列那些是屬於規則內關於計時員和記錄員的分工？",
                    QuestionNumber = "18.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The control of the entry and exit of the substitutes is handled only by the timekeeper.",
                            PhraseNl =
                                "De controle op het betreden en het verlaten van het speelveld door de wisselspelers is voorbehouden aan de tijdwaarnemer.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Контролу уласка и изласка замена врши само мерилац времена",
                            PhraseZhHk = "進出替補區的情況，僅屬於計時員的職責",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Generally, only the timekeeper should interrupt the game, when this becomes necessary.",
                            PhraseNl =
                                "In het algemeen, zou enkel de tijdwaarnemer het spel moeten onderbreken, wanneer dit noodzakelijk is.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Генерално, само мерилац времена треба да прекине игру, када је то неопходно",
                            PhraseZhHk = "一般而言，只有計時員才可以在必要時打擾比賽",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The scorekeeper must whistle, if he observes that a substitute enters the court too soon.",
                            PhraseNl =
                                "De wedstrijdsecretaris moet fluiten, wanneer hij vaststelt dat een uitgesloten speler te vroeg het speelveld betreedt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Записничар мора да свира када уочи да је замена ушла на терен прерано",
                            PhraseZhHk = "如發現替補球員過早進場，記錄員必須鳴哨",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "If there is no public clock, the timekeeper keeps the teams informed about how much time has been played or how much time remains.",
                            PhraseNl =
                                "Wanneer er geen muurklok beschikbaar is, houdt de tijdwaarnemer beide teams op de hoogte omtrent de gespeelde of nog te spelen tijd.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Ако нема јавног мерења времена, мерилац времена информише екипе о времену игре или о томе колико је још времена остало да се игра",
                            PhraseZhHk = "若沒有使用公開計時器，計時員必須讓球隊知道比賽進行了多少時間或剩餘時間",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Counting the number of attacks when a player is serving 3 attacks after receiving medical care on the court is a shared task for the timekeeper and scorekeeper.",
                            PhraseNl =
                                "Het tellen van het aantal aanvallen, wanneer een speler na verzorging op het speelveld, 3 aanvallen moet afblijven, is een gezamenlijke taak van de wedstrijdsecretaris en de tijdwaarnemer.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Рачунање броја напада када је играч у обавези да паузира 3 напада, после указане медицинске помоћи на терену, је заједнички задатак за мериоца времена и записничара",
                            PhraseZhHk = "", //TODO 計算球員在場上接受醫療護理後，必須休息三次進攻的次數，是計時員和記錄員的共同任務
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 5 has a clear chance of scoring. Team official A from WHITE team insults the timekeeper. The timekeeper whistles just when WHITE 5 is about to shoot. The action has been noticed only by the timekeeper. Correct decision?",
                    PhraseNl =
                        "WIT5 heeft een duidelijke scorekans. Team official A van team WIT beledigt de tijdwaarnemer. De tijdwaarnemer fluit net op het ogenblik dat WIT5 gaat werpen. De actie is enkel opgemerkt door de tijdwaarnemer. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 5 је у јасној ситуацији за постизање гола. Званичник А БЕЛЕ екипе вређа мериоца времена. Мерилац времена свира баш када је БЕЛИ 5 спреман да шутира. Ову ситуацију је регистровао само мерилац времена. Исправна одлука?",
                    PhraseZhHk = "白隊5號有一明顯得分機會，當白隊5號正準備射門時，計時員因被白隊球隊職員A侮辱而鳴哨。如何判決？",
                    QuestionNumber = "18.2",
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
                            Phrase = "Punishment against team official A from WHITE team",
                            PhraseNl = "Bestraffing van team official A van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Казна против званичника А БЕЛЕ екипе",
                            PhraseZhHk = "漸進處罰白隊球隊職員A",
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
                            Phrase = "Written report",
                            PhraseNl = "Schriftelijk verslag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Писани извештај",
                            PhraseZhHk = "作出書面報告",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The responsible team official from WHITE team insults the scorekeeper, without this being noticed by the referees or a delegate. During the next interruption of the game, the scorekeeper informs the referees about what has happened. Correct decision?",
                    PhraseNl =
                        "De verantwoordelijke team official van team WIT beledigt de wedstrijdsecretaris, zonder dat de scheidsrechters of de waarnemer dit bemerken. Bij de volgende spelonderbreking van het spel, informeert de wedstrijdsecretaris de scheidsrechters over wat er gebeurd is. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Одговорни представник БЕЛЕ екипе вређа записничара, а да то судије и делегат нису приметили. Када је игра следећи пут прекинута, записничар обавештава судије о томе што се догодило. Исправна одлука?",
                    PhraseZhHk = "白隊“球隊職員代表”侮辱記錄員，但裁判沒有發覺；在接著的比賽中斷時，記錄員將事件知會了裁判。如何判決？",
                    QuestionNumber = "18.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of the responsible team official from WHITE team, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor de verantwoordelijke team official van team WIT, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација одговорног представника БЕЛЕ екипе; Писани извештај (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消白隊“球隊職員代表”資格，作出書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for the responsible team official of WHITE team",
                            PhraseNl = "2-minuten uitsluiting voor de verantwoordelijke team official van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против одговорног представника БЕЛЕ екипе",
                            PhraseZhHk = "白隊“球隊職員代表”退場兩分鐘",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Written report",
                            PhraseNl = "Schriftelijk verslag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Писани извештај",
                            PhraseZhHk = "提交書面報告",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for the responsible team official from WHITE team",
                            PhraseNl = "Waarschuwing voor de verantwoordelijke team official van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена одговорном представнику БЕЛЕ екипе",
                            PhraseZhHk = "警告白隊“球隊職員代表”",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "No personal punishment possible",
                            PhraseNl = "Geen persoonlijke bestraffing mogelijk",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Лична казна није могућа",
                            PhraseZhHk = "不會進行個人處罰",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in possession of the ball at the free-throw line of BLACK team. The technical delegate interrupts the game and explains to the referees that official A from BLACK team has insulted him. Correct decision?",
                    PhraseNl =
                        "Team WIT is in balbezit aan de vrije worplijn van team ZWART. De waarnemer onderbreekt het spel en legt de scheidsrechters uit dat official A van team ZWART hem beledigd heeft. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛА екипа има лопту на линији 9 метара ЦРНЕ екипе. Технички делегат прекида игру и објашњава судијама да га је званичник А ЦРНЕ екипе вређао. Исправна одлука?",
                    PhraseZhHk = "白隊在黑隊自由球線處控球；這時，技術代表中斷比賽，並告訴裁判黑隊球隊職員A辱罵他。如何判決？",
                    QuestionNumber = "18.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Caution for official A from BLACK team, written report",
                            PhraseNl = "Vermaning voor official A van team ZWART, schriftelijk verslag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Упозорење званичнику А ЦРНЕ екипе, писани извештај",
                            PhraseZhHk = "警告黑隊球隊職員A，提交書面報告",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of official A from BLACK team, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van official A van team ZWART, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација званичника А ЦРНЕ екипе, писани извештај (црвени и плави картон показани од стране судија)",
                            PhraseZhHk = "取消黑隊球隊職員A資格，提交書面報告（裁判出示紅牌及藍牌）",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The game is restarted with a free throw for WHITE team at the substitution area of BLACK team.",
                            PhraseNl =
                                "Het spel wordt hernomen met een vrije worp voor team WIT aan de wisselzone van team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Игра се наставља слободним бацањем за БЕЛУ екипу код простора за замену играча ЦРНЕ екипе",
                            PhraseZhHk = "由白隊在黑隊替補區擲自由球恢復比賽",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The game is restarted with a free throw for WHITE team at the free-throw line of BLACK team.",
                            PhraseNl =
                                "Het spel wordt hernomen met een vrije worp voor team WIT aan de vrije worplijn van team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Игра се наставља слободним бацањем за БЕЛУ екипу са линије слободног бацања ЦРНЕ екипе",
                            PhraseZhHk = "由白隊在黑隊自由球線擲自由球恢復比賽",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in possession of the ball at the free-throw line of BLACK team. The timekeeper interrupts the game and explains to the referees that official A from WHITE team has insulted him. The action has been noticed only by the timekeeper. Correct decision?",
                    PhraseNl =
                        "Team WIT is in balbezit aan de vrije worplijn van team ZWART. De tijdwaarnemer onderbreekt het spel en legt aan de scheidsrechters uit dat official A van team WIT hem beledigd heeft. Deze actie werd enkel door de tijdwaarnemer vastgesteld. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛА екипа има лопту на линији слободног бацања ЦРНЕ екипе. Мерилац времена прекида утакмицу и каже судијама да га је званичник А БЕЛЕ екипе вређао. Ову ситуацију је регистровао само мерилац времена. Исправна одлука?",
                    PhraseZhHk = "白隊在黑隊自由球線處控球，計時員鳴哨中斷比賽，並告訴裁判白隊球隊職員A侮辱他，但這個行為只有計時員本人注意到。如何判決？",
                    QuestionNumber = "18.5",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Written report",
                            PhraseNl = "Schriftelijk verslag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Писани извештај",
                            PhraseZhHk = "提交書面報告",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for official A from WHITE team, written report",
                            PhraseNl = "2-minuten uitsluiting voor official A van team ZWART, schriftelijk verslag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против званичника А БЕЛЕ екипе, писани извештај",
                            PhraseZhHk = "白隊球隊職員A被判退場兩分鐘，提交書面報告",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The game is restarted with a free throw for BLACK team at the substitution area of WHITE team.",
                            PhraseNl =
                                "Het spel wordt hernomen met een vrije worp voor team ZWART aan de wisselzone van team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Игра се наставља слободним бацањем за ЦРНУ екипу, код простора за замену играча БЕЛЕ екипе",
                            PhraseZhHk = "由黑隊在白隊替補區擲自由球恢復比賽",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The game is restarted with a free throw for WHITE team at the free-throw line of BLACK team.",
                            PhraseNl =
                                "Het spel wordt hernomen met een vrije worp voor team WIT aan de vrije worp lijn van team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Игра се наставља слободним бацањем за БЕЛУ екипу, са линије слободног бацања ЦРНЕ екипе",
                            PhraseZhHk = "由白隊在黑隊自由球線擲自由球恢復比賽",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "During the match, official A from WHITE team repeatedly moves to the timekeeper’s desk to coach right next to it. While doing so he protests over referee decisions. Due to the noise in the playing hall, the referees do not notice this. Correct decision?",
                    PhraseNl =
                        "De official A van team WIT begeeft zich tijdens het spel herhaaldelijk naar de wedstrijdtafel om van vlak ernaast te coachen. Daarbij protesteert hij tegen de beslissingen van de scheidsrechters. Door het lawaai in de hal merken de scheidsrechters dit niet op. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "За време утакмице одговорни представник БЕЛЕ екипе више пута долази скроз до записничког стола и одатле саветује своје играче на терену. Док то чини, он протестује против одлука судија. Услед буке у хали судије то нису приметиле. Исправна одлука?",
                    PhraseZhHk = "比賽期間，白隊球隊職員A重覆地移向紀錄台旁教授其球員戰術，同時亦抗議裁判的判決。由於比賽場館嘈吵，裁判未有聽到有關抗議，如何判決？",
                    QuestionNumber = "18.6",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The timekeeper immediately interrupts the game and informs the referees about official A’s misbehaviour.",
                            PhraseNl =
                                "De tijdwaarnemer onderbreekt onmiddellijk het spel en licht de scheidsrechters in over het foute gedrag van official A van team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Мерилац времена тренутно прекида игру и обавештава судије о лошем понашању одговорног представника БЕЛЕ екипе",
                            PhraseZhHk = "計時員必需即時鳴哨暫停比賽，通知裁判有關白隊球隊職員A的行為",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The timekeeper waits until the next interruption of the game and informs the referees about official A’s misbehaviour.",
                            PhraseNl =
                                "De tijdwaarnemer wacht tot de volgende onderbreking van het spel en licht de scheidsrechters in over het foute gedrag van official A van team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Мерилац времена чека следећи прекид игре и обавештава судије о лошем понашању одговорног представника БЕЛЕ екипе",
                            PhraseZhHk = "計時員需等待下一次比賽中斷時，通知裁判有關白隊球隊職員A的行為",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for official A from WHITE team",
                            PhraseNl = "Progressieve bestraffing voor official A van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против одговорног представника БЕЛЕ екипе",
                            PhraseZhHk = "漸進處罰白隊球隊職員",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "No punishment possible",
                            PhraseNl = "Geen bestraffing mogelijk",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Казна није могућа",
                            PhraseZhHk = "不用判罰",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "When should the timekeeper/scorekeeper inform the referees about a violation of the Substitution Area Regulations that has not been noticed by the referees?",
                    PhraseNl =
                        "Wanneer zouden de tijdwaarnemer/wedstrijdsecretaris de scheidsrechters moeten informeren over een inbreuk op het wisselzone reglement die niet door de scheidsrechters werd opgemerkt?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Када треба мерилац времена/записничар да информише судије о прекршајима правила о простору за замену играча, које судије нису регистровале?",
                    PhraseZhHk = "如果裁判不知道球隊違犯替補區規則時(非替補犯規)，計時員或記錄員應何時通知裁判？",
                    QuestionNumber = "18.7",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Immediately",
                            PhraseNl = "Onmiddellijk",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тренутно",
                            PhraseZhHk = "立即",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "At the time of the next interruption of the game",
                            PhraseNl = "Bij de eerstvolgende spelonderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "У време следећег прекида игре",
                            AnswerNumber = "b",
                            PhraseZhHk = "下一次比賽中斷時",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "If the technical delegate interrupts the game because of a violation by WHITE team when the ball is in play, the game is restarted with ball possession by BLACK team. Correct?",
                    PhraseNl =
                        "Indien de waarnemer het spel onderbreekt omwille van een overtreding van team WIT wanneer de bal in het spel is, wordt het spel hernomen met balbezit voor team ZWART. Correct?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Ако технички делегат прекине игру, због прекршаја учињеног од стране БЕЛЕ екипе а при томе је лопта у игри, да ли се игра наставља поседом лопте за ЦРНУ екипу?",
                    QuestionNumber = "18.8",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Yes",
                            PhraseNl = "Ja",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Да",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "No",
                            PhraseNl = "Neen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Не",
                            AnswerNumber = "b"
                        }
                    ]
                }
            ]
        };
    }
}
