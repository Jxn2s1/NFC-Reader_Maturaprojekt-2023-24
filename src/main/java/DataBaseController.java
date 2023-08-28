import java.io.IOException;

//Opens the .exe file which serves as a connection to our Database
class DataBaseController {
    public static void openController() {
        String exePath = "src/main/dataBaseController/NFC-Reader/NFC-Reader/bin/Debug/net6.0-windows/NFC-Reader.exe";

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
