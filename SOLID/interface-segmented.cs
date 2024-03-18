// Interface segmented principle
// Interfaces should be such that 
// client should not implement unneccessary function
// they don't need

interface RestrauntEmployee{
    void washDish();
    void serveCustomers();
    void cookFood();
}

class Waiter : RestrauntEmployee{
    public void washDish(){
        // not my job
    }
    public void serveCustomers(){
        // do something
    }
    public void cookFood(){
        // Not my job
    }
}

// the above implementation is not correct

interface WaiterInterface{
    void serveCustomers();
    void takeOrders();
}

class Waiter : WaiterInterface{
    public void serveCustomers(){
        // serve to customer
    }
    public void takeOrders(){
        // take orders
    }
}

interface ChefInterface{
    void cookFood();
    void decideMenus();
}

class Chef : ChefInterface{
    public void cookFood(){
        // cook the food
    }
    public void decideMenus(){
        // decide the menus
    }
}