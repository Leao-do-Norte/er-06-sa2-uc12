// See https://aka.ms/new-console-template for more information

using prog_backend.Classes;

//novaPF.ValidarDataNasc(temp);
//Console.WriteLine(novaPF.ValidarDataNasc(temp));

// Console.WriteLine($"-----Validação de Data-------");
// DateTime temp = new DateTime(2000,01,01);
// Console.WriteLine(novaPF.ValidarDataNasc("2000/05/27"));
// o método acima consegue reconhecer datas em qualquer formato

// Console.WriteLine(@$"
// ---------------PESSOA FÍSICA------------------
// [testando agora outro método com uma data de nascimento diferente]
// [Data de Nascimento: 29/02/2009]
// [Maior de idade: {novaPF.ValidarDataNasc("29/02/2009")}] ");

// PESSOA JURÍDICA
// Console.WriteLine(novaPJ.ValidarCnpj("60.613.417/1001-51"));
// float impostoPagar = novaPJ.CalcularImposto(57890.76f);
// Console.WriteLine($"Imposto a pagar: {impostoPagar.ToString("C")}");

Utils.BarraCarregamento(">> Inicializando", 10, ">", "Bem-vindo!");

string? opcao;

do {
    Console.WriteLine(@$"
    =================================================
    |       Bem vindo ao Sistema de Cadastro        |
    |        de Pessoas Físicas e Jurídicas         |
    =================================================
    |       Digite o número da opção desejada       |
    =================================================
    |               1 - Pessoa Física               |
    |               2 - Pessoa Jurídica             |
    |                                               |
    |               0 - Sair                        |
    =================================================
    ");

    opcao  = Console.ReadLine();
    Thread.Sleep(1000);

    switch (opcao){
    case "1":
        PessoaFisica novaPF = new PessoaFisica();
        novaPF.nome = "Vinícius";
        novaPF.cpf = "123.456.789-00";
        novaPF.rendimento = 4230.49f;
        novaPF.dataNasc = new DateTime(2018,05,27);

        float impostoPagar = novaPF.CalcularImposto(novaPF.rendimento);

        Endereco novoEndPF = new Endereco();
        novaPF.endereco = novoEndPF;
        novoEndPF.logradouro = "Rua James Bond";
        novoEndPF.numero = 007;
        novoEndPF.complemento = "Apt 00";
        novoEndPF.endComercial = false;

        Console.WriteLine(@$"
        ---------------PESSOA FÍSICA------------------
        Nome: {novaPF.nome}
        CPF: {novaPF.cpf}
        Endereço: {novaPF.endereco.logradouro}, N° {novaPF.endereco.numero}, {novaPF.endereco.complemento}
        Data de Nascimento: {novaPF.dataNasc}
        Maior de idade: {novaPF.ValidarDataNasc(novaPF.dataNasc)}
        ----------------------------------------------
        Tributação: {impostoPagar.ToString("C")}
        ----------------------------------------------
        ");
        Console.WriteLine($"Para continuar, tecle enter");
        Console.ReadLine();
    break;
    
    case "2":
        PessoaJuridica novaPJ = new PessoaJuridica();
        novaPJ.cnpj = "47.960.950/0021-21";
        novaPJ.razaoSocial = "Magazine Luiza";
        novaPJ.rendimento = 57890.76f;

        Endereco novoEndPJ = new Endereco();
        novaPJ.endereco = novoEndPJ;
        novoEndPJ.logradouro = "Rua Tatooine";
        novoEndPJ.numero = 456;
        novoEndPJ.complemento = "Apt Skywalker";
        novoEndPJ.endComercial = true;

        Console.WriteLine(@$"
        ---------------PESSOA JURÍDICA------------------
        Razão Social: {novaPJ.razaoSocial}
        CNPJ: {novaPJ.cnpj}
        Endereço: {novaPJ.endereco.logradouro}, N° {novaPJ.endereco.numero}, {novaPJ.endereco.complemento}
        -----------------------------------------------
        CNPJ é válido? --> {novaPJ.ValidarCnpj(novaPJ.cnpj)}
        -----------------------------------------------
        Imposto a pagar: {novaPJ.CalcularImposto(novaPJ.rendimento).ToString("C")}
        -----------------------------------------------
        ");
        Console.WriteLine($"Para continuar, tecle enter");
        Console.ReadLine();
    break;
    
    case "0":
        Console.Clear();
        Console.WriteLine($"Até a próxima!");
    break;
    
    default:
        Console.Clear();
        Console.WriteLine($"Opção inválida!");
        Console.WriteLine($"Para continuar, tecle enter");
        Console.ReadLine();
    break;
    }
} while (opcao != "0");

Utils.BarraCarregamento("<< Encerrando", 5, "<", "Tchau!");