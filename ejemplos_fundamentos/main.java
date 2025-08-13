import java.util.Scanner;

public class main {
    public static void Main(String[] args) {
        System.out.println("Hola, mundo!");
        
        // Crear Scanner
        Scanner sc = new Scanner(System.in);

        // Captura de datos
        System.out.print("Ingrese su nombre: ");
        String nombre = sc.nextLine();

        System.out.print("Ingrese su edad: ");
        int edad = sc.nextInt();

        System.out.print("Ingrese su altura: ");
        double altura = sc.nextDouble();

        System.out.print("Ingrese su inicial: ");
        char inicial = sc.next().charAt(0);

        System.out.print("¿Eres mayor de edad? (true/false): ");
        boolean esMayor = sc.nextBoolean();

        // Mostrar datos capturados
        System.out.println("\n--- Datos capturados ---");
        System.out.println("Nombre: " + nombre);
        System.out.println("Edad: " + edad);
        System.out.println("Altura: " + altura);
        System.out.println("Inicial: " + inicial);
        System.out.println("Mayor de edad: " + esMayor);

        // Cerrar Scanner
        sc.close();
    }
}
