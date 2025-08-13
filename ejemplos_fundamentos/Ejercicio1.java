public class Ejercicio1 {
    public static void main(String[] args) {
        // Ejercicio
        double zapatos = 350000;
        double tenis = 280000;
        double camisetas = 175000;
        double jeans = 200000;

        System.out.println("Se muestran los artículos con precios actuales:");
        System.out.println("1. Zapatos - $350.000");
        System.out.println("2. Tenis - $280.000");
        System.out.println("3. Camisetas - $175.000");
        System.out.println("4. Jeans - $200.000");

        // Precio total
        double precioTotal = zapatos + tenis + camisetas + jeans;
        System.out.println("El precio total de los artículos es: $" + precioTotal);

        // Promedio de venta
        double prom = precioTotal / 4;
        System.out.println("El promedio de venta es: $" + prom);

        // Aumento y disminución
        double aumentoJeans = jeans * (1 + 0.062);
        double disminucionZapatos = zapatos * (1 - 0.008);

        System.out.println("El nuevo valor de los jeans es: $" + aumentoJeans);
        System.out.println("El nuevo valor de los zapatos es: $" + disminucionZapatos);
    }
}
