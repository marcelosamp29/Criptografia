# Criptografia

Este programa em **C# Console App** realiza uma **criptografia simples** de texto. Ele aplica três passos de transformação:

1. Desloca as letras por um valor fixo.  
2. Inverte toda a string.  
3. Aplica um deslocamento adicional apenas na segunda metade da string.

O resultado é uma versão “criptografada” do texto digitado pelo usuário.

---

💡 **Como funciona**

1. Cada letra do texto é deslocada por **3 posições** na tabela ASCII.  
2. O texto resultante é invertido completamente.  
3. A **segunda metade da string invertida** recebe um deslocamento adicional de **-1 na tabela ASCII**.  
4. Caracteres que não são letras permanecem inalterados.

---

🖥️ **Como testar**

1. Copie todo o código abaixo para um arquivo com extensão `.cs`.  
2. Abra no Visual Studio ou qualquer IDE que suporte C# Console App.  
3. Compile e execute o programa.  
4. Informe a quantidade de linhas de texto que deseja criptografar.  
5. Digite cada linha e o programa exibirá a versão criptografada.

> Experimente textos diferentes para ver como cada transformação é aplicada.
