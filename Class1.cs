using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndBuilderModel
{
    public class Client
    {
        private Packaging _packaging;
        private DeliveryDocument _deliveryDocument;

        public Client(PurchaseFactory factory)
        {
            _packaging = factory.CreatePackaging();
            _deliveryDocument = factory.CreateDeliveryDocument();
        }

        public Packaging ClientPackaging
        {
            get { return _packaging; }
        }

        public DeliveryDocument ClientDocument
        {
            get { return _deliveryDocument; }
        }
    }


    public abstract class PurchaseFactory
    {
        public abstract Packaging CreatePackaging();

        public abstract DeliveryDocument CreateDeliveryDocument();
    }


    public class StandardPurchaseFactory : PurchaseFactory
    {
        public override Packaging CreatePackaging()
        {
            return new StandardPackaging();
        }

        public override DeliveryDocument CreateDeliveryDocument()
        {
            return new PostalLabel();
        }
    }


    public class DelicatePurchaseFactory : PurchaseFactory
    {
        public override Packaging CreatePackaging()
        {
            return new ShockProofPackaging();
        }

        public override DeliveryDocument CreateDeliveryDocument()
        {
            return new CourierManifest();
        }
    }

    public abstract class Packaging { }

    public class StandardPackaging : Packaging { }

    public class ShockProofPackaging : Packaging { }

    public abstract class DeliveryDocument { }

    public class PostalLabel : DeliveryDocument { }

    public class CourierManifest : DeliveryDocument { }
}
