// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using CleanCode.Geometrico;
using CleanCode.Livraria;

class Program
{
    public static void Main(string[] args)
    {
        //PrincipioLiskov();
        PrincipioAF();
        //PrincipioResponsabilidadeUnica();

    }

    public static void PrincipioLiskov()
    {
        var altura = 10;
        var largura = 5;

        Retangulo ret = new Retangulo();
        ret.setAltura(altura);
        ret.setLargura(largura);
        Quadrado quad = new Quadrado();
        quad.setAltura(altura);
        quad.setLargura(largura);

        Retangulo entradaTeste = quad;

        if(entradaTeste.getArea() == 50)
        {
            Console.WriteLine("Resultado esperado!!!");
        }
        else
        {
            Console.WriteLine("Resultado não esperado!!!");
        }


    }

    public static void PrincipioAF()
    {
        Livro liv = new Livro("Arquitetura Limpa", "Uncle Bob", 1999, 67, "AAAAAAAAA534DS");
        Fatura fat = new Fatura(liv, 3, 0.2, 0.08);
        //IPersistenciaLivro perLivro = new IPersistenciaLivro();
        PersistenciaEmBD perBD = new PersistenciaEmBD();
        PersistenciaEmArquivo perArq = new PersistenciaEmArquivo();

        //GerentePersistencia(IPersistenciaFatura pPersistenciaFatura, IPersistenciaLivro pPersistenciaLivro)

        GerentePersistencia gePer1 = new GerentePersistencia(perBD, perBD);
        gePer1.persistenciaLivro.salvar(liv);
        gePer1.persistenciaFatura.salvar(fat);

        GerentePersistencia gePer2 = new GerentePersistencia(perArq, perBD);
        gePer2.persistenciaLivro.salvar(liv);
        gePer2.persistenciaFatura.salvar(fat);
    }

    public static void PrincipioResponsabilidadeUnica()
    {
        Livro liv = new Livro("Codigo Limpo", "Uncle Bob", 1994, 57, "JHCEBE12556AADG");
        Fatura fat = new Fatura(liv, 5, 0.3, 0.08);
        ImpressaoFatura imp = new ImpressaoFatura(fat);

        imp.imprimirFatura();
    }


}

