# Esempio di uso di Docker per containerizzare una App in .NET

L'applicazione di esempio espone un socket sulla porta 5010

## Steps per eseguire l'applicaizone con .NET nativo

Step 1 - installare i pacchetti richiesti:

````
dotnet restore
````


Step 2 - Eseguire l'applicazione

````
dotnet run
````

L'applicazione resta in attesa sulla porta 5010. E' possibile mandare paccheti di esempio con telnet.


## Steps per eseguire l'applicazione con Docker

Step 1 - Build dell'immagine

````
docker build -t test-dotnet-docker:latest .
````

Step 2 - Con l'immagine creata, e' possibile avviare un container:

````
docker run --rm -d  --name test-dotnet-docker -p 5010:5010 test-dotnet-docker:latest
````

Step 3 - Verificare che il cotainer sia in esecuzione

````
docker ps
````

Dovresti notare che nella lista e' presente il container `test-dotnet-docker`

Step 4 - Usare l'applicazione dal computer HOST

Avendo esposto la porta del container (5010) con quella dell'HOST (5010), e' possibile usare telnet per verificare il corretto funzionamento del sistema:

````
telnet localhost 5010
````

Il risultato sara' inalterato rispetto all'esecuzione nativa