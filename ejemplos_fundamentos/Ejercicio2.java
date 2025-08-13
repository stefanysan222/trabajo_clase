
import java.util.Scanner;

public class Ejercicio2 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);


        System.out.println("Introduce tu nombre o vivienda:");
        String nombre = sc.nextLine();

        System.out.println("Ingrese la lectura inicial del mes (en litros): ");
        int lecturaInicial = sc.nextInt();

        System.out.println("Ingrese la lectura final del mes (en litros): ");
        int lecturaFinal = sc.nextInt();

        if (lecturaFinal <= lecturaInicial) {
            System.out.println("ERROR: La lectura final debe ser mayor a la lectura inicial");
        } else {
            int consumo = lecturaFinal - lecturaInicial;

            double tarifaPorLitro = 0.15;
            double costoTotal = consumo * tarifaPorLitro;

            System.out.println("--- Resumen del Consumo ---");
            System.out.println("Usuario: " + nombre);
            System.out.println("Consumo: " + consumo);
            System.out.println("Costo total: $" + costoTotal);
        }
        sc.close();
    }
}
