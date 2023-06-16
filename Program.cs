// To Calculate clock angle
static double clockAngle(int hr, int min)
{
    double minAngle = min * 360 / 60;
    double hrAngle = 0;

    if (hr != 12)
    {
        hrAngle = (hr * 360) / 12;
    }

    double diffAngle = Math.Abs(hrAngle - minAngle);
    double lesserAngle = Math.Min(diffAngle, 360 - diffAngle);

    return lesserAngle;
}

// Input hour (1-12)
Console.Write("Enter Hour: ");
int hr = Convert.ToInt32(Console.ReadLine());

//Input minute (00 - 59)
Console.Write("Enter Minute: ");
int min = Convert.ToInt32(Console.ReadLine());

double angle = clockAngle(hr, min);
Console.WriteLine("The lesser angle between hour and minute hands is: " + angle + "°.");

// Exit
Console.Write("Press any key to close the console app..");
Console.ReadKey();
