// if class B is a subtype of class A, 
// then we should be able to replace object of A with B without breaking
// the behaviour of the program
// subclass should extend the capability of parent class and not narrow it down

interface Bike{
    void turnOnEngine();
    void accelerate();
}

class Motorcycle: Bike{
    bool isEngineOn;
    int speed;
    
    public void turnOnEngine(){
        this.isEngineOn = true;
    }

    public void accelerate(){
        this.speed += 10;
    }
}

class BiCycle : Bike{
    public void turnOnEngine(){
        throw new Exception("There is no engine");
        // here we have changed the behaviour
        // as an end user he/she knows if they will turn on the engine , it will actually turn on
        // but in this case we are giving an exception
        // here we are narrowing it down the capability of class Bike(parent class)
        // which violates Liskov substitution principle
    }

    public void accelerate(){

    }
}