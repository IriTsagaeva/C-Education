Console.Clear();
Console.WriteLine ("Please, enter distance (m)");
int distance = int.Parse(Console.ReadLine());
Console.WriteLine ("Please, enter first friends speed (m/s)");
int Friend1Speed = int.Parse(Console.ReadLine());
Console.WriteLine ("Please, enter second friends speed (m/s)");
int Friend2Speed = int.Parse(Console.ReadLine());
Console.WriteLine ("Please, enter dogs speed (m/s)");
int DogSpeed = int.Parse(Console.ReadLine());
int WhatFriend = 1;
int count=0;
while (distance>10)
{
    if (WhatFriend==1)
    {
        distance=distance-((distance/(DogSpeed+Friend2Speed))*(Friend1Speed+Friend2Speed));
        count++;
        WhatFriend=2;
    }
    if (WhatFriend==2)
    {
        distance=distance-((distance/(DogSpeed+Friend1Speed))*(Friend1Speed+Friend2Speed));
        count++;
        WhatFriend=1;
    }
}

Console.WriteLine("Собака пробежала между друзьями "+ count + " раз.");

