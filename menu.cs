using System;

class Menu{
	
	public int MenuUsuario() {
	    Console.WriteLine();
	    Console.WriteLine("----------------------------------");
	    Console.WriteLine("1 - Cadastrar Usuario");
		Console.WriteLine("2 - Ler todos os usuarios Cadastrados"); 
	    Console.WriteLine("3 - Cadastrar Noticia");
	    Console.WriteLine("4 - Ler todas as Noticias");
		Console.WriteLine("5 - Ler noticias especificas");
		Console.WriteLine("0 - Sair");
	    Console.WriteLine("----------------------------------");
	    Console.Write("Informe uma opcao: ");
	    
	    int op = int.Parse(Console.ReadLine());
	    Console.WriteLine();
	    return op;
	}
}