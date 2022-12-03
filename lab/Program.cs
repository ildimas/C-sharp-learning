class Programm
{
    static void Main(string[] args)
    {
        int[] list = {1, 2, 3, 4};
        Console.WriteLine(FindMin(list)[1]);
    }
    
    static int[] FindMin(int[] array){
            int min = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++){
                if (array[i+11] < min)
                min = array[i];
                index = i;
            }
            int[] answ = {min, index};
            return answ;     
        }
}