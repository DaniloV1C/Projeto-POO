namespace ProjetoPoo6
{ 
    public class Cardapio()
    {
        public string nome_prato;
        public string descricao_prato;
        public int preco_prato;
        public void mostrar_cardapio() {
            Console.WriteLine("------CARDAPIO-------");
            Console.WriteLine("1 - Pizza Napolitana");
            Console.WriteLine("Pizza com queijo, molho de tomate e peperoni");
            Console.WriteLine("Preço: 18 R$");
            Console.WriteLine("---------------------");
            Console.WriteLine("2 - Ravioli");
            Console.WriteLine("Ravioli com massa fina, com carne e molho de tomate");
            Console.WriteLine("Preço: 5 R$");
            Console.WriteLine("---------------------");
            Console.WriteLine("3 - Pasta");
            Console.WriteLine("Pasta tradicional ao molho branco");
            Console.WriteLine("Preço: 12 R$");
            Console.WriteLine("---------------------");
        }
    }
    public class Pedido: Cardapio
    {
        public string nome_cliente;
        public int codigo_pedido;
        public int qtdep;
        public int qtder;
        public int qtdem;
        public int total;
        public string metododepag;
        public void fazer_pedido()
        {
            int sel;
            string resp;
            int qtde;
            do
            {
                Console.Clear();
                do
                {
                    
                    Console.WriteLine("Selecione os itens abaixo para fazer seu pedido:");
                    mostrar_cardapio();
                    Console.WriteLine("O que vai querer ?");
                    sel = Int32.Parse(Console.ReadLine());
                    if (sel != 1 && sel != 2 && sel != 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Atenção: Digite um número valido");
                    }
                    else { break; }

                } while (sel != 1 && sel != 2 && sel != 3);
                switch (sel)
                {
                    case 1:
                        nome_prato = "Pizza Napolitana";
                        preco_prato = 18;
                        descricao_prato = "Pizza com queijo, molho de tomate e peperoni";
                        Console.WriteLine("Você selecionou");
                        Console.WriteLine(nome_prato);
                        Console.WriteLine(descricao_prato);
                        Console.WriteLine("Preço: " + preco_prato);
                        Console.WriteLine("Digite a quantidade que deseja:");
                        qtde = Int32.Parse(Console.ReadLine());
                        qtdep += qtde;
                        total += qtde * preco_prato;
                        break;
                    case 2:
                        nome_prato = "Ravioli";
                        preco_prato = 5;
                        descricao_prato = "Ravioli com massa fina e carne ao molho de tomate";
                        Console.WriteLine("Você selecionou");
                        Console.WriteLine(nome_prato);
                        Console.WriteLine(descricao_prato);
                        Console.WriteLine("Preço: " + preco_prato);
                        Console.WriteLine("Digite a quantidade que deseja:");
                        qtde = Int32.Parse(Console.ReadLine());
                        qtder += qtde;
                        total += qtde * preco_prato;
                        break;
                    case 3:
                        nome_prato = "Pasta";
                        preco_prato = 12;
                        descricao_prato = "Pasta tradicional ao molho branco";
                        Console.WriteLine("Você selecionou");
                        Console.WriteLine(nome_prato);
                        Console.WriteLine(descricao_prato);
                        Console.WriteLine("Preço: " + preco_prato);
                        Console.WriteLine("Digite a quantidade que deseja:");
                        qtde = Int32.Parse(Console.ReadLine());
                        qtdem += qtde;
                        total += qtde * preco_prato;
                        break;
                }
                Console.WriteLine("Deseja mais alguma coisa ? [s/n]");
                resp = Console.ReadLine();
            } while (resp == "s");
        }
        public void fazer_pagamento()
        {
            int sel2;
            int valor;
            int troco;
            int div;
            double parcela;
            string resp2;
            Console.Clear();
            do
            {
                

                do
                {
                    
                    Console.WriteLine("O total fica: " + total);
                    Console.WriteLine("Selecione o metodo de pagamento:");
                    Console.WriteLine("1- Dinheiro");
                    Console.WriteLine("2- Debito");
                    Console.WriteLine("3- Credito");
                    Console.WriteLine("4- Pix");
                    sel2 = Int32.Parse(Console.ReadLine());
                    if(sel2 != 1 && sel2 != 2 && sel2 != 3 && sel2 != 4)
                    {
                        Console.Clear() ;
                        Console.WriteLine("Atenção: Digite um número valido");
                    }
                    else { break; }
                }while(sel2!=1 && sel2!=2 && sel2!=3 && sel2!=4);
                    switch (sel2)
                {
                    case 1:
                        metododepag = "Dinheiro";
                        Console.WriteLine("Você selecionou  " + metododepag);
                        do
                        {
                            Console.WriteLine("Coloque um valor:");
                            valor = Int32.Parse(Console.ReadLine());
                            if (valor < total)
                            { 
                                Console.WriteLine("Saldo invalido");
                            }
                        } while (valor < total);
                        Console.WriteLine("Total inserido: " + valor);
                        troco = valor - total;
                        Console.WriteLine("Troco: " + troco);
                        break;
                    case 2:
                        metododepag = "debito";
                        Console.WriteLine("Você selecinou " + metododepag);


                        break;
                    case 3:
                        metododepag = "Credito";
                        Console.WriteLine("Você selecinou " + metododepag);
                        Console.WriteLine("Dividir em quantas vezes ?");
                        div = Int32.Parse(Console.ReadLine());
                        parcela = total / div;
                        Console.WriteLine(div + " parcelas de " + parcela + " R$");
                        break;
                    case 4:
                        metododepag = "Pix";
                        Console.WriteLine("Você selecinou " + metododepag);
                        break;



                }
                Console.WriteLine("Deseja comfirmar ? [s/n]");
                resp2 = Console.ReadLine();
                if(resp2 == "n")
                {
                    Console.Clear();
                }

            } while (resp2 == "n");
        }
        public void gerar_comanda()
        {
            Random random = new Random(); 
            Console.WriteLine("Digite seu nome");
            nome_cliente = Console.ReadLine();
            Console.Clear() ;
            Console.WriteLine("Comanda do pedido");
            if (qtdep > 0)
            {
                Console.WriteLine("Pizza napolitana x" + qtdep);
            }
            if (qtder > 0)
            {
                Console.WriteLine("Ravioli x" + qtder);
            }
            if (qtdem > 0)
            {
                Console.WriteLine("Pasta x" + qtdem);
            }
            Console.WriteLine(nome_cliente + " seu pedido deu no total  " + total + " R$");
            Console.WriteLine("Metodo de pagamento: " + metododepag);
            codigo_pedido = random.Next(1000, 9999);
            Console.WriteLine("Seu codigo é " + codigo_pedido);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cardapio cardapio = new Cardapio();
            Pedido pedido = new Pedido();
            pedido.fazer_pedido();
            pedido.fazer_pagamento();
            pedido.gerar_comanda();

        }
    }
}
