//UC1
int present = 1;
int emp_per_rate = 20;
int emphr = 0;
int empwage = 0;

Random random = new Random();
int employeestatus = random.Next(0, 2);
if (employeestatus==present)
{
    Console.WriteLine("employee is present");
    emphr = 8;
}
else
{
    Console.WriteLine("employee is absent");
    emphr = 0;
}
empwage = (emp_per_rate * emphr);
Console.WriteLine("daily wage" + empwage);
