import java.awt.AWTException;
import java.awt.Dimension;
import java.awt.Robot;
import java.awt.Toolkit;
import java.awt.event.InputEvent;

public class StartInConsole {
    public static void put() {
        try {
            // Create a Robot instance
            Robot robot = new Robot();

            // Get screen dimensions
            Dimension screenSize = Toolkit.getDefaultToolkit().getScreenSize();
            int screenWidth = screenSize.width;
            int screenHeight = screenSize.height;

            // Define the percentage of screen dimensions
            double percentageX = 0.1; // 10%
            double percentageY = 0.95; // 95%

            // Calculate pixel coordinates based on percentages
            int x = (int) (screenWidth * percentageX);
            int y = (int) (screenHeight * percentageY);

            robot.mouseMove(x, y);
            robot.mousePress(InputEvent.BUTTON1_DOWN_MASK);
            robot.mouseRelease(InputEvent.BUTTON1_DOWN_MASK);
        }
        catch (AWTException e) {
            e.printStackTrace();
        }
    }
}