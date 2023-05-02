using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{

    //Controllo se ci sono solo numeri
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
    public static long GetLargestProduct(string digits, int span) 
    {
        //Dichiarazione vairabili
        int lengmnspan=digits.Length-span;      //Lunghezzza meno span
        int[] prodotti = new int[lengmnspan+1];     //Vettore contenente i prodotti
        int i,j;        //Indici
        int maggiore;
        int len=digits.Length;
        bool soloNum = CheckNumero(digits);

        //Controllo iniziale
        if(span>0&&soloNum==true&&digits!=""&&span<=len){
            //Riempio prodotti di 1
            for(i=0;i<lengmnspan+1;i++){
                prodotti[i]=1;
            }

            //Riempimento con i prodotti
            for(i=0;i<=lengmnspan;i++){
                for(j=i;j<i+span;j++){
                    prodotti[i]*=Convert.ToInt32(Convert.ToString(digits[j]));
                }
            }

            maggiore=prodotti[0];       //assegno maggiore
            //Ricerca del prodotto maggiore
            for(i=1;i<lengmnspan+1;i++){
                if(prodotti[i]>=maggiore){
                    maggiore=prodotti[i];
                }
            }
            
            return maggiore;
        }

        if(span==0){
            return 1;
        }
        else{
            throw new ArgumentException();
        }
       

    }
}