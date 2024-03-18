// Class should depend on interfaces rather than concrete classes

class WiredKeyboard{
    // some properties
}

class WiredMouse{
    // some properties
}
class Macbook{
    private WiredMouse wiredMouse;
    private WiredKeyboard wiredKeyboard;
    Macbook(){
        this.wiredKeyboard = new WiredKeyboard();
        this.wiredMouse = new WiredMouse();
        // here we are creating object of concrete classes, which is wrong
        // suppose we want to enhance our macbook in coming version with bluetooth mouse, we can't update here
    }
}

// correct approach should be like this
class Keyboard{
    // some properties
}

class Mouse{
    // some properties
}
class Macbook{
    private Keyboard keyboard;
    private Mouse mouse;
    Macbook(Keyboard keyboard, Mouse mouse){ // here in constructor if we will pass Wired Keyboard, we will get Wired keyboard and vice versa
        this.keyboard = keyboard;
        this.mouse = mouse;
    }
}