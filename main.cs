using System;

class Program {
  public static void Main (string[] args) {
		Usuarios users =new Usuarios();
    Noticia news = new Noticia();
		Menu opcaoUser = new Menu();
		int op = opcaoUser.MenuUsuario();
		while(op != 0){
			if (op == 1){
				users.InserirUsuario();
			}
			if (op == 2){
				users.MostrarUsuarios();
				
			}
			else if(op==3){
				news.Inserir();
			}
			else if(op == 4){
				news.MostrarTodasNoticias();
			}
			else if(op == 5){
				news.MostrarNoticias();
			}
			Console.Write("Informe uma opcao: ");
			op = int.Parse(Console.ReadLine());
			
		}
		
  }
}



