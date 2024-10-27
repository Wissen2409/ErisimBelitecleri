


public class Personel:Insan{


    // sınıflar private olamazlar!!! 



    // Public Access Modifier!! 
    // Public erişim belirteci her üye için söylenebilir!!
    // Metotlar-Prop-Ctor ve Degiskenler access modifier alabilirler
    // Access Modifier : Bir üyeye erişimin nasıl olacağını belirler!! 

    // Public : Her yerden ve her katmandan bu erişim belirteç ile işaretlenmiş üyelere erişlim sağlar!!

    // Public erişim belirteci kullanıyorsanız, yazmış olduğunuz üyeye her yerden erişiebilir!!!
    public void Calis(){

        // Private olan üyeye, private üye ile aynı katmanda olan başka bir üye erişebilir!!!
        Calisma();

    }

    // Private Access Modifier!!
    // Private olan üyeye, kendi katmanı hariç bir bir katmandan hiç kimse erişemez'!!
    // Ancak ,o üyenin olduğu katmandan o üyeye erişebilir!!


    // Eğer, sınıflar harici erişim belirteç yazılmaz ise, default erişim belirteç privatedir!! 

    void Calisma(){

    }
    protected void Protected(){

        // Personel sınıfın kalıtım aldığı Insan sınıfının içerisindeki private üye olan Yasa metodu
        // bu sınıf içerisinde kalıtım yolu ile gelmedi!!!
        //Yasa();
        
        
        
    }
}