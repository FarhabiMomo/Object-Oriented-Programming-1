import java.io.*;
class FileExample{
public static void main(String[]args)throws IOException
{
FileWriter fw=new FileWriter("./file.txt",true);
BufferedWriter bf=new BufferedWriter(fw);
bf.write("computer");
bf.close();

}
}