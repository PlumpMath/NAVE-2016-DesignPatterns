using System;

public class Player {
    private Player() {}
    private static Player instance;
    public static Player Instance {
        get {
            if (instance == null) {
                instance = new Player();
            }
            return instance;
        }
    }
}
