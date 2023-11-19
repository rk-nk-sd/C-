int[] array = { 12, 62, 34, 25, 74, 52, 63, 93, 37, 25 };

int n = array.Length;
int find = 25;

int index = 0;

while (index < n) {
    if(array[index] == find) {
        Console.WriteLine(index);
        break;
    }
    index++;
}