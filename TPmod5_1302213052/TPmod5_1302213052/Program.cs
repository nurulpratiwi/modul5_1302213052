// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user.ToString());
    }
    static void Main(string[] args)
    {
        HaloGeneric haloGeneric = new HaloGeneric();
        Console.Write("Input nama: ");
        String user = Console.ReadLine();
        haloGeneric.SapaUser(user);
    }
}
