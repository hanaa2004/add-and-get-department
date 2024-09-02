using System.Net.Http.Json;

namespace webapiconsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            HttpClient httpClient = new HttpClient();
            dept dept= new dept();
            Console.WriteLine("enter dept name ");
            dept.name = Console.ReadLine();

            Console.WriteLine("enter manager name ");
            dept.managername = Console.ReadLine();

            await httpClient.PostAsJsonAsync<dept>("https://localhost:7180/api/dept", dept);
           
                Console.WriteLine("enter dept id");
                int id = int.Parse(Console.ReadLine());

                dept s = await httpClient.GetFromJsonAsync<dept>("https://localhost:7180/api/dept/" + id);

                //Console.WriteLine(s.id);
                Console.WriteLine(s.name);
                Console.WriteLine(s.managername);

            


        }
    }
}
