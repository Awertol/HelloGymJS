Console.WriteLine("Hello there! Vítej na GJS :)");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Naším největším lákadlem je, že si každý primán může vybrat svého Pokemona!");
Console.WriteLine("************************************************************");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("Jaký je tvůj výběr?");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Pikachu");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Charmander");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Bulbasaur");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Squirtle");
Console.ResetColor();
Console.WriteLine("************************************************************");
Console.Write("(řekni to PŘESNĚ) Tvá volba: "); //napiš příkaz takto, aby šlo psát
                                               //na stejný řádek, kde bude tento text

string volbaPokemona = Console.ReadLine(); //zde uživatel napíše nějaké slovo a ENTERem potvrdí
Console.Clear();
if(volbaPokemona == "Pikachu")
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("quu..__\r\n $$$b  `---.__\r\n  \"$$b        `--.                          ___.---uuudP\r\n   `$$b           `.__.------.__     __.---'      $$$$\"              .\r\n     \"$b          -'            `-.-'            $$$\"              .'|\r\n       \".                                       d$\"             _.'  |\r\n         `.   /                              ...\"             .'     |\r\n           `./                           ..::-'            _.'       |\r\n            /                         .:::-'            .-'         .'\r\n           :                          ::''\\          _.'            |\r\n          .' .-.             .-.           `.      .'               |\r\n          : /'$$|           .@\"$\\           `.   .'              _.-'\r\n         .'|$u$$|          |$$,$$|           |  <            _.-'\r\n         | `:$$:'          :$$$$$:           `.  `.       .-'\r\n         :                  `\"--'             |    `-.     \\\r\n        :##.       ==             .###.       `.      `.    `\\\r\n        |##:                      :###:        |        >     >\r\n        |#'     `..'`..'          `###'        x:      /     /\r\n         \\                                   xXX|     /    ./\r\n          \\                                xXXX'|    /   ./\r\n          /`-.                                  `.  /   /\r\n         :    `-  ...........,                   | /  .'\r\n         |         ``:::::::'       .            |<    `.\r\n         |             ```          |           x| \\ `.:``.\r\n         |                         .'    /'   xXX|  `:`M`M':.\r\n         |    |                    ;    /:' xXXX'|  -'MMMMM:'\r\n         `.  .'                   :    /:'       |-'MMMM.-'\r\n          |  |                   .'   /'        .'MMM.-'\r\n          `'`'                   :  ,'          |MMM<\r\n            |                     `'            |tbap\\\r\n             \\                                  :MM.-'\r\n              \\                 |              .''\r\n               \\.               `.            /\r\n                /     .:::::::.. :           /\r\n               |     .:::::::::::`.         /\r\n               |   .:::------------\\       /\r\n              /   .''               >::'  /\r\n              `',:                 :    .'\r\n                                   `:.:' Tim Park");
}
else if(volbaPokemona == "Charmander")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("              _.--\"\"`-..\r\n            ,'          `.\r\n          ,'          __  `.\r\n         /|          \" __   \\\r\n        , |           / |.   .\r\n        |,'          !_.'|   |\r\n      ,'             '   |   |\r\n     /              |`--'|   |\r\n    |                `---'   |\r\n     .   ,                   |                       ,\".\r\n      ._     '           _'  |                    , ' \\ `\r\n  `.. `.`-...___,...---\"\"    |       __,.        ,`\"   L,|\r\n  |, `- .`._        _,-,.'   .  __.-'-. /        .   ,    \\\r\n-:..     `. `-..--_.,.<       `\"      / `.        `-/ |   .\r\n  `,         \"\"\"\"'     `.              ,'         |   |  ',,\r\n    `.      '            '            /          '    |'. |/\r\n      `.   |              \\       _,-'           |       ''\r\n        `._'               \\   '\"\\                .      |\r\n           |                '     \\                `._  ,'\r\n           |                 '     \\                 .'|\r\n           |                 .      \\                | |\r\n           |                 |       L              ,' |\r\n           `                 |       |             /   '\r\n            \\                |       |           ,'   /\r\n          ,' \\               |  _.._ ,-..___,..-'    ,'\r\n         /     .             .      `!             ,j'\r\n        /       `.          /        .           .'/\r\n       .          `.       /         |        _.'.'\r\n        `.          7`'---'          |------\"'_.'\r\n       _,.`,_     _'                ,''-----\"'\r\n   _,-_    '       `.     .'      ,\\\r\n   -\" /`.         _,'     | _  _  _.|\r\n    \"\"--'---\"\"\"\"\"'        `' '! |! /\r\n                            `\" \" -' mh");
}
else if(volbaPokemona == "Bulbasaur")
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("                                           /\r\n                        _,.------....___,.' ',.-.\r\n                     ,-'          _,.--\"        |\r\n                   ,'         _.-'              .\r\n                  /   ,     ,'                   `\r\n                 .   /     /                     ``.\r\n                 |  |     .                       \\.\\\r\n       ____      |___._.  |       __               \\ `.\r\n     .'    `---\"\"       ``\"-.--\"'`  \\               .  \\\r\n    .  ,            __               `              |   .\r\n    `,'         ,-\"'  .               \\             |    L\r\n   ,'          '    _.'                -._          /    |\r\n  ,`-.    ,\".   `--'                      >.      ,'     |\r\n . .'\\'   `-'       __    ,  ,-.         /  `.__.-      ,'\r\n ||:, .           ,'  ;  /  / \\ `        `.    .      .'/\r\n j|:D  \\          `--'  ' ,'_  . .         `.__, \\   , /\r\n/ L:_  |                 .  \"' :_;                `.'.'\r\n.    \"\"'                  \"\"\"\"\"'                    V\r\n `.                                 .    `.   _,..  `\r\n   `,_   .    .                _,-'/    .. `,'   __  `\r\n    ) \\`._        ___....----\"'  ,'   .'  \\ |   '  \\  .\r\n   /   `. \"`-.--\"'         _,' ,'     `---' |    `./  |\r\n  .   _  `\"\"'--.._____..--\"   ,             '         |\r\n  | .\" `. `-.                /-.           /          ,\r\n  | `._.'    `,_            ;  /         ,'          .\r\n .'          /| `-.        . ,'         ,           ,\r\n '-.__ __ _,','    '`-..___;-...__   ,.'\\ ____.___.'\r\n `\"^--'..'   '-`-^-'\"--    `-^-'`.''\"\"\"\"\"`.,^.`.--' mh");
}
else if(volbaPokemona == "Squirtle")
{
    Console.WriteLine("               _,........__\r\n            ,-'            \"`-.\r\n          ,'                   `-.\r\n        ,'                        \\\r\n      ,'                           .\r\n      .'\\               ,\"\".       `\r\n     ._.'|             / |  `       \\\r\n     |   |            `-.'  ||       `.\r\n     |   |            '-._,'||       | \\\r\n     .`.,'             `..,'.'       , |`-.\r\n     l                       .'`.  _/  |   `.\r\n     `-.._'-   ,          _ _'   -\" \\  .     `\r\n`.\"\"\"\"\"'-.`-...,---------','         `. `....__.\r\n.'        `\"-..___      __,'\\          \\  \\     \\\r\n\\_ .          |   `\"\"\"\"'    `.           . \\     \\\r\n  `.          |              `.          |  .     L\r\n    `.        |`--...________.'.        j   |     |\r\n      `._    .'      |          `.     .|   ,     |\r\n         `--,\\       .            `7\"\"' |  ,      |\r\n            ` `      `            /     |  |      |    _,-'\"\"\"`-.\r\n             \\ `.     .          /      |  '      |  ,'          `.\r\n              \\  v.__  .        '       .   \\    /| /              \\\r\n               \\/    `\"\"\\\"\"\"\"\"\"\"`.       \\   \\  /.''                |\r\n                `        .        `._ ___,j.  `/ .-       ,---.     |\r\n                ,`-.      \\         .\"     `.  |/        j     `    |\r\n               /    `.     \\       /         \\ /         |     /    j\r\n              |       `-.   7-.._ .          |\"          '         /\r\n              |          `./_    `|          |            .     _,'\r\n              `.           / `----|          |-............`---'\r\n                \\          \\      |          |\r\n               ,'           )     `.         |\r\n                7____,,..--'      /          |\r\n                                  `---.__,--.'mh");
    Console.ForegroundColor = ConsoleColor.Cyan;
}
Console.ResetColor();
Console.WriteLine("Tvá volba: " + volbaPokemona);
Thread.Sleep(6000); //aby si člověk mohl omrknout svého vybraného Pokemona :)
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Thread.Sleep(400);
Console.BackgroundColor = ConsoleColor.Green;
Console.Clear();
Thread.Sleep(400);
Console.BackgroundColor = ConsoleColor.Blue;
Console.Clear();
Thread.Sleep(400);
Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.Clear();
Thread.Sleep(400);
Console.BackgroundColor = ConsoleColor.Magenta;
Console.Clear();
Thread.Sleep(400);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.ResetColor();
Console.Clear();
Console.ResetColor();
Thread.Sleep(400);
Console.WriteLine("Užívej GymJS!");
Thread.Sleep(4000);
Console.WriteLine("Ciao :)");
Thread.Sleep(500);
