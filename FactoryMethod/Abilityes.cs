using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern.FactoryMethod
{
    public abstract class Abilityes { 
    }

    public  class Imge :Abilityes { }
    public  class AddFollower : Abilityes { }
    public  class RemoveAccount : Abilityes { }
    public  class UsePhoneNumber : Abilityes { }
    public  class SendSms : Abilityes { }
    public  class ShowViewer : Abilityes { }
    public  class AddInstagramLink : Abilityes { }
    public abstract class Resume { 
    
        List<Abilityes> _Abilityes = new List<Abilityes>();
        public Resume() {
            this.CreateAbilityes();

        }
        public List<Abilityes> Abilityes
        {
            get { return _Abilityes; }
        }
        public abstract void CreateAbilityes();

    }
    public class DemoAccount : Resume
    {
        public override void CreateAbilityes()
        {
            Abilityes.Add(new Imge());
            Abilityes.Add(new RemoveAccount());
            Abilityes.Add(new AddInstagramLink());
         
        }
    }

    public class RealAccount : Resume
    {
        public override void CreateAbilityes()
        {
            Abilityes.Add(new Imge());
            Abilityes.Add(new RemoveAccount());
            Abilityes.Add(new SendSms());
            Abilityes.Add(new ShowViewer());
           
        }
    }





}
