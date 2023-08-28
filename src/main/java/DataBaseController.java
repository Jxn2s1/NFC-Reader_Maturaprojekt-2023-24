import java.io.IOException;

public class DataBaseController {
    public static void openController() {
        String exePath = "src/main/resources/NFC-Reader/NFC-Reader/bin/Debug/net6.0-windows/NFC-Reader.exe"; // Replace with the actual path to your .exe file

        try {
            ProcessBuilder processBuilder = new ProcessBuilder(exePath);
            Process process = processBuilder.start();

            // Wait for the process to finish
            int exitCode = process.waitFor();

            System.out.println("Executable finished with exit code: " + exitCode);
        } catch (IOException | InterruptedException e) {
            e.printStackTrace();
        }
    }
}
