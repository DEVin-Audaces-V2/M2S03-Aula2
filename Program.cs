//Importando o Namespace de Classes para conseguir chamar a classe aluno
using Classes;


Aluno aluno = new Aluno();
aluno.Nome = "Vitor" ;
aluno.Matricula = 5;
aluno.Telefone = "123";
aluno.Endereco = "Rua Girassól";


var aluno1 = new Aluno(){
    Nome= "Antonio", 
    Matricula = 5, 
    Telefone = "456", 
    Endereco = "Rua Girassol"  
};

aluno1.RealizarMatricula();
aluno1.ConsultarNotas();
aluno.RealizarMatricula();
aluno.ConsultarNotas();
