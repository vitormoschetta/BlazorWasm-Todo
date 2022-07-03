# Blazor Wasm

O WebAssembly ou Wasm é um novo formato, portável, leve e com tempo de carregamento eficiente, adequado para compilação na Web. Assim o navegador passa a funcionar como uma máquina virtual rodando o Wasm (código binário).

O Blazor utiliza essa possibilidade para rodar CSharp no Brownser de forma estática, como se fosse um JavaScript. Agora podemos escrever Single Page Applications (SPA), com todas as vantagens do `two way data binding`, com .NET Blazor Wasm.

<br>

### Para executar este aplicativo:

Inicializar a base de dados:
```
cd database
npm install
yarn server
```

Executar o aplicativo:
```
cd BlazorTodo
dotnet watch run
```


<br>

Aplicativo SPA hospedado estaticamente no Vercel:

<https://vitor-blazor.vercel.app>



<br>
<br>


Saiba mais sobre o ASP.NET CoreBlazor:

<https://docs.microsoft.com/pt-br/aspnet/core/blazor/?view=aspnetcore-5.0>


Saiba mais sobre a Hospedagem Vercel:

<https://vercel.com/>