/* // variável, seu valor pode ser alterado no decorrer do programa
let nomeEstudante = "Helena";
console.log(nomeEstudante);

// constante, seu valor não pode ser alterado
const nomeDoEstudante = "Helena";
console.log(nomeDoEstudante);

// Em outras linguagens, portanto, você encontrará algo semelhante a: 
String: nomeEstudante = "Helena"; */

/* let listaDeEstudantes = ["Helena", "Chico", "Mario"];
let quantidadeDeEstudantes = listaDeEstudantes.length;
let inicio = 0; */
// console.log(quantidadeDeEstudantes);

//========= com o FOR ============
/* for (let indice = 0;  indice < quantidadeDeEstudantes; indice++)
{
    const alunoCorrente = listaDeEstudantes[indice];
    console.log(alunoCorrente);
} */

// ========= com o Do While =========

/* let inicio = 0;
do
{
    console.log(listaDeEstudantes[inicio]);
    inicio++;
}  while (inicio < quantidadeDeEstudantes); */

// ========== com o While ============
/* while(inicio < quantidadeDeEstudantes)
{
    console.log(listaDeEstudantes[inicio]);
    inicio++;
} */

// =========== Exemplo For ===========
/* for (let numero = 1; numero <= 10; numero++)
{
    console.log(numero);
} */

// ======== Inserir elemento na lista =========
/* listaDeEstudantes.push("José");
console.log(listaDeEstudantes); */

// ======== Condicionais ============
/* if(quantidadeDeEstudantes < 5)
{
    listaDeEstudantes.push("José");
} else
{
    console.log("Não é possível inserir mais alunos nessa turma!");
}
console.log(listaDeEstudantes); */

// ======== Exercício boletim - Transcrição Fluxograma para Código ======

/* nota1 = parseFloat(prompt ("Informar 1a. nota"));
nota2 = parseFloat(prompt ("Informar 2a. nota"));
nota3 = parseFloat(prompt ("Informar 3a. nota"));

media = (nota1 + nota2 + nota3) / 3;
document.write("A média é :  " + media + "<br>");

if (media >= 6) document.write("Situação: APROVADO");
else if (media >=3 && media < 6) document.write("Situação: EXAME");
else document.write("Situação: REPROVADO"); */

// ==== Exercício repetições -> fluxograma x  código

numero = 1;
soma = 0; 

while(numero > 0)
{
    numero = parseInt(prompt("Informar número ou zero(0) para encerrar"));
    document.write(numero + "<br>");
    soma += numero;
}
document.write("A somatória e: " + soma + "<br>");





