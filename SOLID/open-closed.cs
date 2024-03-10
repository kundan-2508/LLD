class Marker{
    string name;
    string color;
    int price;
    int year;
    Marker(string name, string color, int price, int year){
        this.color = color;
        this.name = name;
        this.price = price;
        this.year = year;
    }
}

class Invoice{
    private Marker marker;
    private int quantity;
    public Invoice(Marker marker, int quantity)
    {
        this.marker = marker;
        this.quantity = quantity;     
    }
    public int calculateTotal(){
        int total = this.marker.price * this.quantity;
        return total;
    }
}
class InvoiceDao{
    private Invoice invoice;
    public InvoiceDao(Invoice invoice)
    {
        this.invoice = invoice;
    }

    public void saveToDb(){
        // save to database logic here
    }
}

// The above invoice class is same as we wrote in single responsibilty principle
// this is well tested, live on production and handling the traffic as well
// now there is a new requirements , along with saving into database there should be a feature to save into file as well
// one possible solution is we will add one more method of saving into file in the same class like this

class InvoiceDao{
    private Invoice invoice;
    public InvoiceDao(Invoice invoice)
    {
        this.invoice = invoice;
    }

    public void saveToDb(){
        // save to database logic here
    }

    public void saveToFile(){
        // save to file logic here
    }
}

// the above code violates open closed principle as we are modifying already tested class and it is prompts to bugs
// A possible solution is as follows, code is below this line

interface InvoiceDao{
    public void save(Invoice invoice);
}

class DatabaseInvoiceDao : InvoiceDao{
    public override save(Invoice invoice){
        // save to database here
    }
}

class FileInvoiceDao : InvoiceDao{
    public override save(Invoice invoice){
        // save to file here
    }
}

// using above approach in future if some new type of saving requirements come up,
// will simply create a new class and inherit the same interface and override the save method
// an example is given below for saving into browser

class BrowserInvoiceDao : InvoiceDao{
    public override save(Invoice invoice){
        // save into browser
    }
}