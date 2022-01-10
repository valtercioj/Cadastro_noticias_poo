using System;
class Noticia{
	private int id=0;
	string noticia;
	private string[] noticias = new string[10];
	
	public void Inserir(){
		if (id == noticias.Length){
			Array.Resize(ref noticias, 2 * noticias.Length);
		}
		Console.WriteLine();
		Console.Write("Noticia: ");
    	noticia = Console.ReadLine();
		noticias[id] = noticia;
		id++;
		Console.WriteLine();
		Console.WriteLine("Noticia Cadastrada...");
		Console.WriteLine();
	}

	public void MostrarTodasNoticias(){
		if(id==0){

			Console.WriteLine("*** Nao existe noticias Cadastradas ***");
			Console.WriteLine();
		}
		for(int i = 0; i<id; i++){
			Console.WriteLine();
			Console.WriteLine(noticias[i]);
			Console.WriteLine();
		}
	}
	public void MostrarNoticias(){

		if(id==0){
			Console.WriteLine("*** Nao existe noticias Cadastradas ***");
			Console.WriteLine();
		}
		else{
			Console.WriteLine(noticias[id-1]);
			Console.WriteLine();
		};
	}
	
}