# Generics CSharp
Um exemplo de Utilização de Generics em C# 
 
 O generics possibilita a criação de classe e métedos genéricos, onde podem receber diversos tipos. Esse tipo será passado no momento da instância da classe.
 Com isso podemos reaproveitar mais o código, evitando repetição, mantendo a segurança de tipo passado e até mesmo o desempenho da aplicação. Podemos inclusive
 criar restições a essa classe genérica, onde criamos uma classe abstrata com os métodos onde somenete as que herdarem dessa classe podem utilizar esse método, 
 ai então podemos definir a classe genérica como desse tipo abstrata, fazendo com que somente os tipos das classe derivadas dessa classe abstrata serem aceitos
 na classe genérica. 
 
 
No código de exemplo realizamos a impressão de duas informações: categorias e produtos, onde as duas utlizam da mesma classe de repositório e de métodos (generics) porém o tipo é passado somente na classe Program,  e a restrição de tipo é passada através da classe Entity, que ao ser herdada pelas classe Produto e Categoria, é passada como o tipo da classe genérica e como o tipo do método imprimir.
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
