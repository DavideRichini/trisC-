using System.ComponentModel;
int[] ln1 = new int[3] { 1, 2, 3 };
int ln1c = 0;
int[] ln2 = new int[3] { 1, 2, 3 };
int ln2c = 0;
int[] ln3 = new int[3] { 1, 2, 3 };
int ln3c = 0;
int[] col1 = new int[3] { 1, 2, 3 };
int col1c = 0;
int[] col2 = new int[3] { 1, 2, 3 };
int col2c = 0;
int[] col3 = new int[3] { 1, 2, 3 };
int col3c = 0;
int[] dia1 = new int[3] { 1, 2, 3 };
int dia1c = 0;
int[] dia2 = new int[3] { 1, 2, 3 };
int dia2c = 0;

int turns = 0;
string cel0 = "0", cel1 = "1", cel2 = "2", cel3 = "3", cel4 = "4", cel5 = "5", cel6 = "6", cel7 = "7", cel8 = "8";
int input;
bool validInput = false;
bool p1 = true;
while (!win(ln1, ln2, ln3, col1, col2, col3, dia1, dia2, turns))
{
    while (!validInput)
    {
        turns++;
        Console.WriteLine($"[{cel0}][{cel1}][{cel2}]\n[{cel3}][{cel4}][{cel5}]\n[{cel6}][{cel7}][{cel8}]");
        input = int.Parse(Console.ReadLine());
        validInput = true;

        switch (input)
        {
            case 0:
                if (cel0 != "0")
                {
                    Console.WriteLine("input non valido");
                    validInput = false;
                    break;
                }
                cel0 = (p1) ? "x" : "o";
                ln1[ln1c] = (p1) ? 0 : 1;
                ln1c++;
                col1[col1c] = (p1) ? 0 : 1;
                col1c++;
                dia1[dia1c] = (p1) ? 0 : 1;
                dia1c++;
                break;
            case 1:
                if (cel1 != "1")
                {
                    Console.WriteLine("input non valido");
                    validInput = false;
                    break;
                }
                cel1 = (p1) ? "x" : "o";
                ln1[ln1c] = (p1) ? 0 : 1;
                ln1c++;
                col2[col2c] = (p1) ? 0 : 1;
                col2c++;
                break;
            case 2:
                if (cel2 != "2")
                {
                    Console.WriteLine("input non valido");
                    validInput = false;
                    break;
                }
                cel2 = (p1) ? "x" : "o";
                ln1[ln1c] = (p1) ? 0 : 1;
                ln1c++;
                col3[col3c] = (p1) ? 0 : 1;
                col3c++;
                dia2[dia2c] = (p1) ? 0 : 1;
                dia2c++;
                break;
            case 3:
                if (cel3 != "3")
                {
                    Console.WriteLine("input non valido");
                    validInput = false;
                    break;
                }
                cel3 = (p1) ? "x" : "o";
                col1[col1c] = (p1) ? 0 : 1;
                col1c++;
                ln2[ln2c] = (p1) ? 0 : 1;
                ln2c++;
                break;
            case 4:
                if (cel4 != "4")
                {
                    Console.WriteLine("input non valido");
                    validInput = false;
                    break;
                }
                cel4 = (p1) ? "x" : "o";
                dia1[dia1c] = (p1) ? 0 : 1;
                dia1c++;
                col2[col2c] = (p1) ? 0 : 1;
                col2c++;
                ln2[ln2c] = (p1) ? 0 : 1;
                ln2c++;
                dia2[dia2c] = (p1) ? 0 : 1;
                dia2c++;
                break;
            case 5:
                if (cel5 != "5")
                {
                    Console.WriteLine("input non valido");
                    validInput = false;
                    break;
                }
                cel5 = (p1) ? "x" : "o";
                col3[col3c] = (p1) ? 0 : 1;
                col3c++;
                ln2[ln2c] = (p1) ? 0 : 1;
                ln2c++;
                break;
            case 6:
                if (cel6 != "6")
                {
                    Console.WriteLine("input non valido");
                    validInput = false;
                    break;
                }
                cel6 = (p1) ? "x" : "o";
                col1[col1c] = (p1) ? 0 : 1;
                col1c++;
                ln3[ln3c] = (p1) ? 0 : 1;
                ln3c++;
                dia2[dia2c] = (p1) ? 0 : 1;
                dia2c++;
                break;
            case 7:
                if (cel7 != "7")
                {
                    Console.WriteLine("input non valido");
                    validInput = false;
                    break;
                }
                cel7 = (p1) ? "x" : "o";
                col2[col2c] = (p1) ? 0 : 1;
                col2c++;
                ln3[ln3c] = (p1) ? 0 : 1;
                ln3c++;
                break;
            case 8:
                if (cel8 != "8")
                {
                    Console.WriteLine("input non valido");
                    validInput = false;
                    break;
                }
                cel8 = (p1) ? "x" : "o";
                dia1[dia1c] = (p1) ? 0 : 1;
                dia1c++;
                col3[col3c] = (p1) ? 0 : 1;
                col3c++;
                ln3[ln3c] = (p1) ? 0 : 1;
                ln3c++;
                break;
        }
        if (validInput)
        {
            p1 = (p1) ? false : true;
        }
        validInput = false;
    }

}



static bool win(int[] ln1, int[] ln2, int[] ln3, int[] col1, int[] col2, int[] col3, int[] dia1, int[] dia2, int turns)
{
    if (turns == 9) return true;
    if (ln1[0] == ln1[1] && ln1[1] == ln1[2]) return true;
    if (ln2[0] == ln2[1] && ln2[1] == ln2[2]) return true;
    if (ln3[0] == ln3[1] && ln3[1] == ln3[2]) return true;
    if (col1[0] == col1[1] && col1[1] == col1[2]) return true;
    if (col2[0] == col2[1] && col2[1] == col2[2]) return true;
    if (col3[0] == col3[1] && col3[1] == col3[2]) return true;
    if (dia1[0] == dia1[1] && dia1[1] == dia1[2]) return true;
    if (dia2[0] == dia2[1] && dia2[1] == dia2[2]) return true;
    return false;
}