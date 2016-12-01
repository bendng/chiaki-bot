using Discord;
using Discord.Commands;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chiaki
{
    class MyBot
    {
        DiscordClient discord;
        CommandService commands;

        Random rand;

 public async Task ChangeAvatar()
        {
            await Discord.CurrentUser.Edit(avatar: new System.IO.FileStream("mura/71.png", System.IO.
                FileMode.Open), avatarType: ImageType.Png);

        }

        string[] myWife;

        string[] randomTexts;
        private string[] flipCoin;
        private string[] coinToPost;
        private string[] randomMura;
        private string[] randomPen;
        private string[] randomDion;
        private string[] randomUni;
        private string[] randomChancey;
        private string[] random8Ball;
        private string[] randomBen;
        private string[] randomRoast;
        private string[] randomWat;
        private string[] randomGift;

        public MyBot()
        {
            rand = new Random();

            myWife = new string[]
            {
                "pics/wife1.png",    // 0
                "pics/wife2.png" ,   // 1 
                "pics/wife3.png",    // 2
                "pics/wife4.png",
                "pics/wife5.png",
                "pics/wife6.jpg",
                "pics/wife7.jpg",
                "pics/wife8.jpg",
                "pics/wife9.jpg",
                "picswife10.png"
            };

            randomTexts = new string[]
            {
                "hello",
                "greetings",
                "alola",
                "please die",
                "die in 8 fires",
                ":heart:"

            };

            flipCoin = new string[]
             {
                "heads",
                "tails"
             };

            randomMura = new string[]
            {
                "<@127316955047657472> get pinged gay boi",
                "mura wears fake jordans",
                "has no waifu but luci sure is juicy tho :eyes:"
            };

            randomPen = new string[]
            {
                "'s penile is 8=======================D",
                "'s penile is 8D",
                "'s penile is 8=D",
                "'s penile is 8=======D",
                "'s penile is 8=================================================D",
                "'s penile is 8==============D",
                "'s penile is 8=======D",
                "'s penile is literally non-existant."
            };

            randomDion = new string[]
            {
                "dion/dion1.jpg",
                "dion/dion.jpg",
                "dion/dion2.jpg",
                "dion/dion3.jpg",
                "dion/dion4.jpg",
                "dion/dion5.jpg"
            };

            randomUni = new string[]
            {
                "uni/LO.png",
                "uni/GA.png",
                "uni/VA.PNG",
                "uni/uni.jpg"
            };

            randomChancey = new string[]
            {
                "chancey/sp1.jpg",
                "chancey/sp2.jpg",
                "chancey/sp3.jpg",
                "chancey/sp4.jpg",
                "chancey/sp5.jpg",
                "chancey/sp6.jpg"
            };

            random8Ball = new string[]
            {
                "no",
                "yes",
                "100% no",
                "maybe",
                "i cant decide...",
                "kill yourself",
                "100% yes",
                "ummm please try again",
                ":thinking:",
                "you're stupid to even consider it",
                "LUL",
                "yes daddy",
                "you're disgusting, no",
                ":3c..."
            };

            randomBen = new string[]
            {
                "<@81633420542742528> you are an amazing human being and deserve only the best",
                "<@81633420542742528> is pretty much god",
                "<@81633420542742528> :heart:",
                "<@81633420542742528> http://puu.sh/s6IoQ/9a461918ed.jpg",
                "<@81633420542742528> everybody should kneel before your presence :clap:"
            };

            randomRoast = new string[]
            {
                "benroast/ben1.png",
                "benroast/ben2.png",
                "benroast/ben3.png",
                "benroast/ben4.png",
                "benroast/ben5.png",
                "benroast/ben6.png",
                "benroast/ben7.PNG",
                "benroast/ben8.png"
            };
            randomGift = new string[]
            {
                "autism.",
                "love! :heart:",
                "a free shadowrealm",
                "str8 up timbs",
                "unlimited memes",
                "anime pussy",
                "a jamaican cat",
                "a noose to hang yourself with!",
                "whipped cream ;)",
                "the succ... :eyes:",
                "uni's ironing board",
                "something to take the edge off",
                "dions good ass lipstick :ok_hand:",
                "your virginity back",
                "a free ticket for nudes! pm ben to redeem"
            };
       

            randomWat = new string[]
            {
                "wat/excuse.png",
                "wat/watbich.png"
            };

            discord = new DiscordClient(x =>
            {
                x.LogLevel = LogSeverity.Info;
                x.LogHandler = Log;
            });



            discord.UsingCommands(x =>
            {
                x.PrefixChar = ';';
                x.AllowMentionPrefix = true;
            });

            commands = discord.GetService<CommandService>();

            RegisterHelloCommand();

            RegisterWifeCommand();

            StartPurge();

            RegisterThonkangCommand();

            RegisterCoinCommand();

            RegisterHelpCommand();

            RegisterMuraCommand();

            RegisterPenileCommand();

            RegisterDionCommand();

            RegisterUniCommand();

            RegisterChanceyCommand();

            RegisterTekiCommand();

            RegisterLULCommand();

            RegisterBenCommand();

            RegisterbenRoastCommand();

            RegisterPtestCommand();

            RegisterBoxBoxCommand();

            RegisterKaioCommand();

            RegisterIdtestCommand();

            RegisterChristmasCommand();

            RegisterWatCommand();

            RegisterGiftCommand();

            discord.MessageReceived += bot_MessageReceived

            ; discord.MessageReceived += ball_MessageReceived

            ; discord.ExecuteAndWait(async () =>
            {
                await discord.Connect("MjQzMDg0MTg5NTU2MDE1MTA0.Cv01Tg.E1aomcKixOuGcTyI857TcIoA6dw", TokenType.Bot);              
                discord.SetGame("liz sux / ;chelp");
                discord.SetStatus(UserStatus.Idle);
            });





        }

        private void RegisterGiftCommand()
        {
            commands.CreateCommand("gift")
                 .Do(async (e) =>
                 {
                     int RandomGiftIndex = rand.Next(randomGift.Length);
                     string giftToPost = randomGift[RandomGiftIndex];
                     await e.Channel.SendMessage(e.User.Mention + " :santa: my gift i give to you is, " +  giftToPost);
                 });
        }

        private void RegisterWatCommand()
        {
            commands.CreateCommand("tf")
                .Do(async (e) =>
                {
                    int RandomWatIndex = rand.Next(randomWat.Length);
                    string watToPost = randomWat[RandomWatIndex];
                    await e.Channel.SendFile(watToPost);
                });
        }

        private void RegisterChristmasCommand()
        {
            commands.CreateCommand("christmas")
                .Do(async (e) =>
                {
                    await e.User.SendMessage("IT CHRIMA");
                  await e.User.SendMessage("IT CHRIMA");
                    await e.User.SendMessage("IT CHRIMAAAAAAAAAAAAAAAA");
                });
        }

        private void RegisterIdtestCommand()
        {
            commands.CreateCommand("verify")
                .Do(async (e) =>
                {
                    if (e.User.Id == 81633420542742528)
                    {
                        await e.Channel.SendMessage("hi ben :wave:");
                    }
                    else if (e.User.ServerPermissions.SendMessages)
                    {
                        await e.Channel.SendMessage("you're the equivilant of DeathCrossome");
                    }
                });
        }

        private void RegisterKaioCommand()
        {
            commands.CreateCommand("kaio")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("http://lmgtfy.com/?q=glasses");
                });
        }

        private void RegisterBoxBoxCommand()
        {
            commands.CreateCommand("slap")
                 .Parameter("prsn")
                 .Do(async (e) =>
                 {
                     await e.Channel.SendMessage(e.GetArg("prsn") + " https://puu.sh/ryfon/ac80170d06.jpg DONT TOUCH DA CHILD says" + e.User.Mention);

                 });
        }

        private void RegisterPtestCommand()
        {
            commands.CreateCommand("ptest")
                .Parameter("msg")
                .Do(async (e) =>
                {
                    if (e.User.ServerPermissions.SendMessages == true)
                    {
                        


                        await e.Channel.SendMessage(e.GetArg("msg") + " parameter(s)");
                    }
                });
        }


        private void RegisterbenRoastCommand()
        {
            commands.CreateCommand("benRoast")
                .Do(async (e) =>
                {
                    int randomRoastIndex = rand.Next(randomRoast.Length);
                    string roastToPost = randomRoast[randomRoastIndex];
                    await e.Channel.SendFile(roastToPost);
                });
        }

        private void RegisterBenCommand()
        {
            commands.CreateCommand("ben")
                .Do(async (e) =>
                {
                    int RandomBenIndex = rand.Next(randomBen.Length);
                    string benToPost = randomBen[RandomBenIndex];
                     await  e.Channel.SendMessage(benToPost);
                    {
                     await e.Channel.SendMessage(e.User.Mention + " :gun:");
                    }
                    
                });
        }

        private async void ball_MessageReceived(object sender, Discord.MessageEventArgs e)
        {
            if (e.Message.RawText.StartsWith(";8ball"))
            {


                int Random8BallIndex = rand.Next(random8Ball.Length);
                string ballToPost = random8Ball[Random8BallIndex];
                await e.Channel.SendMessage(ballToPost);
            }
        }

        private void RegisterLULCommand()
        {
            commands.CreateCommand("LUL")
                .Do(async (e) =>
               {
                   await e.Channel.SendFile("LUL/LUL.png");
               });
        }

        static void bot_MessageReceived(object sender, Discord.MessageEventArgs e)
        {
           if (e.Message.RawText.Contains("i want to die") | e.Message.RawText.Contains ("I WANT TO DIE") | e.Message.RawText.Contains("i wanna die"))
            {     
                e.Channel.SendMessage("me too");            
            }
           else if (e.Message.RawText.StartsWith(":v"))
            {
                e.Channel.SendMessage("wkwkwk i indo");
            }
            else if (e.Message.RawText.StartsWith("<@243084189556015104> ping"))
            {
                e.Channel.SendMessage(e.User.Mention + " i am here");
            }
            if (e.Message.RawText.StartsWith(";avatar"))
                {
                e.Channel.SendMessage(e.User.AvatarUrl);
            }

        }

        private void RegisterTekiCommand()
        {
            commands.CreateCommand("teki")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("teki/teki1.png");
                });
        }

        private void RegisterChanceyCommand()
        {
            commands.CreateCommand("chancey")
                .Do(async (e) =>
                {
                    int RandomChanceyIndex = rand.Next(randomChancey.Length);
                    string chanceyToPost = randomChancey[RandomChanceyIndex];
                    await e.Channel.SendFile(chanceyToPost);
                });
        }

        private void RegisterUniCommand()
        {
            commands.CreateCommand("uni")
                  .Do(async (e) =>
                  {
                      int RandomUniIndex = rand.Next(randomUni.Length);
                      string uniToPost = randomUni[RandomUniIndex];
                      await e.Channel.SendFile(uniToPost);
  
                  });
        }

        private void RegisterDionCommand()
        {
            commands.CreateCommand("dion")
                .Do(async (e) =>
                {
                    int RandomDionIndex = rand.Next(randomDion.Length);
                    string dionToPost = randomDion[RandomDionIndex];
                    await e.Channel.SendFile(dionToPost);
                });
        }

        private void RegisterPenileCommand()
        {
            commands.CreateCommand("penile")
                .Parameter("ping")
                .Do(async (e) =>
                {
                    int RandomPenIndex = rand.Next(randomPen.Length);
                    string penToPost = randomPen[RandomPenIndex];
                    await e.Channel.SendMessage(e.GetArg("ping") + penToPost);
                });

        }

        private void RegisterMuraCommand()
        {
            commands.CreateCommand("mura")
                 .Do(async (e) =>                 
                 {
                     int RandomMuraIndex = rand.Next(randomMura.Length);
                     string muraToPost = randomMura[RandomMuraIndex];
                     await e.Channel.SendMessage(muraToPost);
                 });
        }

        private void RegisterHelpCommand()
        {
            commands.CreateCommand("chelp")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("hello! i am chiaki bot, i was created  by <@81633420542742528>. my commands are ;purge ;wife ;hello ;penile ;coin ;mura ;chancey ;uni ;teki ;boxbox ;ben ;8ball ;lul and ;avatar (i also respond to certain text, but i'll leave you to try and find what that text is :star:, ben is still fairly new to making bots, but if you have an command ideas, PM him. (no guarantee he'll be able to implement them exactly as you want though!)");
                });
        }

        private void RegisterCoinCommand()
        {
            commands.CreateCommand("coin")
                .Do(async (e) =>
                {
                    int randomCoinIndex = rand.Next(flipCoin.Length);
                    string coinToPost = flipCoin[randomCoinIndex];
                    await e.Channel.SendMessage(coinToPost);
                });
        }

        private void RegisterThonkangCommand()
        {
            commands.CreateCommand("thonkang")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("thonkang/thonkang.png");
                });
        }


        private void StartPurge()
     
        {
            commands.CreateCommand("purge")
                .Parameter("purgeamount")
                .Do(async (e) =>
                {
                    if (e.User.ServerPermissions.ManageMessages == true)
                    {


                        var messagesToDelete = await
                         e.Channel.DownloadMessages(Convert.ToInt32(e.GetArg("purgeamount")));

                        await e.Channel.DeleteMessages(messagesToDelete);
                        await e.Channel.SendMessage(e.GetArg("purgeamount") + " messages deleted");
                    }
                    else if (e.User.ServerPermissions.ManageMessages == false)
                    {
                        await e.Channel.SendMessage(e.User.Mention + " sike, you can't use that command");
                        }
                });

        }

        private void RegisterHelloCommand()
        {
            commands.CreateCommand("hello")
                .Do(async (e) =>
                {
                   

                    int randomTextsIndex = rand.Next(randomTexts.Length)
                    ; string textToPost = randomTexts[randomTextsIndex];
                    await e.Channel.SendMessage(textToPost);
                });
        }
     
        private void RegisterWifeCommand()
        {
            commands.CreateCommand("wife")
                .Do(async (e) =>
                {
                    int randomWifeIndex = rand.Next(myWife.Length);
                    string wifeToPost = myWife[randomWifeIndex];
                    await e.Channel.SendFile(wifeToPost);
                });
        }


        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }

    internal class avatar
    {
  
    }

    internal class Client
    {
        internal static Task CurrentUser;
    }
}
