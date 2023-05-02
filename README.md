# longSlice

## Descrizione esecizio
#### Esercizio C# in console che, data una stringa composta solo da cifre, calcoli il prodotto maggiore ottenibile per una sua sottostringa contigua di cifre di lunghezza N; in caso la lunghezza della sottostringa sia 0 ritornare 1.

## Descizione soluzione utilizzata
<details>
<summary>Prima di tutto dobbiamo creare un contenitore per tutti i prodotti che otterremo.</summary>
```
int lengmnspan=digits.Length-span;      //Lunghezzza stringa - lunghezza sottostringa
int[] prodotti = new int[lengmnspan+1]; 
```
Nell'esempio qui sopra <b><i>digits</i></b> rappresenta la nostra stringa mentre <b><i>span</i></b> la lunghezza della sottostringa; la lunghezza di <b><i>prodotti</i></b> deve essere di <b><i>lengmnspan</i></b> in quanto sarà quella la quantità di prodotti ottenuti.
<br>
<img src="https://user-images.githubusercontent.com/127590227/235717404-71f4ed26-04ae-4a5a-8c6f-6a1737fd5a73.png" width="500" heigth="250">  
</details>

<details>
<summary>Creiamo altre variabili utili</summary>
 
```
int i,j;        //Indici
int maggiore;
int len=digits.Length;
```
Le variabili create ci serviranno successivamente, le prime sono degli indici, abbiamo poi una variabile nella quale inseriremo il prodotto maggiore e a seguire la lunghezza della nostra stringa.
 
</details>

<details>
<summary>Creiamo poi una funzione in grado di controllare se la nostra stringa è composta unicamente da numeri che chiameremo <b><i>CheckNumero</i></b>.</summary>
  
```
public static bool CheckNumero(string digits)
{
  //Dichiarazione variabili
  int i;      //Indice
  int len=digits.Length;
  bool numero=true;       //Variabile di return

  //Scorro la stringa
  for(i=0;i<len;i++){
      if(char.IsNumber(digits[i])==false){
          numero=false;
          break;
      }
  }
  return numero;
}
```
Qui eseguiamo un semplice controllo tramite .IsNumber() per ogni carattere di <b><i>digits</i></b>.
</details>

<details>
<summary>Assegniamo ad una variabile il risultato della funzione <b><i>CheckNumero</i></b>.</summary>
  
 ```
 bool soloNum = CheckNumero(digits);
 ```
 In questo modo in caso non siano presenti soltanto numeri, <b><i>soloNum</i></b> risulterà <i>false</i>.
</details>

<details>
<summary>Eseguiamo un controllo prima di iniziare a lavorare sulla stringa</summary>
  
 ```
if(span>0&&soloNum==true&&digits!=""&&span<=len){
 ```
Qui controlliamo che <b><i>span</i></b> sia maggiore di 0, che siano presenti solo numeri, che digits non sia vuota e che <b><i>span</i></b> non superi la lunghezza della stringa, di modo da essere sicuri di poter andare avanti con l'esercizio.
</details>

<details>
<summary>Riempiamo il vettore dedito ai prodotti</summary>
  
```
//Riempio prodotti di 1
for(i=0;i<=lengmnspan;i++){
  for(j=i;j<i+span;j++){
      prodotti[i]*=Convert.ToInt32(Convert.ToString(digits[j]));
  }
}

//Riempimento con i prodotti
for(i=0;i<=lengmnspan;i++){
  for(j=i;j<i+span;j++){
      prodotti[i]*=Convert.ToInt32(Convert.ToString(digits[j]));
  }
}
```
  Nel primo <i>for</i> riempiamo il vettore di 1, in modo da poter calcolare poi i prodotti nel secondo <i>for</i>. 
</details>

<details>
<summary>Cerchiamo il prodotto maggiore</summary>
  
```
maggiore=prodotti[0];

for(i=1;i<lengmnspan+1;i++){
    if(prodotti[i]>=maggiore){
        maggiore=prodotti[i];
    }
}
```
In questa parte di codice inizialmente assegniamo il contenuto di <b><i>prodotti[0]</i></b> a <b><i>maggiore</i></b>, di modo da avere qualcosa da confrontare quando, nel <i>for</i> successivo andremo a confrontare il resto dei componenti di <b><i>prodotti</i></b> con <b><i>maggiore</i></b>, aggiornando la variabile qualora trovassimo un prodotto più grande.
</details>

<details>
<summary>Aggiungiamo il <i>return</i></summary>
 
```
      return maggiore;
}

if(span==0){
    return 1;
}
else{
    throw new ArgumentException();
}
```
L'ultima cosa che ci rimane da fare è ritornare al programma il prodotto maggiore, chiudendo poi l'<i>if</i> iniziato nel quinto punto. Inseriamo delle condizioni finali per i casi speciali: in caso <b><i>span</i></b> sia uguale a 0 ritorneremo 1 (per richiesta dell'esercizio) altrimenti, in caso questa condizione non fosse vera e la stringa non rispetta le condizioni dell'<i>if</i> prima citato, ritorneremo un <i>ArgumentException()</i>. 
</details>




