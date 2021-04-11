using System;
using System.Collections;

namespace Clinica
{
    public class Program
    {
        static Clinic clinic = new Clinic();

        static void Main(string[] args)
        {
            bool running = true;
            String[] dias_uteis = { "Segunda", "Terça", "Quarta", "Quinta", "Sexta" };
            String[] operation_medicines = {"Pain Killer"};
            Professional Ana = new Professional("Ana", 8, 16, dias_uteis,clinic);
            Service routine = new Service("Rotina", 15, 0, 30, Ana,clinic);            
            Service vacine = new Service("Vacinas", 25, 0, 20, Ana,clinic);
            Service operation = new Service("Operação", 100, 2, 30, Ana, operation_medicines,clinic);
            Client teste = new Client("Tiago",987654321,"testc@gmail.com",clinic);
            Animal boby = new Animal("Boby", 2, "M", "Rafeiro", teste,clinic);
            Consulta cons1 = new Consulta(routine,Ana,teste,boby,"14/03/2021",true);
            Consulta cons2 = new Consulta(routine,Ana,teste,boby,"14/03/2022",false);

           
            Console.WriteLine("          **Bem-Vindo**          ");
            while (running)
            {
                
                Console.WriteLine("     O que pretende realizar?   \n");
                Console.WriteLine(" -> 1. Registar Animal ");
                Console.WriteLine(" -> 2. Registar Cliente ");
                Console.WriteLine(" -> 3. Registar Serviço ");
                Console.WriteLine(" -> 4. Registar Médico ");
                Console.WriteLine(" -> 5. Criar Consulta ");
                Console.WriteLine(" -> 6. Indicar Serviço ");
                Console.WriteLine(" -> 7. Gerar Relatório ");
                Console.WriteLine(" -> 8. Fechar aplicação");
                //Console.WriteLine(" -> 6w. Fechar aplicação");
                int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        CreateNewAnimal();
                        break;
                    case 2:
                        CriarCliente();
                        break;
                    case 3:
                        CriarService();
                        break;
                    case 4:
                        criaMedico();
                        break;
                    case 5:
                        CriarConsulta();
                        break;
                    case 6:
                        Console.WriteLine(" Estes são os serviços disponíveis: \n");
                        clinic.imprimeServices();
                        break;
                    
                    case 7:
                        Console.WriteLine("Insira o id do cliente que pretende realizar relatório: ");
                        clinic.imprimeClientes();
                        int id_cliente = Convert.ToInt32(Console.ReadLine());
                        Client cliente_ = clinic.obterclient_id(id_cliente);
                        cliente_.geraRelatorio_Cliente();
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(" ERRO :: Escolha uma opção correta!");
                        break;

                }
            }
            
            
            
        }



        public static void CreateNewAnimal() {
            
            string name;
            int age;
            string genre;
            string specie;
            Console.WriteLine("Qual é o nome do animal ?");
            name = Console.ReadLine();
            Console.WriteLine("Qual é a idade (em anos) ? ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual é o genero? M ou F");
            genre = Console.ReadLine();
            Console.WriteLine("Qual é a espécie do animal ?");
            specie = Console.ReadLine();
            Console.WriteLine("O dono do animal já tem conta?");
            int opt;
            
            Console.WriteLine("1. Sim!");
            Console.WriteLine("2. Não!");
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
                
            {
                case 1:
                    Console.WriteLine("Insira o id do cliente: ");
                    Console.WriteLine("Caso não saiba o id prima 0!");
                    int id_client = Convert.ToInt32(Console.ReadLine());
                    if (id_client == 0)
                    {
                        clinic.imprimeClientes();
                        Console.WriteLine("Insira o id do cliente: ");
                        id_client = Convert.ToInt32(Console.ReadLine());
                    }

                    Client dono = clinic.obterclient_id(id_client);
                    Animal ani = new Animal(name, age, genre, specie, dono,clinic);
                    break;
                case 2:
                    Console.WriteLine("É necessário criar conta cliente primeiro! ");
                    CriarCliente();
                    goto case 1;
                    
                default:
                    Console.WriteLine(" ERRO :: Escolha uma opção correta!");
                    break;
                    

            }
        }

        public static void CriarCliente()
        {
            Console.WriteLine("Qual é o nome ?");
            string name = Console.ReadLine();
            Console.WriteLine("Qual é o contacto ?");
            int contact = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual é o email ?");
            string mail = Console.ReadLine();
            Client Cli = new Client(name,contact,mail,clinic);
        }

        public static void CriarConsulta() {

            Console.WriteLine("Qual serviço? ");
            clinic.imprimeServices_whit_index();            
            int i_servico = Convert.ToInt32(Console.ReadLine()); 
            Service servico = (Service)clinic.services[i_servico];

            Console.WriteLine("Qual médico?");
            clinic.imprimeMedicos();
            int i_medico = Convert.ToInt32(Console.ReadLine());
            Professional medico = (Professional)clinic.medicos[i_medico];

            Console.WriteLine("Qual cliente?");
            clinic.imprimeClientes();
            int i_cliente = Convert.ToInt32(Console.ReadLine());
            Client cliente = (Client)clinic.clients[i_cliente];

            Console.WriteLine("Qual Animal? ");
            cliente.imprimeAnimais();
            int i_animal = Convert.ToInt32(Console.ReadLine());
            Animal animal= (Animal)cliente.animais[i_animal];

            Console.WriteLine("Em que dia? (DD/MM/AAAA) ");
            string data = Console.ReadLine();

            Console.WriteLine("A consulta já se realizou ?");
            Console.WriteLine("1. Sim");
            Console.WriteLine("2. Não");
            int opt = Convert.ToInt32(Console.ReadLine());
            
            if (opt == 1)
            {
                new Consulta(servico, medico, cliente, animal, data, true);
            }
            else
            {
                new Consulta(servico, medico, cliente, animal, data, false);
            }
            
            

        }
        public static void criaMedico()
        {
            Console.WriteLine("Qual é o nome ?");
            string name = Console.ReadLine();
            Console.WriteLine("A que horas começa o trabalho ?");
            int inicio = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("A que horas acaba o trabalho ?");   
            int fim = Convert.ToInt32(Console.ReadLine());
            

            string[] dias = { "", "", "", "", "" };
            Console.WriteLine("Que dias da semana trabalha ? ");
            for(int i=1; i < 6; i++)
            {
                Console.WriteLine($"{i} -> ");
                string dia = Console.ReadLine();
                dias[i-1] = dia;

            }
            new Professional(name,inicio,fim,dias,clinic);
        }
        public static void CriarService()
        {
            Console.WriteLine("Qual é o nome ?");
            string name = Console.ReadLine();

            Console.WriteLine("Quanto tempo demorará o serviço ?");

            Console.WriteLine("Horas ?");            
            int horas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Minutos ?");            
            int minutes = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Preço (euros) ?");
            double price = Convert.ToDouble(Console.ReadLine());
            
            

            Console.WriteLine("Qual Médico? ");
            clinic.imprimeMedicos();
            int i_profesisonal = Convert.ToInt32(Console.ReadLine());
            Professional professional = (Professional)clinic.medicos[i_profesisonal];            
            new Service(name,price,horas,minutes,professional,clinic);
        }
    }
}
