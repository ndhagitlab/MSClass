// See https://aka.ms/new-console-template for more information
using System;
using VCBS_SERVER;

Console.WriteLine("Hello, Nguyen Duc Ha");
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}
Console.WriteLine("");
Console.WriteLine("Use While for loop printing 1-5");
int j = 0;
do
{
    Console.WriteLine(j);
    j++;
} while (j < 5);

Console.WriteLine("");
Console.WriteLine("Use Do for loop printing 1-5 ");

int[] numbers = new int[5];

for (int m = 0; m < 5; m++)
{
    numbers[m] = m;
    Console.WriteLine(m);
}
Console.WriteLine("Gan mang du lieu use For: ");
Console.WriteLine(String.Join(",", numbers));
Console.WriteLine("");

Server VCBS_server = new VCBS_SERVER.Server("","","");

Console.WriteLine("Use class VCBS_Server to print");

VCBS_server.svr_name = "Trading Core - 01";
VCBS_server.svr_ipaddress = "192.168.1.100";
VCBS_server.svr_type = "DELL EMC R650";

VCBS_server.myserver();

Thread.Sleep(5000);
