import java.io.file;
import java.io.IOException;

public class CreateFileSpecificpath
{
public static void main(String[]args)
{
try
{
file myObj = new file("E:\\java program\\createfile.txt");
if(myObj.createNewFile())
{
System.out.println("file create : "+myObj.getName());
}
else
{
System.out.println("file already exit");
}
}
catch(IOException e)
{
System.out.println("an error occurred");
e.printStackTrace();
}
}
}