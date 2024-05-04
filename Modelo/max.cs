namespace Modelo{

    public static class Maximus{
        public static void Max(double n1, double n2, double n3){
            if(n1>n2&&n1>n3){
                Console.WriteLine(n1 + " é  o maior número");
            }else if(n2>n1&&n2>n3){
                Console.WriteLine(n2 + " é  o maior número");
            }else{
                Console.WriteLine(n3 + " é  o maior número");
            }
        }
    }
}