import java. util.Scanner;

class Student{
String name;
float cgpa;
int id;
char section;

public static void main(String[]args)
{
Scanner obj=new Scanner(System.in);

System.out.println("enter your name : ");

String name=obj.nextLine();

System.out.println("enter your cgpa : ");
float cgpa=obj.nextFloat();

System.out.println("enter your id : ");
int id=obj.nextInt();

System.out.println("enter your section: ");
char section=obj.next().charAt(0);

Student s=new Student();
System.out.println("name"+name);
System.out.println("cgpa"+cgpa);
System.out.println("id"+id);
System.out.println("section"+section);


}

}