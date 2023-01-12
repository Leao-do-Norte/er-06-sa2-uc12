// See https://aka.ms/new-console-template for more information

using prog_backend.Classes;

PessoaFisica novaPF = new PessoaFisica();
novaPF.nome = "Vinícius";
novaPF.cpf = "123.456.789-00";
novaPF.rendimento = 4230.49f;
novaPF.dataNasc = new DateTime(2000,05,27);

//novaPF.ValidarDataNasc(temp);
//Console.WriteLine(novaPF.ValidarDataNasc(temp));

// Console.WriteLine($"-----Validação de Data-------");
// DateTime temp = new DateTime(2000,01,01);
// Console.WriteLine(novaPF.ValidarDataNasc("2000/05/27"));
// o método acima consegue reconhecer datas em qualquer formato

float impostoPagar = novaPF.CalcularImposto(4230.49f);

Endereco novoEndPF = new Endereco();
novaPF.endereco = novoEndPF;
novoEndPF.logradouro = "Rua James Bond";
novoEndPF.numero = 007;
novoEndPF.complemento = "Apt 00";
novoEndPF.endComercial = true;

// @ --> serve para indicar quebra de linha automática

// Console.WriteLine(@$"
// ---------------PESSOA FÍSICA------------------
// Nome: {novaPF.nome}
// CPF: {novaPF.cpf}
// Endereço: {novaPF.endereco.logradouro}, N° {novaPF.endereco.numero}, {novaPF.endereco.complemento}
// Data de Nascimento: {novaPF.dataNasc}
// Maior de idade: {novaPF.ValidarDataNasc(novaPF.dataNasc)}
// ----------------------------------------------
// Tributação: {impostoPagar.ToString("C")}
// ----------------------------------------------
// [testando agora outro método com uma data de 
// nascimento diferente]
// [Data de Nascimento: 29/02/2009]
// [Maior de idade: {novaPF.ValidarDataNasc("29/02/2009")}]
// ");

PessoaJuridica novaPJ = new PessoaJuridica();

novaPJ.cnpj = "47.960.950/0021-21";
novaPJ.razaoSocial = "Magazine Luiza";

Console.WriteLine(@$"
---------------PESSOA JURÍDICA------------------

Razão Social: {novaPJ.razaoSocial}
CNPJ: {novaPJ.cnpj}

CNPJ é válido? --> {novaPJ.ValidarCnpj(novaPJ.cnpj)}
");

// Console.WriteLine(novaPJ.ValidarCnpj("60.613.417/1001-51"));
// Console.WriteLine($"Pessoa Juridica ---------------------");
// Console.WriteLine($"CNPJ: {novaPJ.cnpj}");
// Console.WriteLine($"Razão Social: {novaPJ.razaoSocial}");
// float impostoPagar = novaPJ.CalcularImposto(57890.76f);
// Console.WriteLine($"Imposto a pagar: {impostoPagar.ToString("C")}");