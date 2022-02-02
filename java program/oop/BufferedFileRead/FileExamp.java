import java.io.*;
public class FileExamp{
public static void main(String[]args) throws IOException
{
int ch;
BufferedReader bf=new BufferedReader(new FileReader("./file1.txt"));
while((ch=bf.read())!=-1)
{
System.out.println((char)ch);
}
bf.close();
}

}