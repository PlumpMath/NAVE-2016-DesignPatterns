public class Player {
    protected Player() {}
    private static Player instance = null;
    public static Player Instance() {
        if (instance == null) {
            instance = new Player();
        }
        return instance;
    }
}
