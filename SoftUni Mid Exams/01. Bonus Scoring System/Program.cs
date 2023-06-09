int studentsNum = int.Parse(Console.ReadLine()); //number of students//5
double lecturesTotalNum = double.Parse(Console.ReadLine());//course lectures//25
double bonus = double.Parse(Console.ReadLine());//additional bonus//30

List<double> attendances = new List<double>() { };
for (int i = 0; i < studentsNum; i++)//0 5
{
    int newNum = int.Parse(Console.ReadLine());
    attendances.Add(newNum);
    //Console.ReadLine().Split().Select(int.Parse).ToList();//student attendances 
}
//12
//19
//24
//16
//20 
//{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus}) 
double totalBonus = 0;
List<double> listTotalBonuses = new List<double>() { };//empty

double recordHighestAttendedLectures = 0;//double?
for (int i = 0; i < attendances.Count; i++)//12//int?//0 5
{
    totalBonus = attendances[i] / lecturesTotalNum * (5 + bonus);//12/25* (5 + 30)=0.48* (5 + 30)=16.8

    listTotalBonuses.Add(totalBonus);//add 16.8
}

for (int i = 0; i < attendances.Count; i++)//24 highest//int?
{
    recordHighestAttendedLectures = attendances.Max();//24 attendances
}

double hightestBonus = listTotalBonuses.Max();//33.6

double roundedHightestBonus = Math.Ceiling(hightestBonus);//34

Console.WriteLine($"Max Bonus: {roundedHightestBonus}.");//Max Bonus: 34.
Console.WriteLine($"The student has attended {recordHighestAttendedLectures} lectures.");//The student has attended 24 lectures. 

//Max Bonus: 0.
//The student has attended 12 lectures.