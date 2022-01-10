using System;

class Usuarios{
	private int id_user=0;
	private string nome;
	private string[] usuarios = new string[10];
	
	public void InserirUsuario(){
		if (id_user == usuarios.Length){
			Array.Resize(ref usuarios, 2 * usuarios.Length);
		}
		Console.Write("Digite seu Nome: ");
    	nome= Console.ReadLine();
		usuarios[id_user] = nome;
		id_user++;
		Console.WriteLine();
		Console.WriteLine("Usuario Cadastrado...");
		Console.WriteLine();
	}
	public void MostrarUsuarios(){
			
		if(id_user==0){
			Console.WriteLine("*** Nao existe usuarios Cadastradas ***");
			Console.WriteLine();
		}
		for(int i = 0; i<id_user; i++){
			Console.WriteLine();
			Console.WriteLine($"{id_user}-{usuarios[i]}");
			Console.WriteLine();
		}
	}
}