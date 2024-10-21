
int [] v= new int[5];

for(int i = 0 ; i<5;i++){
    Console.Write("skriv ett tal: ");
    int svar = int.Parse(Console.ReadLine());
    v[i]= svar; 
}

for (int i = 4; i>-1;i--){
    Console.Write(v[i]+" ");
}
