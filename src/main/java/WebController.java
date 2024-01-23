import java.io.IOException;

public class WebController {
    public static void openController() {
        String exePath = "src/main/webController/RazerPages/webController/bin/Debug/net8.0/webController.exe";

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

