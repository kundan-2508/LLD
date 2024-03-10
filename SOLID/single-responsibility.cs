// Single Resposibility principle
// ==============================
// A class should have one and only reason to change

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

    public void printInvoice(){
        // print the invoice
    }

    public void saveToDb(){
        // save to database
    }
}

// In the above code we have 3 reason to change the Invoice Class
// 1. if we want to change the logic of calculation like later point of time we want to take care of taxes in calculation
// 2. if we want to change the logic of printing invoice
// 3. if we want to change the logic for saving into database
// hence this is not following Single responsibility principle
// A p[ossible solution can be like this, code is below this

// Solution starts here :

// Marker class will be same as above

class Invoice{
    private Marker marker;
    private int quantity;
    public Invoice(Parameters)
    {
        this.marker = marker;
        this.quantity = quantity;
    }

    public int calculateTotal(){
        return this.marker.price * this.quantity;
    }
}

class InvoiceDao{
    private Invoice invoice;
    public InvoiceDao(Invoice invoice)
    {
        this.invoice = invoice;
    }

    public void saveToDb(){
        // save into database here
    }
}

class InvoicePrinter{
    private Invoice invoice;
    public InvoicePrinter(Invoice invoice)
    {
        this.invoice = invoice;
    }

    public void printInvoice(){
        // print the invoice here
    }
}

