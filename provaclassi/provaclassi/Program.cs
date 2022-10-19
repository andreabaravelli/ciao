// See https://aka.ms/new-console-template for more information
namespace provaclassi
{

class program {

    
int ciao = 0;
    hello myHello = new hello(); // ho creato l'oggetto
        
  hello2 myHello2 = new hello2();
        myHello2.privateHelloScreen(); // non so perchè ma non funziona 

    }
public class hello
{
    private Random rnd= new Random();

    private string name= "";
    public void helloOnScreen()
    {

        Console.WriteLine(rnd.Next());

    }

    private void myPrivateHello()
    {

        Console.WriteLine(rnd.Next());// questo è privato per cui non potrò usarlo direttamente nel main
    
    }

    // protected invece può accedervi solo con l'utilizzo di class 

    public void provaThis(string name)
    {

        this.name = name;// mi permette di usare lo stesso nome facendo una differenza tra il campo e il parametro del metodo 
        

    }

    protected void privateHelloscreen()
    {

        myPrivateHello(); // cosi facendo posso mandare in esecuzione il metodo nonostante esso sia privato
    }
}

    public class hello2 : hello // cosi facendo faccio in modo che i metodi di hello siano accessibili anche a hello2 
    {


        public void protectedHello()
        {
            privateHelloscreen();
        }
    }
}