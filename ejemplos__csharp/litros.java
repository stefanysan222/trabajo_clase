import java.util.Scanner;

public class litros {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        // Tarifa fija por litro
        double tarifaPorLitro = 0.15;

        // 1. Capturar nombre del usuario o vivienda
        System.out.print("Ingrese el nombre del usuario: ");
        String nombreUsuario = sc.nextLine();

        // 2. Capturar lecturas
        System.out.print("Ingrese la lectura inicial del mes (en litros): ");
        double lecturaInicial = sc.nextDouble();

        System.out.print("Ingrese la lectura final del mes (en litros): ");
        double lecturaFinal = sc.nextDouble();

        // 3. Calcular consumo total
        double consumo = lecturaFinal - lecturaInicial;

        // 4. Calcular costo total
        double costoTotal = consumo * tarifaPorLitro;

        // 5. Mostrar resumen
        System.out.println("\n--- Resumen del consumo ---");
        System.out.println("Usuario: " + nombreUsuario);
        System.out.println("Consumo: " + consumo + " litros");
        System.out.printf("Costo total: $%.2f%n", costoTotal);

        sc.close();
    }
}
