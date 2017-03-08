using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Copy_Models
{
    class Program
    {
        static Items items;
        static XmlSerializer xml;
        static string path = @"C:\Users\wojte\Documents\Visual Studio 2013\Projects\WoW Character Viewer Classic\WoW Character Viewer Classic\Data\";

        static void Main(string[] args)
        {
            CopyHeadModels("ClothHeadItems.xml");
            CopyHeadModels("LeatherHeadItems.xml");
            CopyHeadModels("MailHeadItems.xml");
            CopyHeadModels("PlateHeadItems.xml");
            CopyShoulderModels("ClothShoulderItems.xml");
            CopyShoulderModels("LeatherShoulderItems.xml");
            CopyShoulderModels("MailShoulderItems.xml");
            CopyShoulderModels("PlateShoulderItems.xml");
            CopyWeaponModels("DaggerItems.xml");
            CopyWeaponModels("FistWeaponItems.xml");
            CopyWeaponModels("OneHandedAxeItems.xml");
            CopyWeaponModels("OneHandedMaceItems.xml");
            CopyWeaponModels("OneHandedSwordItems.xml");
            CopyWeaponModels("PolearmItems.xml");
            CopyWeaponModels("StaffItems.xml");
            CopyWeaponModels("TwoHandedAxeItems.xml");
            CopyWeaponModels("TwoHandedMaceItems.xml");
            CopyWeaponModels("TwoHandedSwordItems.xml");
            CopyWeaponModels("BowItems.xml");
            CopyWeaponModels("CrossbowItems.xml");
            CopyWeaponModels("GunItems.xml");
            CopyWeaponModels("ThrownItems.xml");
            CopyWeaponModels("WandItems.xml");
            CopyShieldModels("ShieldItems.xml");
            CopyWeaponModels("HeldInOffHandItems.xml");
            CopyMountModels("MountItems.xml");
        }

        static void CopyHeadModels(string file)
        {
            xml = new XmlSerializer(typeof(Items));
            using(StreamReader reader = new StreamReader(path + file))
            {
                items = (Items)xml.Deserialize(reader);
            }
            foreach(ItemsItem item in items.Item)
            {
                CopyHeadModel(item.Models.Left.Replace(".mdx", "_HuM"));
                CopyHeadModel(item.Models.Left.Replace(".mdx", "_HuF"));
                CopyHeadModel(item.Models.Left.Replace(".mdx", "_OrM"));
                CopyHeadModel(item.Models.Left.Replace(".mdx", "_OrF"));
                CopyHeadModel(item.Models.Left.Replace(".mdx", "_DwM"));
                CopyHeadModel(item.Models.Left.Replace(".mdx", "_DwF"));
                CopyHeadModel(item.Models.Left.Replace(".mdx", "_ScM"));
                CopyHeadModel(item.Models.Left.Replace(".mdx", "_ScF"));
                CopyHeadModel(item.Models.Left.Replace(".mdx", "_NiM"));
                CopyHeadModel(item.Models.Left.Replace(".mdx", "_NiF"));
                CopyHeadModel(item.Models.Left.Replace(".mdx", "_TaM"));
                CopyHeadModel(item.Models.Left.Replace(".mdx", "_TaF"));
                CopyHeadModel(item.Models.Left.Replace(".mdx", "_GnM"));
                CopyHeadModel(item.Models.Left.Replace(".mdx", "_GnF"));
                CopyHeadModel(item.Models.Left.Replace(".mdx", "_TrM"));
                CopyHeadModel(item.Models.Left.Replace(".mdx", "_TrF"));
            }
        }

        static void CopyHeadModel(string model)
        {
            string source = @"G:\MPQ\Item\ObjectComponents\Head\" + model + ".m2";
            string destination = @"C:\Users\wojte\Documents\Visual Studio 2013\Projects\Viewer Tools Classic\M2 to XML\M2 to XML\bin\Release\Head\" + model + ".m2";
            File.Copy(source, destination, true);
            Console.WriteLine(model + " copied");
        }

        static void CopyShoulderModels(string file)
        {
            xml = new XmlSerializer(typeof(Items));
            using(StreamReader reader = new StreamReader(path + file))
            {
                items = (Items)xml.Deserialize(reader);
            }
            foreach(ItemsItem item in items.Item)
            {
                CopyShoulderModel(item.Models.Left.Replace(".mdx", ""));
                CopyShoulderModel(item.Models.Right.Replace(".mdx", ""));
            }
        }

        static void CopyShoulderModel(string model)
        {
            string source = @"G:\MPQ\Item\ObjectComponents\Shoulder\" + model + ".m2";
            string destination = @"C:\Users\wojte\Documents\Visual Studio 2013\Projects\Viewer Tools Classic\M2 to XML\M2 to XML\bin\Release\Shoulder\" + model + ".m2";
            if(File.Exists(source))
            {
                File.Copy(source, destination, true);
                Console.WriteLine(model + " copied");
            }
        }

        static void CopyWeaponModels(string file)
        {
            xml = new XmlSerializer(typeof(Items));
            using(StreamReader reader = new StreamReader(path + file))
            {
                items = (Items)xml.Deserialize(reader);
            }
            foreach(ItemsItem item in items.Item)
            {
                CopyWeaponModel(item.Models.Left.Replace(".mdx", ""));
            }
        }

        static void CopyWeaponModel(string model)
        {
            string source = @"G:\MPQ\Item\ObjectComponents\Weapon\" + model + ".m2";
            string destination = @"C:\Users\wojte\Documents\Visual Studio 2013\Projects\Viewer Tools Classic\M2 to XML\M2 to XML\bin\Release\Weapon\" + model + ".m2";
            if(File.Exists(source))
            {
                File.Copy(source, destination, true);
                Console.WriteLine(model + " copied");
            }
        }

        static void CopyShieldModels(string file)
        {
            xml = new XmlSerializer(typeof(Items));
            using(StreamReader reader = new StreamReader(path + file))
            {
                items = (Items)xml.Deserialize(reader);
            }
            foreach(ItemsItem item in items.Item)
            {
                CopyShieldModel(item.Models.Left.Replace(".mdx", ""));
            }
        }

        static void CopyShieldModel(string model)
        {
            string source = @"G:\MPQ\Item\ObjectComponents\Shield\" + model + ".m2";
            string destination = @"C:\Users\wojte\Documents\Visual Studio 2013\Projects\Viewer Tools Classic\M2 to XML\M2 to XML\bin\Release\Shield\" + model + ".m2";
            if(File.Exists(source))
            {
                File.Copy(source, destination, true);
                Console.WriteLine(model + " copied");
            }
        }

        static void CopyMountModels(string file)
        {
            xml = new XmlSerializer(typeof(Items));
            using(StreamReader reader = new StreamReader(path + file))
            {
                items = (Items)xml.Deserialize(reader);
            }
            foreach(ItemsItem item in items.Item)
            {
                CopyMountModel(item.Models.Left);
            }
        }

        static void CopyMountModel(string model)
        {
            string source = @"G:\MPQ\Creature\" + model + ".m2";
            string destination = @"C:\Users\wojte\Documents\Visual Studio 2013\Projects\Viewer Tools Classic\M2 to XML\M2 to XML\bin\Release\Creature\" + model + ".m2";
            string[] path = destination.Split('\\');
            string directory = destination.Replace("\\" + path.Last(), "");
            if(!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            File.Copy(source, destination, true);
        }
    }
}
